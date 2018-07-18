
ALTER proc [dbo].[usp_Remarks_Get]
		@ClassId int,
	@ExaminationId int,
	@ExamHeldYear int
as
begin
	select s.StudentFullName + '-' +  CONVERT(VARCHAR, s.StudentId) AS StudentFullName , r.Remarks
	FROM Student  s
	LEFT JOIN Remarks r on r.StudentId = s.StudentId AND ExaminationId = @ExaminationId 
						AND ExamHeldYear = @ExamHeldYear
	LEFT JOIN StudentClass sc ON s.StudentId = sc.StudentId
	WHERE sc.ClassId =@ClassId  and sc.EnrolledYear = @ExamHeldYear
end

