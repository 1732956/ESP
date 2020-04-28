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
    public partial class FCategory : Form
    {
        CategoryController CategoryController;
        Category mCurrentCategory;
        public Category currentCategory
        {
            get { return mCurrentCategory; }
            set
            {
                mCurrentCategory = value;
                if (mCurrentCategory != null)
                {
                    RefreshCategoryData();
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
                        LBCategories.Enabled = true;
                        break;
                    case State.ADD:
                        ucManagementAction1.btnSave.Enabled = true;
                        ucManagementAction1.btnCancel.Enabled = true;
                        ucManagementAction1.btnNew.Enabled = false;
                        ucManagementAction1.btnDelete.Enabled = false;
                        LBCategories.Enabled = false;
                        break;
                    case State.UPDATE:
                        ucManagementAction1.btnSave.Enabled = true;
                        ucManagementAction1.btnCancel.Enabled = true;
                        ucManagementAction1.btnNew.Enabled = false;
                        ucManagementAction1.btnDelete.Enabled = false;
                        LBCategories.Enabled = true;
                        break;
                }
            }
        } 
        public FCategory()
        {
            InitializeComponent();
            CategoryController = new CategoryController();
            CBFilter.Items.Add("Actifs");
            CBFilter.Items.Add("Inactifs");
            CBFilter.Items.Add("Tous");
            CBFilter.SelectedItem = "Actifs";
            GetAllActiveCategories();
            if (currentCategory == null)
                CurrentState = State.ADD;
            else
                CurrentState = State.VIEW;
            ucManagementAction1.btnDelete.Visible = false;
            ucManagementAction1.SaveButtonClicked += UcManagementAction1_SaveButtonClicked;
            ucManagementAction1.NewButtonClicked += UcManagementAction1_NewButtonClicked;
            ucManagementAction1.CancelButtonClicked += UcManagementAction1_CancelButtonClicked;
            CBFilter.SelectedIndexChanged += CBFilter_SelectedIndexChanged;
            if(currentCategory != null)
                ChangeFormEditStatus(true);
        }

        private void CBFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Category> dataSource = new List<Category>();
            if (CBFilter.Text == "Tous")
                dataSource = CategoryController.GetAllCategories();
            else if (CBFilter.Text == "Actifs")
                dataSource = CategoryController.GetAllActiveCategories();
            else if (CBFilter.Text == "Inactifs")
                dataSource = CategoryController.GetAllInactiveCategories();
            LBCategories.DataBindings.Clear();
            var categories = dataSource;
            LBCategories.DataSource = categories;
            if (categories.Count > 0)
                LBCategories.SelectedIndex = 0;
        }

        private void UcManagementAction1_CancelButtonClicked()
        {
            switch (CurrentState)
            {
                case State.ADD:
                    LBCategories.DataBindings.Clear();
                    List<Category> tempoCategories = CategoryController.GetAllActiveCategories();
                    LBCategories.DataSource = tempoCategories;
                    if (tempoCategories.Count > 0)
                    {
                        LBCategories.SelectedIndex = 0;
                        CurrentState = State.VIEW;
                    }
                    else
                        CurrentState = State.ADD;
                    break;
                case State.UPDATE:
                    RefreshCategoryData();
                    CurrentState = State.VIEW;
                    break;
            }
        }

        private void UcManagementAction1_NewButtonClicked()
        {
            List<Category> tempoCategories = CategoryController.GetAllCategories();
            tempoCategories.Add(new Category());
            LBCategories.DataBindings.Clear();
            LBCategories.DataSource = tempoCategories;
            LBCategories.SelectedIndex = LBCategories.Items.Count - 1;
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
                    Save("update", currentCategory.CategoryID, false);
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
                SetCategoryData(CategoryId);
                bool newCategoryWorked = CategoryController.EditSingleCategory(currentCategory, Action);
                if (newCategoryWorked)
                {
                    MessageBox.Show("Enregistrement effectué");
                    string currentFilter = CBFilter.Text;
                    List<Category> tempoCategory = new List<Category>();
                    if (currentFilter == "Actifs")
                        tempoCategory = CategoryController.GetAllActiveCategories();
                    else if (currentFilter == "Inactifs")
                        tempoCategory = CategoryController.GetAllInactiveCategories();
                    else
                        tempoCategory = CategoryController.GetAllCategories();
                    if (tempoCategory.Count <= 0)
                    {
                        tempoCategory = CategoryController.GetAllActiveCategories();
                        CBFilter.SelectedIndex = 0;
                    }
                    LBCategories.DataBindings.Clear();
                    LBCategories.DataSource = tempoCategory;
                    if (LBCategories.Items.Count > 0)
                        LBCategories.SelectedIndex = last == true ? LBCategories.Items.Count - 1 : 0;
                    else
                        LBCategories.SelectedIndex = -1;
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

        private void SetCategoryData(int categoryId)
        {
            if (currentCategory == null)
                currentCategory = new Category(categoryId, TxtName.Text, cbActive.Checked);
            currentCategory.CategoryID = categoryId;
            currentCategory.Description = TxtName.Text;
            currentCategory.Active = cbActive.Checked;
        }

        private void RefreshCategoryData()
        {
            TxtName.Text = currentCategory.Description;
            cbActive.Checked = currentCategory.Active;
        }

        private void GetAllActiveCategories()
        {
            LBCategories.DisplayMember = "Description";
            LBCategories.ValueMember = "CategoryId";
            var categories = CategoryController.GetAllActiveCategories();
            LBCategories.DataSource = categories;
            if (categories.Count > 0)
                LBCategories.SelectedIndex = 0;
        }

        private void ChangeFormEditStatus(bool Editing)
        {
            if (Editing)
            {
                TxtName.TextChanged += PutInEditMode;
                cbActive.CheckedChanged += PutInEditMode;
            }
            else
            {
                TxtName.TextChanged -= PutInEditMode;
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
            currentCategory = (Category)LBCategories.SelectedItem;
            CurrentState = State.VIEW;
        }
    }
}
