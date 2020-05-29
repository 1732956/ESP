using SGI.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGI.Views.SubViews.Visualization
{
    public partial class FMovementHistory : Form
    {
        InventoryController controllerInv;
        DataTable log;
        public FMovementHistory()
        {
            InitializeComponent();
            DateToFilter.Value = DateTime.Now;
            DateFromFilter.Value = DateTime.Now.AddMonths(-1);
            controllerInv = new InventoryController();
            log = controllerInv.GetInventoryLog();
            ApplyFilter();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        private void ApplyFilter()
        {
            bool hasAppliedFilter = false;
            DataView dv = new DataView(log);
            if (ProductFilter.Text != "")
            {
                dv.RowFilter = "ProdName LIKE '%" + ProductFilter.Text + "%'";
                hasAppliedFilter = true;
            }
            if (LocationFilter.Text != "")
            {
                string query = "";
                if (hasAppliedFilter)
                    query = " AND ";
                query += "LocName LIKE '%" + LocationFilter.Text + "%'";
                hasAppliedFilter = true;
                dv.RowFilter += query;
            }
            if (QuantityFromFilter.Value != 0)
            {
                string query = "";
                if (hasAppliedFilter)
                    query = " AND ";
                query += "QuantityDelta >= " + QuantityFromFilter.Value;
                hasAppliedFilter = true;
                dv.RowFilter += query;
            }
            if (QuantityToFilter.Value != 0)
            {
                string query = "";
                if (hasAppliedFilter)
                    query = " AND ";
                query += "QuantityDelta <= " + QuantityToFilter.Value;
                hasAppliedFilter = true;
                dv.RowFilter += query;
            }
            if (MovementFilter.SelectedItem != null)
            {
                string query = "";
                if (hasAppliedFilter)
                    query = " AND ";
                query += "Movement = '" + MovementFilter.SelectedItem.ToString() + "'";
                hasAppliedFilter = true;
                dv.RowFilter += query;
            }
            string queryDate = "";
            if (hasAppliedFilter)
                queryDate += " AND";
            queryDate += " Date > #" + DateFromFilter.Value.ToString() + "# AND Date < #" + DateToFilter.Value.ToString() + "#";
            dv.RowFilter += queryDate;
            dgvLog.DataSource = dv;
        }
    }
}
