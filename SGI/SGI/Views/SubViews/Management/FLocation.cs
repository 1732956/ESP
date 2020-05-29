﻿using SGI.Controller;
using SGI.Model.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SGI.CEnum;

namespace SGI.Views.SubViews.Management
{
    public partial class FLocation : Form
    {
        LocationController LocationController;
        Location mCurrentLocation;
        BindingList<Location> LocationsActive;
        BindingList<Location> LocationsAll;
        BindingList<Location> LocationsInactive;
        public Location currentLocation
        {
            get { return mCurrentLocation; }
            set
            {
                mCurrentLocation = value;
                if (mCurrentLocation != null)
                {
                    RefreshLocationData();
                }
            }
        }
        State mCurrentState;
        State CurrentState
        {
            get { return mCurrentState; }
            set
            {
                mCurrentState = value;
                switch (mCurrentState)
                {
                    case State.VIEW:
                        ucManagementAction1.btnSave.Enabled = false;
                        ucManagementAction1.btnCancel.Enabled = false;
                        ucManagementAction1.btnNew.Enabled = true;
                        ucManagementAction1.btnDelete.Enabled = true;
                        LBLocations.Enabled = true;
                        break;
                    case State.ADD:
                        ucManagementAction1.btnSave.Enabled = true;
                        ucManagementAction1.btnCancel.Enabled = true;
                        ucManagementAction1.btnNew.Enabled = false;
                        ucManagementAction1.btnDelete.Enabled = false;
                        LBLocations.Enabled = false;
                        break;
                    case State.UPDATE:
                        ucManagementAction1.btnSave.Enabled = true;
                        ucManagementAction1.btnCancel.Enabled = true;
                        ucManagementAction1.btnNew.Enabled = false;
                        ucManagementAction1.btnDelete.Enabled = false;
                        LBLocations.Enabled = true;
                        break;
                }
            }
        }
        public FLocation()
        {
            InitializeComponent();
            LocationController = new LocationController();
            CBFilter.Items.Add("Actifs");
            CBFilter.Items.Add("Inactifs");
            CBFilter.Items.Add("Tous");
            CBFilter.SelectedItem = "Actifs";
            GetAllActiveLocations();
            if (currentLocation == null)
                CurrentState = State.ADD;
            else
                CurrentState = State.VIEW;
            ucManagementAction1.btnDelete.Visible = false;
            ucManagementAction1.SaveButtonClicked += UcManagementAction1_SaveButtonClicked;
            ucManagementAction1.NewButtonClicked += UcManagementAction1_NewButtonClicked;
            ucManagementAction1.CancelButtonClicked += UcManagementAction1_CancelButtonClicked;
            CBFilter.SelectedIndexChanged += CBFilter_SelectedIndexChanged;
            if (currentLocation != null)
                ChangeFormEditStatus(true);
        }

        public bool Leave()
        {
            bool canQuit = true;
            if (CurrentState == State.ADD || CurrentState == State.UPDATE)
            {
                DialogResult result = MessageBox.Show("Voulez-vous vraiment quitter? Vous perderez tout vos changements en cours.", "Voulez-vous vraiment quitter?", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                    canQuit = false;
            }
            else
                canQuit = false;
            return canQuit;
        }

        private void CBFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindingList<Location> dataSource = new BindingList<Location>();
            if (CBFilter.Text == "Tous")
            {
                if (LocationsAll.Count == 0)
                    LocationsAll = LocationController.GetAllLocations();
                dataSource = LocationsAll;
            }
            else if (CBFilter.Text == "Actifs")
            {
                if (LocationsActive.Count == 0)
                    LocationsActive = LocationController.GetAllLocationsActive();
                dataSource = LocationsActive;
            }
            else if (CBFilter.Text == "Inactifs")
            {
                if (LocationsInactive.Count == 0)
                    LocationsInactive = LocationController.GetAllLocationsInactive();
                dataSource = LocationsInactive;
            }
            LBLocations.DataBindings.Clear();
            var locations = dataSource;
            LBLocations.DataSource = locations;
            if (locations.Count > 0)
                LBLocations.SelectedIndex = 0;
        }

        private void UcManagementAction1_CancelButtonClicked()
        {
            switch (CurrentState)
            {
                case State.ADD:
                    if (CBFilter.Text == "Tous")
                        LocationsAll.RemoveAt(LocationsAll.Count - 1);
                    else if (CBFilter.Text == "Actifs")
                        LocationsActive.RemoveAt(LocationsActive.Count - 1);
                    else
                        LocationsInactive.RemoveAt(LocationsInactive.Count - 1);

                    if (LBLocations.Items.Count > 0)
                    {
                        LBLocations.SelectedIndex = 0;
                        ChangeFormEditStatus(true);
                        CurrentState = State.VIEW;
                    }
                    else
                        CurrentState = State.ADD;
                    break;
                case State.UPDATE:
                    RefreshLocationData();
                    CurrentState = State.VIEW;
                    break;
            }
        }

        private void UcManagementAction1_NewButtonClicked()
        {
            if (CBFilter.Text == "Tous")
                LocationsAll.Add(new Location());
            else if (CBFilter.Text == "Actifs")
                LocationsActive.Add(new Location());
            else
                LocationsInactive.Add(new Location());
            LBLocations.SelectedIndex = LBLocations.Items.Count - 1;
            ChangeFormEditStatus(false);
            CurrentState = State.ADD;
        }

        private void UcManagementAction1_SaveButtonClicked()
        {
            switch (CurrentState)
            {
                case State.ADD:
                    Save("add", 0, true);
                    break;
                case State.UPDATE:
                    Save("update", currentLocation.LocationId, false);
                    break;
            }
        }

        private void Save(string Action, int LocationId, bool last)
        {
            string errorMessage = CanSave();
            if (errorMessage != "")
                MessageBox.Show(errorMessage, "Impossible de sauvegarder");
            else
            {
                SetLocationData(LocationId);
                bool newLocationWorked = LocationController.EditSingleLocation(currentLocation, Action);
                if (newLocationWorked)
                {
                    MessageBox.Show("Enregistrement effectué");
                    ChangeFormEditStatus(true);
                    CurrentState = State.VIEW;
                }
                else
                    MessageBox.Show("Une erreur est survenue, veuillez réessayer.");
            }
        }

        private string CanSave()
        {
            string returnMessage = "";
            if (TxtName.Text == "")
                returnMessage += "Le nom ne peut pas être nul." + Environment.NewLine;
            if (txtDescription.Text == "")
                returnMessage += "La description ne peut pas être nulle." + Environment.NewLine;
            return returnMessage;
        }

        private void GetAllActiveLocations()
        {
            LBLocations.DisplayMember = "Name";
            LBLocations.ValueMember = "LocationId";
            LocationsActive = LocationController.GetAllLocationsActive();
            LBLocations.DataSource = LocationsActive;
            if (LocationsActive.Count > 0)
                LBLocations.SelectedIndex = 0;
        }

        private void SetLocationData(int locationId)
        {
            if (currentLocation == null)
                currentLocation = new Location(locationId, TxtName.Text, txtDescription.Text, cbActive.Checked);
            currentLocation.LocationId = locationId;
            currentLocation.Name = TxtName.Text;
            currentLocation.Description = txtDescription.Text;
            currentLocation.Active = cbActive.Checked;
        }

        private void RefreshLocationData()
        {
            TxtName.Text = currentLocation.Name;
            txtDescription.Text = currentLocation.Description;
            cbActive.Checked = currentLocation.Active;
        }

        private void ChangeFormEditStatus(bool Editing)
        {
            if (Editing)
            {
                TxtName.TextChanged -= PutInEditMode;
                txtDescription.TextChanged -= PutInEditMode;
                cbActive.CheckedChanged -= PutInEditMode;
                TxtName.TextChanged += PutInEditMode;
                txtDescription.TextChanged += PutInEditMode;
                cbActive.CheckedChanged += PutInEditMode;
            }
            else
            {
                TxtName.TextChanged -= PutInEditMode;
                txtDescription.TextChanged -= PutInEditMode;
                cbActive.CheckedChanged -= PutInEditMode;
            }
        }

        private void PutInEditMode(object sender, EventArgs e)
        {
            CurrentState = State.UPDATE;
        }

        private void LBLocations_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentLocation = (Location)LBLocations.SelectedItem;
            CurrentState = State.VIEW;
           
        }
    }
}
