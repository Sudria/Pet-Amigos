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

namespace Pet_Amigos.Forms.Seller
{
    public partial class ClientesPanel : UserControl
    {
        public ClientesPanel()
        {
            InitializeComponent();
        }

        private void BGuardarCliente_Click(object sender, EventArgs e)
        {
            
            
            Validator.isValidNum(TBCuit.Text);
            Validator.isValidNum(TBTel.Text);

            Validator.isValidText(DTPNac.Text);
            Validator.isValidEmail(TBEmail.Text);
            Validator.isValidText(TBNombre.Text);
            Validator.isValidText(TBApellido.Text);

            //direcion no tiene que ser validado ya que pue ingresar cualquier texto

        }
    }
}
