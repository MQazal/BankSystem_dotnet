INSERT INTO Persons (FirstName, LastName, Nationality, Age, Email, Phone) VALUES
('Admin', 'Sys', NULL, 24, 'Sys@.com', '0000000');

INSERT INTO Users (Username, Password, Permission, PersonID) VALUES ('Admin', 'Admin19', 2, 9);

EXEC sp_rename 'Login', 'Logins';

EXEC sp_rename 'Transfer', 'Transfers';

EXEC sp_rename 'Persons.Natioanlity', 'Nationality', 'COLUMN';

SELECT * FROM Users WHERE Users.Username = 'Wiliam' AND Users.Password = 'NewP@ss99';

DELETE FROM Users WHERE UserID = 1;

DELETE FROM Transfers WHERE TransferID IN (12);

DELETE FROM Users WHERE Users.UserID BETWEEN 2 AND 22;

SELECT * FROM Persons;

DELETE FROM Persons WHERE PersonID IN (33,35,37);

INSERT INTO Currencies (Country, Name, Code, ExchangeRateUSA) VALUES
    ('United States of America', 'US Dollar', 'USD', 1.000000),
    ('fghanistan', 'Afghanistan Afghani', 'AFN', 64.770000).......................

	DELETE FROM Persons WHERE Persons.PersonID IN (2,3,4);

	SELECT * FROM Persons WHERE PersonID = 6;

	DELETE FROM Clients WHERE ClientID = 3;

	DELETE FROM Persons WHERE Persons.PersonID = 7;
	
SELECT Clients.*, Persons.FirstName, Persons.LastName, Persons.Nationality, Persons.Age, Persons.Email, Persons.Phone
FROM Clients INNER JOIN Persons ON Clients.PersonID = Persons.PersonID
WHERE Clients.ClientID = 1;

SELECT Users.*, Persons.FirstName, Persons.LastName, Persons.Nationality, Persons.Age, Persons.Email, Persons.Phone
FROM Users JOIN Persons ON Users.PersonID = Persons.PersonID;

SELECT * FROM Currencies WHERE Currencies.Code = 'ALL';

SELECT Currencies.CurrencyID FROM Currencies WHERE Currencies.Code = 'ALL';

SELECT Users.*, Persons.FirstName, Persons.LastName, Persons.Nationality, Persons.Age, Persons.Email, Persons.Phone
FROM Users JOIN Persons ON Users.PersonID = Persons.PersonID
WHERE Users.Username = 'MrK' AND Users.Password = 'P678';

SELECT SUM(Clients.AccountBalance) AS TotalBalances FROM Clients;

SELECT COUNT(*) AS NumberOfClients FROM Clients;

SELECT COUNT(*) AS TotalTransfers FROM Transfers;

SELECT COUNT(*) AS TotalUsers FROM Users;

----------------------------

INSERT INTO Persons (FirstName, LastName, Age, Email, Phone, NationalityID)
VALUES
('John',      'Smith',    28,   'john.smith@email.com',   '5551001001', 1),
('Michael',   'Johnson',  35,   'michael.j@email.com',    '5551001002', 1),
('Emma',      'Brown',    24,   'emma.brown@email.com',   '5551001003', 3),
('Olivia',    'Wilson',   31,   'olivia.w@email.com',     '5551001004', 2),
('Ahmet',     'Yilmaz',   29,   'ahmet.y@email.com',      '5551001005', 7),
('Sophia',    'Taylor',   26,   'sophia.t@email.com',     '5551001006', 3),
('James',     'Anderson', 42,   'james.a@email.com',      '5551001007', 2),
('Charlotte', 'Martin',   23,   'charlotte.m@email.com',  '5551001008', 5),
('William',   'Thomas',   38,   'william.t@email.com',    '5551001009', 3),
('Mehmet',    'Demir',    33,   'mehmet.d@email.com',     '5551001010', 7),
('Jhon',      'Mickle',   20,   'Jhon.m@email.com',       '5551001011', 1),
('Lucas',     'Dubois',   40,   'lucas.d@email.com',      '5551001012', 5),
('Keven',     'Wiliam',   50,   'Keven.w@email.com',      '5551001013', 4),
('Daniel',    'Kowalski', 55,   'daniel.k@email.com',     '5551001014', 6),
('Martin',    'Petit',    60,   'Martin.p@email.com',     '5551001015', 5);

INSERT INTO Clients (AccountNumber, PinCode, AccountBalance, PersonID)
VALUES
('A001', '1234', 1500.00, 1),
('A002', '2345', 3200.50, 2),
('A003', '3456', 875.25, 3),
('A004', '4567', 10000.00, 4),
('A005', '5678', 250.75, 5);

INSERT INTO Users (Username, Password,Permission, PersonID)
VALUES
('Admin',     'firnsE9<',  -1,   6),
('James',     'O755',       0,   7),
('Charlotte', 'H855',       1,   8),
('William',   '\555',       2,   9),
('Mehmet',    'XR678',      4,  10),
('jhon.m',    'OmtsE\&',   8,  11),
('lucas.d',   'QzhExI',   16,  12),
('Keven.w',   'Pj{86J',   32,  13),
('daniel.k',  'IEs&',     64,  14),
('Martin.z',  'Rfwy>:',  128,  15);

INSERT INTO Nationalities (NationalityName) VALUES
('American'), ('Australian'), ('British'), ('Canadian'), ('French'), ('Polish'), ('Turkish');

--UPDATE Persons SET Phone = '+966501234567' WHERE PersonID = 1;
--UPDATE Persons SET Phone = '+966551112222' WHERE PersonID = 2;
--UPDATE Persons SET Phone = '+966591234567' WHERE PersonID = 3;
--UPDATE Persons SET Phone = '+966502345678' WHERE PersonID = 4;
--UPDATE Persons SET Phone = '+966553456789' WHERE PersonID = 5;
--UPDATE Persons SET Phone = '+966594567890' WHERE PersonID = 6;
--UPDATE Persons SET Phone = '+966505678901' WHERE PersonID = 7;
--UPDATE Persons SET Phone = '+966556789012' WHERE PersonID = 8;
--UPDATE Persons SET Phone = '+966597890123' WHERE PersonID = 9;
--UPDATE Persons SET Phone = '+966508901234' WHERE PersonID = 10;
--UPDATE Persons SET Phone = '+966559012345' WHERE PersonID = 11;
--UPDATE Persons SET Phone = '+966590123456' WHERE PersonID = 12;
--UPDATE Persons SET Phone = '+966501112233' WHERE PersonID = 13;
--UPDATE Persons SET Phone = '+966552223344' WHERE PersonID = 14;
--UPDATE Persons SET Phone = '+966593334455' WHERE PersonID = 15;
--UPDATE Persons SET Phone = '+966504445566' WHERE PersonID = 16;
--UPDATE Persons SET Phone = '+966555556677' WHERE PersonID = 17;
--UPDATE Persons SET Phone = '+966596667788' WHERE PersonID = 18;
--UPDATE Persons SET Phone = '+966507778899' WHERE PersonID = 19;

DELETE FROM Transfers WHERE SenderClientID = 1 OR ReceiverClientID = 1;

DELETE FROM Transfers WHERE SenderClientID = 3 OR ReceiverClientID = 3;

SELECT Found = 1  FROM Transfers WHERE SenderClientID = 2 OR ReceiverClientID = 2;
