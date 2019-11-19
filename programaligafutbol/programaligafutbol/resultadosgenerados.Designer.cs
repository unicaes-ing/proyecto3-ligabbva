namespace programaligafutbol
{
    partial class resultadosgenerados
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Generar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.te1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Te2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Te3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Te4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Te5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.E5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.E4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.E3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.E2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.E1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvNumeros = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNumeros)).BeginInit();
            this.SuspendLayout();
            // 
            // Generar
            // 
            this.Generar.Location = new System.Drawing.Point(27, 57);
            this.Generar.Name = "Generar";
            this.Generar.Size = new System.Drawing.Size(186, 42);
            this.Generar.TabIndex = 2;
            this.Generar.Text = "Generar Resultados\r\n";
            this.Generar.UseVisualStyleBackColor = true;
            this.Generar.Click += new System.EventHandler(this.Generar_Click);
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.te1,
            this.Te2,
            this.Te3,
            this.Te4,
            this.Te5});
            this.dataGridView1.Location = new System.Drawing.Point(81, 120);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(638, 49);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // te1
            // 
            this.te1.HeaderText = "Equipo 1";
            this.te1.Name = "te1";
            // 
            // Te2
            // 
            this.Te2.HeaderText = "Equipo 2";
            this.Te2.Name = "Te2";
            // 
            // Te3
            // 
            this.Te3.HeaderText = "Equipo 3";
            this.Te3.Name = "Te3";
            // 
            // Te4
            // 
            this.Te4.HeaderText = "Equipo 4";
            this.Te4.Name = "Te4";
            // 
            // Te5
            // 
            this.Te5.HeaderText = "Equipo 5";
            this.Te5.Name = "Te5";
            // 
            // E5
            // 
            this.E5.HeaderText = "Equipo 5";
            this.E5.Name = "E5";
            this.E5.ReadOnly = true;
            // 
            // E4
            // 
            this.E4.HeaderText = "Equipo 4";
            this.E4.Name = "E4";
            this.E4.ReadOnly = true;
            // 
            // E3
            // 
            this.E3.HeaderText = "Equipo 3";
            this.E3.Name = "E3";
            this.E3.ReadOnly = true;
            // 
            // E2
            // 
            this.E2.HeaderText = "Equipo 2";
            this.E2.Name = "E2";
            this.E2.ReadOnly = true;
            // 
            // E1
            // 
            this.E1.HeaderText = "Equipo 1";
            this.E1.Name = "E1";
            this.E1.ReadOnly = true;
            // 
            // dgvNumeros
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNumeros.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvNumeros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNumeros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.E1,
            this.E2,
            this.E3,
            this.E4,
            this.E5});
            this.dgvNumeros.Location = new System.Drawing.Point(81, 165);
            this.dgvNumeros.Name = "dgvNumeros";
            this.dgvNumeros.ReadOnly = true;
            this.dgvNumeros.RowHeadersVisible = false;
            this.dgvNumeros.Size = new System.Drawing.Size(638, 231);
            this.dgvNumeros.TabIndex = 1;
            this.dgvNumeros.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvNumeros_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(279, 60);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 38);
            this.button1.TabIndex = 4;
            this.button1.Text = "Volver";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // resultadosgenerados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Generar);
            this.Controls.Add(this.dgvNumeros);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "resultadosgenerados";
            this.Text = "resultadosgenerados";
            this.Load += new System.EventHandler(this.Resultadosgenerados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNumeros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Generar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn te1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Te2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Te3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Te4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Te5;
        private System.Windows.Forms.DataGridViewTextBoxColumn E5;
        private System.Windows.Forms.DataGridViewTextBoxColumn E4;
        private System.Windows.Forms.DataGridViewTextBoxColumn E3;
        private System.Windows.Forms.DataGridViewTextBoxColumn E2;
        private System.Windows.Forms.DataGridViewTextBoxColumn E1;
        private System.Windows.Forms.DataGridView dgvNumeros;
        private System.Windows.Forms.Button button1;
    }
}