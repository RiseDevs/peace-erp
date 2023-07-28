| Language | File         |
|----------|--------------|
| 🇺🇸 EN    | [README.md](/README.md)    |
| 🇧🇷 BR    | [README_BR.md](/README_BR.md) |

# Welcome to Peace ERP!

This application is intended to be used by NGOs (non governamental organizations), preferably by social NGOs.

# Contribution
To contribute, take a look at our "Contribution Guide" (TBD)

# Language
This application will use C# with .NET Core 7

# Architecture
The architecture to be used is the [Clean Architecture](https://www.youtube.com/watch?v=o_TH-Y78tt4).
<br><img alt="Image from Clean Architecture" src="/img/clean_architecture.jpg" width="400"/>

If you don't mind what we're talking about, think this model:
<br><img alt="Image from Clean Architecture layer distribution" src="/img/ca_layers.png" width="600" />

<details>
<summary>Folder structure</summary>

```
📁 Data                                // Data layer (Take care of Disk and Cloud)
  📁 Features                          // Data features
    📁 Categories                      // Everything related to Category inside Data
      📁 Repositories                  // Category Repositories
        📁 Cloud                       // Everything related to cloud (Eg: APIs)
          📁 Mappers                   // Mappers to cloud classes
            📄 CategoryRestMapper      // Mapper for cloud CategoryRest
            📄 UserRestMapper          // Mapper for cloud UserRest
          📁 Entities                  // Entities used in cloud
                                       // (Here we can use folders to Request and Response as needed)
            📄 CategoryRest            // Category entity to be used in cloud requests to another APIs
            📄 UserRest                // User entity to be used in cloud requests to another APIs
          📄 CategoryCloudRepository   // Cloud repository implementation
          📄 ICategoryCloudRepository  // Cloud repository interface
        📁 Disk                        // Everything related to Disk (Databases, files)
          📁 Mappers                   // Mappers for disk classes
            📄 CategoryMySqlMapper     // Mapper for disk CategoryMySql
            📄 UserSqlMapper           // Mapper for disk UserMySql
          📁 Entities                  // Entities used in disk
            📄 CategoryMySql           // Disk Category entity (like Database, for example)
            📄 UserMySql               // Disk User entity (like Database, for example)
          📄 CategoryDiskRepository    // Disk repository implementation (here we can have one for MySql,
                                       // another for Postgres... but every has to implement ICategoryDiskRepository)
          📄 ICategoryDiskRepository   // Disk repository interface
      📄 CategoryService               // Implementation for Category Service
    📁 Users                           // Everything related to Users in Date (same example as above)
📁 Domain                              // Domain Layer (Logic and Business Rules)
   📁 Features                         // Application Features
     📁 Categories                     // Categories Use Cases
       📄 GetCategoriesUseCase         // Use Case to get all Categories
       📄 GetCategoryByIdUseCase       // Use Case to get a Category by id
       📄 InsertCategoryUseCase        // Use Case to insert a Category
     📁 Users                          // User Use Cases
       📄 CreateUserUseCase            // Create a new User
       📄 UserLoginUseCase             // Try to login the User
   📁 Entities                         // Business Models (Entities)
     📄 Category                       // Category
     📄 User                           // User
   📁 Repository                       // Business Interfaces
     📄 ICategoryRepository            // Interface for defining Category methods
     📄 IUserRepository                // Interface for defining User methods
📁 Presentation                        // Presentation Layer
   📁 Exceptions                       // API return exceptions
     📄 CategoryIdNotFound             // Exception thrown when category not found
     📄 UserLoginException             // Exception thrown when user login/password is invalid
   📁 Features                         // Application controllers
     📄 CategoryController             // Category Controller
     📄 UserController                 // User Controller
   📁 Entities                         // Templates (Entities) exclusive to the Presentation
     📁 Mappers                        // Presentation entity mappers
       📄 CategoryRequestMapper        // CategoryRequest Mapper
       📄 CategoryResponseMapper       // CategoryResponse Mapper
       📄 UserCreateRequestMapper      // UserCreateRequest Mapper
       📄 UserLoginRequestMapper       // UserLoginRequest Mapper
       📄 UserResponseMapper           // UserResponse Mapper
     📁 Requests                       // In API's we use to define input entities
       📄 CategoryRequest              // Request entity for Categories
       📄 UserCreateRequest            // Request entity for creating Users
       📄 UserLoginRequest             // User login request entity
     📁 Responses                      // In API's we use it to define the output entities
       📄 CategoryResponse             // Request entity for Category response
       📄 UserResponse                 // Request entity for User Response
```
</details>

# Packages / Frameworks / Techniques
* [Dependency Injection](https://learn.microsoft.com/en-us/dotnet/core/extensions/dependency-injection)
* [Rx.NET](https://github.com/dotnet/reactive)
* [Entity Framework Core](https://learn.microsoft.com/en-us/ef/core/)
* [Serilog](https://www.nuget.org/packages/serilog/)

# Contributors
<a href="https://github.com/RiseDevs/peace-erp/graphs/contributors"><img src="https://contrib.rocks/image?repo=RiseDevs/peace-erp" /></a>

# Authors
| [<img src="https://github.com/marcosrocha85.png?size=115" width=115><br><sub>@marcosrocha85</sub>](https://github.com/marcosrocha85) | [<img src="https://github.com/eimigueloliveir.png?size=115" width=115><br><sub>@eimigueloliveir</sub>](https://github.com/eimigueloliveir) |
| :---: | :---: |
