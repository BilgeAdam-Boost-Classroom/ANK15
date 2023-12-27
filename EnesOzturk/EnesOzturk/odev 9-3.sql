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
create function ArayýHesapla(@tarih1 datetime,@tarih2 datetime)
returns int
as 
begin
declare @farký int;
		select @farký=DATEDIFF(day,@tarih1,@tarih2);
		RETURN @farký;
end;
go
select o.OrderDate ,o.ShippedDate,dbo.ArayýHesapla(o.OrderDate,o.ShippedDate) as 'Aradaki Gün'
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