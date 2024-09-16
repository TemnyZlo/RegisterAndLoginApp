﻿using RegistrationAndLoginApp.Models;
using System.Data.SqlClient;

namespace RegistrationAndLoginApp.Services
{
    public class UserDAO
    {

        string connectionString = @"Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=TestDatabase;
                                    Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust 
                                    Server Certificate=False;Application Intent=ReadWrite;Multi Subnet 
                                    Failover=False";


        public bool FindUserByNameAndPassword(UserModel user)
        {
            bool success = false;

            string sqlStatement = "SELECT * FROM dbo.Users WHERE username = @username AND password = @password";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command  = new SqlCommand(sqlStatement, connection);

                command.Parameters.Add("@username", System.Data.SqlDbType.VarChar, 40).Value = user.UserName;
                command.Parameters.Add("@password", System.Data.SqlDbType.VarChar, 40).Value = user.Password;

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        success = true;
                    }
                }
                catch (Exception e)
                { 
                    Console.WriteLine(e.Message);
                }

            }

            return success;

            //return true if found in DB
        }
    }
}
