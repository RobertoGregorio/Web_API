using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web_Api.Models.DTOS
{
    public class UpdatePersonDTO
    {
        public long OldPersonId { get; set; }
        public string NewPersonName { get; set; }
        public string NewPersonCPF { get; set; }
        public int NewPersonAge { get; set; }
    }
}