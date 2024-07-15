
namespace EspacioTareas
{
    public class Tarea
    {
        private static int idCounter = 1000;
        private int id;
        public string descripcion;
        public int duracion;

        public int Id
        {
            get => id;
            set => id = value;
        }
        public string Descripcion
        {
            get => descripcion;
            set => descripcion = value;
        }

        public int Duracion
        {
            get => duracion;
            set => duracion = value;
        }

        public Tarea (string descripcion, int duracion)
        {
            this.id = idCounter++;
            this.descripcion = descripcion;
            this.duracion = duracion;
        }

        public void MostrarTarea()
        {
            Console.WriteLine($"--TAREA {id}--");
            Console.WriteLine($"Descripción: {descripcion}");
            Console.WriteLine($"Duración: {duracion} min");
        }

    }
}