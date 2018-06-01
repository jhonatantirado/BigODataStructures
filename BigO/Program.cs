using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigO
{
    class Program
    {
        private static long N = 5;

        static void Main(string[] args)
        {
            fibonacciExponencial();
            Console.WriteLine("--------------------------------------------------");

            fibonacciLineal();
            Console.WriteLine("--------------------------------------------------");

            fibonacciLogaritmicoUno();
            Console.WriteLine("--------------------------------------------------");

            fibonacciLogaritmicoDos();
            Console.WriteLine("--------------------------------------------------");

            fibonacciLogaritmicoTres();

            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Data Structures");
            DataStructures.execute();
        }

        static void fibonacciExponencial()
        {
            Console.WriteLine("fibonacciExponencial: " + N);

            if (N >= 40)
            {
                Console.WriteLine("Número muy grande: " + N);
                return;
            }

            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            Console.WriteLine(Fibonacci.Exponencial(0));
            Console.WriteLine(Fibonacci.Exponencial(1));
            Console.WriteLine(Fibonacci.Exponencial(2));

            Console.WriteLine(Fibonacci.Exponencial(N));

            long ts = stopWatch.ElapsedMilliseconds;
            Console.WriteLine("Elapsed time in milliseconds: " + ts);
        }

        static void fibonacciLineal()
        {
            Console.WriteLine("fibonacciLineal: " + N);

            if (N >= 93)
            {
                Console.WriteLine("Número muy grande: " + N);
                return;
            }

            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            Console.WriteLine(Fibonacci.Lineal(0));
            Console.WriteLine(Fibonacci.Lineal(1));
            Console.WriteLine(Fibonacci.Lineal(2));

            Console.WriteLine(Fibonacci.Lineal(N));

            long ts = stopWatch.ElapsedMilliseconds;
            Console.WriteLine("Elapsed time in milliseconds: " + ts);
        }


        static void fibonacciLogaritmicoUno()
        {
            Console.WriteLine("fibonacciLogaritmicoUno: " + N);

            if (N >= 94)
            {
                Console.WriteLine("Número muy grande: " + N);
                return;
            }

            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            Console.WriteLine(Fibonacci.LogaritmicoUno(0));
            Console.WriteLine(Fibonacci.LogaritmicoUno(1));
            Console.WriteLine(Fibonacci.LogaritmicoUno(2));

            Console.WriteLine(Fibonacci.LogaritmicoUno(N));

            long ts = stopWatch.ElapsedMilliseconds;
            Console.WriteLine("Elapsed time in milliseconds: " + ts);
        }

        static void fibonacciLogaritmicoDos()
        {
            Console.WriteLine("fibonacciLogaritmicoDos: " + N);

            if (N >= 20)
            {
                Console.WriteLine("Número muy grande: " + N);
                return;
            }

            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            Console.WriteLine(Fibonacci.LogaritmicoDos(0));
            Console.WriteLine(Fibonacci.LogaritmicoDos(1));
            Console.WriteLine(Fibonacci.LogaritmicoDos(2));

            Console.WriteLine(Fibonacci.LogaritmicoDos(N));

            long ts = stopWatch.ElapsedMilliseconds;
            Console.WriteLine("Elapsed time in milliseconds: " + ts);
        }


        static void fibonacciLogaritmicoTres()
        {
            Console.WriteLine("fibonacciLogaritmicoTres: " + N);

            if (N >= 94)
            {
                Console.WriteLine("Número muy grande: " + N);
                return;
            }

            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            Console.WriteLine(Fibonacci.LogaritmicoTres(0));
            Console.WriteLine(Fibonacci.LogaritmicoTres(1));
            Console.WriteLine(Fibonacci.LogaritmicoTres(2));

            Console.WriteLine(Fibonacci.LogaritmicoTres(N));

            long ts = stopWatch.ElapsedMilliseconds;
            Console.WriteLine("Elapsed time in milliseconds: " + ts);
        }
    }
}
