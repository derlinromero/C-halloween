namespace ParcialHalloween
{
    partial class PanelParti
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
            this.label3 = new System.Windows.Forms.Label();
            this.btnParadas = new System.Windows.Forms.Button();
            this.btnRanking = new System.Windows.Forms.Button();
            this.btnVotar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(227, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(346, 35);
            this.label3.TabIndex = 11;
            this.label3.Text = "Panel Partipante";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnParadas
            // 
            this.btnParadas.BackColor = System.Drawing.Color.SlateGray;
            this.btnParadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnParadas.ForeColor = System.Drawing.Color.White;
            this.btnParadas.Location = new System.Drawing.Point(234, 127);
            this.btnParadas.Name = "btnParadas";
            this.btnParadas.Size = new System.Drawing.Size(339, 76);
            this.btnParadas.TabIndex = 8;
            this.btnParadas.Text = "Ver Paradas de Dulces";
            this.btnParadas.UseVisualStyleBackColor = false;
            this.btnParadas.Click += new System.EventHandler(this.btnParadas_Click);
            // 
            // btnRanking
            // 
            this.btnRanking.BackColor = System.Drawing.Color.SlateGray;
            this.btnRanking.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRanking.ForeColor = System.Drawing.Color.White;
            this.btnRanking.Location = new System.Drawing.Point(234, 314);
            this.btnRanking.Name = "btnRanking";
            this.btnRanking.Size = new System.Drawing.Size(339, 76);
            this.btnRanking.TabIndex = 12;
            this.btnRanking.Text = "Ver Raking de Puntuaciones";
            this.btnRanking.UseVisualStyleBackColor = false;
            this.btnRanking.Click += new System.EventHandler(this.btnRanking_Click);
            // 
            // btnVotar
            // 
            this.btnVotar.BackColor = System.Drawing.Color.SlateGray;
            this.btnVotar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVotar.ForeColor = System.Drawing.Color.White;
            this.btnVotar.Location = new System.Drawing.Point(234, 222);
            this.btnVotar.Name = "btnVotar";
            this.btnVotar.Size = new System.Drawing.Size(339, 76);
            this.btnVotar.TabIndex = 13;
            this.btnVotar.Text = "Calificar Disfraces";
            this.btnVotar.UseVisualStyleBackColor = false;
            this.btnVotar.Click += new System.EventHandler(this.btnVotar_Click);
            // 
            // PanelParti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVotar);
            this.Controls.Add(this.btnRanking);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnParadas);
            this.Name = "PanelParti";
            this.Text = "PanelParti";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnParadas;
        private System.Windows.Forms.Button btnRanking;
        private System.Windows.Forms.Button btnVotar;
    }
}