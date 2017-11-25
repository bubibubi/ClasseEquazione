using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            Equazione eq = new Equazione();
            eq.A = 3;
            eq.B = -15;
            eq.C = 6;
            eq.Calcola();
            Console.WriteLine("L'equazione ha {0} radici", eq.NumeroRisultati);
            Console.ReadLine();
        }
    }
}
