using System.ComponentModel.DataAnnotations;

namespace Web_Api.Models.InputModels
{
    public class GetPersonJsonInput
    {
        [Required(ErrorMessage = "O campo Id é obrigatorio", AllowEmptyStrings = false)]
        public long PersonId { get; set; }
    }
}