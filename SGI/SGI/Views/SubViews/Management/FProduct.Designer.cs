﻿namespace SGI.Views.SubViews
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
            this.LBProducts = new System.Windows.Forms.ListBox();
            this.GBProduct = new System.Windows.Forms.GroupBox();
            this.TxtDescription = new System.Windows.Forms.TextBox();
            this.CbDepartment = new System.Windows.Forms.ComboBox();
            this.CbCategory = new System.Windows.Forms.ComboBox();
            this.TxtBrand = new System.Windows.Forms.TextBox();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.LblCategory = new System.Windows.Forms.Label();
            this.LblDepartment = new System.Windows.Forms.Label();
            this.LblDescription = new System.Windows.Forms.Label();
            this.LblBrand = new System.Windows.Forms.Label();
            this.LblName = new System.Windows.Forms.Label();
            this.GBSupplier = new System.Windows.Forms.GroupBox();
            this.NudPrice = new System.Windows.Forms.NumericUpDown();
            this.NudMeasuringQty = new System.Windows.Forms.NumericUpDown();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtMeasuringUnit = new System.Windows.Forms.TextBox();
            this.lblMeasuringUnit = new System.Windows.Forms.Label();
            this.lblQuantityUnit = new System.Windows.Forms.Label();
            this.txtSupplierCode = new System.Windows.Forms.TextBox();
            this.lblSupplierCode = new System.Windows.Forms.Label();
            this.TxtSupplierName = new System.Windows.Forms.TextBox();
            this.lblSupplierName = new System.Windows.Forms.Label();
            this.GBOBarCode = new System.Windows.Forms.GroupBox();
            this.btn_Print = new System.Windows.Forms.Button();
            this.txtBarCode = new System.Windows.Forms.TextBox();
            this.lblBarCode = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbActive = new System.Windows.Forms.CheckBox();
            this.TxtLastUpdate = new System.Windows.Forms.TextBox();
            this.LblLastUpdate = new System.Windows.Forms.Label();
            this.ActionPanel = new System.Windows.Forms.Panel();
            this.ucManagementAction1 = new SGI.Views.UCManagementAction();
            this.GBProduct.SuspendLayout();
            this.GBSupplier.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudMeasuringQty)).BeginInit();
            this.GBOBarCode.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.ActionPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // LBProducts
            // 
            this.LBProducts.Dock = System.Windows.Forms.DockStyle.Left;
            this.LBProducts.FormattingEnabled = true;
            this.LBProducts.ItemHeight = 17;
            this.LBProducts.Location = new System.Drawing.Point(0, 0);
            this.LBProducts.Name = "LBProducts";
            this.LBProducts.Size = new System.Drawing.Size(301, 715);
            this.LBProducts.TabIndex = 0;
            this.LBProducts.SelectedIndexChanged += new System.EventHandler(this.LBProducts_SelectedIndexChanged);
            // 
            // GBProduct
            // 
            this.GBProduct.Controls.Add(this.TxtDescription);
            this.GBProduct.Controls.Add(this.CbDepartment);
            this.GBProduct.Controls.Add(this.CbCategory);
            this.GBProduct.Controls.Add(this.TxtBrand);
            this.GBProduct.Controls.Add(this.TxtName);
            this.GBProduct.Controls.Add(this.LblCategory);
            this.GBProduct.Controls.Add(this.LblDepartment);
            this.GBProduct.Controls.Add(this.LblDescription);
            this.GBProduct.Controls.Add(this.LblBrand);
            this.GBProduct.Controls.Add(this.LblName);
            this.GBProduct.Dock = System.Windows.Forms.DockStyle.Top;
            this.GBProduct.Location = new System.Drawing.Point(301, 0);
            this.GBProduct.Name = "GBProduct";
            this.GBProduct.Size = new System.Drawing.Size(1195, 173);
            this.GBProduct.TabIndex = 1;
            this.GBProduct.TabStop = false;
            this.GBProduct.Text = "Produit";
            // 
            // TxtDescription
            // 
            this.TxtDescription.Location = new System.Drawing.Point(895, 77);
            this.TxtDescription.Multiline = true;
            this.TxtDescription.Name = "TxtDescription";
            this.TxtDescription.Size = new System.Drawing.Size(433, 52);
            this.TxtDescription.TabIndex = 0;
            // 
            // CbDepartment
            // 
            this.CbDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbDepartment.FormattingEnabled = true;
            this.CbDepartment.Location = new System.Drawing.Point(591, 98);
            this.CbDepartment.Name = "CbDepartment";
            this.CbDepartment.Size = new System.Drawing.Size(237, 25);
            this.CbDepartment.TabIndex = 8;
            // 
            // CbCategory
            // 
            this.CbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbCategory.FormattingEnabled = true;
            this.CbCategory.Location = new System.Drawing.Point(591, 46);
            this.CbCategory.Name = "CbCategory";
            this.CbCategory.Size = new System.Drawing.Size(237, 25);
            this.CbCategory.TabIndex = 7;
            // 
            // TxtBrand
            // 
            this.TxtBrand.Location = new System.Drawing.Point(111, 104);
            this.TxtBrand.Name = "TxtBrand";
            this.TxtBrand.Size = new System.Drawing.Size(313, 25);
            this.TxtBrand.TabIndex = 6;
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(111, 44);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(313, 25);
            this.TxtName.TabIndex = 5;
            // 
            // LblCategory
            // 
            this.LblCategory.AutoSize = true;
            this.LblCategory.Location = new System.Drawing.Point(479, 46);
            this.LblCategory.Name = "LblCategory";
            this.LblCategory.Size = new System.Drawing.Size(79, 19);
            this.LblCategory.TabIndex = 4;
            this.LblCategory.Text = "Catégorie : ";
            // 
            // LblDepartment
            // 
            this.LblDepartment.AutoSize = true;
            this.LblDepartment.Location = new System.Drawing.Point(479, 104);
            this.LblDepartment.Name = "LblDepartment";
            this.LblDepartment.Size = new System.Drawing.Size(101, 19);
            this.LblDepartment.TabIndex = 3;
            this.LblDepartment.Text = "Département : ";
            // 
            // LblDescription
            // 
            this.LblDescription.AutoSize = true;
            this.LblDescription.Location = new System.Drawing.Point(891, 46);
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
            this.GBSupplier.Controls.Add(this.NudPrice);
            this.GBSupplier.Controls.Add(this.NudMeasuringQty);
            this.GBSupplier.Controls.Add(this.lblPrice);
            this.GBSupplier.Controls.Add(this.txtMeasuringUnit);
            this.GBSupplier.Controls.Add(this.lblMeasuringUnit);
            this.GBSupplier.Controls.Add(this.lblQuantityUnit);
            this.GBSupplier.Controls.Add(this.txtSupplierCode);
            this.GBSupplier.Controls.Add(this.lblSupplierCode);
            this.GBSupplier.Controls.Add(this.TxtSupplierName);
            this.GBSupplier.Controls.Add(this.lblSupplierName);
            this.GBSupplier.Dock = System.Windows.Forms.DockStyle.Top;
            this.GBSupplier.Location = new System.Drawing.Point(301, 173);
            this.GBSupplier.Name = "GBSupplier";
            this.GBSupplier.Size = new System.Drawing.Size(1195, 192);
            this.GBSupplier.TabIndex = 2;
            this.GBSupplier.TabStop = false;
            this.GBSupplier.Text = "Fournisseur";
            // 
            // NudPrice
            // 
            this.NudPrice.DecimalPlaces = 2;
            this.NudPrice.Location = new System.Drawing.Point(987, 56);
            this.NudPrice.Name = "NudPrice";
            this.NudPrice.Size = new System.Drawing.Size(202, 25);
            this.NudPrice.TabIndex = 18;
            // 
            // NudMeasuringQty
            // 
            this.NudMeasuringQty.Location = new System.Drawing.Point(626, 57);
            this.NudMeasuringQty.Name = "NudMeasuringQty";
            this.NudMeasuringQty.Size = new System.Drawing.Size(202, 25);
            this.NudMeasuringQty.TabIndex = 17;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(938, 56);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(38, 19);
            this.lblPrice.TabIndex = 15;
            this.lblPrice.Text = "Prix :";
            // 
            // txtMeasuringUnit
            // 
            this.txtMeasuringUnit.Location = new System.Drawing.Point(626, 116);
            this.txtMeasuringUnit.Name = "txtMeasuringUnit";
            this.txtMeasuringUnit.Size = new System.Drawing.Size(202, 25);
            this.txtMeasuringUnit.TabIndex = 14;
            // 
            // lblMeasuringUnit
            // 
            this.lblMeasuringUnit.AutoSize = true;
            this.lblMeasuringUnit.Location = new System.Drawing.Point(479, 122);
            this.lblMeasuringUnit.Name = "lblMeasuringUnit";
            this.lblMeasuringUnit.Size = new System.Drawing.Size(117, 19);
            this.lblMeasuringUnit.TabIndex = 13;
            this.lblMeasuringUnit.Text = "Unité de mesure :";
            // 
            // lblQuantityUnit
            // 
            this.lblQuantityUnit.AutoSize = true;
            this.lblQuantityUnit.Location = new System.Drawing.Point(479, 57);
            this.lblQuantityUnit.Name = "lblQuantityUnit";
            this.lblQuantityUnit.Size = new System.Drawing.Size(128, 19);
            this.lblQuantityUnit.TabIndex = 11;
            this.lblQuantityUnit.Text = "Quanité par unité : ";
            // 
            // txtSupplierCode
            // 
            this.txtSupplierCode.Location = new System.Drawing.Point(111, 124);
            this.txtSupplierCode.Name = "txtSupplierCode";
            this.txtSupplierCode.Size = new System.Drawing.Size(313, 25);
            this.txtSupplierCode.TabIndex = 10;
            // 
            // lblSupplierCode
            // 
            this.lblSupplierCode.AutoSize = true;
            this.lblSupplierCode.Location = new System.Drawing.Point(30, 124);
            this.lblSupplierCode.Name = "lblSupplierCode";
            this.lblSupplierCode.Size = new System.Drawing.Size(52, 19);
            this.lblSupplierCode.TabIndex = 9;
            this.lblSupplierCode.Text = "Code : ";
            // 
            // TxtSupplierName
            // 
            this.TxtSupplierName.Location = new System.Drawing.Point(111, 51);
            this.TxtSupplierName.Name = "TxtSupplierName";
            this.TxtSupplierName.Size = new System.Drawing.Size(313, 25);
            this.TxtSupplierName.TabIndex = 7;
            // 
            // lblSupplierName
            // 
            this.lblSupplierName.AutoSize = true;
            this.lblSupplierName.Location = new System.Drawing.Point(30, 53);
            this.lblSupplierName.Name = "lblSupplierName";
            this.lblSupplierName.Size = new System.Drawing.Size(50, 19);
            this.lblSupplierName.TabIndex = 6;
            this.lblSupplierName.Text = "Nom : ";
            // 
            // GBOBarCode
            // 
            this.GBOBarCode.Controls.Add(this.btn_Print);
            this.GBOBarCode.Controls.Add(this.txtBarCode);
            this.GBOBarCode.Controls.Add(this.lblBarCode);
            this.GBOBarCode.Dock = System.Windows.Forms.DockStyle.Top;
            this.GBOBarCode.Location = new System.Drawing.Point(301, 365);
            this.GBOBarCode.Name = "GBOBarCode";
            this.GBOBarCode.Size = new System.Drawing.Size(1195, 112);
            this.GBOBarCode.TabIndex = 3;
            this.GBOBarCode.TabStop = false;
            this.GBOBarCode.Text = "Code barre";
            // 
            // btn_Print
            // 
            this.btn_Print.Enabled = false;
            this.btn_Print.Location = new System.Drawing.Point(483, 50);
            this.btn_Print.Name = "btn_Print";
            this.btn_Print.Size = new System.Drawing.Size(157, 37);
            this.btn_Print.TabIndex = 21;
            this.btn_Print.Text = "Imprimer étiquette";
            this.btn_Print.UseVisualStyleBackColor = true;
            // 
            // txtBarCode
            // 
            this.txtBarCode.Location = new System.Drawing.Point(111, 57);
            this.txtBarCode.Name = "txtBarCode";
            this.txtBarCode.ReadOnly = true;
            this.txtBarCode.Size = new System.Drawing.Size(313, 25);
            this.txtBarCode.TabIndex = 20;
            // 
            // lblBarCode
            // 
            this.lblBarCode.AutoSize = true;
            this.lblBarCode.Location = new System.Drawing.Point(27, 60);
            this.lblBarCode.Name = "lblBarCode";
            this.lblBarCode.Size = new System.Drawing.Size(88, 19);
            this.lblBarCode.TabIndex = 19;
            this.lblBarCode.Text = "Code barre : ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbActive);
            this.groupBox1.Controls.Add(this.TxtLastUpdate);
            this.groupBox1.Controls.Add(this.LblLastUpdate);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(301, 477);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1195, 112);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Code barre";
            // 
            // cbActive
            // 
            this.cbActive.AutoSize = true;
            this.cbActive.Location = new System.Drawing.Point(488, 48);
            this.cbActive.Name = "cbActive";
            this.cbActive.Size = new System.Drawing.Size(55, 23);
            this.cbActive.TabIndex = 25;
            this.cbActive.Text = "Actif";
            this.cbActive.UseVisualStyleBackColor = true;
            // 
            // TxtLastUpdate
            // 
            this.TxtLastUpdate.Location = new System.Drawing.Point(174, 48);
            this.TxtLastUpdate.Name = "TxtLastUpdate";
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
            // ActionPanel
            // 
            this.ActionPanel.Controls.Add(this.ucManagementAction1);
            this.ActionPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ActionPanel.Location = new System.Drawing.Point(301, 659);
            this.ActionPanel.Name = "ActionPanel";
            this.ActionPanel.Size = new System.Drawing.Size(1195, 56);
            this.ActionPanel.TabIndex = 6;
            // 
            // ucManagementAction1
            // 
            this.ucManagementAction1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucManagementAction1.Location = new System.Drawing.Point(0, 0);
            this.ucManagementAction1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ucManagementAction1.Name = "ucManagementAction1";
            this.ucManagementAction1.Size = new System.Drawing.Size(1195, 56);
            this.ucManagementAction1.TabIndex = 0;
            this.ucManagementAction1.Load += new System.EventHandler(this.ucManagementAction1_Load);
            // 
            // FProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1496, 715);
            this.Controls.Add(this.ActionPanel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GBOBarCode);
            this.Controls.Add(this.GBSupplier);
            this.Controls.Add(this.GBProduct);
            this.Controls.Add(this.LBProducts);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FProduct";
            this.Text = "FProduct";
            this.GBProduct.ResumeLayout(false);
            this.GBProduct.PerformLayout();
            this.GBSupplier.ResumeLayout(false);
            this.GBSupplier.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudMeasuringQty)).EndInit();
            this.GBOBarCode.ResumeLayout(false);
            this.GBOBarCode.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ActionPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox LBProducts;
        private System.Windows.Forms.GroupBox GBProduct;
        private System.Windows.Forms.TextBox TxtDescription;
        private System.Windows.Forms.ComboBox CbDepartment;
        private System.Windows.Forms.ComboBox CbCategory;
        private System.Windows.Forms.TextBox TxtBrand;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Label LblCategory;
        private System.Windows.Forms.Label LblDepartment;
        private System.Windows.Forms.Label LblDescription;
        private System.Windows.Forms.Label LblBrand;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.GroupBox GBSupplier;
        private System.Windows.Forms.GroupBox GBOBarCode;
        private System.Windows.Forms.TextBox txtSupplierCode;
        private System.Windows.Forms.Label lblSupplierCode;
        private System.Windows.Forms.TextBox TxtSupplierName;
        private System.Windows.Forms.Label lblSupplierName;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtMeasuringUnit;
        private System.Windows.Forms.Label lblMeasuringUnit;
        private System.Windows.Forms.Label lblQuantityUnit;
        private System.Windows.Forms.Button btn_Print;
        private System.Windows.Forms.TextBox txtBarCode;
        private System.Windows.Forms.Label lblBarCode;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtLastUpdate;
        private System.Windows.Forms.Label LblLastUpdate;
        private System.Windows.Forms.CheckBox cbActive;
        private System.Windows.Forms.NumericUpDown NudMeasuringQty;
        private System.Windows.Forms.NumericUpDown NudPrice;
        private System.Windows.Forms.Panel ActionPanel;
        private UCManagementAction ucManagementAction1;
    }
}