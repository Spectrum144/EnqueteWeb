using System.ComponentModel.DataAnnotations;

namespace EnqueteWeb.Models
{
    public class Resposta
    {
        [Required(ErrorMessage = "Nome obrigatório")]
        public string Nome {get; set;}
        [Required(ErrorMessage = "Email obrigatório")]
        [EmailAddress(ErrorMessage="O campo do email preenchido não corresponde à um endereço válido!")]
        public string Email {get; set;}
        [Required(ErrorMessage = "Resposta obrigatória")]
        public bool? Sim { get; set;}

    }
}