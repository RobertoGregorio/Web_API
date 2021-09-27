
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using Web_Api.DataBase;
using Web_Api.Models.Entities;

namespace Web_Api.Models.DAOS
{
    public class CredentialDAO : CommomDAO
    {
        public CredentialDAO() { }

        public void SaveCredential(Credential credential)
        {
            try
            {
                string sqlCommandText = "InsertCredential";
                this.ExecuteStoredProcedure(credential, sqlCommandText);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}