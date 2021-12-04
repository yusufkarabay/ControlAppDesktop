--Talep  oluþtur
alter proc RequestCreate (@requesttitle nvarchar(100) ,@requestcontent nvarchar(1000))
as
declare @rtitle nvarchar(100)=''
declare @eror bit

set @rtitle=(select REQUESTTITLE from REQUEST where REQUESTTITLE=@requesttitle and REQUESTCONTENT=@requestcontent)

if(@rtitle!='')
begin
set @eror=1;select @eror
end
else begin
insert into REQUEST (REQUESTTITLE,REQUESTCONTENT) values (@requesttitle,@requestcontent)
set @eror=0;select @eror
end


