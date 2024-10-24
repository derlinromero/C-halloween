using ParcialHalloween.Datos;
using ParcialHalloween.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParcialHalloween.panel_participante
{
    public partial class ParadadeDulces : Form
    {
        private Db db;
        
        public ParadadeDulces()
        {
            InitializeComponent();
            db = new Db();
            CargarParadas();
        }

        private void CargarParadas()
        {
            var paradas = db.ObtenerDisponibleParadas();

            cmbParadas.Items.Clear();
            foreach (var item in paradas)
            {
                cmbParadas.Items.Add(item.nombre);
            }
        }

        private void cmbParadas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbParadas.SelectedIndex != -1)
            {
                string paradaSelec = cmbParadas.SelectedItem.ToString();

                var listaParadas = db.ObtenerDisponibleParadas();
                Parada_De_Dulces paradaDeDulces = null;

                foreach (var parada in listaParadas)
                {
                    if (parada.nombre == paradaSelec)
                    {
                        pcbFoto.Image = Image.FromFile(parada.foto);
                        txtDulcesDisp.Text = parada.cant_actual + " Dulce/s disponible/s";
                        txtDulcesTomar.Maximum = parada.cant_actual;
                        paradaDeDulces = parada;
                        break;
                    }
                }
            }
        }

        private void btnTomarDulce_Click(object sender, EventArgs e)
        {
            if (cmbParadas.SelectedIndex != -1) {
                string paradaSelec = cmbParadas.SelectedItem.ToString();

                var listaParadas = db.ObtenerDisponibleParadas();
                Parada_De_Dulces paradaDeDulces = null;

                DialogResult resultado = MessageBox.Show("Seguro que deseas esa cantidad de dulces?", "Confirmar Eliminación", MessageBoxButtons.YesNo);

                if (resultado == DialogResult.Yes) {
                    foreach (var parada in listaParadas)
                    {
                        if (parada.nombre == paradaSelec)
                        {
                            paradaDeDulces = parada;
                            int cantidad = Convert.ToInt32(txtDulcesTomar.Text);
                            ;
                            db.ActualizarCantidadParadas(cantidad, paradaDeDulces);
                            MessageBox.Show("Se tomaron " + cantidad + " dulce/s", "Confirmación");
                            this.Close();
                            break;
                        }
                    }
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}