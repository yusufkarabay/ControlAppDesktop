create proc HeadsetDelivery (@headsetserino nvarchar(50),@receiverperson char(11), @deliveryperson char(11),
@headsetstatusinfo nvarchar(100),@deliverydate date)
as
declare @name nvarchar(50)=''
declare @error bit 

set @name =( select HEADSETSERINO from HEADSET where HEADSETSERINO=@headsetserino and RECEIVERPERSON=@receiverperson)

if(@name!='')
begin
set @error=1; select @error
end
else
begin
insert into HEADSET( [HEADSETSERINO],[RECEIVERPERSON],[DELIVERYPERSON],[HEADSETSTATUSINFO],[DELIVERYDATE]) values
(@headsetserino,@receiverperson,@deliveryperson,@headsetstatusinfo,@deliverydate)
set @error=0; select @error
end
