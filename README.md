# 🚀 C# & .NET 8-Week Roadmap for AI Engineers

> **From C# Fundamentals to an End-to-End AI-Enabled Distributed System.**
> *A practical, production-oriented journey connecting Desktop Apps, Web APIs, Microservices, and AI Integration.*

---

## 🎯 Mục Tiêu Sau 8 Tuần

Sau 2 tháng, xây dựng một portfolio / project xuyên suốt theo tiến trình:
```text
Desktop App ──> Web App ──> API ──> Database ──> Architecture ──> AI Integration
```

### 🛣️ Lộ Trình Tiến Hóa Kỹ Thuật

```text
C# Fundamentals
      ↓
.NET Libraries (LINQ, I/O, Async)
      ↓
WinForms (Desktop UI & Dataset Utilities)
      ↓
WPF (XAML + Data Binding + MVVM)
      ↓
ASP.NET Core MVC & Razor
      ↓
ASP.NET Core Web API (RESTful Services)
      ↓
EF Core + Database (PostgreSQL / SQL Server)
      ↓
SOLID + Dependency Injection + Clean Architecture
      ↓
Redis Caching + JWT Auth + Middleware
      ↓
Python AI Microservice (FastAPI + YOLO / PyTorch)
      ↓
.NET + AI System (Orchestration with Docker Compose)
```

> 💡 **Triết lý cốt lõi**: Mỗi tuần đều phải có **output chạy được**, không dừng lại ở lý thuyết suông.

---

## 🗓️ Chi Tiết Roadmap 8 Tuần

### 📌 WEEK 1 — C# Fundamentals
- **Mục tiêu kiến thức**:
  - Cú pháp cơ bản: Variables, Data types, Operators, Control Flow (`if`/`switch`, loops `for`/`while`), Methods.
  - Cấu trúc dữ liệu: Array, String, `List<T>`, `Dictionary<TKey, TValue>`.
  - Exception Handling (`try-catch-finally`), File I/O cơ bản.
  - **OOP cơ bản & nâng cao**: Class, Object, Constructor, Encapsulation, Inheritance, Polymorphism, Interface, Abstract Class.
- **🎯 Output tuần 1**: `Student Management Console`
  ```text
  ========== STUDENT MANAGEMENT ==========
  1. Add student
  2. Remove student
  3. Update student
  4. Search student
  5. List students
  6. Sort students
  7. Save to file
  8. Load from file
  9. Exit
  ```
  - **Entity**: `Student` (`Id`, `Name`, `Age`, `GPA`, `Email`).
  - **Dữ liệu**: Lưu trữ định dạng JSON / CSV.
- **Definition of Done (DoD)**: Git repository, README, Source code chạy mượt mà từ đầu đến cuối, đầy đủ CRUD và File persistence.

---

### 📌 WEEK 2 — .NET Libraries
- **Mục tiêu kiến thức**:
  - `System.IO`: `File`, `Directory`, `Path`.
  - Serialization: JSON (`System.Text.Json`), CSV parsing.
  - `String`, `DateTime`, Collections.
  - **LINQ chuyên sâu**: `Where`, `Select`, `OrderBy`, `GroupBy`, `Any`, `First`/`FirstOrDefault`, `Count`, `Sum`, `Average`.
  - HTTP Client, Environment, Configuration, Logging.
- **🎯 Output tuần 2**: `File Explorer / Dataset CLI`
  - Clone CLI commands: `tree`, `copy`, `search`, `info`, `analyze`.
  ```text
  > tree ./dataset
  dataset/
  ├── train/
  │   ├── image1.jpg
  │   ├── image2.jpg
  │   └── image3.jpg
  ├── test/
  │   └── image4.jpg
  └── labels/

  > analyze dataset/
  Images: 1,284
  JPG: 1,100
  PNG: 184
  Total size: 2.3 GB
  ```
  - *Bắt đầu ứng dụng .NET trực tiếp vào AI / Data engineering workflow.*

---

### 📌 WEEK 3 — WinForms
- **Mục tiêu kiến thức**:
  - Windows Forms: Form, Controls (`Button`, `TextBox`, `Label`, `ComboBox`, `DataGridView`).
  - Event Handling, Layout, File Dialogs (`OpenFileDialog`, `FolderBrowserDialog`), Data Validation.
- **🎯 Output tuần 3**: `Dataset Manager – WinForms`
  - Chuyển hướng dự án từ Student Management sang phục vụ Computer Vision / AI Datasets.
  ```text
  ┌───────────────────────────────────────────────┐
  │              DATASET MANAGER                  │
  ├───────────────────────────────────────────────┤
  │ Dataset: [YOLO Dataset ▼]                     │
  │                                               │
  │ Images: 1,284 | Labels: 1,284 | Classes: 3    │
  │                                               │
  │ [Scan Dataset]   [Analyze]   [Export CSV]     │
  │                                               │
  │ ┌───────────────────────────────────────────┐ │
  │ │ Filename  | Size  | Label   | Valid       │ │
  │ │ img1.jpg  | 2MB   | person  | ✓           │ │
  │ │ img2.jpg  | 1MB   | car     | ✓           │ │
  │ └───────────────────────────────────────────┘ │
  └───────────────────────────────────────────────┘
  ```
- **Definition of Done (DoD)**: Chọn folder, quét dataset, đọc metadata, binding lên DataGridView, lọc/tìm kiếm, thống kê và xuất báo cáo CSV.

---

### 📌 WEEK 4 — WPF (Windows Presentation Foundation)
- **Mục tiêu kiến thức**:
  - Kiến trúc WPF: XAML, Window, Panels (`Grid`, `StackPanel`), Controls (`ListView`, `DataGrid`).
  - Data Binding (`DataContext`, `BindingMode`), Commands (`ICommand`), Resources, Styles.
  - **Mô hình MVVM (Model - View - ViewModel)**: Tách biệt rõ ràng tầng UI và tầng xử lý nghiệp vụ.
- **🎯 Output tuần 4**: `Dataset Manager WPF + MVVM`
  - Tái cấu trúc ứng dụng Tuần 3 với WPF theo chuẩn MVVM:
  ```text
  View ──> ViewModel ──> DatasetService ──> File System
  ```
  - Quản lý Explorer, File Browser, Real-time Filtering, Thống kê trực quan.

---

### 📌 WEEK 5 — ASP.NET Core MVC + Web API
- **Mục tiêu kiến thức**:
  - HTTP Protocol, Request/Response Lifecycle, Routing.
  - Mô hình MVC (Model - View - Controller), Razor Views, Forms, Model Validation.
  - Giới thiệu **ASP.NET Core Web API**: RESTful principles, JSON responses.
- **🎯 Output tuần 5**: `Dataset Management Web App`
  - Đưa Dataset Manager lên nền tảng Web:
    - `Dashboard`, `Datasets`, `Images`, `Labels`, `Users`.
    - REST Endpoints:
      ```http
      GET    /datasets
      GET    /datasets/{id}
      POST   /datasets
      PUT    /datasets/{id}
      DELETE /datasets/{id}
      ```
- **Definition of Done (DoD)**: Giao diện web tương tác được qua trình duyệt tại `http://localhost:xxxx` với đầy đủ CRUD.

---

### 📌 WEEK 6 — Database + EF Core + Authentication
- **Mục tiêu kiến thức**:
  - SQL: Queries, Joins, Aggregation, Indexes.
  - **Entity Framework Core**: `DbContext`, Entities, Migrations, Fluent API / Data Annotations, Database Relationships (1-1, 1-N, N-N).
  - **Bảo mật & Xác thực**: JWT (JSON Web Tokens), Identity, Authorization, Role-based Access Control.
- **🎯 Output tuần 6**: `Dataset Management System v2`
  - Mô hình dữ liệu:
    ```text
    User
     │
     └── Dataset
           │
           ├── Image
           │
           └── Label
    ```
  - API Endpoints:
    ```http
    POST /api/auth/register
    POST /api/auth/login
    GET  /api/datasets
    POST /api/datasets
    GET  /api/datasets/{id}
    POST /api/datasets/{id}/images
    ```
- **Definition of Done (DoD)**: Một hệ thống Backend chuẩn chỉnh với xác thực JWT và cơ sở dữ liệu quan hệ được ánh xạ qua EF Core Migrations.

---

### 📌 WEEK 7 — SOLID + DI + Clean Architecture
- **Mục tiêu kiến thức**:
  - **Nguyên lý SOLID**:
    - **S**: Single Responsibility Principle
    - **O**: Open/Closed Principle
    - **L**: Liskov Substitution Principle
    - **I**: Interface Segregation Principle
    - **D**: Dependency Inversion Principle
  - ASP.NET Core Advanced: Dependency Injection (DI container: Scoped, Transient, Singleton), Custom Middlewares, Repository Pattern, Service Layer, DTOs & AutoMapper/Mapster, Global Exception Handling, Serilog logging.
  - Caching hiệu năng cao với **Redis**.
- **🎯 Output tuần 7**: `Dataset Management System v3`
  - **Refactor code tuần 6** sang kiến trúc đa tầng chuẩn:
    ```text
    Controller ──> Service ──> Repository ──> EF Core ──> Database
    ```
  - Tích hợp Redis Caching, Validation pipeline, Exception Handling Middleware.

---

### 📌 WEEK 8 — Microservices + AI Integration + Docker
- **Mục tiêu kiến thức**:
  - Minimal API, Service Separation, Asynchronous programming (`async`/`await`).
  - Inter-service HTTP communication (`HttpClient` / `IHttpClientFactory`).
  - Container hóa với **Docker** & **Docker Compose**.
  - Xây dựng Python AI microservice (FastAPI + YOLO / PyTorch).
- **🎯 FINAL OUTPUT**: `AI Dataset & Detection Platform`
  - **Kiến trúc hệ thống**:
    ```text
                          Client (Web / CLI)
                                 │
                                 ▼
                       ┌──────────────────┐
                       │   ASP.NET Core   │
                       │   Gateway / API  │
                       └────────┬─────────┘
                                │
                      ┌─────────┴─────────┐
                      ▼                   ▼
                PostgreSQL           Python FastAPI
                                          │
                                          ▼
                                      YOLO Model
    ```
  - **Hệ thống Docker Compose**:
    ```text
    ┌───────────────────────────────────────────────┐
    │                Docker Compose                 │
    │                                               │
    │  ┌────────────┐ ┌──────────────┐ ┌─────────┐ │
    │  │ .NET Core  │ │  Python AI   │ │Postgres │ │
    │  │   API      │ │ (FastAPI+YOLO│ │Database │ │
    │  └────────────┘ └──────────────┘ └─────────┘ │
    └───────────────────────────────────────────────┘
    ```
  - **Flow phát hiện ảnh**:
    1. Client gửi ảnh: `POST /api/detection`
    2. .NET API tiếp nhận và chuyển tiếp stream ảnh qua Python AI Service.
    3. YOLO model inference và trả về kết quả dự đoán (Bounding boxes, Class, Confidence).
    4. .NET API tổng hợp, lưu log/kết quả vào PostgreSQL và trả JSON về Client:
    ```json
    {
      "image": "person.jpg",
      "detections": [
        {
          "class": "person",
          "confidence": 0.94,
          "box": [34, 56, 200, 450]
        }
      ]
    }
    ```

---

## 📌 Bảng Tổng Kết 8 Outputs

| Tuần | Chủ đề | Output Sản Phẩm |
| :---: | :--- | :--- |
| **Week 1** | C# Fundamentals & OOP | **Student Management CLI** (CRUD, JSON/CSV) |
| **Week 2** | .NET Libraries & LINQ | **File Explorer / Dataset CLI** (Tree, Copy, Analyze) |
| **Week 3** | WinForms UI | **Dataset Manager WinForms** (Grid, Filter, Scanner) |
| **Week 4** | WPF + MVVM | **Dataset Manager WPF** (XAML, Binding, MVVM) |
| **Week 5** | ASP.NET Core MVC & API | **Dataset Management Web App** (MVC + REST API) |
| **Week 6** | EF Core + Database + JWT | **Dataset Management System v2** (PostgreSQL, JWT Auth) |
| **Week 7** | SOLID + DI + Clean Code | **Dataset Management System v3** (Repo/Service, Redis) |
| **Week 8** | Services + AI Integration + Docker | **AI Dataset & Detection Platform** (.NET + YOLO + Docker) |

---

## 🧠 Lời Khuyên Cho Kỹ Sư AI Học .NET

> ⚠️ **Đừng hiểu roadmap này là 8 tuần chỉ học thuần túy .NET.**

- **Phân bổ thời gian hàng ngày (3 tiếng/ngày)**:
  - **2 giờ**: .NET Architecture & Backend Engineering.
  - **1 giờ**: AI Engineering / PyTorch / YOLO.
- **Cuối tuần**: Kết nối hai luồng kiến thức thành sản phẩm hoàn chỉnh:
  ```text
  .NET Engineering ────┐
                       ├───> AI System Engineering
  Python / Deep Learning ──┘
  ```

### 🧭 Tiêu Chuẩn Tự Kiểm Tra Mỗi Tuần
Đừng chỉ hỏi: *"Tuần này mình học được bao nhiêu bài?"*  
Hãy tự hỏi:
> **"Nếu xóa hết code của tuần này, mình có thể tự tay viết lại sản phẩm từ đầu hay không?"**
- Nếu câu trả lời là **CÓ** ➔ Tự tin bước tiếp sang tuần sau.
- Nếu câu trả lời là **CHƯA** ➔ Dành thêm thời gian làm chủ kiến thức và refactor lại project.

> 🏁 **Mục tiêu cuối cùng:** Không chỉ là *"I know C# and .NET"*, mà là:  
> **"I built an enterprise-grade AI-enabled platform using ASP.NET Core, PostgreSQL, Python/YOLO, and Docker."**
