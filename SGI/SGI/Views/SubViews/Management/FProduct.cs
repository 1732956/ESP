using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KeepAutomation.Barcode.Bean;
using SGI.Controller;
using SGI.Model.Classes;
using static SGI.CEnum;
using System.Drawing.Imaging;
using System.Drawing.Printing;

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
            if (currentProduct.BarCodeId != "")
                btn_Print.Enabled = true;
            TxtLastUpdate.Text = currentProduct.LastUpdate.ToString();
            cbActive.Checked = currentProduct.Active;
            LoadBarCode(currentProduct.BarCodeId);

        }

        private void Btn_Print_Click(object sender, EventArgs e)
        {
            PrintDialog pd = new PrintDialog();
            PrintDocument doc = new PrintDocument();
            doc.PrintPage += Doc_PrintPage;
            pd.Document = doc;
            if (pd.ShowDialog() == DialogResult.OK)
            {
                doc.Print();
            }
        }

        private void Doc_PrintPage(object sender, PrintPageEventArgs e)
        {

            Bitmap bm = new Bitmap(pictureBox2.Width, pictureBox2.Height);
            pictureBox2.DrawToBitmap(bm, new Rectangle(0, 0, pictureBox2.Width, pictureBox2.Height));
            e.Graphics.DrawImage(bm, 0, 0);
            bm.Dispose();
        }

        void LoadBarCode(string barCodenbr)
        {

            string barcode = barCodenbr;
            lbl_BarCode.Text = barCodenbr;
            Bitmap bitmap = new Bitmap(barcode.Length * 40, 150);
            using (Graphics graphics = Graphics.FromImage(bitmap))
            {

                Font oFont = new System.Drawing.Font("IDAHC39M Code 39 Barcode", 20);
                PointF point = new PointF(2f, 2f);
                SolidBrush black = new SolidBrush(Color.Black);
                SolidBrush white = new SolidBrush(Color.White);
                graphics.FillRectangle(white, 0, 0, bitmap.Width, bitmap.Height);
                graphics.DrawString("*" + barcode + "*", oFont, black, point);
            }

            pictureBox2.Image = bitmap;
            //pictureBox2.Height  = bitmap.Height;
            //pictureBox2.Width = bitmap.Width;
        }

    }
}
