using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_2
{
    internal class Suite : Habitacion
    {
        public int NumeroHabitaciones { get; set; }
        public bool Jaccuzi { get; set; }
        public Suite(int numero, double precio, bool disponible, string clienteAsignado, string tipo, int numeroHabitaciones, bool jaccuzi) : base(numero, precio, disponible, clienteAsignado, tipo)
        {
            NumeroHabitaciones = numeroHabitaciones;
            Jaccuzi = jaccuzi;
        }
    }
    
}
