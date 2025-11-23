CREATE TABLE vehicles (
    vehicle_code INT IDENTITY(1,1) PRIMARY KEY,
    vehicle_name VARCHAR(50) NOT NULL,
    category VARCHAR(10) NOT NULL CHECK (category IN ('Car', 'Van', 'Bus', 'Other')),
    perdaypayment DECIMAL(10, 2) NOT NULL,
    offercode VARCHAR(50) NULL,
    Promo VARCHAR(50) NULL
);
