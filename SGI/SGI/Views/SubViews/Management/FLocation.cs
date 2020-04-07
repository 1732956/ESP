using SGI.Controller;
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
            CurrentState = State.VIEW;
            ucManagementAction1.btnDelete.Visible = false;
            ucManagementAction1.SaveButtonClicked += UcManagementAction1_SaveButtonClicked;
            ucManagementAction1.NewButtonClicked += UcManagementAction1_NewButtonClicked;
            ucManagementAction1.CancelButtonClicked += UcManagementAction1_CancelButtonClicked;
            CBFilter.SelectedIndexChanged += CBFilter_SelectedIndexChanged;
            ChangeFormEditStatus(true);
        }

        private void CBFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Location> dataSource = new List<Location>();
            if (CBFilter.Text == "Tous")
                dataSource = LocationController.GetAllLocations();
            else if (CBFilter.Text == "Actifs")
                dataSource = LocationController.GetAllLocationsActive();
            else if (CBFilter.Text == "Inactifs")
                dataSource = LocationController.GetAllLocationsInactive();
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
                    LBLocations.DataBindings.Clear();
                    List<Location> tempoLocations = LocationController.GetAllLocations();
                    LBLocations.DataSource = tempoLocations;
                    if (tempoLocations.Count > 0)
                        LBLocations.SelectedIndex = 0;
                    CurrentState = State.VIEW;
                    break;
                case State.UPDATE:
                    RefreshLocationData();
                    CurrentState = State.VIEW;
                    break;
            }
        }

        private void UcManagementAction1_NewButtonClicked()
        {
            List<Location> tempoLocations = LocationController.GetAllLocations();
            tempoLocations.Add(new Location());
            LBLocations.DataBindings.Clear();
            LBLocations.DataSource = tempoLocations;
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
                    string currentFilter = CBFilter.Text;
                    List<Location> tempoLocation = new List<Location>();
                    if (currentFilter == "Actifs")
                        tempoLocation = LocationController.GetAllLocationsActive();
                    else if (currentFilter == "Inactifs")
                        tempoLocation = LocationController.GetAllLocationsInactive();
                    else
                        tempoLocation = LocationController.GetAllLocations();
                    if (tempoLocation.Count <= 0)
                    {
                        tempoLocation = LocationController.GetAllLocations();
                        CBFilter.SelectedIndex = 0;
                    }
                    LBLocations.DataBindings.Clear();
                    LBLocations.DataSource = tempoLocation;
                    LBLocations.SelectedIndex = last == true ? LBLocations.Items.Count - 1 : 0;
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
            var locations = LocationController.GetAllLocationsActive();
            LBLocations.DataSource = locations;
            if (locations.Count > 0)
                LBLocations.SelectedIndex = 0;
        }

        private void SetLocationData(int lcoationId)
        {
            currentLocation.LocationId = lcoationId;
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
                TxtName.TextChanged += PutInEditMode;
                txtDescription.TextChanged += PutInEditMode;
                cbActive.CheckedChanged += PutInEditMode;
            }
            else
            {
                TxtName.TextChanged -= PutInEditMode;
                txtDescription.TextChanged -= PutInEditMode;
                cbActive.CheckedChanged -= PutInEditMode;
                CurrentState = State.VIEW;
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
