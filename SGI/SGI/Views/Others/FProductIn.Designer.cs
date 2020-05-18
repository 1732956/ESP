namespace SGI.Views.SubViews.Transaction
{
    partial class FProductIn
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
            this.formTimer = new System.Windows.Forms.Timer(this.components);
            this.lblBrand = new System.Windows.Forms.Label();
            this.txtBrand = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSupplier = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nudQtyOut = new System.Windows.Forms.NumericUpDown();
            this.lblQtyOut = new System.Windows.Forms.Label();
            this.productName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudQtyOut)).BeginInit();
            this.SuspendLayout();
            // 
            // formTimer
            // 
            this.formTimer.Interval = 5000;
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Location = new System.Drawing.Point(12, 41);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(57, 19);
            this.lblBrand.TabIndex = 1;
            this.lblBrand.Text = "Marque";
            // 
            // txtBrand
            // 
            this.txtBrand.Location = new System.Drawing.Point(138, 38);
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.ReadOnly = true;
            this.txtBrand.Size = new System.Drawing.Size(227, 25);
            this.txtBrand.TabIndex = 2;
            // 
            // btnCancel
            // 
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.ImageKey = "(none)";
            this.btnCancel.Location = new System.Drawing.Point(121, 250);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(81, 39);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Annuler";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(138, 162);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(227, 25);
            this.txtPrice.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Prix";
            // 
            // txtCategory
            // 
            this.txtCategory.Location = new System.Drawing.Point(138, 81);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.ReadOnly = true;
            this.txtCategory.Size = new System.Drawing.Size(227, 25);
            this.txtCategory.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "Catégorie";
            // 
            // txtSupplier
            // 
            this.txtSupplier.Location = new System.Drawing.Point(138, 122);
            this.txtSupplier.Name = "txtSupplier";
            this.txtSupplier.ReadOnly = true;
            this.txtSupplier.Size = new System.Drawing.Size(227, 25);
            this.txtSupplier.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 19);
            this.label4.TabIndex = 11;
            this.label4.Text = "Fournisseur";
            // 
            // nudQtyOut
            // 
            this.nudQtyOut.DecimalPlaces = 2;
            this.nudQtyOut.Location = new System.Drawing.Point(138, 207);
            this.nudQtyOut.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudQtyOut.Name = "nudQtyOut";
            this.nudQtyOut.Size = new System.Drawing.Size(227, 25);
            this.nudQtyOut.TabIndex = 17;
            this.nudQtyOut.Visible = false;
            // 
            // lblQtyOut
            // 
            this.lblQtyOut.AutoSize = true;
            this.lblQtyOut.Location = new System.Drawing.Point(12, 206);
            this.lblQtyOut.Name = "lblQtyOut";
            this.lblQtyOut.Size = new System.Drawing.Size(120, 19);
            this.lblQtyOut.TabIndex = 16;
            this.lblQtyOut.Text = "Quantité de sortie";
            this.lblQtyOut.Visible = false;
            // 
            // productName
            // 
            this.productName.AutoSize = true;
            this.productName.Location = new System.Drawing.Point(107, 9);
            this.productName.Name = "productName";
            this.productName.Size = new System.Drawing.Size(0, 19);
            this.productName.TabIndex = 15;
            // 
            // FProductIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 301);
            this.Controls.Add(this.nudQtyOut);
            this.Controls.Add(this.lblQtyOut);
            this.Controls.Add(this.productName);
            this.Controls.Add(this.txtSupplier);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCategory);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtBrand);
            this.Controls.Add(this.lblBrand);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FProductIn";
            ((System.ComponentModel.ISupportInitialize)(this.nudQtyOut)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer formTimer;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.TextBox txtBrand;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSupplier;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudQtyOut;
        private System.Windows.Forms.Label lblQtyOut;
        private System.Windows.Forms.Label productName;
    }
}