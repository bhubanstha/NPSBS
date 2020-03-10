USE [NPSBS]
GO

/****** Object: SqlProcedure [dbo].[usp_SaveAttendance] Script Date: 3/10/2020 3:39:11 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

ALTER proc [dbo].[usp_SaveAttendance]
	@RollNumber nvarchar(5),
	@ClassId int,
	@ExaminationId int,
	@ExamHeldYear nvarchar(4),
	@SchoolDays int,
	@PresentDays int,
	@StudentId int
as
begin
	
	if exists(SELECT 'x' from Attendance WHERE StudentId = @StudentId AND ClassId = @ClassId AND
			ExaminationId = @ExaminationId AND ExamHeldYear = @ExamHeldYear)
			BEGIN
					UPDATE Attendance SET SchoolDays = @SchoolDays, PresentDays = @PresentDays
					WHERE StudentId = @StudentId AND ClassId = @ClassId AND
					ExaminationId = @ExaminationId AND ExamHeldYear = @ExamHeldYear			
			END
	ELSE
	BEGIN
		INSERT INTO Attendance (StudentId, ClassId, ExaminationId, ExamHeldYear, SchoolDays, PresentDays) VALUES
		(@StudentId, @ClassId, @ExaminationId, @ExamHeldYear, @SchoolDays,@PresentDays )
	END

	if exists (select 'x' from StudentExtraActivities where StudentId = @StudentId and ActivitiesYear = @ExamHeldYear and ExaminationId = @ExaminationId)
	begin
		update StudentExtraActivities set PresentDays = @PresentDays where StudentId = @StudentId and ActivitiesYear = @ExamHeldYear and ExaminationId = @ExaminationId
	end
	else
	begin
		insert into StudentExtraActivities (StudentId, ActivitiesYear, ExaminationId, SchoolDays, PresentDays) values
		(@StudentId, @ExamHeldYear, @ExaminationId, @SchoolDays,@PresentDays)
	end
end


select top 1 * from StudentExtraActivities