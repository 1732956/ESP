namespace SGI.Views.SubViews.Management
{
    partial class FLocation
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
            this.GBLocation = new System.Windows.Forms.GroupBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.LblName = new System.Windows.Forms.Label();
            this.LBLocations = new System.Windows.Forms.ListBox();
            this.GBFilter = new System.Windows.Forms.GroupBox();
            this.ActionPanel.SuspendLayout();
            this.GBLocation.SuspendLayout();
            this.GBFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbActive
            // 
            this.cbActive.AutoSize = true;
            this.cbActive.Location = new System.Drawing.Point(502, 46);
            this.cbActive.Name = "cbActive";
            this.cbActive.Size = new System.Drawing.Size(47, 17);
            this.cbActive.TabIndex = 25;
            this.cbActive.Text = "Actif";
            this.cbActive.UseVisualStyleBackColor = true;
            // 
            // ActionPanel
            // 
            this.ActionPanel.Controls.Add(this.ucManagementAction1);
            this.ActionPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ActionPanel.Location = new System.Drawing.Point(301, 446);
            this.ActionPanel.Name = "ActionPanel";
            this.ActionPanel.Size = new System.Drawing.Size(572, 56);
            this.ActionPanel.TabIndex = 22;
            // 
            // ucManagementAction1
            // 
            this.ucManagementAction1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucManagementAction1.Location = new System.Drawing.Point(0, 0);
            this.ucManagementAction1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ucManagementAction1.Name = "ucManagementAction1";
            this.ucManagementAction1.Size = new System.Drawing.Size(572, 56);
            this.ucManagementAction1.TabIndex = 0;
            // 
            // CBFilter
            // 
            this.CBFilter.Dock = System.Windows.Forms.DockStyle.Left;
            this.CBFilter.FormattingEnabled = true;
            this.CBFilter.Location = new System.Drawing.Point(3, 16);
            this.CBFilter.Name = "CBFilter";
            this.CBFilter.Size = new System.Drawing.Size(298, 21);
            this.CBFilter.TabIndex = 0;
            // 
            // GBLocation
            // 
            this.GBLocation.Controls.Add(this.txtDescription);
            this.GBLocation.Controls.Add(this.lblDescription);
            this.GBLocation.Controls.Add(this.cbActive);
            this.GBLocation.Controls.Add(this.TxtName);
            this.GBLocation.Controls.Add(this.LblName);
            this.GBLocation.Dock = System.Windows.Forms.DockStyle.Top;
            this.GBLocation.Location = new System.Drawing.Point(301, 53);
            this.GBLocation.Name = "GBLocation";
            this.GBLocation.Size = new System.Drawing.Size(572, 173);
            this.GBLocation.TabIndex = 20;
            this.GBLocation.TabStop = false;
            this.GBLocation.Text = "Localisation";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(111, 102);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(313, 20);
            this.txtDescription.TabIndex = 27;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(30, 104);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(66, 13);
            this.lblDescription.TabIndex = 26;
            this.lblDescription.Text = "Description :";
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(111, 44);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(313, 20);
            this.TxtName.TabIndex = 5;
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Location = new System.Drawing.Point(30, 46);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(38, 13);
            this.LblName.TabIndex = 0;
            this.LblName.Text = "Nom : ";
            // 
            // LBLocations
            // 
            this.LBLocations.Dock = System.Windows.Forms.DockStyle.Left;
            this.LBLocations.FormattingEnabled = true;
            this.LBLocations.Location = new System.Drawing.Point(0, 53);
            this.LBLocations.Name = "LBLocations";
            this.LBLocations.Size = new System.Drawing.Size(301, 449);
            this.LBLocations.TabIndex = 19;
            this.LBLocations.SelectedIndexChanged += new System.EventHandler(this.LBLocations_SelectedIndexChanged);
            // 
            // GBFilter
            // 
            this.GBFilter.Controls.Add(this.CBFilter);
            this.GBFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.GBFilter.Location = new System.Drawing.Point(0, 0);
            this.GBFilter.Name = "GBFilter";
            this.GBFilter.Size = new System.Drawing.Size(873, 53);
            this.GBFilter.TabIndex = 21;
            this.GBFilter.TabStop = false;
            // 
            // FLocation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 502);
            this.Controls.Add(this.ActionPanel);
            this.Controls.Add(this.GBLocation);
            this.Controls.Add(this.LBLocations);
            this.Controls.Add(this.GBFilter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FLocation";
            this.Text = "FLocation";
            this.ActionPanel.ResumeLayout(false);
            this.GBLocation.ResumeLayout(false);
            this.GBLocation.PerformLayout();
            this.GBFilter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox cbActive;
        private System.Windows.Forms.Panel ActionPanel;
        private UCManagementAction ucManagementAction1;
        private System.Windows.Forms.ToolTip ToolTips;
        private System.Windows.Forms.ComboBox CBFilter;
        private System.Windows.Forms.GroupBox GBLocation;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.ListBox LBLocations;
        private System.Windows.Forms.GroupBox GBFilter;
    }
}