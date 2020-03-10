USE [NPSBS]
GO

/****** Object: SqlProcedure [dbo].[usp_Student_Select_By_Class_Year_Examination] Script Date: 3/10/2020 3:33:57 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
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


EXEC [usp_Student_Select_By_Class_Year_Examination] @ClassId = 10, @EnrolledYear = '2075', @ExaminationId=38

