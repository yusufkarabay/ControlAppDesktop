USE [CONTROLAPP]
GO
/****** Object:  StoredProcedure [dbo].[DepartmentDelete]    Script Date: 3.12.2021 13:10:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Departman silme prosedur
ALTER proc [dbo].[DepartmentDelete] (@departmentid uniqueidentifier )

--departmanlar tablosunda gelen id @departmentid ye eşlit olan departmanı sil
as
delete from DEPARTMENT where DEPARTMENTID=@departmentid