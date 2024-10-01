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

namespace Pet_Amigos.Forms
{
    public partial class Index : Form
    {
        List<UserControl> controls = new List<UserControl>();

        public Index()
        {
            InitializeComponent();
            controls.Add(ProveedorPanel1);
            controls.Add(ClientesPanel);
            controls.Add(ProductPanel);
        }


        private void HideControls()
        {
            for (int i = 0; i < controls.Count; i++)
            {
                controls[i].Visible = false;
            }
        }

        private void BClientes_Click(object sender, EventArgs e)
        {
            HideControls();
            ClientesPanel.Visible = true;
        }

        private void BProviders_Click(object sender, EventArgs e)
        {
            HideControls();
            ProveedorPanel1.Visible = true;
        }

        private void BProduct_Click(object sender, EventArgs e)
        {
            HideControls();
            ProductPanel.Visible = true;
        }

        private void BSales_Click(object sender, EventArgs e)
        {

        }
    }
}
