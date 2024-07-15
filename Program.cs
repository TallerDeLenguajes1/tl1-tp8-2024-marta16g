using System;

using EspacioTareas;

class Program{
private static void Main(string[] args)
{
    Random rand = new();
    int numTareas = rand.Next(2,6);

    List<Tarea> tareasPendientes = new();

    for (int i = 0; i < numTareas; i++)
    {
        Tarea nuevo = new($"Descripción {i}", rand.Next(1, 10));
        tareasPendientes.Add(nuevo);
    }

    

}

}

