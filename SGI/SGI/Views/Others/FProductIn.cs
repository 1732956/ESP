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

namespace SGI.Views.SubViews.Transaction
{
    public partial class FProductIn : Form
    {
        ProductContoller productContoller;

        public FProductIn(string ProductBarCode)
        {
            InitializeComponent();
            productContoller = new ProductContoller();
            Product currentProduct = productContoller.GetSingleProductInfo(ProductBarCode);
            productName.Text = currentProduct.Name;
            txtBrand.Text = currentProduct.Brand;
            txtCategory.Text = currentProduct.Category.Description;
            txtPrice.Text = currentProduct.Price.ToString() + " $";
            txtDepartment.Text = currentProduct.Department.Name;
            txtSupplier.Text = currentProduct.Supplier.Name;
            StartTimer();
        }

        private void StartTimer()
        {
            formTimer.Interval = 5000;
            formTimer.Tick += TimerFinished;
            formTimer.Start();
        }

        private void TimerFinished(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {

        }

        private void FProductIn_Load(object sender, EventArgs e)
        {

        }
    }

    public static class ProductMessageBox
    {
        public static DialogResult Show(string ProductBarCode)
        {
            using (var form = new FProductIn(ProductBarCode))
            {
                DialogResult R = form.ShowDialog();
                return R;
            }
        }
    }
}
