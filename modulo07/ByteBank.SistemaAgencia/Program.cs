using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Lista<int> idades = new Lista<int>();
            idades.AdicionarVarios(1, 50, 25, 89, 23);

            for (int i = 0; i < idades.Tamanho; i++)
            {
                Console.WriteLine(idades[i]);
            }

            Lista<string> cursos = new Lista<string>();
            cursos.AdicionarVarios("C#", "Java", "HTML");
            cursos.Remover("Java");
            cursos.Remover(cursos[0]);

            Teste.Ola();

            Console.ReadLine();

            //SomarNumeros(new int[] { 1, 2, 3, 4, 5, 6, 7 });
        }

        static void ParteDois()
        {
            ListaDeContaCorrente lista = new ListaDeContaCorrente();

            /*ContaCorrente[] contas = new ContaCorrente[]
            {
                new ContaCorrente(1245, 302145),
                new ContaCorrente(6585, 127863),
                new ContaCorrente(6525, 231478),
                new ContaCorrente(6547, 981245),
                new ContaCorrente(3981, 458230)
            };

            lista.AdicionarVarios(contas);*/

            /*Os arrays nos dão a flexibilidade de lidar com vários valores sem ser necessário criar um método com muitos argumentos. Para mantermos o benefício de lidarmos com uma quantidade variável de valores em nosso método AdicionarVarios e ainda não nos preocuparmos com arrays, podemos usar o params apenas mudando a assinatura do método:*/
            lista.AdicionarVarios(new ContaCorrente(1245, 302145),
                new ContaCorrente(6585, 127863),
                new ContaCorrente(6525, 231478),
                new ContaCorrente(6547, 981245),
                new ContaCorrente(3981, 458230));

            lista.EscreverListaNaTela();
            Console.WriteLine("==================ITEM REMOVIDO==================");
            lista.Remover(lista[2]);
            lista.EscreverListaNaTela();

            ContaCorrente conta = lista[2];
            Console.WriteLine($"{conta.Agencia}/{conta.Numero}");
        }

        static void SomarNumeros(int[] numeros)
        {
            for (int i = 0; i < numeros.Length - 1; i += 2)
            {
                int primeiroNumero = numeros[i];
                int segundoNumero = numeros[i + 1];

                int soma = primeiroNumero + segundoNumero;

                Console.WriteLine($"{primeiroNumero}+{segundoNumero} = {soma}");
            }
        }

        static void ParteUm()
        {
            int[] idades = new int[5];

            idades[0] = 15;
            idades[1] = 28;
            idades[2] = 35;
            idades[3] = 50;
            idades[4] = 28;

            int acumulador = 0;
            for (int indice = 0; indice < idades.Length; indice++)
            {
                acumulador += idades[indice];
            }
            int media = acumulador / idades.Length;
            Console.WriteLine(media);

            int[] idades2 = new int[] { 15, 28, 35, 50, 28 };
        }
    }

    public static class Teste
    {
        public static void Ola()
        {
            "mateus".TesteOi();
        }
        public static void TesteOi(this string tese)
        {
            Console.WriteLine(tese);
        }
    }

}

