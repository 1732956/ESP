namespace SGI.Views.SubViews.Integration
{
    partial class FIntegration
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
            this.lblConnexionBD = new System.Windows.Forms.Label();
            this.txtConnexionBD = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblConnexionBD
            // 
            this.lblConnexionBD.AutoSize = true;
            this.lblConnexionBD.Location = new System.Drawing.Point(13, 13);
            this.lblConnexionBD.Name = "lblConnexionBD";
            this.lblConnexionBD.Size = new System.Drawing.Size(213, 19);
            this.lblConnexionBD.TabIndex = 0;
            this.lblConnexionBD.Text = "Connexion a la base de données :";
            // 
            // txtConnexionBD
            // 
            this.txtConnexionBD.Location = new System.Drawing.Point(257, 11);
            this.txtConnexionBD.Name = "txtConnexionBD";
            this.txtConnexionBD.Size = new System.Drawing.Size(325, 25);
            this.txtConnexionBD.TabIndex = 1;
            this.txtConnexionBD.TextChanged += new System.EventHandler(this.ValueChanged);
            // 
            // FIntegration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 501);
            this.Controls.Add(this.txtConnexionBD);
            this.Controls.Add(this.lblConnexionBD);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FIntegration";
            this.Text = "FIntegration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblConnexionBD;
        private System.Windows.Forms.TextBox txtConnexionBD;
    }
}