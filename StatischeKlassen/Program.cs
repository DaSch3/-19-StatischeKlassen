using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatischeKlassen
{
    class Program
    {
        static void Main(string[] args)
        {
            int ergebnis = Mathematik.Multiplikation(10, 2);

            Console.WriteLine(ergebnis);
            Console.ReadKey();
        }
    }

    static class Mathematik
    {
        public static int Addition(int wert1, int wert2)
        {
            return wert1 + wert2;
        }
        public static int Subtraktion(int wert1, int wert2)
        {
            return wert1 - wert2;
        }
        public static int Division(int wert1, int wert2)
        {
            return wert1 / wert2;
        }
        public static int Multiplikation(int wert1, int wert2)
        {
            return wert1 * wert2;
        }
        public static int Modulo(int wert1, int wert2)
        {
            return wert1 % wert2;
        }
    }
}
