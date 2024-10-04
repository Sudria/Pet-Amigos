namespace Pet_Amigos.Forms.Supervisor
{
    partial class SupervisorIndex
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
            this.BMonth = new System.Windows.Forms.Button();
            this.BLogOut = new System.Windows.Forms.Button();
            this.PButtons = new System.Windows.Forms.Panel();
            this.DataGrid1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.From = new System.Windows.Forms.DateTimePicker();
            this.To = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.PButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // BMonth
            // 
            this.BMonth.Location = new System.Drawing.Point(85, 160);
            this.BMonth.Name = "BMonth";
            this.BMonth.Size = new System.Drawing.Size(123, 23);
            this.BMonth.TabIndex = 1;
            this.BMonth.Text = "Ventas";
            this.BMonth.UseVisualStyleBackColor = true;
            // 
            // BLogOut
            // 
            this.BLogOut.Location = new System.Drawing.Point(85, 403);
            this.BLogOut.Name = "BLogOut";
            this.BLogOut.Size = new System.Drawing.Size(123, 23);
            this.BLogOut.TabIndex = 5;
            this.BLogOut.Text = "Cerrar sesion";
            this.BLogOut.UseVisualStyleBackColor = true;
            // 
            // PButtons
            // 
            this.PButtons.BackColor = System.Drawing.Color.DarkCyan;
            this.PButtons.Controls.Add(this.BLogOut);
            this.PButtons.Controls.Add(this.BMonth);
            this.PButtons.Location = new System.Drawing.Point(1, 0);
            this.PButtons.Name = "PButtons";
            this.PButtons.Size = new System.Drawing.Size(319, 452);
            this.PButtons.TabIndex = 22;
            // 
            // DataGrid1
            // 
            this.DataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid1.Location = new System.Drawing.Point(320, 235);
            this.DataGrid1.Name = "DataGrid1";
            this.DataGrid1.Size = new System.Drawing.Size(753, 217);
            this.DataGrid1.TabIndex = 20;
            this.DataGrid1.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(953, 207);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 23;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // From
            // 
            this.From.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.From.Location = new System.Drawing.Point(479, 42);
            this.From.MaxDate = new System.DateTime(2024, 10, 2, 0, 0, 0, 0);
            this.From.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.From.Name = "From";
            this.From.Size = new System.Drawing.Size(97, 20);
            this.From.TabIndex = 24;
            this.From.Value = new System.DateTime(2024, 10, 2, 0, 0, 0, 0);
            // 
            // To
            // 
            this.To.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.To.Location = new System.Drawing.Point(768, 42);
            this.To.MinDate = new System.DateTime(2024, 10, 2, 0, 0, 0, 0);
            this.To.Name = "To";
            this.To.Size = new System.Drawing.Size(96, 20);
            this.To.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(429, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "DESDE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(719, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "HASTA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(616, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "REPORTES";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(479, 85);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(405, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "VENDEDOR";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(405, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 34;
            this.label6.Text = "CATEGORIA";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(479, 124);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 33;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(380, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 13);
            this.label7.TabIndex = 36;
            this.label7.Text = "SUB CATEGORIA";
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(479, 163);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 21);
            this.comboBox4.TabIndex = 35;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(370, 207);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Generar reporte";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // SupervisorIndex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(1074, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.To);
            this.Controls.Add(this.From);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PButtons);
            this.Controls.Add(this.DataGrid1);
            this.Name = "SupervisorIndex";
            this.Text = "SupervisorIndex";
            this.PButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BMonth;
        private System.Windows.Forms.Button BLogOut;
        private System.Windows.Forms.Panel PButtons;
        private System.Windows.Forms.DataGridView DataGrid1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker From;
        private System.Windows.Forms.DateTimePicker To;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Button button2;
    }
}