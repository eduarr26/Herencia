
namespace Herencia
{
    public class Docente : Empleado
    {
        public string? Clase { set; get; }
        public string? Horario { set; get; }
        public string? Dia { set; get; }

        public void Asignar()
        {
            Console.WriteLine("Proceso de asignacion");
        }
    }
}
