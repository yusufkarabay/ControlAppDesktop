--ayr�lan personelin giri� i�lemlerinin silinmesi i�in yaz�ld�. fakat kullan�lmayacak.
--ayr�lan personelin bilgileri silinmek yerine ta��nacak
create proc SessionDelete (@tc char(11))
as
delete SESSION where TC=@tc