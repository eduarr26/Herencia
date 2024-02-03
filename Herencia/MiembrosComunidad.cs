
namespace Herencia
{
    public abstract class MiembrosComunidad
    {
        public string? nombre { set; get; }
        public string? apellido { set; get; }
        public int edad { set; get; }

        public void Saludar()
        {
            Console.WriteLine("Buenos Dias");
        }

    }
}

