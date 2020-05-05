namespace SGI.Views.SubViews
{
    partial class FOrdersToDo
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
            this.dgvOrderToDo = new System.Windows.Forms.DataGridView();
            this.ProductID_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InvMeasUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityMin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quanity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderToDo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvOrderToDo
            // 
            this.dgvOrderToDo.AllowUserToAddRows = false;
            this.dgvOrderToDo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrderToDo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderToDo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductID_,
            this.InvMeasUnit,
            this.QuantityMin,
            this.Quanity});
            this.dgvOrderToDo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOrderToDo.Location = new System.Drawing.Point(0, 0);
            this.dgvOrderToDo.Name = "dgvOrderToDo";
            this.dgvOrderToDo.ReadOnly = true;
            this.dgvOrderToDo.Size = new System.Drawing.Size(933, 588);
            this.dgvOrderToDo.TabIndex = 1;
            // 
            // ProductID_
            // 
            this.ProductID_.DataPropertyName = "Name";
            this.ProductID_.HeaderText = "Produit";
            this.ProductID_.Name = "ProductID_";
            this.ProductID_.ReadOnly = true;
            // 
            // InvMeasUnit
            // 
            this.InvMeasUnit.DataPropertyName = "MeasuringUnit";
            this.InvMeasUnit.HeaderText = "Unité de mesure";
            this.InvMeasUnit.Name = "InvMeasUnit";
            this.InvMeasUnit.ReadOnly = true;
            // 
            // QuantityMin
            // 
            this.QuantityMin.DataPropertyName = "QtyMin";
            this.QuantityMin.HeaderText = "Quantité Min";
            this.QuantityMin.Name = "QuantityMin";
            this.QuantityMin.ReadOnly = true;
            // 
            // Quanity
            // 
            this.Quanity.DataPropertyName = "Quantity";
            this.Quanity.HeaderText = "Quantité";
            this.Quanity.Name = "Quanity";
            this.Quanity.ReadOnly = true;
            // 
            // FOrdersToDo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 588);
            this.Controls.Add(this.dgvOrderToDo);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FOrdersToDo";
            this.Text = "FOrdersToDo";
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderToDo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOrderToDo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID_;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvMeasUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityMin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quanity;
    }
}