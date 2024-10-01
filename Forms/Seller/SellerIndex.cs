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
    public partial class SellerIndex : Form
    {
        List<UserControl> controls = new List<UserControl>();

        public SellerIndex()
        {
            InitializeComponent();
            controls.Add(ProveedorPanel1);
            controls.Add(newSalePanel1);
            controls.Add(ClientesPanel);
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
            DataGrid1.Visible = true;
            ClientesPanel.Visible = true;
        }

        private void BProviders_Click(object sender, EventArgs e)
        {
            HideControls();
            DataGrid1.Visible = true;
            ProveedorPanel1.Visible = true;
        }

        private void BProduct_Click(object sender, EventArgs e)
        {
            HideControls();
            DataGrid1.Visible = true;
            ProductPanel.Visible = true;
        }

        private void BSales_Click(object sender, EventArgs e)
        {
            HideControls();
            DataGrid1.Visible = true;
        }

        private void BLogOut_Click(object sender, EventArgs e)
        {

        }

        private void BNSell_Click(object sender, EventArgs e)
        {
            HideControls();
            DataGrid1.Visible = false;
            newSalePanel1.Visible = true;
        }
    }
}
