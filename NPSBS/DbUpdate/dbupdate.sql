if not exists(select * from INFORMATION_SCHEMA.TABLES where TABLE_CATALOG = 'NPSBS' and TABLE_NAME = 'School')
begin

create table School
(
	ID int primary key identity(1,1),
	SchoolName nvarchar(500),
	ShortName nvarchar(10),
	Address nvarchar(500),
	Phone nvarchar(40),
	Email nvarchar(100),
	Website nvarchar(100),
	Logo varbinary(max),
	EstiblishedYear int,
	Slogan nvarchar(1000)
)

end

GO

create proc SaveUpdateSchool
@Id int,
@SchoolName nvarchar(500),
@ShortName nvarchar(10),
@Address nvarchar(500),
@PhoneNo nvarchar(40),
@Email nvarchar(100),
@WebSite nvarchar(100),
@Logo varbinary(max),
@EstiblishedYear int,
@Slogan nvarchar(1000)
as
begin
	if @Id>0
	begin
		update School set SchoolName = @SchoolName, ShortName = @ShortName, Address = @Address, Phone = @PhoneNo, Email = @Email, Website = @WebSite, Logo = @Logo, EstiblishedYear =@EstiblishedYear, Slogan = @Slogan
		where ID = @Id
		select @Id
	end
	else
	begin
		insert into School (SchoolName, ShortName, Address, Phone, Email, Website, Logo, EstiblishedYear,Slogan) values
		(@SchoolName, @ShortName, @Address, @PhoneNo, @Email, @WebSite, @Logo,@EstiblishedYear,@Slogan)
		select @@IDENTITY
	end

end

GO

create proc GetSchoolInfo
as
begin
	select top 1 * from School

end