using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace programaligafutbol
{
    public partial class tabladeposicionescopia : Form
    {
        public tabladeposicionescopia()
        {
            InitializeComponent();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Tabladeposiciones_Load(object sender, EventArgs e)
        {

        }

        private void DataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Los datos no pueden ser mostrados porque no tiene permisos de administrador, ¿conoces la clave?");
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
