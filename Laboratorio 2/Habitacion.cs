using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_2
{
    internal class Habitacion 
    {
        public int Numero { get; set; }
        public double Precio { get; set; }
        public bool Disponible { get; set; }
        public string ClienteAsignado { get; set; }

        public Habitacion(int numero, double precio, bool disponible, string clienteAsignado)
        {
            Numero = numero;
            Precio = precio;
            Disponible = disponible;
            ClienteAsignado = clienteAsignado;
        }

        public Habitacion(List<Habitacion> habitacionesList)
        {
        }

        public void MenuPrincipal()
        {
            Console.WriteLine("--- Hotel Rosas ---");
            Console.WriteLine("1. Agregar Habitación");
            Console.WriteLine("2. Eliminar Habitación");
            Console.WriteLine("3. Mostrar Habitación");
            Console.WriteLine("4. Asignar Habitación");
            Console.WriteLine("5. Liberar Habitación");
            Console.WriteLine("5. Salir");
            Console.Write("Ingrese una opción:");
        }
        public void MenuHabitaciones()
        {
            Console.WriteLine("--- Hotel Rosas ---");
            Console.WriteLine("1. Habitación Simple");
            Console.WriteLine("2. Habitación Doble");
            Console.WriteLine("3. Suite");
            Console.WriteLine("4. Habitación Deluxe");
            Console.Write("Ingrese una opción:");
        }
    }
}
