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
            this.ProveedorPanel1 = new Pet_Amigos.Forms.Seller.ProveedoresPanel();
            this.ClientesPanel = new Pet_Amigos.Forms.Seller.ClientesPanel();
            this.ProductPanel = new Pet_Amigos.Forms.Admin.ProductPanel();
            this.PButtons = new System.Windows.Forms.Panel();
            this.BLogOut = new System.Windows.Forms.Button();
            this.BNSell = new System.Windows.Forms.Button();
            this.BSales = new System.Windows.Forms.Button();
            this.BClientes = new System.Windows.Forms.Button();
            this.BProduct = new System.Windows.Forms.Button();
            this.BProviders = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.PButtons.SuspendLayout();
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
            // ProveedorPanel1
            // 
            this.ProveedorPanel1.Location = new System.Drawing.Point(334, 11);
            this.ProveedorPanel1.Name = "ProveedorPanel1";
            this.ProveedorPanel1.Size = new System.Drawing.Size(750, 229);
            this.ProveedorPanel1.TabIndex = 10;
            this.ProveedorPanel1.Visible = false;
            // 
            // ClientesPanel
            // 
            this.ClientesPanel.Location = new System.Drawing.Point(334, 12);
            this.ClientesPanel.Name = "ClientesPanel";
            this.ClientesPanel.Size = new System.Drawing.Size(749, 228);
            this.ClientesPanel.TabIndex = 8;
            this.ClientesPanel.Visible = false;
            // 
            // ProductPanel
            // 
            this.ProductPanel.Location = new System.Drawing.Point(335, 11);
            this.ProductPanel.Name = "ProductPanel";
            this.ProductPanel.Size = new System.Drawing.Size(749, 228);
            this.ProductPanel.TabIndex = 11;
            this.ProductPanel.Visible = false;
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
            this.PButtons.Location = new System.Drawing.Point(9, 11);
            this.PButtons.Name = "PButtons";
            this.PButtons.Size = new System.Drawing.Size(319, 452);
            this.PButtons.TabIndex = 12;
            // 
            // BLogOut
            // 
            this.BLogOut.Location = new System.Drawing.Point(76, 404);
            this.BLogOut.Name = "BLogOut";
            this.BLogOut.Size = new System.Drawing.Size(123, 23);
            this.BLogOut.TabIndex = 5;
            this.BLogOut.Text = "Cerrar sesion";
            this.BLogOut.UseVisualStyleBackColor = true;
            // 
            // BNSell
            // 
            this.BNSell.Location = new System.Drawing.Point(76, 140);
            this.BNSell.Name = "BNSell";
            this.BNSell.Size = new System.Drawing.Size(123, 23);
            this.BNSell.TabIndex = 0;
            this.BNSell.Text = "Nueva venta";
            this.BNSell.UseVisualStyleBackColor = true;
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
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 476);
            this.Controls.Add(this.PButtons);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ProveedorPanel1);
            this.Controls.Add(this.ClientesPanel);
            this.Controls.Add(this.ProductPanel);
            this.Name = "Index";
            this.Text = "PET AMIGOS";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.PButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private Seller.ClientesPanel ClientesPanel;
        private Seller.ProveedoresPanel ProveedorPanel1;
        private Admin.ProductPanel ProductPanel;
        private System.Windows.Forms.Panel PButtons;
        private System.Windows.Forms.Button BLogOut;
        private System.Windows.Forms.Button BNSell;
        private System.Windows.Forms.Button BSales;
        private System.Windows.Forms.Button BClientes;
        private System.Windows.Forms.Button BProduct;
        private System.Windows.Forms.Button BProviders;
    }
}