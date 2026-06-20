using BankManagementSystem_DataAccessLayer;
using System;
using System.Data;
using System.Runtime.CompilerServices;

namespace BankManagementSystem_BusinessLogicLayer
{
    public class clsUser : clsPerson
    {
        protected int _UserID { set; get; }
        public int UserID
        {
            get { return _UserID; }
        }
        public string Username { set; get; }
        public string Password { set; get; }
        private static byte _EncryptionKey = 5;

        public enum enPermission
        {
            HaveAllPermissions = -1, BlockUserPermissions = 0,
            pAccessToClientsScreen = 1, pAddNewClient = 2, pUpdateClientInfo = 4, pDeleteClient = 8,
            pAccessToTransactionsScreen = 16, pAccessToUsersScreen = 32, pListLoginRegister = 64,
            pAccessToCurrencyExchangeScreen = 128
        }
        protected enPermission _enumPermission;

        public struct stPermissions
        {
            public bool HaveAllPermissions;
            public bool BlockUserPermissions;
            public bool pAccessToClientsScreen;
            public bool pAddNewClient;
            public bool pUpdateClientInfo;
            public bool pDeleteClient;
            public bool pAccessToTransactionsScreen;
            public bool pAccessToUsersScreen;
            public bool pListLoginRegister;
            public bool pAccessToCurrencyExchangeScreen;
        }

        public stPermissions Permission;

        private short _GetPermissionsValue()
        {
            short Value = 0;

            if (this.Permission.HaveAllPermissions)
                return (short)enPermission.HaveAllPermissions;

            if (this.Permission.BlockUserPermissions)
                return (short)enPermission.BlockUserPermissions;

            if (this.Permission.pAccessToClientsScreen)
                Value += (short)enPermission.pAccessToClientsScreen;

            if (this.Permission.pAddNewClient)
                Value += (short)enPermission.pAddNewClient;

            if (this.Permission.pUpdateClientInfo)
                Value += (short)enPermission.pUpdateClientInfo;

            if (this.Permission.pDeleteClient)
                Value += (short)enPermission.pDeleteClient;

            if (this.Permission.pAccessToTransactionsScreen)
                Value += (short)enPermission.pAccessToTransactionsScreen;

            if (this.Permission.pAccessToUsersScreen)
                Value += (short)enPermission.pAccessToUsersScreen;

            if (this.Permission.pListLoginRegister)
                Value += (short)enPermission.pListLoginRegister;

            if (this.Permission.pAccessToCurrencyExchangeScreen)
                Value += (short)enPermission.pAccessToCurrencyExchangeScreen;

            return Value;
        }

        public short PermissionsValue
        {
            get { return (short)_enumPermission; }
        }

        enum enMode { AddNew, Update }
        enMode _Mode;

        public clsUser()
        {
            this.FirstName = default(string);
            this.LastName = default(string);
            this.NationalityID = default(int);
            this.Age = default(byte);
            this.Email = default(string);
            this.Phone = default(string);
            this.Username = default(string);
            this.Password = default(string);
            _Mode = enMode.AddNew;
        }

        protected clsUser(int PersonID, string FirstName, string LastName, int NationalityID, byte Age, string Email, string Phone,
            int UserID, string Username, string Password, short Permission) :
            base(PersonID, FirstName, LastName, NationalityID, Age, Email, Phone)
        {
            this._UserID = UserID;
            this.Username = Username;
            this.Password = _DecryptPassword(Password); // Encrypted password from database
            this._enumPermission = (enPermission)Permission;
            _Mode = enMode.Update;
        }

        private static int _GetASCII(char Letter)
        {
            return (int)Letter;
        }

        private static char _GetLetter(int ASCII)
        {
            return (char)ASCII;
        }

        private static string _EncryptPassword(string OriginalPassword)
        {
            string EncryptedPassword = default(string);
            for (byte i = 0; i < OriginalPassword.Length; i++)
            {
                EncryptedPassword += _GetLetter(_GetASCII(OriginalPassword[i]) + _EncryptionKey);
            }
            return EncryptedPassword;
        }

        public static string _DecryptPassword(string EncryptedPassword)
        {
            string DecryptedPassword = default(string);
            for (byte i = 0; i < EncryptedPassword.Length; i++)
            {
                DecryptedPassword += _GetLetter(_GetASCII(EncryptedPassword[i]) - _EncryptionKey);
            }
            return DecryptedPassword;
        }

        private bool _AddNewUser()
        {
            if (this._AddNewPerson())
            {
                this._UserID = clsUserData.Add(this.Username, _EncryptPassword(this.Password), this._GetPermissionsValue(), this.PersonID);
                return (this.UserID != -1);
            }
            return false;
        }

        public new static clsUser Find(int UserID)
        {
            int PersonID = default(int), NationalityID = default(int);
            byte Age = default(byte);
            short Permissions = default(short);
            string FirstName = "", LastName = "", Email = "", Phone = "", Username = "", Password = "";
            if (clsUserData.FindByID(UserID, ref Username, ref Password, ref Permissions, ref PersonID, ref FirstName,
                ref LastName, ref NationalityID, ref Age, ref Email, ref Phone))
            {
                return new clsUser(PersonID, FirstName, LastName, NationalityID, Age, Email, Phone, UserID, Username, Password, Permissions);
            }
            return null;
        }

        public static clsUser Find(string Username)
        {
            int PersonID = default(int), UserID = default(int), NationalityID = default(int);
            byte Age = default(byte);
            short Permissions = default(short);
            string FirstName = "", LastName = "", Email = "", Phone = "", Password = "";
            if (clsUserData.FindByUsername(ref UserID, Username, ref Password, ref Permissions, ref PersonID, ref FirstName,
                ref LastName, ref NationalityID, ref Age, ref Email, ref Phone))
            {
                return new clsUser(PersonID, FirstName, LastName, NationalityID, Age, Email, Phone, UserID, Username, Password, Permissions);
            }
            return null;
        }

        public static clsUser Find(string Username, string Password)
        {
            int PersonID = default(int), UserID = default(int), NationalityID = default(int);
            byte Age = default(byte);
            short Permissions = default(short);
            string FirstName = "", LastName = "", Email = "", Phone = "";
            if (clsUserData.FindByUsernameAndPassword(ref UserID, Username, _EncryptPassword(Password), ref Permissions, ref PersonID, ref FirstName,
                ref LastName, ref NationalityID, ref Age, ref Email, ref Phone))
            {
                return new clsUser(PersonID, FirstName, LastName, NationalityID, Age, Email, Phone, UserID, Username, _EncryptPassword(Password), Permissions);
            }
            return null;
        }

        private bool _UpdateUser()
        {
            if (this._UpdatePerson())
            {
                return clsUserData.Update(this.UserID, this.Username, _EncryptPassword(this.Password), this._GetPermissionsValue());
            }
            return false;
        }

        public override bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    if (_AddNewUser())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    return false;

                case enMode.Update:
                    return _UpdateUser();
            }
            return false;
        }

        public new static bool Delete(int UserID)
        {
            if (clsLogin.IsExist(UserID))
            {
                clsLogin.Delete(UserID);
            }
            int PersonID = clsUser.Find(UserID).PersonID;
            if (clsUserData.Delete(UserID))
            {
                return clsPerson.Delete(PersonID);
            }
            return false;
        }

        public static bool Delete(string Username)
        {
            int PersonID = clsUser.Find(Username).PersonID;
            if (clsUserData.Delete(Username))
            {
                return clsPerson.Delete(PersonID);
            }
            return false;
        }

        public static DataTable GetUsersList()
        {
            return clsUserData.LoadUsersList();
        }

        public static bool IsExist(string Username, string Password)
        {
            return clsUserData.IsUserExist(Username, _EncryptPassword(Password));
        }

        public static int GetTotalUsers()
        {
            return clsUserData.GetUsersNumber();
        }

        public static clsUser IsUserValid(string Username, string Password)
        {
            return clsUser.Find(Username, Password);
        }

        private string FindPassword(int UserID)
        {
            return _DecryptPassword(clsUserData.FindPassword(UserID));
        }

        public bool CheckAccessPermission(enPermission ScreenPermission)
        {
            if (this._enumPermission == enPermission.HaveAllPermissions)
                return true;
            else if (this._enumPermission == enPermission.BlockUserPermissions)
                return false;
            else
                return (ScreenPermission & this._enumPermission) == ScreenPermission;
        }
    }
}