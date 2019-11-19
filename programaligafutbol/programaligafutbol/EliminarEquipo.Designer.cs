namespace programaligafutbol
{
    partial class EliminarEquipo
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
            this.txtbusequipeliminar = new System.Windows.Forms.TextBox();
            this.btnbusca = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(281, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Eliminar Equipo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(89, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Buscar Equipo a eliminar: ";
            // 
            // txtbusequipeliminar
            // 
            this.txtbusequipeliminar.Location = new System.Drawing.Point(248, 95);
            this.txtbusequipeliminar.Name = "txtbusequipeliminar";
            this.txtbusequipeliminar.Size = new System.Drawing.Size(291, 20);
            this.txtbusequipeliminar.TabIndex = 2;
            // 
            // btnbusca
            // 
            this.btnbusca.Location = new System.Drawing.Point(248, 141);
            this.btnbusca.Name = "btnbusca";
            this.btnbusca.Size = new System.Drawing.Size(58, 30);
            this.btnbusca.TabIndex = 3;
            this.btnbusca.Text = "Buscar";
            this.btnbusca.UseVisualStyleBackColor = true;
            this.btnbusca.Click += new System.EventHandler(this.btnbusca_Click);
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(330, 141);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(68, 30);
            this.btncancel.TabIndex = 4;
            this.btncancel.Text = "Cancelar";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.Location = new System.Drawing.Point(423, 141);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(115, 29);
            this.btneliminar.TabIndex = 5;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Visible = false;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // EliminarEquipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnbusca);
            this.Controls.Add(this.txtbusequipeliminar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EliminarEquipo";
            this.Text = "EliminarEquipo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbusequipeliminar;
        private System.Windows.Forms.Button btnbusca;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btneliminar;
    }
}