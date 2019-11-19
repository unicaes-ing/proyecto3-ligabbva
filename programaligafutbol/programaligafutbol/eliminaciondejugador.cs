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
    public partial class eliminaciondejugador : Form
    {
        public eliminaciondejugador()
        {
            InitializeComponent();
        }

        private void btnbuscarjugador_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("jugadores.dat", FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            string nombre, posicion,equipo ;
            int goles;

            try
            {
                
              
                while (true)
                {
                    nombre = br.ReadString();
                    posicion = br.ReadString();
                    equipo = br.ReadString();
                    goles = br.ReadInt32();
                    if (txtbuscajugador.Text.Equals( nombre))
                    {
                        dgvjugador.Rows.Add(nombre, equipo);
                    }
                  
                }

            }
            catch (Exception)
            {

                MessageBox.Show("error");
            }finally
            {
                if (br != null) br.Close();
                dgvjugador.ClearSelection();
            }
        }
    }
}
