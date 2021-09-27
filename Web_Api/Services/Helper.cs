using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace Web_Api.Services
{
    public static class Helper
    {
        public static string RegisterServiceSQL
        {
            get { return @"Data Source=DESKTOP-30LO6MP\SQLEXPRESS;Initial Catalog=REGISTER_SERVICE;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"; }
        }
    }
}