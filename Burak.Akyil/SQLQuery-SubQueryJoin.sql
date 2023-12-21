--Gorev 1
SELECT ProductID, ProductName 
FROM Products
where ProductID IN (SELECT DISTINCT ProductID FROM [Order Details])
Go
--Gorev 2
SELECT ProductID, ProductName 
FROM Products
where ProductID NOT IN (SELECT DISTINCT ProductID FROM [Order Details])
-----------------------------------------------------
SELECT distinct p.ProductID, p.ProductName 
FROM Products p
LEFT JOIN [Order Details] od on p.ProductID=od.ProductID
where od.ProductID is null
Go
--Gorev 3
Select ProductName, UnitsInStock, UnitPrice,
(Select CategoryName FROM Categories where Categories.CategoryID = Products.ProductID) Category 
FROM Products
-----------------------------------------------------
Select p.ProductName, p.UnitsInStock, p.UnitPrice, c.CategoryName 
From Products p
left join Categories c on p.CategoryID = c.CategoryID
Go
--Gorev 4
Select s.CompanyName, s.ShipperID, count(*) 
From Orders o
Join Shippers s on o.ShipVia = s.ShipperID
Group By s.CompanyName, s.ShipperID
Go
--Gorev 5
Select Max(UnitPrice*Quantity*(1-Discount)) From [Order Details]
where OrderID IN (Select OrderID From Orders where CustomerID
IN (Select CustomerID From Customers where Country = 'Brazil'))
-----------------------------------------------------
Select Max(UnitPrice*Quantity*(1-Discount)) From [Order Details] od
Join Orders o on od.OrderID = o.OrderID
Join Customers c on c.CustomerID = o.CustomerID
where Country = 'Brazil'
Go
