namespace programaligafutbol
{
    partial class buscarequipo
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
            this.txtbuscarequipo = new System.Windows.Forms.TextBox();
            this.btnbuscarequipo = new System.Windows.Forms.Button();
            this.txtmostrar = new System.Windows.Forms.TextBox();
            this.btnregresar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre del equipo";
            // 
            // txtbuscarequipo
            // 
            this.txtbuscarequipo.Location = new System.Drawing.Point(114, 17);
            this.txtbuscarequipo.Name = "txtbuscarequipo";
            this.txtbuscarequipo.Size = new System.Drawing.Size(234, 20);
            this.txtbuscarequipo.TabIndex = 1;
            // 
            // btnbuscarequipo
            // 
            this.btnbuscarequipo.Location = new System.Drawing.Point(367, 8);
            this.btnbuscarequipo.Name = "btnbuscarequipo";
            this.btnbuscarequipo.Size = new System.Drawing.Size(96, 29);
            this.btnbuscarequipo.TabIndex = 2;
            this.btnbuscarequipo.Text = "Buscar";
            this.btnbuscarequipo.UseVisualStyleBackColor = true;
            this.btnbuscarequipo.Click += new System.EventHandler(this.btnbuscarequipo_Click);
            // 
            // txtmostrar
            // 
            this.txtmostrar.Location = new System.Drawing.Point(114, 89);
            this.txtmostrar.Multiline = true;
            this.txtmostrar.Name = "txtmostrar";
            this.txtmostrar.Size = new System.Drawing.Size(234, 280);
            this.txtmostrar.TabIndex = 3;
            // 
            // btnregresar
            // 
            this.btnregresar.Location = new System.Drawing.Point(367, 51);
            this.btnregresar.Name = "btnregresar";
            this.btnregresar.Size = new System.Drawing.Size(95, 28);
            this.btnregresar.TabIndex = 4;
            this.btnregresar.Text = "Regresar";
            this.btnregresar.UseVisualStyleBackColor = true;
            this.btnregresar.Click += new System.EventHandler(this.btnregresar_Click);
            // 
            // buscarequipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 450);
            this.Controls.Add(this.btnregresar);
            this.Controls.Add(this.txtmostrar);
            this.Controls.Add(this.btnbuscarequipo);
            this.Controls.Add(this.txtbuscarequipo);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "buscarequipo";
            this.Text = "buscarequipo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbuscarequipo;
        private System.Windows.Forms.Button btnbuscarequipo;
        private System.Windows.Forms.TextBox txtmostrar;
        private System.Windows.Forms.Button btnregresar;
    }
}