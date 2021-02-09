using System;
using System.Collections.Generic;
using System.Text;

namespace EventosAtributosPrueba
{
    class MathPerformedEventArgs : EventArgs
    {
        public double MathResult { get; set; }
        public MathPerformedEventArgs(double result)
        {
            MathResult = result;
            
        }
    }
}
