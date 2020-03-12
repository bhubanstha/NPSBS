USE [KidsZone]
GO

/****** Object: SqlProcedure [dbo].[usp_StudentExam_Save] Script Date: 3/12/2020 8:20:07 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
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
