-- Yetkiler listeleme prosedur
-- b�t�n kolonlar� listeler
create proc AuthorityList (@authorityid uniqueidentifier ,@aouthorityName nvarchar(50))

as
select * from AUTHORITY