namespace Practico_4
{
    partial class Form1
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LBNumeros = new System.Windows.Forms.ListBox();
            this.TBDesde = new System.Windows.Forms.TextBox();
            this.TBHasta = new System.Windows.Forms.TextBox();
            this.BFuncion = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.BPares = new System.Windows.Forms.Button();
            this.BImpares = new System.Windows.Forms.Button();
            this.BPrimos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Desde";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hasta";
            // 
            // LBNumeros
            // 
            this.LBNumeros.FormattingEnabled = true;
            this.LBNumeros.Location = new System.Drawing.Point(338, 101);
            this.LBNumeros.Name = "LBNumeros";
            this.LBNumeros.Size = new System.Drawing.Size(275, 225);
            this.LBNumeros.TabIndex = 2;
            // 
            // TBDesde
            // 
            this.TBDesde.Location = new System.Drawing.Point(89, 101);
            this.TBDesde.Name = "TBDesde";
            this.TBDesde.Size = new System.Drawing.Size(100, 20);
            this.TBDesde.TabIndex = 3;
            // 
            // TBHasta
            // 
            this.TBHasta.Location = new System.Drawing.Point(89, 137);
            this.TBHasta.Name = "TBHasta";
            this.TBHasta.Size = new System.Drawing.Size(100, 20);
            this.TBHasta.TabIndex = 4;
            // 
            // BFuncion
            // 
            this.BFuncion.Location = new System.Drawing.Point(89, 187);
            this.BFuncion.Name = "BFuncion";
            this.BFuncion.Size = new System.Drawing.Size(100, 23);
            this.BFuncion.TabIndex = 5;
            this.BFuncion.Text = "Generar Funcion";
            this.BFuncion.UseVisualStyleBackColor = true;
            this.BFuncion.Click += new System.EventHandler(this.BFuncion_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(410, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Lista de numeros";
            // 
            // BPares
            // 
            this.BPares.Location = new System.Drawing.Point(89, 226);
            this.BPares.Name = "BPares";
            this.BPares.Size = new System.Drawing.Size(100, 23);
            this.BPares.TabIndex = 7;
            this.BPares.Text = "Pares";
            this.BPares.UseVisualStyleBackColor = true;
            this.BPares.Click += new System.EventHandler(this.BPares_Click);
            // 
            // BImpares
            // 
            this.BImpares.Location = new System.Drawing.Point(89, 255);
            this.BImpares.Name = "BImpares";
            this.BImpares.Size = new System.Drawing.Size(100, 23);
            this.BImpares.TabIndex = 8;
            this.BImpares.Text = "Impares";
            this.BImpares.UseVisualStyleBackColor = true;
            this.BImpares.Click += new System.EventHandler(this.BImpares_Click);
            // 
            // BPrimos
            // 
            this.BPrimos.Location = new System.Drawing.Point(89, 284);
            this.BPrimos.Name = "BPrimos";
            this.BPrimos.Size = new System.Drawing.Size(100, 23);
            this.BPrimos.TabIndex = 9;
            this.BPrimos.Text = "Primos";
            this.BPrimos.UseVisualStyleBackColor = true;
            this.BPrimos.Click += new System.EventHandler(this.BPrimos_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 347);
            this.Controls.Add(this.BPrimos);
            this.Controls.Add(this.BImpares);
            this.Controls.Add(this.BPares);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BFuncion);
            this.Controls.Add(this.TBHasta);
            this.Controls.Add(this.TBDesde);
            this.Controls.Add(this.LBNumeros);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Formulario4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox LBNumeros;
        private System.Windows.Forms.TextBox TBDesde;
        private System.Windows.Forms.TextBox TBHasta;
        private System.Windows.Forms.Button BFuncion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BPares;
        private System.Windows.Forms.Button BImpares;
        private System.Windows.Forms.Button BPrimos;
    }
}

