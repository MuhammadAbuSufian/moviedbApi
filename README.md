# Overview
This is api application built with  ASP.NET Core, Entity Framwork and SqlServer following the principles of Clean Architecture. It has the following functionalities </br> 
 * User can search list for movie, tv show and person.</br>
 * User can request a record of movie, tv show and person with it's id. </br>
 * It's store users search history in the database. for that user must provide a name with query parameter.</br>
 
 ## Technologies
* ASP.NET Core 2.2
* Entity Framework Core 
* Rest Sharp
* Sql Server

## Database Configuration

The Application uses data-store in SQL Server.

Update the **ConnectionString.Default** connection string within **appsettings.json** , so that application can point to a valid SQL Server instance. 

```json
  "ConnectionStrings": {
    "Default": "Server=(local);Database=TestDb;Trusted_Connection=True;MultipleActiveResultSets=true"
  }
```

When you run **update-database** command, the migrations will be applied and the database will be automatically created.

## API Documentation
There are two endpoint in this application. First one is to search movie, tv show and people and other one is to view detail of a movie, tv show or people. 

Api - https://localhost:44334/api/search

Parameters
1.	User (username should be provided to track user search history this is a must given query parameter)
2.	Key (This is the key for searching the list of movie, person or tv show )
3.	Type (Type should be movie, people or tv)
4.	Language (user can user language filter like ‘en-US’)
5.	Adult(if this query parameter is true then search will include adult search result. By default it is false)
6.	Page (this is to navigate different page of the search result)


Api - https://localhost:44334/api/record

Parameters
1.	User (username should be provided to track user search history this is a must given query parameter)
2.	Type (Type should be movie, person or tv)
3.	RecordId (To get the specific record this parameter should be provided)
4.	Language (user can user language filter like ‘en-US’)




