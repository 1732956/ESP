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
using SGI.Views.SubViews.Visualization;

namespace SGI
{
    public partial class FMain : Form
    {
        FInventoryInOut fInventoryInOut;
        FProduct fProduct;
        FLocation fLocation;
        FSupplier fSupplier;
        FCategory fCategory;
        FDepartment fDepartment;
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

        private void ClearSubForm(Panel parentControl)
        {
            parentControl.Controls.Clear();
        }
        #endregion

        #region SubFormLoads

        private void TPCategory_Enter(object sender, EventArgs e)
        {
            fCategory = new FCategory();
            ShowSubForm(fCategory, CategoryPanel);
        }

        private void TPLocation_Enter(object sender, EventArgs e)
        {
            fLocation = new FLocation();
            ShowSubForm(fLocation, LocationPanel);
        }

        private void TPTransactionHistory_Enter(object sender, EventArgs e)
        {
            FMovementHistory form = new FMovementHistory();
            ShowSubForm(form, MovementHistoryPanel);
        }

        private void TPOrdersToMake_Enter(object sender, EventArgs e)
        {
            FOrdersToDo form = new FOrdersToDo();
            ShowSubForm(form, OrdersToDoPanel);
        }

        private void TPDepartment_Enter(object sender, EventArgs e)
        {
            fDepartment = new FDepartment();
            ShowSubForm(fDepartment, DepartmentPanel);
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
                fProduct = new FProduct();
                ShowSubForm(fProduct, ProductPanel);
            }
        }

        private void TPSupplier_Enter(object sender, EventArgs e)
        {
            if(SupplierPanel.Controls.Count == 0)
            {
                fSupplier = new FSupplier();
                ShowSubForm(fSupplier, SupplierPanel);
            }
        }

        private void TPIntegration_Enter(object sender, EventArgs e)
        {
            FIntegration form = new FIntegration();
            ShowSubForm(form, IntegrationPanel);
        }

        private void TPTransaction_Enter(object sender, EventArgs e)
        {
            fInventoryInOut = new FInventoryInOut();
            ShowSubForm(fInventoryInOut, InventoryInOutPanel);
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

        private void TPTransactionHistory_Leave(object sender, EventArgs e)
        {
            ClearSubForm(MovementHistoryPanel);
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

        private void TCMain_Deselecting(object sender, TabControlCancelEventArgs e)
        {
            if(e.TabPageIndex == 0) //transaction
            {
                e.Cancel = fInventoryInOut.Leave();
            }
        }

        private void TCManagement_Deselecting(object sender, TabControlCancelEventArgs e)
        {
            switch (e.TabPageIndex)
            {
                case 0: //produit
                    e.Cancel = fProduct.Leave();
                    break;
                case 1: //localisation
                    e.Cancel = fLocation.Leave();
                    break;
                case 2: //fournisseur
                    e.Cancel = fSupplier.Leave();
                    break;
                case 3: //catégorie
                    e.Cancel = fCategory.Leave();
                    break;
                case 4://département
                    e.Cancel = fDepartment.Leave();
                    break;
            }
        }
    }
}
