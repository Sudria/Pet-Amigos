﻿using System;
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
    public partial class ClientFormAux : Form
    {
        public ClientFormAux()
        {
            InitializeComponent();
        }

 

        private void BCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
