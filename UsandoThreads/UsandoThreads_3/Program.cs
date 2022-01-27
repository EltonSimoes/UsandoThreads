using System;
using System.Threading;

namespace UsandoThreads_3
{
    /// <summary>
    /// Agora estamos criando uma instância comum , iniciando uma nova thread,
    /// onde estamos executando a rotina NovaThread, e, em seguida executamos
    /// novamente a mesma rotina na mesma instância.
    /// </summary>
    class Program
    {
        bool ok;

        static void Main(string[] args)
        {
            // Cria uma instância comum
            Program tt = new Program();
            // Inicia a execução da rotina na novao instância
            new Thread(tt.NewThread).Start();
            // Exetuta a rotina na mesma instãncia
            tt.NewThread();
        }

        void NewThread()
        {
            if (!ok)
            {
                ok = true;
                Console.WriteLine("www.macoratti.net");
            }
        }
    }
}
