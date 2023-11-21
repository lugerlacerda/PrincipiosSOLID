using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_Classes1
{
    class Funcionario
    {
        public string Nome { get; set; }
        public string Email { get; set; }

        public Funcionario(string Nome, string Email)
        {
            this.Nome = Nome;
            this.Email = Email;
        }
    }
}
