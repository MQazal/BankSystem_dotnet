using System;
using System.Data.SqlClient;
using System.Data;

namespace BankManagementSystem_DataAccessLayer
{
    public class clsClientData
    {
        public static bool FindByID(int ClientID, ref string AccountNumber, ref string PinCode, ref decimal AccountBalance,
            ref int PersonID, ref string FirstName, ref string LastName, ref int NationalityID,
            ref byte Age, ref string Email, ref string Phone)
        {
            bool IsFound = default(bool);

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"SELECT Clients.*, Persons.FirstName, Persons.LastName, Persons.NationalityID,
                             Persons.Age, Persons.Email, Persons.Phone FROM Clients
                             INNER JOIN Persons ON Clients.PersonID = Persons.PersonID WHERE Clients.ClientID = @ClientID";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@ClientID", ClientID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    AccountNumber = (string)reader["AccountNumber"];
                    PinCode = (string)reader["PinCode"];
                    AccountBalance = Convert.ToDecimal(reader["AccountBalance"]);
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

        public static bool FindByAccountNumber(ref int ClientID, string AccountNumber, ref string PinCode, ref decimal AccountBalance,
            ref int PersonID, ref string FirstName, ref string LastName, ref int NationalityID,
            ref byte Age, ref string Email, ref string Phone)
        {
            bool IsFound = default(bool);

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"SELECT Clients.*, Persons.FirstName, Persons.LastName, Persons.NationalityID,
                             Persons.Age, Persons.Email, Persons.Phone FROM Clients
                             INNER JOIN Persons ON Clients.PersonID = Persons.PersonID WHERE Clients.AccountNumber = @AccountNumber";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@AccountNumber", AccountNumber);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    ClientID = (int)reader["ClientID"];
                    PinCode = (string)reader["PinCode"];
                    AccountBalance = Convert.ToDecimal(reader["AccountBalance"]);
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

        public static int Add(string AccountNumber, string PinCode, decimal AccountBalance, int PersonID)
        {
            int AddedID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"INSERT INTO Clients (AccountNumber, PinCode, AccountBalance, PersonID)
                            VALUES (@AccountNumber, @PinCode, @AccountBalance, @PersonID);
                            SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@AccountNumber", AccountNumber);
            command.Parameters.AddWithValue("@PinCode", PinCode);
            command.Parameters.AddWithValue("@AccountBalance", AccountBalance);
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

        public static bool Update(int ClientID, string AccountNumber, string PinCode, decimal AccountBalance)
        {
            bool IsUpdated = default(bool);

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"UPDATE Clients SET AccountNumber = @AccountNumber, PinCode = @PinCode, AccountBalance = @AccountBalance
                             WHERE ClientID = @ClientID";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@ClientID", ClientID);
            command.Parameters.AddWithValue("@AccountNumber", AccountNumber);
            command.Parameters.AddWithValue("@PinCode", PinCode);
            command.Parameters.AddWithValue("@AccountBalance", AccountBalance);

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

        public static bool Delete(int ClientID)
        {
            bool IsDeleted = default(bool);

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "DELETE FROM Clients WHERE ClientID = @ClientID";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@ClientID", ClientID);

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

        public static bool IsExist(int ClientID)
        {
            bool IsFound = default(bool);

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "SELECT Found = 1 FROM Clients WHERE ClientID = @ClientID";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@ClientID", ClientID);

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

        public static DataTable LoadClientsList()
        {
            DataTable Table = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "SELECT * FROM Clients";

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

        public static int GetTotalBalances()
        {
            int Total = default(int);

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "SELECT SUM(Clients.AccountBalance) AS TotalBalances FROM Clients";

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

        public static int GetClientsNumber()
        {
            int Total = default(int);

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "SELECT COUNT(*) AS NumberOfClients FROM Clients";

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
    }
}