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

namespace SGI.Views.SubViews
{
    public partial class FProduct : Form
    {
        ProductContoller contoller;
        public FProduct()
        {
            InitializeComponent();
            contoller = new ProductContoller();
            GetAllProducts();
        }

        private void GetAllProducts()
        {
            LBProducts.DisplayMember = "Name";
            LBProducts.ValueMember = "ProductId";
            LBProducts.DataSource = contoller.GetAllProducts();
            LBProducts.SelectedIndex = 0;
        }
    }
}
