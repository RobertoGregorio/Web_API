using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Web_Api.Models.InputModels
{
    public class UpdatePersonJsonInput
    {
        [Required(ErrorMessage = "O campo OldPersonId é obrigatorio", AllowEmptyStrings = false)]
        public long OldPersonId { get; set; }

        [Required(ErrorMessage = "O campo NewPersonName é obrigatorio", AllowEmptyStrings = false)]
        public string NewPersonName { get; set; }

        [Required(ErrorMessage = "O campo NewPersonCPF é obrigatorio", AllowEmptyStrings = false)]
        public string NewPersonCPF { get; set; }

        [Required(ErrorMessage = "O campo NewPersonAge é obrigatorio", AllowEmptyStrings = false)]
        public int NewPersonAge { get; set; }
    }
}