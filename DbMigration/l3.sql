USE [NPSBS]
GO

/****** Object: SqlProcedure [dbo].[usp_Student_Search] Script Date: 3/5/2020 2:53:42 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

alter proc [dbo].[usp_Student_Search]
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
