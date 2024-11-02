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

namespace ParcialHalloween
{
    public partial class AgregarUsuario : Form
    {
        private Db db;

        public AgregarUsuario()
        {
            InitializeComponent();
            db = new Db();
            ofdFoto.Filter = "Imágenes (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png";
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

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtUsuario.Text) ||
                string.IsNullOrWhiteSpace(txtContra.Text) || string.IsNullOrWhiteSpace(txtDisfraz.Text) ||
                string.IsNullOrWhiteSpace(txtCodigoInv.Text)) {
                MessageBox.Show("Por favor, no deje ningún campo vacío.", "Error");
                return;
            }

            if (txtCodigoInv.Text.Length != 6) {
                MessageBox.Show("El código de invitación debe tener exactamente 6 caracteres.", "Error");
                return;
            }

            string nombre = txtNombre.Text;
            string nombreDeUsuario = txtUsuario.Text;
            string contraseña = txtContra.Text;
            string disfraz = txtDisfraz.Text;
            string codigoInv = txtCodigoInv.Text.ToUpper();
            string foto = pcbFoto.ImageLocation;
            
            bool result = db.AgregarUsuario(nombre, nombreDeUsuario, contraseña, "Participante", disfraz, codigoInv, foto);
            if (result)
            {
                MessageBox.Show("Usuario agregado exitosamente.", "Éxito");
                this.Close();
            }
            else
            {
                MessageBox.Show("Error al registrar el usuario", "Error en registro");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}