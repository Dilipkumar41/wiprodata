-- String Functions 

-- Charindex() : Use to display the first occurane of the given character
select CHARINDEX('1','hello')
Go
 
select nam,CHARINDEX('a',nam) from Emp 
Go

--- Reverse() : Used to display string in reverse order
select reverse('Thati Roja')
Go
select nam,Reverse(nam) from Emp
Go

-- Len(): Used to displlay length of string
select nam,Len(nam) from Emp
Go

---Left() : used to display no of left side chars
select left('ThatiRoja',4)
Go

--Right() : Used to display no of right side chars
select Right('ThatiROja',6)
Go

--upper() : Displays string in upper case
select Upper('thatiroja')
Go
--Lower(): Displsy string in lower case
select Lower('THATIROJA')
Go

--Substring() : Used to display part of the string 
select SUBSTRING('Welcome to wipro',5,8)
Go

--Replace() : used to replace a string/value with a  new one in all occurances
select Replace('Dotnet Training','Dotnet','sql')
Go