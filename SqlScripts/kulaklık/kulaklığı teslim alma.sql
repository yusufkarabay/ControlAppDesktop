create proc HeadsetReturnDelivery (@headsetserino nvarchar(50))
as
delete from HEADSET where HEADSETSERINO=@headsetserino