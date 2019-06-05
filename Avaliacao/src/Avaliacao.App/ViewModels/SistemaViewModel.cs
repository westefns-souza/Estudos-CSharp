using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace App.ViewModels
{
    public class SistemaViewModel
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("Título")]
        [Required(ErrorMessage = "O campo {0} é obrigatório!")]
        [StringLength(80, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres!", MinimumLength = 2)]
        public string Titulo { get; set; }

        [DisplayName("Sistema")]
        [Required(ErrorMessage = "O campo {0} é obrigatório!")]
        [StringLength(80, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres!", MinimumLength = 2)]
        public string NomeSistema { get; set; }

        public List<SelectListItem> Sistemas { get; } = new List<SelectListItem>
        {
            new SelectListItem { Value = "exames", Text = "Exames" },
            new SelectListItem { Value = "agendamento", Text = "Agendamento" },
            new SelectListItem { Value = "marcacao", Text = "Marcações" },
        };

        [DisplayName("Situação")]
        [Required(ErrorMessage = "O campo {0} é obrigatório!")]
        [StringLength(80, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres!", MinimumLength = 2)]
        public string Situacao { get; set; }

        public List<SelectListItem> Situacoes { get; } = new List<SelectListItem>
        {
            new SelectListItem { Value = "aberto", Text = "Aberto" },
            new SelectListItem { Value = "fechado", Text = "Fechado" },
        };

        [DisplayName("Início")]
        [Required(ErrorMessage = "O campo {0} é obrigatório!")]
        public DateTime DataAvaliacaoInicio { get; set; }

        [DisplayName("Fim")]
        [Required(ErrorMessage = "O campo {0} é obrigatório!")]
        public DateTime DataAvaliacaoFim { get; set; }

        /* Relacionamento EF 1 : N => Sistema : Avaliações */
        [ScaffoldColumn(false)]
        public List<AvaliacaoViewModel> Avaliacoes { get; set; }
    }
}
