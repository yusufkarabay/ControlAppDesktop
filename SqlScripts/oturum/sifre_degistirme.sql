--�ifremi unuttum i�in kullan�lacak prosedur
create proc SessionUpdate (@tc char(11), @password nvarchar(15))
as
update SESSION set PASSWORD=@password where TC=@tc