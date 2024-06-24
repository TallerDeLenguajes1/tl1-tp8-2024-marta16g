
namespace EspacioTareas
{
    public class Tarea
    {
        private int id = 1000;
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

        public Tarea (int i, string descripcion, int duracion)
        {
            this.id += i;
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