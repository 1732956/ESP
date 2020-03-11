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
            this.GBBarCode = new System.Windows.Forms.GroupBox();
            this.ActionPanel = new System.Windows.Forms.Panel();
            this.GBProduct.SuspendLayout();
            this.SuspendLayout();
            // 
            // LBProducts
            // 
            this.LBProducts.Dock = System.Windows.Forms.DockStyle.Left;
            this.LBProducts.FormattingEnabled = true;
            this.LBProducts.ItemHeight = 17;
            this.LBProducts.Location = new System.Drawing.Point(0, 0);
            this.LBProducts.Name = "LBProducts";
            this.LBProducts.Size = new System.Drawing.Size(182, 675);
            this.LBProducts.TabIndex = 0;
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
            this.GBProduct.Location = new System.Drawing.Point(182, 0);
            this.GBProduct.Name = "GBProduct";
            this.GBProduct.Size = new System.Drawing.Size(1259, 173);
            this.GBProduct.TabIndex = 1;
            this.GBProduct.TabStop = false;
            this.GBProduct.Text = "Produit";
            // 
            // TxtDescription
            // 
            this.TxtDescription.Location = new System.Drawing.Point(801, 77);
            this.TxtDescription.Multiline = true;
            this.TxtDescription.Name = "TxtDescription";
            this.TxtDescription.Size = new System.Drawing.Size(433, 52);
            this.TxtDescription.TabIndex = 0;
            // 
            // CbDepartment
            // 
            this.CbDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbDepartment.FormattingEnabled = true;
            this.CbDepartment.Location = new System.Drawing.Point(497, 98);
            this.CbDepartment.Name = "CbDepartment";
            this.CbDepartment.Size = new System.Drawing.Size(237, 25);
            this.CbDepartment.TabIndex = 8;
            // 
            // CbCategory
            // 
            this.CbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbCategory.FormattingEnabled = true;
            this.CbCategory.Location = new System.Drawing.Point(497, 46);
            this.CbCategory.Name = "CbCategory";
            this.CbCategory.Size = new System.Drawing.Size(237, 25);
            this.CbCategory.TabIndex = 7;
            // 
            // TxtBrand
            // 
            this.TxtBrand.Location = new System.Drawing.Point(111, 104);
            this.TxtBrand.Name = "TxtBrand";
            this.TxtBrand.Size = new System.Drawing.Size(216, 25);
            this.TxtBrand.TabIndex = 6;
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(111, 44);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(216, 25);
            this.TxtName.TabIndex = 5;
            // 
            // LblCategory
            // 
            this.LblCategory.AutoSize = true;
            this.LblCategory.Location = new System.Drawing.Point(385, 46);
            this.LblCategory.Name = "LblCategory";
            this.LblCategory.Size = new System.Drawing.Size(79, 19);
            this.LblCategory.TabIndex = 4;
            this.LblCategory.Text = "Catégorie : ";
            // 
            // LblDepartment
            // 
            this.LblDepartment.AutoSize = true;
            this.LblDepartment.Location = new System.Drawing.Point(385, 104);
            this.LblDepartment.Name = "LblDepartment";
            this.LblDepartment.Size = new System.Drawing.Size(101, 19);
            this.LblDepartment.TabIndex = 3;
            this.LblDepartment.Text = "Département : ";
            // 
            // LblDescription
            // 
            this.LblDescription.AutoSize = true;
            this.LblDescription.Location = new System.Drawing.Point(797, 46);
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
            this.GBSupplier.Dock = System.Windows.Forms.DockStyle.Top;
            this.GBSupplier.Location = new System.Drawing.Point(182, 173);
            this.GBSupplier.Name = "GBSupplier";
            this.GBSupplier.Size = new System.Drawing.Size(1259, 192);
            this.GBSupplier.TabIndex = 2;
            this.GBSupplier.TabStop = false;
            this.GBSupplier.Text = "Fournisseur";
            // 
            // GBBarCode
            // 
            this.GBBarCode.Dock = System.Windows.Forms.DockStyle.Top;
            this.GBBarCode.Location = new System.Drawing.Point(182, 365);
            this.GBBarCode.Name = "GBBarCode";
            this.GBBarCode.Size = new System.Drawing.Size(1259, 221);
            this.GBBarCode.TabIndex = 3;
            this.GBBarCode.TabStop = false;
            this.GBBarCode.Text = "Code barre";
            // 
            // ActionPanel
            // 
            this.ActionPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ActionPanel.Location = new System.Drawing.Point(182, 575);
            this.ActionPanel.Name = "ActionPanel";
            this.ActionPanel.Size = new System.Drawing.Size(1259, 100);
            this.ActionPanel.TabIndex = 4;
            // 
            // FProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1441, 675);
            this.Controls.Add(this.ActionPanel);
            this.Controls.Add(this.GBBarCode);
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
        private System.Windows.Forms.GroupBox GBBarCode;
        private System.Windows.Forms.Panel ActionPanel;
    }
}