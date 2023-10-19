using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace ConecteDoe.Dominio
{
    public class Comprovante
    {
        public DateTime Data { get; set; }
        public double Valor { get; set; }
        public Usuario Doador { get; set; }
        public Instituicao Instituicao { get; set; }
    }
}
