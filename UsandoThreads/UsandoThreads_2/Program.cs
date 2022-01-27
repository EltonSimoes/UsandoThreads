using System;
using System.Threading;

namespace UsandoThreads_2
{
    /// <summary>
    /// Neste código estamos criando uma nova thread e chamando a rotina NovaThread;
    /// Em seguida chamamos novamente a rotina NovaThread na thread principal;
    /// A rotina NovaThread declara e usa uma variável local chamada contador;
    /// Uma cópia separada da variável contador é criada e cada thread aloca a área de memória
    /// Stack para a variável;
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //Chama NovaThread em uma nova Thread
            new Thread(NewThread).Start();
            //Chama NovaThread na thread principal
            NewThread();
            Console.ReadKey();
        }

        static void NewThread()
        {
            //Declara e usa a variável local - contador
            for (int contador = 0; contador < 5; contador++)
            {
                Console.Write("2");
            }
        }
    }
}
