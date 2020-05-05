namespace SGI.Views.SubViews.Transaction
{
    partial class FInventoryInOut
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FInventoryInOut));
            this.cbo_loc = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TCAction = new System.Windows.Forms.TabControl();
            this.TPIn = new System.Windows.Forms.TabPage();
            this.dgvInventory = new System.Windows.Forms.DataGridView();
            this.pnlMovementActions = new System.Windows.Forms.Panel();
            this.dgvMovement = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.TPOut = new System.Windows.Forms.TabPage();
            this.dgvInventoryOut = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvOutMovement = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnOutConfirm = new System.Windows.Forms.Button();
            this.btnOutDelete = new System.Windows.Forms.Button();
            this.btnOutCancel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_produit = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.Product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductID_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InvMeasUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.images = new System.Windows.Forms.ImageList(this.components);
            this.TCAction.SuspendLayout();
            this.TPIn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).BeginInit();
            this.pnlMovementActions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovement)).BeginInit();
            this.panel2.SuspendLayout();
            this.TPOut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventoryOut)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOutMovement)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbo_loc
            // 
            this.cbo_loc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_loc.FormattingEnabled = true;
            this.cbo_loc.Location = new System.Drawing.Point(111, 6);
            this.cbo_loc.Name = "cbo_loc";
            this.cbo_loc.Size = new System.Drawing.Size(165, 25);
            this.cbo_loc.TabIndex = 1;
            this.cbo_loc.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.cbo_loc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox1_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Localisations :";
            // 
            // TCAction
            // 
            this.TCAction.Controls.Add(this.TPIn);
            this.TCAction.Controls.Add(this.TPOut);
            this.TCAction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TCAction.ImageList = this.images;
            this.TCAction.Location = new System.Drawing.Point(10, 52);
            this.TCAction.Name = "TCAction";
            this.TCAction.SelectedIndex = 0;
            this.TCAction.Size = new System.Drawing.Size(998, 503);
            this.TCAction.TabIndex = 2;
            this.TCAction.SelectedIndexChanged += new System.EventHandler(this.TCAction_SelectedIndexChanged);
            // 
            // TPIn
            // 
            this.TPIn.Controls.Add(this.dgvInventory);
            this.TPIn.Controls.Add(this.pnlMovementActions);
            this.TPIn.ImageKey = "package_add.png";
            this.TPIn.Location = new System.Drawing.Point(4, 26);
            this.TPIn.Name = "TPIn";
            this.TPIn.Padding = new System.Windows.Forms.Padding(10);
            this.TPIn.Size = new System.Drawing.Size(990, 473);
            this.TPIn.TabIndex = 0;
            this.TPIn.Text = "Entrée";
            this.TPIn.UseVisualStyleBackColor = true;
            // 
            // dgvInventory
            // 
            this.dgvInventory.AllowUserToAddRows = false;
            this.dgvInventory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductID_,
            this.InvMeasUnit,
            this.Quantity});
            this.dgvInventory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvInventory.Location = new System.Drawing.Point(10, 10);
            this.dgvInventory.Name = "dgvInventory";
            this.dgvInventory.ReadOnly = true;
            this.dgvInventory.Size = new System.Drawing.Size(574, 453);
            this.dgvInventory.TabIndex = 0;
            // 
            // pnlMovementActions
            // 
            this.pnlMovementActions.Controls.Add(this.dgvMovement);
            this.pnlMovementActions.Controls.Add(this.panel2);
            this.pnlMovementActions.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlMovementActions.Location = new System.Drawing.Point(584, 10);
            this.pnlMovementActions.Name = "pnlMovementActions";
            this.pnlMovementActions.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.pnlMovementActions.Size = new System.Drawing.Size(396, 453);
            this.pnlMovementActions.TabIndex = 3;
            // 
            // dgvMovement
            // 
            this.dgvMovement.AllowUserToAddRows = false;
            this.dgvMovement.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMovement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMovement.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Product,
            this.Qty,
            this.ProductID});
            this.dgvMovement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMovement.Location = new System.Drawing.Point(6, 0);
            this.dgvMovement.Name = "dgvMovement";
            this.dgvMovement.Size = new System.Drawing.Size(390, 375);
            this.dgvMovement.TabIndex = 1;
            this.dgvMovement.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMovement_CellEndEdit);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnConfirm);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(6, 375);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(390, 78);
            this.panel2.TabIndex = 2;
            // 
            // btnConfirm
            // 
            this.btnConfirm.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnConfirm.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnConfirm.Location = new System.Drawing.Point(260, 0);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(130, 78);
            this.btnConfirm.TabIndex = 2;
            this.btnConfirm.Text = "Confirmer";
            this.toolTip1.SetToolTip(this.btnConfirm, "Confirmer tout les mouvements");
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnDelete.Location = new System.Drawing.Point(130, 0);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(130, 78);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "Supprimer";
            this.toolTip1.SetToolTip(this.btnDelete, "Supprimer le mouvement sélectionné");
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCancel.Location = new System.Drawing.Point(0, 0);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(130, 78);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Annuler";
            this.toolTip1.SetToolTip(this.btnCancel, "Modifier le mouvement sélectionné");
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // TPOut
            // 
            this.TPOut.Controls.Add(this.dgvInventoryOut);
            this.TPOut.Controls.Add(this.panel3);
            this.TPOut.ImageKey = "package_delete.png";
            this.TPOut.Location = new System.Drawing.Point(4, 26);
            this.TPOut.Name = "TPOut";
            this.TPOut.Padding = new System.Windows.Forms.Padding(10);
            this.TPOut.Size = new System.Drawing.Size(990, 473);
            this.TPOut.TabIndex = 1;
            this.TPOut.Text = "Sortie";
            this.TPOut.UseVisualStyleBackColor = true;
            // 
            // dgvInventoryOut
            // 
            this.dgvInventoryOut.AllowUserToAddRows = false;
            this.dgvInventoryOut.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInventoryOut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventoryOut.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dgvInventoryOut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvInventoryOut.Location = new System.Drawing.Point(10, 10);
            this.dgvInventoryOut.Name = "dgvInventoryOut";
            this.dgvInventoryOut.Size = new System.Drawing.Size(574, 453);
            this.dgvInventoryOut.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvOutMovement);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(584, 10);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.panel3.Size = new System.Drawing.Size(396, 453);
            this.panel3.TabIndex = 5;
            // 
            // dgvOutMovement
            // 
            this.dgvOutMovement.AllowUserToAddRows = false;
            this.dgvOutMovement.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOutMovement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOutMovement.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dgvOutMovement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOutMovement.Location = new System.Drawing.Point(6, 0);
            this.dgvOutMovement.Name = "dgvOutMovement";
            this.dgvOutMovement.Size = new System.Drawing.Size(390, 375);
            this.dgvOutMovement.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Produit";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Quantité (-)";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "ProductID";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Visible = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnOutConfirm);
            this.panel4.Controls.Add(this.btnOutDelete);
            this.panel4.Controls.Add(this.btnOutCancel);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(6, 375);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(390, 78);
            this.panel4.TabIndex = 2;
            // 
            // btnOutConfirm
            // 
            this.btnOutConfirm.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnOutConfirm.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnOutConfirm.Location = new System.Drawing.Point(260, 0);
            this.btnOutConfirm.Name = "btnOutConfirm";
            this.btnOutConfirm.Size = new System.Drawing.Size(130, 78);
            this.btnOutConfirm.TabIndex = 2;
            this.btnOutConfirm.Text = "Confirmer";
            this.toolTip1.SetToolTip(this.btnOutConfirm, "Confirmer tout les mouvements");
            this.btnOutConfirm.UseVisualStyleBackColor = true;
            this.btnOutConfirm.Click += new System.EventHandler(this.btnOutConfirm_Click);
            // 
            // btnOutDelete
            // 
            this.btnOutDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnOutDelete.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnOutDelete.Location = new System.Drawing.Point(130, 0);
            this.btnOutDelete.Name = "btnOutDelete";
            this.btnOutDelete.Size = new System.Drawing.Size(130, 78);
            this.btnOutDelete.TabIndex = 0;
            this.btnOutDelete.Text = "Supprimer";
            this.toolTip1.SetToolTip(this.btnOutDelete, "Supprimer le mouvement sélectionné");
            this.btnOutDelete.UseVisualStyleBackColor = true;
            this.btnOutDelete.Click += new System.EventHandler(this.btnOutDelete_Click);
            // 
            // btnOutCancel
            // 
            this.btnOutCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnOutCancel.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnOutCancel.Location = new System.Drawing.Point(0, 0);
            this.btnOutCancel.Name = "btnOutCancel";
            this.btnOutCancel.Size = new System.Drawing.Size(130, 78);
            this.btnOutCancel.TabIndex = 1;
            this.btnOutCancel.Text = "Annuler";
            this.toolTip1.SetToolTip(this.btnOutCancel, "Modifier le mouvement sélectionné");
            this.btnOutCancel.UseVisualStyleBackColor = true;
            this.btnOutCancel.Click += new System.EventHandler(this.btnOutCancel_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txt_produit);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbo_loc);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(998, 42);
            this.panel1.TabIndex = 3;
            // 
            // txt_produit
            // 
            this.txt_produit.Location = new System.Drawing.Point(481, 6);
            this.txt_produit.Name = "txt_produit";
            this.txt_produit.Size = new System.Drawing.Size(173, 25);
            this.txt_produit.TabIndex = 0;
            this.txt_produit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProduit_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(404, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Produit :";
            // 
            // Product
            // 
            this.Product.HeaderText = "Produit";
            this.Product.Name = "Product";
            this.Product.ReadOnly = true;
            // 
            // Qty
            // 
            this.Qty.HeaderText = "Quantité (+)";
            this.Qty.Name = "Qty";
            // 
            // ProductID
            // 
            this.ProductID.HeaderText = "ProductID";
            this.ProductID.Name = "ProductID";
            this.ProductID.ReadOnly = true;
            this.ProductID.Visible = false;
            // 
            // ProductID_
            // 
            this.ProductID_.DataPropertyName = "Name";
            this.ProductID_.HeaderText = "Produit";
            this.ProductID_.Name = "ProductID_";
            this.ProductID_.ReadOnly = true;
            // 
            // InvMeasUnit
            // 
            this.InvMeasUnit.DataPropertyName = "InvMeasUnit";
            this.InvMeasUnit.HeaderText = "Unité de mesure";
            this.InvMeasUnit.Name = "InvMeasUnit";
            this.InvMeasUnit.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.HeaderText = "Quantité";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ProductName";
            this.dataGridViewTextBoxColumn1.HeaderText = "Produit";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "MeasuringUnit";
            this.dataGridViewTextBoxColumn2.HeaderText = "Unité de mesure";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Qty";
            this.dataGridViewTextBoxColumn3.HeaderText = "Quantité";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // images
            // 
            this.images.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("images.ImageStream")));
            this.images.TransparentColor = System.Drawing.Color.Transparent;
            this.images.Images.SetKeyName(0, "package_add.png");
            this.images.Images.SetKeyName(1, "package_delete.png");
            // 
            // FInventoryInOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 565);
            this.Controls.Add(this.TCAction);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FInventoryInOut";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "FInventoryInOut";
            this.Shown += new System.EventHandler(this.FInventoryInOut_Shown);
            this.TCAction.ResumeLayout(false);
            this.TPIn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).EndInit();
            this.pnlMovementActions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovement)).EndInit();
            this.panel2.ResumeLayout(false);
            this.TPOut.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventoryOut)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOutMovement)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbo_loc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl TCAction;
        private System.Windows.Forms.TabPage TPIn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvMovement;
        private System.Windows.Forms.DataGridView dgvInventory;
        private System.Windows.Forms.TabPage TPOut;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlMovementActions;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txt_produit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.DataGridView dgvInventoryOut;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvOutMovement;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnOutConfirm;
        private System.Windows.Forms.Button btnOutDelete;
        private System.Windows.Forms.Button btnOutCancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID_;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvMeasUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.ImageList images;
    }
}