USE [NPSBS]
GO

/****** Object: SqlProcedure [dbo].[usp_Student_Select_By_Class_Year] Script Date: 3/10/2020 2:31:53 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
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
