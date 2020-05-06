namespace SGI.Views.SubViews
{
    partial class FDepartment
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
            this.GBDepartment = new System.Windows.Forms.GroupBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.LblName = new System.Windows.Forms.Label();
            this.LBDepartments = new System.Windows.Forms.ListBox();
            this.GBFilter = new System.Windows.Forms.GroupBox();
            this.ActionPanel.SuspendLayout();
            this.GBDepartment.SuspendLayout();
            this.GBFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbActive
            // 
            this.cbActive.AutoSize = true;
            this.cbActive.Location = new System.Drawing.Point(34, 162);
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
            this.ActionPanel.Location = new System.Drawing.Point(301, 409);
            this.ActionPanel.Name = "ActionPanel";
            this.ActionPanel.Size = new System.Drawing.Size(585, 56);
            this.ActionPanel.TabIndex = 18;
            // 
            // ucManagementAction1
            // 
            this.ucManagementAction1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucManagementAction1.Location = new System.Drawing.Point(0, 0);
            this.ucManagementAction1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ucManagementAction1.Name = "ucManagementAction1";
            this.ucManagementAction1.Size = new System.Drawing.Size(585, 56);
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
            // GBDepartment
            // 
            this.GBDepartment.Controls.Add(this.txtDescription);
            this.GBDepartment.Controls.Add(this.lblDescription);
            this.GBDepartment.Controls.Add(this.cbActive);
            this.GBDepartment.Controls.Add(this.TxtName);
            this.GBDepartment.Controls.Add(this.LblName);
            this.GBDepartment.Dock = System.Windows.Forms.DockStyle.Top;
            this.GBDepartment.Location = new System.Drawing.Point(301, 53);
            this.GBDepartment.Name = "GBDepartment";
            this.GBDepartment.Size = new System.Drawing.Size(585, 199);
            this.GBDepartment.TabIndex = 16;
            this.GBDepartment.TabStop = false;
            this.GBDepartment.Text = "Département";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(121, 101);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(313, 25);
            this.txtDescription.TabIndex = 27;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(30, 104);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(85, 19);
            this.lblDescription.TabIndex = 26;
            this.lblDescription.Text = "Description :";
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(121, 43);
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
            // LBDepartments
            // 
            this.LBDepartments.Dock = System.Windows.Forms.DockStyle.Left;
            this.LBDepartments.FormattingEnabled = true;
            this.LBDepartments.ItemHeight = 17;
            this.LBDepartments.Location = new System.Drawing.Point(0, 53);
            this.LBDepartments.Name = "LBDepartments";
            this.LBDepartments.Size = new System.Drawing.Size(301, 412);
            this.LBDepartments.TabIndex = 15;
            this.LBDepartments.SelectedIndexChanged += new System.EventHandler(this.LBDepartments_SelectedIndexChanged);
            // 
            // GBFilter
            // 
            this.GBFilter.Controls.Add(this.CBFilter);
            this.GBFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.GBFilter.Location = new System.Drawing.Point(0, 0);
            this.GBFilter.Name = "GBFilter";
            this.GBFilter.Size = new System.Drawing.Size(886, 53);
            this.GBFilter.TabIndex = 17;
            this.GBFilter.TabStop = false;
            // 
            // FDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 465);
            this.Controls.Add(this.ActionPanel);
            this.Controls.Add(this.GBDepartment);
            this.Controls.Add(this.LBDepartments);
            this.Controls.Add(this.GBFilter);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FDepartment";
            this.Text = "FDepartment";
            this.ActionPanel.ResumeLayout(false);
            this.GBDepartment.ResumeLayout(false);
            this.GBDepartment.PerformLayout();
            this.GBFilter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox cbActive;
        private System.Windows.Forms.Panel ActionPanel;
        private UCManagementAction ucManagementAction1;
        private System.Windows.Forms.ToolTip ToolTips;
        private System.Windows.Forms.ComboBox CBFilter;
        private System.Windows.Forms.GroupBox GBDepartment;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.ListBox LBDepartments;
        private System.Windows.Forms.GroupBox GBFilter;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblDescription;
    }
}