create proc RequestDetailList(@tc char(11))
as
select RD.*,R.REQUESTTITLE,R.REQUESTCONTENT,E.NAME,E.SURNAME from REQUESTDETAIL RD
inner join REQUEST R on RD.REQUESTID=R.REQUESTID
inner join EMPLOYEE E on RD.REQUESTED=E.TC
WHERE REQUESTING=@tc
