using System;
using BankManagementSystem_DataAccessLayer;

namespace BankManagementSystem_BusinessLogicLayer
{
    public class clsPerson
    {
        // Attributes/Fields
        protected int _PersonID { set; get; }
        public int PersonID
        {
            get { return _PersonID; }
        }
        public string FirstName { set; get; }
        public string LastName { set; get; }
        public int NationalityID { set; get; }
        public byte Age { set; get; }
        public string Email { set; get; }
        public string Phone { set; get; }
        enum enMode { AddNew, Update }
        enMode _Mode;

        // Default Constructor -> Add New Person
        public clsPerson()
        {
            this.FirstName = default(string);
            this.LastName = default(string);
            this.NationalityID = default(int);
            this.Age = default(byte);
            this.Email = default(string);
            this.Phone = default(string);
            _Mode = enMode.AddNew;
        }

        // Parametrized Constructor -> Find/Update
        protected clsPerson(int PersonID, string FirstName, string LastName, int NationalityID, byte Age, string Email, string Phone)
        {
            this._PersonID = PersonID;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.NationalityID = NationalityID;
            this.Age = Age;
            this.Email = Email;
            this.Phone = Phone;
            _Mode = enMode.Update;
        }

        public static clsPerson Find(int PersonID)
        {
            string FirstName = default(string), LastName = default(string),
                   Email = default(string), Phone = default(string);
            int NationalityID = default(int);
            byte Age = default(byte);

            if (clsPersonData.Find(PersonID, ref FirstName, ref LastName, ref NationalityID, ref Age, ref Email, ref Phone))
            {
                return new clsPerson(PersonID, FirstName, LastName, NationalityID, Age, Email, Phone);
            }
            return null;
        }

        protected bool _AddNewPerson()
        {
            this._PersonID = clsPersonData.Add(this.FirstName, this.LastName, this.NationalityID, this.Age, this.Email, this.Phone);
            return (this._PersonID != -1);
        }

        protected bool _UpdatePerson()
        {
            return clsPersonData.Update(this._PersonID, this.FirstName, this.LastName, this.NationalityID,
                this.Age, this.Email, this.Phone);
        }

        public static bool Delete(int PersonID)
        {
            return clsPersonData.Delete(PersonID);
        }

        public virtual bool Save()
        {
            switch(_Mode)
            {
                case enMode.AddNew:
                    if (_AddNewPerson())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    else
                        return false;

                case enMode.Update:
                    return _UpdatePerson();
            }

            return false;
        }

        public static bool IsExist(int PersonID)
        {
            return clsPersonData.IsExist(PersonID);
        }
    }
}