using System;

namespace CursoFoop_ModeloDominio
{
    class ClienteRico
    {
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public string Endereco { get; private set; }

        public ClienteRico(int id, string nome, string endereco)
        {
            DomainExceptionValidation.When(id < 0, "Id inválido");
            DomainExceptionValidation.When(string.IsNullOrEmpty(nome), "Nome inválido");
            DomainExceptionValidation.When(string.IsNullOrEmpty(endereco), "endereço inválido");

            Id = id;
            Nome = nome;
            Endereco = endereco;
        }   
    }
}
