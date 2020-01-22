using Decorador.Servicio.Interface;

namespace Decorador.Servicio.Implementacion.Servicio
{
    public abstract class DecoradorAbstracto: IServicio
    {
        protected IServicio IServicio;

        public DecoradorAbstracto(IServicio _IServicio)
        {
            this.IServicio = _IServicio;
        }
    
        public string RealizarOperacion()
        {
            string cMensaje = string.Empty;
            if(this.IServicio!=null)
                cMensaje=this.IServicio.RealizarOperacion();
            else
                cMensaje = "";
            return cMensaje;
        }
    }
}
