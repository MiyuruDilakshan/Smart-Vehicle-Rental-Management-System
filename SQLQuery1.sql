CREATE TABLE Rentals (
    RentalID INT PRIMARY KEY NOT NULL,
    VehicleName VARCHAR(100) NOT NULL,
    VehicleCode VARCHAR(50) NOT NULL,
    OfferCode VARCHAR(50) NOT NULL,
    PickupDate DATETIME NOT NULL,
    DropoffDate DATETIME NOT NULL,
    DriverName VARCHAR(100) NOT NULL,
    DriverAge INT NOT NULL,
    LicenseNumber VARCHAR(50) NOT NULL,
    PhoneNumber VARCHAR(20) NOT NULL,
    Address VARCHAR(200) NOT NULL,
    Payment DECIMAL(10, 2) NOT NULL
);
