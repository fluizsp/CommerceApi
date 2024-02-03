USE Commerce;
GO

INSERT INTO Customers (FirstName, LastName, Email, Phone)
VALUES
('John', 'Doe', 'john.doe@email.com', '123-456-7890'),
('Jane', 'Doe', 'jane.doe@email.com', '098-765-4321'),
('Mike', 'Smith', 'mike.smith@email.com', '111-222-3333'),
('Emily', 'Jones', 'emily.jones@email.com', '444-555-6666');
GO

INSERT INTO Products (ProductName, Price, Quantity)
VALUES
('Laptop', 1200.00, 10),
('Smartphone', 800.00, 15),
('Tablet', 600.00, 20),
('Headphones', 150.00, 30),
('Monitor', 300.00, 25);
GO