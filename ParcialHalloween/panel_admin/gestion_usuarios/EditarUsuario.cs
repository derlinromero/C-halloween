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

namespace ParcialHalloween
{
    public partial class EditarUsuario : Form
    {
        private Db db;
        private Participante participanteSelec;
        
        public EditarUsuario(Participante participante)
        {
            InitializeComponent();
            db = new Db();
            participanteSelec = participante;

            txtNombre.Text = participanteSelec.nombre;
            txtUsuario.Text = participanteSelec.nombreDeUsuario;
            txtDisfraz.Text = participanteSelec.disfraz;
            txtContra.Text = participanteSelec.contraseña;
            pcbFoto.Image = Image.FromFile(participanteSelec.foto);
        }

        private void btnImagen_Click(object sender, EventArgs e)
        {
            var ok = ofdFoto.ShowDialog();
            if (ok == DialogResult.OK)
            {
                pcbFoto.ImageLocation = ofdFoto.FileName;

                pcbFoto.Image = Image.FromFile(ofdFoto.FileName);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nuevoNombre = txtNombre.Text;
            string nuevoNombreDeUsuario = txtUsuario.Text;
            string nuevaContraseña = txtContra.Text;
            string nuevoDisfraz = txtDisfraz.Text;
            string nuevaFoto = ofdFoto.FileName;

            if (string.IsNullOrEmpty(nuevoNombre)) {
                MessageBox.Show("Debe ingresar un nombre para el participante.");
                return;
            }

            if (string.IsNullOrEmpty(nuevaFoto)) {
                nuevaFoto = participanteSelec.foto;
            }

            try {
                participanteSelec.nombre = nuevoNombre;
                participanteSelec.nombreDeUsuario = nuevoNombreDeUsuario;
                participanteSelec.contraseña = nuevaContraseña;
                participanteSelec.disfraz = nuevoDisfraz;
                participanteSelec.foto = nuevaFoto;

                db.ActualizarParticipante(participanteSelec);

                MessageBox.Show("Participante editado con éxito.", "Éxito");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar los cambios", "Error");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}