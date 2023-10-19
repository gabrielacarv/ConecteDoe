using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConecteDoe.Dominio
{
    public class Doacao
    {
        public int Id { get; set; }
        public Usuario Doador { get; set; }
        public Instituicao instituicao { get; set; }
        public DateTime Data { get; set; }
        public double Valor { get; set; }
        public Comprovante Comprovante { get; set; }
    }
}
