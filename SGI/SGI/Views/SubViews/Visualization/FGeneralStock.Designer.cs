namespace SGI.Views.SubViews
{
    partial class FGeneralStock
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
            this.lstProducts = new System.Windows.Forms.ListBox();
            this.pnlData = new System.Windows.Forms.Panel();
            this.dgvStockByProduct = new System.Windows.Forms.DataGridView();
            this.Location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlTotal = new System.Windows.Forms.Panel();
            this.lblTotal = new System.Windows.Forms.Label();
            this.TotalLocValue = new System.Windows.Forms.Label();
            this.pnlData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockByProduct)).BeginInit();
            this.pnlTotal.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstProducts
            // 
            this.lstProducts.Dock = System.Windows.Forms.DockStyle.Left;
            this.lstProducts.FormattingEnabled = true;
            this.lstProducts.ItemHeight = 17;
            this.lstProducts.Location = new System.Drawing.Point(0, 0);
            this.lstProducts.Name = "lstProducts";
            this.lstProducts.Size = new System.Drawing.Size(276, 589);
            this.lstProducts.TabIndex = 1;
            this.lstProducts.SelectedIndexChanged += new System.EventHandler(this.lstProducts_SelectedIndexChanged);
            // 
            // pnlData
            // 
            this.pnlData.Controls.Add(this.dgvStockByProduct);
            this.pnlData.Controls.Add(this.pnlTotal);
            this.pnlData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlData.Location = new System.Drawing.Point(276, 0);
            this.pnlData.Name = "pnlData";
            this.pnlData.Padding = new System.Windows.Forms.Padding(25);
            this.pnlData.Size = new System.Drawing.Size(908, 589);
            this.pnlData.TabIndex = 3;
            // 
            // dgvStockByProduct
            // 
            this.dgvStockByProduct.AllowUserToAddRows = false;
            this.dgvStockByProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStockByProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStockByProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Location,
            this.Quantity,
            this.Price});
            this.dgvStockByProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStockByProduct.Location = new System.Drawing.Point(25, 25);
            this.dgvStockByProduct.Name = "dgvStockByProduct";
            this.dgvStockByProduct.ReadOnly = true;
            this.dgvStockByProduct.Size = new System.Drawing.Size(858, 509);
            this.dgvStockByProduct.TabIndex = 1;
            // 
            // Location
            // 
            this.Location.DataPropertyName = "Location";
            this.Location.HeaderText = "Localisation";
            this.Location.Name = "Location";
            this.Location.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.HeaderText = "Quantité";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "Prix";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // pnlTotal
            // 
            this.pnlTotal.Controls.Add(this.lblTotal);
            this.pnlTotal.Controls.Add(this.TotalLocValue);
            this.pnlTotal.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlTotal.Location = new System.Drawing.Point(25, 534);
            this.pnlTotal.Name = "pnlTotal";
            this.pnlTotal.Padding = new System.Windows.Forms.Padding(0, 10, 10, 0);
            this.pnlTotal.Size = new System.Drawing.Size(858, 30);
            this.pnlTotal.TabIndex = 2;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(754, 10);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(94, 19);
            this.lblTotal.TabIndex = 0;
            this.lblTotal.Text = "Valeur total :";
            // 
            // TotalLocValue
            // 
            this.TotalLocValue.AutoSize = true;
            this.TotalLocValue.Dock = System.Windows.Forms.DockStyle.Right;
            this.TotalLocValue.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalLocValue.Location = new System.Drawing.Point(848, 10);
            this.TotalLocValue.Name = "TotalLocValue";
            this.TotalLocValue.Size = new System.Drawing.Size(0, 19);
            this.TotalLocValue.TabIndex = 1;
            // 
            // FGeneralStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 589);
            this.Controls.Add(this.pnlData);
            this.Controls.Add(this.lstProducts);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FGeneralStock";
            this.Text = "FGeneralStock";
            this.Load += new System.EventHandler(this.FGeneralStock_Load);
            this.pnlData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockByProduct)).EndInit();
            this.pnlTotal.ResumeLayout(false);
            this.pnlTotal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstProducts;
        private System.Windows.Forms.Panel pnlData;
        private System.Windows.Forms.DataGridView dgvStockByProduct;
        private System.Windows.Forms.Panel pnlTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label TotalLocValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn Location;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
    }
}