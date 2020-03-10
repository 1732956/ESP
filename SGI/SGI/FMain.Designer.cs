namespace SGI
{
    partial class FMain
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FMain));
            this.TCMain = new System.Windows.Forms.TabControl();
            this.TPManagement = new System.Windows.Forms.TabPage();
            this.tabproduit = new System.Windows.Forms.TabControl();
            this.Produit = new System.Windows.Forms.TabPage();
            this.Unitedemesure = new System.Windows.Forms.TabPage();
            this.Catégorie = new System.Windows.Forms.TabPage();
            this.Département = new System.Windows.Forms.TabPage();
            this.TPVisualization = new System.Windows.Forms.TabPage();
            this.TPTransaction = new System.Windows.Forms.TabPage();
            this.TCTransaction = new System.Windows.Forms.TabControl();
            this.TPIn = new System.Windows.Forms.TabPage();
            this.TPOut = new System.Windows.Forms.TabPage();
            this.TCMain.SuspendLayout();
            this.TPManagement.SuspendLayout();
            this.tabproduit.SuspendLayout();
            this.TPTransaction.SuspendLayout();
            this.TCTransaction.SuspendLayout();
            this.SuspendLayout();
            // 
            // TCMain
            // 
            this.TCMain.Controls.Add(this.TPManagement);
            this.TCMain.Controls.Add(this.TPVisualization);
            this.TCMain.Controls.Add(this.TPTransaction);
            resources.ApplyResources(this.TCMain, "TCMain");
            this.TCMain.Name = "TCMain";
            this.TCMain.SelectedIndex = 0;
            // 
            // TPManagement
            // 
            this.TPManagement.Controls.Add(this.tabproduit);
            resources.ApplyResources(this.TPManagement, "TPManagement");
            this.TPManagement.Name = "TPManagement";
            this.TPManagement.UseVisualStyleBackColor = true;
            // 
            // tabproduit
            // 
            this.tabproduit.Controls.Add(this.Produit);
            this.tabproduit.Controls.Add(this.Unitedemesure);
            this.tabproduit.Controls.Add(this.Catégorie);
            this.tabproduit.Controls.Add(this.Département);
            resources.ApplyResources(this.tabproduit, "tabproduit");
            this.tabproduit.Name = "tabproduit";
            this.tabproduit.SelectedIndex = 0;
            // 
            // Produit
            // 
            resources.ApplyResources(this.Produit, "Produit");
            this.Produit.Name = "Produit";
            this.Produit.UseVisualStyleBackColor = true;
            // 
            // Unitedemesure
            // 
            resources.ApplyResources(this.Unitedemesure, "Unitedemesure");
            this.Unitedemesure.Name = "Unitedemesure";
            this.Unitedemesure.UseVisualStyleBackColor = true;
            // 
            // Catégorie
            // 
            resources.ApplyResources(this.Catégorie, "Catégorie");
            this.Catégorie.Name = "Catégorie";
            this.Catégorie.UseVisualStyleBackColor = true;
            // 
            // Département
            // 
            resources.ApplyResources(this.Département, "Département");
            this.Département.Name = "Département";
            this.Département.UseVisualStyleBackColor = true;
            // 
            // TPVisualization
            // 
            resources.ApplyResources(this.TPVisualization, "TPVisualization");
            this.TPVisualization.Name = "TPVisualization";
            this.TPVisualization.UseVisualStyleBackColor = true;
            // 
            // TPTransaction
            // 
            this.TPTransaction.Controls.Add(this.TCTransaction);
            resources.ApplyResources(this.TPTransaction, "TPTransaction");
            this.TPTransaction.Name = "TPTransaction";
            this.TPTransaction.UseVisualStyleBackColor = true;
            // 
            // TCTransaction
            // 
            this.TCTransaction.Controls.Add(this.TPIn);
            this.TCTransaction.Controls.Add(this.TPOut);
            resources.ApplyResources(this.TCTransaction, "TCTransaction");
            this.TCTransaction.Name = "TCTransaction";
            this.TCTransaction.SelectedIndex = 0;
            // 
            // TPIn
            // 
            resources.ApplyResources(this.TPIn, "TPIn");
            this.TPIn.Name = "TPIn";
            this.TPIn.UseVisualStyleBackColor = true;
            // 
            // TPOut
            // 
            resources.ApplyResources(this.TPOut, "TPOut");
            this.TPOut.Name = "TPOut";
            this.TPOut.UseVisualStyleBackColor = true;
            // 
            // FMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TCMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.TCMain.ResumeLayout(false);
            this.TPManagement.ResumeLayout(false);
            this.tabproduit.ResumeLayout(false);
            this.TPTransaction.ResumeLayout(false);
            this.TCTransaction.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TCMain;
        private System.Windows.Forms.TabPage TPManagement;
        private System.Windows.Forms.TabPage TPVisualization;
        private System.Windows.Forms.TabPage TPTransaction;
        private System.Windows.Forms.TabControl TCTransaction;
        private System.Windows.Forms.TabPage TPIn;
        private System.Windows.Forms.TabPage TPOut;
        private System.Windows.Forms.TabControl tabproduit;
        private System.Windows.Forms.TabPage Produit;
        private System.Windows.Forms.TabPage Unitedemesure;
        private System.Windows.Forms.TabPage Catégorie;
        private System.Windows.Forms.TabPage Département;
    }
}

