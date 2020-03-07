USE [KidsZone]
GO
/****** Object:  StoredProcedure [dbo].[usp_Examination_Select]    Script Date: 3/6/2020 8:36:31 PM ******/


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


	select top 20 ex.ExaminationId, ROW_NUMBER() OVER (ORDER BY ex.ExamHeldYear desc, ex.ResultPrintDate asc) as 'S.N', e.ExamName as 'Exam', ex.ExamHeldYear as 'Exam Held Year',
	 ex.ResultPrintDate as 'Result Print Date'
	 FROM Examination ex
	INNER JOIN Exam e on ex.ExamId = e.ExamID


end

GO

ALTER proc [dbo].[usp_Examination_GetByYear]
	@Year nvarchar(4)
as
begin
	select ex.ExaminationId, ROW_NUMBER() OVER (ORDER BY ex.ExamHeldYear desc, ex.ResultPrintDate asc) as 'S.N', e.ExamName as 'Exam', ex.ExamHeldYear as 'Exam Held Year',
	 ex.ResultPrintDate as 'Result Print Date'
	 FROM Examination ex
	INNER JOIN Exam e on ex.ExamId = e.ExamID
	where ex.ExamHeldYear = @Year
end

GO
ALTER proc [dbo].[usp_Exam_Delete]
	@ExaminationID int
as
begin
begin try
begin tran
	DELETE FROM StudentExams WHERE ExaminationId = @ExaminationID
	DELETE FROM Remarks where ExaminationId = @ExaminationID
	DELETE FROM StudentExtraActivities where ExaminationId = @ExaminationID
	DELETE FROM Examination WHERE ExaminationId = @ExaminationID
commit
end try
begin catch
	rollback
end catch
end


GO
ALTER proc [dbo].[usp_Student_Select]
as
begin

	select s.StudentId, ROW_NUMBER() over (order by sc.EnrolledYear desc, sc.RollNumber asc, c.ClassId asc) as 'S.N', s.StudentFullName as 'Name', 
	case 
	when s.Gender = 'M' then 'Male'
	else 'Female'
	end as Gender, c.ClassName as 'Class', sc.EnrolledYear as 'Academic Year', sc.RollNumber from Student s
	inner join StudentClass sc on s.StudentId = sc.StudentId
	inner join Class c on sc.ClassId = c.ClassId
	where sc.EnrolledYear = (select ISNULL(MAX(EnrolledYear), 0) from StudentClass)

end


GO
ALTER proc [dbo].[usp_Student_Update]
	@StudentName nvarchar(100),
	@Gender char(1),
	@ClassId int,
	@EnrolledYear nvarchar(4),
	@RollNumber nvarchar(5),
	@StudentId int
as
begin
begin try
begin tran
	update Student set StudentFullName = @StudentName, Gender=@Gender where StudentId = @StudentId
	if(select count(studentid) from StudentClass where StudentId=@StudentId)=1
	begin
		update StudentClass set ClassId = @ClassId, EnrolledYear = @EnrolledYear, RollNumber = @RollNumber
		where StudentId = @StudentId and EnrolledYear = @EnrolledYear
	end
commit
end try
begin catch
	rollback
end catch
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
	delete from Remarks where StudentId = @StudentId
	delete from StudentExtraActivities where StudentId = @StudentId
	delete from  Student where StudentId = @StudentId
commit
end try
begin catch
	select ERROR_MESSAGE()
	rollback
end catch
end



GO

ALTER proc [dbo].[usp_Remarks_Get]
		@ClassId int,
	@ExaminationId int,
	@ExamHeldYear int
as
begin
	select r.RemarksID, s.StudentId, DENSE_RANK() over(order by s.StudentId) as SN, s.StudentFullName  AS [Student Name], sc.RollNumber as [Roll Number] , r.Remarks
	FROM Student  s
	LEFT JOIN Remarks r on r.StudentId = s.StudentId AND ExaminationId = @ExaminationId 
						AND ExamHeldYear = @ExamHeldYear
	LEFT JOIN StudentClass sc ON s.StudentId = sc.StudentId
	WHERE sc.ClassId =@ClassId  and sc.EnrolledYear = @ExamHeldYear
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
	where sc.EnrolledYear = (select ISNULL(MAX(EnrolledYear),0) from StudentClass)
end

