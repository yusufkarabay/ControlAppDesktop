create proc SentryDoneCreate (@done nvarchar(max), @createdtime datetime, @createdemployee char(11))
as
insert into SENTRYDONE (DONE,CREATEDTIME,CREATEDEMPLOYEE) values (@done,@createdtime,@createdemployee)
go