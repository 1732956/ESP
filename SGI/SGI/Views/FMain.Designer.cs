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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FMain));
            this.TCMain = new System.Windows.Forms.TabControl();
            this.TPTransaction = new System.Windows.Forms.TabPage();
            this.TCTransaction = new System.Windows.Forms.TabControl();
            this.TPIn = new System.Windows.Forms.TabPage();
            this.InPanel = new System.Windows.Forms.Panel();
            this.TPOut = new System.Windows.Forms.TabPage();
            this.OutPanel = new System.Windows.Forms.Panel();
            this.TransactionImages = new System.Windows.Forms.ImageList(this.components);
            this.TPManagement = new System.Windows.Forms.TabPage();
            this.TCManagement = new System.Windows.Forms.TabControl();
            this.TPProduct = new System.Windows.Forms.TabPage();
            this.ProductPanel = new System.Windows.Forms.Panel();
            this.TPLocation = new System.Windows.Forms.TabPage();
            this.LocationPanel = new System.Windows.Forms.Panel();
            this.TPCategory = new System.Windows.Forms.TabPage();
            this.CategoryPanel = new System.Windows.Forms.Panel();
            this.TPDepartment = new System.Windows.Forms.TabPage();
            this.DepartmentPanel = new System.Windows.Forms.Panel();
            this.TPMeasuringUnit = new System.Windows.Forms.TabPage();
            this.MeasuringUnitPanel = new System.Windows.Forms.Panel();
            this.ManagementImages = new System.Windows.Forms.ImageList(this.components);
            this.TPVisualization = new System.Windows.Forms.TabPage();
            this.TCVisuzalization = new System.Windows.Forms.TabControl();
            this.TPStockGeneral = new System.Windows.Forms.TabPage();
            this.GeneralStockPanel = new System.Windows.Forms.Panel();
            this.TPStockByLoc = new System.Windows.Forms.TabPage();
            this.LocStcokPanel = new System.Windows.Forms.Panel();
            this.TPOrdersToMake = new System.Windows.Forms.TabPage();
            this.OrdersToDoPanel = new System.Windows.Forms.Panel();
            this.TPItemsTooMuch = new System.Windows.Forms.TabPage();
            this.ItemsTooMuchPanel = new System.Windows.Forms.Panel();
            this.VidualizationImages = new System.Windows.Forms.ImageList(this.components);
            this.TCMain.SuspendLayout();
            this.TPTransaction.SuspendLayout();
            this.TCTransaction.SuspendLayout();
            this.TPIn.SuspendLayout();
            this.TPOut.SuspendLayout();
            this.TPManagement.SuspendLayout();
            this.TCManagement.SuspendLayout();
            this.TPProduct.SuspendLayout();
            this.TPLocation.SuspendLayout();
            this.TPCategory.SuspendLayout();
            this.TPDepartment.SuspendLayout();
            this.TPMeasuringUnit.SuspendLayout();
            this.TPVisualization.SuspendLayout();
            this.TCVisuzalization.SuspendLayout();
            this.TPStockGeneral.SuspendLayout();
            this.TPStockByLoc.SuspendLayout();
            this.TPOrdersToMake.SuspendLayout();
            this.TPItemsTooMuch.SuspendLayout();
            this.SuspendLayout();
            // 
            // TCMain
            // 
            this.TCMain.Controls.Add(this.TPTransaction);
            this.TCMain.Controls.Add(this.TPManagement);
            this.TCMain.Controls.Add(this.TPVisualization);
            resources.ApplyResources(this.TCMain, "TCMain");
            this.TCMain.Name = "TCMain";
            this.TCMain.SelectedIndex = 0;
            this.TCMain.SelectedIndexChanged += new System.EventHandler(this.TCMain_SelectedIndexChanged);
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
            this.TCTransaction.ImageList = this.TransactionImages;
            this.TCTransaction.Name = "TCTransaction";
            this.TCTransaction.SelectedIndex = 0;
            // 
            // TPIn
            // 
            this.TPIn.Controls.Add(this.InPanel);
            resources.ApplyResources(this.TPIn, "TPIn");
            this.TPIn.Name = "TPIn";
            this.TPIn.UseVisualStyleBackColor = true;
            this.TPIn.Enter += new System.EventHandler(this.TPIn_Enter);
            this.TPIn.Leave += new System.EventHandler(this.TPIn_Leave);
            // 
            // InPanel
            // 
            resources.ApplyResources(this.InPanel, "InPanel");
            this.InPanel.Name = "InPanel";
            // 
            // TPOut
            // 
            this.TPOut.Controls.Add(this.OutPanel);
            resources.ApplyResources(this.TPOut, "TPOut");
            this.TPOut.Name = "TPOut";
            this.TPOut.UseVisualStyleBackColor = true;
            this.TPOut.Enter += new System.EventHandler(this.TPOut_Enter);
            this.TPOut.Leave += new System.EventHandler(this.TPOut_Leave);
            // 
            // OutPanel
            // 
            resources.ApplyResources(this.OutPanel, "OutPanel");
            this.OutPanel.Name = "OutPanel";
            // 
            // TransactionImages
            // 
            this.TransactionImages.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("TransactionImages.ImageStream")));
            this.TransactionImages.TransparentColor = System.Drawing.Color.Transparent;
            this.TransactionImages.Images.SetKeyName(0, "InventoryIn.png");
            this.TransactionImages.Images.SetKeyName(1, "InventoryOut.png");
            // 
            // TPManagement
            // 
            this.TPManagement.Controls.Add(this.TCManagement);
            resources.ApplyResources(this.TPManagement, "TPManagement");
            this.TPManagement.Name = "TPManagement";
            this.TPManagement.UseVisualStyleBackColor = true;
            // 
            // TCManagement
            // 
            this.TCManagement.Controls.Add(this.TPProduct);
            this.TCManagement.Controls.Add(this.TPLocation);
            this.TCManagement.Controls.Add(this.TPCategory);
            this.TCManagement.Controls.Add(this.TPDepartment);
            this.TCManagement.Controls.Add(this.TPMeasuringUnit);
            resources.ApplyResources(this.TCManagement, "TCManagement");
            this.TCManagement.ImageList = this.ManagementImages;
            this.TCManagement.Name = "TCManagement";
            this.TCManagement.SelectedIndex = 0;
            // 
            // TPProduct
            // 
            this.TPProduct.Controls.Add(this.ProductPanel);
            resources.ApplyResources(this.TPProduct, "TPProduct");
            this.TPProduct.Name = "TPProduct";
            this.TPProduct.UseVisualStyleBackColor = true;
            this.TPProduct.Enter += new System.EventHandler(this.TPProduct_Enter);
            this.TPProduct.Leave += new System.EventHandler(this.TPProduct_Leave);
            // 
            // ProductPanel
            // 
            resources.ApplyResources(this.ProductPanel, "ProductPanel");
            this.ProductPanel.Name = "ProductPanel";
            // 
            // TPLocation
            // 
            this.TPLocation.Controls.Add(this.LocationPanel);
            resources.ApplyResources(this.TPLocation, "TPLocation");
            this.TPLocation.Name = "TPLocation";
            this.TPLocation.UseVisualStyleBackColor = true;
            this.TPLocation.Enter += new System.EventHandler(this.TPLocation_Enter);
            this.TPLocation.Leave += new System.EventHandler(this.TPLocation_Leave);
            // 
            // LocationPanel
            // 
            resources.ApplyResources(this.LocationPanel, "LocationPanel");
            this.LocationPanel.Name = "LocationPanel";
            // 
            // TPCategory
            // 
            this.TPCategory.Controls.Add(this.CategoryPanel);
            resources.ApplyResources(this.TPCategory, "TPCategory");
            this.TPCategory.Name = "TPCategory";
            this.TPCategory.UseVisualStyleBackColor = true;
            this.TPCategory.Enter += new System.EventHandler(this.TPCategory_Enter);
            this.TPCategory.Leave += new System.EventHandler(this.TPCategory_Leave);
            // 
            // CategoryPanel
            // 
            resources.ApplyResources(this.CategoryPanel, "CategoryPanel");
            this.CategoryPanel.Name = "CategoryPanel";
            // 
            // TPDepartment
            // 
            this.TPDepartment.Controls.Add(this.DepartmentPanel);
            resources.ApplyResources(this.TPDepartment, "TPDepartment");
            this.TPDepartment.Name = "TPDepartment";
            this.TPDepartment.UseVisualStyleBackColor = true;
            this.TPDepartment.Enter += new System.EventHandler(this.TPDepartment_Enter);
            this.TPDepartment.Leave += new System.EventHandler(this.TPDepartment_Leave);
            // 
            // DepartmentPanel
            // 
            resources.ApplyResources(this.DepartmentPanel, "DepartmentPanel");
            this.DepartmentPanel.Name = "DepartmentPanel";
            // 
            // TPMeasuringUnit
            // 
            this.TPMeasuringUnit.Controls.Add(this.MeasuringUnitPanel);
            resources.ApplyResources(this.TPMeasuringUnit, "TPMeasuringUnit");
            this.TPMeasuringUnit.Name = "TPMeasuringUnit";
            this.TPMeasuringUnit.UseVisualStyleBackColor = true;
            this.TPMeasuringUnit.Enter += new System.EventHandler(this.TPMeasuringUnit_Enter);
            this.TPMeasuringUnit.Leave += new System.EventHandler(this.TPMeasuringUnit_Leave);
            // 
            // MeasuringUnitPanel
            // 
            resources.ApplyResources(this.MeasuringUnitPanel, "MeasuringUnitPanel");
            this.MeasuringUnitPanel.Name = "MeasuringUnitPanel";
            // 
            // ManagementImages
            // 
            this.ManagementImages.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ManagementImages.ImageStream")));
            this.ManagementImages.TransparentColor = System.Drawing.Color.Transparent;
            this.ManagementImages.Images.SetKeyName(0, "Category.png");
            this.ManagementImages.Images.SetKeyName(1, "Department.png");
            this.ManagementImages.Images.SetKeyName(2, "MeasuringUnit.png");
            this.ManagementImages.Images.SetKeyName(3, "Product.png");
            this.ManagementImages.Images.SetKeyName(4, "Location.png");
            // 
            // TPVisualization
            // 
            this.TPVisualization.Controls.Add(this.TCVisuzalization);
            resources.ApplyResources(this.TPVisualization, "TPVisualization");
            this.TPVisualization.Name = "TPVisualization";
            this.TPVisualization.UseVisualStyleBackColor = true;
            // 
            // TCVisuzalization
            // 
            this.TCVisuzalization.Controls.Add(this.TPStockGeneral);
            this.TCVisuzalization.Controls.Add(this.TPStockByLoc);
            this.TCVisuzalization.Controls.Add(this.TPOrdersToMake);
            this.TCVisuzalization.Controls.Add(this.TPItemsTooMuch);
            resources.ApplyResources(this.TCVisuzalization, "TCVisuzalization");
            this.TCVisuzalization.ImageList = this.VidualizationImages;
            this.TCVisuzalization.Name = "TCVisuzalization";
            this.TCVisuzalization.SelectedIndex = 0;
            // 
            // TPStockGeneral
            // 
            this.TPStockGeneral.Controls.Add(this.GeneralStockPanel);
            resources.ApplyResources(this.TPStockGeneral, "TPStockGeneral");
            this.TPStockGeneral.Name = "TPStockGeneral";
            this.TPStockGeneral.UseVisualStyleBackColor = true;
            this.TPStockGeneral.Enter += new System.EventHandler(this.TPStockGeneral_Enter);
            this.TPStockGeneral.Leave += new System.EventHandler(this.TPStockGeneral_Leave);
            // 
            // GeneralStockPanel
            // 
            resources.ApplyResources(this.GeneralStockPanel, "GeneralStockPanel");
            this.GeneralStockPanel.Name = "GeneralStockPanel";
            // 
            // TPStockByLoc
            // 
            this.TPStockByLoc.Controls.Add(this.LocStcokPanel);
            resources.ApplyResources(this.TPStockByLoc, "TPStockByLoc");
            this.TPStockByLoc.Name = "TPStockByLoc";
            this.TPStockByLoc.UseVisualStyleBackColor = true;
            this.TPStockByLoc.Enter += new System.EventHandler(this.TPStockByLoc_Enter);
            this.TPStockByLoc.Leave += new System.EventHandler(this.TPStockByLoc_Leave);
            // 
            // LocStcokPanel
            // 
            resources.ApplyResources(this.LocStcokPanel, "LocStcokPanel");
            this.LocStcokPanel.Name = "LocStcokPanel";
            // 
            // TPOrdersToMake
            // 
            this.TPOrdersToMake.Controls.Add(this.OrdersToDoPanel);
            resources.ApplyResources(this.TPOrdersToMake, "TPOrdersToMake");
            this.TPOrdersToMake.Name = "TPOrdersToMake";
            this.TPOrdersToMake.UseVisualStyleBackColor = true;
            this.TPOrdersToMake.Enter += new System.EventHandler(this.TPOrdersToMake_Enter);
            this.TPOrdersToMake.Leave += new System.EventHandler(this.TPOrdersToMake_Leave);
            // 
            // OrdersToDoPanel
            // 
            resources.ApplyResources(this.OrdersToDoPanel, "OrdersToDoPanel");
            this.OrdersToDoPanel.Name = "OrdersToDoPanel";
            this.OrdersToDoPanel.Enter += new System.EventHandler(this.OrdersToDoPanel_Enter);
            // 
            // TPItemsTooMuch
            // 
            this.TPItemsTooMuch.Controls.Add(this.ItemsTooMuchPanel);
            resources.ApplyResources(this.TPItemsTooMuch, "TPItemsTooMuch");
            this.TPItemsTooMuch.Name = "TPItemsTooMuch";
            this.TPItemsTooMuch.UseVisualStyleBackColor = true;
            this.TPItemsTooMuch.Enter += new System.EventHandler(this.TPItemsTooMuch_Enter);
            this.TPItemsTooMuch.Leave += new System.EventHandler(this.TPItemsTooMuch_Leave);
            // 
            // ItemsTooMuchPanel
            // 
            resources.ApplyResources(this.ItemsTooMuchPanel, "ItemsTooMuchPanel");
            this.ItemsTooMuchPanel.Name = "ItemsTooMuchPanel";
            // 
            // VidualizationImages
            // 
            this.VidualizationImages.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("VidualizationImages.ImageStream")));
            this.VidualizationImages.TransparentColor = System.Drawing.Color.Transparent;
            this.VidualizationImages.Images.SetKeyName(0, "GeneralStock.png");
            this.VidualizationImages.Images.SetKeyName(1, "ItemsTooMuch.png");
            this.VidualizationImages.Images.SetKeyName(2, "LocStock.png");
            this.VidualizationImages.Images.SetKeyName(3, "OrdersToDo.png");
            // 
            // FMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TCMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FMain_Load);
            this.TCMain.ResumeLayout(false);
            this.TPTransaction.ResumeLayout(false);
            this.TCTransaction.ResumeLayout(false);
            this.TPIn.ResumeLayout(false);
            this.TPOut.ResumeLayout(false);
            this.TPManagement.ResumeLayout(false);
            this.TCManagement.ResumeLayout(false);
            this.TPProduct.ResumeLayout(false);
            this.TPLocation.ResumeLayout(false);
            this.TPCategory.ResumeLayout(false);
            this.TPDepartment.ResumeLayout(false);
            this.TPMeasuringUnit.ResumeLayout(false);
            this.TPVisualization.ResumeLayout(false);
            this.TCVisuzalization.ResumeLayout(false);
            this.TPStockGeneral.ResumeLayout(false);
            this.TPStockByLoc.ResumeLayout(false);
            this.TPOrdersToMake.ResumeLayout(false);
            this.TPItemsTooMuch.ResumeLayout(false);
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
        private System.Windows.Forms.TabControl TCManagement;
        private System.Windows.Forms.TabPage TPProduct;
        private System.Windows.Forms.TabPage TPMeasuringUnit;
        private System.Windows.Forms.TabPage TPCategory;
        private System.Windows.Forms.TabPage TPDepartment;
        private System.Windows.Forms.TabControl TCVisuzalization;
        private System.Windows.Forms.TabPage TPStockByLoc;
        private System.Windows.Forms.TabPage TPStockGeneral;
        private System.Windows.Forms.TabPage TPOrdersToMake;
        private System.Windows.Forms.TabPage TPItemsTooMuch;
        private System.Windows.Forms.Panel ProductPanel;
        private System.Windows.Forms.Panel InPanel;
        private System.Windows.Forms.Panel OutPanel;
        private System.Windows.Forms.Panel CategoryPanel;
        private System.Windows.Forms.Panel DepartmentPanel;
        private System.Windows.Forms.Panel MeasuringUnitPanel;
        private System.Windows.Forms.Panel GeneralStockPanel;
        private System.Windows.Forms.Panel LocStcokPanel;
        private System.Windows.Forms.Panel OrdersToDoPanel;
        private System.Windows.Forms.Panel ItemsTooMuchPanel;
        private System.Windows.Forms.ImageList TransactionImages;
        private System.Windows.Forms.ImageList ManagementImages;
        private System.Windows.Forms.TabPage TPLocation;
        private System.Windows.Forms.ImageList VidualizationImages;
        private System.Windows.Forms.Panel LocationPanel;
    }
}

