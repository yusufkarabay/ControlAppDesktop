-- Yetkiler listeleme prosedur
-- bütün kolonlarý listeler
create proc AuthorityList (@authorityid uniqueidentifier ,@aouthorityName nvarchar(50))

as
select * from AUTHORITY