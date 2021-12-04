--ayrýlan personelin giriþ iþlemlerinin silinmesi için yazýldý. fakat kullanýlmayacak.
--ayrýlan personelin bilgileri silinmek yerine taþýnacak
create proc SessionDelete (@tc char(11))
as
delete SESSION where TC=@tc