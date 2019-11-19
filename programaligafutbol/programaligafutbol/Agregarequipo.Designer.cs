namespace programaligafutbol
{
    partial class Agregarequipo
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtnombreequipo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtnombrejugador = new System.Windows.Forms.TextBox();
            this.dgvEquipos = new System.Windows.Forms.DataGridView();
            this.NombreEquipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameJugador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.baddjugador = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.btnvaciar = new System.Windows.Forms.Button();
            this.guardar = new System.Windows.Forms.Button();
            this.volverbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(73, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre del Equipo: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtnombreequipo
            // 
            this.txtnombreequipo.Location = new System.Drawing.Point(225, 108);
            this.txtnombreequipo.Name = "txtnombreequipo";
            this.txtnombreequipo.Size = new System.Drawing.Size(326, 20);
            this.txtnombreequipo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(273, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "Datos de equipo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(73, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nombre del Jugador: ";
            // 
            // txtnombrejugador
            // 
            this.txtnombrejugador.Location = new System.Drawing.Point(225, 154);
            this.txtnombrejugador.Name = "txtnombrejugador";
            this.txtnombrejugador.Size = new System.Drawing.Size(326, 20);
            this.txtnombrejugador.TabIndex = 4;
            // 
            // dgvEquipos
            // 
            this.dgvEquipos.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dgvEquipos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEquipos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreEquipo,
            this.NameJugador});
            this.dgvEquipos.Location = new System.Drawing.Point(225, 203);
            this.dgvEquipos.Name = "dgvEquipos";
            this.dgvEquipos.Size = new System.Drawing.Size(326, 235);
            this.dgvEquipos.TabIndex = 5;
            // 
            // NombreEquipo
            // 
            this.NombreEquipo.HeaderText = "Nombre Del Equipo";
            this.NombreEquipo.Name = "NombreEquipo";
            this.NombreEquipo.Width = 135;
            // 
            // NameJugador
            // 
            this.NameJugador.HeaderText = "Nombre de los Jugadores";
            this.NameJugador.Name = "NameJugador";
            this.NameJugador.Width = 135;
            // 
            // baddjugador
            // 
            this.baddjugador.Location = new System.Drawing.Point(68, 240);
            this.baddjugador.Name = "baddjugador";
            this.baddjugador.Size = new System.Drawing.Size(94, 29);
            this.baddjugador.TabIndex = 6;
            this.baddjugador.Text = "Agregar";
            this.baddjugador.UseVisualStyleBackColor = true;
            this.baddjugador.Click += new System.EventHandler(this.baddjugador_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(68, 379);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(94, 27);
            this.cancel.TabIndex = 7;
            this.cancel.Text = "Cancelar";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // btnvaciar
            // 
            this.btnvaciar.Location = new System.Drawing.Point(68, 286);
            this.btnvaciar.Name = "btnvaciar";
            this.btnvaciar.Size = new System.Drawing.Size(93, 31);
            this.btnvaciar.TabIndex = 8;
            this.btnvaciar.Text = "vaciar";
            this.btnvaciar.UseVisualStyleBackColor = true;
            this.btnvaciar.Click += new System.EventHandler(this.btnvaciar_Click);
            // 
            // guardar
            // 
            this.guardar.Location = new System.Drawing.Point(68, 332);
            this.guardar.Name = "guardar";
            this.guardar.Size = new System.Drawing.Size(92, 30);
            this.guardar.TabIndex = 9;
            this.guardar.Text = "Guardar";
            this.guardar.UseVisualStyleBackColor = true;
            this.guardar.Click += new System.EventHandler(this.guardar_Click);
            // 
            // volverbtn
            // 
            this.volverbtn.Location = new System.Drawing.Point(68, 379);
            this.volverbtn.Name = "volverbtn";
            this.volverbtn.Size = new System.Drawing.Size(94, 27);
            this.volverbtn.TabIndex = 10;
            this.volverbtn.Text = "Volver";
            this.volverbtn.UseVisualStyleBackColor = true;
            this.volverbtn.Visible = false;
            this.volverbtn.Click += new System.EventHandler(this.volverbtn_Click);
            // 
            // Agregarequipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(687, 450);
            this.Controls.Add(this.volverbtn);
            this.Controls.Add(this.guardar);
            this.Controls.Add(this.btnvaciar);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.baddjugador);
            this.Controls.Add(this.dgvEquipos);
            this.Controls.Add(this.txtnombrejugador);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtnombreequipo);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Agregarequipo";
            this.Text = "Agregar Equipo";
            this.Load += new System.EventHandler(this.Agregadojugadores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnombreequipo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtnombrejugador;
        private System.Windows.Forms.DataGridView dgvEquipos;
        private System.Windows.Forms.Button baddjugador;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button btnvaciar;
        private System.Windows.Forms.Button guardar;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreEquipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameJugador;
        private System.Windows.Forms.Button volverbtn;
    }
}