using Decorador.Servicio.Interface;

namespace Decorador.Servicio.Implementacion.Servicio
{
    public class EnviarCorreo : DecoradorAbstracto
    {
        public EnviarCorreo(IServicio servicio) : base(servicio)
        {
        }

        public new string RealizarOperacion()
        {
            string cMesaje = string.Empty;
            cMesaje = base.RealizarOperacion();
            cMesaje += "Enviar Correo\n";
            return cMesaje;
        }
    }
}
