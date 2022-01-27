using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoThreads
{
    /// <summary>
    /// Se executarmos o projeto teremos um laço infinito onde são gerados valores aleatórios para o controle ProgressBar que é exibido no formulário;
    /// </summary>
    public partial class Form1 : Form
    {
        private Thread trd;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esta é a thread principal do programa!");
        }

        private void ThreadTarefa()
        {
            int stp;
            int novoValor;
            Random rnd = new Random();

            while (true)
            {
                stp = this.pgbThreads.Step * rnd.Next(-1, 2);
                novoValor = this.pgbThreads.Value + stp;

                if (novoValor > this.pgbThreads.Maximum)
                    novoValor = this.pgbThreads.Maximum;
                else if (novoValor < this.pgbThreads.Minimum)
                    novoValor = this.pgbThreads.Value;

                ///Exceção é lançada quando um controle em um formulário é acessado a partir de outra thread.
                ///Infelizmente trabalhar com threads sincronizadas para controles em aplicações Windows Forms 
                ///é um problema que você terá que resolver sozinho pois não é possível trabalhar com objetos criados por outra thread a não ser usando um delegate.
                //this.pgbThreads.Value = novoValor;

                //esta linha coontorna o problema do erro da thread
                SetControlPropertyValue(pgbThreads, "value", novoValor);

                Thread.Sleep(100);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Thread trd = new Thread(new ThreadStart(this.ThreadTarefa));
            trd.IsBackground = true;
            trd.Start();
        }

        delegate void SetControlValueCallback(Control oControl, string propName, object propValue);
        private void SetControlPropertyValue(Control oControl, string propName, object propValue)
        {
            if (oControl.InvokeRequired)
            {
                SetControlValueCallback d = new SetControlValueCallback(SetControlPropertyValue);
                oControl.Invoke(d, new object[] { oControl, propName, propValue });
            }

            else
            {
                Type t = oControl.GetType();
                PropertyInfo[] props = t.GetProperties();
                foreach (PropertyInfo p in props)
                {
                    if (p.Name.ToUpper() == propName.ToUpper())
                    {
                        p.SetValue(oControl, propValue, null);
                    }
                }
            }
        }
    }
}
