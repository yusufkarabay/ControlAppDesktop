--Personel sil
create proc EmployeeDelete(@tc char(11))
as
delete from EMPLOYEE where  TC=@tc
