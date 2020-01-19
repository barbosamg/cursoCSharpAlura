using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlocoFinally
{
    class Program
    {
        static void Main(string[] args)
        {
            CarregarContas();
            Console.ReadLine();
        }

        private static void CarregarContas()
        {
            //LeitorArquivos leitor = new LeitorArquivos("contas.txt");
            //leitor.LerProximaLinha();
            //leitor.LerProximaLinha();
            //leitor.LerProximaLinha();
            //leitor.Fechar();
            //LeitorArquivos leitor = null;
            //try
            //{
            //    leitor = new LeitorArquivos("contas.txt");
            //    leitor.LerProximaLinha();
            //    leitor.LerProximaLinha();
            //    leitor.LerProximaLinha();
            //    leitor.Fechar();
            //}
            //catch (IOException e)
            //{
            //    Console.WriteLine("Exceção do tipo IOException capturada e tratada.");
            //}
            //finally
            //{
            //    if (leitor != null)
            //    {
            //        leitor.Fechar();
            //    }
            //}
            using (LeitorArquivos leitor = new LeitorArquivos("contas.txt"))
            {
                leitor.LerProximaLinha();
                leitor.LerProximaLinha();
                leitor.LerProximaLinha();
            }
        }
    }
}
