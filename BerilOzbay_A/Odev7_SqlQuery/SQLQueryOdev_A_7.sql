Select 
	Adi,SoyAdi,UnvanEki,Sehir
From
	Personeller
Where Sehir = 'London' or UnvanEki='Ms.' 
Go --- 1

Select * From Personeller Where Adi='Michael'
Go ---2

Select 
	BirimFiyati + HedefStokDuzeyi as [Miktar]
From 
	Urunler
Where
	BirimFiyati + HedefStokDuzeyi > 40
Go ---3

Select
	UrunAdi
From
	Urunler
Where 
	BirimFiyati < 20
Go ---4

Select
	*
From
	Urunler
Where 
	KategoriID = 1 or BirimFiyati = 18
Go --5

Select
	UrunAdi as Nombre,
	BirimFiyati * 2 as Hesap
From
	Urunler
Where
	HedefStokDuzeyi = 0