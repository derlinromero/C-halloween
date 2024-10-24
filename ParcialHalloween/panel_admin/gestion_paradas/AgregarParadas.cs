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

namespace ParcialHalloween.panel_admin.gestion_paradas
{
    public partial class AgregarParadas : Form
    {
        private Db db;
        
        public AgregarParadas()
        {
            InitializeComponent();
            db = new Db();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtCantidadIni.Text) ||
                string.IsNullOrWhiteSpace(txtTipoDulces.Text))
            {
                MessageBox.Show("Por favor, no deje ningún campo vacío.", "Error");
                return;
            }

            string nombre = txtNombre.Text;
            int cantidadIni = Convert.ToInt32(txtCantidadIni.Value);
            string tipoDulces = txtTipoDulces.Text;

            bool result = db.AgregarParada(nombre,cantidadIni, tipoDulces);
            if (result) {
                MessageBox.Show("Parada agregado exitosamente.", "Éxito");
                this.Close();
            }
            else
            {
                MessageBox.Show("Error al registrar la parada", "Error en registro");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}