using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_2
{
    internal class HabitacionSimple : Habitacion
    {
        public int NumeroCamas { get; set; }

        public HabitacionSimple(int numero, double precio, bool disponible, string clienteAsignado, int numeroCamas): base(numero, precio, disponible, clienteAsignado)
        {
            NumeroCamas = numeroCamas;
        }
    }

}
