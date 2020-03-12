USE [KidsZone]
GO

/****** Object: SqlProcedure [dbo].[usp_Student_Select_By_Class_Year] Script Date: 3/12/2020 8:17:08 PM ******/
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
