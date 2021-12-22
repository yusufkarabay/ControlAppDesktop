create proc SentryDoneDelete (@donesentryid uniqueidentifier)
as
delete from SENTRYDONE where DONESENTRYID=@donesentryid