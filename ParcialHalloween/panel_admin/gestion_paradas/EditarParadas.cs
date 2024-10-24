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

namespace ParcialHalloween.panel_admin.gestion_paradas
{
    public partial class EditarParadas : Form
    {
        private Db db;
        private Parada_De_Dulces paradasSelec;
        
        public EditarParadas(Parada_De_Dulces paradas)
        {
            InitializeComponent();
            db = new Db();
            paradasSelec = paradas;

            txtNombre.Text = paradasSelec.nombre;
            txtCantidadIni.Value = paradasSelec.cant_inicial;
            txtTipoDulces.Text = paradasSelec.tipoDulces;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nuevoNombre = txtNombre.Text;
            int nuevaCantidad = Convert.ToInt32(txtCantidadIni.Text);
            string nuevoTipo = txtTipoDulces.Text;

            if (string.IsNullOrEmpty(nuevoNombre)) {
                MessageBox.Show("Debe ingresar un nombre para la parada.");
                return;
            }

            try {
                paradasSelec.nombre = nuevoNombre;
                paradasSelec.cant_inicial = nuevaCantidad;
                paradasSelec.cant_actual = nuevaCantidad;
                paradasSelec.tipoDulces = nuevoTipo;
                
                db.ActualizarParada(paradasSelec);

                MessageBox.Show("Parada editada con éxito.", "Éxito");
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