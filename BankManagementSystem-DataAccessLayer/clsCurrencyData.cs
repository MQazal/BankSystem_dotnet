using System;
using System.Data;
using System.Data.SqlClient;

namespace BankManagementSystem_DataAccessLayer
{
    public class clsCurrencyData
    {
        public static bool FindByCurrencyID(int CurrencyID, ref string CountryName,
            ref string CurrencyName, ref string Code, ref decimal ExchangeRateUSA)
        {
            bool IsFound = default(bool);

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"SELECT * FROM Currencies WHERE CurrencyID = @CurrencyID";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@CurrencyID", CurrencyID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    CountryName = (string)reader["Country"];
                    CurrencyName = (string)reader["Name"];
                    Code = (string)reader["Code"];
                    ExchangeRateUSA = (decimal)reader["ExchangeRateUSA"];
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

        public static bool FindByCode(ref int CurrencyID, ref string CountryName,
           ref string CurrencyName, string Code, ref decimal ExchangeRateUSA)
        {
            bool IsFound = default(bool);

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"SELECT * FROM Currencies WHERE Code = @Code";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@Code", Code);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    CurrencyID = (int)reader["CurrencyID"];
                    CountryName = (string)reader["Country"];
                    CurrencyName = (string)reader["Name"];
                    ExchangeRateUSA = (decimal)reader["ExchangeRateUSA"];
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

        public static DataTable LoadCurrenciesList()
        {
            DataTable Table = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "SELECT * FROM Currencies";

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

        public static bool UpdateExchangeRateUSA(decimal NewExchangeRateUSA, int CurrencyID)
        {
            bool IsUpdated = default(bool);

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "UPDATE Currencies SET ExchangeRateUSA = @NewExchangeRateUSA WHERE CurrencyID = @CurrencyID";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@NewExchangeRateUSA", NewExchangeRateUSA);
            command.Parameters.AddWithValue("@CurrencyID", CurrencyID);

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
    }
}