using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConecteDoe.Dominio
{
    internal class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Email { get; set; }
        public Endereco Endereco { get; set; }
        public string Senha { get; set; }
        public string Telefone { get; set; }
    }
}
