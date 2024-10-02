namespace Pet_Amigos.Forms.Admin
{
    partial class AdminIndex
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
            this.BProviders = new System.Windows.Forms.Button();
            this.BLogOut = new System.Windows.Forms.Button();
            this.BUsers = new System.Windows.Forms.Button();
            this.BProduct = new System.Windows.Forms.Button();
            this.DataGrid1 = new System.Windows.Forms.DataGridView();
            this.userPanel1 = new Pet_Amigos.Forms.Admin.UserPanel();
            this.productPanel1 = new Pet_Amigos.Forms.Admin.ProductPanel();
            this.ProveedorPanel1 = new Pet_Amigos.Forms.Seller.ProveedoresPanel();
            this.PButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // PButtons
            // 
            this.PButtons.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.PButtons.Controls.Add(this.BProviders);
            this.PButtons.Controls.Add(this.BLogOut);
            this.PButtons.Controls.Add(this.BUsers);
            this.PButtons.Controls.Add(this.BProduct);
            this.PButtons.Location = new System.Drawing.Point(6, 10);
            this.PButtons.Name = "PButtons";
            this.PButtons.Size = new System.Drawing.Size(319, 452);
            this.PButtons.TabIndex = 23;
            // 
            // BProviders
            // 
            this.BProviders.Location = new System.Drawing.Point(76, 245);
            this.BProviders.Name = "BProviders";
            this.BProviders.Size = new System.Drawing.Size(123, 23);
            this.BProviders.TabIndex = 6;
            this.BProviders.Text = "Proveedores";
            this.BProviders.UseVisualStyleBackColor = true;
            this.BProviders.Click += new System.EventHandler(this.BProviders_Click);
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
            // BUsers
            // 
            this.BUsers.Location = new System.Drawing.Point(76, 169);
            this.BUsers.Name = "BUsers";
            this.BUsers.Size = new System.Drawing.Size(123, 23);
            this.BUsers.TabIndex = 0;
            this.BUsers.Text = "Usuarios";
            this.BUsers.UseVisualStyleBackColor = true;
            this.BUsers.Click += new System.EventHandler(this.BUsers_Click);
            // 
            // BProduct
            // 
            this.BProduct.Location = new System.Drawing.Point(76, 206);
            this.BProduct.Name = "BProduct";
            this.BProduct.Size = new System.Drawing.Size(123, 23);
            this.BProduct.TabIndex = 3;
            this.BProduct.Text = "Productos";
            this.BProduct.UseVisualStyleBackColor = true;
            this.BProduct.Click += new System.EventHandler(this.BProduct_Click);
            // 
            // DataGrid1
            // 
            this.DataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid1.Location = new System.Drawing.Point(331, 246);
            this.DataGrid1.Name = "DataGrid1";
            this.DataGrid1.Size = new System.Drawing.Size(753, 217);
            this.DataGrid1.TabIndex = 20;
            this.DataGrid1.Visible = false;
            // 
            // userPanel1
            // 
            this.userPanel1.Location = new System.Drawing.Point(331, 10);
            this.userPanel1.Name = "userPanel1";
            this.userPanel1.Size = new System.Drawing.Size(749, 228);
            this.userPanel1.TabIndex = 25;
            this.userPanel1.Visible = false;
            // 
            // productPanel1
            // 
            this.productPanel1.Location = new System.Drawing.Point(331, 10);
            this.productPanel1.Name = "productPanel1";
            this.productPanel1.Size = new System.Drawing.Size(749, 228);
            this.productPanel1.TabIndex = 24;
            this.productPanel1.Visible = false;
            // 
            // ProveedorPanel1
            // 
            this.ProveedorPanel1.Location = new System.Drawing.Point(331, 10);
            this.ProveedorPanel1.Name = "ProveedorPanel1";
            this.ProveedorPanel1.Size = new System.Drawing.Size(753, 230);
            this.ProveedorPanel1.TabIndex = 22;
            this.ProveedorPanel1.Visible = false;
            // 
            // AdminIndex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 476);
            this.Controls.Add(this.userPanel1);
            this.Controls.Add(this.PButtons);
            this.Controls.Add(this.DataGrid1);
            this.Controls.Add(this.productPanel1);
            this.Controls.Add(this.ProveedorPanel1);
            this.Name = "AdminIndex";
            this.Text = "AdminIndex";
            this.PButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel PButtons;
        private System.Windows.Forms.Button BLogOut;
        private System.Windows.Forms.Button BUsers;
        private System.Windows.Forms.Button BProduct;
        private System.Windows.Forms.DataGridView DataGrid1;
        private Seller.ProveedoresPanel ProveedorPanel1;
        private System.Windows.Forms.Button BProviders;
        private ProductPanel productPanel1;
        private UserPanel userPanel1;
    }
}