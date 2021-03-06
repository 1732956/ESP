﻿using System;
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
using static SGI.CEnum;
using System.Drawing.Imaging;
using System.Drawing.Printing;

namespace SGI.Views.SubViews
{
    public partial class FProduct : Form
    {
        ProductContoller Productcontoller;
        CategoryController CategoryController;
        DepartmentController DepartmentController;
        SupplierController SupplierController;
        Product mCurrentProduct;
        State mCurrentState;
        State CurrentState
        {
            get { return mCurrentState; }
            set
            {
                mCurrentState = value;
                switch (mCurrentState)
                {
                    case State.VIEW:
                        ucManagementAction1.btnSave.Enabled = false;
                        ucManagementAction1.btnCancel.Enabled = false;
                        ucManagementAction1.btnNew.Enabled = true;
                        ucManagementAction1.btnDelete.Enabled = true;
                        LBProducts.Enabled = true;
                        break;
                    case State.ADD:
                        ucManagementAction1.btnSave.Enabled = true;
                        ucManagementAction1.btnCancel.Enabled = true;
                        ucManagementAction1.btnNew.Enabled = false;
                        ucManagementAction1.btnDelete.Enabled = false;
                        btn_Print.Enabled = false;
                        LBProducts.Enabled = false;
                        break;
                    case State.UPDATE:
                        ucManagementAction1.btnSave.Enabled = true;
                        ucManagementAction1.btnCancel.Enabled = true;
                        ucManagementAction1.btnNew.Enabled = false;
                        ucManagementAction1.btnDelete.Enabled = false;
                        LBProducts.Enabled = true;
                        break;
                }
            }
        }
        public Product currentProduct
        {
            get { return mCurrentProduct; }
            set
            {
                mCurrentProduct = value;
                if (mCurrentProduct != null)
                {
                    RefreshProductData();
                }
            }
        }
        public FProduct()
        {
            InitializeComponent();
            Productcontoller = new ProductContoller();
            CategoryController = new CategoryController();
            DepartmentController = new DepartmentController();
            SupplierController = new SupplierController();
            CBFilter.Items.Add("Actifs");
            CBFilter.Items.Add("Inactifs");
            CBFilter.Items.Add("Tous");
            CBFilter.SelectedItem = "Actifs";
            GetAllActiveDepartments();
            GetAllActiveCategories();
            GetAllActiveSuppliers();
            GetAllActiveProducts();
            selectDepartments();

            if (currentProduct == null)
                CurrentState = State.ADD;
            else
                CurrentState = State.VIEW;
            ucManagementAction1.btnDelete.Visible = false;
            ucManagementAction1.SaveButtonClicked += UcManagementAction1_SaveButtonClicked;
            ucManagementAction1.NewButtonClicked += UcManagementAction1_NewButtonClicked;
            ucManagementAction1.CancelButtonClicked += UcManagementAction1_CancelButtonClicked;
            CBFilter.SelectedIndexChanged += CBFilter_SelectedIndexChanged;
            if (currentProduct != null)
                ChangeFormEditStatus(true);

 


        }

        public bool Leave()
        {
            bool canQuit = true;
            if(CurrentState == State.ADD || CurrentState == State.UPDATE)
            {
                DialogResult result = MessageBox.Show("Voulez-vous vraiment quitter? Vous perderez tout vos changements en cours.", "Voulez-vous vraiment quitter?", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                    canQuit = false;
            }
            else
                canQuit = false;
            return canQuit;
        }
        private void LBProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentProduct = (Product)LBProducts.SelectedItem;
            CurrentState = State.VIEW;
        }

        private void CBFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Product> dataSource = new List<Product>();
            if (CBFilter.Text == "Tous")
                dataSource = Productcontoller.GetAllProducts(-1);
            else if (CBFilter.Text == "Actifs")
                dataSource = Productcontoller.GetAllProducts(1);
            else if (CBFilter.Text == "Inactifs")
                dataSource = Productcontoller.GetAllProducts(0);
            LBProducts.DataBindings.Clear();
            var products = dataSource;
            LBProducts.DataSource = products;
            if (products.Count > 0)
                LBProducts.SelectedIndex = 0;
        }

        #region Actions
        private void UcManagementAction1_CancelButtonClicked()
        {
            switch (CurrentState)
            {
                case State.ADD:
                    LBProducts.DataBindings.Clear();
                    List<Product> tempoProducts = Productcontoller.GetAllProducts(1);
                    LBProducts.DataSource = tempoProducts;
                    if (tempoProducts.Count > 0)
                    {
                        LBProducts.SelectedIndex = 0;
                        ChangeFormEditStatus(true);
                        CurrentState = State.VIEW;
                    }
                    else
                        CurrentState = State.ADD;
                    break;
                case State.UPDATE:
                    RefreshProductData();
                    CurrentState = State.VIEW;
                    break;
            }
        }

        private void UcManagementAction1_NewButtonClicked()
        {
            List<Product> tempoProducts = Productcontoller.GetAllProducts(1);
            tempoProducts.Add(new Product());
            LBProducts.DataBindings.Clear();
            LBProducts.DataSource = tempoProducts;
            LBProducts.SelectedIndex = LBProducts.Items.Count - 1;
            ChangeFormEditStatus(false);
            CurrentState = State.ADD;
        }

        private void UcManagementAction1_SaveButtonClicked()
        {
            switch (CurrentState)
            {
                case State.ADD:
                    Save("add", 0, true);
                    break;
                case State.UPDATE:
                    Save("update", currentProduct.ProductId, false);
                    break;
            }
        }

        private void Save(string Action, int ProductId, bool last)
        {
            string errorMessage = CanSave();
            if (errorMessage != "")
                MessageBox.Show(errorMessage, "Impossible de sauvegarder");
            else
            {
                SetProductData(ProductId);
                bool newProductWorked = Productcontoller.EditSingleProduct(currentProduct, Action);
                if (newProductWorked)
                {
                    MessageBox.Show("Enregistrement effectué");
                    string currentFilter = CBFilter.Text;
                    int isActiveFilter;
                    if (currentFilter == "Actifs")
                        isActiveFilter = 1;
                    else if (currentFilter == "Inactifs")
                        isActiveFilter = 0;
                    else
                        isActiveFilter = -1;
                    List<Product> tempoProducts = Productcontoller.GetAllProducts(isActiveFilter);
                    if(tempoProducts.Count <= 0)
                    {
                        tempoProducts = Productcontoller.GetAllProducts(1);
                        CBFilter.SelectedIndex = 0;
                    }
                    LBProducts.DataBindings.Clear();
                    LBProducts.DataSource = tempoProducts;
                    if (LBProducts.Items.Count > 0)
                        LBProducts.SelectedIndex = last == true ? LBProducts.Items.Count - 1 : 0;
                    else
                        LBProducts.SelectedIndex = -1;

                    ChangeFormEditStatus(true);
                           CurrentState = State.VIEW;
                }
                else
                    MessageBox.Show("Une erreur est survenue, veuillez réessayer.");
            }
        }

        private string CanSave()
        {
            string returnMessage = "";
            if (TxtName.Text == "")
                returnMessage += "Le nom ne peut pas être nul." + Environment.NewLine;
            if (lst_dep.SelectedItems.Count < 1)
                returnMessage += "Un département doit être sélectionner " + Environment.NewLine;
            if (CBSupplier.SelectedValue == null)
                returnMessage += "Le fournisseur ne peut pas être nul." + Environment.NewLine;
            if (NudMeasuringQty.Value <= 0)
                returnMessage += "La quantité d'unité doit être positive." + Environment.NewLine;
            if (txt_mesure.Text == "")
                returnMessage += "La mesure de l'unité de mesure de peut pas être vide " + Environment.NewLine;
            if (nud_measureqty.Value <= 0)
                returnMessage += "La quantité de l'unité de mesure de peut pas être vide " + Environment.NewLine;
            if (NudMin.Value < 0)
                returnMessage += "La quantité minimum doit être positive." + Environment.NewLine;
            if (nudMax.Value < 0)
                returnMessage += "La quantité maximum doit être positive." + Environment.NewLine;
            if(NudMin.Value > nudMax.Value)
                returnMessage += "La quantité minimum doit être inférieur à la quantité maximum." + Environment.NewLine;
            if (NudPrice.Value <= 0)
                returnMessage += "Le prix doit ne peut pas être nul." + Environment.NewLine;
            if (nudQtyInvOut.Value <= 0)
                returnMessage += "La quantité de sortie d'inventaire ne peut pas être nulle." + Environment.NewLine;
            return returnMessage;
        }
        #endregion

        #region GetData
        private void GetAllActiveProducts()
        {
            LBProducts.DisplayMember = "Name";
            LBProducts.ValueMember = "ProductId";
            var products = Productcontoller.GetAllProducts(1);
            LBProducts.DataSource = products;
            if (products.Count > 0)
                LBProducts.SelectedIndex = 0;
        }

        private void GetAllActiveCategories()
        {
            CbCategory.DisplayMember = "Description";
            CbCategory.ValueMember = "CategoryId";
            CbCategory.DataSource = CategoryController.GetAllActiveCategories();
            CbCategory.SelectedIndex = -1;
        }

        private void GetAllActiveSuppliers()
        {
            CBSupplier.DisplayMember = "Name";
            CBSupplier.ValueMember = "SupplierID";
            CBSupplier.DataSource = SupplierController.GetAllSuppliersActive();
            CBSupplier.SelectedIndex = -1;
        }

        private void GetAllActiveDepartments()
        {
            lst_dep.DisplayMember = "Name";
            lst_dep.ValueMember = "DepartmentId";
            lst_dep.DataSource = DepartmentController.GetAllActiveDepartments();
        }

        private void selectDepartments()
        {
            for (int i = 0; i < lst_dep.Items.Count; i++) 
            {
                Department currentDep = (Department)lst_dep.Items[i];
                if (currentProduct != null && currentProduct.Departments.Any(dId => dId.DepartmentId == currentDep.DepartmentId))
                {
                    lst_dep.SetSelected(i, true);
                }   
                else
                {
                    lst_dep.SetSelected(i, false);
                }
            }
        }



        #endregion

        #region Utils
        private void SetProductData(int productId)
        {
            List<Department> ListDep = new List<Department>();

            for (int i = 0; i < lst_dep.SelectedItems.Count; i++)
            {
                Department currentDep = (Department)lst_dep.SelectedItems[i];
                ListDep.Add(currentDep);
            }

            if (currentProduct == null)
                 currentProduct = new Product(productId, TxtName.Text, TxtBrand.Text, TxtDescription.Text, (Supplier)CBSupplier.SelectedItem, Convert.ToInt32(NudPrice.Value), cbActive.Checked, Convert.ToInt32(NudMeasuringQty.Value), Convert.ToInt32(nudMax.Value), Convert.ToInt32(NudMin.Value), Convert.ToInt64(nudQtyInvOut.Value), (Category)CbCategory.SelectedItem, ListDep, txt_fournisseurcode.Text,txt_mesure.Text, Convert.ToInt32(nud_measureqty.Value));

            currentProduct.ProductId = productId;
            currentProduct.Name = TxtName.Text;
            currentProduct.Brand = TxtBrand.Text;
            currentProduct.Description = TxtDescription.Text;
            currentProduct.Category = (Category)CbCategory.SelectedItem;
            currentProduct.MeasureUnit = txt_mesure.Text;
            currentProduct.MeasureQty = Convert.ToInt32(nud_measureqty.Value);
            currentProduct.Departments = ListDep;
            currentProduct.Supplier = (Supplier)CBSupplier.SelectedItem;
            currentProduct.UnitCount = Convert.ToInt32(NudMeasuringQty.Value);
            currentProduct.Price = Convert.ToInt32(NudPrice.Value);
            currentProduct.Active = cbActive.Checked;
            currentProduct.MinQty = Convert.ToInt32(NudMin.Value);
            currentProduct.MaxQty = Convert.ToInt32(nudMax.Value);
            currentProduct.QtyInventoryOut = Convert.ToInt64(nudQtyInvOut.Value);
            currentProduct.CodeSupplier = txt_fournisseurcode.Text;
        }

        private void ChangeFormEditStatus(bool Editing)
        {
            if (Editing)
            {
                TxtName.TextChanged -= PutInEditMode;
                TxtBrand.TextChanged -= PutInEditMode;
                CbCategory.SelectedIndexChanged -= PutInEditMode;
                lst_dep.SelectedIndexChanged -= PutInEditMode;
                TxtDescription.TextChanged -= PutInEditMode;
                CBSupplier.SelectedIndexChanged -= PutInEditMode;
                NudMeasuringQty.ValueChanged -= PutInEditMode;
                NudPrice.ValueChanged -= PutInEditMode;
                cbActive.CheckedChanged -= PutInEditMode;
                nudMax.ValueChanged -= PutInEditMode;
                NudMin.ValueChanged -= PutInEditMode;
                nudQtyInvOut.ValueChanged -= PutInEditMode;
                txt_fournisseurcode.TextChanged -= PutInEditMode;
                txt_mesure.TextChanged -= PutInEditMode;
                nud_measureqty.ValueChanged -= PutInEditMode;

                TxtName.TextChanged += PutInEditMode;
                TxtBrand.TextChanged += PutInEditMode;
                CbCategory.SelectedIndexChanged += PutInEditMode;
                lst_dep.SelectedIndexChanged += PutInEditMode;
                TxtDescription.TextChanged += PutInEditMode;
                CBSupplier.SelectedIndexChanged += PutInEditMode;
                NudMeasuringQty.ValueChanged += PutInEditMode;
                NudPrice.ValueChanged += PutInEditMode;
                cbActive.CheckedChanged += PutInEditMode;
                nudMax.ValueChanged += PutInEditMode;
                NudMin.ValueChanged += PutInEditMode;
                nudQtyInvOut.ValueChanged += PutInEditMode;
                txt_fournisseurcode.TextChanged += PutInEditMode;
                nud_measureqty.ValueChanged += PutInEditMode;
                txt_mesure.TextChanged += PutInEditMode;
            }
            else
            {
                TxtName.TextChanged -= PutInEditMode;
                TxtBrand.TextChanged -= PutInEditMode;
                CbCategory.SelectedIndexChanged -= PutInEditMode;
                lst_dep.SelectedIndexChanged -= PutInEditMode;
                TxtDescription.TextChanged -= PutInEditMode;
                CBSupplier.SelectedIndexChanged -= PutInEditMode;
                NudMeasuringQty.ValueChanged -= PutInEditMode;
                NudPrice.ValueChanged -= PutInEditMode;
                cbActive.CheckedChanged -= PutInEditMode;
                nudMax.ValueChanged -= PutInEditMode;
                NudMin.ValueChanged -= PutInEditMode;
                nudQtyInvOut.ValueChanged -= PutInEditMode;
                txt_fournisseurcode.TextChanged -= PutInEditMode;
                txt_mesure.TextChanged -= PutInEditMode;
                nud_measureqty.ValueChanged -= PutInEditMode;
            }
        }

        private void PutInEditMode(object sender, EventArgs e)
        {
            CurrentState = State.UPDATE;
        }

        private void RefreshProductData()
        {
            TxtName.Text = currentProduct.Name;
            TxtBrand.Text = currentProduct.Brand;
            TxtDescription.Text = currentProduct.Description;
            CbCategory.SelectedValue = currentProduct.Category.CategoryID;
            selectDepartments();
            CBSupplier.SelectedValue = currentProduct.Supplier.SupplierID;
            NudMeasuringQty.Value = currentProduct.UnitCount;
            NudPrice.Value = Convert.ToDecimal(currentProduct.Price);
            NudMin.Value = currentProduct.MinQty;
            nudMax.Value = currentProduct.MaxQty;
            nudQtyInvOut.Value = (decimal)currentProduct.QtyInventoryOut;
            txt_fournisseurcode.Text = currentProduct.CodeSupplier;
            txt_mesure.Text = currentProduct.MeasureUnit;
            nud_measureqty.Value = currentProduct.MeasureQty;
            if (currentProduct.BarCodeId == "")
            {
                btn_Print.Enabled = false;
                pictureBox2.Enabled = false;
            }
            else
            {
                btn_Print.Enabled = true;
                pictureBox2.Enabled = true;
            }
            TxtLastUpdate.Text = currentProduct.LastUpdate.ToString();
            cbActive.Checked = currentProduct.Active;
            LoadBarCode(currentProduct.BarCodeId);


        }
        #endregion

        #region BarCode
        private void Btn_Print_Click(object sender, EventArgs e)
        {
            PrintDialog pd = new PrintDialog();
            PrintDocument doc = new PrintDocument();
            doc.PrintPage += Doc_PrintPage;
            pd.Document = doc;
            if (pd.ShowDialog() == DialogResult.OK)
            {
                doc.Print();
            }
        }

        private void Doc_PrintPage(object sender, PrintPageEventArgs e)
        {

            Bitmap bm = new Bitmap(pictureBox2.Width, pictureBox2.Height);
            pictureBox2.DrawToBitmap(bm, new Rectangle(0, 0, pictureBox2.Width, pictureBox2.Height));
            e.Graphics.DrawImage(bm, 0, 0);
            bm.Dispose();
        }

        void LoadBarCode(string barCodenbr)
        {

            string barcode = barCodenbr;
            lbl_BarCode.Text = barCodenbr;
            if (barcode != null && barcode.Length > 0)
            {
                GBOBarCode.Visible = true;
                Bitmap bitmap = new Bitmap(barcode.Length * 40, 150);
                using (Graphics graphics = Graphics.FromImage(bitmap))
                {
                    Font oFont = new System.Drawing.Font("IDAHC39M Code 39 Barcode", 20);
                    Font oFontSec = new System.Drawing.Font("Arial", 18);
                    PointF point = new PointF(2f, 50f);
                    PointF Secpoint = new PointF(20f, 2f);
                    SolidBrush black = new SolidBrush(Color.Black);
                    SolidBrush white = new SolidBrush(Color.White);
                    graphics.FillRectangle(white, 0, 0, bitmap.Width, bitmap.Height);
                    graphics.DrawString("*" + barcode + "*", oFont, black, point);
                    graphics.DrawString(currentProduct.Name, oFontSec, black, Secpoint);

                }
                pictureBox2.Image = bitmap;
            }
            else
                GBOBarCode.Visible = false;
        }
        #endregion

        #region QuantityInventoryOut
        private void NudMeasuringQty_Leave(object sender, EventArgs e)
        {
            SetQtyInvOut();
        }

        private void nud_measureqty_Leave(object sender, EventArgs e)
        {
            SetQtyInvOut();
        }

        private void SetQtyInvOut()
        {
            if (CurrentState == State.ADD)
            {
                if (NudMeasuringQty.Value > 0 && nud_measureqty.Value > 0)
                {
                    nudQtyInvOut.Value = (NudMeasuringQty.Value * nud_measureqty.Value);
                }
            }
        }
        #endregion
    }
}
