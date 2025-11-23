CREATE TABLE vehicles (

    vehicle_name VARCHAR(100) NOT NULL,
    vehicle_code VARCHAR(50) PRIMARY KEY NOT NULL, -- Unique vehicle code
    perdaypayment VARCHAR(50) NOT NULL,
    offercode VARCHAR(50) NULL,
    promo VARCHAR(50) NULL,
    gear_method VARCHAR(50) NULL, -- Optional gear method column
    image_path VARCHAR(255) NULL, -- Path to image
    passengercount INT NOT NULL, -- Number of passengers
    category VARCHAR (50) NOT NULL 
);
