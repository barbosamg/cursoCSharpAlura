using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public abstract class Funcionario
    {
        public static int TotalFuncionarios { get; private set; }
        public string Nome { get; set; }
        public string CPF { get; private set; }
        public double Salario { get; protected set; }

        public Funcionario(double salario, string cpf)
        {
            Salario = salario;
            CPF = cpf;
            TotalFuncionarios++;
        }
        public abstract void AumentarSalario();
        public abstract double GetBonificacao();

        /*public virtual void AumentarSalario()
        {
            //Salario = Salario + (Salario * 0.1);
            //Salario = Salario * 1.1;
            Salario *= 1.1;
        }
        public virtual double GetBonificacao()
        {
            return Salario * 0.10;
        }*/
    }
}
