namespace Aula_Classes1
{
    partial class Program
    {
        class Pessoa
        {
            public string nome;
            public int idade;
            public string genero;

            public Pessoa()
            {
            }

            public Pessoa(string nome)
            {
                this.nome = nome;
            }

            //constructor, digitar ctor + tab para criar
            public Pessoa(string nome, int idade, string genero)
            {
                this.nome = nome;
                this.idade = idade;
                this.genero = genero;
            }

            public void Identificar()
            {
                System.Console.WriteLine($"Sou o {nome} tenho a idade {idade} genero {genero}");
            }

        }
    }
}
