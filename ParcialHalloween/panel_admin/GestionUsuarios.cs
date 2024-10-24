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

namespace ParcialHalloween
{
    public partial class GestionUsuarios : Form
    {
        private Db db;

        public GestionUsuarios()
        {
            InitializeComponent();
            db = new Db();
            CargarParticipantes();
        }

        private void CargarParticipantes()
        {
            var participantes = db.ObtenerParticipante();
            
            lsbUsuarios.Items.Clear();
            foreach (var item in participantes)
            {
                lsbUsuarios.Items.Add(item.nombre);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarUsuario agregarUsuario = new AgregarUsuario();
            agregarUsuario.ShowDialog();
            CargarParticipantes();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (lsbUsuarios.SelectedIndex != -1)
            {
                string partiSelec = lsbUsuarios.SelectedItem.ToString();

                var listaParticipantes = db.ObtenerParticipante();

                foreach (var participante in listaParticipantes)
                {
                    if (participante.nombre == partiSelec)
                    {
                        EditarUsuario editarUsuario = new EditarUsuario(participante);
                        editarUsuario.ShowDialog();
                        CargarParticipantes();
                        break;
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione un Participante a Editar", "Error");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (lsbUsuarios.SelectedIndex != -1) {
                string usuarioSelec  = lsbUsuarios.SelectedItem.ToString();

                DialogResult resultado = MessageBox.Show("Seguro que deseas eliminar el usuario?", "Confirmar Eliminación", MessageBoxButtons.YesNo);

                if(resultado == DialogResult.Yes) {
                    var listaUsuarios = db.ObtenerUsuarios();
                    foreach (var usuario in listaUsuarios)
                    {
                        if (usuario.nombre == usuarioSelec) {
                            db.EliminarUsuario(usuario.id);
                            CargarParticipantes();
                            break;
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione un usuario a eliminar", "Error");
            }
        }
    }
}