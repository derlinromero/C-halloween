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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombreDisfraz = new System.Windows.Forms.Label();
            this.txtPuntos = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCalificar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.pcbFoto = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtPuntos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFoto)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lsbParticipantes
            // 
            this.lsbParticipantes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lsbParticipantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsbParticipantes.FormattingEnabled = true;
            this.lsbParticipantes.ItemHeight = 31;
            this.lsbParticipantes.Location = new System.Drawing.Point(311, 184);
            this.lsbParticipantes.Name = "lsbParticipantes";
            this.lsbParticipantes.Size = new System.Drawing.Size(288, 376);
            this.lsbParticipantes.TabIndex = 0;
            this.lsbParticipantes.SelectedIndexChanged += new System.EventHandler(this.lsbParticipantes_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(94)))), ((int)(((byte)(9)))));
            this.label1.Location = new System.Drawing.Point(79, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "Disfraz";
            // 
            // txtNombreDisfraz
            // 
            this.txtNombreDisfraz.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNombreDisfraz.AutoSize = true;
            this.txtNombreDisfraz.BackColor = System.Drawing.Color.Transparent;
            this.txtNombreDisfraz.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreDisfraz.Location = new System.Drawing.Point(0, 253);
            this.txtNombreDisfraz.Name = "txtNombreDisfraz";
            this.txtNombreDisfraz.Size = new System.Drawing.Size(0, 31);
            this.txtNombreDisfraz.TabIndex = 3;
            this.txtNombreDisfraz.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPuntos
            // 
            this.txtPuntos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPuntos.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPuntos.Location = new System.Drawing.Point(105, 328);
            this.txtPuntos.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.txtPuntos.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.txtPuntos.Name = "txtPuntos";
            this.txtPuntos.Size = new System.Drawing.Size(88, 32);
            this.txtPuntos.TabIndex = 4;
            this.txtPuntos.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(94)))), ((int)(((byte)(9)))));
            this.label2.Location = new System.Drawing.Point(55, 292);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 33);
            this.label2.TabIndex = 5;
            this.label2.Text = "Puntuación";
            // 
            // btnCalificar
            // 
            this.btnCalificar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCalificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCalificar.FlatAppearance.BorderSize = 0;
            this.btnCalificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalificar.Font = new System.Drawing.Font("Old English Text MT", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalificar.Location = new System.Drawing.Point(311, 590);
            this.btnCalificar.Name = "btnCalificar";
            this.btnCalificar.Size = new System.Drawing.Size(154, 59);
            this.btnCalificar.TabIndex = 6;
            this.btnCalificar.Text = "Calificar";
            this.btnCalificar.UseVisualStyleBackColor = false;
            this.btnCalificar.Click += new System.EventHandler(this.btnCalificar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Old English Text MT", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(758, 590);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(154, 59);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // pcbFoto
            // 
            this.pcbFoto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pcbFoto.Location = new System.Drawing.Point(21, 61);
            this.pcbFoto.Name = "pcbFoto";
            this.pcbFoto.Size = new System.Drawing.Size(241, 187);
            this.pcbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbFoto.TabIndex = 1;
            this.pcbFoto.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtPuntos);
            this.panel1.Controls.Add(this.txtNombreDisfraz);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pcbFoto);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Location = new System.Drawing.Point(624, 180);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(288, 380);
            this.panel1.TabIndex = 8;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Image = global::ParcialHalloween.Properties.Resources.murcielagos;
            this.pictureBox5.Location = new System.Drawing.Point(221, 2);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(67, 53);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 12;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pictureBox3.Image = global::ParcialHalloween.Properties.Resources.weeb;
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(51, 49);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = global::ParcialHalloween.Properties.Resources._589f098c64b351149f22a8a7;
            this.pictureBox4.Location = new System.Drawing.Point(0, 288);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(288, 92);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 13;
            this.pictureBox4.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.lsbParticipantes);
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Controls.Add(this.btnCalificar);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1160, 677);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Showcard Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(94)))), ((int)(((byte)(9)))));
            this.label3.Location = new System.Drawing.Point(345, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(550, 122);
            this.label3.TabIndex = 14;
            this.label3.Text = "Calificación de Disfraces";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AgregarPuntuacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ParcialHalloween.Properties.Resources.fondohalloween;
            this.ClientSize = new System.Drawing.Size(1184, 701);
            this.Controls.Add(this.groupBox1);
            this.Name = "AgregarPuntuacion";
            this.Text = "AgregarPuntuacion";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.txtPuntos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFoto)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lsbParticipantes;
        private System.Windows.Forms.PictureBox pcbFoto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtNombreDisfraz;
        private System.Windows.Forms.NumericUpDown txtPuntos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCalificar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
    }
}