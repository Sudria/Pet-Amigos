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
    public partial class AdminIndex : Form
    {
        List<UserControl> controls = new List<UserControl>();

        public AdminIndex()
        {
            InitializeComponent();
            controls.Add(ProveedorPanel1);
            controls.Add(productPanel1);
            controls.Add(userPanel1);
        }

        private void HideControls()
        {
            for (int i = 0; i < controls.Count; i++)
            {
                controls[i].Visible = false;
            }
        }

        private void BUsers_Click(object sender, EventArgs e)
        {
            HideControls();
            DataGrid1.Visible = true;
            userPanel1.Visible = true;
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
            productPanel1.Visible = true;
        }
    }
}
