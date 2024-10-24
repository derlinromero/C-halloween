using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcialHalloween.Entities
{
    public class Administrador
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string nombreDeUsuario { get; set; }
        public string contraseña { get; set; }
        public string rol { get; set; }
    }
}