using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web_Api.Models.Entities
{
    public class Credential : BaseProperties
    {
        public long PersonId { get; set; }
        public string Password { get; set; }
        public string email { get; set; }

    }
}