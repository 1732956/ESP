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

namespace SGI.Views.SubViews
{
    public partial class FGeneralStock : Form
    {
        ProductContoller controllerProd;
        InventoryController controllerInv;
        public FGeneralStock()
        {
            InitializeComponent();
            controllerProd = new ProductContoller();
            controllerInv = new InventoryController();
        }

        private void FGeneralStock_Load(object sender, EventArgs e)
        {
            getAllProducts();
        }

        private void getAllProducts()
        {
            lstProducts.DisplayMember = "Name";
            lstProducts.ValueMember = "ProductId";
            var prods = controllerProd.GetAllProducts(1);
            lstProducts.DataSource = prods;
            if (prods.Count > 0)
                lstProducts.SelectedIndex = 0;
        }

        private void lstProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstProducts.SelectedItem != null)
            {
                Product currentProd = (Product)lstProducts.SelectedItem;
                DataTable inv = controllerInv.GetLocationProduct(currentProd);
                TotalLocValue.Text = CalculateTotalPrice(inv) + " $";
                BindingSource SBind = new BindingSource();
                SBind.DataSource = inv;
                dgvStockByProduct.AutoGenerateColumns = false;
                dgvStockByProduct.DataSource = inv;
                dgvStockByProduct.DataSource = SBind;
                dgvStockByProduct.Refresh();
            }
        }

        private double CalculateTotalPrice(DataTable invDT)
        {
            double totalPrice = 0;
            foreach (DataRow row in invDT.Rows)
            {
                int Quantity = (int)row["Quantity"];
                double Price = Convert.ToDouble(row["Price"]);
                totalPrice += (Quantity * Price);
            }
            return totalPrice;
        }
    }
}
