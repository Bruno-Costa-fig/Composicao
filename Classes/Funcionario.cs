using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composicao.Classes
{
    public abstract class Funcionario : Pessoa
    {
        public decimal Salario { get; set; }
        protected Funcionario(decimal salario, string nome, DateTime nascimento, Endereco endereco) : base(nome, nascimento, endereco)
        {
            Salario = salario;
        }
        public abstract void ReceberAumento();
        public virtual void ReceberComissao()
        {
            Salario += 100;
        }
    }
}
