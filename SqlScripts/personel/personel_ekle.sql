USE [CONTROLAPP]
GO
/****** Object:  StoredProcedure [dbo].[EmployeeCreate]    Script Date: 4.12.2021 12:59:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Personel ekleme
ALTER proc [dbo].[EmployeeCreate](@tc char(11),@name nvarchar(30), @surname nvarchar(20),@bdate date, 
@adress nvarchar(max), @tel nvarchar(10), @mail nvarchar(80), @departmentid uniqueidentifier, @authorityid uniqueidentifier)
as

declare @eror bit
declare @control char(11)=''
set @control=(select TC from EMPLOYEE where TC=@tc)
--personel varsa eklemez
if(@control!='')begin
set @eror=1; select @eror
end
else begin
--personel yoksa ekleme işlemi gerçekleştirir
insert into EMPLOYEE ([TC], [NAME], [SURNAME], [BDATE], [ADRESS], [TEL], [MAIL], [DEPARTMENTID], [AUTHORITYID])
values (@tc,@name,@surname,@bdate,@adress,@tel,@mail,@departmentid,@authorityid)
exec SessionCreate @tc,'123456'
set @eror=0; select @eror
end