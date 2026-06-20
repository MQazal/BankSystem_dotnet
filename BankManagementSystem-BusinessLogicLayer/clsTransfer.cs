using System;
using BankManagementSystem_DataAccessLayer;
using System.Data;

namespace BankManagementSystem_BusinessLogicLayer
{
    public class clsTransfer
    {
        private int _TransferID;
        public int TransferID
        {
            get { return _TransferID; }
        }
        public DateTime TransferDate { get; set; }
        public int SenderClientID { get; set; }
        public int ReceiverClientID { get; set; }
        public decimal Amount { get; set; }
        public int UserID { get; set; }
        private enum enMode { AddNew, Update };
        private enMode _Mode;

        public clsTransfer()
        {
            TransferDate = default(DateTime);
            SenderClientID = default(int);
            ReceiverClientID = default(int);
            Amount = default(decimal);
            UserID = default(int);
            _Mode = enMode.AddNew;
        }

        public clsTransfer(DateTime TransferDate, int SenderClientID, int ReceiverClientID, decimal Amount, int UserID)
        {
            this.TransferDate = TransferDate;
            this.SenderClientID = SenderClientID;
            this.ReceiverClientID = ReceiverClientID;
            this.Amount = Amount;
            this.UserID = UserID;
            _Mode = enMode.AddNew;
        }

        private clsTransfer(int TransferID, DateTime TransferDate, int SenderClientID, int ReceiverClientID,
            decimal Amount, int UserID)
        {
            _TransferID = TransferID;
            this.TransferDate = TransferDate;
            this.SenderClientID = SenderClientID;
            this.ReceiverClientID = ReceiverClientID;
            this.Amount = Amount;
            this.UserID = UserID;
            _Mode = enMode.Update;
        }

        private bool _AddNewTransfer()
        {
            _TransferID = clsTransferData.Add(this.TransferDate, this.SenderClientID, this.ReceiverClientID,
                this.Amount, this.UserID);
            return (_TransferID != -1);
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    if (_AddNewTransfer())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    return false;
                default:
                    return false;
            }
        }

        public static DataTable GetTransfersList()
        {
            return clsTransferData.LoadTransfersList();
        }

        public static int GetTransfersNumber()
        {
            return clsTransferData.GetTransfersNumber();
        }

        public static bool Delete(int ClientID)
        {
            return clsTransferData.Delete(ClientID);
        }

        public static bool IsExist(int ClientID)
        {
            return clsTransferData.IsExist(ClientID);
        }
    }
}