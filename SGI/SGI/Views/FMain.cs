using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SGI.Views.SubViews;

namespace SGI
{
    public partial class FMain : Form
    {
        public FMain(bool pDatabaseConnected)
        {
            InitializeComponent();
            if (!pDatabaseConnected)
                MessageBox.Show("Votre connection au serveur ne semble pas fonctionner, veuillez contacter votre administrateur système.", "Erreur connection", MessageBoxButtons.OK);
        }

        #region Utilities
        private void ShowSubForm(Form subForm, Panel parentControl)
        {
            subForm.TopLevel = false;
            subForm.AutoScroll = false;
            parentControl.Controls.Add(subForm);
            subForm.Dock = DockStyle.Fill;
            subForm.Show();
        }
        #endregion

        #region SubFormLoads

        private void TPIn_Enter(object sender, EventArgs e)
        {
            FInventoryIn form = new FInventoryIn();
            ShowSubForm(form, InPanel);
        }

        private void TPOut_Enter(object sender, EventArgs e)
        {
            FInventoryOut form = new FInventoryOut();
            ShowSubForm(form, OutPanel);
        }

        private void TPCategory_Enter(object sender, EventArgs e)
        {
            FCategory form = new FCategory();
            ShowSubForm(form, CategoryPanel);
        }

        private void TPDepartment_Enter(object sender, EventArgs e)
        {
            FDepartment form = new FDepartment();
            ShowSubForm(form, DepartmentPanel);
        }

        private void TPMeasuringUnit_Enter(object sender, EventArgs e)
        {
            FMeasuringUnit form = new FMeasuringUnit();
            ShowSubForm(form, MeasuringUnitPanel);
        }

        private void TPStockByLoc_Enter(object sender, EventArgs e)
        {
            FLocStock form = new FLocStock();
            ShowSubForm(form, LocStcokPanel);
        }

        private void OrdersToDoPanel_Enter(object sender, EventArgs e)
        {
            FOrdersToDo form = new FOrdersToDo();
            ShowSubForm(form, OrdersToDoPanel);
        }

        private void TPItemsTooMuch_Enter(object sender, EventArgs e)
        {
            FItemsTooMuch form = new FItemsTooMuch();
            ShowSubForm(form, ItemsTooMuchPanel);
        }

        #endregion

        private void TCMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (TCMain.SelectedIndex)
            {
                case 1:
                    FProduct form = new FProduct();
                    ShowSubForm(form, ProductPanel);
                    break;
                case 2:
                    FGeneralStock form2 = new FGeneralStock();
                    ShowSubForm(form2, GeneralStockPanel);
                    break;
            }
        }
    }
}
