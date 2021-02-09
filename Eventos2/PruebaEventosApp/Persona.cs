using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaEventosApp
{
    class Persona
    {
        public Action<string> Hablar;
        public string nombre { get; set; }
        public int edad { get; set; }

        public Persona(string nombre, int edad)
        {
            this.nombre = nombre;
            this.edad = edad;
        }

        public void hablar(string mensaje)
        {
            Hablar(mensaje);
        }
    }
}
