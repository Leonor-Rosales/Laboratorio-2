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
                break;
            case 3:
                hotel.MostrarHabitacion(HabitacionesList);
                break;
            case 4:
                hotel.AsignarHabitacion(HabitacionesList);
                break;
            case 5:
                hotel.LiberarHabitacion(HabitacionesList);
                break;
            case 6:

                break;
            default:
                Console.WriteLine("Ingrese una opción válida");
                break;
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine("[!] Error: " + ex.Message);
    }

} while (run);
