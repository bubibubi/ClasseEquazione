using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Equazione
    {
        public float Delta { get; set; }
        public int NumeroRisultati { get; set; }
        public float A { get; set; }
        public float B { get; set; }
        public float C { get; set; }
        public float R1 { get; set; }
        public float R2 { get; set; }


        public void Calcola()
        {
            Delta = B * B - 4 * A * C;
            if (Delta < 0)
                NumeroRisultati = 0;
            else if (Delta == 0)
            {
                NumeroRisultati = 1;
                R1 = R2 = -B / 4 / A / C;
            }
            else
            {
                NumeroRisultati = 2;
                R1 = -(B + (float)Math.Sqrt(Delta)) / 4 / A / C;
                R1 = -(B - (float)Math.Sqrt(Delta)) / 4 / A / C;
            }
        }


    }
}
