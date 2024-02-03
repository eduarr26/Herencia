
namespace Herencia
{
    public class Estudiante : MiembrosComunidad
    {
        public string? carnet { set; get; }
        public string? curso { set; get; }

        public void Estudiar()
        {
            Console.WriteLine("Memorizar exposicion");
        }
    }
}
