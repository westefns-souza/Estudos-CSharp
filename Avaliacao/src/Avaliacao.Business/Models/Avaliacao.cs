using System;
using System.Collections.Generic;

namespace Business.Models
{
    public class Avaliacao : Entity
    {
        public int IdUsuario { get; set; }
        public string NumeroTelefone { get; set; }

        public int Nota { get; set; }
        public string Sugestao { get; set; }
        public string Localizacao { get; set; }

        public DateTime DataAvaliacao { get; set; }

        /* Relacionameto EF 1 : 1 => Avaliação : Sistema */
        public int IdSistema { get; set; }
        public Sistema Sistema { get; set; }
    }
}
