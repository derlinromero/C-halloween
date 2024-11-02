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
            this.id = id;
            db = new Db();
            CargarParticipantes();
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
                        txtNombreDisfraz.Text = participante.disfraz;
                        participanteSeleccionado = participante;
                        break;
                    }
                }
            }
        }

        private void btnCalificar_Click(object sender, EventArgs e)
        {
            if (lsbParticipantes.SelectedIndex == -1) {
                MessageBox.Show("Seleccione un participante.", "Advertencia");
                return;
            }

            int puntos = Convert.ToInt32(txtPuntos.Value);
            if (puntos < 1 || puntos > 10) {
                MessageBox.Show("La puntuación debe estar entre 1 y 10.", "Error");
                return;
            }
            
            if (lsbParticipantes.SelectedIndex != -1)
            {
                string partiSelec = lsbParticipantes.SelectedItem.ToString();

                var listaParticipantes = db.ObtenerParticipante();
                Participante participanteSeleccionado = null;

                foreach (var participante in listaParticipantes)
                {
                    if (participante.nombre == partiSelec)
                    {
                        participanteSeleccionado = participante;
                        break;
                    }
                }

                bool resultado = db.AgregarPuntuacion(participanteSeleccionado.id, id, puntos);

                if (resultado)
                {
                    MessageBox.Show("Puntuación guardada con éxito.", "Éxito");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al guardar la puntuación.", "Error");
                }
            }
            else {
                MessageBox.Show("Por favor, selecciona un participante.", "Advertencia");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}