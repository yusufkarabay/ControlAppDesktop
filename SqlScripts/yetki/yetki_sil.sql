--yetki silme i�lemi
create proc AuthorityDelete (@authortyid uniqueidentifier )
as
delete from AUTHORITY where AUTHORITYID=@authortyid