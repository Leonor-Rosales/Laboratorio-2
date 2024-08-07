using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_2
{
    internal class HabitacionDoble : Habitacion
    {
        public bool VistaMar { get; set; }
        public HabitacionDoble(int numero, double precio, bool disponible, string clienteAsignado, bool vistaMar) : base(numero, precio, disponible, clienteAsignado)
        {
            VistaMar = vistaMar;
        }
    }
}
