using Pet_Amigos.Classes.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pet_Amigos.Forms.Admin
{
    public partial class UserPanel : UserControl
    {
        public UserPanel()
        {
            InitializeComponent();
        }

        private void BGuardarCliente_Click(object sender, EventArgs e)
        {
            Validator.isValidText(TBUser.Text, "Usuario");
            Validator.isValidText(TBNombre.Text, "Nombre");
            Validator.isValidText(TBApellido.Text, "Apellido");
            Validator.isValidNum(TBCuit.Text, "Cuit");
            Validator.isValidNum(TBTel.Text, "Telefono");
            Validator.isValidEmail(TBEmail.Text);
        }

        private void BImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.bmp";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Cargar la imagen seleccionada en el PictureBox
                pictureBox1.Image = Image.FromFile(openFileDialog.FileName);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
    }
}
