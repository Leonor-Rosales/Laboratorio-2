using Laboratorio_2;
List<Habitacion> HabitacionesList = new List<Habitacion>();
Habitacion hotel = new Habitacion(HabitacionesList);
bool run = true;
do
{
    try
    {
        hotel.MenuPrincipal();
        int option = int.Parse(Console.ReadLine() ?? "");
        switch (option)
        {
            case 1:
                hotel.AgregarDatos(HabitacionesList);
                break;
            case 2:
                hotel.EliminarHabitacion(HabitacionesList);
                Console.ReadKey();
                break;
            case 3:
                hotel.MostrarTodasHabitaciones(HabitacionesList);
                Console.ReadKey();
                break;
            case 4:
                hotel.AsignarHabitacion(HabitacionesList);
                Console.ReadKey();
                break;
            case 5:
                hotel.LiberarHabitacion(HabitacionesList);
                Console.ReadKey();
                break;
            case 6:
                Console.Clear();
                Console.WriteLine("Saliendo...");
                Console.ReadKey();
                run = false;
                break;
            default:
                Console.WriteLine("Ingrese una opción válida");
                Console.ReadKey();
                break;
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine("[!] Error: " + ex.Message);
    }

} while (run);
