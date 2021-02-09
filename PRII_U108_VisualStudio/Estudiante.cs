using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRII_U108_VisualStudio
{
    class Estudiante
    {
        public string nombre { get; private set; }
        public List<float> calificaciones;
        public List<string> materias;
        public Estudiante(string nombre)
        {
            calificaciones = new List<float>();
            materias = new List<string>();
            this.nombre = nombre;
        }
        
    }
}
