create proc MyRequestList(@tc char(11))
as
select RD.REQUESTDETAILID,RD.REQUESTID,R.REQUESTTITLE,R.REQUESTCONTENT,E.NAME,E.SURNAME from REQUESTDETAIL RD
inner join REQUEST R on RD.REQUESTID=R.REQUESTID
inner join EMPLOYEE E on RD.REQUESTING=E.TC
where REQUESTING=@tc