using Pet_Amigos.Forms.Admin;
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
        List <UserControl> userControlsPanel = new List <UserControl>();
        public Index()
        {
            InitializeComponent();
            userControlsPanel.Add(ProveedorPanel);
            userControlsPanel.Add(ClientesPanel);
            userControlsPanel.Add(ProductPanel);
        }

        private void BPrueba_Click(object sender, EventArgs e)
        {
            
        }

        private void BClientes_Click(object sender, EventArgs e)
        {
            HideControls();
            ClientesPanel.Show();
        }

        private void HideControls()
        {
            for (int i = 0; i < userControlsPanel.Count; i++)
            {
                userControlsPanel[i].Hide();
            }
        }

        private void BProduct_Click(object sender, EventArgs e)
        {
            HideControls();
            ProductPanel.Show();
        }

        private void BProviders_Click(object sender, EventArgs e)
        {
            HideControls();
            ProveedorPanel.Show();
        }

        private void productPanel1_Load(object sender, EventArgs e)
        {

        }
    }
}
