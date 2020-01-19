using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            /*try
            {
                ContaCorrente mateusConta = new ContaCorrente(154, 8569423);
                mateusConta.Saldo = 1000;
                ContaCorrente juniaConta = new ContaCorrente(654, 256418);
                juniaConta.Saldo = 500;

                juniaConta.Transferir(300, mateusConta);
                Console.WriteLine($"Saldo Junia = {juniaConta.Saldo}");

                mateusConta.Sacar(150);
                Console.WriteLine(mateusConta.Saldo);

                mateusConta.Depositar(2000);
                Console.WriteLine(mateusConta.Saldo);

                mateusConta.Transferir(600, juniaConta);
                Console.WriteLine($"Saldo Mateus = {mateusConta.Saldo} | Saldo Junia = {juniaConta.Saldo}");
            }
            catch(SaldoInsuficienteException e)
            {
                Console.WriteLine("Erro: " + e.Message);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.ParamName);
            }*/
            try
            {
                ContaCorrente conta1 = new ContaCorrente(4565, 78542);
                ContaCorrente conta2 = new ContaCorrente(985612, 652314);

                conta1.Sacar(10000);
            }
            catch (OperacaoFinanceiraException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);

                Console.WriteLine("INFORMAÇÕES DA INNER EXCEPTION (EXCEÇÃO INTERNA)");
                Console.WriteLine(e.InnerException);
                Console.WriteLine(e.InnerException);

            }


            //SobreExcecoes();
            Console.ReadLine();
        }
        static void SobreExcecoes()
        {
            try
            {
                Metodo();
            }
            catch (DivideByZeroException excecao)
            {
                Console.WriteLine("Não é possível divisão por 0!");
            }
            catch (Exception excecao)
            {
                Console.WriteLine(excecao.Message);
                Console.WriteLine(excecao.StackTrace);
            }
        }
        static int Metodo()
        {
            return Dividir(10, 0);
        }
        static int Dividir(int numero, int divisor)
        {
            try
            {
                return numero / divisor;
            }
            catch (Exception)
            {
                Console.WriteLine("Exceção com numero=" + numero + " e divisor=" + divisor);
                throw;
            }
        }
    }
}
