create proc EmployeeLogin (@tc char(11),@password nvarchar(15))
as
-- bu sorguyu saðlayan deðer varsa bize true deðer döndeerecek
if exists(select * from SESSION where TC=@tc and PASSWORD=@password) begin

select E.ID, E.NAME,E.SURNAME,E.DEPARTMENTID,D.DEPARTMENTNAME,E.AUTHORITYID,A.AUTHORITYNAME from SESSION S 
inner join EMPLOYEE E on S.TC=E.TC
inner join DEPARTMENT D on E.DEPARTMENTID=D.DEPARTMENTID
inner join AUTHORITY A on E.AUTHORITYID=A.AUTHORITYID
where S.TC=@tc and PASSWORD=@password
end
