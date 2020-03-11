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
    public partial class FInventoryIn : Form
    {
        LocationController controllerLoc;
        InventoryInController ControllerInvIn;
        ProductContoller ControllerProduct;
        Product CurrentProduct;
        public FInventoryIn()
        {
            InitializeComponent();
            controllerLoc = new LocationController();
            ControllerInvIn = new InventoryInController();
            ControllerProduct = new ProductContoller();
            GetAllLocationsActive();
        }

        private void FInventoryIn_Load(object sender, EventArgs e)
        {
            txt_produit.Focus();
        }

        private void Txt_produit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {

                CurrentProduct = ControllerProduct.GetSingleProductInfo(txt_produit.Text);
                if (CurrentProduct.ProductId != 0 )
                {
                    txt_qte.Visible = true;
                    cbo_loc.Visible = true;
                    lbl_qte.Visible = true;
                    lbl_loc.Visible = true;
                    btn_confirm.Visible = true;
                    grp_product.Visible = true;
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
                    MessageBox.Show("Le produit est invalide");
                    ClearScreen();
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

        private void Cbo_loc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btn_confirm.Focus();
            }
        }
        private void GetAllLocationsActive()
        {

            cbo_loc.DisplayMember = "Name";
            cbo_loc.ValueMember   = "LocationId";
            cbo_loc.DataSource = controllerLoc.GetAllLocationsActive();
            cbo_loc.SelectedIndex = 0;
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
                    txt_qte.Focus();
                }
            }

            if (!vError)
            {
                if (Convert.ToInt32(txt_qte.Text) <= 0)
                {
                    vError = true;
                    MessageBox.Show("La quantité doit être plus grande que zéro");
                    txt_qte.Focus();
                }
            }

            if (!vError)
            {
                try
                {
                    ControllerInvIn.InventoryIn(Convert.ToInt32(txt_productid.Text), Convert.ToInt32(txt_qte.Text), Convert.ToInt32(cbo_loc.SelectedValue));
                    MessageBox.Show("Traitement effectué");
                    ClearScreen();
                }
                catch (Exception)
                {
                    MessageBox.Show("Erreur lors de l'enregistrement");
                    throw;
                }
            }
        }
        void ClearScreen() {
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
        }

    }
}
