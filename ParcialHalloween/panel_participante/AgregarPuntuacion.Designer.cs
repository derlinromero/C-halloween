namespace ParcialHalloween.panel_participante
{
    partial class AgregarPuntuacion
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
            this.lsbParticipantes = new System.Windows.Forms.ListBox();
            this.pcbFoto = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombreDisfraz = new System.Windows.Forms.Label();
            this.txtPuntos = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCalificar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPuntos)).BeginInit();
            this.SuspendLayout();
            // 
            // lsbParticipantes
            // 
            this.lsbParticipantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsbParticipantes.FormattingEnabled = true;
            this.lsbParticipantes.ItemHeight = 20;
            this.lsbParticipantes.Location = new System.Drawing.Point(27, 67);
            this.lsbParticipantes.Name = "lsbParticipantes";
            this.lsbParticipantes.Size = new System.Drawing.Size(223, 324);
            this.lsbParticipantes.TabIndex = 0;
            this.lsbParticipantes.SelectedIndexChanged += new System.EventHandler(this.lsbParticipantes_SelectedIndexChanged);
            // 
            // pcbFoto
            // 
            this.pcbFoto.Location = new System.Drawing.Point(265, 106);
            this.pcbFoto.Name = "pcbFoto";
            this.pcbFoto.Size = new System.Drawing.Size(212, 158);
            this.pcbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbFoto.TabIndex = 1;
            this.pcbFoto.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(261, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Disfraz";
            // 
            // txtNombreDisfraz
            // 
            this.txtNombreDisfraz.AutoSize = true;
            this.txtNombreDisfraz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreDisfraz.Location = new System.Drawing.Point(261, 267);
            this.txtNombreDisfraz.Name = "txtNombreDisfraz";
            this.txtNombreDisfraz.Size = new System.Drawing.Size(0, 20);
            this.txtNombreDisfraz.TabIndex = 3;
            // 
            // txtPuntos
            // 
            this.txtPuntos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPuntos.Location = new System.Drawing.Point(263, 356);
            this.txtPuntos.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.txtPuntos.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtPuntos.Name = "txtPuntos";
            this.txtPuntos.Size = new System.Drawing.Size(271, 26);
            this.txtPuntos.TabIndex = 4;
            this.txtPuntos.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(261, 333);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Puntuación";
            // 
            // btnCalificar
            // 
            this.btnCalificar.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnCalificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalificar.Location = new System.Drawing.Point(591, 332);
            this.btnCalificar.Name = "btnCalificar";
            this.btnCalificar.Size = new System.Drawing.Size(180, 59);
            this.btnCalificar.TabIndex = 6;
            this.btnCalificar.Text = "Calificar";
            this.btnCalificar.UseVisualStyleBackColor = false;
            this.btnCalificar.Click += new System.EventHandler(this.btnCalificar_Click);
            // 
            // AgregarPuntuacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCalificar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPuntos);
            this.Controls.Add(this.txtNombreDisfraz);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pcbFoto);
            this.Controls.Add(this.lsbParticipantes);
            this.Name = "AgregarPuntuacion";
            this.Text = "AgregarPuntuacion";
            ((System.ComponentModel.ISupportInitialize)(this.pcbFoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPuntos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lsbParticipantes;
        private System.Windows.Forms.PictureBox pcbFoto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtNombreDisfraz;
        private System.Windows.Forms.NumericUpDown txtPuntos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCalificar;
    }
}