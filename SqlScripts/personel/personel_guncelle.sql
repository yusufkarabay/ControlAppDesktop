--Personel güncelle
create proc EmployeeUpdate(@tc char(11),@name nvarchar(30), @surname nvarchar(20),@bdate date, 
@adress nvarchar(max), @tel nvarchar(10), @mail nvarchar(80), @departmentid uniqueidentifier, @authorityid uniqueidentifier)
as
update EMPLOYEE set TC=@tc, NAME=@name,SURNAME=@surname,BDATE=@bdate, ADRESS=@adress,TEL=@tel,MAIL=@mail,DEPARTMENTID=@departmentid,AUTHORITYID=@authorityid

