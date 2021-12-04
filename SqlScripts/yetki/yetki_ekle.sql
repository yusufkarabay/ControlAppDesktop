create proc AuthorityCreate (@authorityName nvarchar(50))

as
-- daha �nce ayn� isimle yetki eklendi mi kontrol� ger�ekle�ecek.
declare @name nvarchar(50)=''

declare @error bit --erordan gelen 1 yada 0 de�erine g�re i�leme devam edecek. sonu� d�necek yada hata d�necek


-- yetki tablosundaki, AUTHORITYNAME i paramaetreden gelen @@authorityName i e�le�tir ve AUTHORITYNAME''i d�nder
set @name=(select AUTHORITYNAME from AUTHORITY where AUTHORITYNAME=@authorityName )

--name bo�lu�a e�it de�ilse bir kay�t var demek
if(@name!='')
begin
--ekleme i�lemini engellemek i�in @error true de�eri oluyor
set @error=1; select @error
end
else
begin
--di�er durum da departman eklenir
insert into AUTHORITY (AUTHORITYNAME) values (@authorityName)
set @error=0; select @error
end