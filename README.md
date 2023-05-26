# ASP.net - Course-submission :computer:
This program is a school project for Ec-utbildning in Gothenburg. 
It is developed using ASP.NET with Entity Framework. 
The program serves as a simple website with account services, product categories, and a contact page.

## Getting Started
To run this project, you will need to have the following tools installed on your machine:
- .NET SDK
- SQL Server

## Installation
1. Clone the repository or download the source code.
2. Open the project in your preferred IDE.
3. Configure the database connection string in the appsettings.json file located in the project root directory.
4. Run the following command in the terminal or command prompt to apply the database migrations: 
*dotnet ef database update*

## Getting started
1. To start the project, follow these steps:
2. Open the project in your preferred IDE.
3. Build the solution to restore the NuGet packages.
4. Start the project by running the following command in the terminal or command prompt:
*dotnet run*

## Features
After building and running the project, you will be presented with a console interface with several menu options:

- Account services: Register and log in functionality.
- Role-based access control: The first person to log in gets the role admin and access to the admin backlog page.
- Homepage with categories: Displaying 3 categories with different products in them.
- Products page: Displaying all products from all categories.
- Product details page: Displaying all details about a specific product.
- Contact page: Allows users to enter their details and send a message to the company.
- Seed service: Checks if the database is empty and fills it with 30 computer products if needed.

## Folder structure

- Controllers/            # Contains the controller classes
- Models/                 # Contains the entity models and data contexts
- Repositories/           # Contains the repository classes for data access
- Services/               # Contains the service classes for business logic
- Views/                  # Contains the view templates
- appsettings.json        # Configuration file for the application
- Program.cs              # Entry point of the application

## Dependencies
- ASP.NET
- Entity Framework
- Microsoft.AspNetCore.Identity
- Microsoft.EntityFrameworkCore

## Author
This project was created by Natanael Augustin as a project for a course - ASP.NET whilst studying to become a web developer at EC-Utbildning Gothenburg.
