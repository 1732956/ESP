namespace SGI.Views.SubViews.Visualization
{
    partial class FMovementHistory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FMovementHistory));
            this.gbFilters = new System.Windows.Forms.GroupBox();
            this.lblMovement = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.QuantityToFilter = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.lblQty = new System.Windows.Forms.Label();
            this.lblLoc = new System.Windows.Forms.Label();
            this.lblProduct = new System.Windows.Forms.Label();
            this.DateFromFilter = new System.Windows.Forms.DateTimePicker();
            this.MovementFilter = new System.Windows.Forms.ComboBox();
            this.QuantityFromFilter = new System.Windows.Forms.NumericUpDown();
            this.LocationFilter = new System.Windows.Forms.TextBox();
            this.ProductFilter = new System.Windows.Forms.TextBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.dgvLog = new System.Windows.Forms.DataGridView();
            this.DataPanel = new System.Windows.Forms.Panel();
            this.lblDate = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DateToFilter = new System.Windows.Forms.DateTimePicker();
            this.Product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Movement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QuantityToFilter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuantityFromFilter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLog)).BeginInit();
            this.DataPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbFilters
            // 
            this.gbFilters.Controls.Add(this.DateToFilter);
            this.gbFilters.Controls.Add(this.label3);
            this.gbFilters.Controls.Add(this.label4);
            this.gbFilters.Controls.Add(this.lblDate);
            this.gbFilters.Controls.Add(this.lblMovement);
            this.gbFilters.Controls.Add(this.label2);
            this.gbFilters.Controls.Add(this.QuantityToFilter);
            this.gbFilters.Controls.Add(this.label1);
            this.gbFilters.Controls.Add(this.lblQty);
            this.gbFilters.Controls.Add(this.lblLoc);
            this.gbFilters.Controls.Add(this.lblProduct);
            this.gbFilters.Controls.Add(this.DateFromFilter);
            this.gbFilters.Controls.Add(this.MovementFilter);
            this.gbFilters.Controls.Add(this.QuantityFromFilter);
            this.gbFilters.Controls.Add(this.LocationFilter);
            this.gbFilters.Controls.Add(this.ProductFilter);
            this.gbFilters.Controls.Add(this.btnFilter);
            this.gbFilters.Dock = System.Windows.Forms.DockStyle.Left;
            this.gbFilters.Location = new System.Drawing.Point(0, 0);
            this.gbFilters.Name = "gbFilters";
            this.gbFilters.Size = new System.Drawing.Size(307, 587);
            this.gbFilters.TabIndex = 0;
            this.gbFilters.TabStop = false;
            this.gbFilters.Text = "Filtres";
            // 
            // lblMovement
            // 
            this.lblMovement.AutoSize = true;
            this.lblMovement.Location = new System.Drawing.Point(6, 187);
            this.lblMovement.Name = "lblMovement";
            this.lblMovement.Size = new System.Drawing.Size(91, 19);
            this.lblMovement.TabIndex = 14;
            this.lblMovement.Text = "Mouvement :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(200, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 19);
            this.label2.TabIndex = 13;
            this.label2.Text = "a";
            // 
            // QuantityToFilter
            // 
            this.QuantityToFilter.Location = new System.Drawing.Point(222, 133);
            this.QuantityToFilter.Name = "QuantityToFilter";
            this.QuantityToFilter.Size = new System.Drawing.Size(68, 25);
            this.QuantityToFilter.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 19);
            this.label1.TabIndex = 11;
            this.label1.Text = "De";
            // 
            // lblQty
            // 
            this.lblQty.AutoSize = true;
            this.lblQty.Location = new System.Drawing.Point(6, 135);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(70, 19);
            this.lblQty.TabIndex = 10;
            this.lblQty.Text = "Quantité :";
            // 
            // lblLoc
            // 
            this.lblLoc.AutoSize = true;
            this.lblLoc.Location = new System.Drawing.Point(6, 84);
            this.lblLoc.Name = "lblLoc";
            this.lblLoc.Size = new System.Drawing.Size(87, 19);
            this.lblLoc.TabIndex = 9;
            this.lblLoc.Text = "Localisation :";
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Location = new System.Drawing.Point(6, 33);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(61, 19);
            this.lblProduct.TabIndex = 8;
            this.lblProduct.Text = "Produit :";
            // 
            // DateFromFilter
            // 
            this.DateFromFilter.Location = new System.Drawing.Point(131, 237);
            this.DateFromFilter.Name = "DateFromFilter";
            this.DateFromFilter.Size = new System.Drawing.Size(159, 25);
            this.DateFromFilter.TabIndex = 5;
            this.DateFromFilter.Value = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            // 
            // MovementFilter
            // 
            this.MovementFilter.FormattingEnabled = true;
            this.MovementFilter.Items.AddRange(new object[] {
            "Entree",
            "Sortie"});
            this.MovementFilter.Location = new System.Drawing.Point(103, 187);
            this.MovementFilter.Name = "MovementFilter";
            this.MovementFilter.Size = new System.Drawing.Size(187, 25);
            this.MovementFilter.TabIndex = 4;
            // 
            // QuantityFromFilter
            // 
            this.QuantityFromFilter.Location = new System.Drawing.Point(131, 133);
            this.QuantityFromFilter.Name = "QuantityFromFilter";
            this.QuantityFromFilter.Size = new System.Drawing.Size(63, 25);
            this.QuantityFromFilter.TabIndex = 2;
            // 
            // LocationFilter
            // 
            this.LocationFilter.Location = new System.Drawing.Point(103, 84);
            this.LocationFilter.Name = "LocationFilter";
            this.LocationFilter.Size = new System.Drawing.Size(187, 25);
            this.LocationFilter.TabIndex = 1;
            // 
            // ProductFilter
            // 
            this.ProductFilter.Location = new System.Drawing.Point(103, 33);
            this.ProductFilter.Name = "ProductFilter";
            this.ProductFilter.Size = new System.Drawing.Size(187, 25);
            this.ProductFilter.TabIndex = 0;
            // 
            // btnFilter
            // 
            this.btnFilter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFilter.BackgroundImage")));
            this.btnFilter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFilter.Location = new System.Drawing.Point(10, 326);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(66, 44);
            this.btnFilter.TabIndex = 6;
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // dgvLog
            // 
            this.dgvLog.AllowUserToAddRows = false;
            this.dgvLog.AllowUserToDeleteRows = false;
            this.dgvLog.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLog.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Product,
            this.Location,
            this.Qty,
            this.Movement,
            this.Date});
            this.dgvLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLog.Location = new System.Drawing.Point(11, 13);
            this.dgvLog.Margin = new System.Windows.Forms.Padding(4);
            this.dgvLog.Name = "dgvLog";
            this.dgvLog.Size = new System.Drawing.Size(823, 561);
            this.dgvLog.TabIndex = 7;
            // 
            // DataPanel
            // 
            this.DataPanel.Controls.Add(this.dgvLog);
            this.DataPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataPanel.Location = new System.Drawing.Point(307, 0);
            this.DataPanel.Margin = new System.Windows.Forms.Padding(4);
            this.DataPanel.Name = "DataPanel";
            this.DataPanel.Padding = new System.Windows.Forms.Padding(11, 13, 11, 13);
            this.DataPanel.Size = new System.Drawing.Size(845, 587);
            this.DataPanel.TabIndex = 2;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(6, 237);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(45, 19);
            this.lblDate.TabIndex = 15;
            this.lblDate.Text = "Date :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(99, 270);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 19);
            this.label3.TabIndex = 19;
            this.label3.Text = "a";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(99, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 19);
            this.label4.TabIndex = 18;
            this.label4.Text = "De";
            // 
            // DateToFilter
            // 
            this.DateToFilter.Location = new System.Drawing.Point(131, 270);
            this.DateToFilter.Name = "DateToFilter";
            this.DateToFilter.Size = new System.Drawing.Size(159, 25);
            this.DateToFilter.TabIndex = 20;
            this.DateToFilter.Value = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            // 
            // Product
            // 
            this.Product.DataPropertyName = "ProdName";
            this.Product.HeaderText = "Produit";
            this.Product.Name = "Product";
            this.Product.ReadOnly = true;
            // 
            // Location
            // 
            this.Location.DataPropertyName = "LocName";
            this.Location.HeaderText = "Localisation";
            this.Location.Name = "Location";
            this.Location.ReadOnly = true;
            // 
            // Qty
            // 
            this.Qty.DataPropertyName = "QuantityDelta";
            this.Qty.HeaderText = "Quantité";
            this.Qty.Name = "Qty";
            this.Qty.ReadOnly = true;
            // 
            // Movement
            // 
            this.Movement.DataPropertyName = "Movement";
            this.Movement.HeaderText = "Mouvement";
            this.Movement.Name = "Movement";
            this.Movement.ReadOnly = true;
            // 
            // Date
            // 
            this.Date.DataPropertyName = "Date";
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // FMovementHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 587);
            this.Controls.Add(this.DataPanel);
            this.Controls.Add(this.gbFilters);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FMovementHistory";
            this.Text = "FMovementHistory";
            this.gbFilters.ResumeLayout(false);
            this.gbFilters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QuantityToFilter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuantityFromFilter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLog)).EndInit();
            this.DataPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvLog;
        private System.Windows.Forms.Panel DataPanel;
        private System.Windows.Forms.GroupBox gbFilters;
        private System.Windows.Forms.DateTimePicker DateFromFilter;
        private System.Windows.Forms.ComboBox MovementFilter;
        private System.Windows.Forms.NumericUpDown QuantityFromFilter;
        private System.Windows.Forms.TextBox LocationFilter;
        private System.Windows.Forms.TextBox ProductFilter;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.Label lblMovement;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown QuantityToFilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.Label lblLoc;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker DateToFilter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product;
        private System.Windows.Forms.DataGridViewTextBoxColumn Location;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Movement;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
    }
}