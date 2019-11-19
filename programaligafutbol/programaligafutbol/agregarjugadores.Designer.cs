namespace programaligafutbol
{
    partial class GestionDeJugadores
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtnombrejugador = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtposicionj = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtequipojp = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtgoles = new System.Windows.Forms.TextBox();
            this.btnGenerarGoles = new System.Windows.Forms.Button();
            this.btndjcancel = new System.Windows.Forms.Button();
            this.btnguardatjugador = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(196, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Datos del Jugador";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre del Jugador: ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtnombrejugador
            // 
            this.txtnombrejugador.Location = new System.Drawing.Point(188, 102);
            this.txtnombrejugador.Name = "txtnombrejugador";
            this.txtnombrejugador.Size = new System.Drawing.Size(234, 20);
            this.txtnombrejugador.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Posición: ";
            // 
            // txtposicionj
            // 
            this.txtposicionj.Location = new System.Drawing.Point(188, 138);
            this.txtposicionj.Name = "txtposicionj";
            this.txtposicionj.Size = new System.Drawing.Size(234, 20);
            this.txtposicionj.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "Equipo al que pertenece";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtequipojp
            // 
            this.txtequipojp.Location = new System.Drawing.Point(188, 174);
            this.txtequipojp.Name = "txtequipojp";
            this.txtequipojp.Size = new System.Drawing.Size(234, 20);
            this.txtequipojp.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(35, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 24);
            this.label5.TabIndex = 7;
            this.label5.Text = "Goles";
            // 
            // txtgoles
            // 
            this.txtgoles.Location = new System.Drawing.Point(188, 210);
            this.txtgoles.Name = "txtgoles";
            this.txtgoles.Size = new System.Drawing.Size(98, 20);
            this.txtgoles.TabIndex = 8;
            // 
            // btnGenerarGoles
            // 
            this.btnGenerarGoles.Location = new System.Drawing.Point(319, 209);
            this.btnGenerarGoles.Name = "btnGenerarGoles";
            this.btnGenerarGoles.Size = new System.Drawing.Size(69, 21);
            this.btnGenerarGoles.TabIndex = 9;
            this.btnGenerarGoles.Text = "Generar";
            this.btnGenerarGoles.UseVisualStyleBackColor = true;
            this.btnGenerarGoles.Click += new System.EventHandler(this.btnGenerarGoles_Click);
            // 
            // btndjcancel
            // 
            this.btndjcancel.Location = new System.Drawing.Point(319, 260);
            this.btndjcancel.Name = "btndjcancel";
            this.btndjcancel.Size = new System.Drawing.Size(80, 20);
            this.btndjcancel.TabIndex = 10;
            this.btndjcancel.Text = "Cancelar";
            this.btndjcancel.UseVisualStyleBackColor = true;
            this.btndjcancel.Click += new System.EventHandler(this.btndjcancel_Click);
            // 
            // btnguardatjugador
            // 
            this.btnguardatjugador.Location = new System.Drawing.Point(197, 258);
            this.btnguardatjugador.Name = "btnguardatjugador";
            this.btnguardatjugador.Size = new System.Drawing.Size(88, 21);
            this.btnguardatjugador.TabIndex = 11;
            this.btnguardatjugador.Text = "Guardar";
            this.btnguardatjugador.UseVisualStyleBackColor = true;
            this.btnguardatjugador.Click += new System.EventHandler(this.btnguardatjugador_Click);
            // 
            // GestionDeJugadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 412);
            this.Controls.Add(this.btnguardatjugador);
            this.Controls.Add(this.btndjcancel);
            this.Controls.Add(this.btnGenerarGoles);
            this.Controls.Add(this.txtgoles);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtequipojp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtposicionj);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtnombrejugador);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GestionDeJugadores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "GestiondeJugadores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnombrejugador;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtposicionj;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtequipojp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtgoles;
        private System.Windows.Forms.Button btnGenerarGoles;
        private System.Windows.Forms.Button btndjcancel;
        private System.Windows.Forms.Button btnguardatjugador;
    }
}