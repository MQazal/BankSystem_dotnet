# BankSystem_dotnet

1- Overview:
BankSystem_dotnet is a C#-based bank management application that provides tellers and administrators with tools to manage clients, process fund transfers, handle multi-currency exchange rates, and audit user activity. The project is organized into three independent class library projects plus a presentation layer, demonstrating separation of concerns in a real-world .NET desktop application.

2- Technologies Used:
C#
.NET Framework / .NET
Windows Forms
SQL Server
ADO.NET
Object-Oriented Programming (OOP)
N-Tier Architecture

3- Architecture:
The solution follows a strict 3-Tier Architecture:
<li>Presentation Layer (UI): Windows Forms / Console — user interaction.</li>
<li>Business Logic Layer (BLL): Validation, rules, calculations.</li>
<li>Data Access Layer (DAL): ADO.NET / SqlClient — raw SQL queries.</li>
<li>SQL Server Database: BankManagementSystem — 7 normalized tables.</li>

4- Features:
<li>Client Management — create, view, and delete bank clients; each client is linked to a Person record for contact information.</li>
<li>Account Transfers — process fund transfers between any two distinct client accounts, logged with timestamp and the responsible user.</li>
<li>Multi-Currency Support — a Currencies table stores exchange rates relative to USD for international reference.</li>
<li>User & Permission System — bitfield-based permission model supporting granular role assignments (see Permission System).</li>
<li>Login Auditing — every successful login is recorded in Logins with a timestamp, enabling a full audit trail.</li>
<li>Nationality Lookup — normalized nationality data via a dedicated Nationalities table.</li>
<li>Admin Seeding — a default Admin user is bootstrapped via seed SQL scripts.</li>
<li>Data Integrity — database-level constraints prevent negative balances, self-transfers, and underage clients.</li>
<li>🔑 Permissions System:
The system uses a bitmask-based permissions model.
Example permissions:
<li>View Clients:	1</li>
<li>Add Client:	2</li>
<li>Update Client: 4</li>
<li>Full Access: -1</li>
Users can be assigned multiple permissions efficiently using bitwise operations.</li>
