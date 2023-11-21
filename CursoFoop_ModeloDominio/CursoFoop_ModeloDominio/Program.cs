using System;

namespace CursoFoop_ModeloDominio
{
    class Program
    {
        static void Main(string[] args)
        {
            ClienteRico objCliente = new ClienteRico(-1,"",null);

            Console.WriteLine($"{objCliente.Id} {objCliente.Nome} {objCliente.Endereco}");
            Console.ReadLine();
        }

        private static ClienteAnemico NewMethod()
        {
            ClienteAnemico objCliente = new ClienteAnemico();
            objCliente.Id = -1;
            objCliente.Nome = "";
            objCliente.Endereco = null;
            return objCliente;
        }
    }
}
