using System;
using System.Threading;

namespace UsandoThreads_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread thread = new Thread(Rotina);
            // Inicia a thread
            thread.Start();
            // Aguarda o término da thread
            thread.Join();
            Console.WriteLine("\r\n\r\nA thread terminou a sua execução!");
            Console.ReadKey();
        }

        static void Rotina()
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.Write("www.thread.com.br");
            }
        }
    }
}
