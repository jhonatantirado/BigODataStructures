using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigO
{
    class Fibonacci
    {

        private static ulong[] serieLogaritmicoDos;

        public static long Exponencial (long n)
        {
            if (n < 0) {
                throw new Exception("No puede ser menor que CERO");
            }
                
            if (n <= 1){
                return n;
            }
           
            if (n == 2) {
                return 1;
            }
                
            return Exponencial(n - 1) + Exponencial(n - 2);

        }

        public static long Lineal (long n)
        {
            if (n < 0)
            {
                throw new Exception("No puede ser menor que CERO");
            }

            if (n <= 1)
            {
                return n;
            }

            if (n == 2)
            {
                return 1;
            }

            long a = 0;
            long b = 1;
            long c = 0;

            for (long i = 0; i < n; i++)
            {
                c = a + b;
                a = b;
                b = c;
            }

            return a;
        }

        public static ulong LogaritmicoUno (long n)
        {
            if (n < 0)
            {
                throw new Exception("No puede ser menor que CERO");
            }

            if (n <= 1)
            {
                return (ulong) n;
            }

            ulong[] serie = new ulong[n + 1];
            serie[0] = 0;
            serie[1] = 1;

            for (int i = 2; i <= n; i++)
            {
                serie[i] = serie[i - 1] + serie[i - 2];
            }

            return serie[n];

        }


        public static ulong LogaritmicoDos(long n)
        {
            if (n < 0)
            {
                throw new Exception("No puede ser menor que CERO");
            }

            if (n <= 1)
            {
                return (ulong)n;
            }

            ulong[] serieLogaritmicoDos = new ulong[n + 1];

            serieLogaritmicoDos[0] = 0;
            serieLogaritmicoDos[1] = 1;

            if (serieLogaritmicoDos[n] > 0)
                return serieLogaritmicoDos[n];

            serieLogaritmicoDos[n] = LogaritmicoDos(n - 1) + LogaritmicoDos(n - 2);

            return serieLogaritmicoDos[n];

        }


        public static ulong LogaritmicoTres(long n)
        {
            if (n < 0)
            {
                throw new Exception("No puede ser menor que CERO");
            }

            if (n <= 1)
            {
                return (ulong)n;
            }

            ulong[] serie = new ulong[3];
            serie[0] = 0;
            serie[1] = 1;

            for (int i = 2; i <= n; i++)
            {
                serie[2] = serie[1] + serie[0];
                serie[0] = serie[1];
                serie[1] = serie[2];
            }

            return serie[2];

        }

    }
}
