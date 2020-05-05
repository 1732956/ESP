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
    public partial class FLocStock : Form
    {
        LocationController controllerLoc;
        InventoryController controllerInv;
        public FLocStock()
        {
            InitializeComponent();
            controllerLoc = new LocationController();
            controllerInv = new InventoryController();
        }

        private void FLocStock_Load(object sender, EventArgs e)
        {
            getAllLocations();
        }

        private void getAllLocations()
        {
            lstLocations.DisplayMember = "Name";
            lstLocations.ValueMember = "LocationId";
            var locs = controllerLoc.GetAllLocationsActive();
            lstLocations.DataSource = locs;
            if (locs.Count > 0)
                lstLocations.SelectedIndex = 0;
        }

        private void lstLocations_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lstLocations.SelectedItem != null)
            {
                Location currentLoc = (Location)lstLocations.SelectedItem;
                DataTable inv = controllerInv.GetLocationStock(currentLoc);
                TotalLocValue.Text = CalculateTotalPrice(inv) + " $";
                BindingSource SBind = new BindingSource();
                SBind.DataSource = inv;
                dgvStockByLoc.AutoGenerateColumns = false;
                dgvStockByLoc.DataSource = inv;
                dgvStockByLoc.DataSource = SBind;
                dgvStockByLoc.Refresh();
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
