USE [NPSBS]
GO

/****** Object: SqlProcedure [dbo].[usp_StudentExtraActivities_Save] Script Date: 3/10/2020 3:28:32 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

ALTER proc [dbo].[usp_StudentExtraActivities_Save]
	@RollNumber nvarchar(5) ,
	@ActivitiesYear nvarchar(4),
	@ExaminationId int  ,
	@SchoolDays int,
	@PresentDays int,
	@Drawing nvarchar(4),
	@Games nvarchar(4),
	@Conduct nvarchar(4),
	@PersonalCleanliness nvarchar(4),
	@Cooperation nvarchar(4),
	@StudentId int

as
begin 	
	if exists (SELECT 'x' FROM StudentExtraActivities WHERE StudentId = @StudentId AND 
				ActivitiesYear = @ActivitiesYear AND ExaminationId = @ExaminationId)
	BEGIN
		UPDATE StudentExtraActivities SET SchoolDays = @SchoolDays, PresentDays = @PresentDays,
		Drawing = @Drawing, Games = @Games, Conduct = @Conduct, 
		PersonalCleanliness = @PersonalCleanliness, Cooperation=@Cooperation 
		WHERE StudentId = @StudentId AND  ActivitiesYear = @ActivitiesYear AND ExaminationId = @ExaminationId
	END
	ELSE
	BEGIN
		INSERT INTO StudentExtraActivities (StudentId, ActivitiesYear, ExaminationId, SchoolDays, PresentDays, Drawing, Games,
		 Conduct, PersonalCleanliness, Cooperation) VALUES
	(@StudentId, @ActivitiesYear, @ExaminationId, @SchoolDays, @PresentDays, @Drawing, @Games, @Conduct, 
	@PersonalCleanliness, @Cooperation)	
	END

	declare @ClassId int
	select @ClassId = ClassId from StudentClass where StudentId = @StudentId and EnrolledYear = @ActivitiesYear and RollNumber = @RollNumber
	if exists (SELECT 'x' FROM Attendance WHERE StudentId = @StudentId AND 
				ExamHeldYear = @ActivitiesYear AND ExaminationId = @ExaminationId and ClassId = @ClassId)
	begin
		update Attendance set PresentDays = @PresentDays where StudentId = @StudentId AND 
				ExamHeldYear = @ActivitiesYear AND ExaminationId = @ExaminationId and ClassId = @ClassId
	end
	else
	begin
		insert into Attendance(StudentId, ClassId, ExaminationId, ExamHeldYear, SchoolDays, PresentDays) values
		(@StudentId, @ClassId,@ExaminationId, @ActivitiesYear, @SchoolDays, @PresentDays)
	end
end

