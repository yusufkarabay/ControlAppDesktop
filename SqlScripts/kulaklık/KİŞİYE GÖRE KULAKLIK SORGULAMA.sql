create proc HeadsetByEmployeeName (@receiverperson char(11))
as
select  * FROM HEADSET
inner join EMPLOYEE ON HEADSET.RECEIVERPERSON= EMPLOYEE.TC AND HEADSET.DELIVERYPERSON= EMPLOYEE.TC
 WHERE RECEIVERPERSON=@receiverperson