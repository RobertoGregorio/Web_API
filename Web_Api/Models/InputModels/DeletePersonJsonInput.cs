using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Web_Api.Models.InputModels
{
    public class DeletePersonJsonInput
    {
        [Required(ErrorMessage = "Campo personId é obrigatório", AllowEmptyStrings = false)]
        public long PersonId { get; set; }
    }
}