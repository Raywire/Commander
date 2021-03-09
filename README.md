### Prerequisites
-  [.NET Core SDK](https://dotnet.microsoft.com/download)

### Description
This is a web API that performs Create, Read, Update, and Delete (CRUD) operations

### Run the project
```bash
dotnet run
```

### Build the project
```bash
dotnet build
```

### Install nuget packages
```bash
dotnet restore
```

### Run the tests
```bash
dotnet test
```

## API Documentation
[Postman API Documentation](https://documenter.getpostman.com/view/6831940/SVtN3BSY)

| Method  | Description| Route |
| ------------- | ------------- | ------------- |
| GET |  Get all commands | `/api/commands` |
| POST | Create a commands | `/api/commands` |
| GET |  Get a specific commands | `/api/commands/:id` |
| PUT |  Update a specific commands | `/api/commands/:id` |
| DELETE | Delete a specific commands |`/api/commands/:id` |

## Author

*   **Ryan Wire** 

## Notes
None