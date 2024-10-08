﻿using Pet_Amigos.Controllers;
using Pet_Amigos.Forms;
using Pet_Amigos.Forms.Admin;
using Pet_Amigos.Forms.Seller;
using Pet_Amigos.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pet_Amigos
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AdminIndex());
            ProviderController controller = new ProviderController();
            controller.CrearTablaProveedor();
        }
    }
}
