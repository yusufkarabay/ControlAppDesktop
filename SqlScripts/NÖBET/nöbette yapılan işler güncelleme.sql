create proc SentryDoneUpdate(@donesentryid uniqueidentifier, @done nvarchar(max), @createdtime datetime, @createdemployee char(11))
as 
declare @eror bit
declare @name uniqueidentifier
select DONESENTRYID from SENTRYDONE where DONESENTRYID=@donesentryid
if(@name!= null)
begin
set @eror=1;select @eror
end
else
begin
update SENTRYDONE set DONE=@done, CREATEDTIME=@createdtime, CREATEDEMPLOYEE=@createdemployee where DONESENTRYID=@donesentryid
set @eror=0; select @eror
end
