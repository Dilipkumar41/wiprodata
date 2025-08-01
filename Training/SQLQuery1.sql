use sqlpractice
Go

-- Display List of Tables available in the current data base
select * from INFORMATION_SCHEMA.TABLES
GO

-- Display information about emp Table
sp_help Emp
GO

-- Display all records from Emp Table
select * from Emp
GO

-- Display Empno, Name , Basc from Emp table
select empno 'Employ no' , nam 'Employ Name', basic 'Salary' from Emp
GO

--Display All Records whose Basic >50000

select *from Emp Where basic > 50000
Go

-- Display All records whose dept is 'DOTNET'
select *from Emp
where Dept='DOTNET'
GO

--Display all records whose name is 'swetha'
select *from Emp
where nam='saikiran'
Go

--Between ....And : Display records from specific Range(work for numbers and date only)
select *from Emp
Where basic Between 50000 and 90000
Go
 
 select * from Emp
 where basic not Between 50000 and 90000
 Go
 -- In Clause : used to check for multiple values of particular column
 ---Display all records whose Dept is java or Dot net or Sql

 select *from Emp
 where Dept in('Dotnet','Java','Sql')
 Go

 select *from Emp
 where Dept not in('Dotnet','Java','Sql')
 Go

 select *from Emp
 where nam in('Manu','saikiran','Satish','Swapna')
 Go


 -- Like Operator : Used to display data w.r.t wild cards
 -- Display all records whose name starts with 'S'
 select *from Emp 
 where nam Like'S%'
 Go

 --Display records whose name ends with 'A'
 select * from Emp
 where nam like'%n'
 Go

 ---Distinct : Eliminate duplicate entries at the time of display
 select dept from Emp
 Go
 Select Distinct Dept from Emp
 Go

 --- OrderBy : used to display values w.r.t particular field(s) imn ascending  or descending
 select * from Emp order by nam
 Go
select *from Emp order by basic DESC
Go
select *from Emp order by nam,Dept
Go
select *from Emp order by dept,nam DESC
Go
