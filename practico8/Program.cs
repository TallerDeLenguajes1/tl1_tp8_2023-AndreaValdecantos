using ListaDeTareas;

List<Tareas> TareasPendientes = new List<Tareas>();
List<Tareas> TareasRealizadas = new List<Tareas>();
string? descripcion;

for (int i = 0; i < 5; i++)
{
    Tareas Tarea = new Tareas();
    var numeroRandom = new Random();
    Console.WriteLine($"Ingrese la descripción de la tarea {i+1}: ");
    descripcion = Console.ReadLine();
    Tarea.Descripcion = descripcion;
    Tarea.TareaID = i+1;
    Tarea.Duracion = numeroRandom.Next(10,100);
    TareasPendientes.Add(Tarea);
    
}

Console.WriteLine("\n------------------------\nLISTA DE TAREAS PENDIENTES");
foreach (var tarea in TareasPendientes)
{
    Console.WriteLine($"Tarea {tarea.TareaID}\nDescripción: {tarea.Descripcion}\nDuración: {tarea.Duracion}\n");
}