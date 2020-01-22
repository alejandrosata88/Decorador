using Decorador.Servicio.Interface;

namespace Decorador.Servicio.Implementacion.Servicio
{
    public class GuardarHistorial : DecoradorAbstracto
    {
        public GuardarHistorial(IServicio servicio) : base(servicio)
        {
        }

        public new string RealizarOperacion()
        {
            string cMesaje = string.Empty;
            cMesaje = base.RealizarOperacion();
            cMesaje += "Guardar Historial\n";
            return cMesaje;
        }
    }
}
