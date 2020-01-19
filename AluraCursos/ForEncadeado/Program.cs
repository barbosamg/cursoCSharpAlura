using System;

namespace ForEncadeado
{
    class Program
    {
        static void Main(string[] args)
        {
            //for (int contadorLinha = 0; contadorLinha < 10; contadorLinha++)
            //{
            //    for (int contadorColuna = 0; contadorColuna <= contadorLinha; contadorColuna++)
            //        Console.Write("*");
            //    //if (contadorColuna >= contadorLinha)
            //    //    break;
            //    Console.WriteLine();
            //}
            //Console.ReadLine();

            //int contador = 0;
            ////while(contador <= 10)
            ////{
            ////    Console.WriteLine(contador);
            ////    contador++;
            ////}



            //do
            //{
            //    contador++;
            //    Console.WriteLine(contador);
            //} while (contador <= 50);
            //Console.ReadLine();

            //    for (int linha = 0; linha < 10; linha++)
            //    {
            //        for (int coluna = 0; coluna < 10; coluna++)
            //        {
            //            if (coluna > linha)
            //            {
            //                break;
            //            }
            //            Console.Write(coluna+1);
            //        }
            //        Console.WriteLine();
            //    }

            //    Console.ReadLine();
            //}
            int fatorial = 1;
            for (int i = 1; i < 11; i++)
            {
                fatorial *= i;
                Console.WriteLine("Fatorial de " + i + " = " + fatorial);
            }
            Console.ReadLine();
        }
    }
}
