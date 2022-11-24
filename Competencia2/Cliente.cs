using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treinamento.Cadastros
{
     public class Cliente
    {
        //Atributos:
        public int Codigo;
        public string Nome;

        //Métodos:
        public void Mostrar()
        {
            Console.WriteLine("Dados do Cliente:{0}--{1}", Codigo, Nome);
        }
    }

    class PessoaFisica:Cliente
    {
        public string CPF { get; set; }

        public void Mostrar()
        {
            base.Mostrar();
            Console.WriteLine("CPF: {0}", CPF);
        }
    }

    class PessoaJuridica : Cliente
    {
        public string CNPJ { get; set; }

        public void Mostrar()
        {
            base.Mostrar();
            Console.WriteLine("CNPJ:{0}", CNPJ);
        }
    }
}
