# Entity Framework Core performance improvements
## Streaming vs buffering

Better way to read data from database use Entity Framework Core

### Run a project
```
dotnet run --configuration Release 
```

### Benchmarks result streaming vs buffering

|              Method |      Mean |     Error |    StdDev |      Gen0 |     Gen1 |     Gen2 |  Allocated |
|-------------------- |----------:|----------:|----------:|----------:|---------:|---------:|-----------:|
| ReadPersonBuffering | 31.206 ms | 0.6091 ms | 0.8131 ms | 1156.2500 | 500.0000 | 156.2500 | 8780.78 KB |
| ReadPersonStreaming |  1.239 ms | 0.0200 ms | 0.0167 ms |         - |        - |        - |    6.83 KB |

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
### Libraries
```
dotnet add package BenchmarkDotNet
dotnet add package Bogus
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
dotnet add package Microsoft.EntityFrameworkCore.Design
```

### Create and apply migration
```
dotnet ef migrations add Person
dotnet ef database update
```
