namespace SGI.Views.SubViews
{
    partial class FCategory
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
            this.GBCategory = new System.Windows.Forms.GroupBox();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.LblName = new System.Windows.Forms.Label();
            this.LBCategories = new System.Windows.Forms.ListBox();
            this.GBFilter = new System.Windows.Forms.GroupBox();
            this.ActionPanel.SuspendLayout();
            this.GBCategory.SuspendLayout();
            this.GBFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbActive
            // 
            this.cbActive.AutoSize = true;
            this.cbActive.Location = new System.Drawing.Point(34, 99);
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
            this.ActionPanel.Location = new System.Drawing.Point(301, 354);
            this.ActionPanel.Name = "ActionPanel";
            this.ActionPanel.Size = new System.Drawing.Size(504, 56);
            this.ActionPanel.TabIndex = 14;
            // 
            // ucManagementAction1
            // 
            this.ucManagementAction1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucManagementAction1.Location = new System.Drawing.Point(0, 0);
            this.ucManagementAction1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ucManagementAction1.Name = "ucManagementAction1";
            this.ucManagementAction1.Size = new System.Drawing.Size(504, 56);
            this.ucManagementAction1.TabIndex = 0;
            // 
            // CBFilter
            // 
            this.CBFilter.Dock = System.Windows.Forms.DockStyle.Left;
            this.CBFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBFilter.FormattingEnabled = true;
            this.CBFilter.Location = new System.Drawing.Point(3, 21);
            this.CBFilter.Name = "CBFilter";
            this.CBFilter.Size = new System.Drawing.Size(298, 25);
            this.CBFilter.TabIndex = 0;
            // 
            // GBCategory
            // 
            this.GBCategory.Controls.Add(this.cbActive);
            this.GBCategory.Controls.Add(this.TxtName);
            this.GBCategory.Controls.Add(this.LblName);
            this.GBCategory.Dock = System.Windows.Forms.DockStyle.Top;
            this.GBCategory.Location = new System.Drawing.Point(301, 53);
            this.GBCategory.Name = "GBCategory";
            this.GBCategory.Size = new System.Drawing.Size(504, 173);
            this.GBCategory.TabIndex = 9;
            this.GBCategory.TabStop = false;
            this.GBCategory.Text = "Catégorie";
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(111, 44);
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
            // LBCategories
            // 
            this.LBCategories.Dock = System.Windows.Forms.DockStyle.Left;
            this.LBCategories.FormattingEnabled = true;
            this.LBCategories.ItemHeight = 17;
            this.LBCategories.Location = new System.Drawing.Point(0, 53);
            this.LBCategories.Name = "LBCategories";
            this.LBCategories.Size = new System.Drawing.Size(301, 357);
            this.LBCategories.TabIndex = 8;
            this.LBCategories.SelectedIndexChanged += new System.EventHandler(this.LBCategories_SelectedIndexChanged);
            // 
            // GBFilter
            // 
            this.GBFilter.Controls.Add(this.CBFilter);
            this.GBFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.GBFilter.Location = new System.Drawing.Point(0, 0);
            this.GBFilter.Name = "GBFilter";
            this.GBFilter.Size = new System.Drawing.Size(805, 53);
            this.GBFilter.TabIndex = 10;
            this.GBFilter.TabStop = false;
            // 
            // FCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 410);
            this.Controls.Add(this.ActionPanel);
            this.Controls.Add(this.GBCategory);
            this.Controls.Add(this.LBCategories);
            this.Controls.Add(this.GBFilter);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FCategory";
            this.Text = "FCategory";
            this.ActionPanel.ResumeLayout(false);
            this.GBCategory.ResumeLayout(false);
            this.GBCategory.PerformLayout();
            this.GBFilter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox cbActive;
        private System.Windows.Forms.Panel ActionPanel;
        private UCManagementAction ucManagementAction1;
        private System.Windows.Forms.ToolTip ToolTips;
        private System.Windows.Forms.ComboBox CBFilter;
        private System.Windows.Forms.GroupBox GBCategory;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.ListBox LBCategories;
        private System.Windows.Forms.GroupBox GBFilter;
    }
}