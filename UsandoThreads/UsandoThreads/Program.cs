using System;
using System.Threading;

namespace UsandoThreads
{
    /// <summary>
    /// "Uma Thread é Um fluxo de controle sequencial isolado dentro de um programa"
    /// A linguagem C# suporta a execução paralela de código através do multithreading onde uma Thread 
    /// é uma caminho de execução independente que esta apto para rodar simultaneamente com outras threads.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //dispara uma nova thread para executar
            Thread t = new Thread(NewThread);
            t.Start();

            for (int i = 0; i < 10000; i++)
            {
                Console.Write("1 - Hello World! ");
            }
        }

        static void NewThread()
        {
            for (int i = 0; i < 10000; i++)
            {
                Console.Write("2 - NewThread! ");
            }
        }
    }
}
