USE [CONTROLAPP]
GO
/****** Object:  StoredProcedure [dbo].[DepartmentUpdate]    Script Date: 3.12.2021 12:48:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Departman güncelleme prosedur
ALTER proc [dbo].[DepartmentUpdate] (@departmentid uniqueidentifier ,@departmentName nvarchar(50), @departmentOldName nvarchar(50))

as
declare @error bit
declare @name nvarchar(50)=''

set @name=(select DEPARTMENTNAME from DEPARTMENT where DEPARTMENTNAME=@departmentName )

--eğer departman adı departman eski adından farklı ise hata dönder.
if(@name!='' and @departmentName!=@departmentOldName)
begin
set @error=1; select @error
end
else
--eğer hata yoksa departman adını güncelle
begin
update  DEPARTMENT set DEPARTMENTNAME=@departmentName where DEPARTMENTID=@departmentid
set @error=0; select @error
end