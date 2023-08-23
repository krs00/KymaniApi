# Kymani Api

## Description

The Kymani API is a RESTful web service designed to manage Kymani data.

## Technologies

- C#
- .NET
- ASP.NET Core 
- Entity Framework Core
- Docker
- Docker-compose
- Github Actions

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

### Environment Variables

The Kymani API requires the following environment variables to be set:

- `MYSQL_ROOT_PASSWORD`: Password for the MySQL root user.
- `MYSQL_DATABASE`: Name of the MySQL database.
- `MYSQL_USER`: Username for connecting to the MySQL database.
- `MYSQL_PASSWORD`: Password for the MySQL user.

### Customization

The provided Docker Compose file (`docker-compose.yml`) includes placeholders for the required environment variables, but it doesn't include actual values for security reasons.

To set up your own environment variables, follow these steps:

1. Create a `.env` file in the same directory as the `docker-compose.yml` file.
2. Open the `.env` file in a text editor.
3. Replace the placeholders with your actual values. For example:

After setting up your environment variables, use the `docker-compose` command to start the Kymani API.

### Set Up
Before you start, ensure you have the following in place:

A running instance of the Kymani API on your local machine or a remote server.
A tool for making HTTP requests like cURL or Postman.

The Kymani API provides the following endpoints for interacting with kymani data:
- GET /api/kymanis: Retrieves a list of all kymanis.
- GET /api/kymanis/{id}: Retrieves the details of a specific kymani.
- PUT /api/kymanis/{id}: Updates the information of a specific kymani.
- DELETE /api/kymanis/{id}: Deletes a specific kymani.

## Endpoints for KymaniApi

1. Retrieve All Kymanis
To retrieve a list of all Kymanis, make a GET request to the /api/kymanis endpoint:

- GET http://localhost:5000/api/kymanis

2. Retrieve a Specific Kymani
To retrieve details about a specific Kymani, replace {id} with the Kymani's ID and make a GET request to the /api/kymanis/{id} endpoint:

- GET http://localhost:5000/api/kymanis/{id}

3. Update a Kymani
To update information about a Kymani, replace {id} with the Kymani's ID and make a PUT request to the /api/kymanis/{id} endpoint. Provide the updated data in the request body:

- PUT http://localhost:5000/api/kymanis/{id}

```json
{
  "Mood": "happy",
  "PowerLevel": 8
}
```

4. Delete a Kymani
To delete a Kymani, replace {id} with the Kymani's ID and make a DELETE request to the /api/kymanis/{id} endpoint:

- DELETE http://localhost:5000/api/kymanis/{id}


## Query Parameters

The Kymani API supports the following query parameters for filtering the list of kymanis:

- mood: Filters kymanis by mood.
- powerlevel: Filters kymanis by powerlevel.

You can include these query parameters in the URL when making a GET request to the /api/kymanis endpoint. Here's an example URL with query parameters:

```
GET http://localhost:5000/api/kymanis?mood=cool
```

This URL will retrieve a list of cool kymanis.

```
GET http://localhost:5000/api/kymanis?powerlevel=15
```

This URL will retrieve a list of all kymanis with a powerlevel of 15.


## License

[MIT](https://opensource.org/license/mit/)

Copyright (c) 2023 Kymani Stephens