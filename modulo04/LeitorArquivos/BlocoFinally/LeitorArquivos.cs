 using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlocoFinally
{
    public class LeitorArquivos : IDisposable
    {
        public string Arquivo { get; }

        public LeitorArquivos(string arquivo)
        {
            Arquivo = arquivo;
        }

        public string LerProximaLinha()
        {
            Console.WriteLine("Lendo linha...");

            //throw new IOException();
            return "Linha do arquivo";
        }

        public void Fechar()
        {
            Console.WriteLine("Fechando arquivo.");
        }

        public void Dispose()
        {
            Console.WriteLine("Fechando Arquivo");
        }
    }
}
