
namespace Herencia
{
    public class Maestro : Docente
    {
        public string? materia { set; get; }
        public string? calendario { set; get; }

        public void Lista()
        {
            Console.WriteLine("Pasar Lista");
        }
    }
}
