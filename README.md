# Clients API

RESTful API built with ASP.NET Core for managing clients.
Implements a layered architecture (Controller, Service, Repository) and uses Entity Framework Core with an in-memory database.

---

## 📌 Features

* CRUD operations for clients
* Clean architecture (Controller → Service → Repository)
* Entity Framework Core (In-Memory database)
* Swagger for API documentation and testing
* Cross-platform support (Windows & Linux)

---

## 🛠️ Technologies

* .NET 8 (LTS)
* ASP.NET Core Web API
* Entity Framework Core
* Swashbuckle (Swagger)

---

## 🚀 Getting Started

### 1. Clone the repository

```bash
git clone https://github.com/KillerZeus666/clients-api.git
cd clients-api
```

---

### 2. Install dependencies

```bash
dotnet restore
```

---

### 3. Run the application

```bash
dotnet run
```

---

## 🌐 API Endpoints

Base URL:

```
http://localhost:5183/api/clientes
```

### 🔹 Get all clients

```
GET /api/clientes
```

### 🔹 Get client by ID

```
GET /api/clientes/{id}
```

### 🔹 Create client

```
POST /api/clientes
```

Example body:

```json
{
  "nombre": "Carlos",
  "correo": "carlos@mail.com"
}
```

### 🔹 Delete client

```
DELETE /api/clientes/{id}
```

---

## 🧪 API Testing

Swagger UI is available at:

```
http://localhost:5183/swagger
```

---

## 📂 Project Structure

```
ClientsApi/
│
├── Controllers/
├── Services/
├── Repositories/
├── Models/
├── Data/
└── Program.cs
```

---

## ⚠️ Notes

* The database is in-memory → data resets when the app restarts.
* Designed for learning and demonstration purposes.

---

## 👩‍💻 Author

Developed by [Your Name]

---
