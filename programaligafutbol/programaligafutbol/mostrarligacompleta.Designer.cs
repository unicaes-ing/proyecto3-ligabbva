namespace programaligafutbol
{
    partial class mostrarligacompleta
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
            this.btnmostrarliga = new System.Windows.Forms.Button();
            this.cerrar = new System.Windows.Forms.Button();
            this.txtmostrarJ = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnmostrarliga
            // 
            this.btnmostrarliga.Location = new System.Drawing.Point(33, 26);
            this.btnmostrarliga.Name = "btnmostrarliga";
            this.btnmostrarliga.Size = new System.Drawing.Size(98, 29);
            this.btnmostrarliga.TabIndex = 1;
            this.btnmostrarliga.Text = "Mostrar liga";
            this.btnmostrarliga.UseVisualStyleBackColor = true;
            this.btnmostrarliga.Click += new System.EventHandler(this.btnmostrarliga_Click);
            // 
            // cerrar
            // 
            this.cerrar.Location = new System.Drawing.Point(33, 97);
            this.cerrar.Name = "cerrar";
            this.cerrar.Size = new System.Drawing.Size(98, 29);
            this.cerrar.TabIndex = 2;
            this.cerrar.Text = "Volver";
            this.cerrar.UseVisualStyleBackColor = true;
            this.cerrar.Click += new System.EventHandler(this.cerrar_Click);
            // 
            // txtmostrarJ
            // 
            this.txtmostrarJ.Location = new System.Drawing.Point(195, 12);
            this.txtmostrarJ.Multiline = true;
            this.txtmostrarJ.Name = "txtmostrarJ";
            this.txtmostrarJ.Size = new System.Drawing.Size(324, 426);
            this.txtmostrarJ.TabIndex = 3;
            this.txtmostrarJ.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // mostrarligacompleta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtmostrarJ);
            this.Controls.Add(this.cerrar);
            this.Controls.Add(this.btnmostrarliga);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "mostrarligacompleta";
            this.Text = "mostrarligacompleta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnmostrarliga;
        private System.Windows.Forms.Button cerrar;
        private System.Windows.Forms.TextBox txtmostrarJ;
    }
}