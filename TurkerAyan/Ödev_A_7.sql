--Q1
SELECT FirstName,LastName,Title,City
FROM Employees
WHERE City='London' OR TitleOfCourtesy='Ms.'

--Q2
SELECT * 
FROM Employees
WHERE FirstName='Micheal'
--Q3
SELECT UnitPrice + UnitsInStock as Miktar
From Products
WHERE UnitPrice+UnitsInStock>40
--Q4
SELECT ProductName
From Products
WHERE UnitPrice<20
--Q5
SELECT *
From Products
WHERE CategoryID='1' OR CategoryID='18'
--Q6
SELECT ProductName,UnitPrice*2 as UnitPrice
FROM Products
WHERE UnitsInStock='0'
