using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ParcialHalloween.Datos;
using ParcialHalloween.Entities;

namespace ParcialHalloween.panel_participante
{
    public partial class AgregarPuntuacion : Form
    {
        private Db db;
        private int id;
        
        public AgregarPuntuacion(int id)
        {
            InitializeComponent();
            db = new Db();
            CargarParticipantes();
            this.id = id;
            ;
        }

        private void CargarParticipantes()
        {
            var participantes = db.ObtenerVotantes(id);

            lsbParticipantes.Items.Clear();
            foreach (var item in participantes)
            {
                lsbParticipantes.Items.Add(item.nombre);
            }
        }

        private void lsbParticipantes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsbParticipantes.SelectedIndex != -1) {
                string partiSelec = lsbParticipantes.SelectedItem.ToString();

                var listaParticipantes = db.ObtenerParticipante();
                Participante participanteSeleccionado = null;

                foreach (var participante in listaParticipantes)
                {
                    if (participante.nombre == partiSelec) {
                        pcbFoto.Image = Image.FromFile(participante.foto);
                        txtNombreDisfraz.Text = "Nombre del Disfraz: " + participante.disfraz;
                        participanteSeleccionado = participante;
                        break;
                    }
                }
            }
        }

        private void btnCalificar_Click(object sender, EventArgs e)
        {
            if (lsbParticipantes.SelectedIndex != -1) {
                string partiSelec = lsbParticipantes.SelectedItem.ToString();

                var listaParticipantes = db.ObtenerParticipante();
                Participante participanteSeleccionado = null;

                foreach (var participante in listaParticipantes) {

                }
            }
        }
    }
}