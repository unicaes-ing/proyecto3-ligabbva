namespace programaligafutbol
{
    partial class tablagoleadores
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnMostrarPosiciones = new System.Windows.Forms.Button();
            this.btncancelarmostrar = new System.Windows.Forms.Button();
            this.dgvtablagoleadores = new System.Windows.Forms.DataGridView();
            this.Rk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Namejugador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.posicion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Equipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtablagoleadores)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMostrarPosiciones
            // 
            this.btnMostrarPosiciones.Location = new System.Drawing.Point(54, 48);
            this.btnMostrarPosiciones.Name = "btnMostrarPosiciones";
            this.btnMostrarPosiciones.Size = new System.Drawing.Size(102, 24);
            this.btnMostrarPosiciones.TabIndex = 0;
            this.btnMostrarPosiciones.Text = "Mostrar";
            this.btnMostrarPosiciones.UseVisualStyleBackColor = true;
            this.btnMostrarPosiciones.Click += new System.EventHandler(this.btnMostrarPosiciones_Click);
            // 
            // btncancelarmostrar
            // 
            this.btncancelarmostrar.Location = new System.Drawing.Point(173, 48);
            this.btncancelarmostrar.Name = "btncancelarmostrar";
            this.btncancelarmostrar.Size = new System.Drawing.Size(102, 24);
            this.btncancelarmostrar.TabIndex = 1;
            this.btncancelarmostrar.Text = "Cancelar";
            this.btncancelarmostrar.UseVisualStyleBackColor = true;
            this.btncancelarmostrar.Click += new System.EventHandler(this.btncancelarmostrar_Click);
            // 
            // dgvtablagoleadores
            // 
            this.dgvtablagoleadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvtablagoleadores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Rk,
            this.Namejugador,
            this.goles,
            this.posicion,
            this.Equipo});
            this.dgvtablagoleadores.Location = new System.Drawing.Point(54, 122);
            this.dgvtablagoleadores.Name = "dgvtablagoleadores";
            this.dgvtablagoleadores.Size = new System.Drawing.Size(593, 282);
            this.dgvtablagoleadores.TabIndex = 2;
            // 
            // Rk
            // 
            this.Rk.HeaderText = "RK";
            this.Rk.Name = "Rk";
            this.Rk.Width = 50;
            // 
            // Namejugador
            // 
            this.Namejugador.HeaderText = "Nombre del Jugador";
            this.Namejugador.Name = "Namejugador";
            this.Namejugador.Width = 180;
            // 
            // goles
            // 
            this.goles.HeaderText = "Goles";
            this.goles.Name = "goles";
            this.goles.Width = 50;
            // 
            // posicion
            // 
            this.posicion.HeaderText = "Posición";
            this.posicion.Name = "posicion";
            // 
            // Equipo
            // 
            this.Equipo.HeaderText = "Equipo";
            this.Equipo.Name = "Equipo";
            this.Equipo.Width = 170;
            // 
            // tablagoleadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvtablagoleadores);
            this.Controls.Add(this.btncancelarmostrar);
            this.Controls.Add(this.btnMostrarPosiciones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "tablagoleadores";
            this.Text = "tabladegoleadores";
            ((System.ComponentModel.ISupportInitialize)(this.dgvtablagoleadores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMostrarPosiciones;
        private System.Windows.Forms.Button btncancelarmostrar;
        private System.Windows.Forms.DataGridView dgvtablagoleadores;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rk;
        private System.Windows.Forms.DataGridViewTextBoxColumn Namejugador;
        private System.Windows.Forms.DataGridViewTextBoxColumn goles;
        private System.Windows.Forms.DataGridViewTextBoxColumn posicion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Equipo;
    }
}