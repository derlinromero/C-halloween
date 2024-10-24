namespace ParcialHalloween
{
    partial class PanelAdmin
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
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.btnParadas = new System.Windows.Forms.Button();
            this.btnPuntuaciones = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.BackColor = System.Drawing.Color.SlateGray;
            this.btnUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuarios.ForeColor = System.Drawing.Color.White;
            this.btnUsuarios.Location = new System.Drawing.Point(227, 127);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(339, 76);
            this.btnUsuarios.TabIndex = 0;
            this.btnUsuarios.Text = "Gestion de Usuarios";
            this.btnUsuarios.UseVisualStyleBackColor = false;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // btnParadas
            // 
            this.btnParadas.BackColor = System.Drawing.Color.SlateGray;
            this.btnParadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnParadas.ForeColor = System.Drawing.Color.White;
            this.btnParadas.Location = new System.Drawing.Point(227, 226);
            this.btnParadas.Name = "btnParadas";
            this.btnParadas.Size = new System.Drawing.Size(339, 76);
            this.btnParadas.TabIndex = 1;
            this.btnParadas.Text = "Gestion de Paradas de Dulces";
            this.btnParadas.UseVisualStyleBackColor = false;
            this.btnParadas.Click += new System.EventHandler(this.btnParadas_Click);
            // 
            // btnPuntuaciones
            // 
            this.btnPuntuaciones.BackColor = System.Drawing.Color.SlateGray;
            this.btnPuntuaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPuntuaciones.ForeColor = System.Drawing.Color.White;
            this.btnPuntuaciones.Location = new System.Drawing.Point(227, 322);
            this.btnPuntuaciones.Name = "btnPuntuaciones";
            this.btnPuntuaciones.Size = new System.Drawing.Size(339, 76);
            this.btnPuntuaciones.TabIndex = 2;
            this.btnPuntuaciones.Text = "Ver Tabla de Puntuaciones";
            this.btnPuntuaciones.UseVisualStyleBackColor = false;
            this.btnPuntuaciones.Click += new System.EventHandler(this.btnPuntuaciones_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(220, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(346, 35);
            this.label3.TabIndex = 7;
            this.label3.Text = "Panel Administrador";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PanelAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnPuntuaciones);
            this.Controls.Add(this.btnParadas);
            this.Controls.Add(this.btnUsuarios);
            this.Name = "PanelAdmin";
            this.Text = "PanelAdmin";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Button btnParadas;
        private System.Windows.Forms.Button btnPuntuaciones;
        private System.Windows.Forms.Label label3;
    }
}