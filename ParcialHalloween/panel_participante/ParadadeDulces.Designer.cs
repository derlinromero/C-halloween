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
            this.btnTomarDulce = new System.Windows.Forms.Button();
            this.lblDulcesDisp = new System.Windows.Forms.Label();
            this.txtDulcesTomar = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblNombreParada = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtDulcesTomar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTomarDulce
            // 
            this.btnTomarDulce.BackColor = System.Drawing.Color.Magenta;
            this.btnTomarDulce.FlatAppearance.BorderSize = 0;
            this.btnTomarDulce.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTomarDulce.Font = new System.Drawing.Font("Old English Text MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTomarDulce.Location = new System.Drawing.Point(50, 285);
            this.btnTomarDulce.Name = "btnTomarDulce";
            this.btnTomarDulce.Size = new System.Drawing.Size(148, 55);
            this.btnTomarDulce.TabIndex = 1;
            this.btnTomarDulce.Text = "Tomar Dulce";
            this.btnTomarDulce.UseVisualStyleBackColor = false;
            this.btnTomarDulce.Click += new System.EventHandler(this.btnTomarDulce_Click);
            // 
            // lblDulcesDisp
            // 
            this.lblDulcesDisp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDulcesDisp.Location = new System.Drawing.Point(119, 161);
            this.lblDulcesDisp.Name = "lblDulcesDisp";
            this.lblDulcesDisp.Size = new System.Drawing.Size(168, 49);
            this.lblDulcesDisp.TabIndex = 3;
            this.lblDulcesDisp.Text = "label1";
            this.lblDulcesDisp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDulcesTomar
            // 
            this.txtDulcesTomar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDulcesTomar.Location = new System.Drawing.Point(125, 239);
            this.txtDulcesTomar.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.txtDulcesTomar.Name = "txtDulcesTomar";
            this.txtDulcesTomar.Size = new System.Drawing.Size(156, 26);
            this.txtDulcesTomar.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(132, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Dulces a Tomar";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Old English Text MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(204, 285);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(148, 55);
            this.btnCancelar.TabIndex = 16;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblNombreParada
            // 
            this.lblNombreParada.BackColor = System.Drawing.Color.DimGray;
            this.lblNombreParada.Font = new System.Drawing.Font("Showcard Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreParada.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblNombreParada.Location = new System.Drawing.Point(50, 31);
            this.lblNombreParada.Name = "lblNombreParada";
            this.lblNombreParada.Size = new System.Drawing.Size(302, 105);
            this.lblNombreParada.TabIndex = 18;
            this.lblNombreParada.Text = ".";
            this.lblNombreParada.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ParadadeDulces
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ParcialHalloween.Properties.Resources.actividad;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(416, 377);
            this.Controls.Add(this.lblNombreParada);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDulcesTomar);
            this.Controls.Add(this.lblDulcesDisp);
            this.Controls.Add(this.btnTomarDulce);
            this.DoubleBuffered = true;
            this.Name = "ParadadeDulces";
            this.Text = "ParadadeDulces";
            ((System.ComponentModel.ISupportInitialize)(this.txtDulcesTomar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnTomarDulce;
        private System.Windows.Forms.Label lblDulcesDisp;
        private System.Windows.Forms.NumericUpDown txtDulcesTomar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblNombreParada;
    }
}