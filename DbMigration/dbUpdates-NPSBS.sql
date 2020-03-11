
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


GO

ALTER proc [dbo].[usp_Student_Select]
as
begin
	select s.StudentId, ROW_NUMBER() over (order by sc.EnrolledYear desc, c.ClassID desc, CONVERT(INT, sc.RollNumber) asc ) as 'S.N', s.StudentFullName as 'Name', 
	case 
	when s.Gender = 'M' then 'Male'
	else 'Female'
	end as Gender, c.ClassName as 'Class', sc.EnrolledYear as 'Academic Year', sc.RollNumber as [Roll Number] from Student s
	inner join StudentClass sc on s.StudentId = sc.StudentId
	inner join Class c on sc.ClassId = c.ClassId
	where sc.EnrolledYear = (select ISNULL(MAX(EnrolledYear),0) from StudentClass)
end

GO

ALTER proc [dbo].[usp_Student_Select_By_Class_Year]
@ClassId int,
@EnrolledYear varchar(4),
@SubjectId int,
@ExaminationId int
as
begin
	select sc.RollNumber as [Roll Number], s.StudentFullName as [Student Name], se.TheoryMarks as [Theory Marks], se.PracticalMarks as [Practical Marks],
	sub.TheoryMarks as FullTheory, sub.PracticalMarks as FullPractical, s.StudentId
	 from Student s
	inner join StudentClass sc on s.StudentId = sc.StudentId
	LEFT JOIN StudentExams se on s.StudentId = se.StudentId and sc.ClassId = se.ClassId AND se.SubjectId = @SubjectId
	 AND se.ExaminationId = @ExaminationId
	 LEFT JOIN Subjects sub on sc.ClassId = sub.ClassId AND sub.SubjectId = @SubjectId
	where sc.ClassId = @ClassId AND sc.EnrolledYear = @EnrolledYear
	ORDER BY CONVERT(INT, sc.RollNumber) ASC
end

Go


GO

ALTER proc [dbo].[usp_StudentExam_Save]
@RollNumber varchar(5),
@ExaminationId int,
@ClassId int,
@SubjectId int,
@Theory decimal(6,2),
@Practical decimal(6,2),
@ExamYear nvarchar(4),
@StudentId int
as
begin
begin try
begin tran

	if EXISTS(SELECT 'a' FROM StudentExams WHERE StudentId = @StudentId AND ExaminationId = @ExaminationId AND ClassId = @ClassId AND SubjectId = @SubjectId)
	BEGIN
		UPDATE StudentExams SET TheoryMarks = @Theory, PracticalMarks = @Practical 
			 WHERE StudentId = @StudentId AND ExaminationId = @ExaminationId AND ClassId = @ClassId AND SubjectId = @SubjectId
	END
	ELSE
	BEGIN
		INSERT INTO StudentExams (StudentId, ExaminationId, ClassId, SubjectId, TheoryMarks, PracticalMarks) VALUES
		(@StudentId, @ExaminationId, @ClassId, @SubjectId, @Theory, @Practical)
	END
commit
end try
begin catch
	rollback
end catch
end

GO

GO

SET QUOTED_IDENTIFIER ON
GO

ALTER proc [dbo].[usp_StudentExtraActivities_Get]
	@Year nvarchar(4) ,
	@Examination nvarchar(4)
as
begin 
		select s.StudentId, sc.RollNumber as [Roll Number], s. StudentFullName as [Student Name], sea.SchoolDays as [School Days], sea.PresentDays as [Present Days], sea.Drawing, sea.Games, 
		sea.Conduct, sea.PersonalCleanliness, sea.Cooperation  FROM Student s
		INNER JOIN StudentClass sc on s.StudentId = sc.StudentId AND sc.EnrolledYear = @Year and sc.ClassId = 1
		LEFT JOIN StudentExtraActivities sea on s.StudentId = sea.StudentId AND sea.ExaminationId = @Examination	
end

GO

ALTER proc [dbo].[usp_StudentExtraActivities_Save]
	@RollNumber nvarchar(5) ,
	@ActivitiesYear nvarchar(4),
	@ExaminationId int  ,
	@SchoolDays int,
	@PresentDays int,
	@Drawing nvarchar(4),
	@Games nvarchar(4),
	@Conduct nvarchar(4),
	@PersonalCleanliness nvarchar(4),
	@Cooperation nvarchar(4),
	@StudentId int

as
begin 	
	if exists (SELECT 'x' FROM StudentExtraActivities WHERE StudentId = @StudentId AND 
				ActivitiesYear = @ActivitiesYear AND ExaminationId = @ExaminationId)
	BEGIN
		UPDATE StudentExtraActivities SET SchoolDays = @SchoolDays, PresentDays = @PresentDays,
		Drawing = @Drawing, Games = @Games, Conduct = @Conduct, 
		PersonalCleanliness = @PersonalCleanliness, Cooperation=@Cooperation 
		WHERE StudentId = @StudentId AND  ActivitiesYear = @ActivitiesYear AND ExaminationId = @ExaminationId
	END
	ELSE
	BEGIN
		INSERT INTO StudentExtraActivities (StudentId, ActivitiesYear, ExaminationId, SchoolDays, PresentDays, Drawing, Games,
		 Conduct, PersonalCleanliness, Cooperation) VALUES
	(@StudentId, @ActivitiesYear, @ExaminationId, @SchoolDays, @PresentDays, @Drawing, @Games, @Conduct, 
	@PersonalCleanliness, @Cooperation)	
	END

	declare @ClassId int
	select @ClassId = ClassId from StudentClass where StudentId = @StudentId and EnrolledYear = @ActivitiesYear and RollNumber = @RollNumber
	if exists (SELECT 'x' FROM Attendance WHERE StudentId = @StudentId AND 
				ExamHeldYear = @ActivitiesYear AND ExaminationId = @ExaminationId and ClassId = @ClassId)
	begin
		update Attendance set PresentDays = @PresentDays where StudentId = @StudentId AND 
				ExamHeldYear = @ActivitiesYear AND ExaminationId = @ExaminationId and ClassId = @ClassId
	end
	else
	begin
		insert into Attendance(StudentId, ClassId, ExaminationId, ExamHeldYear, SchoolDays, PresentDays) values
		(@StudentId, @ClassId,@ExaminationId, @ActivitiesYear, @SchoolDays, @PresentDays)
	end
end

GO

--	EXEC usp_Student_Select_By_Class_Year_Examination 13, 2073, 1
ALTER proc [dbo].[usp_Student_Select_By_Class_Year_Examination]
@ClassId int,
@EnrolledYear varchar(4),
@ExaminationId int
as
begin
	select S.StudentId, isnull(a.SchoolDays,70) SchoolDays, sc.RollNumber AS [Roll Number], s.StudentFullName as [Student Name], 
	 ISNULL( a.PresentDays,0) as [Present Days]
	 from Student s
	inner join StudentClass sc on s.StudentId = sc.StudentId
	LEFT JOIN Attendance a on s.StudentId = a.StudentId and sc.ClassId = a.ClassId 
	 AND a.ExaminationId = @ExaminationId AND a.ExamHeldYear = @EnrolledYear
	where sc.ClassId = @ClassId AND sc.EnrolledYear = @EnrolledYear
	ORDER BY CONVERT(INT, sc.RollNumber) ASC
end
GO

ALTER proc [dbo].[usp_SaveAttendance]
	@RollNumber nvarchar(5),
	@ClassId int,
	@ExaminationId int,
	@ExamHeldYear nvarchar(4),
	@SchoolDays int,
	@PresentDays int,
	@StudentId int
as
begin
	
	if exists(SELECT 'x' from Attendance WHERE StudentId = @StudentId AND ClassId = @ClassId AND
			ExaminationId = @ExaminationId AND ExamHeldYear = @ExamHeldYear)
			BEGIN
					UPDATE Attendance SET SchoolDays = @SchoolDays, PresentDays = @PresentDays
					WHERE StudentId = @StudentId AND ClassId = @ClassId AND
					ExaminationId = @ExaminationId AND ExamHeldYear = @ExamHeldYear			
			END
	ELSE
	BEGIN
		INSERT INTO Attendance (StudentId, ClassId, ExaminationId, ExamHeldYear, SchoolDays, PresentDays) VALUES
		(@StudentId, @ClassId, @ExaminationId, @ExamHeldYear, @SchoolDays,@PresentDays )
	END

	if exists (select 'x' from StudentExtraActivities where StudentId = @StudentId and ActivitiesYear = @ExamHeldYear and ExaminationId = @ExaminationId)
	begin
		update StudentExtraActivities set PresentDays = @PresentDays where StudentId = @StudentId and ActivitiesYear = @ExamHeldYear and ExaminationId = @ExaminationId
	end
	else
	begin
		insert into StudentExtraActivities (StudentId, ActivitiesYear, ExaminationId, SchoolDays, PresentDays) values
		(@StudentId, @ExamHeldYear, @ExaminationId, @SchoolDays,@PresentDays)
	end
end

