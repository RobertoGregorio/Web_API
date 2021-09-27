using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;

namespace Web_Api.Services
{
    public class Validators
    {
        public static void ValidateModel(object model)
        {
            try
            {
                Validator.ValidateObject(model, new ValidationContext(model), true);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}