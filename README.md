# 🛰️ SignalR - Real-time Communication Project

**ASP.NET Core SignalR ile geliştirilmiş gerçek zamanlı iletişim uygulaması / Real-time communication app built with ASP.NET Core SignalR**

[![.NET](https://img.shields.io/badge/.NET-6.0-512bd4?logo=dotnet)](https://dotnet.microsoft.com/en-us/)
[![C#](https://img.shields.io/badge/Language-C%23-blue.svg)](https://learn.microsoft.com/dotnet/csharp/)
[![SQL Server](https://img.shields.io/badge/Database-SQL_Server-CC2927.svg)](https://www.microsoft.com/sql-server)
[![SignalR](https://img.shields.io/badge/RealTime-SignalR-success.svg)](https://learn.microsoft.com/aspnet/core/signalr)

---

## 🚀 Özellikler / Features

| 🇹🇷 Türkçe                                                                      | 🇬🇧 English                                                                          |
| -------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| ASP.NET Core SignalR ile gerçek zamanlı bildirimler ve chat                      | Real-time notifications and chat with ASP.NET Core SignalR                            |
| Katmanlı mimari (EntityLayer / DataAccessLayer / BusinessLayer / WebApi / WebUI) | Layered architecture (EntityLayer / DataAccessLayer / BusinessLayer / WebApi / WebUI) |
| DTO ve AutoMapper ile veri taşınması                                             | Data transfer using DTO & AutoMapper                                                  |
| Repository & Generic Repository Pattern                                          | Repository & Generic Repository Pattern                                               |
| Fluent Validation ile model doğrulama                                            | Model validation with Fluent Validation                                               |
| Swagger ile API dokümantasyonu                                                   | API documentation via Swagger                                                         |
| SignalR Hub ile anlık veri aktarımı                                              | Real-time data transfer with SignalR Hub                                              |
| WebUI üzerinden canlı veri tüketimi                                              | Live data consumption through WebUI                                                   |
| Gerçek zamanlı kullanıcı etkileşimi                                              | Real-time user interaction                                                            |
| Modern ve sürdürülebilir proje yapısı                                            | Modern and maintainable project structure                                             |

---

## 🏗️ Mimari / Architecture

```text
SignalR/
├── SignalR.EntityLayer/
│   └── Entities/
│
├── SignalR.DataAccessLayer/
│   ├── Context/
│   └── Repositories/
│
├── SignalR.BusinessLayer/
│   ├── Services/
│   └── Validators/
│
├── SignalR.WebApi/
│   ├── Controllers/
│   └── Hubs/
│
├── SignalR.WebUI/
│   ├── Pages/
│   ├── Scripts/
│   └── wwwroot/
│
└── SignalR.sln
```

Katmanlı mimari sayesinde proje; sürdürülebilir, test edilebilir ve geliştirilebilir bir yapıya sahiptir.

The layered architecture provides a maintainable, testable, and scalable project structure.

---

## 🧩 Kullanılan Tasarım Yaklaşımları / Design Approaches

### Repository Pattern

Veri erişim işlemlerinin merkezi ve yönetilebilir şekilde gerçekleştirilmesini sağlar.

Provides a centralized and maintainable approach for data access operations.

---

### Generic Repository Pattern

Kod tekrarını azaltır ve veri erişim süreçlerini standartlaştırır.

Reduces code duplication and standardizes data access processes.

---

### DTO & AutoMapper

Katmanlar arasında güvenli ve performanslı veri transferi sağlar.

Provides secure and efficient data transfer between application layers.

---

### Fluent Validation

Veri doğrulama süreçlerini merkezi hale getirir.

Centralizes model validation processes.

---

### SignalR Hub Architecture

İstemci ve sunucu arasında çift yönlü gerçek zamanlı iletişim sağlar.

Enables bidirectional real-time communication between clients and server.

---

## 🛠️ Kullanılan Teknolojiler / Tech Stack

| Katman / Layer          | Teknoloji                |
| ----------------------- | ------------------------ |
| Backend                 | ASP.NET Core Web API     |
| Real-Time Communication | SignalR                  |
| ORM                     | Entity Framework Core    |
| Validation              | Fluent Validation        |
| Mapping                 | AutoMapper               |
| API Documentation       | Swagger                  |
| Database                | SQL Server               |
| Frontend                | ASP.NET Core MVC / Razor |
| Language                | C#                       |

---

## ⚙️ Kurulum / Setup

### Gereksinimler / Requirements

* .NET SDK 6.0 veya üzeri / .NET SDK 6.0 or higher
* SQL Server (Yerel veya uzak) / SQL Server (local or remote)
* Visual Studio 2022 (Önerilen) / Visual Studio 2022 (Recommended)

---

### Adımlar / Steps

#### Repoyu Klonla / Clone the Repository

```bash
git clone https://github.com/abdullahhaktan/SignalR.git

cd SignalR
```

#### Veritabanı Bağlantısını Güncelle / Update Database Connection

`appsettings.json`

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=.;Database=SignalRDb;Trusted_Connection=True;"
  }
}
```

#### Migration İşlemlerini Çalıştır / Run EF Core Migrations

```bash
dotnet ef database update
```

#### Web API Uygulamasını Başlat / Run Web API

```bash
dotnet run --project SignalR.WebApi
```

#### WebUI Uygulamasını Başlat / Run WebUI

```bash
dotnet run --project SignalR.WebUI
```

---

## 📸 Ekran Görüntüleri / Screenshots

<img width="800" height="600" alt="Giriş" src="https://github.com/user-attachments/assets/f69b977d-ae11-44f4-bcd6-88d168cc29b2" />

---

<img width="800" height="600" alt="Ekran görüntüsü 2026-02-17 123043" src="https://github.com/user-attachments/assets/e0fe7c50-9832-41ac-9c77-ca2165f5e67d" />

---

<img width="800" height="600" alt="Ekran görüntüsü 2026-06-26 114619" src="https://github.com/user-attachments/assets/eb5c5256-8e92-4422-a149-7a0f8fecfff1" />

---

<img width="800" height="600" alt="Ekran görüntüsü 2026-06-26 114659" src="https://github.com/user-attachments/assets/7d9c7416-6687-4dd4-b5d1-e19f89e62d0c" />

---

<img width="800" height="600" alt="Ekran görüntüsü 2026-06-26 114735" src="https://github.com/user-attachments/assets/6a090aaf-e236-4438-a516-c5705f7f5901" />

---

<img width="800" height="600" alt="Ekran görüntüsü 2026-06-26 114812" src="https://github.com/user-attachments/assets/719eeab9-1367-453c-a44e-9908fd62be22" />


## 👨‍💻 Mühendis & Geliştirici / Engineer & Developer

**Abdullah Haktan**

GitHub → https://github.com/abdullahhaktan

---
