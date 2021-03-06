USE [CONTROLAPP]
GO
/****** Object:  StoredProcedure [dbo].[RequestAssignmentCreate]    Script Date: 3.12.2021 13:41:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--oluşturukan işi ata
ALTER proc [dbo].[RequestAssignmentCreate](@requestid uniqueidentifier, @requesting char(11), @requested char(11))
as
declare @control char(11)=''-- sorgulama tc numarasına göre yapılacaktır
declare @error bit
-- aynı talep aynı personele tekrar tekrar verilme durumunu kontrol eder
set @control=(select REQUESTED from REQUESTDETAIL where REQUESTED=@requested and REQUESTID=@requestid )
--aynı talep aynı personele tekrar verilirse hata verecektir
if(@control!='')begin
set @error=1; select @error
end
--aynı talep değilse talebi oluşturacaktır
else begin
insert into REQUESTDETAIL (REQUESTID,REQUESTING,REQUESTED) values (@requestid,@requesting,@requested)
set @error=0; select @error
end 