using System;
using System.Collections.Generic;
using System.Text;

namespace projeto.Business.Models
{
    public class Avaliacao : Entity
    {
        public DateTime DataAvaliacao { get; set; }
        public string NomeSistema { get; set; }
        public string NumeroTelefone { get; set; }
        public int IdUsuario { get; set; }
        public int Nota { get; set; }
        public string Sugestoes { get; set; }
        public string Localizacao { get; set; }
    }
}
