
ALTER proc [dbo].[usp_Remarks_Get]
		@ClassId int,
	@ExaminationId int,
	@ExamHeldYear int
as
begin
	select r.RemarksID, s.StudentId, DENSE_RANK() over(order by s.StudentId) as SN, s.StudentFullName + '-' +  CONVERT(VARCHAR, s.StudentId) AS [Student Name] , r.Remarks
	FROM Student  s
	LEFT JOIN Remarks r on r.StudentId = s.StudentId AND ExaminationId = @ExaminationId 
						AND ExamHeldYear = @ExamHeldYear
	LEFT JOIN StudentClass sc ON s.StudentId = sc.StudentId
	WHERE sc.ClassId =@ClassId  and sc.EnrolledYear = @ExamHeldYear
end


exec [usp_Remarks_Get] 3, 4, 2074