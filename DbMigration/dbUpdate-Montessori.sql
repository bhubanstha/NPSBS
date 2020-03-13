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

GO

ALTER proc [dbo].[usp_Student_Select_By_Class_Year]
@ClassId int,
@EnrolledYear varchar(4),
@SubjectId int,
@ExaminationId int
as
begin
	select s.StudentId, sc.RollNumber as [Roll Number], s.StudentFullName as [Student Name], se.Grade 
	 from Student s
	inner join StudentClass sc on s.StudentId = sc.StudentId
	LEFT JOIN StudentExams se on s.StudentId = se.StudentId and sc.ClassId = sc.ClassId 
	AND se.SubjectId = @SubjectId
	AND se.ExaminationId = @ExaminationId
	 LEFT JOIN Subjects sub on se.SubjectId = sub.SubjectId
	where sc.ClassId = @ClassId AND sc.EnrolledYear = @EnrolledYear
	ORDER BY convert(int, sc.RollNumber) ASC
end

GO

ALTER proc [dbo].[usp_StudentExam_Save]
@RollNumber varchar(5),
@ExaminationId int,
@ClassId int,
@SubjectId int,
@Grade nchar(2),
@ExamYear nvarchar(4),
@StudentId int
as
begin
begin try
begin tran
	
	if EXISTS(SELECT 'a' FROM StudentExams WHERE StudentId = @StudentId AND ExaminationId = @ExaminationId AND ClassId = @ClassId AND SubjectId = @SubjectId)
	BEGIN
		UPDATE StudentExams SET Grade = @Grade
			 WHERE StudentId = @StudentId AND ExaminationId = @ExaminationId AND ClassId = @ClassId AND SubjectId = @SubjectId
	END
	ELSE
	BEGIN
		INSERT INTO StudentExams (StudentId, ExaminationId, ClassId, SubjectId, Grade) VALUES
		(@StudentId, @ExaminationId, @ClassId, @SubjectId, @Grade)
	END
commit
end try
begin catch
	rollback
end catch
end
GO
	
ALTER proc [dbo].[usp_ExamResult]
@ExaminationId int,
@ClassId int,
@Year varchar(5)
as
begin
	declare @minId int, @maxId int
	
	select SN=identity(int ,1,1), sub.ClassId, s.StudentId, ex.ExamName, e.ExamHeldYear, e.ResultPrintDate, 
	c.ClassName, s.StudentFullName,  sc.RollNumber, sub.SubjectName,  se.Grade as 'ObtainedGrade', r.Remarks
	INTO #tempResult   FROM StudentExams se
	INNER JOIN Student s on se.StudentId = s.StudentId
	INNER JOIN Examination e on se.ExaminationId = e.ExaminationId
	INNER JOIN Exam ex on e.ExamId = ex.ExamID
	INNER JOIN Class c on se.ClassId = c.ClassId
	INNER JOIN StudentClass sc on se.StudentId = sc.StudentId AND se.ClassId = sc.ClassId
	INNER JOIN Subjects sub on se.SubjectId = sub.SubjectId
	LEFT JOIN Remarks r ON s.StudentId  =r.StudentId AND sc.ClassId = r.ClassId AND e.ExaminationId = r.ExaminationId
	WHERE se.ExaminationId = @ExaminationId AND se.ClassId = @ClassId and  e.ExamHeldYear = @Year
	
	SELECT DISTINCT  StudentId into #StudentRecord FROM #tempResult
	
	
	set @minId = (SELECT MIN(StudentId) from #StudentRecord)
	set @maxId = (SELECT MAX(StudentId) from #StudentRecord)
	WHILE (@minId<= @maxId)
	BEGIN
		if(SELECT COUNT(*) from	#tempResult WHERE StudentId = (SELECT StudentId FROM #StudentRecord WHERE StudentId= @minId) )>0
	BEGIN	
		SELECT * FROM #tempResult WHERE StudentId = (SELECT StudentId FROM #StudentRecord WHERE StudentId= @minId) ORDER BY ClassID
		END
		SET @minId = @minId +1
	END
	
	DROP TABLE #tempResult
	DROP TABLE #StudentRecord
end
GO


ALTER proc [dbo].[usp_Remarks_Save]
	@StudentId int,
	@ClassId int,
	@ExaminationId int,
	@ExamHeldYear int,
	@Remark nvarchar (250),
	@RemarkId int
as
begin
	if (@RemarkId=0)
	BEGIN
		INSERT INTO Remarks(StudentId, ClassId, ExaminationId, ExamHeldYear, Remarks) VALUES
			(@StudentId, @ClassId, @ExaminationId, @ExamHeldYear, @Remark)
	END
	ELSE
	BEGIN
		UPDATE Remarks SET Remarks =@Remark WHERE RemarksId = @RemarkId
	END
end


GO
