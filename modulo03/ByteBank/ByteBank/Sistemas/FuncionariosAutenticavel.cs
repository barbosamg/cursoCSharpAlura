using ByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Sistemas
{
    public abstract class FuncionariosAutenticavel : Funcionario, IAutenticavel
    {
        public string Senha { get; set; }
        public FuncionariosAutenticavel(double salario, string cpf) : base(salario, cpf) { }

        public bool Autenticar(string senha)
        {
            return Senha == senha;  
        }
    }
}
