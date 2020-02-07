using System;
using System.Data;
using System.Data.SqlClient;
using OnlineLogisticsRegistration.Entity;


namespace OnlineLogisticsRegistration.DAL
{
    public class UserRepository
    {

        public int SignUp(User user)
        {
            SqlConnection sqlConnection = DataBaseConnection.GetDBConnection();
            sqlConnection.Open();
            string insert_sp = "REGISTER_Insert";

            using (SqlCommand sqlCommand = new SqlCommand(insert_sp, sqlConnection))
            {
                sqlCommand.CommandType = CommandType.StoredProcedure;

                SqlParameter param = new SqlParameter();
                param.ParameterName = "@Name";
                param.Value = user.name;
                param.SqlDbType = System.Data.SqlDbType.VarChar;
                sqlCommand.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@MobileNumber";
                param.Value = user.mobileNumber;
                param.SqlDbType = System.Data.SqlDbType.BigInt;
                sqlCommand.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@UserName";
                param.Value = user.userName;
                param.SqlDbType = System.Data.SqlDbType.VarChar;
                sqlCommand.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "Password";
                param.Value = user.password;
                param.SqlDbType = System.Data.SqlDbType.VarChar;
                sqlCommand.Parameters.Add(param);

                // sqlCommand.Parameters.Add(new SqlParameter("@Option", SqlDbType.Int).Value = option);
                try
                {
                    int retRows = sqlCommand.ExecuteNonQuery();
                    sqlConnection.Close();
                    if (retRows >= 1)
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
                catch(Exception)
                {
                    return -1;
                }
            }         
        }
        public string LogIn(string userName,string password)
        {
            SqlConnection sqlConnection = DataBaseConnection.GetDBConnection();
            sqlConnection.Open();
            string role;
            string checkLogin_sp = "CHECK_Login";

            using (SqlCommand sqlCommand = new SqlCommand(checkLogin_sp, sqlConnection))
            {
                sqlCommand.CommandType = CommandType.StoredProcedure;

                //SqlParameter param = new SqlParameter();
                //param = new SqlParameter();
                //param.ParameterName = "@UserName";
                //param.Value = userName;
                //param.SqlDbType = System.Data.SqlDbType.VarChar;
                //sqlCommand.Parameters.Add(param);

                //param = new SqlParameter();
                //param.ParameterName = "@Password";
                //param.Value = password;
                //param.SqlDbType = System.Data.SqlDbType.VarChar;
                //sqlCommand.Parameters.Add(param);

                sqlCommand.Parameters.AddWithValue("@UserName", userName);
                sqlCommand.Parameters.AddWithValue("@Password", password);

                //sqlCommand.Parameters.Add("@Role",SqlDbType.VarChar,6);

                // sqlCommand.Parameters["@Role"].Direction = ParameterDirection.Output;

                //param = new SqlParameter();
                //param.ParameterName = "@Role";
                //param.Value = null;
                //param.SqlDbType = System.Data.SqlDbType.VarChar;
                //sqlCommand.Parameters.Add(param);

                // sqlCommand.Parameters.Add(new SqlParameter("@Option", SqlDbType.Int).Value = option);
                try
                {
                     role = sqlCommand.ExecuteScalar().ToString();
                }
                catch (Exception)
                {
                    role = "NoUser";
                }
                    sqlConnection.Close();
                    return role;
                
            }
        }
    }
}
