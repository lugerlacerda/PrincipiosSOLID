using System;

namespace Aula_Classes1
{
    partial class Program
    {
        static void Main(string[] args)
        {
            Pessoa objPessoa = new Pessoa();

            objPessoa.nome = "Luiz";
            objPessoa.idade = 50;
            objPessoa.genero = "Masculino";
            objPessoa.Identificar();

            Pessoa objPessoa2 = new Pessoa("JOse", 55, "Masculino");
            objPessoa2.Identificar();

            Pessoa objPessoa3 = new Pessoa("Paulo");
            objPessoa3.Identificar();   

        }
    }
}
