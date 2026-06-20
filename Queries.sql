P@ssw0rd

//private void button1_Click(object sender, EventArgs e)
//{
//    string TB = default(string);

//    for(byte i = 0; i < mskAccountBalance.Text.Length; i++)
//    {
//        if (char.IsDigit(mskAccountBalance.Text[i]))
//            TB += mskAccountBalance.Text[i];
//    }

//    decimal B = Convert.ToDecimal(TB);
//    MessageBox.Show(B.ToString(), "AccB", MessageBoxButtons.OK);
//}


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
    ('fghanistan', 'Afghanistan Afghani', 'AFN', 64.770000),
    ('lbania', 'Albania Lek(e)', 'ALL', 95.200000),
    ('lgeria', 'Algerian Dinar', 'DZD', 133.500000),
    ('merican Samoa', 'US Dollar', 'USD', 1.000000),
    ('rance', 'Euro', 'EUR', 0.870000),
    ('ngola', 'Angolan Kwanza', 'AOA', 912.000000),
    ('nguilla', 'E.C. Dollar', 'XCD', 2.700000),
    ('ntigua and Barbuda', 'E.C. Dollar', 'XCD', 2.700000),
    ('Argentina', 'Argentine Peso', 'ARS', 1050.000000),
    ('Armenia', 'Armenian Dram', 'AMD', 398.500000),
    ('Aruba', 'Aruban Guilder', 'AWG', 1.790000),
    ('Australia', 'Australian Dollar', 'AUD', 1.560000),
    ('Austria', 'Euro', 'EUR', 0.870000),
    ('Azerbaijan', 'Azerbaijan Manat', 'AZN', 1.700000),
    ('Bahamas', 'Bahamian Dollar', 'BSD', 1.000000),
    ('Bahrain', 'Bahraini Dinar', 'BHD', 0.377000),
    ('Bangladesh', 'Bangladesh Taka', 'BDT', 110.500000),
    ('Barbados', 'Barbados Dollar', 'BBD', 2.000000),
    ('Belarus', 'Belarusian Ruble', 'BYN', 3.230000),
    ('Belgium', 'Euro', 'EUR', 0.870000),
    ('Belize', 'Belize Dollar', 'BZD', 2.000000),
    ('Benin', 'CFA Franc', 'XOF', 570.790000),
    ('Bermuda', 'Bermuda Dollar', 'BMD', 1.000000),
    ('Bhutan', 'Bhutan Ngultrum', 'BTN', 82.800003),
    ('Bolivia', 'Bolivia Boliviano', 'BOB', 6.852000),
    ('Bosnia and Herzegovina', 'Bosnia and Herzegovina Convertible Mark', 'BAM', 1.703000),
    ('Botswana', 'Botswana Pula', 'BWP', 13.580000),
    ('Brazil', 'Brazilian Real', 'BRL', 5.750000),
    ('Brunei', 'Brunei Dollar', 'BND', 1.330000),
    ('Bulgaria', 'Bulgarian Lev', 'BGN', 1.703000),
    ('Burkina Faso', 'CFA Franc', 'XOF', 570.790000),
    ('Burundi', 'Burundi Franc', 'BIF', 2910.000000),
    ('Cambodia', 'Cambodian Riel', 'KHR', 4120.000000),
    ('Cameroon', 'CFA Franc', 'XAF', 570.790000),
    ('Canada', 'Canadian Dollar', 'CAD', 1.384000),
    ('Canary Islands', 'Euro', 'EUR', 0.870000),
    ('Cape Verde', 'Cape Verde Escudo', 'CVE', 98.570000),
    ('Cayman Islands', 'Cayman Is. Dollar', 'KYD', 0.820000),
    ('Central African Republic', 'CFA Franc', 'XAF', 570.790000),
    ('Chad', 'CFA Franc', 'XAF', 570.790000),
    ('Chile', 'Chilean Peso', 'CLP', 940.000000),
    ('China', 'Chinese Renminbi', 'CNY', 7.250000),
    ('Colombia', 'Colombian Peso', 'COP', 4180.000000),
    ('Comoros', 'Comoros Franc', 'KMF', 452.350000),
    ('Congo', 'CFA Franc', 'XAF', 570.790000),
    ('Congo, Dem. Rep.', 'Congo Franc, Dem. Rep.of', 'CDF', 2280.000000),
    ('Cook Islands', 'New Zealand Dollar', 'NZD', 1.650000),
    ('Costa Rica', 'Costa Rica Colon', 'CRC', 518.500000),
    ('Cote d''Ivoire', 'CFA Franc', 'XOF', 570.790000),
    ('Croatia', 'Croatia Kuna', 'HRK', 6.555000),
    ('Cuba', 'Cuban Peso', 'CUP', 24.000000),
    ('Cyprus', 'Euro', 'EUR', 0.870000),
    ('Czech Republic', 'Czech Koruna', 'CZK', 22.250000),
    ('Denmark', 'Danish Krone', 'DKK', 6.501000),
    ('Djibouti', 'Djibouti Francs', 'DJF', 177.000000),
    ('Dominica', 'E.C. Dollar', 'XCD', 2.700000),
    ('Dominican Republic', 'Dominican Peso', 'DOP', 59.740000),
    ('East Timor', 'US Dollar', 'USD', 1.000000),
    ('Ecuador', 'US Dollar', 'USD', 1.000000),
    ('Egypt', 'Egyptian Pound', 'EGP', 54.580000),
    ('El Salvador', 'US Dollar', 'USD', 1.000000),
    ('Equatorial Guinea', 'CFA Franc', 'XAF', 570.790000),
    ('Eritrea', 'Eritrea Nakfa', 'ERN', 15.000000),
    ('Estonia', 'Euro', 'EUR', 0.870000),
    ('Eswatini, Kingdom of', 'Lilangeni', 'SZL', 17.087000),
    ('Ethiopia', 'Ethiopian Birr', 'ETB', 153.466000),
    ('Fiji', 'Fiji Dollar', 'FJD', 2.213000),
    ('Finland', 'Euro', 'EUR', 0.870000),
    ('France', 'Euro', 'EUR', 0.870000),
    ('French Guiana', 'Euro', 'EUR', 0.870000),
    ('French Polynesia', 'CFP Franc', 'XPF', 104.110000),
    ('Gabon', 'CFA Franc', 'XAF', 570.790000),
    ('Gambia', 'Gambian Dalasi', 'GMD', 73.000000),
    ('Georgia', 'Georgian Lari', 'GEL', 2.667000),
    ('Germany', 'Euro', 'EUR', 0.870000),
    ('Ghana', 'Ghana Cedi', 'GHS', 10.970000),
    ('Gibraltar', 'Gibraltar Pound', 'GIP', 0.790000),
    ('Greece', 'Euro', 'EUR', 0.870000),
    ('Greenland', 'Danish Krone', 'DKK', 6.501000),
    ('Grenada', 'E.C. Dollar', 'XCD', 2.700000),
    ('Guadeloupe', 'Euro', 'EUR', 0.870000),
    ('Guam', 'US Dollar', 'USD', 1.000000),
    ('Guatemala', 'Guatemala Quetzal(es)', 'GTQ', 7.720000),
    ('Guinea', 'Guinean Franc', 'GNF', 8760.000000),
    ('Guinea-Bissau', 'CFA Franc', 'XOF', 570.790000),
    ('Guyana', 'Guyana Dollar', 'GYD', 209.000000),
    ('Haiti', 'Haiti Gourde', 'HTG', 131.500000),
    ('Honduras', 'Honduras Lempira', 'HNL', 25.280000),
    ('Hong Kong', 'HongKong Dollar', 'HKD', 7.768000),
    ('Hungary', 'Hungary Forint', 'HUF', 364.200000),
    ('Iceland', 'Iceland Krona', 'ISK', 136.500000),
    ('India', 'Indian Rupee', 'INR', 84.200000),
    ('Indonesia', 'Indonesia Rupiah', 'IDR', 16350.000000),
    ('Iran', 'Iranian Rial', 'IRR', 420000.000000),
    ('Iraq', 'Iraqi Dinar', 'IQD', 1310.000000),
    ('Ireland', 'Euro', 'EUR', 0.870000),
    ('Israel', 'Israel Shekel', 'ILS', 3.750000),
    ('Italy', 'Euro', 'EUR', 0.870000),
    ('Jamaica', 'Jamaican Dollar', 'JMD', 159.500000),
    ('Japan', 'Japanese Yen', 'JPY', 159.150000),
    ('Jordan', 'Jordanian Dinar', 'JOD', 0.708000),
    ('Kazakhstan', 'Kazakhstan Tenge', 'KZT', 512.000000),
    ('Kenya', 'Kenyan Shilling', 'KES', 128.500000),
    ('Kiribati', 'Australian Dollar', 'AUD', 1.560000),
    ('Korea, D.P.R. of', 'Korean Won, North Korea', 'KPW', 110.000000),
    ('Korea, Republic of', 'Korean Won, South Korea', 'KRW', 1378.000000),
    ('Kuwait', 'Kuwaiti Dinar', 'KWD', 0.307000),
    ('Kyrgyzstan', 'Kyrgyzstan Som', 'KGS', 87.500000),
    ('Lao, People''s Dem. Rep.', 'Laos Kip', 'LAK', 21800.000000),
    ('Latvia', 'Euro', 'EUR', 0.870000),
    ('Lebanon', 'Lebanese Pound', 'LBP', 89500.000000),
    ('Lesotho', 'Lesotho Loti', 'LSL', 17.087000),
    ('Liberia', 'Liberian Dollar', 'LRD', 188.500000),
    ('Libyan Arab Jamahiriya', 'Libyan Dinar', 'LYD', 4.850000),
    ('Liechtenstein', 'Swiss Franc', 'CHF', 0.880000),
    ('Lithuania', 'Euro', 'EUR', 0.870000),
    ('Luxembourg', 'Euro', 'EUR', 0.870000),
    ('Macao', 'Macao Pataca', 'MOP', 8.010000),
    ('Madagascar', 'Malagasy Ariary, Madagascar', 'MGA', 4560.000000),
    ('Malawi', 'Malawi Kwacha', 'MWK', 1730.000000),
    ('Malaysia', 'Malaysia Ringgit', 'MYR', 4.390000),
    ('Maldives', 'Maldives Rufiyaa', 'MVR', 15.380000),
    ('Mali', 'CFA Franc', 'XOF', 570.790000),
    ('Malta', 'Euro', 'EUR', 0.870000),
    ('Marshall Islands', 'US Dollar', 'USD', 1.000000),
    ('Martinique', 'Euro', 'EUR', 0.870000),
    ('Mauritania', 'Mauritania Ouguiya', 'MRU', 40.250000),
    ('Mauritius', 'Mauritius Rupee', 'MUR', 46.200000),
    ('Mexico', 'Mexican Peso', 'MXN', 19.450000),
    ('Micronesia', 'US Dollar', 'USD', 1.000000),
    ('Moldova, Republic of', 'Moldovan Leu', 'MDL', 17.850000),
    ('Monaco', 'Euro', 'EUR', 0.870000),
    ('Mongolia', 'Mongolia Tugrik', 'MNT', 3440.000000),
    ('Montenegro', 'Euro', 'EUR', 0.870000),
    ('Montserrat', 'E.C. Dollar', 'XCD', 2.700000),
    ('Morocco', 'Morocco Dirham', 'MAD', 9.870000),
    ('Mozambique', 'Mozambique Metical', 'MZN', 64.000000),
    ('Myanmar', 'Myanmar Kyat', 'MMK', 2100.000000),
    ('Namibia', 'Namibia Dollar', 'NAD', 17.087000),
    ('Nauru', 'Australian Dollar', 'AUD', 1.560000),
    ('Nepal', 'Nepalese Rupee', 'NPR', 134.800000),
    ('Netherlands', 'Euro', 'EUR', 0.870000),
    ('Netherlands Antilles', 'Netherlands Antilles Guilder', 'ANG', 1.790000),
    ('New Caledonia', 'CFP Franc', 'XPF', 104.110000),
    ('New Zealand', 'New Zealand Dollar', 'NZD', 1.650000),
    ('Nicaragua', 'Nicaragua Cordoba Oro', 'NIO', 36.840000),
    ('Niger', 'CFA Franc', 'XOF', 570.790000),
    ('Nigeria', 'Nigeria Naira', 'NGN', 1594.000000),
    ('Niue', 'New Zealand Dollar', 'NZD', 1.650000),
    ('North Macedonia, Rep. of', 'Denar', 'MKD', 55.200000),
    ('Northern Mariana Islands', 'US Dollar', 'USD', 1.000000),
    ('Norway', 'Norwegian Krone', 'NOK', 10.450000),
    ('Oman', 'Oman Rial', 'OMR', 0.385000),
    ('Pakistan', 'Pakistani Rupee', 'PKR', 278.500000),
    ('Palau, Republic of', 'US Dollar', 'USD', 1.000000),
    ('Panama', 'Panama Balboa', 'PAB', 1.000000),
    ('Papua New Guinea', 'Kina', 'PGK', 3.950000),
    ('Paraguay', 'Paraguay Guarani', 'PYG', 7780.000000),
    ('Peru', 'Sol', 'PEN', 3.760000),
    ('Philippines', 'Philippine Peso', 'PHP', 56.200000),
    ('Poland', 'Poland Zloty', 'PLN', 3.850000),
    ('Portugal', 'Euro', 'EUR', 0.870000),
    ('Puerto Rico', 'US Dollar', 'USD', 1.000000),
    ('Qatar', 'Qatari Rial', 'QAR', 3.640000),
    ('Reunion', 'Euro', 'EUR', 0.870000),
    ('Romania', 'Romanian Leu', 'RON', 4.570000),
    ('Russian Federation', 'Russian Rouble', 'RUB', 81.500000),
    ('Rwanda', 'Rwanda Franc', 'RWF', 1380.000000),
    ('Saint Helena', 'St.Helena Pound', 'SHP', 0.790000),
    ('Saint Kitts and Nevis', 'E.C. Dollar', 'XCD', 2.700000),
    ('Saint Lucia', 'E.C. Dollar', 'XCD', 2.700000),
    ('Samoa', 'Samoa Tala', 'WST', 2.730000),
    ('San Marino', 'Euro', 'EUR', 0.870000),
    ('Sao Tome and Principe', 'Sao Tome Principe Dobra', 'STN', 24.050000),
    ('Saudi Arabia', 'Saudi Riyal', 'SAR', 3.750000),
    ('Senegal', 'CFA Franc', 'XOF', 570.790000),
    ('Serbia', 'Serbian Dinar', 'RSD', 105.400000),
    ('Seychelles', 'Seychelles Rupee', 'SCR', 14.200000),
    ('Sierra Leone', 'Sierra Leone Leone', 'SLE', 22.800000),
    ('Singapore', 'Singapore Dollar', 'SGD', 1.330000),
    ('Slovakia', 'Euro', 'EUR', 0.870000),
    ('Slovenia', 'Euro', 'EUR', 0.870000),
    ('Solomon Islands', 'Solomon Is. Dollar', 'SBD', 8.420000),
    ('Somalia', 'Somali Shilling', 'SOS', 571.500000),
    ('South Africa', 'South Africa Rand', 'ZAR', 17.087000),
    ('South Sudan', 'South Sudanese Pound', 'SSP', 4515.000000),
    ('Spain', 'Euro', 'EUR', 0.870000),
    ('Sri Lanka', 'Sri Lanka Rupee', 'LKR', 304.500000),
    ('St. Vincent and the Grena', 'E.C. Dollar', 'XCD', 2.700000),
    ('Sudan', 'Sudanese Pound', 'SDG', 601.000000),
    ('Suriname', 'Surinamese Dollar', 'SRD', 36.500000),
    ('Sweden', 'Swedish Krona', 'SEK', 9.960000),
    ('Switzerland', 'Swiss Franc', 'CHF', 0.880000),
    ('Syrian Arab Republic', 'Syrian Pound', 'SYP', 12800.000000),
    ('Tajikistan', 'Tajikistan Somoni', 'TJS', 10.920000),
    ('Tanzania, United Rep. of', 'Tanzania Shilling', 'TZS', 2700.000000),
    ('Thailand', 'Thai Baht', 'THB', 33.500000),
    ('Togo', 'CFA Franc', 'XOF', 570.790000),
    ('Tokelau Islands', 'New Zealand Dollar', 'NZD', 1.650000),
    ('Tonga', 'Tonga Pa''anga', 'TOP', 2.390000),
    ('Trinidad and Tobago', 'Trinidad and Tobago Dollar', 'TTD', 6.790000),
    ('Tunisia', 'Tunisian Dinar', 'TND', 3.090000),
    ('Turkey', 'Turkish Lira', 'TRY', 38.200000),
    ('Turkmenistan', 'Turkmenistan Manat', 'TMT', 3.510000),
    ('Turks and Caicos Island', 'US Dollar', 'USD', 1.000000),
    ('Tuvalu', 'Australian Dollar', 'AUD', 1.560000),
    ('Uganda', 'Uganda Shilling', 'UGX', 3670.000000),
    ('Ukraine', 'Ukraine Hryvnia', 'UAH', 41.500000),
    ('United Arab Emirates', 'United Arab Emirates Dirham', 'AED', 3.672000),
    ('United Kingdom', 'U.K. Pound', 'GBP', 0.790000),
    ('Uruguay', 'Uruguay Peso', 'UYU', 42.300000),
    ('Uzbekistan', 'Uzbekistan Sum', 'UZS', 12890.000000),
    ('Vanuatu', 'Vanuatu Vatu', 'VUV', 119.800000),
    ('Venezuela', 'Bolivar Digital', 'VES', 46.800000),
    ('Viet Nam', 'Viet Nam Dong', 'VND', 25980.000000),
    ('Virgin Islands (UK)', 'US Dollar', 'USD', 1.000000),
    ('Virgin Islands (USA)', 'US Dollar', 'USD', 1.000000),
    ('Wallis and Futuna Islands', 'CFP Franc', 'XPF', 104.110000),
    ('Yemen, Republic of', 'Yemeni Rial', 'YER', 533.500000),
    ('Zambia', 'Zambia Kwacha', 'ZMW', 27.500000),
    ('Zimbabwe', 'Zimbabwe RTGS dollar', 'ZWL', 25.000000);

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