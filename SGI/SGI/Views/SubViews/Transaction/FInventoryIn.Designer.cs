namespace SGI.Views.SubViews
{
    partial class FInventoryIn
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
            this.txt_produit = new System.Windows.Forms.TextBox();
            this.lbl_produit = new System.Windows.Forms.Label();
            this.cbo_loc = new System.Windows.Forms.ComboBox();
            this.lbl_loc = new System.Windows.Forms.Label();
            this.btn_enterInInventory = new System.Windows.Forms.Button();
            this.btn_deleteCurrentProduct = new System.Windows.Forms.Button();
            this.DGVOrder = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancelOrder = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.Product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGVOrder)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_produit
            // 
            this.txt_produit.Location = new System.Drawing.Point(209, 153);
            this.txt_produit.Name = "txt_produit";
            this.txt_produit.Size = new System.Drawing.Size(186, 25);
            this.txt_produit.TabIndex = 0;
            this.txt_produit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_produit_KeyPress);
            // 
            // lbl_produit
            // 
            this.lbl_produit.AutoSize = true;
            this.lbl_produit.Location = new System.Drawing.Point(105, 156);
            this.lbl_produit.Name = "lbl_produit";
            this.lbl_produit.Size = new System.Drawing.Size(61, 19);
            this.lbl_produit.TabIndex = 3;
            this.lbl_produit.Text = "Produit :";
            // 
            // cbo_loc
            // 
            this.cbo_loc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_loc.FormattingEnabled = true;
            this.cbo_loc.Location = new System.Drawing.Point(209, 107);
            this.cbo_loc.Name = "cbo_loc";
            this.cbo_loc.Size = new System.Drawing.Size(186, 25);
            this.cbo_loc.TabIndex = 6;
            this.cbo_loc.SelectedIndexChanged += new System.EventHandler(this.cbo_loc_SelectedIndexChanged);
            this.cbo_loc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Cbo_loc_KeyPress);
            // 
            // lbl_loc
            // 
            this.lbl_loc.AutoSize = true;
            this.lbl_loc.Location = new System.Drawing.Point(105, 110);
            this.lbl_loc.Name = "lbl_loc";
            this.lbl_loc.Size = new System.Drawing.Size(87, 19);
            this.lbl_loc.TabIndex = 7;
            this.lbl_loc.Text = "Localisation :";
            // 
            // btn_enterInInventory
            // 
            this.btn_enterInInventory.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_enterInInventory.Enabled = false;
            this.btn_enterInInventory.Location = new System.Drawing.Point(1158, 0);
            this.btn_enterInInventory.Name = "btn_enterInInventory";
            this.btn_enterInInventory.Size = new System.Drawing.Size(143, 51);
            this.btn_enterInInventory.TabIndex = 8;
            this.btn_enterInInventory.Text = "Confirmer";
            this.toolTip1.SetToolTip(this.btn_enterInInventory, "Entrer en inventaire la liste des produits ci-dessus");
            this.btn_enterInInventory.UseVisualStyleBackColor = true;
            this.btn_enterInInventory.Click += new System.EventHandler(this.Btn_confirm_Click);
            // 
            // btn_deleteCurrentProduct
            // 
            this.btn_deleteCurrentProduct.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_deleteCurrentProduct.Enabled = false;
            this.btn_deleteCurrentProduct.Location = new System.Drawing.Point(872, 0);
            this.btn_deleteCurrentProduct.Name = "btn_deleteCurrentProduct";
            this.btn_deleteCurrentProduct.Size = new System.Drawing.Size(143, 51);
            this.btn_deleteCurrentProduct.TabIndex = 15;
            this.btn_deleteCurrentProduct.Text = "Supprimer";
            this.toolTip1.SetToolTip(this.btn_deleteCurrentProduct, "Supprimer le produit sélectionné");
            this.btn_deleteCurrentProduct.UseVisualStyleBackColor = true;
            this.btn_deleteCurrentProduct.Click += new System.EventHandler(this.btn_deleteCurrentProduct_Click);
            // 
            // DGVOrder
            // 
            this.DGVOrder.AllowUserToAddRows = false;
            this.DGVOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Product,
            this.Quantity,
            this.ProductID});
            this.DGVOrder.Dock = System.Windows.Forms.DockStyle.Right;
            this.DGVOrder.Location = new System.Drawing.Point(872, 0);
            this.DGVOrder.MultiSelect = false;
            this.DGVOrder.Name = "DGVOrder";
            this.DGVOrder.Size = new System.Drawing.Size(429, 552);
            this.DGVOrder.TabIndex = 16;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_deleteCurrentProduct);
            this.panel1.Controls.Add(this.btnCancelOrder);
            this.panel1.Controls.Add(this.btn_enterInInventory);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 552);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1301, 51);
            this.panel1.TabIndex = 17;
            // 
            // btnCancelOrder
            // 
            this.btnCancelOrder.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCancelOrder.Enabled = false;
            this.btnCancelOrder.Location = new System.Drawing.Point(1015, 0);
            this.btnCancelOrder.Name = "btnCancelOrder";
            this.btnCancelOrder.Size = new System.Drawing.Size(143, 51);
            this.btnCancelOrder.TabIndex = 16;
            this.btnCancelOrder.Text = "Annuler";
            this.toolTip1.SetToolTip(this.btnCancelOrder, "Anuller la commande ci-dessus");
            this.btnCancelOrder.UseVisualStyleBackColor = true;
            this.btnCancelOrder.Click += new System.EventHandler(this.btnCancelOrder_Click);
            // 
            // Product
            // 
            this.Product.HeaderText = "Produit";
            this.Product.Name = "Product";
            this.Product.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantité (+)";
            this.Quantity.Name = "Quantity";
            // 
            // ProductID
            // 
            this.ProductID.HeaderText = "ProductID";
            this.ProductID.Name = "ProductID";
            this.ProductID.ReadOnly = true;
            this.ProductID.Visible = false;
            // 
            // FInventoryIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1301, 603);
            this.Controls.Add(this.DGVOrder);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_loc);
            this.Controls.Add(this.cbo_loc);
            this.Controls.Add(this.lbl_produit);
            this.Controls.Add(this.txt_produit);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FInventoryIn";
            this.Text = "FInventoryIn";
            this.Load += new System.EventHandler(this.FInventoryIn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVOrder)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_produit;
        private System.Windows.Forms.Label lbl_produit;
        private System.Windows.Forms.ComboBox cbo_loc;
        private System.Windows.Forms.Label lbl_loc;
        private System.Windows.Forms.Button btn_enterInInventory;
        private System.Windows.Forms.Button btn_deleteCurrentProduct;
        private System.Windows.Forms.DataGridView DGVOrder;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnCancelOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
    }
}