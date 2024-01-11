Select
	FirstName,
	LastName,
	DATEPART(HOUR, BirthDate) as DogumSaati
From
	Employees
Order By 
	DATEPART(HOUR, BirthDate) Desc 
Go
----------------1

Select
	FirstName,
	LastName,
	DATEPART(MINUTE, BirthDate) as DogumSaati
From
	Employees
Order By 
	DATEPART(MINUTE, BirthDate) Desc 
Go
------------------2

Select 
	DATEDIFF(DAY, '1997-06-26', GETDATE()) AS GecenGunSayisi;
Go
-----------------3

Select
	MAX(Discount) as MaximumIndirim
From
	[Order Details]
Go
-----------------4

Select
	MIN(Discount) as MaximumIndirim
From
	[Order Details]
Go
-----------------5

Select
	MAX(Discount) - MIN(Discount) as IndirimFarki
From
	[Order Details]
Go
-----------------5

Select
	OrderID,Sum(UnitPrice) as BirimFiyatToplami
From
	[Order Details]
Where
	Discount = 0
Group By
	OrderID
Go
------------- 6

Select
	ShipCountry, AVG(Freight) as [NakliyeUcreti]
From
	Orders
Group By
	ShipCountry
Go
--------------7

Select
	ShipCountry, AVG(Freight) as [NakliyeUcreti]
From
	Orders
Where 
	ShipCountry Like 'F%'
Group By
	ShipCountry
Go
--------------8
--ODEV 2--
--------------
Select
	Distinct ProductID, UnitPrice
From
	[Order Details]
Where
	UnitPrice < (Select AVG(UnitPrice) From [Order Details])
Order By
	UnitPrice Desc
Go
--------------1

Select
	TerritoryDescription, RegionDescription
From
	Region
Join 
	Territories ON Region.RegionID = Territories.RegionID
Go
-------------- 2

Select
	CustomerID,PostalCode
From
	Customers
Where
	Len(PostalCode) > 5
Go
------------- 3
Select
	EmployeeID, FirstName, LastName
From
	Employees
Where
	EmployeeID = (Select CategoryID from Categories Where CategoryName = 'Seafood')
Go

--------------4

Select
	CategoryName,ProductName
From
	Products
Join
	Categories On Products.CategoryID = Categories.CategoryID
Order By
	ProductName Desc
Go
---------------- 5
Select
	ProductName, 
	(Select 
		CategoryName 
	 From 
		Categories 
	 Where Categories.CategoryID = Products.CategoryID) as Kategori 
From
	Products
Order By
	ProductName Desc
Go
-------------- 6

Select
	ProductName, UnitsInStock,UnitPrice
From
	Products
Where
	UnitPrice > 50 and UnitsInStock > 50
Order By
	UnitsInStock
Go
-----------------7
Select
	*
From
	(Select
		ProductName, UnitsInStock, UnitPrice
	 From
		Products
	 Where
		UnitPrice > 50) Urunler
Where 
	UnitsInStock > 50 
Order By
	UnitsInStock
Go
-----------------8

Select
	ProductName, CategoryName, CompanyName
From
	Products
Join
	Categories On Products.CategoryID = Categories.CategoryID
Join
	Suppliers On Products.SupplierID = Suppliers.SupplierID
Go
--------------9

Create Database OkulDb
Go

Create Table Ogretmenler (
	OgretmenId int Primary key identity(1,1),
	OgretmenAd nvarchar(50) not null,
	OgretmenSoyAd nvarchar(50) not null
)
Go

Create Table Siniflar (
	SinifId int Primary key identity(1,1),
	SinifAd nvarchar(10) not null unique,
	OgretmenId int Foreign key references Ogretmenler(OgretmenId)
)
Go

Insert Into Ogretmenler(OgretmenAd,OgretmenSoyAd)
Values 
	('Salih','Bademci'),
	('Burcu', 'Güneþ'),
	('Nazmi','Þeker'),
	('Pelin','Yýlmaz'),
	('Remzi','Atalay')
Go

Insert Into Siniflar(SinifAd,OgretmenId)
Values
	('101',1),
	('102',2),
	('103',3),
	('104',5),
	('105',5),
	('201',5),
	('202',null),
	('203',null),
	('204',null),
	('205',null)
Go
----------------10
Select
	OgretmenAd,OgretmenSoyAd,SinifId, SinifAd
From
	Siniflar
Join
	Ogretmenler On Siniflar.OgretmenId = Ogretmenler.OgretmenId
Where
	 Siniflar.OgretmenId is not null
Go
-------------------- 11 

Select
	OgretmenAd,OgretmenSoyAd
From
	Ogretmenler
Where
	Ogretmenler.OgretmenId 
not in 
	(Select Distinct Siniflar.OgretmenId From Siniflar where OgretmenId is not null)
Go
---------------------- 12 
Select
	SinifId, SinifAd
From
	Siniflar
Where
	OgretmenId is null
Go
----------------------- 13

Select
	OgretmenAd, OgretmenSoyAd, SinifId, SinifAd
From
	Siniflar
Full Outer join
	Ogretmenler on Siniflar.OgretmenId = Ogretmenler.OgretmenId
Go

---------------------- 14 
------ Odev 3
----------------------
Create Function AyHesapla(@zaman datetime)
returns int
As
Begin
	Declare @GecenAySayisi int
	
	Select @GecenAySayisi = DATEDIFF(Month, @zaman, GETDATE()) 
	Return @GecenAySayisi
End
Go

Select dbo.AyHesapla(HireDate) as GecenAySayisi From Employees
Go

---------------1

Create Function GunHesapla(@tarih1 datetime, @tarih2 datetime)
returns int
As
Begin
	declare @GecenGunSayisi int
	Select @GecenGunSayisi = DATEDIFF(Day, @tarih2, @tarih1)
	Return @GecenGunSayisi
End
Go

Select dbo.GunHesapla(ShippedDate,OrderDate) as GecenGunSayisi From Orders
Go

--------------2

Create Function Isým(@harf NChar(1))
returns table
As
Return
	Select 
		FirstName 
	From 
		Employees 
	Where 
		FirstName Like @harf + '%'
Go

Select
	*
From
	dbo.Isým('A')
Go
-------------------3

Create Proc Ortalama
As
Begin
	Declare @MaxDeger money
	Select @MaxDeger = Max(UnitPrice) From [Order Details]

	Declare @MinDeger money
	Select @MinDeger = Min(UnitPrice) From [Order Details]

	Select Sum(UnitPrice)/ (Count(UnitPrice) - 2) From [Order Details]
	Where UnitPrice not in(@MaxDeger,@MinDeger)
End
Go

Exec dbo.Ortalama 
------------------ 4