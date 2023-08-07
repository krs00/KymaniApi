# Kymani Api

### By Kymani Stephens

## Description

The Kymani API is a RESTful web service designed to manage Kymani data.

## Technologies

- C#
- .NET
- ASP.NET Core 
- Entity Framework Core

## Database Structure

#### Kymanis Table

| KymaniId | Mood | PowerLevel |
|-------------|------|-------|
| int  | string | int |


## Database Setup Instructions

To set up the Kymani API and the corresponding database, please follow the instructions below:

1. Clone this repository to your local machine.

2. Open your terminal or command prompt and navigate to the "KymaniApi" directory.

3. In the "KymaniApi" directory, create a file named `appsettings.json`.

4. Open the `appsettings.json` file and add the following code:

```json 
{
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "AllowedHosts": "*",
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=kymani_api;uid=[USERNAME];pwd=[PASSWORD];" 
  }
}
}
```

Replace `[USERNAME]` and `[PASSWORD]` with your MySQL username and password.

5. Make sure you have MySQL Server installed and running on your machine.

6. Create a new database named "kymani_api" in MySQL.

7. Run the following command in the terminal or command prompt to apply the database migrations:

```
dotnet ef database update
```

8. Once the migrations are applied successfully, the "kymani_api" database should be populated with the necessary tables.

## Using This API

The Kymani API provides the following endpoints for interacting with kymani data:

- GET /api/kymanis: Retrieves a list of all kymanis.
- GET /api/kymanis/{id}: Retrieves the details of a specific kymani.
- PUT /api/kymanis/{id}: Updates the information of a specific kymani.
- DELETE /api/kymanis/{id}: Deletes a specific kymani.

To use these endpoints, you can send HTTP requests to the corresponding URLs using tools like Postman or cURL.

## Query Parameters

The Kymani API supports the following query parameters for filtering the list of kymanis:

- mood: Filters kymanis by mood.
- powerlevel: Filters kymanis by powerlevel.

You can include these query parameters in the URL when making a GET request to the /api/kymanis endpoint. Here's an example URL with query parameters:

```
GET http://localhost:5000/api/kymanis?mood=cool
```

This URL will retrieve a list of cool kymanis.


## Known bugs

## License

[MIT](https://opensource.org/license/mit/)

Copyright (c) 2023 Kymani Stephens