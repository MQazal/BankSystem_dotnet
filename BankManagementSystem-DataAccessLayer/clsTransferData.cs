using System;
using System.Data;
using System.Data.SqlClient;

namespace BankManagementSystem_DataAccessLayer
{
    public class clsTransferData
    {
        public static int Add(DateTime TransferDateTime, int SenderClientID, int ReceiverClientID, decimal Amount, int UserID)
        {
            int AddedID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"INSERT INTO Transfers (TransferDateTime, SenderClientID, ReceiverClientID, Amount, UserID)
                             VALUES (@TransferDateTime, @SenderClientID, @ReceiverClientID, @Amount, @UserID);
                             SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@TransferDateTime", TransferDateTime);
            command.Parameters.AddWithValue("@SenderClientID", SenderClientID);
            command.Parameters.AddWithValue("@ReceiverClientID", ReceiverClientID);
            command.Parameters.AddWithValue("@Amount", Amount);
            command.Parameters.AddWithValue("@UserID", UserID);

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

        public static DataTable LoadTransfersList()
        {
            DataTable Table = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "SELECT * FROM Transfers";

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

        public static int GetTransfersNumber()
        {
            int Total = default(int);

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "SELECT COUNT(*) AS TotalTransfers FROM Transfers";

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

        public static bool Delete(int ClientID)
        {
            bool IsDeleted = default(bool);

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "DELETE FROM Transfers WHERE SenderClientID = @ClientID OR ReceiverClientID = @ClientID";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@ClientID", ClientID);

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

        public static bool IsExist(int ClientID)
        {
            bool IsFound = default(bool);

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"SELECT TOP 1 Found = 1 FROM Transfers WHERE
                             SenderClientID = @ClientID OR ReceiverClientID = @ClientID";

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
    }
}