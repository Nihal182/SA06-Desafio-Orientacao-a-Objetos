using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Treinamento.Cadastros;

namespace Competencia2
{
    class Program
    {
        static void Main(string[] args)
        {
            PessoaFisica pessoa1= new PessoaFisica();
            pessoa1.Codigo = 123;
            pessoa1.Nome = "Nayara Arruda";
            pessoa1.CPF = "04036851179";
           
            pessoa1.Mostrar();

            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++");

            PessoaJuridica pessoa2 = new PessoaJuridica();
            pessoa2.Codigo = 123;
            pessoa2.Nome = "Nihal Store";
            pessoa2.CNPJ = "3453685140001";

            pessoa2.Mostrar();  
            
            Console.ReadLine(); 

        }
    }
}
