using System;
using System.Data.SqlClient;
using System.Data;

namespace BankManagementSystem_DataAccessLayer
{
    public class clsUserData
    {
        public static bool FindByID(int UserID, ref string Username, ref string Password, ref short Permissions,
            ref int PersonID, ref string FirstName, ref string LastName, ref int NationalityID,
            ref byte Age, ref string Email, ref string Phone)
        {
            bool IsFound = default(bool);

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"SELECT Users.*, Persons.FirstName, Persons.LastName, Persons.NationalityID, Persons.Age, Persons.Email, Persons.Phone
                             FROM Users JOIN Persons ON Users.PersonID = Persons.PersonID WHERE UserID = @UserID";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@UserID", UserID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    Username = (string)reader["Username"];
                    Password = (string)reader["Password"];
                    Permissions = (short)reader["Permission"];
                    PersonID = (int)reader["PersonID"];
                    FirstName = (string)reader["FirstName"];
                    LastName = (string)reader["LastName"];
                    NationalityID = (int)reader["NationalityID"];
                    Age = (byte)reader["Age"];
                    Email = (string)reader["Email"];
                    Phone = (string)reader["Phone"];
                    IsFound = true;
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

            return IsFound;
        }

        public static bool FindByUsername(ref int UserID, string Username, ref string Password, ref short Permissions,
            ref int PersonID, ref string FirstName, ref string LastName, ref int NationalityID,
            ref byte Age, ref string Email, ref string Phone)
        {
            bool IsFound = default(bool);

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"SELECT Users.*, Persons.FirstName, Persons.LastName, Persons.NationalityID, Persons.Age, Persons.Email, Persons.Phone
                             FROM Users JOIN Persons ON Users.PersonID = Persons.PersonID WHERE Username = @Username";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@Username", Username);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    UserID = (int)reader["UserID"];
                    Password = (string)reader["Password"];
                    Permissions = (short)reader["Permission"];
                    PersonID = (int)reader["PersonID"];
                    FirstName = (string)reader["FirstName"];
                    LastName = (string)reader["LastName"];
                    NationalityID = (int)reader["NationalityID"];
                    Age = (byte)reader["Age"];
                    Email = (string)reader["Email"];
                    Phone = (string)reader["Phone"];
                    IsFound = true;
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

            return IsFound;
        }

        public static bool FindByUsernameAndPassword(ref int UserID, string Username, string Password, ref short Permissions,
            ref int PersonID, ref string FirstName, ref string LastName, ref int NationalityID,
            ref byte Age, ref string Email, ref string Phone)
        {
            bool IsFound = default(bool);

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"SELECT Users.*, Persons.FirstName, Persons.LastName, Persons.NationalityID, Persons.Age, Persons.Email, Persons.Phone
                             FROM Users JOIN Persons ON Users.PersonID = Persons.PersonID
                             WHERE Username = @Username AND Password = @Password";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@Username", Username);
            command.Parameters.AddWithValue("@Password", Password);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    UserID = (int)reader["UserID"];
                    Permissions = (short)reader["Permission"];
                    PersonID = (int)reader["PersonID"];
                    FirstName = (string)reader["FirstName"];
                    LastName = (string)reader["LastName"];
                    NationalityID = (int)reader["NationalityID"];
                    Age = (byte)reader["Age"];
                    Email = (string)reader["Email"];
                    Phone = (string)reader["Phone"];
                    IsFound = true;
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

            return IsFound;
        }

        public static int Add(string Username, string Password, short Permissions, int PersonID)
        {
            int AddedID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"INSERT INTO Users (Username, Password, Permission, PersonID)
                             VALUES (@Username, @Password, @Permission, @PersonID);
                             SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@Username", Username);
            command.Parameters.AddWithValue("@Password", Password);
            command.Parameters.AddWithValue("@Permission", Permissions);
            command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                connection.Open();

                object Result = command.ExecuteScalar();

                if (Result != null && int.TryParse(Result.ToString(), out int NewInsertedID))
                    AddedID = NewInsertedID;
            }

            catch
            {
                throw;
            }

            finally
            {
                connection.Close();
            }

            return AddedID;
        }

        public static bool Update(int UserID, string Username, string Password, short Permission)
        {
            bool IsUpdated = default(bool);

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"UPDATE Users SET Username = @Username, Password = @Password, Permission = @Permission
                             WHERE UserID = @UserID";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@UserID", UserID);
            command.Parameters.AddWithValue("@Username", Username);
            command.Parameters.AddWithValue("@Password", Password);
            command.Parameters.AddWithValue("@Permission", Permission);

            try
            {
                connection.Open();

                int AffectedRows = command.ExecuteNonQuery();

                if (AffectedRows > 0)
                    IsUpdated = true;
            }

            catch
            {
                throw;
            }

            finally
            {
                connection.Close();
            }

            return IsUpdated;
        }

        public static bool Delete(int UserID)
        {
            bool IsDeleted = default(bool);

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "DELETE FROM Users WHERE UserID = @UserID";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@UserID", UserID);

            try
            {
                connection.Open();

                int AffectedRows = command.ExecuteNonQuery();

                if (AffectedRows > 0)
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

        public static bool Delete(string Username)
        {
            bool IsDeleted = default(bool);

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "DELETE FROM Users WHERE Username = @Username";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@Username", Username);

            try
            {
                connection.Open();

                int AffectedRows = command.ExecuteNonQuery();

                if (AffectedRows > 0)
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

        public static DataTable LoadUsersList()
        {
            DataTable Table = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "SELECT * FROM Users";

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

        public static bool IsUserExist(string Username, string Password)
        {
            bool IsFound = default(bool);

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "SELECT Found = 1 FROM Users WHERE Username = @Username AND Password = @Password";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@Username", Username);
            command.Parameters.AddWithValue("@Password", Password);

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

        public static int GetUsersNumber()
        {
            int Total = default(int);

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "SELECT COUNT(*) AS TotalUsers FROM Users";

            SqlCommand command = new SqlCommand(Query, connection);

            try
            {
                connection.Open();

                object Result = command.ExecuteScalar();

                Total = Convert.ToInt32(Result);
            }

            catch
            {
                throw;
            }

            finally
            {
                connection.Close();
            }

            return Total;
        }

        public static string FindPassword(int UserID)
        {
            string Password = default(string);

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "SELECT Password FROM Users WHERE UserID = @UserID";

            SqlCommand command = new SqlCommand(Query, connection);

            try
            {
                connection.Open();

                object Result = command.ExecuteScalar();

                if (Result != null)
                    Password = Result.ToString();
            }

            catch
            {
                throw;
            }

            finally
            {
                connection.Close();
            }

            return Password;
        }
    }
}