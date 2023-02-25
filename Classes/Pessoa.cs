using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composicao.Classes
{
    public abstract class Pessoa
    {
        public Pessoa(string nome, DateTime nascimento, Endereco endereco)
        {
            Nome = nome;
            Nascimento = nascimento;
            Endereco = endereco;
        }

        public string Nome { get; set; }
        public DateTime Nascimento { get; set; }
        public Endereco Endereco { get; set; }

        public void FazerAniversario()
        {
            Nascimento.AddYears(1);
        }

        public abstract void Descrever();
        public abstract void Descrever(bool acept);
    }
}
