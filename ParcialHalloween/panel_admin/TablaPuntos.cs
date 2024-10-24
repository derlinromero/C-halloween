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
    public partial class TablaPuntos : Form
    {
        private Db db;
        
        public TablaPuntos()
        {
            InitializeComponent();
            db = new Db();
            CargarTabla();
        }

        private void CargarTabla()
        {
            var tabla = db.ObtenerTablaPuntuaciones();

            lsbPuntuaciones.Items.Clear();
            int i = 1;
            foreach (var item in tabla)
            {
                lsbPuntuaciones.Items.Add(i + " - " + item.nombre + ": " + item.puntos + " punto/s");
                i++;
            }
        }

        private void lsbPuntuaciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsbPuntuaciones.SelectedIndex != -1) {
                string usuSelec = lsbPuntuaciones.SelectedItem.ToString().Split(new[] { " - " }, StringSplitOptions.None)[1].Split(new[] { ": " }, StringSplitOptions.None)[0];
                
                var listaUsuarios = db.ObtenerUsuarios();
                Usuario usuarioSeleccionado = null;

                foreach (var usuario in listaUsuarios)
                {
                    if (usuario.nombre == usuSelec) {
                        pcbFoto.Image = Image.FromFile(usuario.foto);
                        txtNombreDisfraz.Text = "Nombre del Disfraz: " + usuario.disfraz;
                        usuarioSeleccionado = usuario;
                        break;
                    }
                }
            }
        }
    }
}