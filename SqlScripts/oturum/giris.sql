--giriþ yapma 
create proc SessionCreate (@tc char(11), @password nvarchar(15))
as
insert into SESSION (SESSIONID,PASSWORD) values (@tc,@password)