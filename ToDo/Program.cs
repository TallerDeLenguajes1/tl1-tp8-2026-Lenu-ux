using TareaApp;

//creo las listas de tareas realizadas y pendientes
List<Tarea> tareasPendientes= new List<Tarea> ();
List<Tarea> tareasRealizadas= new List<Tarea> ();
//2.cargo n tareas aleatorias

//arreglo de diferentes tareas
string[] descripcionAleatoria =
{
    "Entregar pedido a sucursal Zona Norte",
    "Controlar stock de mercadería en depósito",
    "Cargar camión de distribución interna",
    "Revisar facturas pendientes de cobro",
    "Organizar devoluciones de clientes",
    "Limpieza y orden de góndolas principales"
};
//duraciones aleatoria
int []duracionAleatoria={15,30,45,60,90,100};

System.Console.WriteLine("Ingrese la cantidad de tareas a crear: ");
if (int.TryParse(Console.ReadLine(),out int cantTareas))
{
    for (int i = 0; i < cantTareas; i++)
    {
        int id=i+1;
        int indiceDescripcion=i%descripcionAleatoria.Length;
        int indiceDuracion= i% duracionAleatoria.Length;

        string descripcionSeleccionada=descripcionAleatoria[indiceDescripcion];
        int duracionSeleccionada= duracionAleatoria[indiceDuracion];

        Tarea nuevaTarea= new Tarea(id,descripcionSeleccionada,duracionSeleccionada);
        tareasPendientes.Add(nuevaTarea);
    }

    //mostramos
    Console.WriteLine($"\n--{tareasPendientes.Count} Tareas Cargadas----");
    foreach (Tarea t in tareasPendientes)
    {
        Console.WriteLine($"ID: {t.TareaID} | Descripcion: {t.Descripcion} | Duracion: {t.Duracion} min");
    }

}

//3
