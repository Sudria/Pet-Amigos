namespace Pet_Amigos.Forms.Seller
{
    partial class SellerIndex
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
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
            this.PButtons.SuspendLayout();
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
            this.PButtons.Location = new System.Drawing.Point(0, 0);
            this.PButtons.Name = "PButtons";
            this.PButtons.Size = new System.Drawing.Size(319, 452);
            this.PButtons.TabIndex = 7;
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
            // SellerIndex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PButtons);
            this.Name = "SellerIndex";
            this.Size = new System.Drawing.Size(319, 452);
            this.PButtons.ResumeLayout(false);
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
    }
}
