using System;
using BankManagementSystem_DataAccessLayer;
using System.Data;


namespace BankManagementSystem_BusinessLogicLayer
{
    public class clsNationality
    {
        public static DataTable GetNationalitiesList()
        {
            return clsNationalityData.LoadNationalitiesList();
        }
    }
}