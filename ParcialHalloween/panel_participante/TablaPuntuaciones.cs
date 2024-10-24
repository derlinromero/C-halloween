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

namespace ParcialHalloween.panel_participante
{
    public partial class TablaPuntuaciones : Form
    {
        private Db db;


        public TablaPuntuaciones()
        {
            InitializeComponent();
            db = new Db();
            CargarRanking();
        }

        private void CargarRanking()
        {
            var ranking = db.ObtenerRanking();
            var primerPuesto = ranking[0];
            var segundoPuesto = ranking[1];
            Ranking tercerPuesto = null;
            if (ranking.Count > 2)
            {
                tercerPuesto = ranking[2];
            }

            label1.Text = primerPuesto.nombre + " - " + primerPuesto.disfraz;
            pcb1.Image = Image.FromFile(primerPuesto.foto);

            label2.Text = segundoPuesto.nombre + " - " + segundoPuesto.disfraz;
            pcb2.Image = Image.FromFile(segundoPuesto.foto);

            if (ranking.Count > 2)
            {
                label3.Text = tercerPuesto.nombre + " - " + tercerPuesto.disfraz;
                pcb3.Image = Image.FromFile(tercerPuesto.foto);
            }
            else
            {
                pcbTercero.Visible = false;
            }
        }
    }
}