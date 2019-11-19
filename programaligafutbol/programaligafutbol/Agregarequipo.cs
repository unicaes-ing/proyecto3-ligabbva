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
    public partial class Agregarequipo : Form
    {
        public Agregarequipo()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Agregadojugadores_Load(object sender, EventArgs e)
        {
            
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void baddjugador_Click(object sender, EventArgs e)
        {

            try
            {

                if (txtnombreequipo.Text!=null && txtnombrejugador.Text!=null)
                    {

                    int n = dgvEquipos.Rows.Add();
                    label1.Visible = false;
                    txtnombreequipo.Visible = false;
                    dgvEquipos.Rows[0].Cells[0].Value = txtnombreequipo.Text;
                    dgvEquipos.Rows[n].Cells[1].Value = txtnombrejugador.Text;

                    txtnombrejugador.Text = "";
                  
                    }
                    else
                    {
                    MessageBox.Show("Los campos no deben de estar vacios");
                    label1.Visible = true;
                    txtnombreequipo.Visible = true;
                }
           
            }
            catch (Exception)
            {
                MessageBox.Show("Se ha prducido un error");
            }
        }

        private void btnvaciar_Click(object sender, EventArgs e)
        {
            dgvEquipos.Rows.Clear();
        }

        private void guardar_Click(object sender, EventArgs e)
        {

            if (txtnombreequipo.Text != null && txtnombrejugador.Text != null)
            {
                if (!File.Exists(txtnombreequipo.Text+".txt"))
                {
                    
                     StreamWriter equipo = new StreamWriter(txtnombreequipo.Text + ".txt");
                     StreamWriter archivo = new StreamWriter("archivo.txt",true);
                   
                    archivo.WriteLine(txtnombreequipo.Text);
                    archivo.Close();
                    equipo.WriteLine("**********************************");
                    equipo.WriteLine("     "+txtnombreequipo.Text);
                    equipo.WriteLine("**********************************");
                    
                    for (int i = 0; i < dgvEquipos.Rows.Count-1; i++)
                    {
                        for (int j = 1; j < dgvEquipos.Columns.Count; j++)
                        {
                            equipo.WriteLine(dgvEquipos.Rows[i].Cells[j].Value.ToString());
                        }
                     
                    }
                   
                    equipo.Close();
                    MessageBox.Show("Los datos han sido guardados correctamente");
                }
                else
                {
                    MessageBox.Show("Lo sentimos, el nombre "+txtnombreequipo.Text+" ya existe");
                    txtnombreequipo.Visible = true;
                    txtnombreequipo.Text = "";
                    label1.Visible = true;
                }
            }
            cancel.Visible = false;
            volverbtn.Visible = true;
        }

        private void volverbtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
