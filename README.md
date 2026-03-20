# 🚀 Redis Demo with .NET Console Application

---

## 📌 Overview

This project demonstrates a **basic Redis integration in a .NET Console Application** using the `StackExchange.Redis` library.

The application connects to a local Redis server, stores a value, retrieves it, and displays the result in the console.

---

## 🎯 Objective

* Understand how Redis works with .NET
* Perform basic operations:

  * Store data (SET)
  * Retrieve data (GET)
* Build a foundation for **caching and high-performance systems**

---

## 🧩 Technologies Used

* .NET Console Application
* Redis (running locally via Docker)
* StackExchange.Redis (official .NET Redis client)

---

## ⚙️ Setup Instructions

### 🔹 1. Run Redis using Docker

```bash
docker run -d -p 6379:6379 redis
```

---

### 🔹 2. Install Required Package

```bash
dotnet add package StackExchange.Redis
```

---

### 🔹 3. Run the Application

```bash
dotnet run
```

---

## 🧠 Implementation Details

---

### 🔹 Redis Service

This service handles connection and basic Redis operations.

```csharp
public class RedisService
{
    private readonly IDatabase _db;

    public RedisService()
    {
        var redis = ConnectionMultiplexer.Connect("localhost:6379");
        _db = redis.GetDatabase();
    }

    public async Task SetAsync(string key, string value)
    {
        await _db.StringSetAsync(key, value);
    }

    public async Task<string> GetAsync(string key)
    {
        return await _db.StringGetAsync(key);
    }
}
```

---

### 🔹 Program Flow

```csharp
var redis = new RedisService();

// Save data
await redis.SetAsync("name", "Deepanshu 🔥");

// Get data
var value = await redis.GetAsync("name");

Console.WriteLine(value);

Console.ReadLine();
```

---

## 🔄 Execution Flow

```plaintext
Application → RedisService → Redis Server
                    ↓
                Store Data
                    ↓
               Retrieve Data
                    ↓
               Display Output
```

---

## 🎯 Output

```plaintext
Deepanshu 🔥
```

---

## 🧠 Key Learnings

* Redis is a **fast in-memory key-value store**
* Used for:

  * Caching
  * Session storage
  * Performance optimization
* `StackExchange.Redis` is used to interact with Redis in .NET
* Basic operations:

  * `SET` → store data
  * `GET` → retrieve data

---

## 🚀 Future Enhancements

* Add key expiration (TTL)
* Implement caching in Web API
* Use Redis for rate limiting
* Integrate Redis with background jobs

---
## 📌 Conclusion

This is a foundational implementation of Redis in .NET, which can be extended to build **scalable and high-performance applications**.
