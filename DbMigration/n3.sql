USE [NPSBS]
GO

/****** Object: SqlProcedure [dbo].[usp_StudentExtraActivities_Get] Script Date: 3/10/2020 3:19:42 PM ******/
SET ANSI_NULLS ON
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

