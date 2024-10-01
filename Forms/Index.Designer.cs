namespace Pet_Amigos.Forms
{
    partial class Index
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ProductPanel = new Pet_Amigos.Forms.Admin.ProductPanel();
            this.ProveedorPanel = new Pet_Amigos.Forms.Seller.ProveedoresPanel();
            this.ClientesPanel = new Pet_Amigos.Forms.Seller.ClientesPanel();
            this.sellerIndex = new Pet_Amigos.Forms.Seller.SellerIndex();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(337, 247);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(750, 217);
            this.dataGridView1.TabIndex = 7;
            // 
            // ProductPanel
            // 
            this.ProductPanel.Location = new System.Drawing.Point(335, 11);
            this.ProductPanel.Name = "ProductPanel";
            this.ProductPanel.Size = new System.Drawing.Size(749, 228);
            this.ProductPanel.TabIndex = 11;
            this.ProductPanel.Visible = false;
            this.ProductPanel.Load += new System.EventHandler(this.productPanel1_Load);
            // 
            // ProveedorPanel
            // 
            this.ProveedorPanel.Location = new System.Drawing.Point(334, 11);
            this.ProveedorPanel.Name = "ProveedorPanel";
            this.ProveedorPanel.Size = new System.Drawing.Size(750, 229);
            this.ProveedorPanel.TabIndex = 10;
            this.ProveedorPanel.Visible = false;
            // 
            // ClientesPanel
            // 
            this.ClientesPanel.Location = new System.Drawing.Point(334, 12);
            this.ClientesPanel.Name = "ClientesPanel";
            this.ClientesPanel.Size = new System.Drawing.Size(749, 228);
            this.ClientesPanel.TabIndex = 8;
            this.ClientesPanel.Visible = false;
            // 
            // sellerIndex
            // 
            this.sellerIndex.Location = new System.Drawing.Point(9, 11);
            this.sellerIndex.Name = "sellerIndex";
            this.sellerIndex.Size = new System.Drawing.Size(319, 452);
            this.sellerIndex.TabIndex = 12;
            // 
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 476);
            this.Controls.Add(this.sellerIndex);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ProductPanel);
            this.Controls.Add(this.ProveedorPanel);
            this.Controls.Add(this.ClientesPanel);
            this.Name = "Index";
            this.Text = "PET AMIGOS";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private Seller.ClientesPanel ClientesPanel;
        private Seller.ProveedoresPanel ProveedorPanel;
        private Admin.ProductPanel ProductPanel;
        private Seller.SellerIndex sellerIndex;
    }
}