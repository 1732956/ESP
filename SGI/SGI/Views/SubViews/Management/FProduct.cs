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
    public partial class FProduct : Form
    {
        ProductContoller Productcontoller;
        CategoryController CategoryController;
        DepartmentController DepartmentController;
        MeasuringUnitController MeasuringUnitController;
        Product mCurrentProduct;
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
                        btn_Print.Enabled = true;
                        break;
                    case State.ADD:
                        ucManagementAction1.btnSave.Enabled = true;
                        ucManagementAction1.btnCancel.Enabled = true;
                        ucManagementAction1.btnNew.Enabled = false;
                        ucManagementAction1.btnDelete.Enabled = false;
                        btn_Print.Enabled = false;
                        break;
                    case State.UPDATE:
                        ucManagementAction1.btnSave.Enabled = true;
                        ucManagementAction1.btnCancel.Enabled = true;
                        ucManagementAction1.btnNew.Enabled = false;
                        ucManagementAction1.btnDelete.Enabled = false;
                        btn_Print.Enabled = true;
                        break;
                    case State.DELETE:
                        ucManagementAction1.btnSave.Enabled = false;
                        ucManagementAction1.btnCancel.Enabled = false;
                        ucManagementAction1.btnNew.Enabled = false;
                        ucManagementAction1.btnDelete.Enabled = false;
                        btn_Print.Enabled = false;
                        break;
                }
            }
        }

        public Product currentProduct
        {
            get { return mCurrentProduct; }
            set
            {
                mCurrentProduct = value;
                if (mCurrentProduct != null)
                {
                    RefreshProductData();
                }
            }
        }
        public FProduct()
        {
            InitializeComponent();
            Productcontoller = new ProductContoller();
            CategoryController = new CategoryController();
            DepartmentController = new DepartmentController();
            MeasuringUnitController = new MeasuringUnitController();
            GetAllActiveDepartments();
            GetAllActiveCategories();
            GetAllActiveMeasuringUnits();
            GetAllActiveProducts();
            CurrentState = State.VIEW;
            ucManagementAction1.SaveButtonClicked += UcManagementAction1_SaveButtonClicked;
            ucManagementAction1.NewButtonClicked += UcManagementAction1_NewButtonClicked;
            ucManagementAction1.CancelButtonClicked += UcManagementAction1_CancelButtonClicked;
            ucManagementAction1.DeleteButtonClicked += UcManagementAction1_DeleteButtonClicked;
            ChangeFormEditStatus(true);
        }

        private void LBProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentProduct = (Product)LBProducts.SelectedItem;
            CurrentState = State.VIEW;
        }

        #region Actions
        private void UcManagementAction1_DeleteButtonClicked()
        {
            DialogResult dr = MessageBox.Show("Êtes-vous certain de vouloir supprimer le produit : " + currentProduct.Name + " ?", "Suppression d'un produit", MessageBoxButtons.YesNo);
            if(dr == DialogResult.Yes)
            {
                bool deletionWorked = Productcontoller.EditSingleProduct(currentProduct, "delete");
                if (deletionWorked)
                {
                    MessageBox.Show("Produit supprimé.");
                    List<Product> tempoProducts = Productcontoller.GetAllActiveProducts();
                    LBProducts.DataBindings.Clear();
                    LBProducts.DataSource = tempoProducts;
                    LBProducts.SelectedIndex = 0;
                    ChangeFormEditStatus(true);
                }
                else
                    MessageBox.Show("Une erreur est survenue, veuillez réessayer.");
            }
        }

        private void UcManagementAction1_CancelButtonClicked()
        {
            switch (CurrentState)
            {
                case State.ADD:
                    LBProducts.DataBindings.Clear();
                    List<Product> tempoProducts = Productcontoller.GetAllActiveProducts();
                    LBProducts.DataSource = tempoProducts;
                    LBProducts.SelectedIndex = 0;
                    RefreshProductData();
                    CurrentState = State.VIEW;
                    break;
                case State.UPDATE:
                    RefreshProductData();
                    CurrentState = State.VIEW;
                    break;
            }
        }

        private void UcManagementAction1_NewButtonClicked()
        {
            List<Product> tempoProducts = Productcontoller.GetAllActiveProducts();
            tempoProducts.Add(new Product());
            LBProducts.DataBindings.Clear();
            LBProducts.DataSource = tempoProducts;
            LBProducts.SelectedIndex = LBProducts.Items.Count - 1;
            RefreshProductData();
            ChangeFormEditStatus(false);
            CurrentState = State.ADD;
        }

        private void UcManagementAction1_SaveButtonClicked()
        {
            switch (CurrentState)
            {
                case State.ADD:
                    Save("add", 0);
                    break;
                case State.UPDATE:
                    Save("update", currentProduct.ProductId);
                    break;
            }
        }

        private void Save(string Action, int ProductId)
        {
            string errorMessage = CanSave();
            if (errorMessage != "")
                MessageBox.Show(errorMessage);
            else
            {
                SetProductData(ProductId);
                bool newProductWorked = Productcontoller.EditSingleProduct(currentProduct, Action);
                if (newProductWorked)
                {
                    MessageBox.Show("Enregistrement effectué");
                    List<Product> tempoProducts = Productcontoller.GetAllActiveProducts();
                    LBProducts.DataBindings.Clear();
                    LBProducts.DataSource = tempoProducts;
                    LBProducts.SelectedIndex = LBProducts.Items.Count - 1;
                    RefreshProductData();
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
                returnMessage += "Le nom ne peut pas être nulle." + Environment.NewLine;
            if (TxtBrand.Text == "")
                returnMessage += "La marque ne peut pas être nulle." + Environment.NewLine;
            if (CbCategory.SelectedValue == null)
                returnMessage += "La catégorie ne peut pas être nulle." + Environment.NewLine;
            if (CbDepartment.SelectedValue == null)
                returnMessage += "Le département ne peut pas être nulle." + Environment.NewLine;
            if (TxtSupplierName.Text == "")
                returnMessage += "Le nom de fournisseur ne peut pas être nulle." + Environment.NewLine;
            if (NudMeasuringQty.Value <= 0)
                returnMessage += "La quantité d'unité doit être positive." + Environment.NewLine;
            if (CBMeasuringUnit.SelectedValue == null)
                returnMessage += "L'unité de mesure ne peut pas être nulle." + Environment.NewLine;
            if(NudMin.Value <= 0)
                returnMessage += "La quantité minimum doit être positive." + Environment.NewLine;
            if (nudMax.Value <= 0)
                returnMessage += "La quantité maximum doit être positive." + Environment.NewLine;
            return returnMessage;
        }
        #endregion

        #region GetData
        private void GetAllActiveProducts()
        {
            LBProducts.DisplayMember = "Name";
            LBProducts.ValueMember = "ProductId";
            LBProducts.DataSource = Productcontoller.GetAllActiveProducts();
            LBProducts.SelectedIndex = 0;
        }

        private void GetAllActiveCategories()
        {
            CbCategory.DisplayMember = "Description";
            CbCategory.ValueMember = "CategoryId";
            CbCategory.DataSource = CategoryController.GetAllActiveCategories();
            CbCategory.SelectedIndex = -1;
        }

        private void GetAllActiveDepartments()
        {
            CbDepartment.DisplayMember = "Name";
            CbDepartment.ValueMember = "DepartmentId";
            CbDepartment.DataSource = DepartmentController.GetAllActiveDepartments();
            CbDepartment.SelectedIndex = -1;
        }

        private void GetAllActiveMeasuringUnits()
        {
            CBMeasuringUnit.DisplayMember = "UnitCode";
            CBMeasuringUnit.ValueMember = "UnitId";
            CBMeasuringUnit.DataSource = MeasuringUnitController.GetAllActiveMeasuringUnits();
            CbDepartment.SelectedIndex = -1;
        }

        #endregion

        #region Utils
        private void SetProductData(int productId)
        {
            currentProduct.ProductId = productId;
            currentProduct.Name = TxtName.Text;
            currentProduct.Brand = TxtBrand.Text;
            currentProduct.Description = TxtDescription.Text;
            currentProduct.Category = (Category)CbCategory.SelectedItem;
            currentProduct.Department = (Department)CbDepartment.SelectedItem;
            currentProduct.Supplier = TxtSupplierName.Text;
            currentProduct.SupplierCode = txtSupplierCode.Text;
            currentProduct.UnitCount = Convert.ToInt32(NudMeasuringQty.Value);
            currentProduct.MeasuringUnit = (MeasuringUnit)CBMeasuringUnit.SelectedItem;
            currentProduct.Price = Convert.ToInt32(NudPrice.Value);
            currentProduct.Active = cbActive.Checked;
            currentProduct.MinQty = Convert.ToInt32(NudMin.Value);
            currentProduct.MaxQty = Convert.ToInt32(nudMax.Value);
        }

        private void ChangeFormEditStatus(bool Editing)
        {
            if (Editing)
            {
                TxtName.TextChanged += PutInEditMode;
                TxtBrand.TextChanged += PutInEditMode;
                CbCategory.SelectedIndexChanged += PutInEditMode;
                CbDepartment.SelectedIndexChanged += PutInEditMode;
                TxtDescription.TextChanged += PutInEditMode;
                TxtSupplierName.TextChanged += PutInEditMode;
                txtSupplierCode.TextChanged += PutInEditMode;
                NudMeasuringQty.ValueChanged += PutInEditMode;
                CBMeasuringUnit.SelectedIndexChanged += PutInEditMode;
                NudPrice.ValueChanged += PutInEditMode;
                cbActive.CheckedChanged += PutInEditMode;
                nudMax.ValueChanged += PutInEditMode;
                NudMin.ValueChanged += PutInEditMode;
            }
            else
            {
                TxtName.TextChanged -= PutInEditMode;
                TxtBrand.TextChanged -= PutInEditMode;
                CbCategory.SelectedIndexChanged -= PutInEditMode;
                CbDepartment.SelectedIndexChanged -= PutInEditMode;
                TxtDescription.TextChanged -= PutInEditMode;
                TxtSupplierName.TextChanged -= PutInEditMode;
                txtSupplierCode.TextChanged -= PutInEditMode;
                NudMeasuringQty.ValueChanged -= PutInEditMode;
                CBMeasuringUnit.SelectedIndexChanged -= PutInEditMode;
                NudPrice.ValueChanged -= PutInEditMode;
                cbActive.CheckedChanged -= PutInEditMode;
                nudMax.ValueChanged -= PutInEditMode;
                NudMin.ValueChanged -= PutInEditMode;
                CurrentState = State.VIEW;
            }
        }

        private void PutInEditMode(object sender, EventArgs e)
        {
            CurrentState = State.UPDATE;
        }

        private void RefreshProductData()
        {
            TxtName.Text = currentProduct.Name;
            TxtBrand.Text = currentProduct.Brand;
            TxtDescription.Text = currentProduct.Description;
            CbCategory.SelectedValue = currentProduct.Category.CategoryID;
            CbDepartment.SelectedValue = currentProduct.Department.DepartmentId;
            TxtSupplierName.Text = currentProduct.Supplier;
            txtSupplierCode.Text = currentProduct.SupplierCode;
            NudMeasuringQty.Value = currentProduct.UnitCount;
            CBMeasuringUnit.SelectedValue = currentProduct.MeasuringUnit.UnitId;
            NudPrice.Value = Convert.ToDecimal(currentProduct.Price);
            txtBarCode.Text = currentProduct.BarCodeId;
            NudMin.Value = currentProduct.MinQty;
            nudMax.Value = currentProduct.MaxQty;
            if (currentProduct.BarCodeId != "")
                btn_Print.Enabled = true;
            TxtLastUpdate.Text = currentProduct.LastUpdate.ToString();
            cbActive.Checked = currentProduct.Active;

        }

        #endregion
    }
}
