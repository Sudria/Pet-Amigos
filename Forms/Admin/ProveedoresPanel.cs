using Pet_Amigos.Classes.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pet_Amigos.Forms.Seller
{
    public partial class ProveedoresPanel : UserControl
    {
        public ProveedoresPanel()
        {
            InitializeComponent();
        }

        private void BGuardarCliente_Click(object sender, EventArgs e)
        {
            Validator.isValidText(TBNombre.Text, "Nombre");
            Validator.isValidText(TBApellido.Text, "Apellido");
            Validator.isValidNum(TBCuit.Text, "Cuit");
            Validator.isValidNum(TBTel.Text, "Telefono");
            Validator.isValidEmail(TBEmail.Text);

        }
    }
}
