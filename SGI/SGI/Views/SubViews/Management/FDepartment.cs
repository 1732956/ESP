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

namespace SGI.Views.SubViews
{
    public partial class FDepartment : Form
    {
        DepartmentController DepartmentController;
        Department mCurrentDepartment;
        public Department currentDepartment
        {
            get { return mCurrentDepartment; }
            set
            {
                mCurrentDepartment = value;
                if (mCurrentDepartment != null)
                {
                    RefreshDepartmentData();
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
                        LBDepartments.Enabled = true;
                        break;
                    case State.ADD:
                        ucManagementAction1.btnSave.Enabled = true;
                        ucManagementAction1.btnCancel.Enabled = true;
                        ucManagementAction1.btnNew.Enabled = false;
                        ucManagementAction1.btnDelete.Enabled = false;
                        LBDepartments.Enabled = false;
                        break;
                    case State.UPDATE:
                        ucManagementAction1.btnSave.Enabled = true;
                        ucManagementAction1.btnCancel.Enabled = true;
                        ucManagementAction1.btnNew.Enabled = false;
                        ucManagementAction1.btnDelete.Enabled = false;
                        LBDepartments.Enabled = true;
                        break;
                }
            }
        }
        public FDepartment()
        {
            InitializeComponent();
            DepartmentController = new DepartmentController();
            CBFilter.Items.Add("Actifs");
            CBFilter.Items.Add("Inactifs");
            CBFilter.Items.Add("Tous");
            CBFilter.SelectedItem = "Actifs";
            GetAllActiveDepartments();
            if (currentDepartment == null)
                CurrentState = State.ADD;
            else
                CurrentState = State.VIEW;
            ucManagementAction1.btnDelete.Visible = false;
            ucManagementAction1.SaveButtonClicked += UcManagementAction1_SaveButtonClicked;
            ucManagementAction1.NewButtonClicked += UcManagementAction1_NewButtonClicked;
            ucManagementAction1.CancelButtonClicked += UcManagementAction1_CancelButtonClicked;
            CBFilter.SelectedIndexChanged += CBFilter_SelectedIndexChanged;
            if(currentDepartment != null)
                ChangeFormEditStatus(true);
        }

        private void CBFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Department> dataSource = new List<Department>();
            if (CBFilter.Text == "Tous")
                dataSource = DepartmentController.GetAllDepartments();
            else if (CBFilter.Text == "Actifs")
                dataSource = DepartmentController.GetAllActiveDepartments();
            else if (CBFilter.Text == "Inactifs")
                dataSource = DepartmentController.GetAllInactiveDepartments();
            LBDepartments.DataBindings.Clear();
            var categories = dataSource;
            LBDepartments.DataSource = categories;
            if (categories.Count > 0)
                LBDepartments.SelectedIndex = 0;
        }

        private void UcManagementAction1_CancelButtonClicked()
        {
            switch (CurrentState)
            {
                case State.ADD:
                    LBDepartments.DataBindings.Clear();
                    List<Department> tempoCategories = DepartmentController.GetAllActiveDepartments();
                    LBDepartments.DataSource = tempoCategories;
                    if (tempoCategories.Count > 0)
                    {
                        LBDepartments.SelectedIndex = 0;
                        CurrentState = State.VIEW;
                    }
                    else
                        CurrentState = State.ADD;
                    break;
                case State.UPDATE:
                    RefreshDepartmentData();
                    CurrentState = State.VIEW;
                    break;
            }
        }

        private void UcManagementAction1_NewButtonClicked()
        {
            List<Department> tempoCategories = DepartmentController.GetAllDepartments();
            tempoCategories.Add(new Department());
            LBDepartments.DataBindings.Clear();
            LBDepartments.DataSource = tempoCategories;
            LBDepartments.SelectedIndex = LBDepartments.Items.Count - 1;
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
                    Save("update", currentDepartment.DepartmentId, false);
                    break;
            }
        }

        private void Save(string Action, int CategoryId, bool last)
        {
            string errorMessage = CanSave();
            if (errorMessage != "")
                MessageBox.Show(errorMessage, "Impossible de sauvegarder");
            else
            {
                SetDepartmentData(CategoryId);
                bool newDepartmentWorked = DepartmentController.EditSingleDepartment(currentDepartment, Action);
                if (newDepartmentWorked)
                {
                    MessageBox.Show("Enregistrement effectué");
                    string currentFilter = CBFilter.Text;
                    List<Department> tempoDepartment = new List<Department>();
                    if (currentFilter == "Actifs")
                        tempoDepartment = DepartmentController.GetAllActiveDepartments();
                    else if (currentFilter == "Inactifs")
                        tempoDepartment = DepartmentController.GetAllInactiveDepartments();
                    else
                        tempoDepartment = DepartmentController.GetAllDepartments();
                    if (tempoDepartment.Count <= 0)
                    {
                        tempoDepartment = DepartmentController.GetAllActiveDepartments();
                        CBFilter.SelectedIndex = 0;
                    }
                    LBDepartments.DataBindings.Clear();
                    LBDepartments.DataSource = tempoDepartment;
                    if (LBDepartments.Items.Count > 0)
                        LBDepartments.SelectedIndex = last == true ? LBDepartments.Items.Count - 1 : 0;
                    else
                        LBDepartments.SelectedIndex = -1;
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
         
            return returnMessage;
        }

        private void SetDepartmentData(int departmentId)
        {
            if (currentDepartment == null)
                currentDepartment = new Department(departmentId, TxtName.Text, txtDescription.Text, cbActive.Checked);
            currentDepartment.DepartmentId = departmentId;
            currentDepartment.Name = TxtName.Text;
            currentDepartment.Description = txtDescription.Text;
            currentDepartment.Active = cbActive.Checked;
        }

        private void GetAllActiveDepartments()
        {
            LBDepartments.DisplayMember = "Name";
            LBDepartments.ValueMember = "DepartmentId";
            var departments = DepartmentController.GetAllActiveDepartments();
            LBDepartments.DataSource = departments;
            if (departments.Count > 0)
                LBDepartments.SelectedIndex = 0;
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

        private void RefreshDepartmentData()
        {
            TxtName.Text = currentDepartment.Name;
            txtDescription.Text = currentDepartment.Description;
            cbActive.Checked = currentDepartment.Active;
        }

        private void LBDepartments_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentDepartment = (Department)LBDepartments.SelectedItem;
            CurrentState = State.VIEW;
        }
    }
}
