USE StoreSample;

CREATE TABLE Shipper (
    ShipperID INT PRIMARY KEY,
    CompanyName VARCHAR(40),
    Phone VARCHAR(20)
);

CREATE TABLE Ordern (
    OrderID INT PRIMARY KEY,
    CustomerID INT,
    EmployeeID INT,
    OrderDate DATETIME,
    RequiredDate DATETIME,
    ShippedDate DATETIME,
    ShipVia INT,
    Freight DECIMAL(10, 2),
    ShipName VARCHAR(40),
    ShipAddress VARCHAR(60),
    ShipCity VARCHAR(15),
    ShipRegion VARCHAR(15),
    ShipPostalCode VARCHAR(10),
    ShipCountry VARCHAR(15)
);

CREATE TABLE OrderDetails (
    OrderID INT,
    ProductID INT,
    UnitPrice DECIMAL(10, 2),
    Quantity SMALLINT,
    Discount DECIMAL(4, 2)
);

ALTER TABLE Orders ADD ShipVia INT;
ALTER TABLE Orders DROP COLUMN Freight;
ALTER TABLE OrderDetails DROP COLUMN UnitPrice;

