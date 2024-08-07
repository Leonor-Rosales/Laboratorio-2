using Laboratorio_2;
List<Habitacion> HabitacionesList = new List<Habitacion>();
List<HabitacionSimple> HabitacionSimple = new List<HabitacionSimple>();
Habitacion hotel = new Habitacion(HabitacionesList);
hotel.MenuPrincipal();
int option = int.Parse(Console.ReadLine()??"");
switch(option)
{
    case 1:
        hotel.MenuHabitaciones();
        Console.ReadKey();
        break;
    case 2:

        break;
    case 3:

        break;
    case 4:
        
        break;
    case 5:

        break;
    case 6:

        break;
    default:
        Console.WriteLine("Ingrese una opción válida");
        break;
}

