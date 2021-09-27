using System;
using System.Data;
using System.Data.SqlClient;
using Web_Api.Services;

namespace Web_Api.DataBase
{
    public class DataAccess
    {
        private SqlConnection sqlConnection = new SqlConnection();

        public DataAccess()
        {
            sqlConnection.ConnectionString = Helper.RegisterServiceSQL;
            ConnectionInit();
        }

        public SqlConnection ConnectionInit()
        {
            try
            {
                if (sqlConnection.State == ConnectionState.Closed)
                    sqlConnection.Open();

                return sqlConnection;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}