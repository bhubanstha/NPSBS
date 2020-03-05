USE [NPSBS]
GO

/****** Object: SqlProcedure [dbo].[usp_Subject_ByClass] Script Date: 3/5/2020 3:20:39 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
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
