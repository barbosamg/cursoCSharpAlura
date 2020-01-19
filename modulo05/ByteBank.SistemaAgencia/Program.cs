using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;
using Humanizer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            //ContaCorrente conta = new ContaCorrente(526, 5489);
            //Console.WriteLine(conta.Numero);

            //Teste carlos = new Teste(250.00, "teste");


            //================================= DATAS =================================

            DateTime fimPagamento = new DateTime(2020, 2, 15);
            DateTime dataAtual = DateTime.Now;

            TimeSpan diferenca = fimPagamento - dataAtual;
            string vencimento = "Vencimento em: " + TimeSpanHumanizeExtensions.Humanize(diferenca);

            Console.WriteLine(vencimento);

            Console.ReadLine();
        }

        public class Teste : Funcionario
        {
            public Teste(double salario, string cpf) : base(salario, cpf)
            {

            }
            public override void AumentarSalario()
            {
                throw new NotImplementedException();
            }

            protected override double GetBonificacao()
            {
                throw new NotImplementedException();
            }
        }

    }
}
