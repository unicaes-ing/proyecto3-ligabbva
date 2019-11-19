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
    public partial class resultadosgenerados : Form
    {
        public resultadosgenerados()
        {
            InitializeComponent();
        }

        private void DgvNumeros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        

        private void Generar_Click(object sender, EventArgs e)
        {
            int[,] numeros = new int[5, 5];
            int[,] numeros2 = new int[5, 5];
            dgvNumeros.Size = new Size(550, 110);
            dgvNumeros.ColumnCount = 5;
            dgvNumeros.AllowUserToAddRows = false;
            dgvNumeros.ColumnHeadersVisible = false;
            dgvNumeros.RowHeadersVisible = false;
            dgvNumeros.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Random aleatorio = new Random();

            

            for (int f = 0; f < numeros.GetLength(0); f++)
            {
                dgvNumeros.Rows.Add();
                for (int c = 0; c < numeros.GetLength(1); c++)
                {
                    numeros[f, c] = aleatorio.Next(0, 6);
                    numeros2[f, c] = aleatorio.Next(0, 7);
                    dgvNumeros.Rows[f].Cells[c].Value = numeros[f, c]+"-"+ numeros2[f,c] ;
                }
            }
            dgvNumeros.ClearSelection();

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Resultadosgenerados_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
