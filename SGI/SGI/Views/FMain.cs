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
using SGI.Views.SubViews.Integration;
using SGI.Views.SubViews.Management;
using SGI.Views.SubViews.Transaction;

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
        private void FMain_Load(object sender, EventArgs e)
        {
            
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

        private void ClearSubForm(Panel parentControl)
        {
            parentControl.Controls.Clear();
        }
        #endregion

        #region SubFormLoads

        private void TPCategory_Enter(object sender, EventArgs e)
        {
            FCategory form = new FCategory();
            ShowSubForm(form, CategoryPanel);
        }

        private void TPLocation_Enter(object sender, EventArgs e)
        {
            FLocation form = new FLocation();
            ShowSubForm(form, LocationPanel);
        }

        private void TPOrdersToMake_Enter(object sender, EventArgs e)
        {
            FOrdersToDo form = new FOrdersToDo();
            ShowSubForm(form, OrdersToDoPanel);
        }

        private void TPDepartment_Enter(object sender, EventArgs e)
        {
            FDepartment form = new FDepartment();
            ShowSubForm(form, DepartmentPanel);
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

        private void TPStockGeneral_Enter(object sender, EventArgs e)
        {
            if (GeneralStockPanel.Controls.Count == 0)
            {
                FGeneralStock form = new FGeneralStock();
                ShowSubForm(form, GeneralStockPanel);
            }
        }

        private void TPProduct_Enter(object sender, EventArgs e)
        {
            if (ProductPanel.Controls.Count == 0)
            {
                FProduct form = new FProduct();
                ShowSubForm(form, ProductPanel);
            }
        }

        private void TPSupplier_Enter(object sender, EventArgs e)
        {
            if(SupplierPanel.Controls.Count == 0)
            {
                FSupplier form = new FSupplier();
                ShowSubForm(form, SupplierPanel);
            }
        }

        private void TPIntegration_Enter(object sender, EventArgs e)
        {
            FIntegration form = new FIntegration();
            ShowSubForm(form, IntegrationPanel);
        }

        private void TPTransaction_Enter(object sender, EventArgs e)
        {
            FInventoryInOut form = new FInventoryInOut();
            ShowSubForm(form, InventoryInOutPanel);
        }

        #endregion

        #region SubFormClears

        private void TPProduct_Leave(object sender, EventArgs e)
        {
            ClearSubForm(ProductPanel);
        }

        private void TPStockGeneral_Leave(object sender, EventArgs e)
        {
            ClearSubForm(GeneralStockPanel);
        }


        private void TPLocation_Leave(object sender, EventArgs e)
        {
            ClearSubForm(LocationPanel);
        }

        private void TPCategory_Leave(object sender, EventArgs e)
        {
            ClearSubForm(CategoryPanel);
        }

        private void TPDepartment_Leave(object sender, EventArgs e)
        {
            ClearSubForm(DepartmentPanel);
        }

        private void TPStockByLoc_Leave(object sender, EventArgs e)
        {
            ClearSubForm(LocStcokPanel);
        }

        private void TPOrdersToMake_Leave(object sender, EventArgs e)
        {
            ClearSubForm(OrdersToDoPanel);
        }

        private void TPItemsTooMuch_Leave(object sender, EventArgs e)
        {
            ClearSubForm(ItemsTooMuchPanel);
        }

        private void TPSupplier_Leave(object sender, EventArgs e)
        {
            ClearSubForm(SupplierPanel);
        }

        private void TPIntegration_Leave(object sender, EventArgs e)
        {
            ClearSubForm(IntegrationPanel);
        }

        private void TPTransaction_Leave(object sender, EventArgs e)
        {
            ClearSubForm(InventoryInOutPanel);
        }

        #endregion
        private void TCMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(TCMain.SelectedIndex)
            {
                case 0: //transactions
                    
                    break;
                case 1: //gestion
                    TCManagement.SelectedIndex = -1;
                    break;
                case 2: //visualisation
                    TCVisuzalization.SelectedIndex = -1;
                    break;
            }
        }
    }
}
