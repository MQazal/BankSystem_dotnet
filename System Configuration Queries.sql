CREATE DATABASE BankManagementSystem;

USE BankManagementSystem;

CREATE TABLE Persons(
PersonID INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
FirstName NVARCHAR(30) NOT NULL,
LastName NVARCHAR(30) NOT NULL,
Age TINYINT NOT NULL CHECK(Age > 18),
Email VARCHAR(255) NULL,
Phone VARCHAR(15) NOT NULL,
NationalityID INT REFERENCES Nationalities(NationalityID)
);

CREATE TABLE Clients(
ClientID INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
AccountNumber CHAR(4) NOT NULL UNIQUE,
PinCode CHAR(4) NOT NULL,
AccountBalance DECIMAL NOT NULL CHECK(AccountBalance >= 0),
PersonID INT REFERENCES Persons(PersonID)
);

CREATE TABLE Users(
UserID INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
Username VARCHAR(20) NOT NULL UNIQUE,
Password VARCHAR(20) NOT NULL,
Permission SMALLINT NOT NULL,
PersonID INT REFERENCES Persons(PersonID)
);

CREATE TABLE Logins(
LoginID INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
LoginDateTime DATETIME NOT NULL,
UserID INT REFERENCES Users(UserID)
);

CREATE TABLE Transfers(
TransferID INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
TransferDateTime DATETIME NOT NULL,
SenderClientID INT REFERENCES Clients(ClientID),
ReceiverClientID INT REFERENCES Clients(ClientID),
Amount DECIMAL NOT NULL CHECK(Amount > 0),
UserID INT REFERENCES Users(UserID),
CONSTRAINT CHK_Transfer_Clients CHECK(ReceiverClientID <> SenderClientID)
);

CREATE TABLE Currencies(
CurrencyID INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
Country VARCHAR(50) NOT NULL,
Name VARCHAR(50) NOT NULL,
Code CHAR(3) NOT NULL,
ExchangeRateUSA DECIMAL NOT NULL
);

CREATE TABLE Nationalities(
NationalityID INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
NationalityName VARCHAR(15) NOT NULL
)

SELECT * FROM Persons;
SELECT * FROM Users;
SELECT * FROM Clients;
SELECT * FROM Transfers;
SELECT * FROM Currencies;
SELECT * FROM Logins;
SELECT * FROM Nationalities;