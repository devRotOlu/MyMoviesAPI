# 🎬 MyMoviesAPI

MyMoviesAPI is a modular ASP.NET Core Web API designed to manage movie data efficiently. It follows clean architecture principles and separates concerns across multiple layers for scalability and maintainability.

## 📁 Project Structure

- **MyMovies.API** – Entry point of the application (controllers, startup config)
- **MyMovies.Application** – Business logic and use cases
- **MyMovies.Domain** – Core entities and interfaces
- **MyMovies.Infrastructure** – Data access, external services

## 🚀 Getting Started

### Prerequisites

- [.NET SDK 8.0+](https://dotnet.microsoft.com/download)
- SQL Server or any configured database provider

### Setup

```bash
git clone https://github.com/devRotOlu/MyMoviesAPI.git
cd MyMoviesAPI
dotnet restore
dotnet build
dotnet run --project MyMovies.API
```
