using System;

namespace CursoFoop_MetodosExtensao
{
    class Program
    {
        static void Main(string[] args)
        {
            var texto1 = "curso";
            var texto2 = "madalena";

            texto1 = texto1.CaixaAltaPrimeiraLetra();
            texto2 = texto2.CaixaAltaPrimeiraLetra();

            Console.WriteLine(texto1);
            Console.WriteLine(texto2);

            Console.ReadLine();
        }
    }
}
