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

namespace SGI.Views.SubViews.Transaction
{
    public partial class FInventoryInOut : Form
    {
        LocationController controllerLoc;
        ProductContoller ControllerProduct;
        InventoryInController ControllerInvIn;
        InventoryOutController ControllerInvOut;
        InventoryController ControllerInv;
        Product CurrentProduct;
        public FInventoryInOut()
        {
            InitializeComponent();
            controllerLoc = new LocationController();
            ControllerProduct = new ProductContoller();
            ControllerInvIn = new InventoryInController();
            ControllerInvOut = new InventoryOutController();
            ControllerInv = new InventoryController();
            GetAllLocationsActive();
            GetCurrentInventory(dgvInventory);
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

        private void TCAction_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TCAction.SelectedIndex == 0) //in
            {
                GetCurrentInventory(dgvInventory);
                btnConfirm.Enabled = false;
                btnDelete.Enabled = false;
                btnCancel.Enabled = false;
            }
            else //out
            {
                GetCurrentInventory(dgvInventoryOut);
                btnOutConfirm.Enabled = false;
                btnOutDelete.Enabled = false;
                btnOutCancel.Enabled = false;
            }
            txt_produit.Focus();
        }

        private void txtProduit_KeyPress(object sender, KeyPressEventArgs e)
        {
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
                    else if (cbo_loc.SelectedValue == null)
                    {
                        MessageBox.Show("Veuillez choisir une location");
                        cbo_loc.Focus();
                    }
                    else
                    {
                        DialogResult Result = ProductMessageBox.Show(txt_produit.Text);
                        if (Result == DialogResult.OK) //le produit est accepté
                        {
                            if(TCAction.SelectedIndex == 0)
                            {
                                AddToInMovement();
                            }
                            else
                            {
                                AddToOutMovement();
                            }
                            cbo_loc.Enabled = false;
                            txt_produit.Text = "";
                            txt_produit.Focus();
                        }
                        else if (Result == DialogResult.Cancel) // le produit est refusé
                        {
                            txt_produit.Text = "";
                            txt_produit.Focus();
                        }
                    }
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TCAction.SelectedIndex == 0)
                GetCurrentInventory(dgvInventory);
            else
                GetCurrentInventory(dgvInventoryOut);
            txt_produit.Focus();
        }

        private void GetCurrentInventory(DataGridView dgvToFill)
        {
            Location currentLocation = (Location)cbo_loc.SelectedItem;
            DataTable inv = ControllerInv.GetLocationInventory(currentLocation, dgvToFill.Columns[0].DataPropertyName, dgvToFill.Columns[2].DataPropertyName, dgvToFill.Columns[1].DataPropertyName);
            BindingSource SBind = new BindingSource();
            SBind.DataSource = inv;
            dgvToFill.AutoGenerateColumns = false;
            dgvToFill.DataSource = inv;
            dgvToFill.DataSource = SBind;
            dgvToFill.Refresh();
        }

        #region InventroyIn

        private void AddToInMovement()
        {
            bool isAlreadyIn = false;
            for (int i = 0; i < dgvMovement.Rows.Count; i++)
            {
                if (Convert.ToInt32(dgvMovement.Rows[i].Cells[2].Value) == CurrentProduct.ProductId)
                {
                    isAlreadyIn = true;
                    dgvMovement.Rows[i].Cells[1].Value = Convert.ToInt32(dgvMovement.Rows[i].Cells[1].Value) + 1;
                }
            }

            if (isAlreadyIn == false)
            {
                dgvMovement.Rows.Add(CurrentProduct.Name, 1, CurrentProduct.ProductId);
            }
            btnDelete.Enabled = true;
            btnCancel.Enabled = true;
            btnConfirm.Enabled = true;
        }

        private void FinishInOrder()
        {
            dgvMovement.Rows.Clear();
            cbo_loc.Enabled = true;
            txt_produit.Text = "";
            btnConfirm.Enabled = false;
            btnDelete.Enabled = false;
            btnCancel.Enabled = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvMovement.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Êtes-vous certain de vouloir supprimer ce produit du mouvement?", "Suppression du produit", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    for (int i = 0; i < dgvMovement.SelectedRows.Count; i++)
                    {
                        dgvMovement.Rows.Remove(dgvMovement.SelectedRows[i]);
                        if (dgvMovement.Rows.Count == 0)
                        {
                            btnCancel.Enabled = false;
                            btnConfirm.Enabled = false;
                            btnDelete.Enabled = false;
                        }
                    }
                }
            }
            else
                MessageBox.Show("Impossible de supprimer un produit null, veuillez sélectionner un produit et réessayer", "Sélection nulle");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Êtes-vous certain de vouloir annuler ce mouvement?", "Annulation du mouvement", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                FinishInOrder();
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                bool vError = false;
                for (int i = 0; i < dgvMovement.Rows.Count; i++)
                {
                    if (Convert.ToInt32(dgvMovement.Rows[i].Cells[1].Value) <= 0)
                    {
                        vError = true;
                    }
                }
                if (!vError)
                {
                    if (!vError)
                    {
                        if (MessageBox.Show("Êtes-vous certain de vouloir confirmer ce mouvement d'inventaire", "Confirmation du mouvement", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            for (int i = 0; i < dgvMovement.Rows.Count; i++)
                            {
                                ControllerInvIn.InventoryIn(Convert.ToInt32(dgvMovement.Rows[i].Cells[2].Value), Convert.ToInt32(dgvMovement.Rows[i].Cells[1].Value), Convert.ToInt32(cbo_loc.SelectedValue));
                            }
                            MessageBox.Show("Inventaire ajouté");
                            FinishInOrder();
                            GetCurrentInventory(dgvInventory);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Un ou plusieurs produits de la commande ont une quanité négative ou nulle, veuillez modifier leur quantité et réessayer.");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erreur lors de l'enregistrement");
            }
        }

        #endregion

        #region InventoryOut

        private void AddToOutMovement()
        {
            bool isAlreadyIn = false;
            for (int i = 0; i < dgvOutMovement.Rows.Count; i++)
            {
                if (Convert.ToInt32(dgvOutMovement.Rows[i].Cells[2].Value) == CurrentProduct.ProductId)
                {
                    isAlreadyIn = true;
                    dgvOutMovement.Rows[i].Cells[1].Value = Convert.ToInt32(dgvOutMovement.Rows[i].Cells[1].Value) + 1;
                }
            }

            if (isAlreadyIn == false)
            {
                dgvOutMovement.Rows.Add(CurrentProduct.Name, 1, CurrentProduct.ProductId);
            }
            btnOutDelete.Enabled = true;
            btnOutCancel.Enabled = true;
            btnOutConfirm.Enabled = true;
        }

        private void FinishOutOrder()
        {
            dgvOutMovement.Rows.Clear();
            cbo_loc.Enabled = true;
            txt_produit.Text = "";
            btnOutConfirm.Enabled = false;
            btnOutDelete.Enabled = false;
            btnOutCancel.Enabled = false;
        }

        private void btnOutCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Êtes-vous certain de vouloir annuler ce mouvement?", "Annulation du mouvement", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                FinishOutOrder();
            }
        }

        private void btnOutDelete_Click(object sender, EventArgs e)
        {
            if (dgvOutMovement.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Êtes-vous certain de vouloir supprimer ce produit du mouvement?", "Suppression du produit", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    for (int i = 0; i < dgvOutMovement.SelectedRows.Count; i++)
                    {
                        dgvOutMovement.Rows.Remove(dgvOutMovement.SelectedRows[i]);
                        if (dgvOutMovement.Rows.Count == 0)
                        {
                            btnOutCancel.Enabled = false;
                            btnOutConfirm.Enabled = false;
                            btnOutDelete.Enabled = false;
                        }
                    }
                }
            }
            else
                MessageBox.Show("Impossible de supprimer un produit null, veuillez sélectionner un produit et réessayer", "Sélection nulle");
        }

        private void btnOutConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                bool vError = false;
                for (int i = 0; i < dgvOutMovement.Rows.Count; i++)
                {
                    if (Convert.ToInt32(dgvOutMovement.Rows[i].Cells[1].Value) <= 0)
                    {
                        vError = true;
                    }
                }
                if (!vError)
                {
                    if (!vError)
                    {
                        if (MessageBox.Show("Êtes-vous certain de vouloir confirmer ce mouvement d'inventaire", "Confirmation du mouvement", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            bool AlreadynotEnough = false;
                            for (int i = 0; i < dgvOutMovement.Rows.Count; i++)
                            {
                                if (AlreadynotEnough == false)
                                {
                                    AlreadynotEnough = ControllerInvOut.VerifyQty(Convert.ToInt32(dgvOutMovement.Rows[i].Cells[2].Value), Convert.ToInt32(dgvOutMovement.Rows[i].Cells[1].Value), Convert.ToInt32(cbo_loc.SelectedValue), AlreadynotEnough);
                                }
                            }

                            if (AlreadynotEnough == false)
                            {
                                for (int i = 0; i < dgvOutMovement.Rows.Count; i++)
                                {
                                    ControllerInvOut.InventoryOut(Convert.ToInt32(dgvOutMovement.Rows[i].Cells[2].Value), Convert.ToInt32(dgvOutMovement.Rows[i].Cells[1].Value), Convert.ToInt32(cbo_loc.SelectedValue));
                                }
                                MessageBox.Show("Inventaire déduit");
                                FinishOutOrder();
                                GetCurrentInventory(dgvInventoryOut);
                            }
                            else
                            {
                                MessageBox.Show("Impossible de déduir l'inventaire, vous tentez de supprimer un quantité plus grande que celle en inventaire");
                            }
<<<<<<< HEAD
                            MessageBox.Show("Inventaire diminué");
                            FinishOutOrder();
                            GetCurrentInventory(dgvInventoryOut);
=======
>>>>>>> acbd6f6ae9fc126e4ab97f5bbd773efc3ad6c92b
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Un ou plusieurs produits de la commande ont une quanité négative ou nulle, veuillez modifier leur quantité et réessayer.");
                }
            }
            catch
            {
                MessageBox.Show("Erreur lors de l'enregistrement");
            }
        }

        #endregion

        #region productFocus
        private void dgvMovement_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            txt_produit.Focus();
        }

        private void FInventoryInOut_Shown(object sender, EventArgs e)
        {
            txt_produit.Focus();
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txt_produit.Focus();
            }
        }

        #endregion

    }
}
