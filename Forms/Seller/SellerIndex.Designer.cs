namespace Pet_Amigos.Forms.Seller
{
    partial class SellerIndex
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
            this.PButtons = new System.Windows.Forms.Panel();
            this.BLogOut = new System.Windows.Forms.Button();
            this.BNSell = new System.Windows.Forms.Button();
            this.BSales = new System.Windows.Forms.Button();
            this.BClientes = new System.Windows.Forms.Button();
            this.BProduct = new System.Windows.Forms.Button();
            this.BProviders = new System.Windows.Forms.Button();
            this.DataGrid1 = new System.Windows.Forms.DataGridView();
            this.newSalePanel1 = new Pet_Amigos.Forms.Seller.NewSalePanel();
            this.ProveedorPanel1 = new Pet_Amigos.Forms.Seller.ProveedoresPanel();
            this.ClientesPanel = new Pet_Amigos.Forms.Seller.ClientesPanel();
            this.ProductPanel = new Pet_Amigos.Forms.Admin.ProductPanel();
            this.PButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // PButtons
            // 
            this.PButtons.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.PButtons.Controls.Add(this.BLogOut);
            this.PButtons.Controls.Add(this.BNSell);
            this.PButtons.Controls.Add(this.BSales);
            this.PButtons.Controls.Add(this.BClientes);
            this.PButtons.Controls.Add(this.BProduct);
            this.PButtons.Controls.Add(this.BProviders);
            this.PButtons.Location = new System.Drawing.Point(12, 12);
            this.PButtons.Name = "PButtons";
            this.PButtons.Size = new System.Drawing.Size(319, 452);
            this.PButtons.TabIndex = 17;
            // 
            // BLogOut
            // 
            this.BLogOut.Location = new System.Drawing.Point(76, 404);
            this.BLogOut.Name = "BLogOut";
            this.BLogOut.Size = new System.Drawing.Size(123, 23);
            this.BLogOut.TabIndex = 5;
            this.BLogOut.Text = "Cerrar sesion";
            this.BLogOut.UseVisualStyleBackColor = true;
            this.BLogOut.Click += new System.EventHandler(this.BLogOut_Click);
            // 
            // BNSell
            // 
            this.BNSell.Location = new System.Drawing.Point(76, 140);
            this.BNSell.Name = "BNSell";
            this.BNSell.Size = new System.Drawing.Size(123, 23);
            this.BNSell.TabIndex = 0;
            this.BNSell.Text = "Nueva venta";
            this.BNSell.UseVisualStyleBackColor = true;
            this.BNSell.Click += new System.EventHandler(this.BNSell_Click);
            // 
            // BSales
            // 
            this.BSales.Location = new System.Drawing.Point(76, 324);
            this.BSales.Name = "BSales";
            this.BSales.Size = new System.Drawing.Size(123, 23);
            this.BSales.TabIndex = 4;
            this.BSales.Text = "Ventas";
            this.BSales.UseVisualStyleBackColor = true;
            this.BSales.Click += new System.EventHandler(this.BSales_Click);
            // 
            // BClientes
            // 
            this.BClientes.Location = new System.Drawing.Point(76, 188);
            this.BClientes.Name = "BClientes";
            this.BClientes.Size = new System.Drawing.Size(123, 23);
            this.BClientes.TabIndex = 1;
            this.BClientes.Text = "Clientes";
            this.BClientes.UseVisualStyleBackColor = true;
            this.BClientes.Click += new System.EventHandler(this.BClientes_Click);
            // 
            // BProduct
            // 
            this.BProduct.Location = new System.Drawing.Point(76, 278);
            this.BProduct.Name = "BProduct";
            this.BProduct.Size = new System.Drawing.Size(123, 23);
            this.BProduct.TabIndex = 3;
            this.BProduct.Text = "Productos";
            this.BProduct.UseVisualStyleBackColor = true;
            this.BProduct.Click += new System.EventHandler(this.BProduct_Click);
            // 
            // BProviders
            // 
            this.BProviders.Location = new System.Drawing.Point(76, 235);
            this.BProviders.Name = "BProviders";
            this.BProviders.Size = new System.Drawing.Size(123, 23);
            this.BProviders.TabIndex = 2;
            this.BProviders.Text = "Proveedores";
            this.BProviders.UseVisualStyleBackColor = true;
            this.BProviders.Click += new System.EventHandler(this.BProviders_Click);
            // 
            // DataGrid1
            // 
            this.DataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid1.Location = new System.Drawing.Point(337, 248);
            this.DataGrid1.Name = "DataGrid1";
            this.DataGrid1.Size = new System.Drawing.Size(753, 217);
            this.DataGrid1.TabIndex = 13;
            // 
            // newSalePanel1
            // 
            this.newSalePanel1.Location = new System.Drawing.Point(338, 13);
            this.newSalePanel1.Name = "newSalePanel1";
            this.newSalePanel1.Size = new System.Drawing.Size(751, 451);
            this.newSalePanel1.TabIndex = 18;
            this.newSalePanel1.Visible = false;
            // 
            // ProveedorPanel1
            // 
            this.ProveedorPanel1.Location = new System.Drawing.Point(337, 12);
            this.ProveedorPanel1.Name = "ProveedorPanel1";
            this.ProveedorPanel1.Size = new System.Drawing.Size(753, 230);
            this.ProveedorPanel1.TabIndex = 15;
            this.ProveedorPanel1.Visible = false;
            // 
            // ClientesPanel
            // 
            this.ClientesPanel.Location = new System.Drawing.Point(337, 13);
            this.ClientesPanel.Name = "ClientesPanel";
            this.ClientesPanel.Size = new System.Drawing.Size(749, 228);
            this.ClientesPanel.TabIndex = 14;
            this.ClientesPanel.Visible = false;
            // 
            // ProductPanel
            // 
            this.ProductPanel.Location = new System.Drawing.Point(338, 12);
            this.ProductPanel.Name = "ProductPanel";
            this.ProductPanel.Size = new System.Drawing.Size(749, 228);
            this.ProductPanel.TabIndex = 16;
            this.ProductPanel.Visible = false;
            // 
            // SellerIndex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 476);
            this.Controls.Add(this.newSalePanel1);
            this.Controls.Add(this.PButtons);
            this.Controls.Add(this.DataGrid1);
            this.Controls.Add(this.ProveedorPanel1);
            this.Controls.Add(this.ClientesPanel);
            this.Controls.Add(this.ProductPanel);
            this.Name = "SellerIndex";
            this.Text = "SellerIndex";
            this.PButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PButtons;
        private System.Windows.Forms.Button BLogOut;
        private System.Windows.Forms.Button BNSell;
        private System.Windows.Forms.Button BSales;
        private System.Windows.Forms.Button BClientes;
        private System.Windows.Forms.Button BProduct;
        private System.Windows.Forms.Button BProviders;
        private System.Windows.Forms.DataGridView DataGrid1;
        private ProveedoresPanel ProveedorPanel1;
        private ClientesPanel ClientesPanel;
        private Admin.ProductPanel ProductPanel;
        private NewSalePanel newSalePanel1;
    }
}