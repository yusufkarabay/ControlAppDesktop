--þifremi unuttum için kullanýlacak prosedur
create proc SessionUpdate (@tc char(11), @password nvarchar(15))
as
update SESSION set PASSWORD=@password where TC=@tc