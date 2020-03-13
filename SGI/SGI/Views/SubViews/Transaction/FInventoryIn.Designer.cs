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
            this.txt_produit = new System.Windows.Forms.TextBox();
            this.txt_qte = new System.Windows.Forms.TextBox();
            this.lbl_produit = new System.Windows.Forms.Label();
            this.lbl_qte = new System.Windows.Forms.Label();
            this.cbo_loc = new System.Windows.Forms.ComboBox();
            this.lbl_loc = new System.Windows.Forms.Label();
            this.btn_confirm = new System.Windows.Forms.Button();
            this.txt_nom = new System.Windows.Forms.TextBox();
            this.txt_descr = new System.Windows.Forms.TextBox();
            this.txt_marque = new System.Windows.Forms.TextBox();
            this.txt_cat = new System.Windows.Forms.TextBox();
            this.txt_dep = new System.Windows.Forms.TextBox();
            this.grp_product = new System.Windows.Forms.GroupBox();
            this.txt_productid = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.grp_product.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_produit
            // 
            this.txt_produit.Location = new System.Drawing.Point(513, 137);
            this.txt_produit.Name = "txt_produit";
            this.txt_produit.Size = new System.Drawing.Size(186, 25);
            this.txt_produit.TabIndex = 0;
            this.txt_produit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_produit_KeyPress);
            this.txt_produit.Validating += new System.ComponentModel.CancelEventHandler(this.Txt_produit_Validating);
            // 
            // txt_qte
            // 
            this.txt_qte.Location = new System.Drawing.Point(513, 198);
            this.txt_qte.Name = "txt_qte";
            this.txt_qte.Size = new System.Drawing.Size(186, 25);
            this.txt_qte.TabIndex = 1;
            this.txt_qte.Visible = false;
            this.txt_qte.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_qte_KeyPress);
            // 
            // lbl_produit
            // 
            this.lbl_produit.AutoSize = true;
            this.lbl_produit.Location = new System.Drawing.Point(435, 140);
            this.lbl_produit.Name = "lbl_produit";
            this.lbl_produit.Size = new System.Drawing.Size(61, 19);
            this.lbl_produit.TabIndex = 3;
            this.lbl_produit.Text = "Produit :";
            // 
            // lbl_qte
            // 
            this.lbl_qte.AutoSize = true;
            this.lbl_qte.Location = new System.Drawing.Point(433, 201);
            this.lbl_qte.Name = "lbl_qte";
            this.lbl_qte.Size = new System.Drawing.Size(74, 19);
            this.lbl_qte.TabIndex = 4;
            this.lbl_qte.Text = "Quantité : ";
            this.lbl_qte.Visible = false;
            // 
            // cbo_loc
            // 
            this.cbo_loc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_loc.FormattingEnabled = true;
            this.cbo_loc.Location = new System.Drawing.Point(513, 263);
            this.cbo_loc.Name = "cbo_loc";
            this.cbo_loc.Size = new System.Drawing.Size(186, 25);
            this.cbo_loc.TabIndex = 6;
            this.cbo_loc.Visible = false;
            this.cbo_loc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Cbo_loc_KeyPress);
            // 
            // lbl_loc
            // 
            this.lbl_loc.AutoSize = true;
            this.lbl_loc.Location = new System.Drawing.Point(409, 266);
            this.lbl_loc.Name = "lbl_loc";
            this.lbl_loc.Size = new System.Drawing.Size(87, 19);
            this.lbl_loc.TabIndex = 7;
            this.lbl_loc.Text = "Localisation :";
            this.lbl_loc.Visible = false;
            // 
            // btn_confirm
            // 
            this.btn_confirm.Location = new System.Drawing.Point(449, 405);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(117, 34);
            this.btn_confirm.TabIndex = 8;
            this.btn_confirm.Text = "Confirmer";
            this.btn_confirm.UseVisualStyleBackColor = true;
            this.btn_confirm.Visible = false;
            this.btn_confirm.Click += new System.EventHandler(this.Btn_confirm_Click);
            // 
            // txt_nom
            // 
            this.txt_nom.Location = new System.Drawing.Point(156, 76);
            this.txt_nom.Name = "txt_nom";
            this.txt_nom.ReadOnly = true;
            this.txt_nom.Size = new System.Drawing.Size(170, 25);
            this.txt_nom.TabIndex = 9;
            // 
            // txt_descr
            // 
            this.txt_descr.Location = new System.Drawing.Point(156, 107);
            this.txt_descr.Name = "txt_descr";
            this.txt_descr.ReadOnly = true;
            this.txt_descr.Size = new System.Drawing.Size(170, 25);
            this.txt_descr.TabIndex = 10;
            // 
            // txt_marque
            // 
            this.txt_marque.Location = new System.Drawing.Point(156, 140);
            this.txt_marque.Name = "txt_marque";
            this.txt_marque.ReadOnly = true;
            this.txt_marque.Size = new System.Drawing.Size(170, 25);
            this.txt_marque.TabIndex = 11;
            // 
            // txt_cat
            // 
            this.txt_cat.Location = new System.Drawing.Point(156, 171);
            this.txt_cat.Name = "txt_cat";
            this.txt_cat.ReadOnly = true;
            this.txt_cat.Size = new System.Drawing.Size(170, 25);
            this.txt_cat.TabIndex = 12;
            // 
            // txt_dep
            // 
            this.txt_dep.Location = new System.Drawing.Point(156, 205);
            this.txt_dep.Name = "txt_dep";
            this.txt_dep.ReadOnly = true;
            this.txt_dep.Size = new System.Drawing.Size(170, 25);
            this.txt_dep.TabIndex = 13;
            // 
            // grp_product
            // 
            this.grp_product.Controls.Add(this.txt_productid);
            this.grp_product.Controls.Add(this.label5);
            this.grp_product.Controls.Add(this.label4);
            this.grp_product.Controls.Add(this.label3);
            this.grp_product.Controls.Add(this.label2);
            this.grp_product.Controls.Add(this.label1);
            this.grp_product.Controls.Add(this.txt_nom);
            this.grp_product.Controls.Add(this.txt_dep);
            this.grp_product.Controls.Add(this.txt_descr);
            this.grp_product.Controls.Add(this.txt_cat);
            this.grp_product.Controls.Add(this.txt_marque);
            this.grp_product.Dock = System.Windows.Forms.DockStyle.Right;
            this.grp_product.Location = new System.Drawing.Point(963, 0);
            this.grp_product.Name = "grp_product";
            this.grp_product.Size = new System.Drawing.Size(338, 603);
            this.grp_product.TabIndex = 14;
            this.grp_product.TabStop = false;
            this.grp_product.Text = "Information produit";
            this.grp_product.Visible = false;
            // 
            // txt_productid
            // 
            this.txt_productid.Location = new System.Drawing.Point(156, 236);
            this.txt_productid.Name = "txt_productid";
            this.txt_productid.ReadOnly = true;
            this.txt_productid.Size = new System.Drawing.Size(170, 25);
            this.txt_productid.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 19);
            this.label5.TabIndex = 18;
            this.label5.Text = "Département :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 19);
            this.label4.TabIndex = 17;
            this.label4.Text = "Catégorie :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 19);
            this.label3.TabIndex = 16;
            this.label3.Text = "Marque :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 19);
            this.label2.TabIndex = 15;
            this.label2.Text = "Description :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 19);
            this.label1.TabIndex = 14;
            this.label1.Text = "Nom :";
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(626, 405);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(117, 34);
            this.btn_cancel.TabIndex = 15;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Visible = false;
            this.btn_cancel.Click += new System.EventHandler(this.Btn_cancel_Click);
            // 
            // FInventoryIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1301, 603);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.grp_product);
            this.Controls.Add(this.btn_confirm);
            this.Controls.Add(this.lbl_loc);
            this.Controls.Add(this.cbo_loc);
            this.Controls.Add(this.lbl_qte);
            this.Controls.Add(this.lbl_produit);
            this.Controls.Add(this.txt_qte);
            this.Controls.Add(this.txt_produit);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FInventoryIn";
            this.Text = "FInventoryIn";
            this.Load += new System.EventHandler(this.FInventoryIn_Load);
            this.grp_product.ResumeLayout(false);
            this.grp_product.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_produit;
        private System.Windows.Forms.TextBox txt_qte;
        private System.Windows.Forms.Label lbl_produit;
        private System.Windows.Forms.Label lbl_qte;
        private System.Windows.Forms.ComboBox cbo_loc;
        private System.Windows.Forms.Label lbl_loc;
        private System.Windows.Forms.Button btn_confirm;
        private System.Windows.Forms.TextBox txt_nom;
        private System.Windows.Forms.TextBox txt_descr;
        private System.Windows.Forms.TextBox txt_marque;
        private System.Windows.Forms.TextBox txt_cat;
        private System.Windows.Forms.TextBox txt_dep;
        private System.Windows.Forms.GroupBox grp_product;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_productid;
        private System.Windows.Forms.Button btn_cancel;
    }
}