USE [KidsZone]
GO

/****** Object: SqlProcedure [dbo].[usp_Remarks_Save] Script Date: 3/12/2020 8:39:55 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


ALTER proc [dbo].[usp_Remarks_Save]
	@StudentId int,
	@ClassId int,
	@ExaminationId int,
	@ExamHeldYear int,
	@Remark nvarchar (250),
	@RemarkId int
as
begin
	if (@RemarkId=0)
	BEGIN
		INSERT INTO Remarks(StudentId, ClassId, ExaminationId, ExamHeldYear, Remarks) VALUES
			(@StudentId, @ClassId, @ExaminationId, @ExamHeldYear, @Remark)
	END
	ELSE
	BEGIN
		UPDATE Remarks SET Remarks =@Remark WHERE RemarksId = @RemarkId
	END
end
