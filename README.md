# ASP.NET Core Dependency Injection Demo

This project demonstrates the different lifetime scopes of dependency injection in ASP.NET Core:

- Singleton
- Scoped
- Transient

## Running the Project

1. Clone the repository
2. Navigate to the project directory
3. Run `dotnet run`
4. Access the API at `https://localhost:5001/DI`

## Understanding the Demo

The project includes three service types with different lifetimes:

- **Singleton**: The same instance is used throughout the application's lifetime
- **Scoped**: A new instance is created for each HTTP request
- **Transient**: A new instance is created each time the service is requested

Make multiple requests to the API endpoint to observe how the IDs change based on their lifetime scope. # DependancyInjection-ASP.Netcore
