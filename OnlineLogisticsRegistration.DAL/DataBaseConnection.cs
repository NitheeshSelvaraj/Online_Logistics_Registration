﻿using System.Configuration;
using System.Data.SqlClient;


namespace OnlineLogisticsRegistration.DAL
{
    class DataBaseConnection
    {
        public static SqlConnection GetDBConnection()
        {
            string connectString = ConfigurationManager.ConnectionStrings["Connect"].ConnectionString;
            SqlConnection sqlConnection = new SqlConnection(connectString);
            return sqlConnection;
        }
    }
}
