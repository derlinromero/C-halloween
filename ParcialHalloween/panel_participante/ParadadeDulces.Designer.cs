namespace ParcialHalloween.panel_participante
{
    partial class ParadadeDulces
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
            this.cmbParadas = new System.Windows.Forms.ComboBox();
            this.btnTomarDulce = new System.Windows.Forms.Button();
            this.pcbFoto = new System.Windows.Forms.PictureBox();
            this.txtDulcesDisp = new System.Windows.Forms.Label();
            this.txtDulcesTomar = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDulcesTomar)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbParadas
            // 
            this.cmbParadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbParadas.FormattingEnabled = true;
            this.cmbParadas.Location = new System.Drawing.Point(80, 180);
            this.cmbParadas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbParadas.Name = "cmbParadas";
            this.cmbParadas.Size = new System.Drawing.Size(451, 33);
            this.cmbParadas.TabIndex = 0;
            this.cmbParadas.SelectedIndexChanged += new System.EventHandler(this.cmbParadas_SelectedIndexChanged);
            // 
            // btnTomarDulce
            // 
            this.btnTomarDulce.BackColor = System.Drawing.Color.Magenta;
            this.btnTomarDulce.FlatAppearance.BorderSize = 0;
            this.btnTomarDulce.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTomarDulce.Font = new System.Drawing.Font("Old English Text MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTomarDulce.Location = new System.Drawing.Point(60, 607);
            this.btnTomarDulce.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTomarDulce.Name = "btnTomarDulce";
            this.btnTomarDulce.Size = new System.Drawing.Size(197, 68);
            this.btnTomarDulce.TabIndex = 1;
            this.btnTomarDulce.Text = "Tomar Dulce";
            this.btnTomarDulce.UseVisualStyleBackColor = false;
            this.btnTomarDulce.Click += new System.EventHandler(this.btnTomarDulce_Click);
            // 
            // pcbFoto
            // 
            this.pcbFoto.Location = new System.Drawing.Point(200, 232);
            this.pcbFoto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pcbFoto.Name = "pcbFoto";
            this.pcbFoto.Size = new System.Drawing.Size(219, 209);
            this.pcbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbFoto.TabIndex = 2;
            this.pcbFoto.TabStop = false;
            // 
            // txtDulcesDisp
            // 
            this.txtDulcesDisp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDulcesDisp.Location = new System.Drawing.Point(195, 454);
            this.txtDulcesDisp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtDulcesDisp.Name = "txtDulcesDisp";
            this.txtDulcesDisp.Size = new System.Drawing.Size(224, 60);
            this.txtDulcesDisp.TabIndex = 3;
            this.txtDulcesDisp.Text = "label1";
            this.txtDulcesDisp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDulcesTomar
            // 
            this.txtDulcesTomar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDulcesTomar.Location = new System.Drawing.Point(200, 556);
            this.txtDulcesTomar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDulcesTomar.Name = "txtDulcesTomar";
            this.txtDulcesTomar.Size = new System.Drawing.Size(208, 30);
            this.txtDulcesTomar.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(229, 526);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "Dulces a Tomar";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Showcard Gothic", 25.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(71, 37);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(461, 114);
            this.label3.TabIndex = 14;
            this.label3.Text = "Visita por Paradas de Dulces";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(75, 151);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(229, 26);
            this.label2.TabIndex = 15;
            this.label2.Text = "Paradas Disponibles";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Old English Text MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(299, 607);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(197, 68);
            this.btnCancelar.TabIndex = 16;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // ParadadeDulces
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ParcialHalloween.Properties.Resources.actividad;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(633, 689);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDulcesTomar);
            this.Controls.Add(this.txtDulcesDisp);
            this.Controls.Add(this.pcbFoto);
            this.Controls.Add(this.btnTomarDulce);
            this.Controls.Add(this.cmbParadas);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ParadadeDulces";
            this.Text = "ParadadeDulces";
            ((System.ComponentModel.ISupportInitialize)(this.pcbFoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDulcesTomar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbParadas;
        private System.Windows.Forms.Button btnTomarDulce;
        private System.Windows.Forms.PictureBox pcbFoto;
        private System.Windows.Forms.Label txtDulcesDisp;
        private System.Windows.Forms.NumericUpDown txtDulcesTomar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancelar;
    }
}