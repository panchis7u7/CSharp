using System;
using System.Collections.Generic;
using System.Text;

namespace EventosAtributosPrueba
{
        class HablarEventArgs : EventArgs { };
    class Persona 
    {
        //public delegate double resultHandler(double v1, double v2);
        //public delegate void OutBoundHandler(double result);
        //public resultHandler mathDelegate;
        //public OutBoundHandler OutBoundDelegate; es identico al evento OutBoundEvent!
        //public event OutBoundHandler OutBoundEvent;
        public event EventHandler<MathPerformedEventArgs> MathPerformed;
        public Persona()
        {
        }
        public double sumarNumeros(double v1, double v2)
        {
            var result = v1 + v2;
            MathPerformed(this, new MathPerformedEventArgs(result));
            return result;
        }
        public double multiplicarNumeros(double v1, double v2)
        {
            var result = v1 * v2;
            MathPerformed(this, new MathPerformedEventArgs(result));
            return result;
        }
    }
}
