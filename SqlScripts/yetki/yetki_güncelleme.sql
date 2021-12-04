-- yetki g�ncelleme
create proc AuthorityUpdate (@authorityid uniqueidentifier ,@authorityName nvarchar(50),@authorityOldName nvarchar(50))

as
declare @error bit
declare @name nvarchar(50)=''

set @name=(select AUTHORITYNAME from AUTHORITY where AUTHORITYNAME=@authorityName )

--e�er yetki ad� yetki eski ad�ndan farkl� ise hata d�nder.
if(@name!='' and @authorityName!=@authorityOldName)
begin
set @error=1; select @error
end
else
--e�er hata yoksa departman ad�n� g�ncelle
begin
update  AUTHORITY set AUTHORITYNAME=@authorityName where AUTHORITYID=@authorityid
set @error=0; select @error
end