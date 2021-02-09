using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRII_U108_VisualStudio
{
    class Estudiante
    {
        public int[] calificaciones;
        public String nombre { get; private set; }
        private const int mate = 0, prog = 1, red = 2, sw = 3, bd = 4;
        private int mayor = 0, menor = 0, prom;
        public Estudiante()
        {
            calificaciones = new int[5];
            nombre = "Juana";
        }
        public void setMatematicas(int cal)
        {
            calificaciones[mate] = cal;
        }
        public void setProgramacion(int cal)
        {
            calificaciones[prog] = cal;
        }
        public void setRed(int cal)
        {
            calificaciones[red] = cal;
        }
        public void setSW(int cal)
        {
            calificaciones[sw] = cal;
        }
        public void setBD(int cal)
        {
            calificaciones[bd] = cal;
        }

        public int calMayor()
        {
            for(int i=0; i<calificaciones.Length; i++)
            {
                if (calificaciones[i]>mayor)
                {
                    mayor = calificaciones[i];
                }                
            }
            return mayor;
        }

        public int calMin()
        {
            menor = calificaciones[0];
            for (int i = 0; i < calificaciones.Length; i++)
            {
                if (calificaciones[i] < menor)
                {
                    menor = calificaciones[i];
                }
            }
            return menor;
        }

        public int promedio()
        {
            for (int i = 0; i < calificaciones.Length; i++)
            {
                prom += calificaciones[i];
            }
            prom = prom / calificaciones.Length;
            return prom;
        }

    }
}
