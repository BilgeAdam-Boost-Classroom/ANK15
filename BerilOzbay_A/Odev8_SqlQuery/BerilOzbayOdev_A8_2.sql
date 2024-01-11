Select 
	*
From
	Personeller
Where
	Adi Not Like '[A-L]%'
Go ---1

Select
	*
From
	Personeller
Where 
	Adi NOT LIKE '_a%' and Adi NOT LIKE '_t%'
Go --2

Select 
	*
From
	Personeller
Where 
	Adi Like 'La%' or Adi Like 'Ln%' or Adi Like 'Aa%'or Adi Like 'An%'
Go -- 3

Select 
	Adi
From
	Personeller
Where
	Adi Like '[%_%]'
Go --- 4

Select Top 10 Percent 
	MusteriID
From
	Musteriler
Where
	MusteriID Like '_A_T%'
Order by 
	MusteriID Desc
Go --5
