# CRUDwithDapper

## Table of Contents
1. [Project Overview](#project-overview)
2. [Objectives](#objectives)
3. [Features](#features)
4. [Technology Stack](#technology-stack)
5. [System Requirements](#system-requirements)
6. [Setup and Installation](#setup-and-installation)
7. [Usage](#usage)

---

## Project Overview

The **CRUDwithDapper** application is a web-based platform designed to perform **CRUD** operations on **Branch** records using **Dapper ORM** for database interactions. Built with **ASP.NET Core MVC**, this application allows users to add, view, edit, and delete branch records in a **SQL Server** database.

---

## Objectives

- Build a **CRUD** application using **Dapper ORM** to manage branch data.
- Implement **Create**, **Read**, **Update**, and **Delete** functionalities for branch records.
- Utilize **ASP.NET Core MVC** for building the user interface and backend logic.
- Use **SQL Server** as the database, with **Dapper** for quick and efficient data access.

---

## Features

- **Add Branch**: Enter new branch details (e.g., name) and save them to the database.
- **View Branches**: Display a list of all branches stored in the system.
- **Edit Branch**: Update an existing branch record.
- **Delete Branch**: Remove a branch from the system.
- **Responsive UI**: User-friendly interface designed with **Bootstrap** for mobile-friendly access.
- **Database Configuration**: Uses **Dapper ORM** for efficient querying and interaction with **SQL Server**.

---

## Technology Stack

- **ASP.NET Core MVC**: Framework for building the web application.
- **Dapper ORM**: Lightweight ORM used for database interactions.
- **SQL Server**: Database for storing branch records.
- **Bootstrap**: Frontend framework for styling and responsive design.
- **C#**: Programming language used for backend development.

---

## System Requirements

- **.NET 8.0** or later
- **SQL Server** (local or remote)
- Visual Studio or Visual Studio Code with **.NET** extensions
- **Git** (for version control)

---

## Setup and Installation

1. **Clone the repository**:
    Clone the repository to your local machine using Git:
   ```bash
   git clone https://github.com/d3ku010/CRUDwithDapper.git
   cd StudentPortal
   ```
   
2. **Navigate to the project directory:**:
   After cloning, navigate to the project folder:
    ```bash
   cd CRUDwithDapper
    ```
    
3. **Restore .NET dependencies**:
    ```bash
   dotnet restore
    ```
    
4. **Configure the database**:
    Open appsettings.json and configure the connection string to point to your SQL Server instance:
   ```json
   "ConnectionStrings": {
    "DefaultConnectionMSSQLNoCred": "Server=localhost;Database=DapperCRUD;TrustedConnection=True;MultipleActiveResultSets=true",
    "connMSSQL": "Server=localhost;Database=DapperCRUD;User ID=sa;Password=yourpassword;TrustServerCertificate=True;MultipleActiveResultSets=true"
      }
    ```
   
5. **Run the application**:
   Run the application using Visual Studio or via the .NET CLI:
    ```bash
    dotnet run
    ```

6. **Access the application**:
   After the application is running, open your browser and navigate to http://localhost:5000 (or the port specified in the output).


---


# Database Setup

Before running the application, you must ensure the database and schema are set up correctly.

## 1. Create the database schema
If the database does not already exist, you can create it manually using the following SQL script:
```sql
CREATE DATABASE DapperCRUD;
```

## 2. Create the `Branch` table
Once the database is created, execute the following SQL script to create the `Branch` table:
```sql
CREATE TABLE Branch (
    Id BIGINT PRIMARY KEY IDENTITY,
    Name NVARCHAR(100) NOT NULL,
    CreatedDate DATETIME NOT NULL,
    UpdatedDate DATETIME NULL
);
```

## 3. Insert test data (optional)
To quickly populate the table with test data, you can insert sample records:
```sql
INSERT INTO Branch (Name, CreatedDate, UpdatedDate)
VALUES ('Computer Science', GETDATE(), NULL),
       ('Electrical Engineering', GETDATE(), NULL);
```

## 4. Configure connection string
Ensure that your `appsettings.json` file contains the correct database connection string to connect to your SQL Server.

Example connection string for a local database:
```json
"ConnectionStrings": {
  "DefaultConnectionMSSQLNoCred": "Server=localhost;Database=DapperCRUD;TrustedConnection=True;MultipleActiveResultSets=true",
  "connMSSQL": "Server=localhost;Database=DapperCRUD;User ID=sa;Password=yourpassword;TrustServerCertificate=True;MultipleActiveResultSets=true"
}
```

---

## Usage

1. **Add a Branch**:
   Navigate to the "Create Branch" page, enter the required details (e.g., name), and submit the form to create a new branch record.
  
2. **View Branch**:
  The homepage will display all branches stored in the system, listing their details.
  
3. **Edit a Branch**:
  Click "Edit" next to a branch’s name to update its information.

4. **Delete a Branch**:
  Click "Delete" next to a branch’s entry to remove its record from the system.


---
