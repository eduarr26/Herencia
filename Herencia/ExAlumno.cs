
namespace Herencia
{
    public class ExAlumno : MiembrosComunidad
    {
        public string? fechaSalida { set; get; }
        public string? carnet { set; get; }

        public void Documentos()
        {
            Console.WriteLine("Buscar documentacion estudiantil");
        }

    }
}
