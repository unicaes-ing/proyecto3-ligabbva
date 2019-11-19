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
   

    public partial class GestionDeJugadores : Form
    {
        string nombrejugador, equipo, posicion;
        int goles;
        FileStream fs = null;
        BinaryWriter bw = null;
       // BinaryReader br = null;
        public GestionDeJugadores()
        {
            InitializeComponent();
        }

        private void agregarequipo_Click(object sender, EventArgs e)
        {

        }

        private void gecancelar_Click(object sender, EventArgs e)
        {
            GestionDeJugadores f1 = new GestionDeJugadores();
            f1.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnguardatjugador_Click(object sender, EventArgs e)
        {
            try
            {
                fs = new FileStream("jugadores.dat", FileMode.Append, FileAccess.Write);
                bw = new BinaryWriter(fs);
                nombrejugador = txtnombrejugador.Text;
                posicion = txtposicionj.Text;
                equipo = txtequipojp.Text;
                goles = Convert.ToInt32(txtgoles.Text);
                bw.Write(nombrejugador);
                bw.Write(posicion);
                bw.Write(equipo);
                bw.Write(goles);
                MessageBox.Show("Los datos fueron guardados ccorrectamente");
                txtnombrejugador.Clear();
                txtposicionj.Clear();
                txtequipojp.Clear();
                txtgoles.Clear();
            }
            catch(Exception)
            {
                MessageBox.Show("Se ha producido un error");
            }
            finally
            {
                if (bw != null) bw.Close();
            }
        }

        private void btnGenerarGoles_Click(object sender, EventArgs e)
        {
            int goles;
            Random ale = new Random();
            txtgoles.Text = "";
            goles = ale.Next(0, 6);
            txtgoles.Text = goles.ToString();


        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btndjcancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
