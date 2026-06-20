using System;
using System.Data.SqlClient;
using System.Data;

namespace BankManagementSystem_DataAccessLayer
{
    public class clsLoginData
    {
        public static void Add(DateTime LoginDateTime, int UserID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"INSERT INTO Logins (LoginDateTime, UserID) VALUES (@LoginDateTime, @UserID)";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@LoginDateTime", LoginDateTime);
            command.Parameters.AddWithValue("@UserID", UserID);

            try
            {
                connection.Open();
                command.ExecuteScalar();
            }

            catch
            {
                throw;
            }

            finally
            {
                connection.Close();
            }
        }

        public static DataTable LoadLogList()
        {
            DataTable Table = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"SELECT * FROM Logins";

            SqlCommand command = new SqlCommand(Query, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    Table.Load(reader);
                }

                reader.Close();
            }

            catch
            {
                throw;
            }

            finally
            {
                connection.Close();
            }

            return Table;
        }

        public static bool IsExist(int UserID)
        {
            bool IsFound = default(bool);

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"SELECT TOP 1 Found = 1 FROM Logins WHERE UserID = @UserID";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@UserID", UserID);

            try
            {
                connection.Open();

                object Result = command.ExecuteScalar();

                if (Result != null)
                    IsFound = true;
            }

            catch
            {
                throw;
            }

            finally
            {
                connection.Close();
            }

            return IsFound;
        }

        public static bool Delete(int UserID)
        {
            bool IsDeleted = default(bool);

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "DELETE FROM Logins WHERE UserID = @UserID";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@UserID", UserID);

            try
            {
                connection.Open();

                if (command.ExecuteNonQuery() > 0)
                    IsDeleted = true;
            }

            catch
            {
                throw;
            }

            finally
            {
                connection.Close();
            }

            return IsDeleted;
        }
    }
}