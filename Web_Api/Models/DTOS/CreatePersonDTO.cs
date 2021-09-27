using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web_Api.Models.DTOS
{
    public class CreatePersonDTO
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string CPF { get; set; }
        public int Age { get; set; }
    }
}