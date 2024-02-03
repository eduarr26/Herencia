
namespace Herencia
{    public class Empleado : MiembrosComunidad
    {
        public string ID { set; get; }
        public string? area { set; get; }
        public int tiempoEnEmpresa { set; get; }

        public void Trabajar()
        {
            Console.WriteLine("Realizar Trabajo");
        }
    }
}
