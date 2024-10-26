using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using ParcialHalloween.Datos;
using ParcialHalloween.Entities;

namespace ParcialHalloween.panel_participante
{
    public partial class ParadasVista : Form
    {
        private Db db;
        private Image imagenColor;
        private Image imagenBlancoNegro;
        private Random random;
        private List<Rectangle> posicionesOcupadas;
        public ParadasVista()
        {
            InitializeComponent();
            db = new Db();
            random = new Random();
            posicionesOcupadas = new List<Rectangle>();

            imagenColor = Properties.Resources.Casa;
            imagenBlancoNegro = Properties.Resources.Casa_black_white;

            CargarParadas();
        }

        private void CargarParadas()
        {
            var paradas = db.ObtenerParadas();
            int anchoPB = 175;
            int altoPB = 175;

            foreach (var parada in paradas)
            {
                PictureBox pb = new PictureBox
                {
                    Width = anchoPB,
                    Height = altoPB,
                    Tag = parada,
                    Anchor = AnchorStyles.None,
                    SizeMode = PictureBoxSizeMode.StretchImage
                };

                if (parada.cant_actual > 0)
                {
                    pb.Image = imagenColor;
                }
                else
                {
                    pb.Image = imagenBlancoNegro;
                }

                int[] posicion = GenerarPosicionAleatoria(anchoPB, altoPB);
                pb.Location = new Point(posicion[0], posicion[1]);

                pb.Click += Pb_Click;
                groupBox1.Controls.Add(pb);
            }
        }

        private int[] GenerarPosicionAleatoria(int anchoPB, int altoPB)
        {
            int x, y;
            int margenSeparacion = 20;
            Rectangle areaPB;

            do
            {
                x = random.Next(10, groupBox1.ClientSize.Width - anchoPB - 10);
                y = random.Next(10, groupBox1.ClientSize.Height - altoPB - 10);
                areaPB = new Rectangle(x, y, anchoPB, altoPB);
            }
            while (posicionesOcupadas.Any(r => r.IntersectsWith(new Rectangle(areaPB.X - margenSeparacion, areaPB.Y - margenSeparacion, areaPB.Width + 2 * margenSeparacion, areaPB.Height + 2 * margenSeparacion))));

            posicionesOcupadas.Add(areaPB);

            return new int[] { x, y };
        }

        private void Pb_Click(object sender, EventArgs e)
        {
            var pb = sender as PictureBox;
            var parada = pb.Tag as Parada_De_Dulces;

            if (parada.cant_actual > 0)
            {
                ParadadeDulces tomarDulcesForm = new ParadadeDulces(parada);
                tomarDulcesForm.ShowDialog();
                ActualizarImagen(pb, parada);
            }
            else
            {
                pb.Image = imagenBlancoNegro;
                MessageBox.Show(parada.nombre +  " no tiene más dulces disponibles.", "Sin Dulces");
            }
        }

        private void ActualizarImagen(PictureBox pb, Parada_De_Dulces parada)
        {
            parada.cant_actual = db.ObtenerCantidadDulces(parada.id);
            pb.Image = parada.cant_actual > 0 ? imagenColor : imagenBlancoNegro;
        }
    }
}