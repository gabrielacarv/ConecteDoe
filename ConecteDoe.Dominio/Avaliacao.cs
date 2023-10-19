using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConecteDoe.Dominio
{
    public class Avaliacao
    {
        public Usuario Avaliador { get; set; }
        public Instituicao Instituicao { get; set; }
        public int Classificacao { get; set; }
        public string Comentario { get; set; }
    }
}
