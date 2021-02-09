using System;

namespace PruebaEventosApp
{
    class Program
    {
        static void Main()
        {
            Persona Tino = new Persona("Tino", 50);
            Persona Emiliano = new Persona("Emiliano", 10);
            Persona Alaina = new Persona("Alaina", 5);
            Tino.Hablar += (mensaje) => Console.WriteLine("{0}", mensaje);
            Tino.Hablar("Hola a todas las instancias!");
        }
    }
}
