using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConecteDoe.Dominio
{
    public class DadosInstituicao
    {
        public int InstituicaoID { get; set; }
        public string Coordenador { get; set; }
        public DateTime DataCriacao { get; set; }
        public int QuantidadeCarentes { get; set; }
        public string Causa { get; set; }
    }
}
