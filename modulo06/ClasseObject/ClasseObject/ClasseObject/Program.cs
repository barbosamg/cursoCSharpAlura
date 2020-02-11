using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseObject
{
    class Program
    {
        static void Main(string[] args)
        {
            Teste teste = new Teste(12);
            object teste2 = new Teste(12);
            int a = teste.Numero;
            Console.WriteLine(a.Equals(13));
            Console.ReadKey();
        }
    }

    class Teste
    {
        public int Numero { get; set; }
        public Teste(int numero)
        {
            Numero = numero;
        }
        public override string ToString()
        {
            return "Hello World";
        }

        public override bool Equals(object obj)
        {
            //Teste teste = (Teste)obj; OU:
            Teste teste = obj as Teste;
            return base.Equals(obj);
        }
    }

    class Teste2 { }


}
