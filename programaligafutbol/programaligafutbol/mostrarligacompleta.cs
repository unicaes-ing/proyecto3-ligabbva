using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace programaligafutbol
{
    public partial class mostrarligacompleta : Form
    {
        public mostrarligacompleta()
        {
            InitializeComponent();
        }

        private void cerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnmostrarliga_Click(object sender, EventArgs e)
        {
            StreamReader archivo = new StreamReader("archivo.txt");
            string linea;
            string[] array = new string[100];
            int c = 0;
            do
            {

                linea = archivo.ReadLine();
                if (linea != null)
                {
                    array[c] = linea;
                    c++;
                }
            } while (linea != null);

            for (int i = 0; i < c; i++)
            {

                if (!File.Exists(array[i] + ".txt"))
                {

                }
                else
                {
                    archivo = new StreamReader(array[i]+".txt");
                    string linea2;

                    linea2 = archivo.ReadLine();
                    while (linea2!=null)
                    {
                        txtmostrarJ.AppendText(linea2+"\r\n");
                        linea2 = archivo.ReadLine();
                    }
                        
                    
                }
            }
        }

       
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
