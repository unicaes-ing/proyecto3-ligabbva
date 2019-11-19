using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;

using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace programaligafutbol
{
    public partial class EliminarEquipo : Form
    {
        public EliminarEquipo()
        {
            InitializeComponent();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
           
            Close();
        }

        private void btnbusca_Click(object sender, EventArgs e)
        {
            if (txtbusequipeliminar.Text!=null)
            {


                if (File.Exists(txtbusequipeliminar.Text + ".txt"))
                {
                    MessageBox.Show("El equipo ha sido encontrado");
                    btneliminar.Visible = true;
                }
                else
                {
                    MessageBox.Show("No hay ningún resultado");
                }
            }
            else
            {
                MessageBox.Show("NO debe dejar el campo vacio");
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {

            File.Delete(txtbusequipeliminar.Text+".txt");
            MessageBox.Show("El equipo ha sido eliminado");
            txtbusequipeliminar.Text = "";
            btneliminar.Visible = false;
        }
    }
}
