USE [CONTROLAPP]
GO
/****** Object:  StoredProcedure [dbo].[DepartmentCreate]    Script Date: 3.12.2021 12:39:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Departman ekleme prosedur
ALTER proc [dbo].[DepartmentCreate] (@departmentName nvarchar(50))

as
-- daha önce aynı isimle departman eklendi mi kontrolü gerçekleşecek.
declare @name nvarchar(50)=''

declare @error bit --erordan gelen 1 yada 0 değerine göre işleme devam edecek. sonuç dönecek yada hata dönecek


-- departmanlar tablosundaki, DEPARTMENTNAME i paramaetreden gelen @departmentName i eşleştir ve DEPARTMENTNAME''i dönder
set @name=(select DEPARTMENTNAME from DEPARTMENT where DEPARTMENTNAME=@departmentName )

--name boşluğa eşit değilse bir kayıt var demek
if(@name!='')
begin
--ekleme işlemini engellemek için @error true değeri oluyor
set @error=1; select @error
end
else
begin
--diğer durum da departman eklenir
insert into DEPARTMENT (DEPARTMENTNAME) values (@departmentName)
set @error=0; select @error
end