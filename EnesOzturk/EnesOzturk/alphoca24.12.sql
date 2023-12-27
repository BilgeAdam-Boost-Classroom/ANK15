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



ALTER TABLE Ogretmenler ALTER COLUMN OgretmenId INT  IDENTITY(1,1)

INSERT INTO Ogretmenler	(OgretmenAd,OgretmenSoyad


)



VALUES('REMZÝ','SAVCI')
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
SELECT*FROM Ogretmenler

SELECT 

avg(od.UnitPrice)/(count(od.UnitPrice)-2)
FROM  [Order Details] as od
