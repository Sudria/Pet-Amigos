using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practico_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
        }


        private void BFoto_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog(this) == DialogResult.OK)
            {
                TBFoto.Text = openFileDialog1.FileName;
                PBImagen.Image = new Bitmap(openFileDialog1.FileName);


            }
        }

        private void TBNombre_TextChanged(object sender, EventArgs e)
        {

            TBNombre.TextChanged -= TBNombre_TextChanged;

            if (TBNombre.Text.Length > 0)
            {
                TBNombre.Text = char.ToUpper(TBNombre.Text[0]) + TBNombre.Text.Substring(1).ToLower();

                TBNombre.SelectionStart = TBNombre.Text.Length;
            }

            TBNombre.TextChanged += TBNombre_TextChanged;
        }

        private void TBApellido_TextChanged(object sender, EventArgs e)
        {
            TBApellido.TextChanged -= TBApellido_TextChanged;

            if (TBNombre.Text.Length > 0)
            {
                TBApellido.Text = char.ToUpper(TBApellido.Text[0]) + TBApellido.Text.Substring(1).ToLower();

                TBApellido.SelectionStart = TBNombre.Text.Length;
            }

            TBApellido.TextChanged += TBNombre_TextChanged;
        }

        private void BGuardar_Click(object sender, EventArgs e)
        {
            string Sexo = RBHombre.Checked ? "Hombre" : "Mujer";
            DGUsuario.Rows.Add(TBNombre.Text, TBApellido.Text, DTNacimiento.Text, Sexo, "Eliminar", TBSaldo.Text, PBImagen.Image, TBFoto.Text);
        }

        private void DGUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DGBEliminar_Click(Object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("Hola");
        }
    }
}
