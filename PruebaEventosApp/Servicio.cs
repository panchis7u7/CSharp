using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaEventosApp
{
    class ServicioEventArgs :EventArgs
    {
        public string mensaje { get;  private set; }
        public ServicioEventArgs(string mensaje)
        {
            this.mensaje = mensaje;
        }
    }
}
