<h1 align="right">
  <img alt="Project's logo" src="https://github.com/user-attachments/assets/bbf2fd04-d808-47a4-a9d0-a50f269f771d" width="140px" align="left" />
  Import CRUD
</h1>

<p align="right">
  🌊 A simple ASPNET MVC application to create imports of products. Made with .NET Framework 4.8.1
  <br />
</p>
<br/>

## 👀 Overview

<div>
  <img src="https://github.com/user-attachments/assets/ebc4336a-9c19-48cf-97c0-6140d90d2dba" />
  <img src="https://github.com/user-attachments/assets/62413817-5445-42b8-8c33-b2a9202e6f0e" />
</div>

## 📖 About

ImportCrud is an ASP.NET MVC application targeting .NET Framework 4.8.1. The application provides a platform for managing user authentication, external logins, and basic CRUD operations. It leverages ASP.NET Identity for user management and authentication.

## 🧱 This project was built with:

- [.NET Framework 4.8.1](https://dotnet.microsoft.com/en-us/download/dotnet-framework/net481)
- [SQL Server](https://www.microsoft.com/en/sql-server/sql-server-downloads)
- [Entity Framework 6](https://learn.microsoft.com/en-us/ef/ef6/)
- [Bootstrap 5](https://getbootstrap.com/)

## 🚶‍♂️ Installing and Running

> If you haven't downloaded .NET Framework 4.8.1 yet you can download it here [Download .NET Framework 4.8.1](https://dotnet.microsoft.com/en-us/download/dotnet-framework/net481)
> 
> You can download SQL Server here [SQL Server Downloads | Microsoft](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) and SQL Server Management Studio here [Download SQL Server Management Studio (SSMS)](https://learn.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms?view=sql-server-ver16)

1.  Clone this repository `git clone https://github.com/pferreirafabricio/aspnet-mvc-import-crud.git`
2.  Open the solution `ImportCrud/ImportCrud.sln` in Visual Studio
3.  Restore the Nuget packages
4.  Change the connection string in `ImportCrud/Web.config`
5.  Build the project
6.  Run the following commands in the Package manager console to update the database 
```bash
Update-Database -ConfigurationTypeName ConfigurationIdentity  -Verbose
Update-Database -ConfigurationTypeName ConfigurationImportCrud -Verbose
```
7.  Run the web app with IIS Express

## ♻ Contribute

1.  Fork this repository
2.  Create a branch with your feature: `git checkout -b my-feature`
3.  Commit your changes: `git commit -m 'feat: My new feature'`
4.  Push your branch: `git push origin my-feature`

## :page_with_curl: License

This project is licensed under the MIT license. For more details, see the [LICENSE](LICENSE) file.

## 📚 Learn more

- [Use EF Migrations in an ASP.NET MVC app and deploy to Azure](https://learn.microsoft.com/en-us/aspnet/mvc/overview/getting-started/getting-started-with-ef-using-mvc/migrations-and-deployment-with-the-entity-framework-in-an-asp-net-mvc-application)
