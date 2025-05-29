# Gamovida
Steps to Set Up SQL Server in Docker
Install Docker:
If you don’t already have Docker installed, you can download and install it from the official Docker website.

Run SQL Server Docker Container:
You can pull the official Microsoft SQL Server image from Docker Hub and run it in a container.

Open a terminal (Command Prompt or PowerShell on Windows, Terminal on macOS/Linux) and run the following commands:

Pull the latest SQL Server image:

bash
Copy
docker pull mcr.microsoft.com/mssql/server

Run SQL Server in a Docker container:

bash
Copy
docker run -e 'ACCEPT_EULA=Y' -e 'MSSQL_SA_PASSWORD=YourPassword123' -p 1433:1433 --name sql_server_container -d mcr.microsoft.com/mssql/server


![image](https://github.com/user-attachments/assets/520a4bd4-65fe-404c-b5d5-b47c5beeb2c3)



![image](https://github.com/user-attachments/assets/76bf6b3d-efdb-4e47-b508-81b68545d69c)




Once connected, open a New Query window and execute the following SQL script to create the UG database and People table. This script will safely drop and recreate them if they already exist.

SQL

USE master;
GO

IF EXISTS (SELECT name FROM sys.databases WHERE name = 'UG')
BEGIN
    ALTER DATABASE UG SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
    DROP DATABASE UG;
END
GO

CREATE DATABASE UG;
GO

USE UG;
GO

CREATE TABLE People (
    Id INT IDENTITY PRIMARY KEY,
    Firstname NVARCHAR(30) NOT NULL,
    Lastname NVARCHAR(30) NOT NULL,
    Email NVARCHAR(100),
    Gender NVARCHAR(10),
    Age INT
);
GO



You can verify the database and table exist by refreshing the "Databases" node in SSMS Object Explorer and checking under UG -> Tables. To see data, right-click dbo.People and select "Select Top 1000 Rows".
![image](https://github.com/user-attachments/assets/d4ff5e9e-3556-43ae-aaff-2c09d4b18e2c)

3. Set up the C# Project in Visual Studio
Create a New C# Windows Forms App (.NET Framework) project in Visual Studio.
Choose the "Windows Forms App (.NET Framework)" template.
Name your project LashaMurgvaLominadzeShraieri.Quiz3 to match the namespaces.
Ensure the target .NET Framework is 4.7.2 or later (or whatever you initially used).
Add NuGet Package:
In Visual Studio, right-click your project in Solution Explorer.
Select Manage NuGet Packages...
![image](https://github.com/user-attachments/assets/23dddecd-43d0-4513-8f54-d4f79a8ed22d)

Go to the Browse tab.
Search for Microsoft.Data.SqlClient and install it.
![image](https://github.com/user-attachments/assets/efe3b903-26a1-407a-a96f-17fdf0e889a4)
