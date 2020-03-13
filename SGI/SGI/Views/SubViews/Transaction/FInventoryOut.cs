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

namespace SGI.Views.SubViews
{
    public partial class FInventoryOut : Form
    {

        LocationController controllerLoc;
        ProductContoller ControllerProduct;
        Product CurrentProduct;
        ReasonCodeController ControllerReasonCode;
        InventoryOutController ControllerInvOut;

        public FInventoryOut()
        {
            InitializeComponent();
            controllerLoc        = new LocationController();
            ControllerProduct    = new ProductContoller();
            ControllerReasonCode = new ReasonCodeController();
            ControllerInvOut     = new InventoryOutController();
            GetAllLocationsActive();
            GetAllReasonActive();
        }

        private void Txt_produit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {

                CurrentProduct = ControllerProduct.GetSingleProductInfo(txt_produit.Text);
                if (CurrentProduct.ProductId != 0 && CurrentProduct.ProductId != -1)
                {
                    txt_qte.Visible = true;
                    cbo_loc.Visible = true;
                    lbl_qte.Visible = true;
                    lbl_loc.Visible = true;
                    btn_confirm.Visible = true;
                    grp_product.Visible = true;
                    btn_cancel.Visible = true;
                    txt_productid.Text = CurrentProduct.ProductId.ToString();
                    txt_descr.Text = CurrentProduct.Description;
                    txt_nom.Text = CurrentProduct.Name;
                    txt_marque.Text = CurrentProduct.Brand;
                    txt_cat.Text = CurrentProduct.Category.Description;
                    txt_dep.Text = CurrentProduct.Department.Name;
                    txt_qte.Focus();
                }
                else
                {
                    if (CurrentProduct.ProductId == 0)
                    {
                        MessageBox.Show("Le produit est invalide");
                        ClearScreenProduct();
                    }
                    else
                    {
                        MessageBox.Show("Le produit est inactif");
                        ClearScreenProduct();
                    }

                }
            }
        }

        private void Txt_qte_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btn_confirm.Focus();
            }
        }

        private void GetAllLocationsActive()
        {
            cbo_loc.DisplayMember = "Name";
            cbo_loc.ValueMember = "LocationId";
            var locs = controllerLoc.GetAllLocationsActive();
            cbo_loc.DataSource = locs;
            if (locs.Count > 0)
                cbo_loc.SelectedIndex = 0;
        }


        private void GetAllReasonActive()
        {

           
            cbo_reason.DisplayMember = "Description";
            cbo_reason.ValueMember = "ReasonId";
            var reasons = ControllerReasonCode.GetAllActiveReasonCode();
            cbo_reason.DataSource = reasons;
            if (reasons.Count > 0)
                cbo_loc.SelectedIndex = 0;
        }

        void ClearScreenProduct()
        {
            txt_nom.Text = "";
            txt_produit.Text = "";
            txt_productid.Text = "";
            txt_descr.Text = "";
            txt_nom.Text = "";
            txt_marque.Text = "";
            txt_cat.Text = "";
            txt_dep.Text = "";
            txt_produit.Focus();
        }

        private void Btn_cancel_Click(object sender, EventArgs e)
        {
             ClearScreen();
        }
        void ClearScreen()
        {
            txt_nom.Text = "";
            txt_produit.Text = "";
            txt_qte.Text = "";
            cbo_loc.SelectedIndex = 0;
            txt_productid.Text = "";
            txt_descr.Text = "";
            txt_nom.Text = "";
            txt_marque.Text = "";
            txt_cat.Text = "";
            txt_dep.Text = "";
            txt_qte.Visible = false;
            cbo_loc.Visible = false;
            grp_product.Visible = false;
            lbl_qte.Visible = false;
            lbl_loc.Visible = false;
            btn_confirm.Visible = false;
            btn_cancel.Visible = false;
            cbo_reason.Visible = false;
            lbl_reason.Visible = false;
        }
        private void Txt_produit_Validating(object sender, CancelEventArgs e)
        {
            if (txt_produit.Text == "")
            {
                ClearScreenProduct();
            }
            else
            if (txt_produit.Text != CurrentProduct.BarCodeId)
            {
                CurrentProduct = ControllerProduct.GetSingleProductInfo(txt_produit.Text);
                if (CurrentProduct.ProductId == 0)
                {
                    MessageBox.Show("Le produit est invalide");
                    ClearScreenProduct();
                }
            }
        }

        private void Btn_confirm_Click(object sender, EventArgs e)
        {
            bool vError = false;






            if (txt_produit.Text == "")
            {
                vError = true;
                MessageBox.Show("Le produit ne doit pas être vide");
                txt_produit.Focus();
            }

            if (!vError)
            {
                try
                {
                    Convert.ToInt32(txt_qte.Text);
                }
                catch (Exception)
                {
                    vError = true;
                    MessageBox.Show("La quantité doit être numérique");
                    txt_qte.Text = "";
                    txt_qte.Focus();
                }
            }

            if (!vError)
            {
                if (Convert.ToInt32(txt_qte.Text) <= 0)
                {
                    vError = true;
                    MessageBox.Show("La quantité doit être plus grande que zéro");
                    txt_qte.Text = "";
                    txt_qte.Focus();
                }
            }

            if (!vError)
            {
                try
                {
                    if (!vError)
                    {
                        ControllerInvOut.InventoryOut(Convert.ToInt32(txt_productid.Text), Convert.ToInt32(cbo_reason.SelectedValue), Convert.ToInt32(txt_qte.Text), Convert.ToInt32(cbo_loc.SelectedValue));
                        MessageBox.Show("Inventaire retiré");
                        ClearScreen();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Erreur lors de l'enregistrement");
                    throw;
                }
            }
        }
    }
}
