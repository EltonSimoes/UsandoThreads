using System;
using System.Threading;

namespace UsandoThreads_4
{
    /// <summary>
    /// Uma outra forma de compartilhar dados entre as threads é definir campos estáticos.
    /// </summary>
    class Program
    {
        static bool ok;
        static bool ok2;
        static void Main(string[] args)
        {
            new Thread(NEwRotina).Start();
            NEwRotina();


            new Thread(NovaRotina2).Start();
            NovaRotina2();
            Console.ReadKey();

            TesteLock();
            Console.ReadKey();
        }

        static void NEwRotina()
        {
            if (!ok)
            {
                ok = true;
                Console.WriteLine("www.macoratti.net");
            }
        }

        /// <summary>
        /// Executando este código o resultado será o mesmo que o exemplo anterior,
        /// Se alterarmos a ordem das instruções na rotina NovaRotina();
        /// O problema é que uma thread pode estar avaliando a instrução if enquanto a outra thread
        /// pode estar executando a instrução Writeline.
        /// </summary>
        static void NovaRotina2()
        {
            if (!ok2)
            {
                Console.WriteLine("www.macoratti.net");
                ok2 = true;
            }
        }

        /// <summary>
        /// O lock() que vai bloquear os recursos até que a thread que o esta usando acabe de processá-lo.
        /// </summary>

        static bool ok3;
        static readonly object bloqueador = new object();

        static void TesteLock()
        {
            new Thread(NovaRotina).Start();
            NovaRotina();
            Console.ReadKey();
        }

        static void NovaRotina()
        {
            lock (bloqueador)
            {
                if (!ok3)
                {
                    Console.WriteLine("www.macoratti.net Lock");
                    ok3 = true;
                }
            }
        }
    }
}
