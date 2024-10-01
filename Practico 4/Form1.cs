using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practico_4
{
    public partial class Form1 : Form
    {
        int desdeNum;
        int hastaNum;
        public Form1()
        {
            InitializeComponent();

        }

        private void BFuncion_Click(object sender, EventArgs e)
        {
            if (Validator())
            {
                for (int i = desdeNum; i <= hastaNum; i++)
                    {
                        LBNumeros.Items.Add(i.ToString());
                    }
            }
           
        }


        private void BPares_Click(object sender, EventArgs e)
        {
            if (Validator()) 
            {
                for (int i = desdeNum; i <= hastaNum; i++)
                {
                    if(i % 2 == 0)
                    {
                        LBNumeros.Items.Add(i.ToString());
                    }
                }
            }
        }


        private bool Validator()
        {
            LBNumeros.Items.Clear();
            string desde = TBDesde.Text;
            string hasta = TBHasta.Text;


            if (int.TryParse(desde, out desdeNum) && int.TryParse(hasta, out hastaNum))
            {
                if (desdeNum < hastaNum)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("El valor 'Desde' no puede ser mayor que 'Hasta' ");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Solo se pueden ingresar numeros en los cuadros de texto");
                return false;
            }
        }

        private void BImpares_Click(object sender, EventArgs e)
        {
            if (Validator())
            {

                for (int i = desdeNum; i <= hastaNum; i++)
                {
                    if (i % 2 != 0)
                    {
                        LBNumeros.Items.Add(i.ToString());
                    }
                }
            }
        }

        private void BPrimos_Click(object sender, EventArgs e)
        {
            if (Validator())
            {
                LBNumeros.Items.Add(1);
                LBNumeros.Items.Add(2);
                LBNumeros.Items.Add(3);
                for (int i = desdeNum; i <= hastaNum; i++)
                {
                    if (i % 2 != 0 && i % 3 != 0 && i != 1)
                    {
                        LBNumeros.Items.Add(i.ToString());
                    }
                }
            }
        }
    }
}
