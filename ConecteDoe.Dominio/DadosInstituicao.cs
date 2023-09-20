using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConecteDoe.Dominio
{
    internal class DadosInstituicao
    {
        public string Coordenador { get; set; }
        public DateTime DataCriacao { get; set; }
        public int QuantidadeCarentes { get; set; }
        public string Causa { get; set; }
    }
}
