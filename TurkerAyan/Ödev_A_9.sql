create database InsaatDb
Go
Use InsaatDb
Go
Create Table adresler(
Id int Primary Key identity(1,1),
Adres nvarchar(255)
)
Go
Create  table binalar(
Id int primary key identity(1,1),
BinaAd nvarchar(55),
daireId int foreign key references daireler(Id)
)

Create Table Daireler(
Id int Primary Key identity(1,1),
AdresID int,
BinaID int,
foreign key (adresId) references adresler(Id)
)
Go
Create table Binamalzemeleri(
binaId int primary key foreign key references Binalar(ID),
malzemeId int foreign key references Malzemeler(ID)
)


Create table malzemeler(
Id int primary key identity (1,1),
Malzemeadı nvarchar(20)
)
