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
    public partial class tablagoleadores : Form
    {
        public tablagoleadores()
        {
            InitializeComponent();
        }

        private void btnMostrarPosiciones_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("jugadores.dat", FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            string nombre, equipo, posicion;
            int goles, rk=1;
            try
            {
                
               
                dgvtablagoleadores.Rows.Clear();
                while (true)
                {
                    nombre = br.ReadString();
                    posicion = br.ReadString();
                    equipo = br.ReadString();
                    goles = br.ReadInt32();
                 
                    dgvtablagoleadores.Rows.Add(rk,nombre,goles,posicion,equipo);
                    rk++;
                }
            }
            catch (Exception)
            {
            }
            finally
            {
                if (br != null) br.Close();
                dgvtablagoleadores.ClearSelection();
            }
        }

        private void btncancelarmostrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
