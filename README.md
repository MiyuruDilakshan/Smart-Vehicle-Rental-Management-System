# 🚗 Dam Seniya Rentals - Smart Vehicle Rental Management System

<div align="center">

![Dam Seniya Rentals Banner](https://img.shields.io/badge/Dam%20Seniya%20Rentals-Vehicle%20Management%20System-FF6B00?style=for-the-badge)
[![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)](https://docs.microsoft.com/en-us/dotnet/csharp/)
[![.NET Framework](https://img.shields.io/badge/.NET%20Framework%204.8-512BD4?style=for-the-badge&logo=.net&logoColor=white)](https://dotnet.microsoft.com/)
[![Windows Forms](https://img.shields.io/badge/Windows%20Forms-0078D6?style=for-the-badge&logo=windows&logoColor=white)](https://docs.microsoft.com/en-us/dotnet/desktop/winforms/)
[![SQL Server](https://img.shields.io/badge/SQL%20Server-CC2927?style=for-the-badge&logo=microsoft-sql-server&logoColor=white)](https://www.microsoft.com/en-us/sql-server)

**A comprehensive desktop application for managing vehicle rentals with user authentication, vehicle inventory, booking management, and payment processing**

[View Demo](#) • [Report Bug](https://github.com/yourusername/DamSeniyaRentals/issues) • [Request Feature](https://github.com/yourusername/DamSeniyaRentals/issues)

</div>

---

## 🌟 Overview

Dam Seniya Rentals is a full-featured desktop application built to streamline vehicle rental operations. This enterprise-grade Windows Forms application provides a complete solution for managing vehicle fleets, processing rentals, tracking payments, and maintaining customer records. From user registration to vehicle booking and payment history, every aspect has been designed for efficiency and ease of use.

### 🎯 The Problem I Solved

Traditional vehicle rental management faces several challenges:
- Manual booking processes prone to errors
- Lack of centralized vehicle inventory management
- Inefficient payment tracking and history
- No organized customer and driver information
- Difficulty managing multiple vehicle categories
- Limited promotional offer management

### 💡 My Solution

A comprehensive Windows desktop application built with C# and .NET Framework 4.8, featuring user authentication, dynamic vehicle catalog with category filtering, intelligent rental booking with date selection, automated payment calculations, complete rental and payment history tracking, and vehicle inventory management—all unified in a robust, user-friendly desktop platform.

---

## ✨ Key Features

### 🔐 **User Authentication System**
- Secure user registration with category selection (User/Driver/Employee)
- Login functionality with database validation
- Password visibility toggle for better UX
- Email and username management
- Input validation and error handling
- Session management across forms

### 🚙 **Dynamic Vehicle Management**
- Complete vehicle inventory system
- Category-based filtering (Car, Van, Bus, All)
- Custom vehicle cards with detailed information
- Real-time database integration
- Image display for each vehicle
- Vehicle specifications display:
  - Price per day
  - Air conditioning status
  - Gear method (Automatic/Manual)
  - Passenger capacity

### 📅 **Intelligent Rental Booking**
- Interactive date selection with calendar controls
- Pickup and drop-off date management
- Automatic rental duration calculation
- Real-time price calculation based on days
- Vehicle and offer code integration
- Driver information collection:
  - Driver name and age
  - License number validation
  - Phone number and address
- Booking confirmation and validation

### 💰 **Payment Processing & History**
- Secure payment recording system
- Payment code generation
- Cardholder name validation
- Amount verification and storage
- Complete payment history tracking
- DataGridView display for all transactions
- Delete payment records functionality
- SQL-based payment persistence

### 📊 **Rental History Management**
- Comprehensive rental records display
- DataGridView-based history viewing
- Complete rental information tracking:
  - Vehicle details
  - Rental dates
  - Driver information
  - Payment amounts
- Delete rental records capability
- Real-time database synchronization

### 🎁 **Promotional Offers System**
- Dedicated offers display page
- Offer code integration with rentals
- Promotional pricing support
- Visual offer presentations
- Promo code validation

### ⚙️ **Administrative Settings**
- Vehicle addition interface
- Complete vehicle details input:
  - Vehicle name and code
  - Per-day payment rates
  - Offer codes and promotions
  - Gear method selection
  - Image path configuration
  - Passenger count
  - Category assignment
  - Air conditioning status
- Input validation and data persistence
- Clear and save functionality

### 🗺️ **Location Integration**
- Google Maps integration for location services
- Direct navigation to rental location
- External browser launch for maps

### 🎨 **Professional User Interface**
- Modern Windows Forms design
- Consistent navigation sidebar
- Visual feedback for user actions
- Responsive layout design
- Custom vehicle card components
- Calendar controls for date selection
- NumericUpDown controls for precise input
- RichTextBox controls for detailed information

---

## 🛠️ Technology Stack

### **Desktop Application**
- **C# Programming Language** - Core application logic
- **Windows Forms** - Rich desktop UI framework
- **.NET Framework 4.8** - Application runtime
- **Visual Studio** - Development environment

### **Database**
- **Microsoft SQL Server LocalDB** - Local database engine
- **ADO.NET** - Database connectivity
- **SqlConnection** - Database connection management
- **SqlCommand** - SQL query execution
- **SqlDataAdapter** - Data retrieval and binding
- **DataTable** - In-memory data representation

### **UI Components**
- **FlowLayoutPanel** - Dynamic vehicle card layout
- **DataGridView** - Tabular data display
- **MonthCalendar** - Date selection interface
- **NumericUpDown** - Numeric input controls
- **RichTextBox** - Multi-line text input
- **ComboBox** - Dropdown selection
- **PictureBox** - Image display
- **Custom UserControls** - Reusable vehicle cards

### **Core Technologies**
- **System.Data.SqlClient** - SQL Server connectivity
- **System.Windows.Forms** - Windows Forms framework
- **System.Drawing** - Image and graphics handling
- **System.Diagnostics** - External process management

---

## 🏗️ System Architecture

```
┌──────────────────────────────────────────────────────┐
│              Windows Forms Application               │
│                  (Presentation Layer)                │
│                                                       │
│  ┌────────────────────────────────────────────────┐ │
│  │  Login & Registration Forms                    │ │
│  │  - Login.cs                                    │ │
│  │  - Registration.cs (reglog)                   │ │
│  └────────────────────────────────────────────────┘ │
│                                                       │
│  ┌────────────────────────────────────────────────┐ │
│  │  Main Application Forms                        │ │
│  │  - Home.cs (dashboard)                        │ │
│  │  - vehicles.cs                                │ │
│  │  - Renting.cs                                 │ │
│  │  - Offers.cs                                  │ │
│  │  - Settings.cs                                │ │
│  └────────────────────────────────────────────────┘ │
│                                                       │
│  ┌────────────────────────────────────────────────┐ │
│  │  History & Payment Forms                       │ │
│  │  - RentingHistory.cs                          │ │
│  │  - PaymentHistory.cs                          │ │
│  │  - pay here.cs (Form3)                        │ │
│  └────────────────────────────────────────────────┘ │
│                                                       │
│  ┌────────────────────────────────────────────────┐ │
│  │  Custom Components                             │ │
│  │  - vehicleCard.cs (UserControl)               │ │
│  └────────────────────────────────────────────────┘ │
└───────────────────┬──────────────────────────────────┘
                    │
                    │ ADO.NET (SqlConnection)
                    ▼
┌──────────────────────────────────────────────────────┐
│           SQL Server LocalDB                          │
│         (DamSeniyaRentals.mdf)                       │
│                                                       │
│  ┌────────────────────────────────────────────────┐ │
│  │  Users Table                                   │ │
│  │  - Username, Password, Email, Category        │ │
│  └────────────────────────────────────────────────┘ │
│                                                       │
│  ┌────────────────────────────────────────────────┐ │
│  │  Vehicles Table                                │ │
│  │  - vehicle_name, vehicle_code, category       │ │
│  │  - perdaypayment, gear_method, image_path     │ │
│  │  - passengercount, AirConditioned, promo      │ │
│  └────────────────────────────────────────────────┘ │
│                                                       │
│  ┌────────────────────────────────────────────────┐ │
│  │  Rentals Table                                 │ │
│  │  - VehicleName, VehicleCode, OfferCode        │ │
│  │  - PickupDate, DropoffDate, Payment           │ │
│  │  - DriverName, DriverAge, LicenseNumber       │ │
│  │  - PhoneNumber, Address                       │ │
│  └────────────────────────────────────────────────┘ │
│                                                       │
│  ┌────────────────────────────────────────────────┐ │
│  │  Payments Table                                │ │
│  │  - PaymentId, PaymentCode, Amount             │ │
│  │  - HolderName                                 │ │
│  └────────────────────────────────────────────────┘ │
└──────────────────────────────────────────────────────┘
```

---

## 🚀 Getting Started

### Prerequisites

Before you begin, ensure you have the following installed:
- **Visual Studio 2019** or higher (with .NET desktop development workload)
- **.NET Framework 4.8** Developer Pack
- **SQL Server LocalDB** (included with Visual Studio)
- **Windows OS** (Windows 7 or higher)

### Installation

#### 1️⃣ Clone or Download the Repository

```bash
# If using Git
git clone https://github.com/MiyuruDilakshan/Smart-Vehicle-Rental-Management-System.git
cd Smart-Vehicle-Rental-Management-System

# Or download and extract the ZIP file
```

#### 2️⃣ Database Setup

**Option A: Attach Existing Database**
1. Locate the `DamSeniyaRentals.mdf` and `DamSeniyaRentals_log.ldf` files
2. Copy them to your desired location
3. Update the connection string in all C# files

**Option B: Create New Database**

Open SQL Server Management Studio or Visual Studio SQL Server Object Explorer and execute:

```sql
-- Create the database
CREATE DATABASE DamSeniyaRentals;
GO

USE DamSeniyaRentals;
GO

-- Create Users table
CREATE TABLE Users (
    UserId INT PRIMARY KEY IDENTITY(1,1),
    Username VARCHAR(100) NOT NULL UNIQUE,
    Password VARCHAR(255) NOT NULL,
    Email VARCHAR(255) NOT NULL,
    Category VARCHAR(50) NOT NULL CHECK (Category IN ('User', 'Driver', 'Employee'))
);
GO

-- Create vehicles table
CREATE TABLE vehicles (
    vehicle_name VARCHAR(100) NOT NULL,
    vehicle_code VARCHAR(50) PRIMARY KEY NOT NULL,
    perdaypayment VARCHAR(50) NOT NULL,
    offercode VARCHAR(50) NULL,
    promo VARCHAR(50) NULL,
    gear_method VARCHAR(50) NULL,
    image_path VARCHAR(255) NULL,
    passengercount INT NOT NULL,
    category VARCHAR(50) NOT NULL CHECK (category IN ('Car', 'Van', 'Bus', 'All')),
    AirConditioned VARCHAR(10) NULL
);
GO

-- Create Rentals table
CREATE TABLE Rentals (
    RentalID INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
    VehicleName VARCHAR(100) NOT NULL,
    VehicleCode VARCHAR(50) NOT NULL,
    OfferCode VARCHAR(50) NULL,
    PickupDate DATETIME NOT NULL,
    DropoffDate DATETIME NOT NULL,
    DriverName VARCHAR(100) NOT NULL,
    DriverAge INT NOT NULL,
    LicenseNumber VARCHAR(50) NOT NULL,
    PhoneNumber VARCHAR(20) NOT NULL,
    Address VARCHAR(200) NOT NULL,
    Payment DECIMAL(10, 2) NOT NULL
);
GO

-- Create Payments table
CREATE TABLE Payments (
    PaymentId INT PRIMARY KEY IDENTITY(1,1),
    PaymentCode VARCHAR(100) NOT NULL,
    Amount DECIMAL(10, 2) NOT NULL,
    HolderName VARCHAR(255) NOT NULL,
    CreatedAt DATETIME DEFAULT GETDATE()
);
GO
```

#### 3️⃣ Update Connection Strings

Update the connection string in the following files with your database path:

- `Login.cs`
- `Registration.cs`
- `Home.cs`
- `vehicles.cs`
- `Renting.cs`
- `pay here.cs`
- `PaymentHistory.cs`
- `RentingHistory.cs`
- `Settings.cs`

```csharp
private string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename='YOUR_PATH\\DamSeniyaRentals.mdf';Integrated Security=True;Connect Timeout=30";
```

Replace `YOUR_PATH` with the actual path to your database file.

#### 4️⃣ Configure Image Paths

Update image paths in `vehicleCard.cs`:

```csharp
string defaultImagePath = @"YOUR_PATH\images\DS logo.png";
```

Ensure all images are placed in the `images` folder.

#### 5️⃣ Build the Project

1. Open `Dam Seniya Rentals.sln` in Visual Studio
2. Restore NuGet packages (if any)
3. Build the solution: **Build → Build Solution** (Ctrl+Shift+B)
4. Resolve any build errors related to missing references

#### 6️⃣ Run the Application

1. Set `Program.cs` as the startup file
2. Press **F5** or click **Start** to run the application
3. The login form will appear as the initial window

---

## 📂 Project Structure

```
Smart-Vehicle-Rental-Management-System/
├── Dam Seniya Rentals.sln          # Visual Studio solution file
├── Dam Seniya Rentals.csproj       # Project configuration
├── App.config                       # Application configuration
├── DamSeniyaRentals.mdf            # SQL Server database file
├── DamSeniyaRentals_log.ldf        # Database log file
│
├── Program.cs                       # Application entry point
├── Class1.cs                        # Additional class file
│
├── Authentication/
│   ├── Login.cs                     # Login form logic
│   ├── Login.Designer.cs            # Login form designer
│   ├── Login.resx                   # Login form resources
│   ├── Registration.cs              # Registration form logic
│   ├── Registration.Designer.cs     # Registration form designer
│   └── Registration.resx            # Registration form resources
│
├── Main Forms/
│   ├── Home.cs                      # Dashboard form logic
│   ├── Home.resx                    # Dashboard form resources
│   ├── vehicles.cs                  # Vehicles display form
│   ├── vehicles.Designer.cs         # Vehicles form designer
│   ├── vehicles.resx                # Vehicles form resources
│   ├── Renting.cs                   # Rental booking form
│   ├── Renting.Designer.cs          # Renting form designer
│   ├── Renting.resx                 # Renting form resources
│   ├── Offers.cs                    # Offers display form
│   ├── Offers.Designer.cs           # Offers form designer
│   └── Offers.resx                  # Offers form resources
│
├── Management Forms/
│   ├── Settings.cs                  # Vehicle management form
│   ├── Settings.Designer.cs         # Settings form designer
│   ├── Settings.resx                # Settings form resources
│   ├── RentingHistory.cs            # Rental history form
│   ├── RentingHistory.Designer.cs   # Rental history designer
│   ├── RentingHistory.resx          # Rental history resources
│   ├── PaymentHistory.cs            # Payment history form
│   ├── PaymentHistory.Designer.cs   # Payment history designer
│   └── PaymentHistory.resx          # Payment history resources
│
├── Payment/
│   ├── pay here.cs                  # Payment processing form
│   ├── pay here.Designer.cs         # Payment form designer
│   └── pay here.resx                # Payment form resources
│
├── Components/
│   ├── vehicleCard.cs               # Custom vehicle card control
│   ├── vehicleCard.Designer.cs      # Vehicle card designer
│   └── vehicleCard.resx             # Vehicle card resources
│
├── Properties/
│   ├── AssemblyInfo.cs              # Assembly metadata
│   ├── Resources.Designer.cs        # Resource designer
│   ├── Resources.resx               # Application resources
│   ├── Settings.Designer.cs         # Settings designer
│   └── Settings.settings            # Application settings
│
├── System/
│   └── Configuration/
│       └── ConfigurationManager.cs  # Configuration management
│
├── Database Scripts/
│   ├── SQLQuery1.sql                # Rentals table creation
│   ├── SQLQuery2.sql                # Vehicles table creation
│   ├── SQLQuery3.sql                # Alter vehicles table
│   └── SQLQuery5.sql                # Updated vehicles schema
│
├── images/                          # Application images
│   ├── DS logo.png                  # Company logo
│   ├── home vehicle.jpeg            # Home page image
│   ├── buddy van.png                # Vehicle images
│   ├── bus1.png
│   ├── dolphin.jpg
│   ├── elite.jpeg
│   ├── highroof.png
│   ├── KDH.jpg
│   ├── premio.jpeg
│   ├── prius.jpg
│   ├── wagon r.jpeg
│   ├── gear.png                     # Feature icons
│   ├── km.png
│   ├── passengers.png
│   ├── ventilation.png
│   ├── offer 1.png                  # Promotional images
│   ├── offer 2.jpeg
│   ├── offer 3.jpeg
│   ├── home.png                     # Navigation icons
│   ├── offers.png
│   ├── pay here.png
│   ├── renting.png
│   ├── settings.png
│   └── vehicles.png
│
└── bin/                             # Compiled binaries
    ├── Debug/
    └── Release/
```

---

## 💻 My Contributions

As the **Full-Stack Desktop Developer** on this project, I architected and implemented the entire application:

### 🏛️ **Application Architecture & Design**
- Designed complete Windows Forms architecture with form navigation
- Architected normalized SQL Server database schema
- Created custom reusable UserControl components
- Implemented ADO.NET data access layer
- Designed form-to-form communication pattern

### 💻 **Backend Development**
- Developed secure user authentication system with database validation
- Implemented complete CRUD operations for all entities
- Built rental booking logic with automatic price calculation
- Created payment processing and recording system
- Developed vehicle inventory management with filtering
- Implemented data validation and error handling across all forms

### 🎨 **Frontend Development**
- Built responsive Windows Forms UI with custom styling
- Implemented dynamic vehicle card generation using FlowLayoutPanel
- Created interactive date selection with MonthCalendar controls
- Developed DataGridView-based history displays
- Designed consistent navigation sidebar across all forms
- Implemented visual feedback and user-friendly error messages

### 🗄️ **Database Design & Implementation**
- Designed and implemented relational database schema
- Created Users, Vehicles, Rentals, and Payments tables
- Implemented proper data types and constraints
- Configured LocalDB for development and deployment
- Optimized queries for performance

### 🔒 **Security & Data Integrity**
- Implemented SQL parameterized queries preventing SQL injection
- Built secure user authentication system
- Added input validation on all forms
- Implemented proper exception handling
- Ensured data consistency across transactions

### 🧩 **Component Development**
- Created custom `vehicleCard` UserControl for dynamic vehicle display
- Implemented reusable form navigation patterns
- Built modular form components for maintainability
- Developed configuration management system

---

## 🎯 Key Technical Highlights

### **Form Navigation System**
Implemented seamless navigation between forms with consistent sidebar:
- Dashboard (Home)
- Vehicles (Browse and Filter)
- Renting (Booking Form)
- Offers (Promotions)
- Rental History
- Payment History
- Settings (Vehicle Management)

### **Dynamic Vehicle Display**
Custom vehicle card system with:
- Database-driven vehicle loading
- Category-based filtering
- Image display with fallback handling
- Real-time price and specification display
- Navigation to booking form with context

### **Rental Calculation Logic**
Intelligent booking system featuring:
- Date range selection with validation
- Automatic duration calculation (days)
- Real-time total price computation
- Per-day rate integration
- Offer code application

### **Data Management**
Robust data handling with:
- SqlConnection for database connectivity
- SqlDataAdapter for data retrieval
- DataTable for in-memory operations
- DataGridView for tabular display
- Prepared statements for security

---

## 🎬 Application Flow

### **User Journey**

1. **Authentication**: 
   - Register new account (User/Driver/Employee)
   - Login with credentials
   - Navigate to dashboard

2. **Browse Vehicles**:
   - View all available vehicles
   - Filter by category (Car/Van/Bus)
   - See vehicle specifications
   - Click "Book Now" on desired vehicle

3. **Make Booking**:
   - Enter vehicle and offer details
   - Select pickup and drop-off dates
   - Enter driver information
   - Review automatic price calculation
   - Submit rental booking

4. **Process Payment**:
   - Enter payment code
   - Provide cardholder name
   - Confirm payment amount
   - Submit payment

5. **View History**:
   - Check rental history
   - Review payment records
   - Delete old records if needed

### **Admin Operations**

1. **Vehicle Management**:
   - Access Settings form
   - Add new vehicles with complete details
   - Upload vehicle images
   - Set pricing and promotions
   - Categorize vehicles

2. **Record Management**:
   - View all rental records
   - Monitor payment transactions
   - Delete outdated records
   - Track business operations

---

## 🔮 Future Enhancements

### **Phase 1: Enhanced Features**
- Vehicle availability calendar
- Real-time availability checking
- Automated email confirmations
- PDF receipt generation
- Advanced search and filtering

### **Phase 2: Business Intelligence**
- Revenue reporting and analytics
- Popular vehicle tracking
- Customer behavior analysis
- Seasonal trend reporting
- Booking forecasting

### **Phase 3: User Experience**
- Mobile app version
- Online booking portal (Web)
- Multi-location support
- Real-time notifications
- Customer reviews and ratings

### **Phase 4: Advanced Functionality**
- Integration with payment gateways
- GPS vehicle tracking
- Insurance management
- Maintenance scheduling
- Loyalty rewards program

---

## 🐛 Troubleshooting

### Common Issues and Solutions

**Issue**: Database connection fails
```
Solution:
1. Verify SQL Server LocalDB is installed
2. Check connection string path to .mdf file
3. Ensure database file is not corrupted
4. Update connection string with correct path
5. Check Windows authentication permissions
```

**Issue**: Images not displaying
```
Solution:
1. Verify image files exist in the images folder
2. Check image_path in database matches actual file path
3. Update vehicleCard.cs with correct default image path
4. Ensure image files are included in project
```

**Issue**: Form navigation not working
```
Solution:
1. Check all forms are properly instantiated
2. Verify form references are correct
3. Ensure forms are added to project
4. Review form constructor initialization
```

**Issue**: Data not saving to database
```
Solution:
1. Verify connection string is correct
2. Check SQL query syntax
3. Ensure all parameters are properly bound
4. Review database constraints and data types
5. Check for SQL exceptions in error messages
```

---

## 📊 Database Schema

### **Users Table**
| Column | Type | Constraints | Description |
|--------|------|-------------|-------------|
| UserId | INT | PRIMARY KEY, IDENTITY | Unique user identifier |
| Username | VARCHAR(100) | NOT NULL, UNIQUE | User login name |
| Password | VARCHAR(255) | NOT NULL | User password |
| Email | VARCHAR(255) | NOT NULL | Email address |
| Category | VARCHAR(50) | NOT NULL, CHECK | User role (User/Driver/Employee) |

### **Vehicles Table**
| Column | Type | Constraints | Description |
|--------|------|-------------|-------------|
| vehicle_code | VARCHAR(50) | PRIMARY KEY | Unique vehicle identifier |
| vehicle_name | VARCHAR(100) | NOT NULL | Vehicle name/model |
| category | VARCHAR(50) | NOT NULL, CHECK | Car/Van/Bus/All |
| perdaypayment | VARCHAR(50) | NOT NULL | Daily rental rate |
| offercode | VARCHAR(50) | NULL | Associated offer code |
| promo | VARCHAR(50) | NULL | Promotional discount |
| gear_method | VARCHAR(50) | NULL | Automatic/Manual |
| image_path | VARCHAR(255) | NULL | Path to vehicle image |
| passengercount | INT | NOT NULL | Passenger capacity |
| AirConditioned | VARCHAR(10) | NULL | AC availability |

### **Rentals Table**
| Column | Type | Constraints | Description |
|--------|------|-------------|-------------|
| RentalID | INT | PRIMARY KEY, IDENTITY | Unique rental identifier |
| VehicleName | VARCHAR(100) | NOT NULL | Rented vehicle name |
| VehicleCode | VARCHAR(50) | NOT NULL | Rented vehicle code |
| OfferCode | VARCHAR(50) | NULL | Applied offer code |
| PickupDate | DATETIME | NOT NULL | Rental start date |
| DropoffDate | DATETIME | NOT NULL | Rental end date |
| DriverName | VARCHAR(100) | NOT NULL | Driver full name |
| DriverAge | INT | NOT NULL | Driver age |
| LicenseNumber | VARCHAR(50) | NOT NULL | Driving license number |
| PhoneNumber | VARCHAR(20) | NOT NULL | Contact number |
| Address | VARCHAR(200) | NOT NULL | Driver address |
| Payment | DECIMAL(10,2) | NOT NULL | Total rental amount |

### **Payments Table**
| Column | Type | Constraints | Description |
|--------|------|-------------|-------------|
| PaymentId | INT | PRIMARY KEY, IDENTITY | Unique payment identifier |
| PaymentCode | VARCHAR(100) | NOT NULL | Payment reference code |
| Amount | DECIMAL(10,2) | NOT NULL | Payment amount |
| HolderName | VARCHAR(255) | NOT NULL | Cardholder name |
| CreatedAt | DATETIME | DEFAULT GETDATE() | Payment timestamp |

---

## 📄 License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

---

## 🔗 Links

**Project Repository**: [https://github.com/MiyuruDilakshan/DamSeniyaRentals](https://github.com/MiyuruDilakshan/DamSeniyaRentals)

**Demo Video**: [Coming Soon](#)

---

## 📞 Contact

- 📧 **Email**: [Miyurudilakshan@gmail.com](mailto:Miyurudilakshan@gmail.com)
- 🌐 **Website**: [miyuru.dev](https://miyuru.dev)
- 💼 **LinkedIn**: [linkedin.com/in/miyurudilakshan](https://www.linkedin.com/in/miyurudilakshan/)
- 🐙 **GitHub**: [github.com/miyurudilakshan](https://github.com/miyurudilakshan)

---

## 🙏 Acknowledgments

- **Microsoft .NET Team** for the robust Windows Forms framework
- **SQL Server Team** for reliable LocalDB solution
- **C# Community** for comprehensive documentation
- **Visual Studio** for powerful IDE features
- **Stack Overflow Community** for technical guidance

---

<div align="center">

**Built with 🚗 and passion for efficient rental management**

*Transforming vehicle rental operations, one booking at a time*

⭐ **Star this repository if you found it helpful!** ⭐

</div>
