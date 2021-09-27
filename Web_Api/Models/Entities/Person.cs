using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web_Api.Models.Entities
{
    public class Person : BaseProperties
    {
        public string Name { get; set; }
        public string CPF { get; set; }
        public int Age { get; set; }
    }
}