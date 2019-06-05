using System;
using System.Collections.Generic;

namespace Business.Models
{
    public class Sistema : Entity
    {
        public string Titulo { get; set; }
        public string NomeSistema { get; set; }
        public string Situacao { get; set; }
        public DateTime DataAvaliacaoInicio { get; set; }
        public DateTime DataAvaliacaoFim { get; set; }

        /* Relacionamento EF 1 : N => Sistema : Avaliações */
        public List<Avaliacao> Avaliacoes { get; set; }
    }
}
