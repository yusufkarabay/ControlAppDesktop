USE [CONTROLAPP]
GO
/****** Object:  StoredProcedure [dbo].[RequestUpdate]    Script Date: 4.12.2021 10:44:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Talep  güncelle
ALTER proc [dbo].[RequestUpdate] (@requestid uniqueidentifier,@requesttitle nvarchar(100) ,@requestcontent nvarchar(1000))
as
declare @rtitle nvarchar(100)=''
declare @eror bit

set @rtitle=(select REQUESTTITLE from REQUEST where REQUESTTITLE=@requesttitle and REQUESTCONTENT=@requestcontent)

if(@rtitle!='')
begin
set @eror=1;select @eror
end
else begin
update REQUEST set REQUESTTITLE=@requesttitle ,REQUESTCONTENT=@requestcontent where REQUESTID=@requestid
set @eror=0;select @eror
end

