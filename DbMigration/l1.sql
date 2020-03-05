USE [NPSBS]
GO

/****** Object: SqlProcedure [dbo].[usp_Examination_Select] Script Date: 3/5/2020 2:35:04 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

ALTER proc [dbo].[usp_Examination_Select]
as
begin
	select ex.ExaminationId, ROW_NUMBER() OVER (ORDER BY ex.ExamHeldYear desc, ex.ResultPrintDate asc) as 'S.N', e.ExamName as 'Exam', ex.ExamHeldYear as 'Exam Held Year',
	 ex.ResultPrintDate as 'Result Print Date'
	 FROM Examination ex
	INNER JOIN Exam e on ex.ExamId = e.ExamID
end
