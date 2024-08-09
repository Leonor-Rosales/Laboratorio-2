using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Numerics;
using System.Runtime.ExceptionServices;
using System.Security.Cryptography.X509Certificates;
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
        public string Tipo { get; set; }

        public Habitacion(int numero, double precio, bool disponible, string clienteAsignado, string tipo)
        {
            Numero = numero;
            Precio = precio;
            Disponible = disponible;
            ClienteAsignado = clienteAsignado;
            Tipo = tipo;
        }

        public Habitacion(List<Habitacion> habitacionesList)
        {
        }

        public void MenuPrincipal()
        {
            Console.Clear();
            Console.WriteLine("--- Hotel Bambinas ---");
            Console.WriteLine("1. Agregar Habitación");
            Console.WriteLine("2. Eliminar Habitación");
            Console.WriteLine("3. Mostrar Habitación");
            Console.WriteLine("4. Asignar Habitación");
            Console.WriteLine("5. Liberar Habitación");
            Console.WriteLine("6. Salir");
            Console.Write("Ingrese una opción: ");
        }
        public void MenuHabitaciones()
        {
            Console.WriteLine("--- Tipos de Habitación ---");
            Console.WriteLine("1. Habitación Simple");
            Console.WriteLine("2. Habitación Doble");
            Console.WriteLine("3. Suite");
            Console.WriteLine("4. Habitación Deluxe");
            Console.Write("Ingrese una opción: ");
        }
        public void AgregarDatos(List<Habitacion> habitacionesList)       
        {
            try
            {
                Console.Clear();
                Console.Write("Número de habitación: ");
                int numeroHabitacion = int.Parse(Console.ReadLine());
                Console.Write("Precio de habitación: ");
                double precioHabitación = int.Parse(Console.ReadLine());
                Console.Write("Disponibilidad: ");
                bool disponibilidadHabitacion = Convert.ToBoolean(Console.ReadLine());
                string clienteAsignadoHabitacion = "";
                if (disponibilidadHabitacion == true)
                {
                    clienteAsignadoHabitacion = "";
                }
                else if (disponibilidadHabitacion == false)
                {
                    Console.Write("Cliente Asignado: ");
                    clienteAsignadoHabitacion = Console.ReadLine();
                }
                if ((precioHabitación > 0) & (numeroHabitacion >= 0)) 
                {
                    MenuHabitaciones();
                    int option = int.Parse(Console.ReadLine());
                    string tipoHabitacion = "";
                    switch (option)
                    {
                        case 1:
                            tipoHabitacion = "Simple";
                            Console.Write("Número de camas: ");
                            int camasHabitacion = int.Parse(Console.ReadLine());
                            habitacionesList.Add(new HabitacionSimple(numeroHabitacion, precioHabitación, disponibilidadHabitacion, clienteAsignadoHabitacion, tipoHabitacion, camasHabitacion));
                            Console.WriteLine("\nHabitación Añadida con Éxito");
                            Console.ReadKey();
                            break;
                        case 2:
                            tipoHabitacion = "Doble";
                            Console.Write("Vista al mar: ");
                            bool vistaMar = Convert.ToBoolean(Console.ReadLine());
                            habitacionesList.Add(new HabitacionDoble(numeroHabitacion, precioHabitación, disponibilidadHabitacion, clienteAsignadoHabitacion, tipoHabitacion, vistaMar));
                            Console.WriteLine("\nHabitación Añadida con Éxito");
                            Console.ReadKey();
                            break;
                        case 3:
                            tipoHabitacion = "Suite";
                            Console.Write("Número de habitaciones: ");
                            int numeroHabitaciones = int.Parse(Console.ReadLine());
                            Console.Write("Jacuzzi: ");
                            bool jaccuzi = Convert.ToBoolean(Console.ReadLine());
                            habitacionesList.Add(new Suite(numeroHabitacion, precioHabitación, disponibilidadHabitacion, clienteAsignadoHabitacion, tipoHabitacion, numeroHabitaciones, jaccuzi));
                            Console.WriteLine("\nHabitación Añadida con Éxito");
                            Console.ReadKey();
                            break;
                        case 4:
                            tipoHabitacion = "Deluxe";
                            Console.Write("Servicios: ");
                            string servicios = Console.ReadLine();
                            habitacionesList.Add(new HabitacionDeluxe(numeroHabitacion, precioHabitación, disponibilidadHabitacion, clienteAsignadoHabitacion, tipoHabitacion, servicios));
                            Console.WriteLine("\nHabitación Añadida con Éxito");
                            Console.ReadKey();
                            break;
                        default:
                            Console.WriteLine("Ingrese una opción válida");
                            Console.ReadKey();
                            break;
                    }                   
                }
                else
                {
                    Console.WriteLine("[!] Ingrese datos válidos");
                    Console.ReadKey();
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine("Error:" + ex.Message);
            }
        }
        public void EliminarHabitacion(List<Habitacion> habitacionesList)
        {
            if (habitacionesList.Count == 0)
            {
                Console.WriteLine("No hay Datos Añadidos");

            }
            else
            {
                Console.Write("Número de habitación: ");
                int numeroHabitacion = int.Parse(Console.ReadLine());
                Habitacion habitacionFind = habitacionesList.Find(p => p.Numero == numeroHabitacion);
                if (habitacionFind != null)
                {
                    habitacionesList.Remove(habitacionFind);
                    Console.WriteLine("Habitación Eliminada Con Éxito");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("\n[!] Habitación Inexistente");
                    Console.ReadKey();
                }
            }
        }
        public virtual void MostrarHabitacion(List<Habitacion> habitacionesList)
        {
            if (habitacionesList.Count == 0)
            {
                Console.WriteLine("No hay Datos Añadidos");

            }
            else
            {
               foreach(var habitacion in habitacionesList)
                    {
                    Console.WriteLine($"Número de habitación: ¨{habitacion.Numero}\nPrecio: {habitacion.Precio}\nDisponibilidad: {habitacion.Disponible}\nCliente Asignado: {habitacion.ClienteAsignado}\nTipo: {habitacion.Tipo}");

                }
            }
        }
        public void AsignarHabitacion(List<Habitacion> habitacionList)
        {
            Console.Write("Número de habitación: ");
            int habitacionNumero = int.Parse(Console.ReadLine());
            Habitacion habitacionFind = habitacionList.Find(p => p.Numero == habitacionNumero);
            if (habitacionNumero != null)
            {
                Console.Write("\nCliente Asignado: ");
                string clienteAsignado = Console.ReadLine();
                habitacionFind.ClienteAsignado = clienteAsignado;
                habitacionFind.Disponible = false;
                Console.WriteLine("\n[!] Cliente Agregado");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("\n[!] Habitación Inexistente");
                Console.ReadKey();
            }
        }
        public void LiberarHabitacion(List<Habitacion> habitacionList)
        {
            Console.Write("Número de habitación: ");
            int habitacionNumero = int.Parse(Console.ReadLine());
            Habitacion habitacionFind = habitacionList.Find(p => p.Numero == habitacionNumero);
            if (habitacionNumero != null)
            {
                
                habitacionFind.ClienteAsignado = "";
                habitacionFind.Disponible = true;
                Console.WriteLine("\n[!] Habitación Liberada");
            }
            else
            {
                Console.WriteLine("\n[!] Habitación Inexistente");
                Console.ReadKey();
            }
        }
        public bool Disponibilidad()
        {
            Console.Write("Disponibilidad: ");
            string disponibilidadString = Console.ReadLine().ToLower();
                bool disponibilidadHabitacion = Convert.ToBoolean(Console.ReadLine());
            return disponibilidadHabitacion;
    }
    }
}
