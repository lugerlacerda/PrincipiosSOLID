﻿using System;

namespace Aula_Propriedades
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa("Luiz");
            p1.Genero = "Masculino";
            p1.Idade = 19;

            Console.WriteLine(p1.Nome);
            Console.WriteLine(p1.Idade);

        }
    }
}
