using ParcialHalloween.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ParcialHalloween.Entities;

namespace ParcialHalloween.panel_admin
{
    public partial class TablaPuntos : Form
    {
        private Db db;


        public TablaPuntos()
        {
            InitializeComponent();
            db = new Db();
            CargarRanking();
        }

        private void CargarRanking()
        {
            var ranking = db.ObtenerRanking();
            if (ranking.Count == 0)
            {
                MessageBox.Show("No hay ninguna puntaje que mostrar \n Se mostrara el forms pero sin información, por favor cerrarlo", "Error");
            }
            else
            {
                var primerPuesto = ranking[0];
                var segundoPuesto = ranking[1];
                Ranking tercerPuesto = null;
                if (ranking.Count > 2)
                {
                    tercerPuesto = ranking[2];
                }

                label1.Text = primerPuesto.nombre + "\n" + primerPuesto.disfraz + "\n" + primerPuesto.puntos + " punto/s";
                pcb1.Image = Image.FromFile(primerPuesto.foto);

                label2.Text = segundoPuesto.nombre + "\n" + segundoPuesto.disfraz + "\n" + segundoPuesto.puntos + " punto/s";
                pcb2.Image = Image.FromFile(segundoPuesto.foto);

                if (ranking.Count > 2)
                {
                    label3.Text = tercerPuesto.nombre + "\n" + tercerPuesto.disfraz + "\n" + tercerPuesto.puntos + " punto/s";
                    pcb3.Image = Image.FromFile(tercerPuesto.foto);
                }
                else
                {
                    pcbTercero.Visible = false;
                }
            }
        }
    }
}