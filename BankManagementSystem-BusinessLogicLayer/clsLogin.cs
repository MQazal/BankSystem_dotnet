using System;
using System.Data;
using BankManagementSystem_DataAccessLayer;

namespace BankManagementSystem_BusinessLogicLayer
{
    public class clsLogin
    {
        public static void AddLogin(DateTime LoginDateTime, int UserID)
        {
            clsLoginData.Add(LoginDateTime, UserID);
        }

        public static DataTable GetLogList()
        {
            return clsLoginData.LoadLogList();
        }

        public static bool IsExist(int UserID)
        {
            return clsLoginData.IsExist(UserID);
        }

        public static bool Delete(int UserID)
        {
            return clsLoginData.Delete(UserID);
        }
    }
}