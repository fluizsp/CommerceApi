# Commerce API Project
## About The Project
Welcome to the Commerce API project! This project is a .NET Core Web API designed to simulate a simple commerce system, featuring a range of functionalities from product listings to customer management.

The Commerce API is structured around key entities such as products, customers, orders, and order details, providing a solid foundation for a commerce-related application. Whether you're interested in how .NET Core APIs are built or looking for inspiration for your projects, I hope you find this project both informative and engaging.

### Built With

- **[.NET Core](https://dotnet.microsoft.com/download)**: For creating high-performance, cross-platform web APIs.
- **[Entity Framework Core](https://docs.microsoft.com/en-us/ef/core/)**: For data access.
- **[Swagger](https://swagger.io/)**: For API documentation and testing.
- **[SQL Server 2022 Developer Edition](https://www.microsoft.com/en-us/sql-server/sql-server-downloads)**: As the database back-end.

## Getting Started

To get a local copy up and running, follow these simple steps.

### Prerequisites

- [.NET Core SDK](https://dotnet.microsoft.com/download)
- [SQL Server 2022 Developer Edition](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) or any SQL Server version compatible with .NET Core.
- [Visual Studio Code](https://code.visualstudio.com/) or any preferred IDE with C# support.


### Installation
#### Clone the repository

```
git clone https://github.com/fluizsp/CommerceApi.git
```

#### Navigate to the project directory
````
cd CommerceApi
````

#### Restore dependencies
````
dotnet restore
````

#### Set up the database

Execute the SQL script provided in the Database_Scripts folder to create and populate your database.

#### Update the database connection string

Modify the appsettings.json file with your SQL Server connection details.

### Run the application

````
dotnet run
````

### Access Swagger UI

Navigate to https://localhost:5001/swagger to view the API documentation and test endpoints.

## Usage
This API project can be used as a template for creating your commerce system or as a reference for learning how to build and document a .NET Core API. Explore creating, reading, updating, and deleting (CRUD) operations on products and customers, and see how these operations are implemented in a RESTful service.

## Contributing
Contributions are what make the open-source community such an amazing place to learn, inspire, and create. Any contributions you make are greatly appreciated.

## Fork the Project
Create your Feature Branch (git checkout -b feature/AmazingFeature)
Commit your Changes (git commit -m 'Add some AmazingFeature')
Push to the Branch (git push origin feature/AmazingFeature)
Open a Pull Request

## License
Distributed under the MIT License. See LICENSE for more information.

## Contact
Fábio Luiz - https://github.com/fluizsp/

Project Link: https://github.com/fluizsp/commerceapi
