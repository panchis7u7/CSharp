using System;

namespace EventosAtributosPrueba
{
    class Atributos : Attribute { }
    class Program
    {
        static void Main(string[] args)
        {
            Persona p1 = new Persona();
            p1.MathPerformed += OnOutboundEvent;
            p1.sumarNumeros(4.3, 10.6);
            p1.multiplicarNumeros(2, 2);
        }
        //On prefix, Event Suffix
        public static void OnOutboundEvent(object sender, MathPerformedEventArgs e)
        {
            Console.WriteLine("Outbound Result: "+ e.MathResult);
        }
    }
}
