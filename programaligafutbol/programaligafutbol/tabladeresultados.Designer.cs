namespace programaligafutbol
{
    partial class tabladeresultados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tabladeresultados));
            this.btnRegresar = new System.Windows.Forms.Button();
            this.ingresoderesultado = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRegresar
            // 
            this.btnRegresar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRegresar.Image = ((System.Drawing.Image)(resources.GetObject("btnRegresar.Image")));
            this.btnRegresar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegresar.Location = new System.Drawing.Point(459, 208);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(148, 44);
            this.btnRegresar.TabIndex = 5;
            this.btnRegresar.Text = "    Regresar";
            this.btnRegresar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click_1);
            // 
            // ingresoderesultado
            // 
            this.ingresoderesultado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ingresoderesultado.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ingresoderesultado.Image = ((System.Drawing.Image)(resources.GetObject("ingresoderesultado.Image")));
            this.ingresoderesultado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ingresoderesultado.Location = new System.Drawing.Point(188, 208);
            this.ingresoderesultado.Name = "ingresoderesultado";
            this.ingresoderesultado.Size = new System.Drawing.Size(165, 44);
            this.ingresoderesultado.TabIndex = 13;
            this.ingresoderesultado.Text = "     Ingresar Resultados";
            this.ingresoderesultado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ingresoderesultado.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ingresoderesultado.UseVisualStyleBackColor = true;
            this.ingresoderesultado.Click += new System.EventHandler(this.ingresoderesultado_Click);
            // 
            // tabladeresultados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ingresoderesultado);
            this.Controls.Add(this.btnRegresar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "tabladeresultados";
            this.Text = "tabladeresultados";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button ingresoderesultado;
    }
}