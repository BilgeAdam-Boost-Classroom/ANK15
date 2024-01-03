create function AyHesapla(@BaslamaTarihi datetime)
returns int
as
begin

declare @gecmisaylar int
		select @gecmisaylar=DATEDIFF(MONTH,@BaslamaTarihi	,GETDATE())
		RETURN @gecmisaylar;
end
go
select 
EmployeeID,dbo.AyHesapla(HireDate) as gecenaylar
from Employees


SELECT  EmployeeID,dbo.AyHesapla(HireDate) as GecenAylar
FROM Employees
go
 
-->2
create function Aray�Hesapla(@tarih1 datetime,@tarih2 datetime)
returns int
as 
begin
declare @fark� int;
		select @fark�=DATEDIFF(day,@tarih1,@tarih2);
		RETURN @fark�;
end;
go
select o.OrderDate ,o.ShippedDate,dbo.Aray�Hesapla(o.OrderDate,o.ShippedDate) as 'Aradaki G�n'
from Orders o
go
-->3
create function BasHarfTablo(@BasHarf char(1))
returns table
as 
return
select e.FirstName
from Employees e
where FirstName like @BasHarf +'%'
;