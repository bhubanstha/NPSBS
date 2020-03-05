USE [NPSBS]
GO

ALTER TABLE Subjects
ADD IsDelete bit 

GO

Update Subjects set IsDelete = 0

GO

ALTER proc [dbo].[usp_Subject_Delete]
	@SubjectId int
as
begin
	Update Subjects Set IsDelete = 1
	where SubjectId = @SubjectId
end

