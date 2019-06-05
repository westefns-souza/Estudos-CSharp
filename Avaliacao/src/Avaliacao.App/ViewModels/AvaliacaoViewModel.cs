using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace App.ViewModels
{
    public class AvaliacaoViewModel
    {

        public AvaliacaoViewModel()
        {
            DataAvaliacao = DateTime.Now.Date;
        }

        [Key]
        public int Id { get; set; }

        public int IdUsuario { get; set; }

        [DisplayName("Telefone")]
        public string NumeroTelefone { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório!")]
        public int Nota { get; set; }

        [DisplayName("Sugestão")]
        public string Sugestao { get; set; }

        [DisplayName("Localização")]
        public string Localizacao { get; set; }

        [DisplayName("Data da avaliação")]
        public DateTime DataAvaliacao { get; set; }

        /* Relacionameto EF 1 : 1 => Avaliação : Sistema */
        [DisplayName("Sistema")]
        public int IdSistema { get; set; }

        [DisplayName("Sistema")]
        public SistemaViewModel Sistema { get; set; }
    }
}
