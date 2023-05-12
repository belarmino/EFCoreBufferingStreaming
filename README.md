# Entity Framework Core performance improvements
## Streaming vs buffering

Better way to read data from database use Entity Framework Core

## Run a project
```
dotnet run --configuration Release 
```
## To create a new project
### Create a console project
```
dotnet new console -o EFCoreBufferingStreaming
cd EFCoreBufferingStreaming
dotnet new gitignore
```

### EF tools
```
dotnet tool install --global dotnet-ef
```
### Add EF library
```
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
dotnet add package Microsoft.EntityFrameworkCore.Design
```

### Create and apply migration
```
dotnet ef migrations add Person
dotnet ef database update
```