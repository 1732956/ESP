using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SGI.Controller;
using SGI.Model.Classes;
using static SGI.CEnum;
using System.Drawing.Imaging;
using System.Drawing.Printing;

namespace SGI.Views.SubViews
{
    public partial class FSupplier : Form
    {
        SupplierController SupplierController;
        Supplier mCurrentSupplier;
        public Supplier currentSupplier
        {
            get { return mCurrentSupplier; }
            set
            {
                mCurrentSupplier = value;
                if (mCurrentSupplier != null)
                {
                    RefreshSupplierData();
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
                        LBSuppliers.Enabled = true;
                        break;
                    case State.ADD:
                        ucManagementAction1.btnSave.Enabled = true;
                        ucManagementAction1.btnCancel.Enabled = true;
                        ucManagementAction1.btnNew.Enabled = false;
                        ucManagementAction1.btnDelete.Enabled = false;
                        LBSuppliers.Enabled = false;
                        break;
                    case State.UPDATE:
                        ucManagementAction1.btnSave.Enabled = true;
                        ucManagementAction1.btnCancel.Enabled = true;
                        ucManagementAction1.btnNew.Enabled = false;
                        ucManagementAction1.btnDelete.Enabled = false;
                        LBSuppliers.Enabled = true;
                        break;
                }
            }
        } 
        public FSupplier()
        {
            InitializeComponent();
            SupplierController = new SupplierController();
            CBFilter.Items.Add("Actifs");
            CBFilter.Items.Add("Inactifs");
            CBFilter.Items.Add("Tous");
            CBFilter.SelectedItem = "Actifs";
            GetAllActiveSuppliers();
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
            List<Supplier> dataSource = new List<Supplier>();
            if (CBFilter.Text == "Tous")
                dataSource = SupplierController.GetAllSuppliers();
            else if (CBFilter.Text == "Actifs")
                dataSource = SupplierController.GetAllSuppliersActive();
            else if (CBFilter.Text == "Inactifs")
                dataSource = SupplierController.GetAllSuppliersInactive();
            LBSuppliers.DataBindings.Clear();
            var suppliers = dataSource;
            LBSuppliers.DataSource = suppliers;
            if (suppliers.Count > 0)
                LBSuppliers.SelectedIndex = 0;
        }

        private void UcManagementAction1_CancelButtonClicked()
        {
            switch (CurrentState)
            {
                case State.ADD:
                    LBSuppliers.DataBindings.Clear();
                    List<Supplier> tempoSuppliers = SupplierController.GetAllSuppliers();
                    LBSuppliers.DataSource = tempoSuppliers;
                    if (tempoSuppliers.Count > 0)
                        LBSuppliers.SelectedIndex = 0;
                    CurrentState = State.VIEW;
                    break;
                case State.UPDATE:
                    RefreshSupplierData();
                    CurrentState = State.VIEW;
                    break;
            }
        }

        private void UcManagementAction1_NewButtonClicked()
        {
            List<Supplier> tempoSuppliers = SupplierController.GetAllSuppliers();
            tempoSuppliers.Add(new Supplier());
            LBSuppliers.DataBindings.Clear();
            LBSuppliers.DataSource = tempoSuppliers;
            LBSuppliers.SelectedIndex = LBSuppliers.Items.Count - 1;
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
                    Save("update", currentSupplier.SupplierID, false);
                    break;
            }
        }

        private void Save(string Action, int SupplierId, bool last)
        {
            string errorMessage = CanSave();
            if (errorMessage != "")
                MessageBox.Show(errorMessage, "Impossible de sauvegarder");
            else
            {
                SetSupplierData(SupplierId);
                bool newSuplierWorked = SupplierController.EditSingleSupplier(currentSupplier, Action);
                if (newSuplierWorked)
                {
                    MessageBox.Show("Enregistrement effectué");
                    string currentFilter = CBFilter.Text;
                    List<Supplier> tempoSupplier = new List<Supplier>();
                    if (currentFilter == "Actifs")
                        tempoSupplier = SupplierController.GetAllSuppliersActive();
                    else if (currentFilter == "Inactifs")
                        tempoSupplier = SupplierController.GetAllSuppliersInactive();
                    else
                        tempoSupplier = SupplierController.GetAllSuppliers();
                    if (tempoSupplier.Count <= 0)
                    {
                        tempoSupplier = SupplierController.GetAllSuppliersActive();
                        CBFilter.SelectedIndex = 0;
                    }
                    LBSuppliers.DataBindings.Clear();
                    LBSuppliers.DataSource = tempoSupplier;
                    if (LBSuppliers.Items.Count > 0)
                        LBSuppliers.SelectedIndex = last == true ? LBSuppliers.Items.Count - 1 : 0;
                    else
                        LBSuppliers.SelectedIndex = -1;
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
            if (txtAdress.Text == "")
                returnMessage += "L'adresse ne peut pas être nulle." + Environment.NewLine;
            if (txtCode.Text == "")
                returnMessage += "Le code ne peut pas être nul." + Environment.NewLine;
            if (txtEmail.Text == "")
                returnMessage += "L'email ne peut pas être nul." + Environment.NewLine;
            if (txtPhoneNumber.Text == "")
                returnMessage += "Le numéro de téléphone ne peut pas être nul." + Environment.NewLine;
            if (txtResourcePerson.Text == "")
                returnMessage += "La personne ressource ne peut pas être nulle." + Environment.NewLine;
            if (nudMinOrderPrice.Value <= 0)
                returnMessage += "Le prix de commande mnimimum ne peut pas être nul ou négatif." + Environment.NewLine;
            return returnMessage;
        }

        private void SetSupplierData(int supplierId)
        {
            currentSupplier.SupplierID = supplierId;
            currentSupplier.Adress = txtAdress.Text;
            currentSupplier.Code = txtCode.Text;
            currentSupplier.Email = txtEmail.Text;
            currentSupplier.MinOrderPrice = Convert.ToDouble(nudMinOrderPrice.Value);
            currentSupplier.Name = TxtName.Text;
            currentSupplier.PhoneNumber = txtPhoneNumber.Text;
            currentSupplier.ResourcePerson = txtResourcePerson.Text;
            currentSupplier.Active = cbActive.Checked;
        }

        private void RefreshSupplierData()
        {
            TxtName.Text = currentSupplier.Name;
            txtAdress.Text = currentSupplier.Adress;
            txtCode.Text = currentSupplier.Code;
            txtEmail.Text = currentSupplier.Email;
            txtPhoneNumber.Text = currentSupplier.PhoneNumber;
            txtResourcePerson.Text = currentSupplier.ResourcePerson;
            nudMinOrderPrice.Value = Convert.ToDecimal(currentSupplier.MinOrderPrice);
            cbActive.Checked = currentSupplier.Active;
        }

        private void GetAllActiveSuppliers()
        {
            LBSuppliers.DisplayMember = "Name";
            LBSuppliers.ValueMember = "SupplierId";
            var suppliers = SupplierController.GetAllSuppliersActive();
            LBSuppliers.DataSource = suppliers;
            if (suppliers.Count > 0)
                LBSuppliers.SelectedIndex = 0;
        }

        private void ChangeFormEditStatus(bool Editing)
        {
            if (Editing)
            {
                TxtName.TextChanged += PutInEditMode;
                txtAdress.TextChanged += PutInEditMode;
                txtCode.TextChanged += PutInEditMode;
                txtEmail.TextChanged += PutInEditMode;
                txtPhoneNumber.TextChanged += PutInEditMode;
                txtResourcePerson.TextChanged += PutInEditMode;
                nudMinOrderPrice.ValueChanged += PutInEditMode;
                cbActive.CheckedChanged += PutInEditMode;
            }
            else
            {
                TxtName.TextChanged -= PutInEditMode;
                txtAdress.TextChanged -= PutInEditMode;
                txtCode.TextChanged -= PutInEditMode;
                txtEmail.TextChanged -= PutInEditMode;
                txtPhoneNumber.TextChanged -= PutInEditMode;
                txtResourcePerson.TextChanged -= PutInEditMode;
                nudMinOrderPrice.ValueChanged -= PutInEditMode;
                cbActive.CheckedChanged -= PutInEditMode;
                CurrentState = State.VIEW;
            }
        }

        private void PutInEditMode(object sender, EventArgs e)
        {
            CurrentState = State.UPDATE;
        }

        private void LBCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentSupplier = (Supplier)LBSuppliers.SelectedItem;
            CurrentState = State.VIEW;
        }
    }
}
