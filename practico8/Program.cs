using ListaDeTareas;

List<Tareas> TareasPendientes = new List<Tareas>();
List<Tareas> TareasRealizadas = new List<Tareas>();
string? descripcion;
string? respuestaAMoverTarea;

//GENERAR TAREAS ALEATORIAS
for (int i = 0; i < 4; i++)
{
    Tareas Tarea = new Tareas();
    var numeroRandom = new Random();
    Console.WriteLine($"Ingrese la descripción de la tarea {i + 1}: ");
    descripcion = Console.ReadLine();
    Tarea.Descripcion = descripcion;
    Tarea.TareaID = i + 1;
    Tarea.Duracion = numeroRandom.Next(10, 100);
    TareasPendientes.Add(Tarea);

}

Console.WriteLine("\n------------------------\nLISTA DE TAREAS PENDIENTES");
MostrarListaDeTareas(TareasPendientes);

ConsultarTarea(TareasPendientes, TareasRealizadas);
EliminarTareasMovidas(TareasPendientes, TareasRealizadas);

Console.WriteLine("\n------------------------\nLISTA DE TAREAS PENDIENTES");
MostrarListaDeTareas(TareasPendientes);
Console.WriteLine("\n------------------------\nLISTA DE TAREAS REALIZADAS");
MostrarListaDeTareas(TareasRealizadas);

BuscarTareaPendientePorDescripcion(TareasPendientes);

void MostrarListaDeTareas(List<Tareas> ListaDeTareas){
    foreach (var tarea in ListaDeTareas)
{
    Console.WriteLine($"Tarea {tarea.TareaID}\nDescripción: {tarea.Descripcion}\nDuración: {tarea.Duracion}\n");
}
}
void ConsultarTarea(List<Tareas> TareasPendientes, List<Tareas> TareasRealizadas){
    foreach (var tarea in TareasPendientes)
{
    Console.WriteLine($"¿Desea mover la tarea {tarea.TareaID} a Tareas Realizadas?");
    MoverTareas(tarea, TareasRealizadas);
}
}
void MoverTareas(Tareas TareaConsultada, List<Tareas> TareasRealizadas)
{
    respuestaAMoverTarea = Console.ReadLine();
    switch (respuestaAMoverTarea)
    {
        case "s":
            TareasRealizadas.Add(TareaConsultada);
            break;
        case "n":
            break;
        default:
            break;
    }
}
void EliminarTareasMovidas(List<Tareas> TareasPendientes, List<Tareas> TareasRealizadas){
    foreach (var tarea in TareasRealizadas)
    {
        if (TareasPendientes.Contains(tarea))
        {
            TareasPendientes.Remove(tarea);
        }
    }
}
void BuscarTareaPendientePorDescripcion(List<Tareas> TareasPendientes){
    string? descripcion;
    Console.WriteLine("\n\n-----------------------\nBUSCAR TAREA\nIngrese la descripción de la tarea que busca: ");
    descripcion = Console.ReadLine();
    foreach (var tarea in TareasPendientes)
    {
        if (tarea.Descripcion == descripcion)
        {
            Console.WriteLine($"------------------\nTAREA ENCONTRADA\nTarea {tarea.TareaID}\nDescripción: {tarea.Descripcion}\nDuración: {tarea.Duracion}\n");
        }
    }
}