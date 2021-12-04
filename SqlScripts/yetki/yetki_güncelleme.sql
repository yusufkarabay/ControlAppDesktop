-- yetki güncelleme
create proc AuthorityUpdate (@authorityid uniqueidentifier ,@authorityName nvarchar(50),@authorityOldName nvarchar(50))

as
declare @error bit
declare @name nvarchar(50)=''

set @name=(select AUTHORITYNAME from AUTHORITY where AUTHORITYNAME=@authorityName )

--eðer yetki adý yetki eski adýndan farklý ise hata dönder.
if(@name!='' and @authorityName!=@authorityOldName)
begin
set @error=1; select @error
end
else
--eðer hata yoksa departman adýný güncelle
begin
update  AUTHORITY set AUTHORITYNAME=@authorityName where AUTHORITYID=@authorityid
set @error=0; select @error
end