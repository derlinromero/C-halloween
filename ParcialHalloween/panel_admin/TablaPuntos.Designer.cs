namespace ParcialHalloween
{
    partial class TablaPuntos
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
            this.lsbPuntuaciones = new System.Windows.Forms.ListBox();
            this.pcbFoto = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombreDisfraz = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // lsbPuntuaciones
            // 
            this.lsbPuntuaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsbPuntuaciones.FormattingEnabled = true;
            this.lsbPuntuaciones.ItemHeight = 20;
            this.lsbPuntuaciones.Location = new System.Drawing.Point(28, 105);
            this.lsbPuntuaciones.Name = "lsbPuntuaciones";
            this.lsbPuntuaciones.Size = new System.Drawing.Size(399, 344);
            this.lsbPuntuaciones.TabIndex = 0;
            this.lsbPuntuaciones.SelectedIndexChanged += new System.EventHandler(this.lsbPuntuaciones_SelectedIndexChanged);
            // 
            // pcbFoto
            // 
            this.pcbFoto.Location = new System.Drawing.Point(433, 200);
            this.pcbFoto.Name = "pcbFoto";
            this.pcbFoto.Size = new System.Drawing.Size(210, 247);
            this.pcbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbFoto.TabIndex = 1;
            this.pcbFoto.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(433, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Disfraz";
            // 
            // txtNombreDisfraz
            // 
            this.txtNombreDisfraz.AutoSize = true;
            this.txtNombreDisfraz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreDisfraz.Location = new System.Drawing.Point(433, 450);
            this.txtNombreDisfraz.Name = "txtNombreDisfraz";
            this.txtNombreDisfraz.Size = new System.Drawing.Size(0, 20);
            this.txtNombreDisfraz.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(250, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(346, 78);
            this.label3.TabIndex = 14;
            this.label3.Text = "Tabla de Puntuaciones";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TablaPuntos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 486);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNombreDisfraz);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pcbFoto);
            this.Controls.Add(this.lsbPuntuaciones);
            this.Name = "TablaPuntos";
            this.Text = "TablaPuntos";
            ((System.ComponentModel.ISupportInitialize)(this.pcbFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lsbPuntuaciones;
        private System.Windows.Forms.PictureBox pcbFoto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtNombreDisfraz;
        private System.Windows.Forms.Label label3;
    }
}