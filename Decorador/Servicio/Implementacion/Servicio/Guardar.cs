using Decorador.Servicio.Interface;

namespace Decorador.Servicio.Implementacion.Servicio
{
    public class Guardar : IServicio
    {
        public string RealizarOperacion()
        {
            return "Se realiza el Guardado\n";
        }
    }
}
