--1Q1
Select FirstName ad,LastName Soyad, datepart(hour,Birthdate) saat 
From Employees
Order by saat desc 

--1Q2
Select FirstName ad,LastName Soyad, datepart(MINUTE,Birthdate) Minutess 
From Employees e
Group by firstName, LastName, BirthDate
Order by Minutess desc
--1Q3
Select DATEDIFF(DAY,'07/27/1992',getdate())
--1Q4
Select *
From [Order Details]
where Discount=(select MAX(discount) from [Order Details])
--1Q5
Select MIN(discount)
From [Order Details]
--1Q6
Select max(discount)-MIN(discount)
From [Order Details]
--1Q7
Select Sum(UnitPrice)
From [Order Details]
where Discount='0'
--1Q8
Select ShipCountry, Avg(Freight)
From Orders
Group by ShipCountry
--1Q9
Select ShipCountry,avg(Freight)
From Orders
Where ShipCountry like 'F%'
Group by ShipCountry
--2Q1
Select distinct ProductID, UnitPrice 
From [Order Details]
Where UnitPrice< (Select Avg(UnitPrice) From [Order Details])
Order by UnitPrice desc
Go
--2Q2
Select t.TerritoryDescription,r.RegionDescription
From Region r
INNER JOIN	Territories t on r.RegionID=t.RegionID
--2Q3
Select PostalCode
From Customers
Where Len(PostalCode)>5
--2Q4
SELECT 
    employeeID,firstname,lastname
FROM Employees
WHERE employeeID IN (SELECT categoryID FROM Categories WHERE categoryname = 'seafood')
--2Q5
Select p.ProductName,c.CategoryName
From Products p
INNER JOIN Categories c on p.CategoryID=c.CategoryID
order by ProductName desc
--2Q6
Select p.ProductName,(Select CategoryName from Categories c where c.CategoryID=p.CategoryID )
From Products p
--2Q7
Select ProductName,UnitsInStock,UnitPrice
From Products
Where UnitPrice>50 and UnitsInStock>50
order by UnitsInStock 
--2Q8
Select c.ProductName,c.UnitsInStock,c.UnitPrice
From (Select * From Products Where UnitPrice>50 and UnitsInStock>50) c
order by c.UnitsInStock 
--2Q9
Select p.ProductName,c.CategoryName,s.CompanyName
From Products p
INNER JOIN Categories c ON c.CategoryID=p.CategoryID
INNER JOIN Suppliers s ON s.SupplierID=p.SupplierID
--2Q10
Create database OKULDb
Use okuldb
Create Table Ogretmenler(
OgretmenID int  Primary key identity(1,1),
OgretmenAd nvarchar(50) not null,
OgretmenSoyad nvarchar(50) not null)
Create Table Siniflar (
SinifID int primary key identity(1,1),
SinifAd nvarchar(10) not null unique,
OgretmenId int foreign key REFERENCES Ogretmenler(OgretmenID)
)

INSERT INTO siniflar




--3Q1
Use NORTHWND
GO
Create function AyHesapla (@baslamatarihi int)
returns int 
as 
begin
declare @totalay int
		Select @totalay=DATEDIFF(month,@baslamatarihi,GetDATE());
		Return @totalay;
end;
 Go
 SELECT em.FirstName,
 FROM Employees em
 create function AyHesapla(@BaslamaTarihi datetime)
returns int
as 
begin
declare @GecmisAylar int
		select @GecmisAylar=DATEDIFF(month,@BaslamaTarihi,GETDATE());
		RETURN @GecmisAylar;
end;
 
SELECT  EmployeeID,dbo.AyHesapla(HireDate) as GecenAylar
FROM Employees
go
 
-->3Q2
create function ArayıHesapla(@tarih1 datetime,@tarih2 datetime)
returns int
as 
begin
declare @farkı int;
		select @farkı=DATEDIFF(day,@tarih1,@tarih2);
		RETURN @farkı;
end;
go
 
select o.OrderDate ,o.ShippedDate,dbo.ArayıHesapla(o.OrderDate,o.ShippedDate) as 'Aradaki Gün'
from Orders o
go
 
 -->3Q3
create function BasHarfTablo(@BasHarf char(1))
returns table
as 
return
select e.FirstName
from Employees e
where FirstName like @BasHarf +'%'
;
 --3Q4
ALTER PROCEDURE CalculateTrimmedMean
AS
BEGIN
    SELECT sum(UnitPrice)/(COUNT(od.UnitPrice)-2)
    FROM [Order Details] od 
    WHERE UnitPrice Not IN ((select Min(unitPrice) from [Order Details]), (select max(unitPrice) from [Order Details])) ;
END;

 Go
exec CalculateTrimmedMean



/*-- Order details tablosundaki unitprice’ların kırpılmış ortalamasını hesaplayan stored procedure 
yazınız. (Kırpılmış ortalama: En küçük ve en büyük değerler dahil edilmeden hesaplanan 
aritmetik ortalamadır. Bölerken, (terim sayısı-2) ’ye bölünmelidir.)*/

