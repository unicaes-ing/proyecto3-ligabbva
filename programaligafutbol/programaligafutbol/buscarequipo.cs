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
    public partial class buscarequipo : Form
    {
        public buscarequipo()
        {
            InitializeComponent();
        }

        private void btnbuscarequipo_Click(object sender, EventArgs e)
        {
            if (File.Exists(txtbuscarequipo.Text+".txt"))
            {
                //StreamReader archivo = new StreamReader(txtbuscarequipo.Text+".txt");
                string equipo = File.ReadAllText(txtbuscarequipo.Text+".txt");
                txtmostrar.Text=equipo;
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnregresar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
