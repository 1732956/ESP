namespace SGI.Views.SubViews
{
    partial class FSupplier
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
            this.cbActive = new System.Windows.Forms.CheckBox();
            this.ActionPanel = new System.Windows.Forms.Panel();
            this.ucManagementAction1 = new SGI.Views.UCManagementAction();
            this.ToolTips = new System.Windows.Forms.ToolTip(this.components);
            this.CBFilter = new System.Windows.Forms.ComboBox();
            this.GBSupplier = new System.Windows.Forms.GroupBox();
            this.nudMinOrderPrice = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAdress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtResourcePerson = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.LblName = new System.Windows.Forms.Label();
            this.LBSuppliers = new System.Windows.Forms.ListBox();
            this.GBFilter = new System.Windows.Forms.GroupBox();
            this.ActionPanel.SuspendLayout();
            this.GBSupplier.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinOrderPrice)).BeginInit();
            this.GBFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbActive
            // 
            this.cbActive.AutoSize = true;
            this.cbActive.Location = new System.Drawing.Point(34, 335);
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
            this.ActionPanel.Location = new System.Drawing.Point(301, 471);
            this.ActionPanel.Name = "ActionPanel";
            this.ActionPanel.Size = new System.Drawing.Size(845, 56);
            this.ActionPanel.TabIndex = 14;
            // 
            // ucManagementAction1
            // 
            this.ucManagementAction1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucManagementAction1.Location = new System.Drawing.Point(0, 0);
            this.ucManagementAction1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ucManagementAction1.Name = "ucManagementAction1";
            this.ucManagementAction1.Size = new System.Drawing.Size(845, 56);
            this.ucManagementAction1.TabIndex = 0;
            // 
            // CBFilter
            // 
            this.CBFilter.Dock = System.Windows.Forms.DockStyle.Left;
            this.CBFilter.FormattingEnabled = true;
            this.CBFilter.Location = new System.Drawing.Point(3, 21);
            this.CBFilter.Name = "CBFilter";
            this.CBFilter.Size = new System.Drawing.Size(298, 25);
            this.CBFilter.TabIndex = 0;
            // 
            // GBSupplier
            // 
            this.GBSupplier.Controls.Add(this.nudMinOrderPrice);
            this.GBSupplier.Controls.Add(this.label6);
            this.GBSupplier.Controls.Add(this.txtPhoneNumber);
            this.GBSupplier.Controls.Add(this.label5);
            this.GBSupplier.Controls.Add(this.txtEmail);
            this.GBSupplier.Controls.Add(this.label4);
            this.GBSupplier.Controls.Add(this.txtAdress);
            this.GBSupplier.Controls.Add(this.label3);
            this.GBSupplier.Controls.Add(this.txtResourcePerson);
            this.GBSupplier.Controls.Add(this.label2);
            this.GBSupplier.Controls.Add(this.cbActive);
            this.GBSupplier.Controls.Add(this.TxtName);
            this.GBSupplier.Controls.Add(this.LblName);
            this.GBSupplier.Dock = System.Windows.Forms.DockStyle.Top;
            this.GBSupplier.Location = new System.Drawing.Point(301, 53);
            this.GBSupplier.Name = "GBSupplier";
            this.GBSupplier.Size = new System.Drawing.Size(845, 411);
            this.GBSupplier.TabIndex = 9;
            this.GBSupplier.TabStop = false;
            this.GBSupplier.Text = "Fournisseur";
            // 
            // nudMinOrderPrice
            // 
            this.nudMinOrderPrice.Location = new System.Drawing.Point(240, 276);
            this.nudMinOrderPrice.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudMinOrderPrice.Name = "nudMinOrderPrice";
            this.nudMinOrderPrice.Size = new System.Drawing.Size(120, 25);
            this.nudMinOrderPrice.TabIndex = 37;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 278);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(195, 19);
            this.label6.TabIndex = 36;
            this.label6.Text = "Prix de commande minimum : ";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(240, 226);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(313, 25);
            this.txtPhoneNumber.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 19);
            this.label5.TabIndex = 34;
            this.label5.Text = "Numéro téléphone : ";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(240, 180);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(313, 25);
            this.txtEmail.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 19);
            this.label4.TabIndex = 32;
            this.label4.Text = "Email : ";
            // 
            // txtAdress
            // 
            this.txtAdress.Location = new System.Drawing.Point(240, 132);
            this.txtAdress.Name = "txtAdress";
            this.txtAdress.Size = new System.Drawing.Size(313, 25);
            this.txtAdress.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 19);
            this.label3.TabIndex = 30;
            this.label3.Text = "Adresse :";
            // 
            // txtResourcePerson
            // 
            this.txtResourcePerson.Location = new System.Drawing.Point(240, 86);
            this.txtResourcePerson.Name = "txtResourcePerson";
            this.txtResourcePerson.Size = new System.Drawing.Size(313, 25);
            this.txtResourcePerson.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 19);
            this.label2.TabIndex = 28;
            this.label2.Text = "Personne ressource :";
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(240, 43);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(313, 25);
            this.TxtName.TabIndex = 5;
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
            // LBSuppliers
            // 
            this.LBSuppliers.Dock = System.Windows.Forms.DockStyle.Left;
            this.LBSuppliers.FormattingEnabled = true;
            this.LBSuppliers.ItemHeight = 17;
            this.LBSuppliers.Location = new System.Drawing.Point(0, 53);
            this.LBSuppliers.Name = "LBSuppliers";
            this.LBSuppliers.Size = new System.Drawing.Size(301, 474);
            this.LBSuppliers.TabIndex = 8;
            this.LBSuppliers.SelectedIndexChanged += new System.EventHandler(this.LBCategories_SelectedIndexChanged);
            // 
            // GBFilter
            // 
            this.GBFilter.Controls.Add(this.CBFilter);
            this.GBFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.GBFilter.Location = new System.Drawing.Point(0, 0);
            this.GBFilter.Name = "GBFilter";
            this.GBFilter.Size = new System.Drawing.Size(1146, 53);
            this.GBFilter.TabIndex = 10;
            this.GBFilter.TabStop = false;
            // 
            // FSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1146, 527);
            this.Controls.Add(this.ActionPanel);
            this.Controls.Add(this.GBSupplier);
            this.Controls.Add(this.LBSuppliers);
            this.Controls.Add(this.GBFilter);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FSupplier";
            this.Text = "FCategory";
            this.ActionPanel.ResumeLayout(false);
            this.GBSupplier.ResumeLayout(false);
            this.GBSupplier.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinOrderPrice)).EndInit();
            this.GBFilter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox cbActive;
        private System.Windows.Forms.Panel ActionPanel;
        private UCManagementAction ucManagementAction1;
        private System.Windows.Forms.ToolTip ToolTips;
        private System.Windows.Forms.ComboBox CBFilter;
        private System.Windows.Forms.GroupBox GBSupplier;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.ListBox LBSuppliers;
        private System.Windows.Forms.GroupBox GBFilter;
        private System.Windows.Forms.NumericUpDown nudMinOrderPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAdress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtResourcePerson;
        private System.Windows.Forms.Label label2;
    }
}