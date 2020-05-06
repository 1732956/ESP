namespace SGI.Views.SubViews
{
    partial class FLocStock
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
            this.lstLocations = new System.Windows.Forms.ListBox();
            this.dgvStockByLoc = new System.Windows.Forms.DataGridView();
            this.Product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MeasuringUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlData = new System.Windows.Forms.Panel();
            this.pnlTotal = new System.Windows.Forms.Panel();
            this.lblTotal = new System.Windows.Forms.Label();
            this.TotalLocValue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockByLoc)).BeginInit();
            this.pnlData.SuspendLayout();
            this.pnlTotal.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstLocations
            // 
            this.lstLocations.Dock = System.Windows.Forms.DockStyle.Left;
            this.lstLocations.FormattingEnabled = true;
            this.lstLocations.ItemHeight = 17;
            this.lstLocations.Location = new System.Drawing.Point(0, 0);
            this.lstLocations.Name = "lstLocations";
            this.lstLocations.Size = new System.Drawing.Size(200, 604);
            this.lstLocations.TabIndex = 0;
            this.lstLocations.SelectedIndexChanged += new System.EventHandler(this.lstLocations_SelectedIndexChanged);
            // 
            // dgvStockByLoc
            // 
            this.dgvStockByLoc.AllowUserToAddRows = false;
            this.dgvStockByLoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStockByLoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStockByLoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Product,
            this.MeasuringUnit,
            this.Quantity,
            this.Price});
            this.dgvStockByLoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStockByLoc.Location = new System.Drawing.Point(25, 25);
            this.dgvStockByLoc.Name = "dgvStockByLoc";
            this.dgvStockByLoc.ReadOnly = true;
            this.dgvStockByLoc.Size = new System.Drawing.Size(744, 524);
            this.dgvStockByLoc.TabIndex = 1;
            // 
            // Product
            // 
            this.Product.DataPropertyName = "Name";
            this.Product.HeaderText = "Produit";
            this.Product.Name = "Product";
            this.Product.ReadOnly = true;
            // 
            // MeasuringUnit
            // 
            this.MeasuringUnit.DataPropertyName = "MeasUnit";
            this.MeasuringUnit.HeaderText = "Unité de mesure";
            this.MeasuringUnit.Name = "MeasuringUnit";
            this.MeasuringUnit.ReadOnly = true;
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
            // pnlData
            // 
            this.pnlData.Controls.Add(this.dgvStockByLoc);
            this.pnlData.Controls.Add(this.pnlTotal);
            this.pnlData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlData.Location = new System.Drawing.Point(200, 0);
            this.pnlData.Name = "pnlData";
            this.pnlData.Padding = new System.Windows.Forms.Padding(25);
            this.pnlData.Size = new System.Drawing.Size(794, 604);
            this.pnlData.TabIndex = 2;
            // 
            // pnlTotal
            // 
            this.pnlTotal.Controls.Add(this.lblTotal);
            this.pnlTotal.Controls.Add(this.TotalLocValue);
            this.pnlTotal.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlTotal.Location = new System.Drawing.Point(25, 549);
            this.pnlTotal.Name = "pnlTotal";
            this.pnlTotal.Padding = new System.Windows.Forms.Padding(0, 10, 10, 0);
            this.pnlTotal.Size = new System.Drawing.Size(744, 30);
            this.pnlTotal.TabIndex = 2;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(640, 10);
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
            this.TotalLocValue.Location = new System.Drawing.Point(734, 10);
            this.TotalLocValue.Name = "TotalLocValue";
            this.TotalLocValue.Size = new System.Drawing.Size(0, 19);
            this.TotalLocValue.TabIndex = 1;
            // 
            // FLocStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 604);
            this.Controls.Add(this.pnlData);
            this.Controls.Add(this.lstLocations);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FLocStock";
            this.Text = "FLocStock";
            this.Load += new System.EventHandler(this.FLocStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockByLoc)).EndInit();
            this.pnlData.ResumeLayout(false);
            this.pnlTotal.ResumeLayout(false);
            this.pnlTotal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstLocations;
        private System.Windows.Forms.DataGridView dgvStockByLoc;
        private System.Windows.Forms.Panel pnlData;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product;
        private System.Windows.Forms.DataGridViewTextBoxColumn MeasuringUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.Panel pnlTotal;
        private System.Windows.Forms.Label TotalLocValue;
        private System.Windows.Forms.Label lblTotal;
    }
}