


SELECT
e.FirstName,e.LastName,DATEPART(HOUR,E.BirthDate) 'HOUR', e.BirthDate as saat

FROM Employees as e
GROUP BY e.FirstName,e.LastName,e.BirthDate
ORDER BY E.BirthDate DESC


SELECT 
E.FirstName,E.LastName,DATEPART(MINUTE,E.BirthDate) 
FROM Employees AS E 
GROUP BY E.FirstName,E.LastName,E.BirthDate
ORDER BY E.BirthDate DESC

DECLARE  @TARÝH datetime
set @TARÝH=16/06/2000


SELECT DATEDIFF(DAY,'06/16/2000',getdate())

SELECT
OD.Discount,MAX(OD.Discount)
FROM [Order Details] AS OD
GROUP BY OD.Discount 

SELECT
MIN(od.Discount)
FROM [Order Details] AS OD

select
(max(od.Discount)-MIN(od.Discount))
from [Order Details] as od

select		
sum(od.UnitPrice)
from [Order Details] as od
where od.Discount=0
		
SELECT
O.ShipCountry,AVG(O.Freight) AS ORTALAMA
FROM Orders AS O
GROUP BY O.ShipCountry

SELECT
O.ShipCountry,AVG(O.Freight) AS ORTALAMA
FROM ORDERS AS O 
WHERE O.ShipCountry LIKE 'F%'
GROUP BY O.ShipCountry

---------------------------
SELECT
DISTINCT OD.ProductID ,OD.UnitPrice

FROM [Order Details] AS OD
WHERE OD.UnitPrice <(SELECT   AVG(od.UnitPrice)  FROM [Order Details] AS OD)
ORDER BY OD.ProductID 
-------------------------
SELECT
RE.RegionDescription,Territories.TerritoryDescription
FROM Region AS RE
JOIN Territories ON Territories.RegionID=RE.RegionID
------------------------------------------------

SELECT
C.PostalCode
FROM CUSTOMERS AS C
WHERE LEN(C.PostalCode)>5
GROUP BY C.PostalCode

-----------------------------------------
SELECT 
p.ProductName,c.CategoryName
FROM Products AS P
JOIN Categories C on p.CategoryID=c.CategoryID
ORDER BY P.ProductName DESC

SELECT
ProductName,  (SELECT CategoryName FROM Categories WHERE CategoryID = p.CategoryID) AS CategoryName
      
FROM  Products AS p
  
ORDER BY    ProductName DESC;

SELECT 
P.ProductName,P.UnitPrice,P.UnitsInStock
FROM Products AS P
WHERE P.UnitPrice >50 AND P.UnitsInStock>50
ORDER BY P.UnitsInStock ASC

SELECT * FROM(SELECT P.ProductName,P.UnitsInStock,P.UnitPrice   FROM Products AS P WHERE P.UnitsInStock>50)
Products
where UnitPrice>50


SELECT

P.ProductName,C.CategoryName,S.CompanyName
FROM Products AS P 

JOIN Categories C ON C.CategoryID=P.CategoryID
JOIN Suppliers S ON S.SupplierID=P.SupplierID

GO
CREATE DATABASE OOKULDB
CREATE TABLE Siniflar(
SinifId int Primary key identity(1,1),
SinifAd nvarchar(10) NOT NULL unique,
OgretmenId int FOREIGN KEY REFERENCES Ogretmenler(OgretmenId)


)
create TABLE Ogretmenler(

OgretmenId int primary key identity,
OgretmenAd nvarchar(50) not null,
OgretmenSoyad nvarchar(50) not null

)



INSERT INTO Ogretmenler	(OgretmenAd,OgretmenSoyad


)
VALUES('GÜRAL','SAVCI')
INSERT INTO Siniflar(SinifAd)
values('4-b')
INSERT INTO Siniflar(SinifAd)
values('4-c')INSERT INTO Siniflar(SinifAd)
values('4-d')INSERT INTO Siniflar(SinifAd)
values('4-e')INSERT INTO Siniflar(SinifAd)
values('5-a')INSERT INTO Siniflar(SinifAd)
values('5-b')INSERT INTO Siniflar(SinifAd)
values('5-c')INSERT INTO Siniflar(SinifAd)
values('5-d')INSERT INTO Siniflar(SinifAd)
values('5-e')INSERT INTO Siniflar(SinifAd)
values('6-a')
select*from Siniflar

