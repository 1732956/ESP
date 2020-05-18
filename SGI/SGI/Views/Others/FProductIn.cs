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

namespace SGI.Views.SubViews.Transaction
{
    public partial class FProductIn : Form
    {
        ProductContoller productContoller;

        public float InvOutQty
        {
            get { return Convert.ToInt64(nudQtyOut.Value); }
        }

        public FProductIn(string ProductBarCode, InventoryTransactionType type)
        {
            InitializeComponent();
            productContoller = new ProductContoller();
            Product currentProduct = productContoller.GetSingleProductInfo(ProductBarCode);
            productName.Text = currentProduct.Name;
            txtBrand.Text = currentProduct.Brand;
            txtCategory.Text = currentProduct.Category.Description;
            txtPrice.Text = currentProduct.Price.ToString() + " $";
            txtSupplier.Text = currentProduct.Supplier.Name;
            if (type == InventoryTransactionType.OUT)
            {
                lblQtyOut.Visible = true;
                nudQtyOut.Visible = true;
                nudQtyOut.Value = (decimal)currentProduct.QtyInventoryOut;
                this.Text = "Sortie d'inventaire";
                nudQtyOut.Focus();
            }
            else
                this.Text = "Entrée d'inventaire";
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
    }

    public class ProductMessageBox
    {
        FProductIn currentForm;
        public DialogResult Show()
        {
            DialogResult R = currentForm.ShowDialog();
            return R;
        }

        public ProductMessageBox(string ProductBarCode, InventoryTransactionType type)
        {
            currentForm = new FProductIn(ProductBarCode, type);
        }

        public float getQtyOut()
        {
            return currentForm.InvOutQty;
        }
    }
}
