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
using ParcialHalloween.panel_admin.gestion_paradas;

namespace ParcialHalloween
{
    public partial class GestionParadas : Form
    {
        private Db db;

        public GestionParadas()
        {
            InitializeComponent();
            db = new Db();
            CargarParadas();
        }

        private void CargarParadas()
        {
            var paradas = db.ObtenerParadas();

            lsbParadas.Items.Clear();
            foreach (var item in paradas)
            {
                lsbParadas.Items.Add(item.nombre);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarParadas agregarParadas = new AgregarParadas();
            agregarParadas.ShowDialog();
            CargarParadas();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (lsbParadas.SelectedIndex != -1) {
                string paradaSelec = lsbParadas.SelectedItem.ToString();

                var listaParadas = db.ObtenerParadas();

                foreach (var parada in listaParadas)
                {
                    if (parada.nombre == paradaSelec)
                    {
                        EditarParadas editarParadas = new EditarParadas(parada);
                        editarParadas.ShowDialog();
                        CargarParadas();
                        break;
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione una Parada a Editar", "Error");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (lsbParadas.SelectedIndex != -1)
            {
                string paradaSelec = lsbParadas.SelectedItem.ToString();

                DialogResult resultado = MessageBox.Show("Seguro que deseas eliminar la parada?", "Confirmar Eliminación", MessageBoxButtons.YesNo);

                if (resultado == DialogResult.Yes)
                {
                    var listaParadas = db.ObtenerParadas();
                    foreach (var parada in listaParadas)
                    {
                        if (parada.nombre == paradaSelec)
                        {
                            db.EliminarParada(parada.id);
                            CargarParadas();
                            MessageBox.Show("Se ha eliminado la parada exitosamente!!","Éxito");
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