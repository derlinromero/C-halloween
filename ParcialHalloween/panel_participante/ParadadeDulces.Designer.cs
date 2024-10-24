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
            this.cmbParadas.Location = new System.Drawing.Point(60, 146);
            this.cmbParadas.Name = "cmbParadas";
            this.cmbParadas.Size = new System.Drawing.Size(339, 28);
            this.cmbParadas.TabIndex = 0;
            this.cmbParadas.SelectedIndexChanged += new System.EventHandler(this.cmbParadas_SelectedIndexChanged);
            // 
            // btnTomarDulce
            // 
            this.btnTomarDulce.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTomarDulce.Location = new System.Drawing.Point(45, 493);
            this.btnTomarDulce.Name = "btnTomarDulce";
            this.btnTomarDulce.Size = new System.Drawing.Size(148, 55);
            this.btnTomarDulce.TabIndex = 1;
            this.btnTomarDulce.Text = "Tomar Dulce";
            this.btnTomarDulce.UseVisualStyleBackColor = true;
            this.btnTomarDulce.Click += new System.EventHandler(this.btnTomarDulce_Click);
            // 
            // pcbFoto
            // 
            this.pcbFoto.Location = new System.Drawing.Point(142, 180);
            this.pcbFoto.Name = "pcbFoto";
            this.pcbFoto.Size = new System.Drawing.Size(164, 170);
            this.pcbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbFoto.TabIndex = 2;
            this.pcbFoto.TabStop = false;
            // 
            // txtDulcesDisp
            // 
            this.txtDulcesDisp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDulcesDisp.Location = new System.Drawing.Point(138, 353);
            this.txtDulcesDisp.Name = "txtDulcesDisp";
            this.txtDulcesDisp.Size = new System.Drawing.Size(168, 49);
            this.txtDulcesDisp.TabIndex = 3;
            this.txtDulcesDisp.Text = "label1";
            this.txtDulcesDisp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDulcesTomar
            // 
            this.txtDulcesTomar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDulcesTomar.Location = new System.Drawing.Point(111, 450);
            this.txtDulcesTomar.Name = "txtDulcesTomar";
            this.txtDulcesTomar.Size = new System.Drawing.Size(240, 26);
            this.txtDulcesTomar.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(172, 427);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Dulces a Tomar";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(53, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(346, 78);
            this.label3.TabIndex = 14;
            this.label3.Text = "Visita por Paradas de Dulces";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(56, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Paradas Disponibles";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(224, 493);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(148, 55);
            this.btnCancelar.TabIndex = 16;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // ParadadeDulces
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 560);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDulcesTomar);
            this.Controls.Add(this.txtDulcesDisp);
            this.Controls.Add(this.pcbFoto);
            this.Controls.Add(this.btnTomarDulce);
            this.Controls.Add(this.cmbParadas);
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