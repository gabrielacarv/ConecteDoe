using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConecteDoe.Dominio
{
    public class Notificacao
    {
        public Usuario Destinatario { get; set; }
        public Enum Tipo { get; set; }
        public string Conteudo { get; set; }
        public DateTime DataHoraNotificacao { get; set; }
    }
}
