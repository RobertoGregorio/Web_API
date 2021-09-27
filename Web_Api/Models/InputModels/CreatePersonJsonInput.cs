using System.ComponentModel.DataAnnotations;

namespace Web_Api.Models.InputModels
{
    public class CreatePersonJsonInput
    {
        [Required(ErrorMessage = "O campo name é obrigatorio", AllowEmptyStrings = false)]
        public string Name { get; set; }

        [Required(ErrorMessage = "O campo Email é obrigatorio", AllowEmptyStrings = false)]
        public string Email { get; set; }

        [Required(ErrorMessage = "O campo Password é obrigatorio", AllowEmptyStrings = false)]
        public string Password { get; set; }

        [Required(ErrorMessage = "O campo Cpf é obrigatorio", AllowEmptyStrings = false)]
        public string CPF { get; set; }

        [Required(ErrorMessage = "O campo Age é obrigatorio", AllowEmptyStrings = false)]
        public int Age { get; set; }
    }
}