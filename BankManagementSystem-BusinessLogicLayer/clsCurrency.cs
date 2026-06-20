using System;
using System.Data;
using BankManagementSystem_DataAccessLayer;

namespace BankManagementSystem_BusinessLogicLayer
{
    public class clsCurrency
    {
        public int CurrencyID{ get; }
        public string CountryName { get; }
        public string CurrencyName {  get; }
        public string Code { get; }
        public decimal ExchangeRateUSA { set; get; }

        public clsCurrency()
        {
            this.CurrencyID = default(int);
            this.CountryName = default(string);
            this.CurrencyName = default(string);
            this.Code = default(string);
            this.ExchangeRateUSA = default(decimal);
        }

        private clsCurrency(int CurrencyID, string CountryName, string CurrencyName, string Code, decimal ExchangeRateUSA)
        {
            this.CurrencyID = CurrencyID;
            this.CountryName = CountryName;
            this.CurrencyName = CurrencyName;
            this.Code = Code;
            this.ExchangeRateUSA = ExchangeRateUSA;
        }

        public static clsCurrency Find(int CurrencyID)
        {
            string CountryName = "", CurrencyName = "", Code = "";
            decimal ExchangeRateUSA = default(decimal);
            if (clsCurrencyData.FindByCurrencyID(CurrencyID, ref CountryName, ref CurrencyName,
                ref Code, ref ExchangeRateUSA))
            {
                return new clsCurrency(CurrencyID, CountryName, CurrencyName, Code, ExchangeRateUSA);
            }
            return null;
        }

        public static clsCurrency Find(string Code)
        {
            int CurrencyID = default(int);
            string CountryName = "", CurrencyName = "";
            decimal ExchangeRateUSA = default(decimal);

            if (clsCurrencyData.FindByCode(ref CurrencyID, ref CountryName, ref CurrencyName,
                Code, ref ExchangeRateUSA))
            {
                return new clsCurrency(CurrencyID, CountryName, CurrencyName, Code, ExchangeRateUSA);
            }
            return null;
        }

        public static DataTable GetCurrenciesList()
        {
            return clsCurrencyData.LoadCurrenciesList();
        }

        public bool UpdateExchangeRateUSA(decimal NewExchangeRateUSA, int CurrencyID)
        {
            return clsCurrencyData.UpdateExchangeRateUSA(NewExchangeRateUSA, this.CurrencyID);
        }

        // Currency Calculator

        public decimal ConvertCurrencyToUSD(decimal Amount)
        {
            return Amount / this.ExchangeRateUSA;
        }

        public decimal ConvertToOtherCurrency(decimal Amount, decimal Currency2Rate)
        {
            return ConvertCurrencyToUSD(Amount) * Currency2Rate;
        }
    }
}