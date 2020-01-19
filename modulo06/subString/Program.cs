using System;

namespace modulo06
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = "pagina?argumentos";
            // string argumentos = url.Substring(7);
            Console.WriteLine(url);

            int indiceInterrogacao = url.IndexOf("?");
            Console.WriteLine(indiceInterrogacao);
            string argumentos = url.Substring(indiceInterrogacao);
            Console.WriteLine(argumentos);
        }
    }
}
