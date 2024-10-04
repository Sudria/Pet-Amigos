namespace Pet_Amigos.Forms.Admin
{
    partial class ProductPanel
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
            this.label8 = new System.Windows.Forms.Label();
            this.CBPSubcategory = new System.Windows.Forms.ComboBox();
            this.CBPCategory = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.BCancel = new System.Windows.Forms.Button();
            this.BSave = new System.Windows.Forms.Button();
            this.BImage = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TBPrice = new System.Windows.Forms.TextBox();
            this.TBPName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.CBProvider = new System.Windows.Forms.ComboBox();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.BCategoryPlus = new System.Windows.Forms.Button();
            this.BSubCategoryPlus = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(301, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 37;
            this.label8.Text = "Proveedor";
            // 
            // CBPSubcategory
            // 
            this.CBPSubcategory.FormattingEnabled = true;
            this.CBPSubcategory.Location = new System.Drawing.Point(169, 161);
            this.CBPSubcategory.Name = "CBPSubcategory";
            this.CBPSubcategory.Size = new System.Drawing.Size(100, 21);
            this.CBPSubcategory.TabIndex = 36;
            // 
            // CBPCategory
            // 
            this.CBPCategory.FormattingEnabled = true;
            this.CBPCategory.Location = new System.Drawing.Point(169, 124);
            this.CBPCategory.Name = "CBPCategory";
            this.CBPCategory.Size = new System.Drawing.Size(100, 21);
            this.CBPCategory.TabIndex = 35;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(47, 164);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 34;
            this.label7.Text = "Sub-Categoria";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(187, -48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "CREAR NUEVO PRODUCTO";
            // 
            // BCancel
            // 
            this.BCancel.Location = new System.Drawing.Point(427, 197);
            this.BCancel.Name = "BCancel";
            this.BCancel.Size = new System.Drawing.Size(75, 23);
            this.BCancel.TabIndex = 32;
            this.BCancel.Text = "Cancelar";
            this.BCancel.UseVisualStyleBackColor = true;
            // 
            // BSave
            // 
            this.BSave.Location = new System.Drawing.Point(346, 197);
            this.BSave.Name = "BSave";
            this.BSave.Size = new System.Drawing.Size(75, 23);
            this.BSave.TabIndex = 31;
            this.BSave.Text = "Guardar";
            this.BSave.UseVisualStyleBackColor = true;
            this.BSave.Click += new System.EventHandler(this.BSave_Click);
            // 
            // BImage
            // 
            this.BImage.Location = new System.Drawing.Point(189, 197);
            this.BImage.Name = "BImage";
            this.BImage.Size = new System.Drawing.Size(80, 23);
            this.BImage.TabIndex = 30;
            this.BImage.Text = "Imagen";
            this.BImage.UseVisualStyleBackColor = true;
            this.BImage.Click += new System.EventHandler(this.BImage_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(530, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(205, 215);
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // TBPrice
            // 
            this.TBPrice.Location = new System.Drawing.Point(423, 85);
            this.TBPrice.Name = "TBPrice";
            this.TBPrice.Size = new System.Drawing.Size(100, 20);
            this.TBPrice.TabIndex = 27;
            // 
            // TBPName
            // 
            this.TBPName.Location = new System.Drawing.Point(169, 43);
            this.TBPName.Name = "TBPName";
            this.TBPName.Size = new System.Drawing.Size(100, 20);
            this.TBPName.TabIndex = 25;
            this.TBPName.Text = " ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(302, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Cantidad min";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(302, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Precio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Categoria";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Cantidad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Nombre del producto";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(240, 8);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(181, 13);
            this.label9.TabIndex = 39;
            this.label9.Text = "CREAR O MODIFICAR PRODUCTO";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(51, 197);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 23);
            this.button1.TabIndex = 40;
            this.button1.Text = "Cargar Productos";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(169, 80);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(100, 20);
            this.numericUpDown1.TabIndex = 41;
            // 
            // CBProvider
            // 
            this.CBProvider.FormattingEnabled = true;
            this.CBProvider.Location = new System.Drawing.Point(423, 46);
            this.CBProvider.Name = "CBProvider";
            this.CBProvider.Size = new System.Drawing.Size(100, 21);
            this.CBProvider.TabIndex = 42;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(423, 130);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(100, 20);
            this.numericUpDown2.TabIndex = 43;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // BCategoryPlus
            // 
            this.BCategoryPlus.Location = new System.Drawing.Point(13, 119);
            this.BCategoryPlus.Name = "BCategoryPlus";
            this.BCategoryPlus.Size = new System.Drawing.Size(29, 23);
            this.BCategoryPlus.TabIndex = 44;
            this.BCategoryPlus.Text = "+";
            this.BCategoryPlus.UseVisualStyleBackColor = true;
            this.BCategoryPlus.Click += new System.EventHandler(this.BCategoryPlus_Click);
            // 
            // BSubCategoryPlus
            // 
            this.BSubCategoryPlus.Location = new System.Drawing.Point(13, 159);
            this.BSubCategoryPlus.Name = "BSubCategoryPlus";
            this.BSubCategoryPlus.Size = new System.Drawing.Size(29, 23);
            this.BSubCategoryPlus.TabIndex = 45;
            this.BSubCategoryPlus.Text = "+";
            this.BSubCategoryPlus.UseVisualStyleBackColor = true;
            this.BSubCategoryPlus.Click += new System.EventHandler(this.BSubCategoryPlus_Click);
            // 
            // ProductPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.Controls.Add(this.BSubCategoryPlus);
            this.Controls.Add(this.BCategoryPlus);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.CBProvider);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.CBPSubcategory);
            this.Controls.Add(this.CBPCategory);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BCancel);
            this.Controls.Add(this.BSave);
            this.Controls.Add(this.BImage);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TBPrice);
            this.Controls.Add(this.TBPName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ProductPanel";
            this.Size = new System.Drawing.Size(749, 228);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox CBPSubcategory;
        private System.Windows.Forms.ComboBox CBPCategory;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BCancel;
        private System.Windows.Forms.Button BSave;
        private System.Windows.Forms.Button BImage;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox TBPrice;
        private System.Windows.Forms.TextBox TBPName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.ComboBox CBProvider;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button BCategoryPlus;
        private System.Windows.Forms.Button BSubCategoryPlus;
    }
}
