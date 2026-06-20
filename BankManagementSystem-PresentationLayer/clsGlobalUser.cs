using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using BankManagementSystem_BusinessLogicLayer;


namespace BankManagementSystem_PresentationLayer
{
    public class clsGlobalUser : clsUser
    {
        public static clsGlobalUser CurrentUser;

        public clsGlobalUser(clsUser ValidUser)
        {
            this._PersonID = ValidUser.PersonID;
            this.FirstName = ValidUser.FirstName;
            this.LastName = ValidUser.LastName;
            this.NationalityID = ValidUser.NationalityID;
            this.Age = ValidUser.Age;
            this.Email = ValidUser.Email;
            this.Phone = ValidUser.Phone;
            this._UserID = ValidUser.UserID;
            this.Username = ValidUser.Username;
            this.Password = ValidUser.Password;
            this._enumPermission = (enPermission)ValidUser.PermissionsValue;
        }
    }
}