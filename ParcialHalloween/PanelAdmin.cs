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
    public partial class PanelAdmin : Form
    {
        public PanelAdmin()
        {
            InitializeComponent();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            GestionUsuarios gestionUsuarios = new GestionUsuarios();
            gestionUsuarios.ShowDialog();
        }

        private void btnParadas_Click(object sender, EventArgs e)
        {
            GestionParadas gestionParadas = new GestionParadas();
            gestionParadas.ShowDialog();
        }

        private void btnPuntuaciones_Click(object sender, EventArgs e)
        {
            TablaPuntos tablaPuntos = new TablaPuntos();
            tablaPuntos.ShowDialog();
        }
    }
}