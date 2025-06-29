
-- Drop table if it exists
DROP TABLE IF EXISTS Products;

-- Create Products table
CREATE TABLE Products (
    ProductID INT PRIMARY KEY,
    ProductName VARCHAR(100),
    Category VARCHAR(100),
    Price DECIMAL(10,2)
);

-- Insert sample product data
INSERT INTO Products (ProductID, ProductName, Category, Price) VALUES
(1, 'Phone A', 'Electronics', 799.99),
(2, 'Phone B', 'Electronics', 999.99),
(3, 'Phone C', 'Electronics', 899.99),
(4, 'Laptop A', 'Computers', 1299.99),
(5, 'Laptop B', 'Computers', 1499.99),
(6, 'Laptop C', 'Computers', 1299.99),
(7, 'TV A', 'Appliances', 499.99),
(8, 'TV B', 'Appliances', 599.99),
(9, 'TV C', 'Appliances', 599.99),
(10, 'TV D', 'Appliances', 399.99);

-- ROW_NUMBER(): Top 3 products per category, uniquely ranked
SELECT *
FROM (
    SELECT 
        ProductID,
        ProductName,
        Category,
        Price,
        ROW_NUMBER() OVER (PARTITION BY Category ORDER BY Price DESC) AS RowNum
    FROM Products
) Ranked
WHERE RowNum <= 3;

-- RANK(): Top 3 products per category, with gaps for ties
SELECT *
FROM (
    SELECT 
        ProductID,
        ProductName,
        Category,
        Price,
        RANK() OVER (PARTITION BY Category ORDER BY Price DESC) AS RankNum
    FROM Products
) Ranked
WHERE RankNum <= 3;

-- DENSE_RANK(): Top 3 products per category, no gaps for ties
SELECT *
FROM (
    SELECT 
        ProductID,
        ProductName,
        Category,
        Price,
        DENSE_RANK() OVER (PARTITION BY Category ORDER BY Price DESC) AS DenseRankNum
    FROM Products
) Ranked
WHERE DenseRankNum <= 3;
