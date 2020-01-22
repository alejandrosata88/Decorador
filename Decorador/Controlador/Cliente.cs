using Decorador.Servicio.Implementacion.Servicio;
using Decorador.Servicio.Interface;
using System;

namespace Decorador.Controlador
{
    public class Cliente
    {
        public void Main()
        {
            string cMensaje = string.Empty;
            IServicio IServicio = new Guardar();

            cMensaje=IServicio.RealizarOperacion();
            Console.WriteLine(cMensaje);

            Console.WriteLine("Caso 1:\n");
            GuardarHistorial GuardarHistorial = new GuardarHistorial(IServicio);
            cMensaje = GuardarHistorial.RealizarOperacion();
            Console.WriteLine(cMensaje);

            Console.WriteLine("Caso 2:\n");
            EnviarCorreo EnviarCorreo = new EnviarCorreo(IServicio);
            cMensaje = EnviarCorreo.RealizarOperacion();
            Console.WriteLine(cMensaje);

            Console.WriteLine("Caso 3:\n");
            GuardarHistorial = new GuardarHistorial(IServicio);
            EnviarCorreo = new EnviarCorreo(GuardarHistorial);
            cMensaje = EnviarCorreo.RealizarOperacion();
            Console.WriteLine(cMensaje);

            Console.ReadLine();
        }
    }
}
