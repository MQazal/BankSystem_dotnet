# BankSystem_dotnet

## Overview

BankSystem_dotnet is a C#-based bank management application that provides tellers and administrators with tools to manage clients, process fund transfers, handle multi-currency exchange rates, and audit user activity. The project is organized into three independent class library projects plus a presentation layer, demonstrating separation of concerns in a real-world .NET desktop application.

## Technologies Used

- C# / .NET Framework
- Windows Forms
- SQL Server
- ADO.NET
- OOP · N-Tier Architecture

## Architecture

The solution follows a strict **3-Tier Architecture**:

- **Presentation Layer (UI)** — Windows Forms / Console — user interaction
- **Business Logic Layer (BLL)** — Validation, rules, calculations
- **Data Access Layer (DAL)** — ADO.NET / SqlClient — raw SQL queries
- **SQL Server Database** — BankManagementSystem — 7 normalized tables

## Features

- **Client Management** — create, view, and delete bank clients; each client is linked to a Person record for contact information
- **Account Transfers** — process fund transfers between any two distinct client accounts, logged with timestamp and the responsible user
- **Multi-Currency Support** — a Currencies table stores exchange rates relative to USD for international reference
- **User & Permission System** — bitfield-based permission model supporting granular role assignments
- **Login Auditing** — every successful login is recorded in Logins with a timestamp, enabling a full audit trail
- **Nationality Lookup** — normalized nationality data via a dedicated Nationalities table
- **Admin Seeding** — a default Admin user is bootstrapped via seed SQL scripts
- **Data Integrity** — database-level constraints prevent negative balances, self-transfers, and underage clients

## Permission System

The system uses a **bitmask-based** permissions model. Users can be assigned multiple permissions efficiently using bitwise operations.

| Permission | Value |
|---|---|
| View Clients | 1 |
| Add Client | 2 |
| Update Client | 4 |
| Full Access | -1 |
| Blocked Access | 0 |
