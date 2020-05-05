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
    public partial class FOrdersToDo : Form
    {
        InventoryController ControllerInv;
        public FOrdersToDo()
        {
            InitializeComponent();
            ControllerInv = new InventoryController();
            GetOrderToDo(dgvOrderToDo);
        }


        private void GetOrderToDo(DataGridView dgvToFill)
        {
            DataTable inv = ControllerInv.GetProductToDo();
            BindingSource SBind = new BindingSource();
            SBind.DataSource = inv;
            dgvToFill.AutoGenerateColumns = false;
            dgvToFill.DataSource = inv;
            dgvToFill.DataSource = SBind;
            dgvToFill.Refresh();
        }
    }
}
