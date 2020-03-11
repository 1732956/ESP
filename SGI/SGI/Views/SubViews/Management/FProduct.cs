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
        Product mCurrentProduct;
        UCManagementAction UCManagementAction;
        State currentState = State.UPDATE;

        public Product currentProduct
        {
            get { return mCurrentProduct; }
            set
            {
                mCurrentProduct = value;
                if(mCurrentProduct != null)
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
            GetAllActiveDepartments();
            GetAllActiveCategories();
            GetAllProducts();
        }

        #region GetData
        private void GetAllProducts()
        {
            LBProducts.DisplayMember = "Name";
            LBProducts.ValueMember = "ProductId";
            LBProducts.DataSource = Productcontoller.GetAllProducts();
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

        #endregion

        #region Actions

        #endregion

        private void LBProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentProduct = (Product)LBProducts.SelectedItem;
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
            txtMeasuringUnit.Text = currentProduct.MeasuringUnit.UnitCode;
            NudPrice.Value = Convert.ToDecimal(currentProduct.Price);
            txtBarCode.Text = currentProduct.BarCodeId;
            if (currentProduct.BarCodeId != "")
                btn_Print.Enabled = true;
            TxtLastUpdate.Text = currentProduct.LastUpdate.ToString();
            cbActive.Checked = currentProduct.Active;

        }

        private void ucManagementAction1_Load(object sender, EventArgs e)
        {

        }
    }
}
