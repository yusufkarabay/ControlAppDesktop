USE [CONTROLAPP]
GO
/****** Object:  StoredProcedure [dbo].[RequestDetailList]    Script Date: 13.12.2021 20:52:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER proc [dbo].[RequestDetailList](@tc char(11))
as
select RD.*,R.REQUESTTITLE,R.REQUESTCONTENT,E.NAME+E.SURNAME from REQUESTDETAIL RD
inner join REQUEST R on RD.REQUESTID=R.REQUESTID
inner join EMPLOYEE E on RD.REQUESTED=E.TC
WHERE REQUESTING=@tc
