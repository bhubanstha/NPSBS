
USE [NPSBS]
GO


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

go


ALTER proc [dbo].[usp_Examination_Select]
as
begin
	select ex.ExaminationId, ROW_NUMBER() OVER (ORDER BY ex.ExamHeldYear desc, ex.ResultPrintDate asc) as 'S.N', e.ExamName as 'Exam', ex.ExamHeldYear as 'Exam Held Year',
	 ex.ResultPrintDate as 'Result Print Date'
	 FROM Examination ex
	INNER JOIN Exam e on ex.ExamId = e.ExamID
end

GO

ALTER proc [dbo].[usp_Student_Select]
as
begin
	select s.StudentId, ROW_NUMBER() over (order by sc.EnrolledYear desc, c.ClassID desc, CONVERT(INT, sc.RollNumber) asc ) as 'S.N', s.StudentFullName as 'Name', 
	case 
	when s.Gender = 'M' then 'Male'
	else 'Female'
	end as Gender, c.ClassName as 'Class', sc.EnrolledYear as 'Academic Year', sc.RollNumber from Student s
	inner join StudentClass sc on s.StudentId = sc.StudentId
	inner join Class c on sc.ClassId = c.ClassId
end

go

ALTER proc [dbo].[usp_Student_Search]
	@Name nvarchar(100),
	@ClassId int,
	@AcademicYear nvarchar(4)
as
begin
	select s.StudentId, ROW_NUMBER() over (order by sc.EnrolledYear desc, c.ClassID desc, CONVERT(INT, sc.RollNumber) asc ) as 'S.N', s.StudentFullName as 'Name', 
	case 
	when s.Gender = 'M' then 'Male'
	else 'Female'
	end as Gender, c.ClassName as 'Class', sc.EnrolledYear as 'Academic Year', sc.RollNumber from Student s
	inner join StudentClass sc on s.StudentId = sc.StudentId
	inner join Class c on sc.ClassId = c.ClassId
	where (s.StudentFullName like @Name + '%'  or @Name = '' )and sc.ClassId = @ClassId and sc.EnrolledYear  = @AcademicYear
	
end

GO

ALTER proc [dbo].[usp_Student_Transfer]
	@ClassId int,
	@AcademicYear nvarchar(4)
as
begin
	select s.StudentId, ROW_NUMBER() over (order by sc.EnrolledYear desc, c.ClassID desc, CONVERT(INT, sc.RollNumber) asc ) as 'S.N', s.StudentFullName as 'Name', 
	case 
	when s.Gender = 'M' then 'Male'
	else 'Female'
	end as Gender, c.ClassName as 'Class', sc.EnrolledYear as 'Academic Year', 
	sc.RollNumber as 'Roll Number', sc.RollNumber as 'New Roll Number'
	 from Student s
	inner join StudentClass sc on s.StudentId = sc.StudentId
	inner join Class c on sc.ClassId = c.ClassId
	where  sc.ClassId = @ClassId and sc.EnrolledYear  = @AcademicYear
	
end

GO

ALTER TABLE Subjects
ADD IsDelete bit 

GO

Update Subjects set IsDelete = 0

GO

ALTER proc [dbo].[usp_Subject_Delete]
	@SubjectId int
as
begin
	Update Subjects Set IsDelete = 1
	where SubjectId = @SubjectId
end

GO

ALTER proc [dbo].[usp_Subject_ByClass]
	@ClassId int
as
begin
	
	select s.SubjectId, ROW_NUMBER() over (order by c.ClassId, s.SubjectName) as 'S.N',
	 c.ClassName as 'Class', s.SubjectName as 'Subject', s.TheoryMarks as 'Theory Marks', 
	 s.PracticalMarks as 'Practical Marks'
	 from Subjects s
	inner join Class c on s.ClassId = c.ClassId
	where s.IsDelete = 0 AND (s.ClassId = @ClassId OR @ClassId = 0) 
	order by c.ClassId asc, s.SubjectName asc
	
end

GO

ALTER proc [dbo].[usp_Subject_Select]
as
begin
	select s.SubjectId, ROW_NUMBER() over (order by c.ClassId, s.SubjectName) as 'S.N',
	 c.ClassName as 'Class', s.SubjectName as 'Subject', s.TheoryMarks as 'Theory Marks', 
	 s.PracticalMarks as 'Practical Marks'
	 from Subjects s
	inner join Class c on s.ClassId = c.ClassId
	where s.IsDelete = 0
	order by c.ClassId asc, s.SubjectName asc
	
end

GO


ALTER proc [dbo].[usp_Student_Delete]
	@StudentId int
as
begin
begin try
begin tran
	delete from StudentExams where StudentId = @StudentId
	delete from StudentClass where StudentId = @StudentId
	delete from Attendance where StudentId = @StudentId
	delete from  Student where StudentId = @StudentId
commit
end try
begin catch
	rollback
end catch
end

