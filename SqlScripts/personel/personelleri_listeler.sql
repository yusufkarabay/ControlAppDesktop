--tüm personelleri listeler
create proc EmployeeList
as
select P.*,D.DEPARTMENTNAME, Y.AUTHORITYNAME from EMPLOYEE P inner join DEPARTMENT D on P.DEPARTMENTID=D.DEPARTMENTID
inner join AUTHORITY Y on P.AUTHORITYID=Y.AUTHORITYID