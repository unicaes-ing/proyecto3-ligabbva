namespace programaligafutbol
{
    partial class tabladeposicionescopia
    {
        /// <summary>
        /// Variable del diseñador requerdida
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

        #region Codigo generado de Windows Form

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Equipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PJ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.P = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Equipo,
            this.PJ,
            this.PG,
            this.PE,
            this.PP,
            this.GF,
            this.GC,
            this.DG,
            this.P});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Size = new System.Drawing.Size(776, 275);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick_1);
            // 
            // Equipo
            // 
            this.Equipo.HeaderText = "Equipo";
            this.Equipo.Name = "Equipo";
            this.Equipo.Width = 125;
            // 
            // PJ
            // 
            this.PJ.HeaderText = "Partidos Jugados";
            this.PJ.Name = "PJ";
            this.PJ.Width = 75;
            // 
            // PG
            // 
            this.PG.HeaderText = "Partidos Ganados";
            this.PG.Name = "PG";
            this.PG.Width = 75;
            // 
            // PE
            // 
            this.PE.HeaderText = "Partidos Empatados";
            this.PE.Name = "PE";
            this.PE.Width = 75;
            // 
            // PP
            // 
            this.PP.HeaderText = "Partidos Perdidos";
            this.PP.Name = "PP";
            this.PP.Width = 75;
            // 
            // GF
            // 
            this.GF.HeaderText = "Goles a Favor";
            this.GF.Name = "GF";
            this.GF.Width = 75;
            // 
            // GC
            // 
            this.GC.HeaderText = "Goles en Contra";
            this.GC.Name = "GC";
            this.GC.Width = 75;
            // 
            // DG
            // 
            this.DG.HeaderText = "Diferencia de Goles";
            this.DG.Name = "DG";
            this.DG.Width = 75;
            // 
            // P
            // 
            this.P.HeaderText = "Puntos";
            this.P.Name = "P";
            this.P.Width = 75;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(119, 344);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 37);
            this.button1.TabIndex = 1;
            this.button1.Text = "Mostrar Datos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(291, 344);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 37);
            this.button2.TabIndex = 2;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // tabladeposicionescopia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "tabladeposicionescopia";
            this.Text = "tabladeposiciones";
            this.Load += new System.EventHandler(this.Tabladeposiciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Equipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn PJ;
        private System.Windows.Forms.DataGridViewTextBoxColumn PG;
        private System.Windows.Forms.DataGridViewTextBoxColumn PE;
        private System.Windows.Forms.DataGridViewTextBoxColumn PP;
        private System.Windows.Forms.DataGridViewTextBoxColumn GF;
        private System.Windows.Forms.DataGridViewTextBoxColumn GC;
        private System.Windows.Forms.DataGridViewTextBoxColumn DG;
        private System.Windows.Forms.DataGridViewTextBoxColumn P;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}