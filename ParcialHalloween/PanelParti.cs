using ParcialHalloween.panel_participante;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParcialHalloween
{
    public partial class PanelParti : Form
    {
        private int id;
        
        public PanelParti(int id)
        {
            InitializeComponent();
            this.id = id;
            ;
        }

        private void btnParadas_Click(object sender, EventArgs e)
        {
            ParadadeDulces paradadeDulces = new ParadadeDulces();
            paradadeDulces.Show();
        }

        private void btnRanking_Click(object sender, EventArgs e)
        {
            TablaPuntuaciones tablaPuntuaciones = new TablaPuntuaciones();
            tablaPuntuaciones.Show();
        }

        private void btnVotar_Click(object sender, EventArgs e)
        {
            AgregarPuntuacion agregarPuntuacion = new AgregarPuntuacion(id);
            agregarPuntuacion.Show();
        }
    }
}