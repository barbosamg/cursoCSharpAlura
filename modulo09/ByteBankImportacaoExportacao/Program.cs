using ByteBankImportacaoExportacao.Modelos;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankImportacaoExportacao
{
    class Program
    {
        static void Main(string[] args)
        {
            var arquivo = "C:/Users/mateu/Documents/cursos/alura/c#/modulo09/arquivos/nomes.txt";
            var fluxoDoArquivo = new FileStream(arquivo, FileMode.Open);
            var buffer = new byte[1024];

            fluxoDoArquivo.Read(buffer, 0, 1024);

            var qtdBytesLidos = -1;
            while (qtdBytesLidos != 0)
            {
                qtdBytesLidos = fluxoDoArquivo.Read(buffer, 0, 1024);
                EscreverBuffer(buffer);
            }

            Console.ReadLine();
        }

        static void EscreverBuffer(byte[] buffer)
        {
            //var encoding = new UTF8Encoding();
            //var texto = encoding.GetString(buffer);

            //OU

            var utf8 = Encoding.UTF8; //Encoding.Default - pega o encoding do so
            var texto = utf8.GetString(buffer);
            Console.Write(texto);

            //foreach (var meuByte in buffer)
            //{
            //    Console.Write(meuByte);
            //    Console.Write(" ");
            //}
        }
    }
}
