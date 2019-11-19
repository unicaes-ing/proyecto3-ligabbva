namespace programaligafutbol
{
    partial class eliminaciondejugador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(eliminaciondejugador));
            this.label1 = new System.Windows.Forms.Label();
            this.txtbuscajugador = new System.Windows.Forms.TextBox();
            this.btnbuscarjugador = new System.Windows.Forms.Button();
            this.dgvjugador = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvjugador)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre del Jugador";
            // 
            // txtbuscajugador
            // 
            this.txtbuscajugador.Location = new System.Drawing.Point(140, 57);
            this.txtbuscajugador.Name = "txtbuscajugador";
            this.txtbuscajugador.Size = new System.Drawing.Size(248, 20);
            this.txtbuscajugador.TabIndex = 1;
            // 
            // btnbuscarjugador
            // 
            this.btnbuscarjugador.Image = ((System.Drawing.Image)(resources.GetObject("btnbuscarjugador.Image")));
            this.btnbuscarjugador.Location = new System.Drawing.Point(420, 54);
            this.btnbuscarjugador.Name = "btnbuscarjugador";
            this.btnbuscarjugador.Size = new System.Drawing.Size(106, 23);
            this.btnbuscarjugador.TabIndex = 2;
            this.btnbuscarjugador.Text = " Buscar jugador";
            this.btnbuscarjugador.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnbuscarjugador.UseVisualStyleBackColor = true;
            this.btnbuscarjugador.Click += new System.EventHandler(this.btnbuscarjugador_Click);
            // 
            // dgvjugador
            // 
            this.dgvjugador.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvjugador.Location = new System.Drawing.Point(140, 136);
            this.dgvjugador.Name = "dgvjugador";
            this.dgvjugador.Size = new System.Drawing.Size(385, 270);
            this.dgvjugador.TabIndex = 3;
            // 
            // eliminaciondejugador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvjugador);
            this.Controls.Add(this.btnbuscarjugador);
            this.Controls.Add(this.txtbuscajugador);
            this.Controls.Add(this.label1);
            this.Name = "eliminaciondejugador";
            this.Text = "eliminaciondejugador";
            ((System.ComponentModel.ISupportInitialize)(this.dgvjugador)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbuscajugador;
        private System.Windows.Forms.Button btnbuscarjugador;
        private System.Windows.Forms.DataGridView dgvjugador;
    }
}