USE [CONTROLAPP]
GO
/****** Object:  StoredProcedure [dbo].[DepartmentList]    Script Date: 3.12.2021 13:12:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Departman listeleme prosedur
-- bütün kolonları listeler
ALTER proc [dbo].[DepartmentList] (@departmentid uniqueidentifier ,@departmentName nvarchar(50), @departmentOldName nvarchar(50))

as
select * from DEPARTMENT