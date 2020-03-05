USE [NPSBS]
GO

/****** Object: SqlProcedure [dbo].[usp_Student_Delete] Script Date: 3/5/2020 3:46:04 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
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
