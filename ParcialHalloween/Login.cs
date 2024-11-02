using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using ParcialHalloween.Datos;
using ParcialHalloween.Entities;

namespace ParcialHalloween
{
    public partial class Login : Form
    {
        private SoundPlayer soundPlayer;

        public Login()
        {
            InitializeComponent();
            LimpiarCampos();

            soundPlayer = new SoundPlayer(Properties.Resources.Thriller_Instrumental);
        }
        
        private void Login_Load(object sender, EventArgs e)
        {
            LimpiarCampos();

            soundPlayer.PlayLooping();
        }

        private void btnIniSesion_Click(object sender, EventArgs e)
        {
            string nombreDeUsuario = txtUsuario.Text;
            string contraseña = txtContra.Text;

            if (string.IsNullOrEmpty(nombreDeUsuario) || string.IsNullOrEmpty(contraseña)) {
                MessageBox.Show("Por favor, complete todos los campos.", "Error");
                return;
            }

            var db = new Db();
            var usuarios = db.ObtenerUsuarios();

            Usuario usuarioEncontrado = null;

            foreach (var usuario in usuarios)
            {
                if (usuario.nombreDeUsuario == nombreDeUsuario) {
                    usuarioEncontrado = usuario;
                    break;
                }
            }

            if (usuarioEncontrado == null) {
                MessageBox.Show("Usuario no encontrado.", "Error");
                return;
            }

            if (usuarioEncontrado.contraseña != contraseña) {
                MessageBox.Show("Contraseña incorrecta.", "Error");
                return;
            }

            MessageBox.Show("Inicio de sesión exitoso", "Inicio de sesión");

            this.Hide();

            if (usuarioEncontrado.rol == "Administrador") {
                PanelAdmin panelAdmin = new PanelAdmin();
                panelAdmin.FormClosed += PanelAdmin_FormClosed;
                panelAdmin.ShowDialog();
            }

            if (usuarioEncontrado.rol == "Participante") {
                PanelParti panelParti = new PanelParti(usuarioEncontrado.id);
                panelParti.FormClosed += PanelParti_FormClosed;
                panelParti.ShowDialog();
            }
        }

        private void PanelAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
            LimpiarCampos();
        }

        private void PanelParti_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
            LimpiarCampos();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            var registro = new Registro();
            registro.ShowDialog();
        }

        private void LimpiarCampos() {
            txtUsuario.Text = string.Empty;
            txtContra.Text = string.Empty;
        }
    }
}