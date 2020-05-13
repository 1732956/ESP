namespace SGI.Views.SubViews
{
    partial class FProduct
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FProduct));
            this.LBProducts = new System.Windows.Forms.ListBox();
            this.GBProduct = new System.Windows.Forms.GroupBox();
            this.lst_dep = new System.Windows.Forms.ListBox();
            this.TxtDescription = new System.Windows.Forms.TextBox();
            this.LblDepartment = new System.Windows.Forms.Label();
            this.CbCategory = new System.Windows.Forms.ComboBox();
            this.TxtBrand = new System.Windows.Forms.TextBox();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.LblCategory = new System.Windows.Forms.Label();
            this.LblDescription = new System.Windows.Forms.Label();
            this.LblBrand = new System.Windows.Forms.Label();
            this.LblName = new System.Windows.Forms.Label();
            this.GBSupplier = new System.Windows.Forms.GroupBox();
            this.nud_measureqty = new System.Windows.Forms.NumericUpDown();
            this.txt_mesure = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_fournisseurcode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CBSupplier = new System.Windows.Forms.ComboBox();
            this.NudPrice = new System.Windows.Forms.NumericUpDown();
            this.NudMeasuringQty = new System.Windows.Forms.NumericUpDown();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblQuantityUnit = new System.Windows.Forms.Label();
            this.lblSupplierName = new System.Windows.Forms.Label();
            this.lbl_BarCode = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_Print = new System.Windows.Forms.Button();
            this.GBOther = new System.Windows.Forms.GroupBox();
            this.TxtLastUpdate = new System.Windows.Forms.TextBox();
            this.LblLastUpdate = new System.Windows.Forms.Label();
            this.cbActive = new System.Windows.Forms.CheckBox();
            this.ActionPanel = new System.Windows.Forms.Panel();
            this.ToolTips = new System.Windows.Forms.ToolTip(this.components);
            this.GBInventory = new System.Windows.Forms.GroupBox();
            this.GBOBarCode = new System.Windows.Forms.GroupBox();
            this.nudMax = new System.Windows.Forms.NumericUpDown();
            this.NudMin = new System.Windows.Forms.NumericUpDown();
            this.lblMaxQty = new System.Windows.Forms.Label();
            this.lblQtyMin = new System.Windows.Forms.Label();
            this.GBFilter = new System.Windows.Forms.GroupBox();
            this.CBFilter = new System.Windows.Forms.ComboBox();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.nudQtyInvOut = new System.Windows.Forms.NumericUpDown();
            this.lblQtyInvOut = new System.Windows.Forms.Label();
            this.ucManagementAction1 = new SGI.Views.UCManagementAction();
            this.GBProduct.SuspendLayout();
            this.GBSupplier.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_measureqty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudMeasuringQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.GBOther.SuspendLayout();
            this.ActionPanel.SuspendLayout();
            this.GBInventory.SuspendLayout();
            this.GBOBarCode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudMin)).BeginInit();
            this.GBFilter.SuspendLayout();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQtyInvOut)).BeginInit();
            this.SuspendLayout();
            // 
            // LBProducts
            // 
            this.LBProducts.Dock = System.Windows.Forms.DockStyle.Left;
            this.LBProducts.FormattingEnabled = true;
            this.LBProducts.ItemHeight = 17;
            this.LBProducts.Location = new System.Drawing.Point(0, 53);
            this.LBProducts.Name = "LBProducts";
            this.LBProducts.Size = new System.Drawing.Size(238, 845);
            this.LBProducts.TabIndex = 0;
            this.LBProducts.SelectedIndexChanged += new System.EventHandler(this.LBProducts_SelectedIndexChanged);
            // 
            // GBProduct
            // 
            this.GBProduct.AutoSize = true;
            this.GBProduct.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.GBProduct.Controls.Add(this.lst_dep);
            this.GBProduct.Controls.Add(this.TxtDescription);
            this.GBProduct.Controls.Add(this.LblDepartment);
            this.GBProduct.Controls.Add(this.CbCategory);
            this.GBProduct.Controls.Add(this.TxtBrand);
            this.GBProduct.Controls.Add(this.TxtName);
            this.GBProduct.Controls.Add(this.LblCategory);
            this.GBProduct.Controls.Add(this.LblDescription);
            this.GBProduct.Controls.Add(this.LblBrand);
            this.GBProduct.Controls.Add(this.LblName);
            this.GBProduct.Dock = System.Windows.Forms.DockStyle.Top;
            this.GBProduct.Location = new System.Drawing.Point(0, 0);
            this.GBProduct.Name = "GBProduct";
            this.GBProduct.Size = new System.Drawing.Size(1560, 176);
            this.GBProduct.TabIndex = 1;
            this.GBProduct.TabStop = false;
            this.GBProduct.Text = "Produit";
            // 
            // lst_dep
            // 
            this.lst_dep.FormattingEnabled = true;
            this.lst_dep.ItemHeight = 17;
            this.lst_dep.Location = new System.Drawing.Point(591, 46);
            this.lst_dep.Name = "lst_dep";
            this.lst_dep.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lst_dep.Size = new System.Drawing.Size(237, 106);
            this.lst_dep.TabIndex = 9;
            // 
            // TxtDescription
            // 
            this.TxtDescription.Location = new System.Drawing.Point(1070, 77);
            this.TxtDescription.Multiline = true;
            this.TxtDescription.Name = "TxtDescription";
            this.TxtDescription.Size = new System.Drawing.Size(237, 75);
            this.TxtDescription.TabIndex = 0;
            // 
            // LblDepartment
            // 
            this.LblDepartment.AutoSize = true;
            this.LblDepartment.Location = new System.Drawing.Point(484, 46);
            this.LblDepartment.Name = "LblDepartment";
            this.LblDepartment.Size = new System.Drawing.Size(101, 19);
            this.LblDepartment.TabIndex = 3;
            this.LblDepartment.Text = "Département : ";
            // 
            // CbCategory
            // 
            this.CbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbCategory.FormattingEnabled = true;
            this.CbCategory.Location = new System.Drawing.Point(1070, 40);
            this.CbCategory.Name = "CbCategory";
            this.CbCategory.Size = new System.Drawing.Size(237, 25);
            this.CbCategory.TabIndex = 7;
            // 
            // TxtBrand
            // 
            this.TxtBrand.Location = new System.Drawing.Point(200, 103);
            this.TxtBrand.Name = "TxtBrand";
            this.TxtBrand.Size = new System.Drawing.Size(237, 25);
            this.TxtBrand.TabIndex = 6;
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(200, 43);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(237, 25);
            this.TxtName.TabIndex = 5;
            // 
            // LblCategory
            // 
            this.LblCategory.AutoSize = true;
            this.LblCategory.Location = new System.Drawing.Point(900, 43);
            this.LblCategory.Name = "LblCategory";
            this.LblCategory.Size = new System.Drawing.Size(79, 19);
            this.LblCategory.TabIndex = 4;
            this.LblCategory.Text = "Catégorie : ";
            // 
            // LblDescription
            // 
            this.LblDescription.AutoSize = true;
            this.LblDescription.Location = new System.Drawing.Point(900, 80);
            this.LblDescription.Name = "LblDescription";
            this.LblDescription.Size = new System.Drawing.Size(163, 19);
            this.LblDescription.TabIndex = 2;
            this.LblDescription.Text = "Description d\'utilisation : ";
            // 
            // LblBrand
            // 
            this.LblBrand.AutoSize = true;
            this.LblBrand.Location = new System.Drawing.Point(30, 104);
            this.LblBrand.Name = "LblBrand";
            this.LblBrand.Size = new System.Drawing.Size(68, 19);
            this.LblBrand.TabIndex = 1;
            this.LblBrand.Text = "Marque : ";
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Location = new System.Drawing.Point(30, 46);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(50, 19);
            this.LblName.TabIndex = 0;
            this.LblName.Text = "Nom : ";
            // 
            // GBSupplier
            // 
            this.GBSupplier.AutoSize = true;
            this.GBSupplier.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.GBSupplier.Controls.Add(this.nud_measureqty);
            this.GBSupplier.Controls.Add(this.txt_mesure);
            this.GBSupplier.Controls.Add(this.label2);
            this.GBSupplier.Controls.Add(this.txt_fournisseurcode);
            this.GBSupplier.Controls.Add(this.label1);
            this.GBSupplier.Controls.Add(this.CBSupplier);
            this.GBSupplier.Controls.Add(this.NudPrice);
            this.GBSupplier.Controls.Add(this.NudMeasuringQty);
            this.GBSupplier.Controls.Add(this.lblPrice);
            this.GBSupplier.Controls.Add(this.lblQuantityUnit);
            this.GBSupplier.Controls.Add(this.lblSupplierName);
            this.GBSupplier.Dock = System.Windows.Forms.DockStyle.Top;
            this.GBSupplier.Location = new System.Drawing.Point(0, 176);
            this.GBSupplier.Name = "GBSupplier";
            this.GBSupplier.Size = new System.Drawing.Size(1560, 163);
            this.GBSupplier.TabIndex = 2;
            this.GBSupplier.TabStop = false;
            this.GBSupplier.Text = "Fournisseur";
            // 
            // nud_measureqty
            // 
            this.nud_measureqty.Location = new System.Drawing.Point(712, 56);
            this.nud_measureqty.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nud_measureqty.Name = "nud_measureqty";
            this.nud_measureqty.Size = new System.Drawing.Size(56, 25);
            this.nud_measureqty.TabIndex = 26;
            this.ToolTips.SetToolTip(this.nud_measureqty, "Unité");
            this.nud_measureqty.Leave += new System.EventHandler(this.nud_measureqty_Leave);
            // 
            // txt_mesure
            // 
            this.txt_mesure.Location = new System.Drawing.Point(787, 56);
            this.txt_mesure.Name = "txt_mesure";
            this.txt_mesure.Size = new System.Drawing.Size(144, 25);
            this.txt_mesure.TabIndex = 24;
            this.ToolTips.SetToolTip(this.txt_mesure, "Mesure");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(628, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 19);
            this.label2.TabIndex = 23;
            this.label2.Text = "Unité(s) de ";
            // 
            // txt_fournisseurcode
            // 
            this.txt_fournisseurcode.Location = new System.Drawing.Point(174, 114);
            this.txt_fournisseurcode.Name = "txt_fournisseurcode";
            this.txt_fournisseurcode.Size = new System.Drawing.Size(202, 25);
            this.txt_fournisseurcode.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 19);
            this.label1.TabIndex = 21;
            this.label1.Text = "Code de fournisseur :";
            // 
            // CBSupplier
            // 
            this.CBSupplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBSupplier.FormattingEnabled = true;
            this.CBSupplier.Location = new System.Drawing.Point(174, 53);
            this.CBSupplier.Name = "CBSupplier";
            this.CBSupplier.Size = new System.Drawing.Size(202, 25);
            this.CBSupplier.TabIndex = 20;
            // 
            // NudPrice
            // 
            this.NudPrice.DecimalPlaces = 2;
            this.NudPrice.Location = new System.Drawing.Point(505, 110);
            this.NudPrice.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.NudPrice.Name = "NudPrice";
            this.NudPrice.Size = new System.Drawing.Size(202, 25);
            this.NudPrice.TabIndex = 18;
            // 
            // NudMeasuringQty
            // 
            this.NudMeasuringQty.Location = new System.Drawing.Point(559, 57);
            this.NudMeasuringQty.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.NudMeasuringQty.Name = "NudMeasuringQty";
            this.NudMeasuringQty.Size = new System.Drawing.Size(55, 25);
            this.NudMeasuringQty.TabIndex = 17;
            this.ToolTips.SetToolTip(this.NudMeasuringQty, "Quantité");
            this.NudMeasuringQty.Leave += new System.EventHandler(this.NudMeasuringQty_Leave);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(428, 112);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(38, 19);
            this.lblPrice.TabIndex = 15;
            this.lblPrice.Text = "Prix :";
            // 
            // lblQuantityUnit
            // 
            this.lblQuantityUnit.AutoSize = true;
            this.lblQuantityUnit.Location = new System.Drawing.Point(428, 59);
            this.lblQuantityUnit.Name = "lblQuantityUnit";
            this.lblQuantityUnit.Size = new System.Drawing.Size(125, 19);
            this.lblQuantityUnit.TabIndex = 11;
            this.lblQuantityUnit.Text = "Unité de mesure  : ";
            this.ToolTips.SetToolTip(this.lblQuantityUnit, "Champs pour unité de mesure (Exemple : 6 unités de 500 Millilitres)");
            // 
            // lblSupplierName
            // 
            this.lblSupplierName.AutoSize = true;
            this.lblSupplierName.Location = new System.Drawing.Point(30, 53);
            this.lblSupplierName.Name = "lblSupplierName";
            this.lblSupplierName.Size = new System.Drawing.Size(91, 19);
            this.lblSupplierName.TabIndex = 6;
            this.lblSupplierName.Text = "Fournisseur : ";
            // 
            // lbl_BarCode
            // 
            this.lbl_BarCode.AutoSize = true;
            this.lbl_BarCode.Location = new System.Drawing.Point(521, 130);
            this.lbl_BarCode.Name = "lbl_BarCode";
            this.lbl_BarCode.Size = new System.Drawing.Size(0, 19);
            this.lbl_BarCode.TabIndex = 24;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(34, 24);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(240, 82);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 23;
            this.pictureBox2.TabStop = false;
            // 
            // btn_Print
            // 
            this.btn_Print.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Print.BackgroundImage")));
            this.btn_Print.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Print.Enabled = false;
            this.btn_Print.Location = new System.Drawing.Point(314, 35);
            this.btn_Print.Name = "btn_Print";
            this.btn_Print.Size = new System.Drawing.Size(75, 56);
            this.btn_Print.TabIndex = 21;
            this.ToolTips.SetToolTip(this.btn_Print, "Imprimer");
            this.btn_Print.UseVisualStyleBackColor = true;
            this.btn_Print.Click += new System.EventHandler(this.Btn_Print_Click);
            // 
            // GBOther
            // 
            this.GBOther.AutoSize = true;
            this.GBOther.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.GBOther.Controls.Add(this.TxtLastUpdate);
            this.GBOther.Controls.Add(this.LblLastUpdate);
            this.GBOther.Controls.Add(this.cbActive);
            this.GBOther.Dock = System.Windows.Forms.DockStyle.Top;
            this.GBOther.Location = new System.Drawing.Point(0, 531);
            this.GBOther.Name = "GBOther";
            this.GBOther.Size = new System.Drawing.Size(1560, 136);
            this.GBOther.TabIndex = 5;
            this.GBOther.TabStop = false;
            this.GBOther.Text = "Autres";
            // 
            // TxtLastUpdate
            // 
            this.TxtLastUpdate.Location = new System.Drawing.Point(174, 48);
            this.TxtLastUpdate.Name = "TxtLastUpdate";
            this.TxtLastUpdate.ReadOnly = true;
            this.TxtLastUpdate.Size = new System.Drawing.Size(202, 25);
            this.TxtLastUpdate.TabIndex = 23;
            // 
            // LblLastUpdate
            // 
            this.LblLastUpdate.AutoSize = true;
            this.LblLastUpdate.Location = new System.Drawing.Point(27, 52);
            this.LblLastUpdate.Name = "LblLastUpdate";
            this.LblLastUpdate.Size = new System.Drawing.Size(139, 19);
            this.LblLastUpdate.TabIndex = 22;
            this.LblLastUpdate.Text = "Dernière mise à jour :";
            // 
            // cbActive
            // 
            this.cbActive.AutoSize = true;
            this.cbActive.Location = new System.Drawing.Point(31, 89);
            this.cbActive.Name = "cbActive";
            this.cbActive.Size = new System.Drawing.Size(55, 23);
            this.cbActive.TabIndex = 25;
            this.cbActive.Text = "Actif";
            this.cbActive.UseVisualStyleBackColor = true;
            // 
            // ActionPanel
            // 
            this.ActionPanel.Controls.Add(this.ucManagementAction1);
            this.ActionPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ActionPanel.Location = new System.Drawing.Point(238, 842);
            this.ActionPanel.Name = "ActionPanel";
            this.ActionPanel.Size = new System.Drawing.Size(1560, 56);
            this.ActionPanel.TabIndex = 6;
            // 
            // GBInventory
            // 
            this.GBInventory.AutoSize = true;
            this.GBInventory.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.GBInventory.Controls.Add(this.nudQtyInvOut);
            this.GBInventory.Controls.Add(this.lblQtyInvOut);
            this.GBInventory.Controls.Add(this.GBOBarCode);
            this.GBInventory.Controls.Add(this.nudMax);
            this.GBInventory.Controls.Add(this.NudMin);
            this.GBInventory.Controls.Add(this.lblMaxQty);
            this.GBInventory.Controls.Add(this.lblQtyMin);
            this.GBInventory.Dock = System.Windows.Forms.DockStyle.Top;
            this.GBInventory.Location = new System.Drawing.Point(0, 339);
            this.GBInventory.Name = "GBInventory";
            this.GBInventory.Size = new System.Drawing.Size(1560, 192);
            this.GBInventory.TabIndex = 7;
            this.GBInventory.TabStop = false;
            this.GBInventory.Text = "Inventaire";
            // 
            // GBOBarCode
            // 
            this.GBOBarCode.Controls.Add(this.btn_Print);
            this.GBOBarCode.Controls.Add(this.pictureBox2);
            this.GBOBarCode.Controls.Add(this.lbl_BarCode);
            this.GBOBarCode.Location = new System.Drawing.Point(432, 28);
            this.GBOBarCode.Name = "GBOBarCode";
            this.GBOBarCode.Size = new System.Drawing.Size(441, 130);
            this.GBOBarCode.TabIndex = 28;
            this.GBOBarCode.TabStop = false;
            this.GBOBarCode.Text = "Code Barre";
            // 
            // nudMax
            // 
            this.nudMax.Location = new System.Drawing.Point(220, 102);
            this.nudMax.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudMax.Name = "nudMax";
            this.nudMax.Size = new System.Drawing.Size(170, 25);
            this.nudMax.TabIndex = 27;
            // 
            // NudMin
            // 
            this.NudMin.Location = new System.Drawing.Point(220, 54);
            this.NudMin.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.NudMin.Name = "NudMin";
            this.NudMin.Size = new System.Drawing.Size(170, 25);
            this.NudMin.TabIndex = 20;
            // 
            // lblMaxQty
            // 
            this.lblMaxQty.AutoSize = true;
            this.lblMaxQty.Location = new System.Drawing.Point(27, 104);
            this.lblMaxQty.Name = "lblMaxQty";
            this.lblMaxQty.Size = new System.Drawing.Size(134, 19);
            this.lblMaxQty.TabIndex = 26;
            this.lblMaxQty.Text = "Quantité maximum :";
            // 
            // lblQtyMin
            // 
            this.lblQtyMin.AutoSize = true;
            this.lblQtyMin.Location = new System.Drawing.Point(27, 56);
            this.lblQtyMin.Name = "lblQtyMin";
            this.lblQtyMin.Size = new System.Drawing.Size(132, 19);
            this.lblQtyMin.TabIndex = 19;
            this.lblQtyMin.Text = "Quantité minimum :";
            // 
            // GBFilter
            // 
            this.GBFilter.Controls.Add(this.CBFilter);
            this.GBFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.GBFilter.Location = new System.Drawing.Point(0, 0);
            this.GBFilter.Name = "GBFilter";
            this.GBFilter.Size = new System.Drawing.Size(1798, 53);
            this.GBFilter.TabIndex = 1;
            this.GBFilter.TabStop = false;
            // 
            // CBFilter
            // 
            this.CBFilter.Dock = System.Windows.Forms.DockStyle.Left;
            this.CBFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBFilter.FormattingEnabled = true;
            this.CBFilter.Location = new System.Drawing.Point(3, 21);
            this.CBFilter.Name = "CBFilter";
            this.CBFilter.Size = new System.Drawing.Size(235, 25);
            this.CBFilter.TabIndex = 0;
            // 
            // pnlMain
            // 
            this.pnlMain.AutoScroll = true;
            this.pnlMain.AutoSize = true;
            this.pnlMain.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlMain.Controls.Add(this.GBOther);
            this.pnlMain.Controls.Add(this.GBInventory);
            this.pnlMain.Controls.Add(this.GBSupplier);
            this.pnlMain.Controls.Add(this.GBProduct);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(238, 53);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1560, 789);
            this.pnlMain.TabIndex = 8;
            // 
            // nudQtyInvOut
            // 
            this.nudQtyInvOut.DecimalPlaces = 2;
            this.nudQtyInvOut.Location = new System.Drawing.Point(220, 143);
            this.nudQtyInvOut.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudQtyInvOut.Name = "nudQtyInvOut";
            this.nudQtyInvOut.Size = new System.Drawing.Size(170, 25);
            this.nudQtyInvOut.TabIndex = 30;
            this.ToolTips.SetToolTip(this.nudQtyInvOut, "Valeur par défaut : Quantité d\'unités * Quantité de mesures");
            // 
            // lblQtyInvOut
            // 
            this.lblQtyInvOut.AutoSize = true;
            this.lblQtyInvOut.Location = new System.Drawing.Point(30, 143);
            this.lblQtyInvOut.Name = "lblQtyInvOut";
            this.lblQtyInvOut.Size = new System.Drawing.Size(172, 19);
            this.lblQtyInvOut.TabIndex = 29;
            this.lblQtyInvOut.Text = "Quantité sortie inventaire :";
            this.ToolTips.SetToolTip(this.lblQtyInvOut, "Quanité du produit qui sera sortie par défaut lors de scan scan dans la sortie d\'" +
        "inventaire");
            // 
            // ucManagementAction1
            // 
            this.ucManagementAction1.AllowDrop = true;
            this.ucManagementAction1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucManagementAction1.Location = new System.Drawing.Point(0, 0);
            this.ucManagementAction1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ucManagementAction1.Name = "ucManagementAction1";
            this.ucManagementAction1.Size = new System.Drawing.Size(1560, 56);
            this.ucManagementAction1.TabIndex = 0;
            // 
            // FProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1798, 898);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.ActionPanel);
            this.Controls.Add(this.LBProducts);
            this.Controls.Add(this.GBFilter);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FProduct";
            this.Text = "FProduct";
            this.GBProduct.ResumeLayout(false);
            this.GBProduct.PerformLayout();
            this.GBSupplier.ResumeLayout(false);
            this.GBSupplier.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_measureqty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudMeasuringQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.GBOther.ResumeLayout(false);
            this.GBOther.PerformLayout();
            this.ActionPanel.ResumeLayout(false);
            this.GBInventory.ResumeLayout(false);
            this.GBInventory.PerformLayout();
            this.GBOBarCode.ResumeLayout(false);
            this.GBOBarCode.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudMin)).EndInit();
            this.GBFilter.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQtyInvOut)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LBProducts;
        private System.Windows.Forms.GroupBox GBProduct;
        private System.Windows.Forms.TextBox TxtDescription;
        private System.Windows.Forms.ComboBox CbCategory;
        private System.Windows.Forms.TextBox TxtBrand;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Label LblCategory;
        private System.Windows.Forms.Label LblDepartment;
        private System.Windows.Forms.Label LblDescription;
        private System.Windows.Forms.Label LblBrand;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.GroupBox GBSupplier;
        private System.Windows.Forms.Label lblSupplierName;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblQuantityUnit;
        private System.Windows.Forms.Button btn_Print;
        private System.Windows.Forms.GroupBox GBOther;
        private System.Windows.Forms.TextBox TxtLastUpdate;
        private System.Windows.Forms.Label LblLastUpdate;
        private System.Windows.Forms.CheckBox cbActive;
        private System.Windows.Forms.NumericUpDown NudMeasuringQty;
        private System.Windows.Forms.NumericUpDown NudPrice;
        private System.Windows.Forms.Panel ActionPanel;
        private UCManagementAction ucManagementAction1;
        private System.Windows.Forms.ToolTip ToolTips;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbl_BarCode;
        private System.Windows.Forms.GroupBox GBInventory;
        private System.Windows.Forms.Label lblQtyMin;
        private System.Windows.Forms.NumericUpDown nudMax;
        private System.Windows.Forms.NumericUpDown NudMin;
        private System.Windows.Forms.Label lblMaxQty;
        private System.Windows.Forms.GroupBox GBFilter;
        private System.Windows.Forms.ComboBox CBFilter;
        private System.Windows.Forms.ComboBox CBSupplier;
        private System.Windows.Forms.TextBox txt_fournisseurcode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lst_dep;
        private System.Windows.Forms.TextBox txt_mesure;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nud_measureqty;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.GroupBox GBOBarCode;
        private System.Windows.Forms.NumericUpDown nudQtyInvOut;
        private System.Windows.Forms.Label lblQtyInvOut;
    }
}