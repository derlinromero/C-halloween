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
        private Parada_De_Dulces parada;

        public ParadadeDulces(Parada_De_Dulces paradaSeleccionada)
        {
            InitializeComponent();
            db = new Db();
            parada = paradaSeleccionada;
            CargarInformacionParada();
        }

        private void CargarInformacionParada()
        {
            lblNombreParada.Text = parada.nombre;
            lblDulcesDisp.Text = "Tipo de dulce: " + parada.tipoDulces + "\n" + "Dulces disponibles: " + parada.cant_actual;
        }

        private void btnTomarDulce_Click(object sender, EventArgs e)
        {
            int cantidadTomada = Convert.ToInt32(txtDulcesTomar.Text);

            if (cantidadTomada <= parada.cant_actual)
            {
                parada.cant_actual -= cantidadTomada;
                db.ActualizarCantidadParadas(cantidadTomada, parada);
                MessageBox.Show("Has tomado " + cantidadTomada + " dulce/s", "Confirmación");

                lblDulcesDisp.Text = "Dulces disponibles: " + parada.cant_actual;

                if (parada.cant_actual == 0)
                {
                    MessageBox.Show(parada.nombre + " no tiene más dulces disponibles.", "Sin Dulces");
                }
            }
            else
            {
                MessageBox.Show("No hay suficientes dulces disponibles.", "Error");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}