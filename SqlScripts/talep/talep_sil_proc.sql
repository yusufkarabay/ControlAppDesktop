--Talep  sil
create proc RequestDelete (@requestid uniqueidentifier)
as
delete from REQUEST where REQUESTID=@requestid

