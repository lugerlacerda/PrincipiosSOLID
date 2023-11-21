using System;

namespace MetodosEstaticos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Somar: " + Calculadora.Somar(10,5));
            Console.WriteLine("Subtrarir: " + Calculadora.Subtrair(10, 5));

            Console.ReadLine();
        }
    }
}
