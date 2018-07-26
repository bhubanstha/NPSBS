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
	Logo varbinary(max)
)

end