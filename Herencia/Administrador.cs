
namespace Herencia
{
    public class Administrador : Docente
    {
        public string? edificio { set; get; }
        public string? carrera { set; get; }

        public void Reparar()
        {
            Console.WriteLine("Corrigiendo assigments");
        }

    }
}
