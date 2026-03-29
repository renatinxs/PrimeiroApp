using System.ComponentModel.DataAnnotations;

namespace PrimeiroApp.Models
    {
        public class Endereco
        {
            /* PK */

            [Display(Name = "Código", Description = "Código.")]
            public int Id { get; set; }

            [Display(Name = "CEP", Description = "CEP.")]
            [MaxLength(10, ErrorMessage = "O CEP deve ter no máximo 10 caracteres")]
            [Required(ErrorMessage = "O CEP é obrigatório.")]
            public string CEP { get; set; }

            [Display(Name = "Estado", Description = "Estado.")]
            [Required(ErrorMessage = "O Estado é obrigatório.")]
            public string Estado { get; set; }

            [Display(Name = "Cidade", Description = "Cidade.")]
            [Required(ErrorMessage = "A Cidade é obrigatória.")]
            public string Cidade { get; set; }

            [Display(Name = "Bairro", Description = "Bairro.")]
            [Required(ErrorMessage = "O Bairro é obrigatório.")]
            public string Bairro { get; set; }

            [Display(Name = "Endereço", Description = "Endereço.")]
            [Required(ErrorMessage = "O Endereço é obrigatório.")]
            public string Logradouro { get; set; }

            [Display(Name = "Complemento", Description = "Complemento.")]
            [Required(ErrorMessage = "O Complemento é obrigatório.")]
            public string Complemento { get; set; }

            [Display(Name = "Número", Description = "Número.")]
            public string Numero { get; set; }
        }
    }

