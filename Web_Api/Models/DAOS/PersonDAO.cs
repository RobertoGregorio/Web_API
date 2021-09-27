using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Web;
using Web_Api.DataBase;
using Web_Api.Models.Entities;

namespace Web_Api.Models.DAOS
{
    public class PersonDAO : CommomDAO
    {
        public PersonDAO() { }

        public void SavePerson(Person person)
        {
            try
            {
                string sqlCommandText = "InsertPerson";
                this.ExecuteStoredProcedure(person, sqlCommandText);
            }
            catch (Exception)
            {
                throw new Exception($"pessoa não cadastrada");
            }
        }

        public Person GetPersonById(long personId)
        {
            try
            {
                this.sqlCommand.CommandText = "GetPerson";
                this.sqlCommand.Parameters.AddWithValue("paramId", personId);

                this.reader = this.sqlCommand.ExecuteReader();

                return (Person)this.MapperEntites<Person>(new Person());
            }
            catch (Exception)
            {
                throw new Exception("Pessoa não encontrada");
            }
        }

        public void UpdatePerson(Person newPersonInfo, long personId)
        {
            try
            {
                this.sqlCommand.CommandText = "UpdatePerson";

                this.sqlCommand.Parameters.AddWithValue("paramPersonId", personId);
                this.sqlCommand.Parameters.AddWithValue("paramName", newPersonInfo.Name);
                this.sqlCommand.Parameters.AddWithValue("paramCpf", newPersonInfo.CPF);
                this.sqlCommand.Parameters.AddWithValue("paramAge", newPersonInfo.Id);

                this.sqlCommand.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw new Exception("Dados não atualizados");
            }

        }

        public void DeleterPersonById(long personId)
        {
            try
            {
                this.sqlCommand.CommandText = "DeletePerson";
                this.sqlCommand.Parameters.AddWithValue("paramPersonId", personId);
                this.sqlCommand.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw new Exception("Pessoa não deletada");
            }

        }

    }
}