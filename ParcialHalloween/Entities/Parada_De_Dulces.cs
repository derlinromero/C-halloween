using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcialHalloween.Entities
{
    public class Parada_De_Dulces {
        public int id {  get; set; }
        public string nombre { get; set; }
        public int cant_inicial { get; set; }
        public int cant_actual { get; set; }
        public string tipoDulces { get; set; }
    }
}