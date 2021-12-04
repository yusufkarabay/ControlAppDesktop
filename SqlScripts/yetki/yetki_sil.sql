--yetki silme iþlemi
create proc AuthorityDelete (@authortyid uniqueidentifier )
as
delete from AUTHORITY where AUTHORITYID=@authortyid