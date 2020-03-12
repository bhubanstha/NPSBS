USE [KidsZone]
GO

/****** Object: SqlProcedure [dbo].[usp_ExamResult] Script Date: 3/12/2020 8:31:51 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
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
