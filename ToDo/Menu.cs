namespace TareaApp;

public class Menu
{
    public void Ejecutar(List<Tarea> pendientes, List<Tarea> realizadas)
    {
        bool salir =false;
        while (!salir)
        {
            Console.WriteLine("----Menu----\n");
            Console.WriteLine("1. Mostrar tareas pendientes");
            Console.WriteLine("2. Mostrar tareas realizadas");
            Console.WriteLine("3. Buscar tareas por descripcion");
            Console.WriteLine("4. Marcar tarea como realizada");
            Console.WriteLine("5. Mostrar todas las tareas");
            Console.WriteLine("6.Salir");
            Console.WriteLine("Seleccione la opcion: ");
            if (int.TryParse(Console.ReadLine(),out int opcion))
            {
                switch (opcion)
                {
                    case 1:
                        MostrarTareas(pendientes);
                    break;
                    case 2:
                        MostrarTareas(realizadas);
                    break;
                    case 3:
                        BuscarTarea(pendientes);
                    break;
                    case 4:
                        MoverTarea(pendientes,realizadas);
                    break;
                    case 5:
                        MostrarTodas(pendientes, realizadas);
                    break;
                    case 6:
                        salir=true;
                    break;
                    default:
                        Console.WriteLine("Opcion invalida");
                    break;
                }
            }
        }
    }
    public void MostrarTareas(List<Tarea> lista)
    {
        foreach (Tarea t in lista)
        {
            Console.WriteLine($"ID:{t.TareaID} | Descripcion: {t.Descripcion}| Duracion: {t.Duracion}min");
        }
    }

    public void BuscarTarea(List<Tarea> pendientes)
    {
        Console.WriteLine("Ingrese el texto a buscar: ");
        string texto=Console.ReadLine();
        foreach (Tarea t in pendientes)
        {
            if (t.Descripcion.Contains(texto,StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"ID:{t.TareaID} | Descripcion: {t.Descripcion}| Duracion: {t.Duracion}min");
            }
        }
    }

    public void MoverTarea(List<Tarea> pendientes, List<Tarea> realizadas)
    {
        Console.WriteLine("Ingrese el ID de la tarea realizada: ");
        if (int.TryParse(Console.ReadLine(),out int idEncontrado))
        {
            Tarea tareaEncontrada=null;
            foreach (Tarea t in pendientes)
            {
                if (t.TareaID == idEncontrado)
                {
                    tareaEncontrada=t;
                    break;
                }
            }
            if (tareaEncontrada != null)
            {
                pendientes.Remove(tareaEncontrada);
                realizadas.Add(tareaEncontrada);
                Console.WriteLine("Tarea movida correctamente");
            }else
            {
                Console.WriteLine("No existe la tarea");
            }
        }
    }

    public void MostrarTodas(List<Tarea> pendientes, List <Tarea> realizadas)
    {
        Console.WriteLine("---Tareas Pendientes----");
        MostrarTareas(pendientes);

        Console.WriteLine("---Tareas Realizadas---");
        MostrarTareas(realizadas);
    }
}