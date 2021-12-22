create proc SentryDoneGetByDate (@createdtime datetime)
as
select * from SENTRYDONE where CREATEDTIME= @createdtime