using System;
using BankManagementSystem_DataAccessLayer;
using System.Data;

namespace BankManagementSystem_BusinessLogicLayer
{
    public class clsClient : clsPerson
    {
        private int _ClientID { set; get; }
        public int ClientID
        {
            get { return _ClientID; }
        }
        public string AccountNumber { set; get; }
        public string PinCode { set; get; }
        public decimal AccountBalance { set; get; }
        enum enMode { AddNew, Update }
        enMode _Mode;

        public clsClient()
        {
            this.FirstName = default(string);
            this.LastName = default(string);
            this.NationalityID = default(int);
            this.Age = default(byte);
            this.Email = default(string);
            this.Phone = default(string);
            this.AccountNumber = default(string);
            this.PinCode = default(string);
            this.AccountBalance = default(decimal);
            this._Mode = enMode.AddNew;
        }

        private clsClient(int PersonID, string FirstName, string LastName, int NationalityID, byte Age, string Email, string Phone,
            int ClientID, string AccountNumber, string PinCode, decimal AccountBalance) :
            base (PersonID, FirstName, LastName, NationalityID, Age, Email, Phone)
        {
            this._ClientID = ClientID;
            this.AccountNumber = AccountNumber;
            this.PinCode = PinCode;
            this.AccountBalance = AccountBalance;
            _Mode = enMode.Update;
        }

        public new static clsClient Find(int ClientID)
        {
            int PersonID = default(int), NationalityID = default(int);
            byte Age = default(byte);
            decimal AccountBalance = default(decimal);
            string FirstName = "", LastName = "", Email = "", Phone = "", AccountNumber = "", PinCode = "";

            if (clsClientData.FindByID(ClientID, ref AccountNumber, ref PinCode, ref AccountBalance,
                ref PersonID, ref FirstName, ref LastName, ref NationalityID, ref Age, ref Email, ref Phone))
            {
                return new clsClient(PersonID, FirstName, LastName, NationalityID, Age, Email, Phone,
                                     ClientID, AccountNumber, PinCode, AccountBalance);
            }
                return null;
        }

        public static clsClient Find(string AccountNumber)
        {
            int PersonID = default(int), ClientID = default(int), NationalityID = default(int);
            byte Age = default(byte);
            decimal AccountBalance = default(decimal);
            string FirstName = "", LastName = "", Email = "", Phone = "", PinCode = "";

            if (clsClientData.FindByAccountNumber(ref ClientID, AccountNumber, ref PinCode, ref AccountBalance,
                ref PersonID, ref FirstName, ref LastName, ref NationalityID, ref Age, ref Email, ref Phone))
            {
                return new clsClient(PersonID, FirstName, LastName, NationalityID, Age, Email, Phone,
                                     ClientID, AccountNumber, PinCode, AccountBalance);
            }
                return null;
        }

        private bool _AddNewClient()
        {
            if (this._AddNewPerson())
            {
                this._ClientID = clsClientData.Add(this.AccountNumber, this.PinCode, this.AccountBalance, this.PersonID);
                return (this._ClientID != -1);
            }
            return false;
        }

        private bool _UpdateClient()
        {
            if (this._UpdatePerson())
            {
                return clsClientData.Update(this._ClientID, this.AccountNumber, this.PinCode, this.AccountBalance);
            }
            return false;
        }

        public override bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    if (_AddNewClient())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    else
                        return false;

                case enMode.Update:
                    return _UpdateClient();
            }
            return false;
        }

        public new static bool Delete(int ClientID)
        {
            if (clsTransfer.IsExist(ClientID))
            {
                clsTransfer.Delete(ClientID);
            }
            int PersonID = clsClient.Find(ClientID).PersonID;
            if (clsClientData.Delete(ClientID))
            {
                return clsPerson.Delete(PersonID);
            }
            return false;
        }

        public new static bool IsExist(int ClientID)
        {
            return clsClientData.IsExist(ClientID);
        }

        public static DataTable GetClientsList()
        {
            return clsClientData.LoadClientsList();
        }

        public bool Deposite(decimal DepositAmount)
        {
            this.AccountBalance += DepositAmount;
            return this.Save();
        }

        public bool Withdraw(decimal WithdrawAmount)
        {
            if (this.AccountBalance >= WithdrawAmount)
            {
                this.AccountBalance -= WithdrawAmount;
                return this.Save();
            }
            return false;
        }

        private bool _IsClientEmpty(clsClient Client)
        {
            return Client == null;
        }

        private bool _RegisterTransferLog(decimal TransferAmount, int SenderID, int ReceiverID, int UserID)
        {
            return new clsTransfer(DateTime.Now, SenderID, ReceiverID, TransferAmount, UserID).Save();
        }

        public bool Transfer(decimal TransferAmount, ref clsClient Receiver, int UserID)
        {
            if (_IsClientEmpty(this) || _IsClientEmpty(Receiver))
                return false;

            if (TransferAmount > this.AccountBalance)
                return false;

            if (Receiver.Deposite(TransferAmount))
            {
                if (this.Withdraw(TransferAmount))
                {
                    if (_RegisterTransferLog(TransferAmount, this._ClientID, Receiver._ClientID, UserID))
                        return true;
                }
            }
            return false;
        }

        public static int GetTotalBalances()
        {
           return clsClientData.GetTotalBalances();
        }

        public static int GetTotalClients()
        {
            return clsClientData.GetClientsNumber();
        }
    }
}