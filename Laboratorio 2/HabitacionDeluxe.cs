using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_2
{
    internal class HabitacionDeluxe : Habitacion
    {
        public string Servicios { get; set; }
        public HabitacionDeluxe(int numero, double precio, bool disponible, string clienteAsignado, string tipo, string servicios) : base(numero, precio, disponible, clienteAsignado, tipo)
        {
            Servicios = servicios;
        }
    }
}
