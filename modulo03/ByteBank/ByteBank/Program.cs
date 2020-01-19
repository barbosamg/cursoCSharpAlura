using ByteBank.Funcionarios;
using ByteBank.Sistemas;
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
            //CalcularBonificacao();
            UsarSistema();
            Console.ReadLine();
        }

        public static void UsarSistema()
        {
            SistemaInterno sistema = new SistemaInterno();
            Diretor roberta = new Diretor(5000, "45678912354");
            roberta.Nome = "Roberta";
            roberta.Senha = "123";

            GerenteConta camila = new GerenteConta(5000, "45678912354");
            camila.Nome = "Camila";
            camila.Senha = "abc";

            sistema.Logar(roberta, "123");
            sistema.Logar(camila, "abc");
        }

        public static void CalcularBonificacao()
        {
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

            Designer pedro = new Designer(2000, "56488712364");
            pedro.Nome = "Pedro";

            Diretor roberta = new Diretor(5000, "45678912354");
            roberta.Nome = "Roberta";

            Auxiliar igor = new Auxiliar(1800, "65491534786");
            igor.Nome = "Igor";

            GerenteConta camila = new GerenteConta(3500, "32165498774");
            camila.Nome = "Camila";

            gerenciador.Registrar(pedro);
            gerenciador.Registrar(roberta);
            gerenciador.Registrar(igor);
            gerenciador.Registrar(camila);

            Console.WriteLine("Total bonificações do mês = " + gerenciador.GetTotalBonificacao());
        }
    }
}
