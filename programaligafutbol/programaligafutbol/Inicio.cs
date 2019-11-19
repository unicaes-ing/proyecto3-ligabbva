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
using System.Runtime.InteropServices;

namespace programaligafutbol
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
           

        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void slide_Click(object sender, EventArgs e)
        {
            if (MenuVetical.Width == 250)
            {
                MenuVetical.Width = 1;
            }
            else
                MenuVetical.Width = 250;
        }

        private void iconexpandir_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            iconcontraer.Visible = true;
            iconexpandir.Visible = false;
        }

        private void iconcontraer_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            iconcontraer.Visible = false;
            iconexpandir.Visible = true;
        }

        private void iconcerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconminimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012,0);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Abrirventana(new tablagoleadores());
        }

        private void Gestiondeequipo_Click(object sender, EventArgs e)
        {
          
            addjugador.Visible = false;
            Eliminarjugador.Visible = false;
            asignaraequipo.Visible = false;
            eliminarJdeequipo.Visible = false;
            btnMostrarLiga.Visible = false;
            btnBuscarequipo.Visible = false;
            agregarequipo.Visible = true;
            eliminarequipo.Visible = true;
            gecancelar.Visible = true;
        }

        private void Gestiondejugador_Click(object sender, EventArgs e)
        {
            
            agregarequipo.Visible = false;
            eliminarequipo.Visible = false;
            gecancelar.Visible = false;
            btnMostrarLiga.Visible = false;
            btnBuscarequipo.Visible = false;
            addjugador.Visible = true;
            Eliminarjugador.Visible = true;
            asignaraequipo.Visible = true;
            eliminarJdeequipo.Visible = true;
        }

        private void Abrirventana(object formhijo)
        {
           
            agregarequipo.Visible = false;
            eliminarequipo.Visible = false;
            gecancelar.Visible = false;
            addjugador.Visible = false;
            Eliminarjugador.Visible = false;
            asignaraequipo.Visible = false;
            eliminarJdeequipo.Visible = false;
            btnMostrarLiga.Visible = false;
            btnBuscarequipo.Visible = false;
            if (PanelContededor.Controls.Count>0)
            
                PanelContededor.Controls.RemoveAt(0);
            Form fh =formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            PanelContededor.Controls.Add(fh);
            PanelContededor.Tag = fh;
            fh.Show();
        }
        private void agregarequipo_Click(object sender, EventArgs e)
        {
            Abrirventana(new Agregarequipo());
            
        }

        private void PanelContededor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void addjugador_Click(object sender, EventArgs e)
        {
            Abrirventana(new GestionDeJugadores());
        }

        private void mostrarliga_Click(object sender, EventArgs e)
        {
           
            agregarequipo.Visible = false;
            eliminarequipo.Visible = false;
            gecancelar.Visible = false;
            addjugador.Visible = false;
            Eliminarjugador.Visible = false;
            asignaraequipo.Visible = false;
            eliminarJdeequipo.Visible = false;
            btnMostrarLiga.Visible = true;
            btnBuscarequipo.Visible = true;
        }

        private void gecancelar_Click(object sender, EventArgs e)
        {
            agregarequipo.Visible = false;
            eliminarequipo.Visible = false;
            gecancelar.Visible = false;
        }

        private void eliminarequipo_Click(object sender, EventArgs e)
        {
            Abrirventana(new EliminarEquipo());
        }

        private void tabladeposiciones_Click(object sender, EventArgs e)
        {
            Abrirventana(new tabladeposicionescopia());
        }

        private void btnMostrarLiga_Click(object sender, EventArgs e)
        {
            Abrirventana(new mostrarligacompleta());
        }

        private void btnBuscarequipo_Click(object sender, EventArgs e)
        {
            Abrirventana(new buscarequipo());
        }

        

       

        private void ingresarresultados_Click(object sender, EventArgs e)
        {
            
            Abrirventana(new tabladeresultados());
        }

        private void tabladeresultados_Click(object sender, EventArgs e)
        {
            Abrirventana(new resultadosgenerados());
        }

        private void addjugador_Click_1(object sender, EventArgs e)
        {
            Abrirventana(new GestionDeJugadores());
        }

        private void eliminarJdeequipo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Opción disponible en la versión de paga :"+'"'+"v");
        }

        private void asignaraequipo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Opción disponible en la versión de paga :" + '"' + "v");
        }

        private void Eliminarjugador_Click_1(object sender, EventArgs e)
        {
            Abrirventana(new eliminaciondejugador()); 
        }

        private void restaurarliga_Click(object sender, EventArgs e)
        {
            File.Delete("jugadores.dat");
            File.Create("jugadores.dat");
            MessageBox.Show("Los cambios se realizaron con exito ");
            
        
        }
    }
}
