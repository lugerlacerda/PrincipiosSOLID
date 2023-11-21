namespace Aula_Propriedades
{
    public class Pessoa
    {
        public string nome;
        public int idade;
        public string genero;

        public Pessoa(string nome)
        {
            this.Nome = nome;
        }

        public string Nome { get; }

        public string Genero
        {
            set
            {
                genero = value;
                System.Console.WriteLine(genero);
            }
        }

        public int Idade
        {
            set
            {
                if (value < 18)
                {
                    System.Console.WriteLine("Idade tem que ser maior que 18");
                }
                else
                {
                    this.idade = value;
                }
            }

            get { return idade; }

        }


    }
}
