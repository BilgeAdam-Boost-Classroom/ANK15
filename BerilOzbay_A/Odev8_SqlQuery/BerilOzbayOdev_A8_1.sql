Select 
	* 
From 
	Personeller
Where 
	Ulke In ('UK', 'Turkey') --- 1
Go

Select 
	*
From
	Personeller
Where 
	Bolge is Null
Go --- 2

Select 
	* 
From 
	Personeller
Where 
	SoyAdi In ('Fuller', 'King') --- 3
Go

Select
	*
From
	Urunler
Where 
	(BirimFiyati > 15 and Sonlandi = 0) or (YeniSatis<70 and EnAzYenidenSatisMikatari>5)
Go ---4

Select 
	UrunAdi, KategoriID
From
	Urunler
Where
	KategoriID In(1,4,8)
Go ---5

Select
	Adres
From
	Tedarikciler
Where 
	Faks is Null or Sehir='New Orleans'
Go --- 6

Select 
	BolgeID as BolgeNo, BolgeTanimi
From
	Bolge
Go ---7

Select 
	*
From
	[Satis Detaylari]
Where
	Ýndirim !=0 or Miktar Between 10 and 40 
Go---8

Select 
	 DISTINCT UnvanEki,Unvan
From
	Personeller
Go --9

Select
	SatisTarihi, SevkTarihi
From
	Satislar
Where 
	Month(SatisTarihi) = 07 or Day(SevkTarihi) > 15
Go --- 10

Create Database SatrancDb --11
Go

Create Table Taslar (
	ID int Primary Key Identity(1,1),
	Ad nvarchar(50) not null,
	Hareket nvarchar(MAX) not null,
	Renk bit not null
)
Go --12

Insert Into
	Taslar(Ad, Hareket,Renk)
Values
	('Fil','Çapraz', 1),
	('Piyon','Dikey', 0),
	('Kale','Dikey ve yatay', 1),
	('At','L seklinde', 0),
	('Vezir','Dikey,yatay ve çapraz', 1),
	('Þah','Dikey ve yatay', 0)
Go -- 13