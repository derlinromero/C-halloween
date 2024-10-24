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
    public partial class Registro : Form
    {
        private Db db;

        public Registro()
        {
            InitializeComponent();
            db = new Db();
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
            string codigoInv = txtCodigoInv.Text;
            string nombreDeUsuario = txtUsuario.Text;
            string contraseña = txtContra.Text;
            string nombre = txtNombre.Text;
            string disfraz = txtDisfraz.Text;
            string foto = pcbFoto.ImageLocation;
            
            bool result = db.AgregarUsuario(nombre, nombreDeUsuario, contraseña, "Participante", disfraz, codigoInv, foto);
            if (result)
            {
                MessageBox.Show("Registro exitoso", "Registro");
                this.Close();
            }
            else {
                MessageBox.Show("Error al registrar el usuario","Error en registro");
            }
        }
    }
}