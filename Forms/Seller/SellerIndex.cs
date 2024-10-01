using Pet_Amigos.Forms.Admin;
using Pet_Amigos.Forms.Seller;
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
    public partial class SellerIndex : UserControl
    {
        List<UserControl> controls = new List<UserControl>();
        public SellerIndex()
        {
            controls.Add(ClientesPanel);
            controls.Add(ProductPanel);
            InitializeComponent();
        }

        private void BClientes_Click(object sender, EventArgs e)
        {

        }

        private void BProviders_Click(object sender, EventArgs e)
        {

        }

        private void BProduct_Click(object sender, EventArgs e)
        {

        }

        private void BSales_Click(object sender, EventArgs e)
        {

        }

        private void BNSell_Click(object sender, EventArgs e)
        {

        }

        private void BLogOut_Click(object sender, EventArgs e)
        {

        }

        private void HideAll()
        {
            for (int i = 0; i < controls.Count; i++)
            {
                controls[i].Visible = false;
            }
        }
    }
}
