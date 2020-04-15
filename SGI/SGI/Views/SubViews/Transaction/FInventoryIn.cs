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
using SGI.Views.SubViews.Transaction;

namespace SGI.Views.SubViews
{
    public partial class FInventoryIn : Form
    {
        LocationController controllerLoc;
        ProductContoller ControllerProduct;
        InventoryInController ControllerInvIn;
        Product CurrentProduct;
        public FInventoryIn()
        {
            InitializeComponent();
            controllerLoc = new LocationController();
            ControllerProduct = new ProductContoller();
            ControllerInvIn = new InventoryInController();
            GetAllLocationsActive();
        }

        private void FInventoryIn_Load(object sender, EventArgs e)
        {
            txt_produit.Focus();
        }

        private void Txt_produit_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool isAlreadyIn = false;

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (txt_produit.Text == "")
                {
                    MessageBox.Show("Le produit ne peut pas être vide");
                    txt_produit.Focus();
                }
                else
                {
                    CurrentProduct = ControllerProduct.GetSingleProductInfo(txt_produit.Text); 
                    if (CurrentProduct.ProductId == 0)
                    {
                        MessageBox.Show("Le produit est invalide");
                        txt_produit.Focus();
                    }
                    else
                    {
                        DialogResult Result = ProductMessageBox.Show(txt_produit.Text);
                        if(Result == DialogResult.OK) //le produit est accepté
                        {
                            for (int i = 0; i < DGVOrder.Rows.Count; i++)
                            {
                               if (Convert.ToInt32(DGVOrder.Rows[i].Cells[2].Value) == CurrentProduct.ProductId)
                                {
                                    isAlreadyIn = true;
                                    DGVOrder.Rows[i].Cells[1].Value = Convert.ToInt32(DGVOrder.Rows[i].Cells[1].Value) + 1;
                                }
                            }

                            if (isAlreadyIn == false)
                            {
                                DGVOrder.Rows.Add(CurrentProduct.Name, 1, CurrentProduct.ProductId);
                            }

                            btn_deleteCurrentProduct.Enabled = true;
                            btnCancelOrder.Enabled = true;
                            btn_enterInInventory.Enabled = true;
                            cbo_loc.Enabled = false;
                            txt_produit.Text = "";
                            txt_produit.Focus();
                        }
                        else if(Result == DialogResult.Cancel) // le produit est refusé
                        {
                            txt_produit.Text = "";
                            txt_produit.Focus();
                        }
                    }
                } 
            }
        }

        private void Cbo_loc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txt_produit.Focus();
            }
        }

        private void GetAllLocationsActive()
        {
            cbo_loc.DisplayMember = "Name";
            cbo_loc.ValueMember   = "LocationId";
            var locs = controllerLoc.GetAllLocationsActive();
            cbo_loc.DataSource = locs;
            if (locs.Count > 0)
                cbo_loc.SelectedIndex = 0;
        }

        private void Btn_confirm_Click(object sender, EventArgs e)
        {
            bool vError = false;
            for (int i = 0; i < DGVOrder.Rows.Count; i++)
            {
                if(Convert.ToInt32(DGVOrder.Rows[i].Cells[1].Value) <= 0)
                {
                    vError = true;
                }
            }

            if (!vError)
            {
                try
                {
                    if (!vError)
                    {
                        for (int i = 0; i < DGVOrder.Rows.Count; i++)
                        {
                            ControllerInvIn.InventoryIn(Convert.ToInt32(DGVOrder.Rows[i].Cells[2].Value), Convert.ToInt32(DGVOrder.Rows[i].Cells[1].Value), Convert.ToInt32(cbo_loc.SelectedValue));
                        }
                        MessageBox.Show("Inventaire ajouté");
                        FinishOrder();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Erreur lors de l'enregistrement");
                    throw;
                }
            }
            else
            {
                MessageBox.Show("Un ou plusieurs produits de la commande ont une quanité négative ou nulle, veuillez modifier leur quantité et réessayer.");
            }
        }

        private void btnCancelOrder_Click(object sender, EventArgs e)
        {
            FinishOrder();
        }

        private void FinishOrder()
        {
            DGVOrder.Rows.Clear();
            cbo_loc.Enabled = true;
            txt_produit.Text = "";
            btnCancelOrder.Enabled = false;
            btn_deleteCurrentProduct.Enabled = false;
            btn_enterInInventory.Enabled = false;
        }

        private void btn_deleteCurrentProduct_Click(object sender, EventArgs e)
        {
            if(DGVOrder.SelectedRows != null)
            {
                for (int i = 0; i < DGVOrder.SelectedRows.Count; i++)
                {
                    DGVOrder.Rows.Remove(DGVOrder.SelectedRows[i]);
                    if(DGVOrder.Rows.Count == 0)
                    {
                        btn_deleteCurrentProduct.Enabled = false;
                        btnCancelOrder.Enabled = false;
                        btn_enterInInventory.Enabled = false;
                    }
                }
            }
        }
    }
}
