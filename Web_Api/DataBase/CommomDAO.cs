using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Reflection;
using Web_Api.Models.Entities;

namespace Web_Api.DataBase
{
    public class CommomDAO
    {
        protected SqlDataReader reader;

        protected SqlCommand sqlCommand = new SqlCommand();

        protected CommomDAO()
        {
            this.sqlCommand.Connection = new DataAccess().ConnectionInit();
            this.sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
        }

        protected void ExecuteStoredProcedure(BaseProperties baseProperties, string sqlCommandText)
        {
                this.sqlCommand.CommandText = sqlCommandText;

                PropertyInfo[] propertyInfos = baseProperties.GetType().GetProperties();

                foreach (PropertyInfo propertyInfo in propertyInfos)
                {
                    if (propertyInfo.Name == "Id")
                        continue;

                    string sqlParameter = "param" + propertyInfo.Name;

                    this.sqlCommand.Parameters.AddWithValue(sqlParameter, propertyInfo.GetValue(baseProperties));
                };

                reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    baseProperties.Id = Convert.ToInt64(reader[0]);
                }
        }

        protected BaseProperties MapperEntites<T>(BaseProperties Entity)
        {
            PropertyInfo[] propertyInfos = Entity.GetType().GetProperties();

                for (int index = 0; index < propertyInfos.Length; index++)
                {
                    PropertyInfo property = Entity.GetType().GetProperty(propertyInfos[index].Name);

                    if (property.Name == "Id")
                        property.SetValue(Entity, this.reader[Entity.GetType().Name + property.Name]);
                    else
                        property.SetValue(Entity, this.reader[property.Name]);
                }

                return Entity;
        }
    }
}






