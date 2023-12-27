--Ödev_8_1
--Q1
SELECT Country
FROM Employees
Where Country='UK' OR Country='Turkey'
--Q2
SELECT *
FROM Employees
WHERE Region is null
--Q3
SELECT *
FROM Employees
WHERE LastName='Fuller' OR LastName='King'
--Q4
SELECT *
FROM Products
WHERE UnitPrice>15 and Discontinued='0' Or UnitsOnOrder<70 and ReorderLevel>5 
--Q5
SELECT ProductName, CategoryID
FROM Products
WHERE CategoryID IN (1, 4, 8);
--Q6
SELECT Address
From Suppliers
WHERE Fax IS NULL OR City='New Orleans'
--Q7
SELECT RegionID as BolgeNo,RegionDescription as BolgeTanımı
FROM Region
--Q8
Select *
FROM [Order Details]
Where Discount!='0' OR Quantity Between 10 and 40
--Q9
SELECT DISTINCT Title as Gorev
FROM Employees
--Q10
SELECT OrderDate, ShippedDate
FROM Orders
WHERE MONTH(OrderDate) = 7 OR DAY(ShippedDate) > 15;
--Q11
Create DATABASE SatrancDb 
Go

Use SatrancDb
GO

Create TABLE Taslar(
ID INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
Ad nvarchar(50) Not null,
Hareket nvarchar(Max) Not null,
Renk bit not null
)
INSERT INTO Taslar (Ad, Hareket, Renk) VALUES
('piyon', 'İleri bir kare ilerler.', 1),
('kale', 'Yatay veya dikey bir yönde istediği kadar kare ilerler.', 0),
('at', 'L şeklinde hareket eder.', 1),
('fil', 'Çapraz bir yönde istediği kadar kare ilerler.', 0),
('vezir', 'Yatay, dikey veya çapraz bir yönde istediği kadar kare ilerler.', 1),
('şah', 'Her yöne bir kare ilerler.', 0);
--Ödev_8_2
--Q1
USE NORTHWND
GO

SELECT *
FROM Employees
WHERE LEFT(FirstName, 1) NOT BETWEEN 'A' AND 'I';
--Q2
SELECT *
FROM Employees
WHERE SUBSTRING(FirstName, 2, 1) NOT IN ('A', 'T');
--Q3
SELECT *
FROM Employees
WHERE LEFT(FirstName, 2) IN ('LA', 'LN', 'AA', 'AN');
--Q4
SELECT FirstName
FROM Employees
WHERE FirstName LIKE '%_%';
--Q5
SELECT TOP 10 PERCENT CustomerID
FROM Customers
WHERE SUBSTRING(CustomerID, 2, 1) = 'A' AND SUBSTRING(CustomerID, 4, 1) = 'T'
ORDER BY CustomerID DESC;

 




