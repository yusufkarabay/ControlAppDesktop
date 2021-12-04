create proc AuthorityCreate (@authorityName nvarchar(50))

as
-- daha önce ayný isimle yetki eklendi mi kontrolü gerçekleþecek.
declare @name nvarchar(50)=''

declare @error bit --erordan gelen 1 yada 0 deðerine göre iþleme devam edecek. sonuç dönecek yada hata dönecek


-- yetki tablosundaki, AUTHORITYNAME i paramaetreden gelen @@authorityName i eþleþtir ve AUTHORITYNAME''i dönder
set @name=(select AUTHORITYNAME from AUTHORITY where AUTHORITYNAME=@authorityName )

--name boþluða eþit deðilse bir kayýt var demek
if(@name!='')
begin
--ekleme iþlemini engellemek için @error true deðeri oluyor
set @error=1; select @error
end
else
begin
--diðer durum da departman eklenir
insert into AUTHORITY (AUTHORITYNAME) values (@authorityName)
set @error=0; select @error
end