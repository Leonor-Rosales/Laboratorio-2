﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_2
{
    internal class HabitacionDoble : Habitacion
    {
        public bool VistaMar { get; set; }
        public HabitacionDoble(int numero, double precio, bool disponible, string clienteAsignado, string tipo, bool vistaMar) : base(numero, precio, disponible, clienteAsignado, tipo)
        {
            VistaMar = vistaMar;
        }
        public override void MostrarHabitacion()
        {
            base.MostrarHabitacion();
            Console.WriteLine($"Vista al Mar: {Enmascarar(VistaMar)}");
        }
    }
}
