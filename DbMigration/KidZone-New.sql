USE [master]
GO
/****** Object:  Database [KidsZone]    Script Date: 3/9/2020 7:31:52 PM ******/
CREATE DATABASE [KidsZone-New]
GO
USE [KidsZone-New]
GO
/****** Object:  Table [dbo].[Class]    Script Date: 3/9/2020 7:31:52 PM ******/

SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Class](
	[ClassId] [int] IDENTITY(1,1) NOT NULL,
	[ClassName] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[ClassId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Exam]    Script Date: 3/9/2020 7:31:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Exam](
	[ExamID] [int] IDENTITY(1,1) NOT NULL,
	[ExamName] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[ExamID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Examination]    Script Date: 3/9/2020 7:31:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Examination](
	[ExaminationId] [int] IDENTITY(1,1) NOT NULL,
	[ExamHeldYear] [nvarchar](4) NULL,
	[ExamId] [int] NULL,
	[ResultPrintDate] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[ExaminationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GradingSystem]    Script Date: 3/9/2020 7:31:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GradingSystem](
	[GradingSystemId] [int] IDENTITY(1,1) NOT NULL,
	[MarksFrom] [decimal](6, 2) NULL,
	[MarksTo] [decimal](6, 2) NULL,
	[Grade] [nvarchar](5) NULL,
	[Remarks] [nvarchar](200) NULL,
PRIMARY KEY CLUSTERED 
(
	[GradingSystemId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Remarks]    Script Date: 3/9/2020 7:31:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Remarks](
	[RemarksId] [int] IDENTITY(1,1) NOT NULL,
	[StudentId] [int] NULL,
	[ClassId] [int] NULL,
	[ExaminationId] [int] NULL,
	[ExamHeldYear] [nvarchar](4) NULL,
	[Remarks] [nvarchar](250) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[School]    Script Date: 3/9/2020 7:31:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[School](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[SchoolName] [nvarchar](500) NULL,
	[ShortName] [nvarchar](10) NULL,
	[Address] [nvarchar](500) NULL,
	[Phone] [nvarchar](40) NULL,
	[Email] [nvarchar](100) NULL,
	[Website] [nvarchar](100) NULL,
	[Logo] [varbinary](max) NULL,
	[EstiblishedYear] [int] NULL,
	[Slogan] [nvarchar](1000) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Student]    Script Date: 3/9/2020 7:31:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Student](
	[StudentId] [int] IDENTITY(1,1) NOT NULL,
	[StudentFullName] [nvarchar](100) NULL,
	[Gender] [char](1) NULL,
PRIMARY KEY CLUSTERED 
(
	[StudentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StudentClass]    Script Date: 3/9/2020 7:31:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StudentClass](
	[StudentId] [int] NOT NULL,
	[ClassId] [int] NOT NULL,
	[EnrolledYear] [nvarchar](4) NOT NULL,
	[RollNumber] [varchar](5) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[StudentId] ASC,
	[ClassId] ASC,
	[EnrolledYear] ASC,
	[RollNumber] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StudentExams]    Script Date: 3/9/2020 7:31:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StudentExams](
	[StudentId] [int] NOT NULL,
	[ExaminationId] [int] NOT NULL,
	[ClassId] [int] NOT NULL,
	[SubjectId] [int] NOT NULL,
	[Grade] [nchar](2) NULL,
PRIMARY KEY CLUSTERED 
(
	[StudentId] ASC,
	[ExaminationId] ASC,
	[ClassId] ASC,
	[SubjectId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StudentExtraActivities]    Script Date: 3/9/2020 7:31:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StudentExtraActivities](
	[StudentId] [int] NOT NULL,
	[ActivitiesYear] [nvarchar](4) NOT NULL,
	[ExaminationId] [int] NOT NULL,
	[SchoolDays] [int] NULL,
	[Present_Days] [int] NULL,
	[Reading_And_Writing_Skill] [nvarchar](50) NULL,
	[Recognition_of_Letter] [nvarchar](50) NULL,
	[English] [nvarchar](50) NULL,
	[Nepali] [nvarchar](50) NULL,
	[Copying_Skill] [nvarchar](50) NULL,
	[Students_Academic_Attitude] [nvarchar](50) NULL,
	[Concentration] [nvarchar](50) NULL,
	[Co-operation] [nvarchar](50) NULL,
	[Memory] [nvarchar](50) NULL,
	[Curiosity] [nvarchar](50) NULL,
	[Understanding] [nvarchar](50) NULL,
	[Student_Department] [nvarchar](50) NULL,
	[Conduct] [nvarchar](50) NULL,
	[Neatness_And_Tidiness] [nvarchar](50) NULL,
	[Punctuality] [nvarchar](50) NULL,
	[Politeness] [nvarchar](50) NULL,
	[Height_And_Weight] [nvarchar](50) NULL,
	[Extra_Curricular_Activities] [nvarchar](50) NULL,
	[Drill/P.T] [nvarchar](50) NULL,
	[Dance] [nvarchar](50) NULL,
	[Rhymes] [nvarchar](50) NULL,
 CONSTRAINT [PK__StudentE__31431A8222AA2996] PRIMARY KEY CLUSTERED 
(
	[StudentId] ASC,
	[ActivitiesYear] ASC,
	[ExaminationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Subjects]    Script Date: 3/9/2020 7:31:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Subjects](
	[SubjectId] [int] IDENTITY(1,1) NOT NULL,
	[SubjectName] [nvarchar](100) NULL,
	[ClassId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[SubjectId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Class] ON 

INSERT [dbo].[Class] ([ClassId], [ClassName]) VALUES (1, N'Foundation')
INSERT [dbo].[Class] ([ClassId], [ClassName]) VALUES (2, N'Pre- Elementary I')
INSERT [dbo].[Class] ([ClassId], [ClassName]) VALUES (3, N'Pre- Elementary II')
SET IDENTITY_INSERT [dbo].[Class] OFF
SET IDENTITY_INSERT [dbo].[Exam] ON 

INSERT [dbo].[Exam] ([ExamID], [ExamName]) VALUES (1, N'First Terminal Examination')
INSERT [dbo].[Exam] ([ExamID], [ExamName]) VALUES (2, N'Mid Terminal Examination')
INSERT [dbo].[Exam] ([ExamID], [ExamName]) VALUES (3, N'Second Terminal Examination')
INSERT [dbo].[Exam] ([ExamID], [ExamName]) VALUES (4, N'Annual Exam')
SET IDENTITY_INSERT [dbo].[Exam] OFF
SET IDENTITY_INSERT [dbo].[Examination] ON 

INSERT [dbo].[Examination] ([ExaminationId], [ExamHeldYear], [ExamId], [ResultPrintDate]) VALUES (1, N'2073', 1, CAST(N'2073-04-07' AS Date))
INSERT [dbo].[Examination] ([ExaminationId], [ExamHeldYear], [ExamId], [ResultPrintDate]) VALUES (2, N'2073', 4, CAST(N'2073-12-23' AS Date))
INSERT [dbo].[Examination] ([ExaminationId], [ExamHeldYear], [ExamId], [ResultPrintDate]) VALUES (3, N'2074', 1, CAST(N'2074-04-06' AS Date))
INSERT [dbo].[Examination] ([ExaminationId], [ExamHeldYear], [ExamId], [ResultPrintDate]) VALUES (4, N'2074', 4, CAST(N'2074-12-23' AS Date))
INSERT [dbo].[Examination] ([ExaminationId], [ExamHeldYear], [ExamId], [ResultPrintDate]) VALUES (5, N'2075', 1, CAST(N'2075-04-03' AS Date))
INSERT [dbo].[Examination] ([ExaminationId], [ExamHeldYear], [ExamId], [ResultPrintDate]) VALUES (6, N'2075', 3, CAST(N'2075-10-13' AS Date))
INSERT [dbo].[Examination] ([ExaminationId], [ExamHeldYear], [ExamId], [ResultPrintDate]) VALUES (7, N'2075', 4, CAST(N'2075-12-24' AS Date))
INSERT [dbo].[Examination] ([ExaminationId], [ExamHeldYear], [ExamId], [ResultPrintDate]) VALUES (8, N'2076', 1, CAST(N'2076-04-06' AS Date))
INSERT [dbo].[Examination] ([ExaminationId], [ExamHeldYear], [ExamId], [ResultPrintDate]) VALUES (9, N'2076', 2, CAST(N'2076-07-07' AS Date))
INSERT [dbo].[Examination] ([ExaminationId], [ExamHeldYear], [ExamId], [ResultPrintDate]) VALUES (10, N'2076', 3, CAST(N'2076-10-09' AS Date))
SET IDENTITY_INSERT [dbo].[Examination] OFF
SET IDENTITY_INSERT [dbo].[Remarks] ON 

INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (1, 1, 1, 1, N'2073', N'Promoted to Class Pre- I')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (2, 2, 1, 1, N'2073', N'Promoted to Class Pre- I')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (3, 3, 1, 1, N'2073', N'Promoted to Class Pre- I')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (4, 4, 1, 1, N'2073', N'Promoted to Class Pre- I')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (5, 5, 1, 1, N'2073', N'Promoted to Class Pre- I')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (6, 6, 1, 1, N'2073', N'Promoted to Class Pre- I')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (7, 7, 1, 1, N'2073', N'Promoted to Class Pre- I')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (8, 8, 1, 1, N'2073', N'Promoted to Class Pre- I')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (9, 10, 2, 1, N'2073', N'He must work hard for better performance and try to improve handwriting also.')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (10, 11, 2, 1, N'2073', N'Well done! Keep it up.')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (11, 12, 2, 1, N'2073', N'She can do better with little more effort.')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (12, 13, 2, 1, N'2073', N'Excellent work, keep it up and improve your handwriting.')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (13, 14, 2, 1, N'2073', N'Hard work is the only key to enhance your performance.')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (14, 15, 2, 1, N'2073', N'The child shows interest in all subjects. A regulat guifance at home will help the child fot better position.')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (15, 16, 2, 1, N'2073', N'His result is satisfactory. He must participate more in class.')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (16, 17, 2, 1, N'2073', N'Excellent! Keep it up!!')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (17, 18, 2, 1, N'2073', N'Excellent work! Keep it up!!')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (18, 19, 2, 1, N'2073', N'Excellent! Keep it up!!')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (19, 20, 2, 1, N'2073', N'')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (20, 21, 2, 1, N'2073', N'')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (21, 22, 2, 1, N'2073', N'Excellent performance!')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (22, 23, 2, 1, N'2073', N'He can do better with little more effort.')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (23, 24, 3, 1, N'2073', N'Well done! Keep it up!')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (24, 25, 3, 1, N'2073', N'Excellent! Keep it up!!')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (25, 26, 3, 1, N'2073', N'Doing well, but he has improve his handwriting.')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (26, 27, 3, 1, N'2073', N'His result is satisfactory. He can do more than this.')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (27, 28, 3, 1, N'2073', N'He is a good boy. Doing well.')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (28, 29, 3, 1, N'2073', N'His result is satisfactory. But try to improve your handwriting.')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (29, 30, 3, 1, N'2073', N'He has to work hard to obtain good result. Be regular in class.')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (30, 1, 1, 2, N'2073', N'Promoted to Class Pre- I')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (31, 2, 1, 2, N'2073', N'Promoted to Class Pre- I')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (32, 3, 1, 2, N'2073', N'Promoted to Class Pre- I')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (33, 4, 1, 2, N'2073', N'Promoted to Class Pre- I')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (34, 5, 1, 2, N'2073', N'Promoted to Class Pre- I')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (35, 6, 1, 2, N'2073', N'Promoted to Class Pre- I')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (36, 7, 1, 2, N'2073', N'Promoted to Class Pre- I')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (37, 8, 1, 2, N'2073', N'Promoted to Class Pre- I')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (38, 1, 2, 2, N'2073', N'')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (39, 2, 2, 2, N'2073', N'')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (40, 3, 2, 2, N'2073', N'')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (41, 4, 2, 2, N'2073', N'')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (42, 5, 2, 2, N'2073', N'')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (43, 6, 2, 2, N'2073', N'')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (44, 7, 2, 2, N'2073', N'')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (45, 8, 2, 2, N'2073', N'')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (46, 1, 3, 2, N'2073', N'')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (47, 2, 3, 2, N'2073', N'')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (48, 3, 3, 2, N'2073', N'')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (49, 4, 3, 2, N'2073', N'')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (50, 5, 3, 2, N'2073', N'')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (51, 6, 3, 2, N'2073', N'')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (52, 7, 3, 2, N'2073', N'')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (53, 8, 3, 2, N'2073', N'')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (54, 38, 1, 2, N'2073', N'Promoted to Class Pre- I')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (55, 38, 2, 2, N'2073', N'')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (56, 38, 3, 2, N'2073', N'')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (57, 38, 1, 1, N'2073', N'Promoted to Class Pre- I')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (58, 10, 2, 2, N'2073', N'Promoted to class Pre- II')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (59, 11, 2, 2, N'2073', N'Promoted to class Pre- II')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (60, 12, 2, 2, N'2073', N'Promoted to class Pre- II')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (61, 13, 2, 2, N'2073', N'Promoted to class Pre- II')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (62, 14, 2, 2, N'2073', N'Promoted to class Pre- II')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (63, 15, 2, 2, N'2073', N'Promoted to class Pre- II')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (64, 16, 2, 2, N'2073', N'Promoted to class Pre- II')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (65, 17, 2, 2, N'2073', N'Promoted to class Pre- II')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (66, 18, 2, 2, N'2073', N'Promoted to class Pre- II')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (67, 19, 2, 2, N'2073', N'Promoted to class Pre- II')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (68, 22, 2, 2, N'2073', N'Promoted to class Pre- II')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (69, 23, 2, 2, N'2073', N'Promoted to class Pre- II')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (70, 24, 3, 2, N'2073', N'Promoted to Class- 1')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (71, 25, 3, 2, N'2073', N'Promoted to Class- 1')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (72, 26, 3, 2, N'2073', N'Promoted to Class- 1')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (73, 27, 3, 2, N'2073', N'Promoted to Class- 1')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (74, 28, 3, 2, N'2073', N'Promoted to Class- 1')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (75, 29, 3, 2, N'2073', N'Promoted to Class- 1')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (76, 1, 1, 3, N'2074', N'')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (77, 2, 1, 3, N'2074', N'')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (78, 3, 1, 3, N'2074', N'')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (79, 4, 1, 3, N'2074', N'')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (80, 5, 1, 3, N'2074', N'')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (81, 6, 1, 3, N'2074', N'')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (82, 7, 1, 3, N'2074', N'')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (83, 8, 1, 3, N'2074', N'')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (84, 20, 1, 3, N'2074', N'')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (85, 21, 1, 3, N'2074', N'')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (86, 30, 1, 3, N'2074', N'')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (87, 38, 1, 3, N'2074', N'')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (88, 39, 1, 3, N'2074', N'She can do better if she get more guidance at home.')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (89, 40, 1, 3, N'2074', N'She is good student.')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (90, 41, 1, 3, N'2074', N'The child shows interest in all subjects. A regular guidance at home.')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (91, 42, 1, 3, N'2074', N'She is a good student.')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (92, 43, 1, 3, N'2074', N'She can do better if she works a bit harder.')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (93, 44, 1, 3, N'2074', N'She is good student. She can do better if she gets more guidance at home.')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (94, 10, 2, 3, N'2074', N'')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (95, 11, 2, 3, N'2074', N'')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (96, 12, 2, 3, N'2074', N'')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (97, 13, 2, 3, N'2074', N'')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (98, 14, 2, 3, N'2074', N'')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (99, 15, 2, 3, N'2074', N'')
GO
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (100, 16, 2, 3, N'2074', N'')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (101, 17, 2, 3, N'2074', N'')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (102, 18, 2, 3, N'2074', N'')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (103, 19, 2, 3, N'2074', N'')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (104, 22, 2, 3, N'2074', N'')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (105, 23, 2, 3, N'2074', N'')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (106, 53, 2, 3, N'2074', N'He is overall good in his study.')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (107, 54, 2, 3, N'2074', N'He has to work very hard in his study.')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (108, 55, 2, 3, N'2074', N'Congratulations! Kepp it up.')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (109, 56, 2, 3, N'2074', N'Congratulations! Keep it up.')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (110, 57, 2, 3, N'2074', N'She is overall good in her study. Keep it up.')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (111, 58, 2, 3, N'2074', N'She must work hard in her study.')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (112, 59, 2, 3, N'2074', N'Congratulations! Keep it up.')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (113, 60, 2, 3, N'2074', N'She is overall good inher study.')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (114, 61, 2, 3, N'2074', N'Congratulations! Keep it up.')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (115, 24, 3, 3, N'2074', N'')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (116, 25, 3, 3, N'2074', N'')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (117, 26, 3, 3, N'2074', N'')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (118, 27, 3, 3, N'2074', N'')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (119, 28, 3, 3, N'2074', N'')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (120, 29, 3, 3, N'2074', N'')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (121, 67, 3, 3, N'2074', N'Doing well. He can do better with little more effort.')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (122, 68, 3, 3, N'2074', N'Excellent! Keep it up!')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (123, 69, 3, 3, N'2074', N'Well done! Keep it up!')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (124, 70, 3, 3, N'2074', N'Excellent performance.')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (125, 71, 3, 3, N'2074', N'Well done! Keep it up!')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (126, 72, 3, 3, N'2074', N'He is overall good in his study.')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (127, 73, 3, 3, N'2074', N'Well done! Keep it up!')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (128, 74, 3, 3, N'2074', N'')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (129, 75, 3, 3, N'2074', N'He is good in all subjects except English. He needs more practise in English.')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (130, 76, 3, 3, N'2074', N'Her result is satisfactory. She can do more than this.')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (131, 77, 3, 3, N'2074', N'He is a good boy, doing well.')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (132, 78, 3, 3, N'2074', N'He is overall good in his study.')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (133, 79, 3, 3, N'2074', N'He has to work hard to obtain good result.')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (134, 1, 1, 4, N'2074', N'')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (135, 2, 1, 4, N'2074', N'')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (136, 3, 1, 4, N'2074', N'')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (137, 4, 1, 4, N'2074', N'')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (138, 5, 1, 4, N'2074', N'')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (139, 6, 1, 4, N'2074', N'')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (140, 7, 1, 4, N'2074', N'')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (141, 8, 1, 4, N'2074', N'')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (142, 20, 1, 4, N'2074', N'')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (143, 21, 1, 4, N'2074', N'')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (144, 30, 1, 4, N'2074', N'')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (145, 38, 1, 4, N'2074', N'')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (146, 39, 1, 4, N'2074', N'Promoted to class Pre Elementary- I')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (147, 40, 1, 4, N'2074', N'Promoted to class Pre Elementary- I')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (148, 41, 1, 4, N'2074', N'Promoted to class Pre Elementary- I')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (149, 42, 1, 4, N'2074', N'')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (150, 43, 1, 4, N'2074', N'Promoted to class Pre Elementary- I')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (151, 44, 1, 4, N'2074', N'Promoted to class Pre Elementary- I')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (152, 10, 2, 4, N'2074', N'')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (153, 11, 2, 4, N'2074', N'')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (154, 12, 2, 4, N'2074', N'')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (155, 13, 2, 4, N'2074', N'')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (156, 14, 2, 4, N'2074', N'')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (157, 15, 2, 4, N'2074', N'')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (158, 16, 2, 4, N'2074', N'')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (159, 17, 2, 4, N'2074', N'')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (160, 18, 2, 4, N'2074', N'')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (161, 19, 2, 4, N'2074', N'')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (162, 22, 2, 4, N'2074', N'')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (163, 23, 2, 4, N'2074', N'')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (164, 53, 2, 4, N'2074', N'Promoted to class Pre Elementary- II')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (165, 54, 2, 4, N'2074', N'Promoted to class Pre Elementary- II')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (166, 55, 2, 4, N'2074', N'Promoted to class Pre Elementary- II')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (167, 56, 2, 4, N'2074', N'Promoted to class Pre Elementary- II')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (168, 57, 2, 4, N'2074', N'Promoted to class Pre Elementary- II')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (169, 58, 2, 4, N'2074', N'Promoted to class Pre Elementary- II')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (170, 59, 2, 4, N'2074', N'Promoted to class Pre Elementary- II')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (171, 60, 2, 4, N'2074', N'Promoted to class Pre Elementary- II')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (172, 61, 2, 4, N'2074', N'Promoted to class Pre Elementary- II')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (173, 24, 3, 4, N'2074', N'')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (174, 25, 3, 4, N'2074', N'')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (175, 26, 3, 4, N'2074', N'')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (176, 27, 3, 4, N'2074', N'')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (177, 28, 3, 4, N'2074', N'')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (178, 29, 3, 4, N'2074', N'')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (179, 67, 3, 4, N'2074', N'Promoted to Class- I')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (180, 68, 3, 4, N'2074', N'Promoted to Class- I')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (181, 69, 3, 4, N'2074', N'Promoted to Class- I')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (182, 70, 3, 4, N'2074', N'Promoted to Class- I')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (183, 71, 3, 4, N'2074', N'Promoted to Class- I')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (184, 72, 3, 4, N'2074', N'Promoted to Class- I')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (185, 73, 3, 4, N'2074', N'Promoted to Class- I')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (186, 74, 3, 4, N'2074', N'')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (187, 75, 3, 4, N'2074', N'Promoted to Class- I')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (188, 76, 3, 4, N'2074', N'Promoted to Class- I')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (189, 77, 3, 4, N'2074', N'Promoted to Class- I')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (190, 78, 3, 4, N'2074', N'Promoted to Class- I')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (191, 79, 3, 4, N'2074', N'Promoted to Class- I')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (192, 1, 1, 5, N'2075', N'')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (193, 2, 1, 5, N'2075', N'')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (194, 3, 1, 5, N'2075', N'')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (195, 4, 1, 5, N'2075', N'')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (196, 5, 1, 5, N'2075', N'')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (197, 6, 1, 5, N'2075', N'')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (198, 7, 1, 5, N'2075', N'')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (199, 8, 1, 5, N'2075', N'')
GO
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (200, 20, 1, 5, N'2075', N'')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (201, 21, 1, 5, N'2075', N'')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (202, 30, 1, 5, N'2075', N'')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (203, 38, 1, 5, N'2075', N'')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (204, 39, 1, 5, N'2075', N'')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (205, 40, 1, 5, N'2075', N'')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (206, 41, 1, 5, N'2075', N'')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (207, 42, 1, 5, N'2075', N'')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (208, 43, 1, 5, N'2075', N'')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (209, 44, 1, 5, N'2075', N'')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (210, 85, 1, 5, N'2075', N'She is overall good in her study.')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (211, 86, 1, 5, N'2075', N'Congratulation!! Keep it up.')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (212, 131, 1, 5, N'2075', N'He has to work hard in his study for good result.')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (213, 10, 2, 5, N'2075', N'')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (214, 11, 2, 5, N'2075', N'')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (215, 12, 2, 5, N'2075', N'')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (216, 13, 2, 5, N'2075', N'')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (217, 14, 2, 5, N'2075', N'')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (218, 15, 2, 5, N'2075', N'')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (219, 16, 2, 5, N'2075', N'')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (220, 17, 2, 5, N'2075', N'')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (221, 18, 2, 5, N'2075', N'')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (222, 19, 2, 5, N'2075', N'')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (223, 22, 2, 5, N'2075', N'')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (224, 23, 2, 5, N'2075', N'')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (225, 53, 2, 5, N'2075', N'')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (226, 54, 2, 5, N'2075', N'')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (227, 55, 2, 5, N'2075', N'')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (228, 56, 2, 5, N'2075', N'')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (229, 57, 2, 5, N'2075', N'')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (230, 58, 2, 5, N'2075', N'')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (231, 59, 2, 5, N'2075', N'')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (232, 60, 2, 5, N'2075', N'')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (233, 61, 2, 5, N'2075', N'')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (234, 99, 2, 5, N'2075', N'She has to work hard in her study for good result.')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (235, 100, 2, 5, N'2075', N'He is overall good in his study.')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (236, 101, 2, 5, N'2075', N'Congratulation!! Keep it up.')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (237, 102, 2, 5, N'2075', N'She is over all good in her study.')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (238, 24, 3, 5, N'2075', N'')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (239, 25, 3, 5, N'2075', N'')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (240, 26, 3, 5, N'2075', N'')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (241, 27, 3, 5, N'2075', N'')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (242, 28, 3, 5, N'2075', N'')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (243, 29, 3, 5, N'2075', N'')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (244, 67, 3, 5, N'2075', N'')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (245, 68, 3, 5, N'2075', N'')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (246, 69, 3, 5, N'2075', N'')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (247, 70, 3, 5, N'2075', N'')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (248, 71, 3, 5, N'2075', N'')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (249, 72, 3, 5, N'2075', N'')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (250, 73, 3, 5, N'2075', N'')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (251, 74, 3, 5, N'2075', N'')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (252, 75, 3, 5, N'2075', N'')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (253, 76, 3, 5, N'2075', N'')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (254, 77, 3, 5, N'2075', N'')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (255, 78, 3, 5, N'2075', N'')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (256, 79, 3, 5, N'2075', N'')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (257, 113, 3, 5, N'2075', N'He need to improve his handwriting and spelling.')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (258, 114, 3, 5, N'2075', N'Congratulation! Keep it up.')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (259, 115, 3, 5, N'2075', N'She is good in all subjects but she need to improve her handwriting.')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (260, 116, 3, 5, N'2075', N'Very good.')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (261, 117, 3, 5, N'2075', N'Excellent performance.')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (262, 118, 3, 5, N'2075', N'Well done!!')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (263, 119, 3, 5, N'2075', N'Excellent! Great job.')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (264, 120, 3, 5, N'2075', N'Excellent! Keep it up.')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (265, 85, 1, 6, N'2075', N'Excellent! Keep it up!!')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (266, 86, 1, 6, N'2075', N'Congratulation! Keep it up!!')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (267, 131, 1, 6, N'2075', N'He is good in his study. Keep it up!')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (268, 99, 2, 6, N'2075', N'She is good in her study. Keep it up!')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (269, 100, 2, 6, N'2075', N'He is doing well in his study. Keep it up!')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (270, 101, 2, 6, N'2075', N'Congratulation! Keep it up!!')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (271, 102, 2, 6, N'2075', N'Congratulation! Keep it up!!')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (272, 113, 3, 6, N'2075', N'You need to improve your handwriting and spelling.')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (273, 114, 3, 6, N'2075', N'Excellent! Keep it up!!')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (274, 115, 3, 6, N'2075', N'She is good in all except her handwriting.')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (275, 116, 3, 6, N'2075', N'Very good.')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (276, 117, 3, 6, N'2075', N'Excellent! Great job.')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (277, 118, 3, 6, N'2075', N'Well done.')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (278, 119, 3, 6, N'2075', N'Excellent performance.')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (279, 120, 3, 6, N'2075', N'Excellent! Keep it up!!')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (280, 85, 1, 7, N'2075', N'Promoted to Class: Pre- Elementary I')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (281, 86, 1, 7, N'2075', N'Promoted to Class: Pre- Elementary I')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (282, 131, 1, 7, N'2075', N'Promoted to Class: Pre- Elementary I')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (283, 99, 2, 7, N'2075', N'Promoted to Class: Pre- Elementary II')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (284, 100, 2, 7, N'2075', N'Promoted to Class: Pre- Elementary II')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (285, 101, 2, 7, N'2075', N'Promoted to Class: Pre- Elementary II')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (286, 102, 2, 7, N'2075', N'Promoted to Class: Pre- Elementary II')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (287, 113, 3, 7, N'2075', N'Promoted to Class: I')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (288, 114, 3, 7, N'2075', N'Promoted to Class: I')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (289, 115, 3, 7, N'2075', N'Promoted to Class: I')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (290, 116, 3, 7, N'2075', N'Promoted to Class: I')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (291, 117, 3, 7, N'2075', N'Promoted to Class: I')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (292, 118, 3, 7, N'2075', N'Promoted to Class: I')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (293, 119, 3, 7, N'2075', N'Promoted to Class: I')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (294, 120, 3, 7, N'2075', N'Promoted to Class: I')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (295, 132, 1, 8, N'2076', N'Congratulation! Keep it up!!')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (296, 133, 1, 8, N'2076', N'He can do better if he works hard.')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (297, 134, 1, 8, N'2076', N'She is overall good in her study.')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (298, 135, 1, 8, N'2076', N'He can do better if he work hard.')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (299, 146, 2, 8, N'2076', N'Congratulation! Keep it up!!')
GO
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (300, 147, 2, 8, N'2076', N'Excellent! Keep it up!!')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (301, 148, 2, 8, N'2076', N'Excellent! Keep it up!!')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (302, 160, 3, 8, N'2076', N'Excellent Performance.')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (303, 161, 3, 8, N'2076', N'Excellent Performance.')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (304, 162, 3, 8, N'2076', N'Well done! Keep it up!!')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (305, 163, 3, 8, N'2076', N'Excellent! Great job!!')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (306, 132, 1, 9, N'2076', N'She is confident, positive and a great role model for her classmates.')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (307, 133, 1, 9, N'2076', N'He makes smart decisions, admits mistakes and listens to opportunities to improve.')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (308, 134, 1, 9, N'2076', N'She comes always well prepared and generates neat and carefulwork.')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (309, 135, 1, 9, N'2076', N'He shows a positive attitude with classmates in group projects and activities.')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (310, 146, 2, 9, N'2076', N'She is confident, positive and a great role model for her classmates.')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (311, 147, 2, 9, N'2076', N'He has shown excellent ability to set goals and be persistent in achieving them.')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (312, 148, 2, 9, N'2076', N'He performs indepent work with confidence and focus.')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (313, 160, 3, 9, N'2076', N'She is confident, positive and a great role model for her classmates.')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (314, 161, 3, 9, N'2076', N'He has shown excellent ability to set goals and be persistent in achieving them.')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (315, 162, 3, 9, N'2076', N'She can do much more better by continuous efforts.')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (316, 163, 3, 9, N'2076', N'She performs indepent work with confidence and focus.')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (317, 132, 1, 10, N'2076', N'She has shown excellent ability to get goals and be persistent in achieving them.')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (318, 133, 1, 10, N'2076', N'')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (319, 134, 1, 10, N'2076', N'She remains focused on the activity of class.')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (320, 135, 1, 10, N'2076', N'He works well with classmates in group work and often takes a leadership role.')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (321, 146, 2, 10, N'2076', N'She performs independent work with confidence and focus.')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (322, 147, 2, 10, N'2076', N'He is confident, positive and a great role model for his classmate.')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (323, 148, 2, 10, N'2076', N'He has shown excellent ability to set goals and be persistent in achieving.')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (324, 160, 3, 10, N'2076', N'She performs independent work with confidence and focus.')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (325, 161, 3, 10, N'2076', N'He has shown excellent ability to set goals and be persistent in achieving them.')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (326, 162, 3, 10, N'2076', N'She can do much more better by continuous efforts.')
INSERT [dbo].[Remarks] ([RemarksId], [StudentId], [ClassId], [ExaminationId], [ExamHeldYear], [Remarks]) VALUES (327, 163, 3, 10, N'2076', N'She is confident positive and a great role model for her classmates.')
SET IDENTITY_INSERT [dbo].[Remarks] OFF
SET IDENTITY_INSERT [dbo].[School] ON 

INSERT [dbo].[School] ([ID], [SchoolName], [ShortName], [Address], [Phone], [Email], [Website], [Logo], [EstiblishedYear], [Slogan]) VALUES (1, N'NATIONAL PEACE KIDS ZONE', N'NPKZ', N'Gongabu-5, kathmandu, Nepal', N'123456', N'info@npsbs.edu.np', N'npsbs.edu.np', 0xFFD8FFE000104A46494600010101006000600000FFDB004300080606070605080707070909080A0C140D0C0B0B0C1912130F141D1A1F1E1D1A1C1C20242E2720222C231C1C2837292C30313434341F27393D38323C2E333432FFDB0043010909090C0B0C180D0D1832211C213232323232323232323232323232323232323232323232323232323232323232323232323232323232323232323232323232FFC000110800C800C803012200021101031101FFC4001F0000010501010101010100000000000000000102030405060708090A0BFFC400B5100002010303020403050504040000017D01020300041105122131410613516107227114328191A1082342B1C11552D1F02433627282090A161718191A25262728292A3435363738393A434445464748494A535455565758595A636465666768696A737475767778797A838485868788898A92939495969798999AA2A3A4A5A6A7A8A9AAB2B3B4B5B6B7B8B9BAC2C3C4C5C6C7C8C9CAD2D3D4D5D6D7D8D9DAE1E2E3E4E5E6E7E8E9EAF1F2F3F4F5F6F7F8F9FAFFC4001F0100030101010101010101010000000000000102030405060708090A0BFFC400B51100020102040403040705040400010277000102031104052131061241510761711322328108144291A1B1C109233352F0156272D10A162434E125F11718191A262728292A35363738393A434445464748494A535455565758595A636465666768696A737475767778797A82838485868788898A92939495969798999AA2A3A4A5A6A7A8A9AAB2B3B4B5B6B7B8B9BAC2C3C4C5C6C7C8C9CAD2D3D4D5D6D7D8D9DAE2E3E4E5E6E7E8E9EAF2F3F4F5F6F7F8F9FAFFDA000C03010002110311003F00F9FE8A28A0028A28A0028A28A0028A28A0028A28A0028ADDB7F0DBDC787DB535B906408F22C013AAA9C312C48C1C063800F41DCE06978F6D8A5E5A4EB756F34215EDA25864DC15632082B8F97610E36ED3D8F418CF43C34D5373969B3F54CC1578B9A82D77FBD1809A1EA7269BFDA0B652FD94A975908C6E50482CA3A90082091C0DADE8719F5E9DA2E8DA85C7826348933348BF65890BA804CE2464E49C2E41EE4633CE39AC1F00D9CF25C5F5CC522EC2A966F00277CA2524E36E30CBFBB2083FDE5E0F6DE5835CD4E117AC97DC651C53E59C9AF859C7D14515C0760514514005145140051451400514514005145140051451400514514005145140051451400568CBA0EAD069E2FE5D3AE52D76873234640553B36B1F456F3130C786CF04D3BC3F671DFEBD6904C2168B71924498B859150162995F9B2C14A8C6392391D477924BA55E493692646691630278E354D810818D8C09195C8041036B01C1C1C76E1708ABA6DCADD179BDCE4C4627D93492BF57E48A9E1378EFBC3A90ADB65ADC3A364EF127CC5D895C74DAD8C73F749EF814FC75A7416D65626C673259DBAC712F99F7F2F1A9C1E003B4A3293C74040E6A2D1CFD9B40D574E9E068EEB4F9A499E4591586F0A36AE318F95A227392083EDCECDCE9F1789AC6DA38A598C4D3C0625890333079563DA4838523CC3EBC8C7D3D256AB83E5EAA3F93FD2DF89C3AD3C5732D9BFCD7EB73A4D3EE6C6C3C05268D3CBBF524BA8586C53B19634DB90481FED75C5707E1FB2D4749D3358B9E609A169238E48A61BE39A152CD82A7231B9486E87B1E0E352EB50BC4F17C1A1ED68D5222D7113C29B8BED670437DEC6DD9DC77E3D5F3E95A85A41AC69CB71025D4D234E8589C159E18E4D8491C3146DBCF018F503E6AB9284E49D3BBE5E65EBEEAD888B9C6369FDAE57F89E695B11F87AE65F0FF00F6A47BDDB71610AA83FBA190D26739E082318E809E82B2EE2092D6E65B79401244E51C060C01070791C1FA8AF6FD1BC230A781354BE26361A698E14D9B9A298F494E1C64862D9C103AE303A579384C3C6AB929E9D3E6DD91E9626BCA9A4E1AFF00925A9E19455CD56082DB58BEB7B5F33ECF15C489179AC0BEC0C40DC40009C75C0154EB91A69D99D29DD5D051451486145145001451450014514500145145001451450014514500145145006C7859957C476A5991462419760A33B1B039EE7A01DCF15B1636CF17C419A08A72448B24AFFC20831194A91DF047E2403C55DF16DB9B53A7EA56904520B3657594248A2485B6B42769C6D8FB8E14FEF00F4C742D6568F7D0CA608E4B858B16D7B2C8F12081F0C2421CA80BB4B10580C09189E8A57DBA18771FDDA7AC64A57F27BB3C9AD5D3F7EDA4938DBCFB1CDDCEA969E14F13EA301B21730CEB6D7656E1039690C41CA1E8BE5B191B20827017AF39E31AF2E9ED16D1AE666B646DCB0990EC53CF217A6793F99A9F59BD1A86B37774934F2C4F2110B5C7DFF2870808C9C61428C0240C60702A8D79556AB9BB2DB5B7CD9E8D3A4A2AFD74FC02B5749F10DF68F1490C3E54B6F236F68664DC376D201046194F39E08076AE72001595456709CA0F9A2ECCB946325692BA3774C16BAB78C448CA60B796792E162751370373AA37DD0C0E029381D49C76AF4E875FB98FC2B73A69BA8D345FB566E6E191B11BA852C99C738DC9903272401C9C5795787F5D9B41BF69913CDB79D043750E429962DEAE54360ED39452081C10382320D390DC6ADAABB436E5EE6EE725208109CBBB70AA392793803935DB87C62A34DE979377D7F0FC4E4AD857566B5B24ADFE7F8170D8DEEB9FDA5ABAC7122891E675195524E5982678F94738273C8EA4D64D7A6593C3E1EFECDB386758EE03FC92A36D26400B3386DA33F3615738382BD715C1EB7A63E91AC4F64CAC02ED740DD763A874CF039DAC3B52C5617D94232BEBD7C9EFF932B0F88F6B2946DA74F4DBF333E8A28AE13AC28A28A0028A28A0028A28A0028A28A0028A28A009FEC577F6037FF659BEC625F24DC7967CBF3319D9BBA6EC738EB8A82BD5FE175DD9DD786F50D1A65491BED1E74904C1592542131F293F361A3C9E30095F5A7FC45F0D698DA136AD6B6D0594F66150A5B42B1A4AACE0721401B816CEEEB8E0E78C762C14E547DB45DD1E44B38A50C5FD52A45A77493E8EFB1E4B5D0F87349B4BCB5BFBBD4125FB3C51955658CB1538259D7E650CCA003B49C1DC338AE9FC75E02B6D37494D4F4480A5BD9C6AB7A1E625882CAAB260F72CC0305C0E46140C9A83C3B6510F0E4704A2E02DC2BC93A2C9B1F6B1DB94E3214AECEB91F37390715A61B07275DD39AD97FC37E2CD658FA7570EAB527A376FB9EBF82297856E61D47499F4ABA1B8440F000C9898F38F9700AB1C8249396181F2D7377D36A36465D266BD9DA08498FCA12379646EDD90A71F293F30E3BE6A76B7BEF0BEB56EF73090C0798847DD9A239525491D0FCC338C8208E082051D42F1F50BF9AE9C60C8DC2FF740E00E8338000CD6556AA9518C25F1C74F97FC03A69D36AAB947E196BF33A1D13C3169A8F85EE75396698DCF9CF04312908AAC047B0B120E7734AA31F2818E4F3C4FA57834ADDE9F35F8F321CBB5DC2582AA6D04A2EE56CB07C7F0E08E791D46F7C3D825D4FC2B716704B70BF66BB79A5782D4CDE42BAC7862A595486113AFDEC80A4FA5767A25CF996D3D925B3EA9752F9EA8448269531198F691924042C991FC20AF404575E1F0F4254E3296FEBE67356AF5633718FE5E4793C7E11963F113DBDE413C7A60BB9ED44C655421D378556620857250E148CB60802BA7B6F865A75DA5A1826BF7FB5CAD1C39745DECAA1990F1F2E030F9F9DDB0FCA377CAFB8D13C456FAFE8965A91BCD423BE96E6ED217B7317992AAB3F9B956CC8CA5CB0249C648E8483DB59EAA9A35D69364B04CFE5DF5D4B0C6E80CB2A63054019F993CB60FD8152339C0A7470F4ACF992BDFBF97AF7DBD4552B54BAB3D2DDBCFFC8F1BD7F40D3F45D22065B8B892FE490637A15474C1DC40DB8041D831BC9E738E4557F095B5BDC6B05A76F9E18FCD8577EDDD2065C7B9C025B03FBBE80D751E3E9ADFFE115D1D201CBCD26F9A36DF1DC3293CAB0CA9DA1C03FEF5707A75DFD8351B7BADAECB14819911F6175EEB9E719191D0F5AE6ACA952C4A71D62AC6F4FDA55C3B4DEAEE76BE23B983FB3EFE0CFD9EEAC9E17852526194921089146EF981DCFB48FE0DAC40CD705248F2C8D248ECEEE4B3331C924F524D753AE69F26BDE21B74D1516F649ADD19DE17C81F36C0D212711803603BB681C6715149E0E96DB46B9BBB9BB41791A6F4B5840906013BF7C9B828C28DC36EFCF43834F13ED6BD5934B9ADD57E6187F67469A4F4BF4673345755A5F82E4D4FC1F79AE8BB30BDBF98CB04901DB2A2282583E7FDF1F77195C67938E87C37F0DAC2FB4382FB54B9BC135CC6248E280A208C127192436ECAEC3FC38C90735853C2D6A8D28ADF522BE6785A11729CF676F9F63CD28AEF7E23E9DA3E8D67A1E9BA7451C7710C72B4C447FBC753B76BBBE3E625849DF8C63006057055954A6E9CDC1EE8E8C3578E2292AB1D9851451506E145145001451450014514500771F0C75C6D3F5F934C91C0B5D4542905D540950318CF2324F2EA141192E3AE00AF55BD824B8862489955D2E609B2C4E311CAAE7A77C29C7BD7CF16975358DEC1776CFE5CF048B2C6F8076B29C8383C7515EE7E12F10C9E26D0CDF4D6D15BCD1CCD0BAC44EC6C004100E48E180C127A67BE07B396558CA2E84BA9F25C45859C271C6C3A593F5BE8735F162F2E21B4D36DE1B896386E3CD1346AE42CA14C65770E8707919AE00F882F19B4D66588B580C46402BBD781B5B04646001C632339C939AF47F1FE989AC6ADE1EB192E96D6393ED05E6642DB555558E00EAD80401900923240E4723A9782638AE1574BD545D41B32CF7301818364F0154B82318E73DCF1C739E268D796226E927D36F447764F528C70149546BAFE6D16F5D3A66A7E143A8192249D361B7608CEE5C9C3DB96180300B3E587FCB3F971BF9E1AB5B56B5D4748821D32E2F4C96B27FA52C11CAC630C729BB69C0DD85C671D31CD64D7162AA4A751B9AB3EBEA7B18784614ED1775D3D028A2B7BC3DA4DADDCF0BDFBA24333F94A64DC1141E0C8C4725573D07520E7A60E54E9CAA4B9626B2928ABB3068AF4FF00127C34B55B13A8F87AFADEF74F854C46E6DF71569B76712EE6FDDFCAC406195E1338CB357985138383D423252D828A28A828EDFC31AC5B9D2ADF4BDEC92891F3120FBE3058C87803A00BC927E51DBA76BF1262D1742B396C74B50EB15A0F36592501E692500003D76AB06DA07AFA66BCABC311C92F88AD163B916E4166672CC32A14965E013F3282B8E87760E064D6AF8D6FD6492DEC55A532C7996725CED2580D83691D42E4E72787C71839F62962A4B08DB76B68BCEEBF4D4F2EA61E2F1292EBABF2B3FD743D03E1FDFB6BBE11106A91C73C10B9B264194F32108BF292B8E769DB9183803BE49E9A0F3BECD08B8B5B7B59F60F32DED401144D8E513048DA0F03048C01CD719F0B0FFC52B723FE9F5BFF00404AE835CF1669DE14FB34DA85BDC5C1983B43144A36BB26D3B5C923683B80C8048E7835D94271A7878D69F447C8636954AF8E9E1692DE57FC353CA3E205FD9EA1E2EBA6B4B5685A0FF479DD9F3E7488482F8FE118DAA00ECB9EA48AE5E9F34D2DC4D24D348F24B2317777625998F24927A934CAF9D9CB9A4E5DF53EFA8D354A9469AE892FB828A28A9350A28A2800A2BAC5F075BB786EDB50FED0B8177751F990C46CC790C3760FEF7CCCE46083F27DE18F7AAA9E10B8642C751B1420642B19727DB84C56FF0056AD6BA8983C4D24ECE473B45753A8781EEACEC56E2DF55D335090919B6B4793CD0304E70E8A0F4C6012724601AE6A7826B5B896DEE229219E2729247229564607041079041ED594A1287C4AC6B19C65F0BB9634CD2750D66EC5AE9D692DCCDC12235E10160BB98F455CB01B8E00C8E6BDDFC2DA4DC699E1CD3B4C7DD25C45192CA0676B33172BC139C162323AE335E51F0E350FB0F8C208CB46B1DDC6F6EECE71D46E0073D4B2A8FC6BB4F8A6A7FE113B7E3A5F267FEF893FC2BD4C0A8D2A52C46ED687CCE7529E27154B02F48CB5BFDE6578D7C430A78E2C6C9C2AC5A6978E793272AF2001F38CF0A31918072187A575BAE9D22DFC00F71169C96DAFD9CC61B8462C09D88C72573DF6E0FBE6BC1EBBBF0C5E8D43449ECA475F3A389EDC96E4F96EA54301BB276E48EC07C83BD5613152AB52516ECDEABD6DB7F5D8F42A60A186A31505751567E97DFEFF00CCE4B54D56E757B949AE760F2E311A2A2E02AE49C7AF524F27BD51AD2B1D0EF350D59B4F8BCBDD13ED9A756F3218577052ECE9B814C91F30CE72319C8CB353D1EF34997CBBA8C0E71B94E4671D3D8FD6BCA6A52BCD9EAC54609416841636A6F6FA1B60C57CC60BB80CE3F0AED67D92EBBE4EA2ED6B0472081FCA266F2234F902AE492C14000649E075ACEB5B0974CB46B592D9E2BECB1BA0CA448832311B0CF0176EE3C020B107EE8C3D22924491E346658D77390385190327F1207E35EB60E8724399EECE1C4D5E6972AD91D72DF5C784E2BC93C2DADAEA3A55D45E55DEFB728159B72A8646EF804835E6BAC59ADBC914F163CB981C8C8F95C633DC9EE0E781C903A57A06AFA4F876C7C27A7DCD8EBCF75ABDC6C6B9B451F2202B939F42A481CFBD26A1E0FBF6F0BC3A858C125E6957B64B2DCCD1C4B21B5915BE6EBCA90475183B4B0CE09A55E9C6A53F3F3D2E3A53719F91E5B455F4D26E1B54B7B176488CECA16660C536938DFF002824A8E49C02460F1918AE82DACEC74892D6D5C69F7335E3496B34B2C91B794485041563FBA00B01E61DA461C83C607971A6DEFA7A9DAE696DA983A1DE5BE9FAC4175742530A6EDC2200B72A40C6481D48EF5D05B68B2EBF3CBABEB971345F6952618E3F9980DB88CFCC788D7E4017A955C0DA30D5CE6AF642C3519228D5C40C77C3BCE4943D327032474240C641C5761E25D79B4A0B6F69044B3DC216DC6201614DC36F9601C67E57520A900631CF4ECC3461C92F6FF0C5EDE6F4FD0E5C439F34551F8A5D7C97FC39D4780A18B4B8751D13CE324B1CFF006A8DCAEC1344EAAA194139E0A90DD40381934DF893A3CDA978763B9B6B579E7B290C8E5324A43B4EF38EE32149E38009E066B92D775B9F4F3A4EABA4F99637722B317594B6E8F31BA46E0FCACA1B2482B86CF20E001E8FE11D4EF755F0D58EA579307BB98C85E45454CE2460385000E07615E84396A2960FB2D1F96EBF33E631B4A784AD0CCD3BDDEABCECD3FC99E03456EF8CE4B493C5DA88B2B64B78229042228E258D414508C42AF1C95273DF393C935855E0CA3CB271EC7D8D39F3C14ED6BAB8515D369FE09BEBB8E56BABED3F4D6450CB1DE48FBE4C83C011AB15230321B6F51EF88DFC1F708A08D4AC1CE3EEA99723F34C5691C3D596D164BAF4A3BC91CED15D95AF81EDAEB4E46FED9105EEF5597ED1004B484170A19E72F903047F075E3DE8A89D39537692B150A91A8AF17739FD1F599F4899CA012DBCC02CD0374703A11E8C39C30E992390483D923A4B0C734677472A074391D0FAE09E47423B104579DD757E0F9C5C4775A6104CD8373060673B47EF1701493F28DD92C0011B752D5DB80C43A73E496CCE3C761D54873ADD1B55CA789EDFCBD4C5C01F2DC2062426D01870467B9E0313FED7E27ABA5C8688C522472C458318E440EB91D0E0F7E4F3EE7D6BD4C550F6F0E5EA79785AFEC67CDD0E2F46D3B51BDBAF3F4F7F25AD5924373E6F97E49DC02907AEE0790172D85240E0D765E299F59D57C1D6F1497CB7C9A781717F23C012424908AE5CB93261A52BC052721886392B62DA19EF66B7B2B741927CB862501557273C01C019C93F89AADE359ECEC7421A7E9734B3192655BBBB0C5567032422AF740C01E7A95078C0AE09E1151A32BB6DFE0774713EDEB45F2AB27A5F7F91C4E9FA4DEEAA6416712BF978DDBA454C6738FBC47A1AD84F0D788B4385B5948ED505B02495BBB795C03F293E5EE248C1FEE9C75ED9ACDD1F56BAD35A48AD6DE399EE0A8019589C8CE00008EB9AF40D5EFED2DB4C6BC82D8D9BA46731DD4C974A6439DABFEAD55BDC1523AF50335186C351AB4DCF99A94757DBCB536C457AB4EA28D934F4F3F3395F0FAD9A68574E5AEEDF53925516D710A8C04C8DC7AE78C1C018C920E7E5C558B4FB6D879B62E21BED2215263BC9ED0BC50175E84B290A72FB79E15C920F5639DA4EBA12D24B5BE9711C51936CEABF383900A64725482783DD40C805835F9F5ED3F4DB9923B681AE6391D431F397884FDE5CED237B0E3BA80482AC71B738BA5ECD493D57E3F2366A7CED5B466A46DA9E9167AB21892279905ADC898625405B2400791929826BD474EF879A5789EEEECE9F7CD6167736D6F7135B4480901E30D1953E9BC3923D85796DF9BA856CD2CE38EF842E24B236F8F2AE20DC588540BF7B730ECA412CAC09C01E85A66B4D1F86A3D5348BD8125B6636E65858F945A36796DC36707CB747923C300410A0E08AE9A951CBE1767F818C2296FB1C56B9E0AD5742935732AA4B0E993C70CD221EBE60CA363D08C7E26B73528F55F04F84F429F4BD51E4B5D4A417E248C90A2408018CAF75E79CF5C1CF4A8AEBE211D5B58BDBABEB768AD75182082F608F9122A82AC467A11BB72FBA81585AD78B98F8274FD12E8472436524AD62C9B7CC90E47FAC1BB2898724100EE2B8E3048B9CE4A29D5D96FF0077F99318C5B6A1B915E6AB126A0F75A72FD82DAF2411450C9266389DCAB365707744AE88C46D6E15477AC8B7B6B6D35B115AC7292065AEE25909E3B023006727D79E49C562C9ADCF2EB0BA8C9040DB32B1DBE18451A6080A0039C0CFAE49E492492522D72F62B6312B8690B3113BE5DD43672012481C92D9033939CD722C4D272E6946FDBFAF3377467CB64CD6D52CCDD59E5C2452C31B4B18D80663C74C0E76F1C1E80E477C893C710C7E7D8DE45319229A36588F96543460EE5619E79DFD0818C7BF18979AF6AFA85C3CF75A95D4B23C3F673994E0459CF96074099E8A381E95D0DB7826EF52B1B3925F126951C7F67530C73BDC1312B65F600222072CC481C6493CE734BDACAB29469C37B6DE42708D39465396D7DFCCC8D7F5DB7D5D2D60B4D356CADED8BF96BE734AD86C00A58E3850A00E3392C493900779E0CF12C107846C6D143DBCD6D3BABCDB3CE0C048B27DCCA70CAEEA46E046D041F9BE5E135EF0BDCE84AB29BCB3BDB72554CF6ACFB439DD8521D55B3852738C74E73C574BE07934D9B429AC7515F237DCB3457A8B93136D51871FC49C76E47515587753EB0FDA5D36B5E8CC3194A8D4A0AC9349DD76BFF5FF0004E3F57D1EE3479E349648A68E540E93424946E0647201041E0823DC64104DAF0BDB4AFAA7DAD547976A37333292031042E0E301B3961D3EE923A576D20BCD22F2E2D8BEC90068650A72B2230C107B32B03DF820D55DF885608D238A1562C2389022EE38C9C0EE7039F615D10CB946A2927EE98CF306E9B8B5EF0DA50625CBCF32430AF2F23E70A3D78E4FD0727A0E692B03C4DA849115D3A291D03206B80091BB386553C723A3752391DC576E26B2A34DCBAF438F0D45D6A8A3D0C8D53559F549D59FE4863C88A2078407AFD49EE7E9D8000AA1457CDCA4E4F99EE7D1C62A2ACB60A9AD2EA5B2BC82EE02A2682459232C818065391952082323A10454345219E8ED35BDCAA5D5A7FC7BCEA2445DC58A67AA12557254E549C004A9238C536B1BC30920D2E590C8863698858C7DE5200C93C74395C73D8F4EFB35F4D87A8EA528C99F358982A7565144D6ECCB2332B15608DC838EC6B03C4DFF0020B8FF00EBB0FF00D04D74DA63AC33CF348AEE90DACF2B221505C2C4EC572CAC0640C671919C8C1C118F7BA649E21D13ED1A7491B46AE1D7CD6D9BC8C02993C0701B71048E01209C8CE58A9A70953EB635C2C1A9C6A74B89E0DD22D4694BAB4B3A8925BA92D866324C2A888C5873CEEF331D3236F5E4D43E26D1AF6EEE6E6E52FEDE4B1B70ED0210E8C2319392B8C6F200CF279E33802A0B2D3BC59A7DA35ADB3C696E5FCCF28DD40CA18800900B1C1200C91D7033D056B19FC48FA3369F2E8BA3CAEF1BC6F76D72A2560D9E7898264678C2F619CF39E584E9BC32A338CAEAFB2D1BF33B67197B7756128DB4DDEA79ED15B9FF00088EB5FF003EF07FE05C3FFC551FF088EB5FF3EF07FE05C3FF00C55799EC6A7F2BFB8EFF006D4FF997DE63C17135ACCB35BCD2432AFDD78D8AB0EDC115D27879DED346BE3772FD9EC6ECA2A48D23282E1FAEC00EF5EB9C0CE54107E56069FF00C223AD7FCFBC1FF8170FFF00155D2788F49B8BAB64B4D3B4F84AB3A4ED2BDFC6C615D98581795C84DC43311C951B40032DB52A7383E7B3BADB4339D4A72F76EB5F330E7F10DB59F92DA546649F68679AF205FDDB86CE113732918182581CEE230319393A9EA926AAF6F24B0411BC517965A152BE61DCCDB986719F9B1C60600E2AF7FC223AD7FCFBC1FF008170FF00F1547FC223AD7FCFBC1FF8170FFF0015533F6F51FBC98E32A31D9A30E8ADCFF84475AFF9F783FF0002E1FF00E2A8FF0084475AFF009F783FF02E1FFE2AB3F6353F95FDC5FB6A7FCCBEF30EBD63468A39BC3F0AFD9B7CC964B3998CE542229850809B4EF24CCBDD70013CF02B83FF0084475AFF009F783FF02E1FFE2ABA8866F105A58C36F6BA4D9E52D8DB3B4D7D1BEE04C4D9003AE0E611D73C31FAD7760A53A0DB69ADBA3EFAFE071E2D42B24934F7EABB69F899DE20BF8F52F08C77514060492ED31197DE461641D7033F9545E19FF9043FFD776FFD056AC5DE897AFE14D3F4E82063749234973BEE2058D705B6EC22425B21B9C85C63BF5A9B45D2A6D2F4D2353920B488CC59A679959146D1DD49CB615B0A32C71C035BC26E5885527FCAAEDE9ADB530A914B0EE9C3BE8976B9A57971F6936E7690D1C091B13FC5B7807F2C7E555AA49665B8582658FCB592089826738CA29EB51D7A5069C53479B34D49A63259E3B5B792E6504C712EE201C6EF419C1C64E0671DEB819E692E2E249E520C923976200009272781C0AEC75F5BA3A0CE6DFCC31ABA1B9F2D58FEEF3C1620E02EFD9D47DE2BD0F5E2ABC5CCAA375793A23D9CBA9A54F9FAB0A28A2BCE3D00A28ADFF0C69CB3DCB5EDD5B096D22565512292924B8C01D47DDCEEEE38008C355D383A92518F522A4D422E52E87490C37165616BA7DCCBBDAD10C60060426599D94104820333720E0F5EF4EA09C9CD15F4F08A84545743E6673739393EA5BB1FF57A8FFD836F7FF49E4AF2FAF50B1FF57A8FFD836F7FF49E4AF2FAF1B33FE2AF43D9CB7F84FD7FC828AEE27F03D84375135BEA9717B6C9328B956B716EE23E4B153B9C678C0E0F2413C551D17C271DCF8CECB48BF92536773E6159A0215982A330C64100E40C83FD41AF1E589A4A2E57D937F71EFD4CAF19492954A6D2BA5F37B1CAD15DE6A9F0DEE2CFC532D9ABCB1692E924D6F74FB1DCA285C02BB949F9E44524019C9603008A66A5E010F6F11D0CDCCF74B12892DE52ACD33807718F0075E311F24F20313807B30D46A62A83C4515CD05D7FAD4E6787AAAF75B1C3515ADE1FD186B17C565768ED6201E5651C9E785538C063CF5EC09E71837BC63E1FB7D02F2CD6D23B95B79EDC3E6E2547666EB91B40C0DA53AF7CF3D8676EA5FD4EB7B0FAC72FB97B5CE6E8ABDA4698FAC6A9158473C303CA1889272C106D52D83B413CE3038EA47D6BB2D37C01601ED5B52D4679776E17105AA04C750BB646CE7F849CA0EE3DEB6A586AB5B5A71B9E756C551A2ED52563CFE8AE8F4AF0C89AEAE7FB42422DEDE5780F90E373C8A3B6470A09072473D077222D73C38DA6C2B7968D2CD624ED77755062725B09C1CB7CA01DD8032718F5E47560A7ECDBD4F57FB3F13F5658A507C8FAFEBE9E660D15D96A3E0F78ED341B68EDFECD777314CD3CF721D32EA376C65F9B695C320E0648C9C76A1A87842EED6F238E09967B77058CFB1944480AA97900CED19751D4E7207520528D684A4A29EACF3215E9CE4A09EAF6473945742FE1E83EC177341712CCD04092B3B208D10F1B97A92DF31DAA78CF04819C0E7ABA270943491D33A72A6ED247A245FF001E565FF5E90FFE8B5A5A48BFE3CACBFEBD21FF00D16B4B5F4D4BF871F447CA55FE24BD48AEA137561736A0BFEFA3202AB05DCC395049E31B82E7FA75AF3FAF45AE6FC51A708E65D4E3752B74E449180C4A48002492723E7C9239EA18600033E766545B4AA2F99E8E5B5926E9BF91CF514515E39EB9B5E1DD157589E632099A285794807CEC4E71D8E07049383D31DF23B896DEFE548621613C70C1188A18A38182C683B018F52493D4924924926B8CF0BF8A6E7C2B71717365E6A5C4CA13CD865F2D82752B9C1E09DA7FE022BAD8FE2FDE93FE93FDB327AECD5B67FED235E8E16BD2A31BF5F9FF0091E7E26854AB2B6B6F97F98D96D6E614DF35B4D1AFF79E3207EB51568D9FC609FED8519EFA2B36503C9BE996F63762C010FF002290BB771CA82781C73C49E21B6B6835312D944D0DA5D44B3C513758F3C327FC05830FC2BD2A1898D576479B5F0CE92BB20D31438D481CFF00C82AF8F1ED6B29AF36D36086E755B3B7B82E219674490A1C3052C01C7079C7B57A5E93D752FF00B04DFF00FE92CB5C07868427C416DE7C4B2A80E42B315C30462A723B86C1F438E78AF2F36972CEFD97F99EC6494FDAB8D3EF24BEFB1E9715C409E1EBA84468D777372803632CA8A09207D495FCAB7B48FB2D8F8A22D2A358FED5069B2F9ECA087DC6488B64E30C323681938F2CF03393CB4225B27B3BFDA0AF99B933DCA115D178734C86D7C71E28B9640F2B790D6F36E3911481C9047439D8873EDEE6BE2710D2C3546FA2FCCFD63396E118C61AA94B5F97F95ADF313C576B3FFC274B78ABFE8F168B043236E190CEEECA31D4F11B723818E7A8CCB2D8CBA45ED8CD2490CAACC927EEDB214820946F423238F7A4F1613FF0985CAFA69B6A07E72D6AF89E5B5924D2AC6D0C4F2A02D33C472199D86D04F72140AFD2B86DB8E5B422B69735FE47C63BA97ADCE2EEF4C8F4CD6354456DD24F7D34CF9400AE58E173FC431CF6C6E23DCE1FC4CD4AC9AE2DB448A266B9D34089A73E98248F5392DEC0003A93C74BA95D26A1ACEBCCAEC5ACEFFCA20AA8011D72B839CB1DC92E7238F979E70394F89D109354D3B5407FE3F6D14B8C7F1A9C31FC4D789884D5492F37F99EBE3A69E4D4FD8FC2B47EB7B3FC6FF2FBCA1F0FCC675F96161079D3C1E541E6EDCF98644C052DD188C8E39C123A135E9164C2C05EDFDC2B46B676924AC2442ACA48DA015232082DD08CF15E57E0EBCBAB5D7962B58D1DAE90C32163828990CCCB938DC02E46723D8F4AF47D752EE4F016BB3C0F086631995E59D1495CF200639627776E7A639C57A780AAE1859BE88FCBF30A4A58B85FA99FA0E897DA8BC3A70CC770919927376DE5F96C4EE7DD9031F3B118F7028BCB292EFC27ADE9ED148D346D1BA46832DBC123007B92062BA8F041B16F12DD2EA72C620C195CCCDC38460C41F5E80E3DAB36D257BAFED9BC8548DF324800EA06F2FF00A053F957C4737BDED7AB6CFDAF152F6584AB876BDC8423E4BFAFC874B01D4744FB46199B4DBB3313BBA2CAA539CF51BBF9D60F8A9C43369E8AB812E9A49DBC649910927FEF9AD04B89228A7851B11CC0071EA01C8FD4556F17DB466DB4DBA3395956D122487670EA7259B7678C155E31CEEED8E75CA9F3E2A1FD773F15C91F3E369F97FC133F5D874DD0BC253DB47792CFA9DF47119418B64512FCAE51493976F9D09C702BCE2BB9F1A695AB3E8B63AE6AD720C8045690C325C21758B6332623072AB819E719DC0F7CD70D5EF6224DCECCFA5C549BA9A9E8917FC79597FD7A43FF00A2D696922FF8F3B2FF00AF487FF45AD696876F6D3EA61EF959ACADE36B8B855382C8A33B73DB270BF8D7D0D376A49F91F235173556BCCA715ADC4EBBA1B79A45F548CB0FD2A4FB05E18E48A4D3E778A45DB246F0B6187BF1F8E7A82011C8A9EEFE304DF6A448BEDDF610847D9AC665B38E3392004F95CB2EDDBCB00724F1C735A4F8BF7A3FE3D86B31FF00BFAB6FFF00DA42B8A58F83D1DBF1FF0023B23819AD55FF000FF3398F12F86E5B159755B6B46B7D3DA658CC4E4E60770CCA8371DCCA42360F278C139C162A0F14F8A2EBC557705D5E999E6890C6249A5F318A67217381C0249FC4D15E455E4E77C9B1EB52E6E45CFB98345145666815EB1E0AD4B4AD7FC371E8FA95BDE34FA782D1CD6281A48D090082A4FCC84EDE7B331F519F27A2B5A355D295D1955A4AA46CCF65D62FF4D8344D6B46D32CD21296D27DA9EE18497459770DAD8E23C321CA75E99E2BCE7C23B3FB4AE0BA2B30B73B091F74EE5E47E191F89AB1E16FF904EBFF00F5E6DFFA0BD56F086A767A4F8821B9BD546848D87CC52D18C900970BC950327804F420640A31CDD5A49F569FE67564B3861B1B194B68B5E5D0F48BF6DFE1DD16D92326453348481D77BE00FF00C70D765A7D89B53348CAA5D2286CE5947F14912E597E8BE62AFD41AE253C4BA432690239EDD6578D56D6717483CA9212416995B1E587662C3207DC000C36466F80FE285AE8979A8C5AB59235BEA13F9AF388C3BF3B542C87825557241032096E0EFE3E6F1382A95684A3E4BF07FF0003D4FB5CC337A1C91841A7ABEBDFDEDD5FBA5DB7EC76DE2E795BC413249008D634448DB786F35719DD81F77925707FBB9EF54747441A82DC49810DA29B9909F44E47E6DB47E358BAFF008E74F1E27D7EC4DD816575731CF15CDBEC9D10F9281B6B61B07E40B900E73CE3683591E26F19E9B2E817965A45C48CB7B70CC212BCC0981C33141B970595472C32C49E06EFD032BC7D2A396420F751EFAFDCF5BFCADF91F373C4452669A5EBDD58C044D3343266E55256CED693E76C7E27F202B07E26B2C33E8FA713FBEB6B4DD22E3952E7760FF9ED5B761ACE95A6FF00635C99F4B8E182C6DFCF86594CF997681BF08D91C904A609186046381E79E22D59F5CD7EF35079249165958A34830DB73C6464804F5201C649AF0AA49C9DDF53D8CDF30A4F014F0F05BA5DBEFD1BFC77B9B9E05B12D3DD6A0E9F222F951964E371E4956EC40001C767FCFBAF34DAE8FAC5F2604B6B66D242C403B64C8DA7078F5AC9F0C6B9E1ED17C2FA09BF92C1E67926799006CE03300B32A6E6CFCCAC1F03202A8C856DD1F8B3E23699AB787F52D1EC6DD2D8B381149696815260AFD4BB3070A572402B9E9903B7AF43134E8E19413D5FF5FD6C7E675F0952BE2DCE4B45A6DD3E7FF0461B986F71776F1F970CE3CC48FCCF33603CED2D81923A1381C8E82B67F7BA7E8D6282172F7D33CB2100FC910465527D8B161F88AC9F04F883414F0B791ADD95ACAFA7B318FF00D2841232925F0463320C96FBB961803BA8AAF75F10ACA6F15CFA8C892B4315A3416E91C113C4EE5D3F85D72B1045000C96CA83C6E65AF8DFAA3E695BCCFD3F38CEA388CA1D25ACA51B3D53D5AB3D37FBEDADADDD7437B6F6D158E9EF0B969DE22D70B8E14EE3B79FF771C7B553F1A868F4DD16375DADE4E4823047CAB8AE7C7C4241E2482FBECDBAC5233981A150124CE43AA8214FDD5186C8C6EE39CD6843E3BD375CBDBED4FC43A58BA30AC6618E5BEDBB99B872D800B8CEDC2A01B54739E5ABA72EC34A96223525D3FC9A3F3CCAB072A38A85696897F935F7F532A5B996CFC2B7D7D1BE2E64956D1252A1996368DD64504F4CAB63E95C3D761E31F17C3AEDA43A7DA5ADADB5B5B4EE552CE0F2E361C00D9277393FED004607AF1C7D7A95E6A73BA3DAC4D4552A5D1ED1A3DE69D2689A468FA8D94770B25AC4D6C629047741D820223278932CEBF2727A91C0388FC4D7BA4F877C337F6BA61BA86EE754DD25EB88AE1FE63B56245C90A194B331C0F902E41233C378B7FE413E1EFF00AF25FF00D023AE52BA6AE2650F71797E47934B0F195A6FCFF30A28A2B80EE0A28A2800A28A2800A28A2803A6F045D14D69AC993CC82EA361226C0C30AA4927D82EE27B7AFB626A7A74FA56A1359DC29578DB0091F787623D8D564768DD5D18AB29CAB03820FAD7A25B78C343D474E8A1D62D6190AED2F14EB2050C3701B593716500F1B8646EC027935D34F92A43924ECD6C73CF9A9CF9E2AE9EE79CD15E93FDAFE04FFA04E9FF00F7D5C7FF001147F6BF813FE813A7FF00DF571FFC4557D5A3FCEBF0FF00327EB12FE47FD7C8F36A2BD27FB5FC09FF00409D3FFEFAB8FF00E228FED7F027FD0274FF00FBEAE3FF0088A3EAD1FE75F87F987D625FC8FF00AF91E6D457A4FF006BF813FE813A7FFDF571FF00C451FDAFE04FFA04E9FF00F7D5C7FF001147D5A3FCEBF0FF0030FAC4BF91FF005F23CDA8AF49FED7F027FD0274FF00FBEAE3FF0088A3FB5FC09FF409D3FF00EFAB8FFE228FAB47F9D7E1FE61F5897F23FEBE479B515E93FDAFE04FFA04E9FF00F7D5C7FF001147F6BF813FE813A7FF00DF571FFC451F568FF3AFC3FCC3EB12FE47FD7C8F36A2BD27FB5FC09FF409D3FF00EFAB8FFE228FED7F027FD0274FFF00BEAE3FF88A3EAD1FE75F87F987D625FC8FFAF91E6D56F4CD3AE355D422B4B746679180240CED19E49AEFBFB5FC09FF00409D3FFEFAB8FF00E229979E33D1F4ED35ADB45B5850316658E1F30A8660A1892F8DB9006768C9DA06470685429A7794D581D7A8F48C5DCE7BC67730B6A50D85BAA886CA211AE324F41C64F518031F5EB5CD5493CCF717124F2906491CBB10A14649C9E0703F0A8EB9EA4F9E6E46F4E1C91510A28A2A0B0A28A2800A28A2800A28A2800A28A2800A28A2800A28A2800A28A2800A28A2800A28A2800A28A2800A28A2800A28A2800A28A2800A28A2803FFFD9, 1996, N'Affiliated to National Peace Secondary Boarding School')
SET IDENTITY_INSERT [dbo].[School] OFF
SET IDENTITY_INSERT [dbo].[Student] ON 

INSERT [dbo].[Student] ([StudentId], [StudentFullName], [Gender]) VALUES (1, N'Rhythm Maharjan', N'M')
INSERT [dbo].[Student] ([StudentId], [StudentFullName], [Gender]) VALUES (2, N'Prasamsha Dhungel', N'F')
INSERT [dbo].[Student] ([StudentId], [StudentFullName], [Gender]) VALUES (3, N'Prince Dahal', N'F')
INSERT [dbo].[Student] ([StudentId], [StudentFullName], [Gender]) VALUES (4, N'Aashree K.C', N'F')
INSERT [dbo].[Student] ([StudentId], [StudentFullName], [Gender]) VALUES (5, N'Namden Tamang', N'F')
INSERT [dbo].[Student] ([StudentId], [StudentFullName], [Gender]) VALUES (6, N'Suman Budhathoki', N'M')
INSERT [dbo].[Student] ([StudentId], [StudentFullName], [Gender]) VALUES (7, N'Aayusha Thapa', N'F')
INSERT [dbo].[Student] ([StudentId], [StudentFullName], [Gender]) VALUES (8, N'Aaliya Bhandari', N'F')
INSERT [dbo].[Student] ([StudentId], [StudentFullName], [Gender]) VALUES (10, N'Rohin Dev Maharjan', N'M')
INSERT [dbo].[Student] ([StudentId], [StudentFullName], [Gender]) VALUES (11, N'Sharon K.C', N'F')
INSERT [dbo].[Student] ([StudentId], [StudentFullName], [Gender]) VALUES (12, N'Diti Khatri', N'F')
INSERT [dbo].[Student] ([StudentId], [StudentFullName], [Gender]) VALUES (13, N'Aarshabh Nepal', N'M')
INSERT [dbo].[Student] ([StudentId], [StudentFullName], [Gender]) VALUES (14, N'Shreeyansh Pudasainee', N'M')
INSERT [dbo].[Student] ([StudentId], [StudentFullName], [Gender]) VALUES (15, N'Reeva Bastakoti', N'F')
INSERT [dbo].[Student] ([StudentId], [StudentFullName], [Gender]) VALUES (16, N'Jonan Gurung', N'M')
INSERT [dbo].[Student] ([StudentId], [StudentFullName], [Gender]) VALUES (17, N'Anuska Aryal', N'F')
INSERT [dbo].[Student] ([StudentId], [StudentFullName], [Gender]) VALUES (18, N'Kapish Maharjan', N'M')
INSERT [dbo].[Student] ([StudentId], [StudentFullName], [Gender]) VALUES (19, N'Nirishma Singh', N'F')
INSERT [dbo].[Student] ([StudentId], [StudentFullName], [Gender]) VALUES (20, N'Ajen Gurung', N'M')
INSERT [dbo].[Student] ([StudentId], [StudentFullName], [Gender]) VALUES (21, N'Prapti Rajbhandari', N'M')
INSERT [dbo].[Student] ([StudentId], [StudentFullName], [Gender]) VALUES (22, N'Shreyas Maharjan', N'M')
INSERT [dbo].[Student] ([StudentId], [StudentFullName], [Gender]) VALUES (23, N'Aarush Gautam', N'M')
INSERT [dbo].[Student] ([StudentId], [StudentFullName], [Gender]) VALUES (24, N'Angela Maharjan', N'F')
INSERT [dbo].[Student] ([StudentId], [StudentFullName], [Gender]) VALUES (25, N'Ansh Gautam', N'M')
INSERT [dbo].[Student] ([StudentId], [StudentFullName], [Gender]) VALUES (26, N'Aaryan Jirel', N'M')
INSERT [dbo].[Student] ([StudentId], [StudentFullName], [Gender]) VALUES (27, N'Aarush Bajracharya', N'M')
INSERT [dbo].[Student] ([StudentId], [StudentFullName], [Gender]) VALUES (28, N'Samrat Wagle', N'M')
INSERT [dbo].[Student] ([StudentId], [StudentFullName], [Gender]) VALUES (29, N'Joyesh Dhakal', N'M')
INSERT [dbo].[Student] ([StudentId], [StudentFullName], [Gender]) VALUES (30, N'Ayub Shrestha', N'M')
INSERT [dbo].[Student] ([StudentId], [StudentFullName], [Gender]) VALUES (38, N'Moni Blon Tamang', N'M')
INSERT [dbo].[Student] ([StudentId], [StudentFullName], [Gender]) VALUES (39, N'Naomi Ghimire', N'M')
INSERT [dbo].[Student] ([StudentId], [StudentFullName], [Gender]) VALUES (40, N'Giana Senchury', N'F')
INSERT [dbo].[Student] ([StudentId], [StudentFullName], [Gender]) VALUES (41, N'Sworen Shrestha', N'F')
INSERT [dbo].[Student] ([StudentId], [StudentFullName], [Gender]) VALUES (42, N'Prabisha Pokharel', N'M')
INSERT [dbo].[Student] ([StudentId], [StudentFullName], [Gender]) VALUES (43, N'Oshin Gurung', N'F')
INSERT [dbo].[Student] ([StudentId], [StudentFullName], [Gender]) VALUES (44, N'Mahira Limbu', N'F')
INSERT [dbo].[Student] ([StudentId], [StudentFullName], [Gender]) VALUES (53, N'Rhythm Maharjan', N'M')
INSERT [dbo].[Student] ([StudentId], [StudentFullName], [Gender]) VALUES (54, N'Prince Dahal', N'F')
INSERT [dbo].[Student] ([StudentId], [StudentFullName], [Gender]) VALUES (55, N'Aayusha Thapa', N'F')
INSERT [dbo].[Student] ([StudentId], [StudentFullName], [Gender]) VALUES (56, N'Prasamsha Dhungel', N'M')
INSERT [dbo].[Student] ([StudentId], [StudentFullName], [Gender]) VALUES (57, N'Namden Tamang', N'F')
INSERT [dbo].[Student] ([StudentId], [StudentFullName], [Gender]) VALUES (58, N'Paree Sunuwar', N'F')
INSERT [dbo].[Student] ([StudentId], [StudentFullName], [Gender]) VALUES (59, N'Aashree K.C', N'F')
INSERT [dbo].[Student] ([StudentId], [StudentFullName], [Gender]) VALUES (60, N'Moni Blon Tamang', N'M')
INSERT [dbo].[Student] ([StudentId], [StudentFullName], [Gender]) VALUES (61, N'Aaliya Bhandari', N'F')
INSERT [dbo].[Student] ([StudentId], [StudentFullName], [Gender]) VALUES (67, N'Rohin Dev Maharjan', N'M')
INSERT [dbo].[Student] ([StudentId], [StudentFullName], [Gender]) VALUES (68, N'Sharon K.C', N'F')
INSERT [dbo].[Student] ([StudentId], [StudentFullName], [Gender]) VALUES (69, N'Diti Khatri', N'F')
INSERT [dbo].[Student] ([StudentId], [StudentFullName], [Gender]) VALUES (70, N'Aarshabh Nepal', N'M')
INSERT [dbo].[Student] ([StudentId], [StudentFullName], [Gender]) VALUES (71, N'Nirishma Singh', N'M')
INSERT [dbo].[Student] ([StudentId], [StudentFullName], [Gender]) VALUES (72, N'Kapish Maharjan', N'F')
INSERT [dbo].[Student] ([StudentId], [StudentFullName], [Gender]) VALUES (73, N'Anuska Aryal', N'M')
INSERT [dbo].[Student] ([StudentId], [StudentFullName], [Gender]) VALUES (74, N'Ajen Gurung', N'F')
INSERT [dbo].[Student] ([StudentId], [StudentFullName], [Gender]) VALUES (75, N'Shreeyansh Pudasainee', N'M')
INSERT [dbo].[Student] ([StudentId], [StudentFullName], [Gender]) VALUES (76, N'Reeva Bastakoti', N'F')
INSERT [dbo].[Student] ([StudentId], [StudentFullName], [Gender]) VALUES (77, N'Aarush Gautam', N'M')
INSERT [dbo].[Student] ([StudentId], [StudentFullName], [Gender]) VALUES (78, N'Shreyas Maharjan', N'M')
INSERT [dbo].[Student] ([StudentId], [StudentFullName], [Gender]) VALUES (79, N'Jonan Gurung', N'M')
INSERT [dbo].[Student] ([StudentId], [StudentFullName], [Gender]) VALUES (85, N'Fiona Sherchan', N'M')
INSERT [dbo].[Student] ([StudentId], [StudentFullName], [Gender]) VALUES (86, N'Sanskar Dhakal', N'M')
INSERT [dbo].[Student] ([StudentId], [StudentFullName], [Gender]) VALUES (99, N'Oshin Gurung', N'F')
INSERT [dbo].[Student] ([StudentId], [StudentFullName], [Gender]) VALUES (100, N'Sworen Shrestha', N'F')
INSERT [dbo].[Student] ([StudentId], [StudentFullName], [Gender]) VALUES (101, N'Mahira Limbu', N'F')
INSERT [dbo].[Student] ([StudentId], [StudentFullName], [Gender]) VALUES (102, N'Giana Senchury', N'F')
INSERT [dbo].[Student] ([StudentId], [StudentFullName], [Gender]) VALUES (113, N'Prince Dahal', N'M')
INSERT [dbo].[Student] ([StudentId], [StudentFullName], [Gender]) VALUES (114, N'Prasamsha Dhungel', N'F')
INSERT [dbo].[Student] ([StudentId], [StudentFullName], [Gender]) VALUES (115, N'Paree Sunuwar', N'F')
INSERT [dbo].[Student] ([StudentId], [StudentFullName], [Gender]) VALUES (116, N'Namden Tamang', N'M')
INSERT [dbo].[Student] ([StudentId], [StudentFullName], [Gender]) VALUES (117, N'Aayusha Thapa', N'M')
INSERT [dbo].[Student] ([StudentId], [StudentFullName], [Gender]) VALUES (118, N'Rhythm Maharjan', N'F')
INSERT [dbo].[Student] ([StudentId], [StudentFullName], [Gender]) VALUES (119, N'Moni Blon Tamang', N'M')
INSERT [dbo].[Student] ([StudentId], [StudentFullName], [Gender]) VALUES (120, N'Aaliya Bhandari', N'F')
INSERT [dbo].[Student] ([StudentId], [StudentFullName], [Gender]) VALUES (131, N'Unish Khadka', N'M')
INSERT [dbo].[Student] ([StudentId], [StudentFullName], [Gender]) VALUES (132, N'Unisha Pandey', N' ')
INSERT [dbo].[Student] ([StudentId], [StudentFullName], [Gender]) VALUES (133, N'Anbin Rajbhandari', N' ')
INSERT [dbo].[Student] ([StudentId], [StudentFullName], [Gender]) VALUES (134, N'Prashamsha Rai', N' ')
INSERT [dbo].[Student] ([StudentId], [StudentFullName], [Gender]) VALUES (135, N'Sugam Dhakal', N' ')
INSERT [dbo].[Student] ([StudentId], [StudentFullName], [Gender]) VALUES (146, N'Fiona Sherchan', N' ')
INSERT [dbo].[Student] ([StudentId], [StudentFullName], [Gender]) VALUES (147, N'Unish Khadka', N' ')
INSERT [dbo].[Student] ([StudentId], [StudentFullName], [Gender]) VALUES (148, N'Sanskar Dhakal', N' ')
INSERT [dbo].[Student] ([StudentId], [StudentFullName], [Gender]) VALUES (160, N'Mahira Limbu', N'F')
INSERT [dbo].[Student] ([StudentId], [StudentFullName], [Gender]) VALUES (161, N'Sworen Shrestha', N' ')
INSERT [dbo].[Student] ([StudentId], [StudentFullName], [Gender]) VALUES (162, N'Oshin Gurung', N' ')
INSERT [dbo].[Student] ([StudentId], [StudentFullName], [Gender]) VALUES (163, N'Giana Senchury', N' ')
SET IDENTITY_INSERT [dbo].[Student] OFF
INSERT [dbo].[StudentClass] ([StudentId], [ClassId], [EnrolledYear], [RollNumber]) VALUES (1, 1, N'2073', N'1')
INSERT [dbo].[StudentClass] ([StudentId], [ClassId], [EnrolledYear], [RollNumber]) VALUES (2, 1, N'2073', N'2')
INSERT [dbo].[StudentClass] ([StudentId], [ClassId], [EnrolledYear], [RollNumber]) VALUES (3, 1, N'2073', N'3')
INSERT [dbo].[StudentClass] ([StudentId], [ClassId], [EnrolledYear], [RollNumber]) VALUES (4, 1, N'2073', N'4')
INSERT [dbo].[StudentClass] ([StudentId], [ClassId], [EnrolledYear], [RollNumber]) VALUES (5, 1, N'2073', N'5')
INSERT [dbo].[StudentClass] ([StudentId], [ClassId], [EnrolledYear], [RollNumber]) VALUES (6, 1, N'2073', N'6')
INSERT [dbo].[StudentClass] ([StudentId], [ClassId], [EnrolledYear], [RollNumber]) VALUES (7, 1, N'2073', N'7')
INSERT [dbo].[StudentClass] ([StudentId], [ClassId], [EnrolledYear], [RollNumber]) VALUES (8, 1, N'2073', N'8')
INSERT [dbo].[StudentClass] ([StudentId], [ClassId], [EnrolledYear], [RollNumber]) VALUES (10, 2, N'2073', N'1')
INSERT [dbo].[StudentClass] ([StudentId], [ClassId], [EnrolledYear], [RollNumber]) VALUES (11, 2, N'2073', N'2')
INSERT [dbo].[StudentClass] ([StudentId], [ClassId], [EnrolledYear], [RollNumber]) VALUES (12, 2, N'2073', N'3')
INSERT [dbo].[StudentClass] ([StudentId], [ClassId], [EnrolledYear], [RollNumber]) VALUES (13, 2, N'2073', N'4')
INSERT [dbo].[StudentClass] ([StudentId], [ClassId], [EnrolledYear], [RollNumber]) VALUES (14, 2, N'2073', N'5')
INSERT [dbo].[StudentClass] ([StudentId], [ClassId], [EnrolledYear], [RollNumber]) VALUES (15, 2, N'2073', N'6')
INSERT [dbo].[StudentClass] ([StudentId], [ClassId], [EnrolledYear], [RollNumber]) VALUES (16, 2, N'2073', N'7')
INSERT [dbo].[StudentClass] ([StudentId], [ClassId], [EnrolledYear], [RollNumber]) VALUES (17, 2, N'2073', N'8')
INSERT [dbo].[StudentClass] ([StudentId], [ClassId], [EnrolledYear], [RollNumber]) VALUES (18, 2, N'2073', N'9')
INSERT [dbo].[StudentClass] ([StudentId], [ClassId], [EnrolledYear], [RollNumber]) VALUES (19, 2, N'2073', N'10')
INSERT [dbo].[StudentClass] ([StudentId], [ClassId], [EnrolledYear], [RollNumber]) VALUES (20, 1, N'2073', N'11')
INSERT [dbo].[StudentClass] ([StudentId], [ClassId], [EnrolledYear], [RollNumber]) VALUES (21, 1, N'2073', N'12')
INSERT [dbo].[StudentClass] ([StudentId], [ClassId], [EnrolledYear], [RollNumber]) VALUES (22, 2, N'2073', N'13')
INSERT [dbo].[StudentClass] ([StudentId], [ClassId], [EnrolledYear], [RollNumber]) VALUES (23, 2, N'2073', N'14')
INSERT [dbo].[StudentClass] ([StudentId], [ClassId], [EnrolledYear], [RollNumber]) VALUES (24, 3, N'2073', N'1')
INSERT [dbo].[StudentClass] ([StudentId], [ClassId], [EnrolledYear], [RollNumber]) VALUES (25, 3, N'2073', N'2')
INSERT [dbo].[StudentClass] ([StudentId], [ClassId], [EnrolledYear], [RollNumber]) VALUES (26, 3, N'2073', N'3')
INSERT [dbo].[StudentClass] ([StudentId], [ClassId], [EnrolledYear], [RollNumber]) VALUES (27, 3, N'2073', N'4')
INSERT [dbo].[StudentClass] ([StudentId], [ClassId], [EnrolledYear], [RollNumber]) VALUES (28, 3, N'2073', N'5')
INSERT [dbo].[StudentClass] ([StudentId], [ClassId], [EnrolledYear], [RollNumber]) VALUES (29, 3, N'2073', N'6')
INSERT [dbo].[StudentClass] ([StudentId], [ClassId], [EnrolledYear], [RollNumber]) VALUES (30, 1, N'2073', N'7')
INSERT [dbo].[StudentClass] ([StudentId], [ClassId], [EnrolledYear], [RollNumber]) VALUES (38, 1, N'2073', N'9')
INSERT [dbo].[StudentClass] ([StudentId], [ClassId], [EnrolledYear], [RollNumber]) VALUES (39, 1, N'2074', N'1')
INSERT [dbo].[StudentClass] ([StudentId], [ClassId], [EnrolledYear], [RollNumber]) VALUES (40, 1, N'2074', N'2')
INSERT [dbo].[StudentClass] ([StudentId], [ClassId], [EnrolledYear], [RollNumber]) VALUES (41, 1, N'2074', N'3')
INSERT [dbo].[StudentClass] ([StudentId], [ClassId], [EnrolledYear], [RollNumber]) VALUES (42, 1, N'2074', N'4')
INSERT [dbo].[StudentClass] ([StudentId], [ClassId], [EnrolledYear], [RollNumber]) VALUES (43, 1, N'2074', N'5')
INSERT [dbo].[StudentClass] ([StudentId], [ClassId], [EnrolledYear], [RollNumber]) VALUES (44, 1, N'2074', N'6')
INSERT [dbo].[StudentClass] ([StudentId], [ClassId], [EnrolledYear], [RollNumber]) VALUES (53, 2, N'2074', N'1')
INSERT [dbo].[StudentClass] ([StudentId], [ClassId], [EnrolledYear], [RollNumber]) VALUES (54, 2, N'2074', N'2')
INSERT [dbo].[StudentClass] ([StudentId], [ClassId], [EnrolledYear], [RollNumber]) VALUES (55, 2, N'2074', N'3')
INSERT [dbo].[StudentClass] ([StudentId], [ClassId], [EnrolledYear], [RollNumber]) VALUES (56, 2, N'2074', N'4')
INSERT [dbo].[StudentClass] ([StudentId], [ClassId], [EnrolledYear], [RollNumber]) VALUES (57, 2, N'2074', N'5')
INSERT [dbo].[StudentClass] ([StudentId], [ClassId], [EnrolledYear], [RollNumber]) VALUES (58, 2, N'2074', N'6')
INSERT [dbo].[StudentClass] ([StudentId], [ClassId], [EnrolledYear], [RollNumber]) VALUES (59, 2, N'2074', N'7')
INSERT [dbo].[StudentClass] ([StudentId], [ClassId], [EnrolledYear], [RollNumber]) VALUES (60, 2, N'2074', N'8')
INSERT [dbo].[StudentClass] ([StudentId], [ClassId], [EnrolledYear], [RollNumber]) VALUES (61, 2, N'2074', N'9')
INSERT [dbo].[StudentClass] ([StudentId], [ClassId], [EnrolledYear], [RollNumber]) VALUES (67, 3, N'2074', N'1')
INSERT [dbo].[StudentClass] ([StudentId], [ClassId], [EnrolledYear], [RollNumber]) VALUES (68, 3, N'2074', N'2')
INSERT [dbo].[StudentClass] ([StudentId], [ClassId], [EnrolledYear], [RollNumber]) VALUES (69, 3, N'2074', N'3')
INSERT [dbo].[StudentClass] ([StudentId], [ClassId], [EnrolledYear], [RollNumber]) VALUES (70, 3, N'2074', N'4')
INSERT [dbo].[StudentClass] ([StudentId], [ClassId], [EnrolledYear], [RollNumber]) VALUES (71, 3, N'2074', N'5')
INSERT [dbo].[StudentClass] ([StudentId], [ClassId], [EnrolledYear], [RollNumber]) VALUES (72, 3, N'2074', N'6')
INSERT [dbo].[StudentClass] ([StudentId], [ClassId], [EnrolledYear], [RollNumber]) VALUES (73, 3, N'2074', N'7')
INSERT [dbo].[StudentClass] ([StudentId], [ClassId], [EnrolledYear], [RollNumber]) VALUES (74, 3, N'2074', N'8')
INSERT [dbo].[StudentClass] ([StudentId], [ClassId], [EnrolledYear], [RollNumber]) VALUES (75, 3, N'2074', N'9')
INSERT [dbo].[StudentClass] ([StudentId], [ClassId], [EnrolledYear], [RollNumber]) VALUES (76, 3, N'2074', N'10')
INSERT [dbo].[StudentClass] ([StudentId], [ClassId], [EnrolledYear], [RollNumber]) VALUES (77, 3, N'2074', N'11')
INSERT [dbo].[StudentClass] ([StudentId], [ClassId], [EnrolledYear], [RollNumber]) VALUES (78, 3, N'2074', N'12')
INSERT [dbo].[StudentClass] ([StudentId], [ClassId], [EnrolledYear], [RollNumber]) VALUES (79, 3, N'2074', N'13')
INSERT [dbo].[StudentClass] ([StudentId], [ClassId], [EnrolledYear], [RollNumber]) VALUES (85, 1, N'2075', N'1')
INSERT [dbo].[StudentClass] ([StudentId], [ClassId], [EnrolledYear], [RollNumber]) VALUES (86, 1, N'2075', N'3')
INSERT [dbo].[StudentClass] ([StudentId], [ClassId], [EnrolledYear], [RollNumber]) VALUES (99, 2, N'2075', N'1')
INSERT [dbo].[StudentClass] ([StudentId], [ClassId], [EnrolledYear], [RollNumber]) VALUES (100, 2, N'2075', N'2')
INSERT [dbo].[StudentClass] ([StudentId], [ClassId], [EnrolledYear], [RollNumber]) VALUES (101, 2, N'2075', N'3')
INSERT [dbo].[StudentClass] ([StudentId], [ClassId], [EnrolledYear], [RollNumber]) VALUES (102, 2, N'2075', N'4')
INSERT [dbo].[StudentClass] ([StudentId], [ClassId], [EnrolledYear], [RollNumber]) VALUES (113, 3, N'2075', N'1')
INSERT [dbo].[StudentClass] ([StudentId], [ClassId], [EnrolledYear], [RollNumber]) VALUES (114, 3, N'2075', N'2')
INSERT [dbo].[StudentClass] ([StudentId], [ClassId], [EnrolledYear], [RollNumber]) VALUES (115, 3, N'2075', N'3')
INSERT [dbo].[StudentClass] ([StudentId], [ClassId], [EnrolledYear], [RollNumber]) VALUES (116, 3, N'2075', N'4')
INSERT [dbo].[StudentClass] ([StudentId], [ClassId], [EnrolledYear], [RollNumber]) VALUES (117, 3, N'2075', N'5')
INSERT [dbo].[StudentClass] ([StudentId], [ClassId], [EnrolledYear], [RollNumber]) VALUES (118, 3, N'2075', N'6')
INSERT [dbo].[StudentClass] ([StudentId], [ClassId], [EnrolledYear], [RollNumber]) VALUES (119, 3, N'2075', N'7')
INSERT [dbo].[StudentClass] ([StudentId], [ClassId], [EnrolledYear], [RollNumber]) VALUES (120, 3, N'2075', N'8')
INSERT [dbo].[StudentClass] ([StudentId], [ClassId], [EnrolledYear], [RollNumber]) VALUES (131, 1, N'2075', N'2')
INSERT [dbo].[StudentClass] ([StudentId], [ClassId], [EnrolledYear], [RollNumber]) VALUES (132, 1, N'2076', N'1')
INSERT [dbo].[StudentClass] ([StudentId], [ClassId], [EnrolledYear], [RollNumber]) VALUES (133, 1, N'2076', N'2')
INSERT [dbo].[StudentClass] ([StudentId], [ClassId], [EnrolledYear], [RollNumber]) VALUES (134, 1, N'2076', N'3')
INSERT [dbo].[StudentClass] ([StudentId], [ClassId], [EnrolledYear], [RollNumber]) VALUES (135, 1, N'2076', N'4')
INSERT [dbo].[StudentClass] ([StudentId], [ClassId], [EnrolledYear], [RollNumber]) VALUES (146, 2, N'2076', N'1')
INSERT [dbo].[StudentClass] ([StudentId], [ClassId], [EnrolledYear], [RollNumber]) VALUES (147, 2, N'2076', N'2')
INSERT [dbo].[StudentClass] ([StudentId], [ClassId], [EnrolledYear], [RollNumber]) VALUES (148, 2, N'2076', N'3')
INSERT [dbo].[StudentClass] ([StudentId], [ClassId], [EnrolledYear], [RollNumber]) VALUES (160, 3, N'2076', N'1')
INSERT [dbo].[StudentClass] ([StudentId], [ClassId], [EnrolledYear], [RollNumber]) VALUES (161, 3, N'2076', N'2')
INSERT [dbo].[StudentClass] ([StudentId], [ClassId], [EnrolledYear], [RollNumber]) VALUES (162, 3, N'2076', N'3')
INSERT [dbo].[StudentClass] ([StudentId], [ClassId], [EnrolledYear], [RollNumber]) VALUES (163, 3, N'2076', N'4')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (1, 1, 1, 26, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (1, 1, 1, 27, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (1, 1, 1, 28, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (1, 1, 1, 29, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (1, 1, 1, 30, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (1, 1, 1, 31, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (1, 1, 1, 32, N'C ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (1, 1, 1, 33, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (1, 1, 1, 34, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (1, 2, 1, 26, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (1, 2, 1, 27, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (1, 2, 1, 28, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (1, 2, 1, 29, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (1, 2, 1, 30, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (1, 2, 1, 31, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (1, 2, 1, 32, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (1, 2, 1, 33, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (1, 2, 1, 34, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (2, 1, 1, 26, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (2, 1, 1, 27, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (2, 1, 1, 28, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (2, 1, 1, 29, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (2, 1, 1, 30, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (2, 1, 1, 31, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (2, 1, 1, 32, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (2, 1, 1, 33, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (2, 1, 1, 34, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (2, 2, 1, 26, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (2, 2, 1, 27, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (2, 2, 1, 28, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (2, 2, 1, 29, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (2, 2, 1, 30, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (2, 2, 1, 31, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (2, 2, 1, 32, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (2, 2, 1, 33, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (2, 2, 1, 34, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (3, 1, 1, 26, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (3, 1, 1, 27, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (3, 1, 1, 28, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (3, 1, 1, 29, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (3, 1, 1, 30, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (3, 1, 1, 31, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (3, 1, 1, 32, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (3, 1, 1, 33, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (3, 1, 1, 34, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (3, 2, 1, 26, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (3, 2, 1, 27, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (3, 2, 1, 28, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (3, 2, 1, 29, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (3, 2, 1, 30, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (3, 2, 1, 31, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (3, 2, 1, 32, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (3, 2, 1, 33, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (3, 2, 1, 34, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (4, 1, 1, 26, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (4, 1, 1, 27, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (4, 1, 1, 28, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (4, 1, 1, 29, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (4, 1, 1, 30, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (4, 1, 1, 31, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (4, 1, 1, 32, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (4, 1, 1, 33, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (4, 1, 1, 34, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (4, 2, 1, 26, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (4, 2, 1, 27, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (4, 2, 1, 28, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (4, 2, 1, 29, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (4, 2, 1, 30, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (4, 2, 1, 31, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (4, 2, 1, 32, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (4, 2, 1, 33, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (4, 2, 1, 34, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (5, 1, 1, 26, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (5, 1, 1, 27, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (5, 1, 1, 28, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (5, 1, 1, 29, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (5, 1, 1, 30, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (5, 1, 1, 31, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (5, 1, 1, 32, N'C ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (5, 1, 1, 33, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (5, 1, 1, 34, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (5, 2, 1, 26, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (5, 2, 1, 27, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (5, 2, 1, 28, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (5, 2, 1, 29, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (5, 2, 1, 30, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (5, 2, 1, 31, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (5, 2, 1, 32, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (5, 2, 1, 33, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (5, 2, 1, 34, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (6, 1, 1, 26, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (6, 1, 1, 27, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (6, 1, 1, 28, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (6, 1, 1, 29, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (6, 1, 1, 30, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (6, 1, 1, 31, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (6, 1, 1, 32, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (6, 1, 1, 33, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (6, 1, 1, 34, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (6, 2, 1, 26, N'A+')
GO
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (6, 2, 1, 27, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (6, 2, 1, 28, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (6, 2, 1, 29, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (6, 2, 1, 30, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (6, 2, 1, 31, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (6, 2, 1, 32, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (6, 2, 1, 33, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (6, 2, 1, 34, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (7, 1, 1, 26, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (7, 1, 1, 27, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (7, 1, 1, 28, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (7, 1, 1, 29, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (7, 1, 1, 30, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (7, 1, 1, 31, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (7, 1, 1, 32, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (7, 1, 1, 33, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (7, 1, 1, 34, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (7, 2, 1, 26, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (7, 2, 1, 27, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (7, 2, 1, 28, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (7, 2, 1, 29, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (7, 2, 1, 30, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (7, 2, 1, 31, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (7, 2, 1, 32, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (7, 2, 1, 33, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (7, 2, 1, 34, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (8, 1, 1, 26, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (8, 1, 1, 27, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (8, 1, 1, 28, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (8, 1, 1, 29, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (8, 1, 1, 30, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (8, 1, 1, 31, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (8, 1, 1, 32, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (8, 1, 1, 33, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (8, 1, 1, 34, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (8, 2, 1, 26, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (8, 2, 1, 27, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (8, 2, 1, 28, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (8, 2, 1, 29, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (8, 2, 1, 30, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (8, 2, 1, 31, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (8, 2, 1, 32, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (8, 2, 1, 33, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (8, 2, 1, 34, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (10, 1, 2, 60, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (10, 1, 2, 61, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (10, 1, 2, 62, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (10, 1, 2, 63, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (10, 1, 2, 65, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (10, 1, 2, 66, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (10, 1, 2, 67, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (10, 2, 2, 60, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (10, 2, 2, 61, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (10, 2, 2, 62, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (10, 2, 2, 63, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (10, 2, 2, 65, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (10, 2, 2, 66, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (10, 2, 2, 67, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (11, 1, 2, 60, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (11, 1, 2, 61, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (11, 1, 2, 62, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (11, 1, 2, 63, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (11, 1, 2, 65, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (11, 1, 2, 66, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (11, 1, 2, 67, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (11, 2, 2, 60, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (11, 2, 2, 61, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (11, 2, 2, 62, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (11, 2, 2, 63, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (11, 2, 2, 65, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (11, 2, 2, 66, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (11, 2, 2, 67, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (12, 1, 2, 60, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (12, 1, 2, 61, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (12, 1, 2, 62, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (12, 1, 2, 63, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (12, 1, 2, 65, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (12, 1, 2, 66, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (12, 1, 2, 67, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (12, 2, 2, 60, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (12, 2, 2, 61, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (12, 2, 2, 62, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (12, 2, 2, 63, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (12, 2, 2, 65, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (12, 2, 2, 66, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (12, 2, 2, 67, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (13, 1, 2, 60, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (13, 1, 2, 61, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (13, 1, 2, 62, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (13, 1, 2, 63, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (13, 1, 2, 65, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (13, 1, 2, 66, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (13, 1, 2, 67, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (13, 2, 2, 60, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (13, 2, 2, 61, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (13, 2, 2, 62, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (13, 2, 2, 63, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (13, 2, 2, 65, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (13, 2, 2, 66, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (13, 2, 2, 67, N'A ')
GO
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (14, 1, 2, 60, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (14, 1, 2, 61, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (14, 1, 2, 62, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (14, 1, 2, 63, N'C ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (14, 1, 2, 65, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (14, 1, 2, 66, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (14, 1, 2, 67, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (14, 2, 2, 60, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (14, 2, 2, 61, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (14, 2, 2, 62, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (14, 2, 2, 63, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (14, 2, 2, 65, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (14, 2, 2, 66, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (14, 2, 2, 67, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (15, 1, 2, 60, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (15, 1, 2, 61, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (15, 1, 2, 62, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (15, 1, 2, 63, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (15, 1, 2, 65, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (15, 1, 2, 66, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (15, 1, 2, 67, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (15, 2, 2, 60, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (15, 2, 2, 61, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (15, 2, 2, 62, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (15, 2, 2, 63, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (15, 2, 2, 65, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (15, 2, 2, 66, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (15, 2, 2, 67, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (16, 1, 2, 60, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (16, 1, 2, 61, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (16, 1, 2, 62, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (16, 1, 2, 63, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (16, 1, 2, 65, N'C ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (16, 1, 2, 66, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (16, 1, 2, 67, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (16, 2, 2, 60, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (16, 2, 2, 61, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (16, 2, 2, 62, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (16, 2, 2, 63, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (16, 2, 2, 65, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (16, 2, 2, 66, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (16, 2, 2, 67, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (17, 1, 2, 60, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (17, 1, 2, 61, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (17, 1, 2, 62, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (17, 1, 2, 63, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (17, 1, 2, 65, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (17, 1, 2, 66, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (17, 1, 2, 67, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (17, 2, 2, 60, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (17, 2, 2, 61, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (17, 2, 2, 62, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (17, 2, 2, 63, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (17, 2, 2, 65, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (17, 2, 2, 66, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (17, 2, 2, 67, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (18, 1, 2, 60, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (18, 1, 2, 61, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (18, 1, 2, 62, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (18, 1, 2, 63, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (18, 1, 2, 65, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (18, 1, 2, 66, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (18, 1, 2, 67, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (18, 2, 2, 60, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (18, 2, 2, 61, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (18, 2, 2, 62, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (18, 2, 2, 63, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (18, 2, 2, 65, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (18, 2, 2, 66, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (18, 2, 2, 67, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (19, 1, 2, 60, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (19, 1, 2, 61, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (19, 1, 2, 62, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (19, 1, 2, 63, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (19, 1, 2, 65, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (19, 1, 2, 66, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (19, 1, 2, 67, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (19, 2, 2, 60, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (19, 2, 2, 61, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (19, 2, 2, 62, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (19, 2, 2, 63, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (19, 2, 2, 65, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (19, 2, 2, 66, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (19, 2, 2, 67, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (20, 1, 2, 60, N'D ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (20, 1, 2, 61, N'D ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (20, 1, 2, 62, N'D ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (20, 1, 2, 63, N'D ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (20, 1, 2, 65, N'D ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (20, 1, 2, 66, N'D ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (20, 1, 2, 67, N'D ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (20, 2, 2, 60, N'D ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (20, 2, 2, 61, N'D ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (20, 2, 2, 62, N'D ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (20, 2, 2, 63, N'D ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (20, 2, 2, 65, N'D ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (20, 2, 2, 66, N'D ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (20, 2, 2, 67, N'D ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (21, 1, 2, 60, N'D ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (21, 1, 2, 61, N'D ')
GO
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (21, 1, 2, 62, N'D ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (21, 1, 2, 63, N'D ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (21, 1, 2, 65, N'D ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (21, 1, 2, 66, N'D ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (21, 1, 2, 67, N'D ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (21, 2, 2, 60, N'D ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (21, 2, 2, 61, N'D ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (21, 2, 2, 62, N'D ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (21, 2, 2, 63, N'D ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (21, 2, 2, 65, N'D ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (21, 2, 2, 66, N'D ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (21, 2, 2, 67, N'D ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (22, 1, 2, 60, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (22, 1, 2, 61, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (22, 1, 2, 62, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (22, 1, 2, 63, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (22, 1, 2, 65, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (22, 1, 2, 66, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (22, 1, 2, 67, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (22, 2, 2, 60, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (22, 2, 2, 61, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (22, 2, 2, 62, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (22, 2, 2, 63, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (22, 2, 2, 65, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (22, 2, 2, 66, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (22, 2, 2, 67, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (23, 1, 2, 60, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (23, 1, 2, 61, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (23, 1, 2, 62, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (23, 1, 2, 63, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (23, 1, 2, 65, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (23, 1, 2, 66, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (23, 1, 2, 67, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (23, 2, 2, 60, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (23, 2, 2, 61, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (23, 2, 2, 62, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (23, 2, 2, 63, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (23, 2, 2, 65, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (23, 2, 2, 66, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (23, 2, 2, 67, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (24, 1, 3, 68, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (24, 1, 3, 69, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (24, 1, 3, 70, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (24, 1, 3, 71, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (24, 1, 3, 72, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (24, 1, 3, 73, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (24, 1, 3, 74, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (24, 1, 3, 75, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (24, 2, 3, 68, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (24, 2, 3, 69, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (24, 2, 3, 70, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (24, 2, 3, 71, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (24, 2, 3, 72, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (24, 2, 3, 73, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (24, 2, 3, 74, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (24, 2, 3, 75, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (25, 1, 3, 68, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (25, 1, 3, 69, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (25, 1, 3, 70, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (25, 1, 3, 71, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (25, 1, 3, 72, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (25, 1, 3, 73, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (25, 1, 3, 74, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (25, 1, 3, 75, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (25, 2, 3, 68, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (25, 2, 3, 69, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (25, 2, 3, 70, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (25, 2, 3, 71, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (25, 2, 3, 72, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (25, 2, 3, 73, N'C ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (25, 2, 3, 74, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (25, 2, 3, 75, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (26, 1, 3, 68, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (26, 1, 3, 69, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (26, 1, 3, 70, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (26, 1, 3, 71, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (26, 1, 3, 72, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (26, 1, 3, 73, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (26, 1, 3, 74, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (26, 1, 3, 75, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (26, 2, 3, 68, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (26, 2, 3, 69, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (26, 2, 3, 70, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (26, 2, 3, 71, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (26, 2, 3, 72, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (26, 2, 3, 73, N'C ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (26, 2, 3, 74, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (26, 2, 3, 75, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (27, 1, 3, 68, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (27, 1, 3, 69, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (27, 1, 3, 70, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (27, 1, 3, 71, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (27, 1, 3, 72, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (27, 1, 3, 73, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (27, 1, 3, 74, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (27, 1, 3, 75, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (27, 2, 3, 68, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (27, 2, 3, 69, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (27, 2, 3, 70, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (27, 2, 3, 71, N'A+')
GO
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (27, 2, 3, 72, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (27, 2, 3, 73, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (27, 2, 3, 74, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (27, 2, 3, 75, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (28, 1, 3, 68, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (28, 1, 3, 69, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (28, 1, 3, 70, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (28, 1, 3, 71, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (28, 1, 3, 72, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (28, 1, 3, 73, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (28, 1, 3, 74, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (28, 1, 3, 75, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (28, 2, 3, 68, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (28, 2, 3, 69, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (28, 2, 3, 70, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (28, 2, 3, 71, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (28, 2, 3, 72, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (28, 2, 3, 73, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (28, 2, 3, 74, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (28, 2, 3, 75, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (29, 1, 3, 68, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (29, 1, 3, 69, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (29, 1, 3, 70, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (29, 1, 3, 71, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (29, 1, 3, 72, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (29, 1, 3, 73, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (29, 1, 3, 74, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (29, 1, 3, 75, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (29, 2, 3, 68, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (29, 2, 3, 69, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (29, 2, 3, 70, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (29, 2, 3, 71, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (29, 2, 3, 72, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (29, 2, 3, 73, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (29, 2, 3, 74, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (29, 2, 3, 75, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (30, 1, 3, 68, N'C ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (30, 1, 3, 69, N'D ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (30, 1, 3, 70, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (30, 1, 3, 71, N'D ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (30, 1, 3, 72, N'D ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (30, 1, 3, 73, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (30, 1, 3, 74, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (30, 1, 3, 75, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (38, 1, 1, 30, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (38, 2, 1, 26, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (38, 2, 1, 27, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (38, 2, 1, 28, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (38, 2, 1, 29, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (38, 2, 1, 30, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (38, 2, 1, 31, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (38, 2, 1, 32, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (38, 2, 1, 33, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (38, 2, 1, 34, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (39, 3, 1, 26, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (39, 3, 1, 27, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (39, 3, 1, 28, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (39, 3, 1, 29, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (39, 3, 1, 30, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (39, 3, 1, 31, N'C ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (39, 3, 1, 32, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (39, 3, 1, 33, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (39, 3, 1, 34, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (39, 4, 1, 26, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (39, 4, 1, 27, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (39, 4, 1, 28, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (39, 4, 1, 29, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (39, 4, 1, 30, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (39, 4, 1, 31, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (39, 4, 1, 32, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (39, 4, 1, 33, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (40, 3, 1, 26, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (40, 3, 1, 27, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (40, 3, 1, 28, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (40, 3, 1, 29, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (40, 3, 1, 30, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (40, 3, 1, 31, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (40, 3, 1, 32, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (40, 3, 1, 33, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (40, 3, 1, 34, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (40, 4, 1, 26, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (40, 4, 1, 27, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (40, 4, 1, 28, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (40, 4, 1, 29, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (40, 4, 1, 30, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (40, 4, 1, 31, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (40, 4, 1, 32, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (40, 4, 1, 33, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (41, 3, 1, 26, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (41, 3, 1, 27, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (41, 3, 1, 28, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (41, 3, 1, 29, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (41, 3, 1, 30, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (41, 3, 1, 31, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (41, 3, 1, 32, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (41, 3, 1, 33, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (41, 3, 1, 34, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (41, 4, 1, 26, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (41, 4, 1, 27, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (41, 4, 1, 28, N'A+')
GO
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (41, 4, 1, 29, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (41, 4, 1, 30, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (41, 4, 1, 31, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (41, 4, 1, 32, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (41, 4, 1, 33, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (42, 3, 1, 26, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (42, 3, 1, 27, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (42, 3, 1, 28, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (42, 3, 1, 29, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (42, 3, 1, 30, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (42, 3, 1, 31, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (42, 3, 1, 32, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (42, 3, 1, 33, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (42, 3, 1, 34, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (42, 4, 1, 26, N'D ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (42, 4, 1, 27, N'D ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (42, 4, 1, 28, N'D ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (42, 4, 1, 29, N'D ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (42, 4, 1, 30, N'D ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (42, 4, 1, 31, N'D ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (42, 4, 1, 32, N'D ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (42, 4, 1, 33, N'D ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (43, 3, 1, 26, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (43, 3, 1, 27, N'C ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (43, 3, 1, 28, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (43, 3, 1, 29, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (43, 3, 1, 30, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (43, 3, 1, 31, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (43, 3, 1, 32, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (43, 3, 1, 33, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (43, 3, 1, 34, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (43, 4, 1, 26, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (43, 4, 1, 27, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (43, 4, 1, 28, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (43, 4, 1, 29, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (43, 4, 1, 30, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (43, 4, 1, 31, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (43, 4, 1, 32, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (43, 4, 1, 33, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (44, 3, 1, 26, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (44, 3, 1, 27, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (44, 3, 1, 28, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (44, 3, 1, 29, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (44, 3, 1, 30, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (44, 3, 1, 31, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (44, 3, 1, 32, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (44, 3, 1, 33, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (44, 3, 1, 34, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (44, 4, 1, 26, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (44, 4, 1, 27, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (44, 4, 1, 28, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (44, 4, 1, 29, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (44, 4, 1, 30, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (44, 4, 1, 31, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (44, 4, 1, 32, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (44, 4, 1, 33, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (53, 3, 2, 60, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (53, 3, 2, 61, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (53, 3, 2, 62, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (53, 3, 2, 63, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (53, 3, 2, 65, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (53, 3, 2, 66, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (53, 3, 2, 67, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (53, 4, 2, 60, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (53, 4, 2, 61, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (53, 4, 2, 62, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (53, 4, 2, 63, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (53, 4, 2, 65, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (53, 4, 2, 66, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (53, 4, 2, 67, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (54, 3, 2, 60, N'C ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (54, 3, 2, 61, N'D ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (54, 3, 2, 62, N'C ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (54, 3, 2, 63, N'D ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (54, 3, 2, 65, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (54, 3, 2, 66, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (54, 3, 2, 67, N'C ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (54, 4, 2, 60, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (54, 4, 2, 61, N'C ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (54, 4, 2, 62, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (54, 4, 2, 63, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (54, 4, 2, 65, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (54, 4, 2, 66, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (54, 4, 2, 67, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (55, 3, 2, 60, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (55, 3, 2, 61, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (55, 3, 2, 62, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (55, 3, 2, 63, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (55, 3, 2, 65, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (55, 3, 2, 66, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (55, 3, 2, 67, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (55, 4, 2, 60, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (55, 4, 2, 61, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (55, 4, 2, 62, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (55, 4, 2, 63, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (55, 4, 2, 65, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (55, 4, 2, 66, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (55, 4, 2, 67, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (56, 3, 2, 60, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (56, 3, 2, 61, N'A+')
GO
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (56, 3, 2, 62, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (56, 3, 2, 63, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (56, 3, 2, 65, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (56, 3, 2, 66, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (56, 3, 2, 67, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (56, 4, 2, 60, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (56, 4, 2, 61, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (56, 4, 2, 62, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (56, 4, 2, 63, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (56, 4, 2, 65, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (56, 4, 2, 66, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (56, 4, 2, 67, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (57, 3, 2, 60, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (57, 3, 2, 61, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (57, 3, 2, 62, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (57, 3, 2, 63, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (57, 3, 2, 65, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (57, 3, 2, 66, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (57, 3, 2, 67, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (57, 4, 2, 60, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (57, 4, 2, 61, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (57, 4, 2, 62, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (57, 4, 2, 63, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (57, 4, 2, 65, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (57, 4, 2, 66, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (57, 4, 2, 67, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (58, 3, 2, 60, N'C ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (58, 3, 2, 61, N'D ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (58, 3, 2, 62, N'D ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (58, 3, 2, 63, N'D ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (58, 3, 2, 65, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (58, 3, 2, 66, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (58, 3, 2, 67, N'C ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (58, 4, 2, 60, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (58, 4, 2, 61, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (58, 4, 2, 62, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (58, 4, 2, 63, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (58, 4, 2, 65, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (58, 4, 2, 66, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (58, 4, 2, 67, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (59, 3, 2, 60, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (59, 3, 2, 61, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (59, 3, 2, 62, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (59, 3, 2, 63, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (59, 3, 2, 65, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (59, 3, 2, 66, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (59, 3, 2, 67, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (59, 4, 2, 60, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (59, 4, 2, 61, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (59, 4, 2, 62, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (59, 4, 2, 63, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (59, 4, 2, 65, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (59, 4, 2, 66, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (59, 4, 2, 67, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (60, 3, 2, 60, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (60, 3, 2, 61, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (60, 3, 2, 62, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (60, 3, 2, 63, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (60, 3, 2, 65, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (60, 3, 2, 66, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (60, 3, 2, 67, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (60, 4, 2, 60, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (60, 4, 2, 61, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (60, 4, 2, 62, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (60, 4, 2, 63, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (60, 4, 2, 65, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (60, 4, 2, 66, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (60, 4, 2, 67, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (61, 3, 2, 60, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (61, 3, 2, 61, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (61, 3, 2, 62, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (61, 3, 2, 63, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (61, 3, 2, 65, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (61, 3, 2, 66, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (61, 3, 2, 67, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (61, 4, 2, 60, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (61, 4, 2, 61, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (61, 4, 2, 62, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (61, 4, 2, 63, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (61, 4, 2, 65, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (61, 4, 2, 66, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (61, 4, 2, 67, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (67, 3, 3, 68, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (67, 3, 3, 69, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (67, 3, 3, 70, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (67, 3, 3, 71, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (67, 3, 3, 73, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (67, 3, 3, 74, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (67, 3, 3, 75, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (67, 4, 3, 68, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (67, 4, 3, 69, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (67, 4, 3, 70, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (67, 4, 3, 71, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (67, 4, 3, 72, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (67, 4, 3, 73, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (67, 4, 3, 74, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (67, 4, 3, 75, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (68, 3, 3, 68, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (68, 3, 3, 69, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (68, 3, 3, 70, N'A+')
GO
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (68, 3, 3, 71, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (68, 3, 3, 73, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (68, 3, 3, 74, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (68, 3, 3, 75, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (68, 4, 3, 68, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (68, 4, 3, 69, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (68, 4, 3, 70, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (68, 4, 3, 71, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (68, 4, 3, 72, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (68, 4, 3, 73, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (68, 4, 3, 74, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (68, 4, 3, 75, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (69, 3, 3, 68, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (69, 3, 3, 69, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (69, 3, 3, 70, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (69, 3, 3, 71, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (69, 3, 3, 73, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (69, 3, 3, 74, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (69, 3, 3, 75, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (69, 4, 3, 68, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (69, 4, 3, 69, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (69, 4, 3, 70, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (69, 4, 3, 71, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (69, 4, 3, 72, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (69, 4, 3, 73, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (69, 4, 3, 74, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (69, 4, 3, 75, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (70, 3, 3, 68, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (70, 3, 3, 69, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (70, 3, 3, 70, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (70, 3, 3, 71, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (70, 3, 3, 73, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (70, 3, 3, 74, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (70, 3, 3, 75, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (70, 4, 3, 68, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (70, 4, 3, 69, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (70, 4, 3, 70, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (70, 4, 3, 71, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (70, 4, 3, 72, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (70, 4, 3, 73, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (70, 4, 3, 74, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (70, 4, 3, 75, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (71, 3, 3, 68, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (71, 3, 3, 69, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (71, 3, 3, 70, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (71, 3, 3, 71, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (71, 3, 3, 73, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (71, 3, 3, 74, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (71, 3, 3, 75, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (71, 4, 3, 68, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (71, 4, 3, 69, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (71, 4, 3, 70, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (71, 4, 3, 71, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (71, 4, 3, 72, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (71, 4, 3, 73, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (71, 4, 3, 74, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (71, 4, 3, 75, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (72, 3, 3, 68, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (72, 3, 3, 69, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (72, 3, 3, 70, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (72, 3, 3, 71, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (72, 3, 3, 73, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (72, 3, 3, 74, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (72, 3, 3, 75, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (72, 4, 3, 68, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (72, 4, 3, 69, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (72, 4, 3, 70, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (72, 4, 3, 71, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (72, 4, 3, 72, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (72, 4, 3, 73, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (72, 4, 3, 74, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (72, 4, 3, 75, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (73, 3, 3, 68, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (73, 3, 3, 69, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (73, 3, 3, 70, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (73, 3, 3, 71, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (73, 3, 3, 73, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (73, 3, 3, 74, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (73, 3, 3, 75, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (73, 4, 3, 68, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (73, 4, 3, 69, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (73, 4, 3, 70, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (73, 4, 3, 71, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (73, 4, 3, 72, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (73, 4, 3, 73, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (73, 4, 3, 74, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (73, 4, 3, 75, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (74, 3, 3, 68, N'D ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (74, 3, 3, 69, N'D ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (74, 3, 3, 70, N'D ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (74, 3, 3, 71, N'D ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (74, 3, 3, 73, N'D ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (74, 3, 3, 74, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (74, 3, 3, 75, N'D ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (74, 4, 3, 68, N'D ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (74, 4, 3, 69, N'D ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (74, 4, 3, 70, N'D ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (74, 4, 3, 71, N'D ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (74, 4, 3, 72, N'D ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (74, 4, 3, 73, N'B ')
GO
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (74, 4, 3, 74, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (74, 4, 3, 75, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (75, 3, 3, 68, N'B+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (75, 3, 3, 69, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (75, 3, 3, 70, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (75, 3, 3, 71, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (75, 3, 3, 73, N'C ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (75, 3, 3, 74, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (75, 3, 3, 75, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (75, 4, 3, 68, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (75, 4, 3, 69, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (75, 4, 3, 70, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (75, 4, 3, 71, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (75, 4, 3, 72, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (75, 4, 3, 73, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (75, 4, 3, 74, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (75, 4, 3, 75, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (76, 3, 3, 68, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (76, 3, 3, 69, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (76, 3, 3, 70, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (76, 3, 3, 71, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (76, 3, 3, 73, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (76, 3, 3, 74, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (76, 3, 3, 75, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (76, 4, 3, 68, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (76, 4, 3, 69, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (76, 4, 3, 70, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (76, 4, 3, 71, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (76, 4, 3, 72, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (76, 4, 3, 73, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (76, 4, 3, 74, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (76, 4, 3, 75, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (77, 3, 3, 68, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (77, 3, 3, 69, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (77, 3, 3, 70, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (77, 3, 3, 71, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (77, 3, 3, 73, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (77, 3, 3, 74, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (77, 3, 3, 75, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (77, 4, 3, 68, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (77, 4, 3, 69, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (77, 4, 3, 70, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (77, 4, 3, 71, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (77, 4, 3, 72, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (77, 4, 3, 73, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (77, 4, 3, 74, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (77, 4, 3, 75, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (78, 3, 3, 68, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (78, 3, 3, 69, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (78, 3, 3, 70, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (78, 3, 3, 71, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (78, 3, 3, 73, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (78, 3, 3, 74, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (78, 3, 3, 75, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (78, 4, 3, 68, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (78, 4, 3, 69, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (78, 4, 3, 70, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (78, 4, 3, 71, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (78, 4, 3, 72, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (78, 4, 3, 73, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (78, 4, 3, 74, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (78, 4, 3, 75, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (79, 3, 3, 68, N'C ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (79, 3, 3, 69, N'C ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (79, 3, 3, 70, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (79, 3, 3, 71, N'C ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (79, 3, 3, 73, N'C ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (79, 3, 3, 74, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (79, 3, 3, 75, N'C ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (79, 4, 3, 68, N'C ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (79, 4, 3, 69, N'C ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (79, 4, 3, 70, N'C ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (79, 4, 3, 71, N'C ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (79, 4, 3, 72, N'C ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (79, 4, 3, 73, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (79, 4, 3, 74, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (79, 4, 3, 75, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (85, 5, 1, 26, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (85, 5, 1, 27, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (85, 5, 1, 28, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (85, 5, 1, 29, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (85, 5, 1, 30, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (85, 5, 1, 31, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (85, 5, 1, 32, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (85, 5, 1, 33, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (85, 5, 1, 34, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (85, 6, 1, 26, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (85, 6, 1, 27, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (85, 6, 1, 28, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (85, 6, 1, 29, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (85, 6, 1, 30, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (85, 6, 1, 31, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (85, 6, 1, 32, N'C ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (85, 6, 1, 33, N'C ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (85, 6, 1, 34, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (85, 7, 1, 26, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (85, 7, 1, 27, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (85, 7, 1, 28, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (85, 7, 1, 29, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (85, 7, 1, 30, N'A+')
GO
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (85, 7, 1, 31, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (85, 7, 1, 32, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (85, 7, 1, 33, N'C ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (85, 7, 1, 34, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (86, 5, 1, 26, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (86, 5, 1, 27, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (86, 5, 1, 28, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (86, 5, 1, 29, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (86, 5, 1, 30, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (86, 5, 1, 31, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (86, 5, 1, 32, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (86, 5, 1, 33, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (86, 5, 1, 34, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (86, 6, 1, 26, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (86, 6, 1, 27, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (86, 6, 1, 28, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (86, 6, 1, 29, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (86, 6, 1, 30, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (86, 6, 1, 31, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (86, 6, 1, 32, N'C ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (86, 6, 1, 33, N'C ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (86, 6, 1, 34, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (86, 7, 1, 26, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (86, 7, 1, 27, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (86, 7, 1, 28, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (86, 7, 1, 29, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (86, 7, 1, 30, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (86, 7, 1, 31, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (86, 7, 1, 32, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (86, 7, 1, 33, N'C ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (86, 7, 1, 34, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (99, 5, 2, 60, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (99, 5, 2, 61, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (99, 5, 2, 62, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (99, 5, 2, 63, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (99, 5, 2, 65, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (99, 5, 2, 66, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (99, 5, 2, 67, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (99, 6, 2, 60, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (99, 6, 2, 61, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (99, 6, 2, 62, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (99, 6, 2, 63, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (99, 6, 2, 65, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (99, 6, 2, 66, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (99, 6, 2, 67, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (99, 7, 2, 60, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (99, 7, 2, 61, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (99, 7, 2, 62, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (99, 7, 2, 63, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (99, 7, 2, 65, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (99, 7, 2, 66, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (99, 7, 2, 67, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (100, 5, 2, 60, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (100, 5, 2, 61, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (100, 5, 2, 62, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (100, 5, 2, 63, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (100, 5, 2, 65, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (100, 5, 2, 66, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (100, 5, 2, 67, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (100, 6, 2, 60, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (100, 6, 2, 61, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (100, 6, 2, 62, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (100, 6, 2, 63, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (100, 6, 2, 65, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (100, 6, 2, 66, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (100, 6, 2, 67, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (100, 7, 2, 60, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (100, 7, 2, 61, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (100, 7, 2, 62, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (100, 7, 2, 63, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (100, 7, 2, 65, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (100, 7, 2, 66, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (100, 7, 2, 67, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (101, 5, 2, 60, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (101, 5, 2, 61, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (101, 5, 2, 62, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (101, 5, 2, 63, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (101, 5, 2, 65, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (101, 5, 2, 66, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (101, 5, 2, 67, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (101, 6, 2, 60, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (101, 6, 2, 61, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (101, 6, 2, 62, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (101, 6, 2, 63, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (101, 6, 2, 65, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (101, 6, 2, 66, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (101, 6, 2, 67, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (101, 7, 2, 60, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (101, 7, 2, 61, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (101, 7, 2, 62, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (101, 7, 2, 63, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (101, 7, 2, 65, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (101, 7, 2, 66, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (101, 7, 2, 67, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (102, 5, 2, 60, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (102, 5, 2, 61, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (102, 5, 2, 62, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (102, 5, 2, 63, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (102, 5, 2, 65, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (102, 5, 2, 66, N'B ')
GO
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (102, 5, 2, 67, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (102, 6, 2, 60, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (102, 6, 2, 61, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (102, 6, 2, 62, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (102, 6, 2, 63, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (102, 6, 2, 65, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (102, 6, 2, 66, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (102, 6, 2, 67, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (102, 7, 2, 60, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (102, 7, 2, 61, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (102, 7, 2, 62, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (102, 7, 2, 63, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (102, 7, 2, 65, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (102, 7, 2, 66, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (102, 7, 2, 67, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (113, 5, 3, 68, N'B+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (113, 5, 3, 69, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (113, 5, 3, 70, N'C+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (113, 5, 3, 71, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (113, 5, 3, 72, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (113, 5, 3, 73, N'B+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (113, 5, 3, 74, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (113, 5, 3, 75, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (113, 6, 3, 68, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (113, 6, 3, 69, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (113, 6, 3, 70, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (113, 6, 3, 71, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (113, 6, 3, 72, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (113, 6, 3, 73, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (113, 6, 3, 74, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (113, 6, 3, 75, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (113, 7, 3, 68, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (113, 7, 3, 69, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (113, 7, 3, 70, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (113, 7, 3, 71, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (113, 7, 3, 72, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (113, 7, 3, 73, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (113, 7, 3, 74, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (113, 7, 3, 75, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (114, 5, 3, 68, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (114, 5, 3, 69, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (114, 5, 3, 70, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (114, 5, 3, 71, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (114, 5, 3, 72, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (114, 5, 3, 73, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (114, 5, 3, 74, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (114, 5, 3, 75, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (114, 6, 3, 68, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (114, 6, 3, 69, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (114, 6, 3, 70, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (114, 6, 3, 71, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (114, 6, 3, 72, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (114, 6, 3, 73, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (114, 6, 3, 74, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (114, 6, 3, 75, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (114, 7, 3, 68, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (114, 7, 3, 69, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (114, 7, 3, 70, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (114, 7, 3, 71, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (114, 7, 3, 72, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (114, 7, 3, 73, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (114, 7, 3, 74, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (114, 7, 3, 75, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (115, 5, 3, 68, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (115, 5, 3, 69, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (115, 5, 3, 70, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (115, 5, 3, 71, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (115, 5, 3, 72, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (115, 5, 3, 73, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (115, 5, 3, 74, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (115, 5, 3, 75, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (115, 6, 3, 68, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (115, 6, 3, 69, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (115, 6, 3, 70, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (115, 6, 3, 71, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (115, 6, 3, 72, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (115, 6, 3, 73, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (115, 6, 3, 74, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (115, 6, 3, 75, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (115, 7, 3, 68, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (115, 7, 3, 69, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (115, 7, 3, 70, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (115, 7, 3, 71, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (115, 7, 3, 72, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (115, 7, 3, 73, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (115, 7, 3, 74, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (115, 7, 3, 75, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (116, 5, 3, 68, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (116, 5, 3, 69, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (116, 5, 3, 70, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (116, 5, 3, 71, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (116, 5, 3, 72, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (116, 5, 3, 73, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (116, 5, 3, 74, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (116, 5, 3, 75, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (116, 6, 3, 68, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (116, 6, 3, 69, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (116, 6, 3, 70, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (116, 6, 3, 71, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (116, 6, 3, 72, N'A+')
GO
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (116, 6, 3, 73, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (116, 6, 3, 74, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (116, 6, 3, 75, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (116, 7, 3, 68, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (116, 7, 3, 69, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (116, 7, 3, 70, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (116, 7, 3, 71, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (116, 7, 3, 72, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (116, 7, 3, 73, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (116, 7, 3, 74, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (116, 7, 3, 75, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (117, 5, 3, 68, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (117, 5, 3, 69, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (117, 5, 3, 70, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (117, 5, 3, 71, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (117, 5, 3, 72, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (117, 5, 3, 73, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (117, 5, 3, 74, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (117, 5, 3, 75, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (117, 6, 3, 68, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (117, 6, 3, 69, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (117, 6, 3, 70, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (117, 6, 3, 71, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (117, 6, 3, 72, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (117, 6, 3, 73, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (117, 6, 3, 74, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (117, 6, 3, 75, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (117, 7, 3, 68, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (117, 7, 3, 69, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (117, 7, 3, 70, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (117, 7, 3, 71, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (117, 7, 3, 72, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (117, 7, 3, 73, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (117, 7, 3, 74, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (117, 7, 3, 75, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (118, 5, 3, 68, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (118, 5, 3, 69, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (118, 5, 3, 70, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (118, 5, 3, 71, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (118, 5, 3, 72, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (118, 5, 3, 73, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (118, 5, 3, 74, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (118, 5, 3, 75, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (118, 6, 3, 68, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (118, 6, 3, 69, N'B+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (118, 6, 3, 70, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (118, 6, 3, 71, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (118, 6, 3, 72, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (118, 6, 3, 73, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (118, 6, 3, 74, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (118, 6, 3, 75, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (118, 7, 3, 68, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (118, 7, 3, 69, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (118, 7, 3, 70, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (118, 7, 3, 71, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (118, 7, 3, 72, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (118, 7, 3, 73, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (118, 7, 3, 74, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (118, 7, 3, 75, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (119, 5, 3, 68, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (119, 5, 3, 69, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (119, 5, 3, 70, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (119, 5, 3, 71, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (119, 5, 3, 72, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (119, 5, 3, 73, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (119, 5, 3, 74, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (119, 5, 3, 75, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (119, 6, 3, 68, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (119, 6, 3, 69, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (119, 6, 3, 70, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (119, 6, 3, 71, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (119, 6, 3, 72, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (119, 6, 3, 73, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (119, 6, 3, 74, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (119, 6, 3, 75, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (119, 7, 3, 68, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (119, 7, 3, 69, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (119, 7, 3, 70, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (119, 7, 3, 71, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (119, 7, 3, 72, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (119, 7, 3, 73, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (119, 7, 3, 74, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (119, 7, 3, 75, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (120, 5, 3, 68, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (120, 5, 3, 69, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (120, 5, 3, 70, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (120, 5, 3, 71, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (120, 5, 3, 72, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (120, 5, 3, 73, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (120, 5, 3, 74, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (120, 5, 3, 75, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (120, 6, 3, 68, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (120, 6, 3, 69, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (120, 6, 3, 70, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (120, 6, 3, 71, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (120, 6, 3, 72, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (120, 6, 3, 73, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (120, 6, 3, 74, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (120, 6, 3, 75, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (120, 7, 3, 68, N'A+')
GO
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (120, 7, 3, 69, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (120, 7, 3, 70, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (120, 7, 3, 71, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (120, 7, 3, 72, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (120, 7, 3, 73, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (120, 7, 3, 74, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (120, 7, 3, 75, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (131, 5, 1, 26, N'C ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (131, 5, 1, 27, N'C ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (131, 5, 1, 28, N'C ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (131, 5, 1, 29, N'C ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (131, 5, 1, 30, N'C ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (131, 5, 1, 31, N'C ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (131, 5, 1, 32, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (131, 5, 1, 33, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (131, 5, 1, 34, N'C ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (131, 6, 1, 26, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (131, 6, 1, 27, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (131, 6, 1, 28, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (131, 6, 1, 29, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (131, 6, 1, 30, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (131, 6, 1, 31, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (131, 6, 1, 32, N'C ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (131, 6, 1, 33, N'C ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (131, 6, 1, 34, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (131, 7, 1, 26, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (131, 7, 1, 27, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (131, 7, 1, 28, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (131, 7, 1, 29, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (131, 7, 1, 30, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (131, 7, 1, 31, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (131, 7, 1, 32, N'C ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (131, 7, 1, 33, N'C ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (131, 7, 1, 34, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (132, 8, 1, 26, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (132, 8, 1, 27, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (132, 8, 1, 28, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (132, 8, 1, 29, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (132, 8, 1, 30, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (132, 8, 1, 31, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (132, 8, 1, 32, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (132, 8, 1, 33, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (132, 8, 1, 34, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (132, 9, 1, 26, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (132, 9, 1, 27, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (132, 9, 1, 28, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (132, 9, 1, 29, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (132, 9, 1, 30, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (132, 9, 1, 31, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (132, 9, 1, 32, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (132, 9, 1, 33, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (132, 9, 1, 34, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (132, 10, 1, 26, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (132, 10, 1, 27, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (132, 10, 1, 28, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (132, 10, 1, 29, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (132, 10, 1, 30, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (132, 10, 1, 31, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (132, 10, 1, 32, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (132, 10, 1, 33, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (132, 10, 1, 34, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (133, 8, 1, 26, N'C ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (133, 8, 1, 27, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (133, 8, 1, 28, N'C ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (133, 8, 1, 29, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (133, 8, 1, 30, N'C ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (133, 8, 1, 31, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (133, 8, 1, 32, N'C ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (133, 8, 1, 33, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (133, 8, 1, 34, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (133, 9, 1, 26, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (133, 9, 1, 27, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (133, 9, 1, 28, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (133, 9, 1, 29, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (133, 9, 1, 30, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (133, 9, 1, 31, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (133, 9, 1, 32, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (133, 9, 1, 33, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (133, 9, 1, 34, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (133, 10, 1, 26, N'D ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (133, 10, 1, 27, N'D ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (133, 10, 1, 28, N'D ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (133, 10, 1, 29, N'D ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (133, 10, 1, 30, N'D ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (133, 10, 1, 31, N'D ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (133, 10, 1, 32, N'D ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (133, 10, 1, 33, N'D ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (133, 10, 1, 34, N'D ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (134, 8, 1, 26, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (134, 8, 1, 27, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (134, 8, 1, 28, N'C ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (134, 8, 1, 29, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (134, 8, 1, 30, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (134, 8, 1, 31, N'B+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (134, 8, 1, 32, N'C ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (134, 8, 1, 33, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (134, 8, 1, 34, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (134, 9, 1, 26, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (134, 9, 1, 27, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (134, 9, 1, 28, N'A ')
GO
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (134, 9, 1, 29, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (134, 9, 1, 30, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (134, 9, 1, 31, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (134, 9, 1, 32, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (134, 9, 1, 33, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (134, 9, 1, 34, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (134, 10, 1, 26, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (134, 10, 1, 27, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (134, 10, 1, 28, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (134, 10, 1, 29, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (134, 10, 1, 30, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (134, 10, 1, 31, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (134, 10, 1, 32, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (134, 10, 1, 33, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (134, 10, 1, 34, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (135, 8, 1, 26, N'C ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (135, 8, 1, 27, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (135, 8, 1, 28, N'C ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (135, 8, 1, 29, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (135, 8, 1, 30, N'C ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (135, 8, 1, 31, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (135, 8, 1, 32, N'C ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (135, 8, 1, 33, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (135, 8, 1, 34, N'C ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (135, 9, 1, 26, N'C ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (135, 9, 1, 27, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (135, 9, 1, 28, N'C ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (135, 9, 1, 29, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (135, 9, 1, 30, N'C ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (135, 9, 1, 31, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (135, 9, 1, 32, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (135, 9, 1, 33, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (135, 9, 1, 34, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (135, 10, 1, 26, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (135, 10, 1, 27, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (135, 10, 1, 28, N'C+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (135, 10, 1, 29, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (135, 10, 1, 30, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (135, 10, 1, 31, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (135, 10, 1, 32, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (135, 10, 1, 33, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (135, 10, 1, 34, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (146, 8, 2, 60, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (146, 8, 2, 61, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (146, 8, 2, 62, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (146, 8, 2, 63, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (146, 8, 2, 65, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (146, 8, 2, 66, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (146, 8, 2, 67, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (146, 9, 2, 60, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (146, 9, 2, 61, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (146, 9, 2, 62, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (146, 9, 2, 63, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (146, 9, 2, 65, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (146, 9, 2, 66, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (146, 9, 2, 67, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (146, 10, 2, 60, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (146, 10, 2, 61, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (146, 10, 2, 62, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (146, 10, 2, 63, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (146, 10, 2, 65, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (146, 10, 2, 66, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (146, 10, 2, 67, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (147, 8, 2, 60, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (147, 8, 2, 61, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (147, 8, 2, 62, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (147, 8, 2, 63, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (147, 8, 2, 65, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (147, 8, 2, 66, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (147, 8, 2, 67, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (147, 9, 2, 60, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (147, 9, 2, 61, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (147, 9, 2, 62, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (147, 9, 2, 63, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (147, 9, 2, 65, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (147, 9, 2, 66, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (147, 9, 2, 67, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (147, 10, 2, 60, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (147, 10, 2, 61, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (147, 10, 2, 62, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (147, 10, 2, 63, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (147, 10, 2, 65, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (147, 10, 2, 66, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (147, 10, 2, 67, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (148, 8, 2, 60, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (148, 8, 2, 61, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (148, 8, 2, 62, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (148, 8, 2, 63, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (148, 8, 2, 65, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (148, 8, 2, 66, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (148, 8, 2, 67, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (148, 9, 2, 60, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (148, 9, 2, 61, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (148, 9, 2, 62, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (148, 9, 2, 63, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (148, 9, 2, 65, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (148, 9, 2, 66, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (148, 9, 2, 67, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (148, 10, 2, 60, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (148, 10, 2, 61, N'A+')
GO
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (148, 10, 2, 62, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (148, 10, 2, 63, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (148, 10, 2, 65, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (148, 10, 2, 66, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (148, 10, 2, 67, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (160, 8, 3, 68, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (160, 8, 3, 69, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (160, 8, 3, 70, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (160, 8, 3, 71, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (160, 8, 3, 72, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (160, 8, 3, 73, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (160, 8, 3, 74, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (160, 8, 3, 75, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (160, 9, 3, 68, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (160, 9, 3, 69, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (160, 9, 3, 70, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (160, 9, 3, 71, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (160, 9, 3, 72, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (160, 9, 3, 73, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (160, 9, 3, 74, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (160, 9, 3, 75, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (160, 10, 3, 68, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (160, 10, 3, 69, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (160, 10, 3, 70, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (160, 10, 3, 71, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (160, 10, 3, 72, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (160, 10, 3, 73, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (160, 10, 3, 74, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (160, 10, 3, 75, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (161, 8, 3, 68, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (161, 8, 3, 69, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (161, 8, 3, 70, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (161, 8, 3, 71, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (161, 8, 3, 72, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (161, 8, 3, 73, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (161, 8, 3, 74, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (161, 8, 3, 75, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (161, 9, 3, 68, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (161, 9, 3, 69, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (161, 9, 3, 70, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (161, 9, 3, 71, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (161, 9, 3, 72, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (161, 9, 3, 73, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (161, 9, 3, 74, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (161, 9, 3, 75, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (161, 10, 3, 68, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (161, 10, 3, 69, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (161, 10, 3, 70, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (161, 10, 3, 71, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (161, 10, 3, 72, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (161, 10, 3, 73, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (161, 10, 3, 74, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (161, 10, 3, 75, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (162, 8, 3, 68, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (162, 8, 3, 69, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (162, 8, 3, 70, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (162, 8, 3, 71, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (162, 8, 3, 72, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (162, 8, 3, 73, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (162, 8, 3, 74, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (162, 8, 3, 75, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (162, 9, 3, 68, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (162, 9, 3, 69, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (162, 9, 3, 70, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (162, 9, 3, 71, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (162, 9, 3, 72, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (162, 9, 3, 73, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (162, 9, 3, 74, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (162, 9, 3, 75, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (162, 10, 3, 68, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (162, 10, 3, 69, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (162, 10, 3, 70, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (162, 10, 3, 71, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (162, 10, 3, 72, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (162, 10, 3, 73, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (162, 10, 3, 74, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (162, 10, 3, 75, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (163, 8, 3, 68, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (163, 8, 3, 69, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (163, 8, 3, 70, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (163, 8, 3, 71, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (163, 8, 3, 72, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (163, 8, 3, 73, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (163, 8, 3, 74, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (163, 8, 3, 75, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (163, 9, 3, 68, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (163, 9, 3, 69, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (163, 9, 3, 70, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (163, 9, 3, 71, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (163, 9, 3, 72, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (163, 9, 3, 73, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (163, 9, 3, 74, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (163, 9, 3, 75, N'A ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (163, 10, 3, 68, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (163, 10, 3, 69, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (163, 10, 3, 70, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (163, 10, 3, 71, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (163, 10, 3, 72, N'A+')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (163, 10, 3, 73, N'B ')
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (163, 10, 3, 74, N'A ')
GO
INSERT [dbo].[StudentExams] ([StudentId], [ExaminationId], [ClassId], [SubjectId], [Grade]) VALUES (163, 10, 3, 75, N'A ')
INSERT [dbo].[StudentExtraActivities] ([StudentId], [ActivitiesYear], [ExaminationId], [SchoolDays], [Present_Days], [Reading_And_Writing_Skill], [Recognition_of_Letter], [English], [Nepali], [Copying_Skill], [Students_Academic_Attitude], [Concentration], [Co-operation], [Memory], [Curiosity], [Understanding], [Student_Department], [Conduct], [Neatness_And_Tidiness], [Punctuality], [Politeness], [Height_And_Weight], [Extra_Curricular_Activities], [Drill/P.T], [Dance], [Rhymes]) VALUES (1, N'2073', 1, 240, 233, N'', N'', N'A', N'A', N'A', N'', N'A', N'A', N'A', N'A', N'A', N'', N'GOOD', N'A', N'A', N'A', N'3F6"/18KG', N'', N'A', N'B', N'B')
INSERT [dbo].[StudentExtraActivities] ([StudentId], [ActivitiesYear], [ExaminationId], [SchoolDays], [Present_Days], [Reading_And_Writing_Skill], [Recognition_of_Letter], [English], [Nepali], [Copying_Skill], [Students_Academic_Attitude], [Concentration], [Co-operation], [Memory], [Curiosity], [Understanding], [Student_Department], [Conduct], [Neatness_And_Tidiness], [Punctuality], [Politeness], [Height_And_Weight], [Extra_Curricular_Activities], [Drill/P.T], [Dance], [Rhymes]) VALUES (1, N'2073', 2, 240, 233, N'', N'', N'A', N'A', N'A', N'', N'A', N'A', N'A', N'A', N'A', N'', N'GOOD', N'A', N'A', N'A', N'3F6"/18KG', N'', N'A', N'B', N'B')
INSERT [dbo].[StudentExtraActivities] ([StudentId], [ActivitiesYear], [ExaminationId], [SchoolDays], [Present_Days], [Reading_And_Writing_Skill], [Recognition_of_Letter], [English], [Nepali], [Copying_Skill], [Students_Academic_Attitude], [Concentration], [Co-operation], [Memory], [Curiosity], [Understanding], [Student_Department], [Conduct], [Neatness_And_Tidiness], [Punctuality], [Politeness], [Height_And_Weight], [Extra_Curricular_Activities], [Drill/P.T], [Dance], [Rhymes]) VALUES (2, N'2073', 1, 240, 228, N'', N'', N'A', N'A', N'A', N'', N'A', N'B', N'A+', N'A', N'A', N'', N'GOOD', N'A', N'A', N'A', N'3F4"/16KG', N'', N'A', N'A', N'A')
INSERT [dbo].[StudentExtraActivities] ([StudentId], [ActivitiesYear], [ExaminationId], [SchoolDays], [Present_Days], [Reading_And_Writing_Skill], [Recognition_of_Letter], [English], [Nepali], [Copying_Skill], [Students_Academic_Attitude], [Concentration], [Co-operation], [Memory], [Curiosity], [Understanding], [Student_Department], [Conduct], [Neatness_And_Tidiness], [Punctuality], [Politeness], [Height_And_Weight], [Extra_Curricular_Activities], [Drill/P.T], [Dance], [Rhymes]) VALUES (2, N'2073', 2, 240, 228, N'', N'', N'A', N'A', N'A', N'', N'A', N'B', N'A+', N'A', N'A', N'', N'GOOD', N'A', N'A', N'A', N'3F4"/16KG', N'', N'A', N'A', N'A')
INSERT [dbo].[StudentExtraActivities] ([StudentId], [ActivitiesYear], [ExaminationId], [SchoolDays], [Present_Days], [Reading_And_Writing_Skill], [Recognition_of_Letter], [English], [Nepali], [Copying_Skill], [Students_Academic_Attitude], [Concentration], [Co-operation], [Memory], [Curiosity], [Understanding], [Student_Department], [Conduct], [Neatness_And_Tidiness], [Punctuality], [Politeness], [Height_And_Weight], [Extra_Curricular_Activities], [Drill/P.T], [Dance], [Rhymes]) VALUES (3, N'2073', 1, 240, 220, N'', N'', N'A', N'A', N'A', N'', N'A', N'A', N'A', N'A', N'A', N'', N'GOOD', N'A', N'A', N'A', N'3F2"/14KG', N'', N'A', N'B', N'A')
INSERT [dbo].[StudentExtraActivities] ([StudentId], [ActivitiesYear], [ExaminationId], [SchoolDays], [Present_Days], [Reading_And_Writing_Skill], [Recognition_of_Letter], [English], [Nepali], [Copying_Skill], [Students_Academic_Attitude], [Concentration], [Co-operation], [Memory], [Curiosity], [Understanding], [Student_Department], [Conduct], [Neatness_And_Tidiness], [Punctuality], [Politeness], [Height_And_Weight], [Extra_Curricular_Activities], [Drill/P.T], [Dance], [Rhymes]) VALUES (3, N'2073', 2, 240, 220, N'', N'', N'A', N'A', N'A', N'', N'A', N'A', N'A', N'A', N'A', N'', N'GOOD', N'A', N'A', N'A', N'3F2"/14KG', N'', N'A', N'B', N'A')
INSERT [dbo].[StudentExtraActivities] ([StudentId], [ActivitiesYear], [ExaminationId], [SchoolDays], [Present_Days], [Reading_And_Writing_Skill], [Recognition_of_Letter], [English], [Nepali], [Copying_Skill], [Students_Academic_Attitude], [Concentration], [Co-operation], [Memory], [Curiosity], [Understanding], [Student_Department], [Conduct], [Neatness_And_Tidiness], [Punctuality], [Politeness], [Height_And_Weight], [Extra_Curricular_Activities], [Drill/P.T], [Dance], [Rhymes]) VALUES (4, N'2073', 1, 240, 226, N'', N'', N'A', N'A', N'A', N'', N'A', N'A', N'A+', N'A', N'A', N'', N'GOOD', N'A', N'A', N'A', N'3F4"/19KG', N'', N'A', N'A', N'A')
INSERT [dbo].[StudentExtraActivities] ([StudentId], [ActivitiesYear], [ExaminationId], [SchoolDays], [Present_Days], [Reading_And_Writing_Skill], [Recognition_of_Letter], [English], [Nepali], [Copying_Skill], [Students_Academic_Attitude], [Concentration], [Co-operation], [Memory], [Curiosity], [Understanding], [Student_Department], [Conduct], [Neatness_And_Tidiness], [Punctuality], [Politeness], [Height_And_Weight], [Extra_Curricular_Activities], [Drill/P.T], [Dance], [Rhymes]) VALUES (4, N'2073', 2, 240, 226, N'', N'', N'A', N'A', N'A', N'', N'A', N'A', N'A+', N'A', N'A', N'', N'GOOD', N'A', N'A', N'A', N'3F4"/19KG', N'', N'A', N'A', N'A')
INSERT [dbo].[StudentExtraActivities] ([StudentId], [ActivitiesYear], [ExaminationId], [SchoolDays], [Present_Days], [Reading_And_Writing_Skill], [Recognition_of_Letter], [English], [Nepali], [Copying_Skill], [Students_Academic_Attitude], [Concentration], [Co-operation], [Memory], [Curiosity], [Understanding], [Student_Department], [Conduct], [Neatness_And_Tidiness], [Punctuality], [Politeness], [Height_And_Weight], [Extra_Curricular_Activities], [Drill/P.T], [Dance], [Rhymes]) VALUES (5, N'2073', 1, 240, 229, N'', N'', N'A', N'A', N'A', N'', N'A', N'A', N'A', N'A', N'A', N'', N'GOOD', N'A', N'A', N'A', N'3F3.5"/16KG', N'', N'A', N'A', N'A')
INSERT [dbo].[StudentExtraActivities] ([StudentId], [ActivitiesYear], [ExaminationId], [SchoolDays], [Present_Days], [Reading_And_Writing_Skill], [Recognition_of_Letter], [English], [Nepali], [Copying_Skill], [Students_Academic_Attitude], [Concentration], [Co-operation], [Memory], [Curiosity], [Understanding], [Student_Department], [Conduct], [Neatness_And_Tidiness], [Punctuality], [Politeness], [Height_And_Weight], [Extra_Curricular_Activities], [Drill/P.T], [Dance], [Rhymes]) VALUES (5, N'2073', 2, 240, 229, N'', N'', N'A', N'A', N'A', N'', N'A', N'A', N'A', N'A', N'A', N'', N'GOOD', N'A', N'A', N'A', N'3F3.5"/16KG', N'', N'A', N'A', N'A')
INSERT [dbo].[StudentExtraActivities] ([StudentId], [ActivitiesYear], [ExaminationId], [SchoolDays], [Present_Days], [Reading_And_Writing_Skill], [Recognition_of_Letter], [English], [Nepali], [Copying_Skill], [Students_Academic_Attitude], [Concentration], [Co-operation], [Memory], [Curiosity], [Understanding], [Student_Department], [Conduct], [Neatness_And_Tidiness], [Punctuality], [Politeness], [Height_And_Weight], [Extra_Curricular_Activities], [Drill/P.T], [Dance], [Rhymes]) VALUES (6, N'2073', 1, 240, 218, N'', N'', N'A', N'A', N'A', N'', N'A', N'A', N'A', N'A', N'A', N'', N'GOOD', N'A', N'A', N'A', N'3F3.5"/14KG', N'', N'A', N'B', N'A')
INSERT [dbo].[StudentExtraActivities] ([StudentId], [ActivitiesYear], [ExaminationId], [SchoolDays], [Present_Days], [Reading_And_Writing_Skill], [Recognition_of_Letter], [English], [Nepali], [Copying_Skill], [Students_Academic_Attitude], [Concentration], [Co-operation], [Memory], [Curiosity], [Understanding], [Student_Department], [Conduct], [Neatness_And_Tidiness], [Punctuality], [Politeness], [Height_And_Weight], [Extra_Curricular_Activities], [Drill/P.T], [Dance], [Rhymes]) VALUES (6, N'2073', 2, 240, 218, N'', N'', N'A', N'A', N'A', N'', N'A', N'A', N'A', N'A', N'A', N'', N'GOOD', N'A', N'A', N'A', N'3F3.5"/14KG', N'', N'A', N'B', N'A')
INSERT [dbo].[StudentExtraActivities] ([StudentId], [ActivitiesYear], [ExaminationId], [SchoolDays], [Present_Days], [Reading_And_Writing_Skill], [Recognition_of_Letter], [English], [Nepali], [Copying_Skill], [Students_Academic_Attitude], [Concentration], [Co-operation], [Memory], [Curiosity], [Understanding], [Student_Department], [Conduct], [Neatness_And_Tidiness], [Punctuality], [Politeness], [Height_And_Weight], [Extra_Curricular_Activities], [Drill/P.T], [Dance], [Rhymes]) VALUES (7, N'2073', 1, 240, 203, N'', N'', N'A', N'A', N'A', N'', N'A', N'A', N'A', N'A', N'A', N'', N'GOOD', N'A', N'A', N'A', N'3F0.5"/14KG', N'', N'A', N'A', N'A')
INSERT [dbo].[StudentExtraActivities] ([StudentId], [ActivitiesYear], [ExaminationId], [SchoolDays], [Present_Days], [Reading_And_Writing_Skill], [Recognition_of_Letter], [English], [Nepali], [Copying_Skill], [Students_Academic_Attitude], [Concentration], [Co-operation], [Memory], [Curiosity], [Understanding], [Student_Department], [Conduct], [Neatness_And_Tidiness], [Punctuality], [Politeness], [Height_And_Weight], [Extra_Curricular_Activities], [Drill/P.T], [Dance], [Rhymes]) VALUES (7, N'2073', 2, 240, 203, N'', N'', N'A', N'A', N'A', N'', N'A', N'A', N'A', N'A', N'A', N'', N'GOOD', N'A', N'A', N'A', N'3F0.5"/14KG', N'', N'A', N'A', N'A')
INSERT [dbo].[StudentExtraActivities] ([StudentId], [ActivitiesYear], [ExaminationId], [SchoolDays], [Present_Days], [Reading_And_Writing_Skill], [Recognition_of_Letter], [English], [Nepali], [Copying_Skill], [Students_Academic_Attitude], [Concentration], [Co-operation], [Memory], [Curiosity], [Understanding], [Student_Department], [Conduct], [Neatness_And_Tidiness], [Punctuality], [Politeness], [Height_And_Weight], [Extra_Curricular_Activities], [Drill/P.T], [Dance], [Rhymes]) VALUES (8, N'2073', 1, 240, 192, N'', N'', N'A', N'A', N'A', N'', N'A', N'A', N'A', N'A', N'A', N'', N'GOOD', N'A', N'A', N'A', N'3F5"/18KG', N'', N'A', N'A', N'A')
INSERT [dbo].[StudentExtraActivities] ([StudentId], [ActivitiesYear], [ExaminationId], [SchoolDays], [Present_Days], [Reading_And_Writing_Skill], [Recognition_of_Letter], [English], [Nepali], [Copying_Skill], [Students_Academic_Attitude], [Concentration], [Co-operation], [Memory], [Curiosity], [Understanding], [Student_Department], [Conduct], [Neatness_And_Tidiness], [Punctuality], [Politeness], [Height_And_Weight], [Extra_Curricular_Activities], [Drill/P.T], [Dance], [Rhymes]) VALUES (8, N'2073', 2, 240, 192, N'', N'', N'A', N'A', N'A', N'', N'A', N'A', N'A', N'A', N'A', N'', N'GOOD', N'A', N'A', N'A', N'3F5"/18KG', N'', N'A', N'A', N'A')
INSERT [dbo].[StudentExtraActivities] ([StudentId], [ActivitiesYear], [ExaminationId], [SchoolDays], [Present_Days], [Reading_And_Writing_Skill], [Recognition_of_Letter], [English], [Nepali], [Copying_Skill], [Students_Academic_Attitude], [Concentration], [Co-operation], [Memory], [Curiosity], [Understanding], [Student_Department], [Conduct], [Neatness_And_Tidiness], [Punctuality], [Politeness], [Height_And_Weight], [Extra_Curricular_Activities], [Drill/P.T], [Dance], [Rhymes]) VALUES (10, N'2073', 1, 70, 70, N'', N'', N'A', N'B', N'A', N'', N'B', N'B', N'B', N'B', N'B', N'', N'GOOD', N'A', N'A', N'A', N'3F6"/17KG', N'', N'B', N'B', N'A')
INSERT [dbo].[StudentExtraActivities] ([StudentId], [ActivitiesYear], [ExaminationId], [SchoolDays], [Present_Days], [Reading_And_Writing_Skill], [Recognition_of_Letter], [English], [Nepali], [Copying_Skill], [Students_Academic_Attitude], [Concentration], [Co-operation], [Memory], [Curiosity], [Understanding], [Student_Department], [Conduct], [Neatness_And_Tidiness], [Punctuality], [Politeness], [Height_And_Weight], [Extra_Curricular_Activities], [Drill/P.T], [Dance], [Rhymes]) VALUES (10, N'2073', 2, 240, 233, N'', N'', N'A', N'A', N'A', N'', N'A', N'A', N'A', N'A', N'A', N'', N'GOOD', N'A', N'A', N'A', N'3F7"/18KG', N'', N'A', N'B', N'A')
INSERT [dbo].[StudentExtraActivities] ([StudentId], [ActivitiesYear], [ExaminationId], [SchoolDays], [Present_Days], [Reading_And_Writing_Skill], [Recognition_of_Letter], [English], [Nepali], [Copying_Skill], [Students_Academic_Attitude], [Concentration], [Co-operation], [Memory], [Curiosity], [Understanding], [Student_Department], [Conduct], [Neatness_And_Tidiness], [Punctuality], [Politeness], [Height_And_Weight], [Extra_Curricular_Activities], [Drill/P.T], [Dance], [Rhymes]) VALUES (11, N'2073', 1, 70, 67, N'', N'', N'A', N'A', N'A', N'', N'A', N'A', N'A', N'B', N'A', N'', N'GOOD', N'A', N'A', N'A', N'3F2"/15KG', N'', N'A', N'A', N'A')
INSERT [dbo].[StudentExtraActivities] ([StudentId], [ActivitiesYear], [ExaminationId], [SchoolDays], [Present_Days], [Reading_And_Writing_Skill], [Recognition_of_Letter], [English], [Nepali], [Copying_Skill], [Students_Academic_Attitude], [Concentration], [Co-operation], [Memory], [Curiosity], [Understanding], [Student_Department], [Conduct], [Neatness_And_Tidiness], [Punctuality], [Politeness], [Height_And_Weight], [Extra_Curricular_Activities], [Drill/P.T], [Dance], [Rhymes]) VALUES (11, N'2073', 2, 240, 227, N'', N'', N'A', N'A', N'A', N'', N'A', N'A', N'A', N'A', N'A', N'', N'GOOD', N'A', N'A', N'A', N'3F4"/17KG', N'', N'A', N'A', N'A')
INSERT [dbo].[StudentExtraActivities] ([StudentId], [ActivitiesYear], [ExaminationId], [SchoolDays], [Present_Days], [Reading_And_Writing_Skill], [Recognition_of_Letter], [English], [Nepali], [Copying_Skill], [Students_Academic_Attitude], [Concentration], [Co-operation], [Memory], [Curiosity], [Understanding], [Student_Department], [Conduct], [Neatness_And_Tidiness], [Punctuality], [Politeness], [Height_And_Weight], [Extra_Curricular_Activities], [Drill/P.T], [Dance], [Rhymes]) VALUES (12, N'2073', 1, 70, 66, N'', N'', N'A', N'A', N'A', N'', N'B', N'B', N'A', N'B', N'A', N'', N'GOOD', N'A', N'A', N'B', N'3F3"/15KG', N'', N'A', N'A', N'A')
INSERT [dbo].[StudentExtraActivities] ([StudentId], [ActivitiesYear], [ExaminationId], [SchoolDays], [Present_Days], [Reading_And_Writing_Skill], [Recognition_of_Letter], [English], [Nepali], [Copying_Skill], [Students_Academic_Attitude], [Concentration], [Co-operation], [Memory], [Curiosity], [Understanding], [Student_Department], [Conduct], [Neatness_And_Tidiness], [Punctuality], [Politeness], [Height_And_Weight], [Extra_Curricular_Activities], [Drill/P.T], [Dance], [Rhymes]) VALUES (12, N'2073', 2, 240, 231, N'', N'', N'A', N'A', N'A', N'', N'A', N'A', N'A', N'A', N'A', N'', N'GOOD', N'A', N'A', N'A', N'3F4"/17KG', N'', N'A', N'B', N'A')
INSERT [dbo].[StudentExtraActivities] ([StudentId], [ActivitiesYear], [ExaminationId], [SchoolDays], [Present_Days], [Reading_And_Writing_Skill], [Recognition_of_Letter], [English], [Nepali], [Copying_Skill], [Students_Academic_Attitude], [Concentration], [Co-operation], [Memory], [Curiosity], [Understanding], [Student_Department], [Conduct], [Neatness_And_Tidiness], [Punctuality], [Politeness], [Height_And_Weight], [Extra_Curricular_Activities], [Drill/P.T], [Dance], [Rhymes]) VALUES (13, N'2073', 1, 70, 65, N'', N'', N'A', N'A', N'A', N'', N'A', N'A', N'A', N'A', N'A', N'', N'GOOD', N'A', N'A', N'A', N'3F7"/16KG', N'', N'A', N'B', N'A')
INSERT [dbo].[StudentExtraActivities] ([StudentId], [ActivitiesYear], [ExaminationId], [SchoolDays], [Present_Days], [Reading_And_Writing_Skill], [Recognition_of_Letter], [English], [Nepali], [Copying_Skill], [Students_Academic_Attitude], [Concentration], [Co-operation], [Memory], [Curiosity], [Understanding], [Student_Department], [Conduct], [Neatness_And_Tidiness], [Punctuality], [Politeness], [Height_And_Weight], [Extra_Curricular_Activities], [Drill/P.T], [Dance], [Rhymes]) VALUES (13, N'2073', 2, 240, 231, N'', N'', N'A', N'A', N'A', N'', N'A', N'A', N'A', N'A', N'A', N'', N'GOOD', N'A', N'A', N'A', N'3F8"/18KG', N'', N'A', N'A', N'A')
INSERT [dbo].[StudentExtraActivities] ([StudentId], [ActivitiesYear], [ExaminationId], [SchoolDays], [Present_Days], [Reading_And_Writing_Skill], [Recognition_of_Letter], [English], [Nepali], [Copying_Skill], [Students_Academic_Attitude], [Concentration], [Co-operation], [Memory], [Curiosity], [Understanding], [Student_Department], [Conduct], [Neatness_And_Tidiness], [Punctuality], [Politeness], [Height_And_Weight], [Extra_Curricular_Activities], [Drill/P.T], [Dance], [Rhymes]) VALUES (14, N'2073', 1, 70, 65, N'', N'', N'B', N'B', N'A', N'', N'B', N'B', N'B', N'B', N'B', N'', N'GOOD', N'A', N'A', N'B', N'3F5"/15KG', N'', N'A', N'B', N'A')
INSERT [dbo].[StudentExtraActivities] ([StudentId], [ActivitiesYear], [ExaminationId], [SchoolDays], [Present_Days], [Reading_And_Writing_Skill], [Recognition_of_Letter], [English], [Nepali], [Copying_Skill], [Students_Academic_Attitude], [Concentration], [Co-operation], [Memory], [Curiosity], [Understanding], [Student_Department], [Conduct], [Neatness_And_Tidiness], [Punctuality], [Politeness], [Height_And_Weight], [Extra_Curricular_Activities], [Drill/P.T], [Dance], [Rhymes]) VALUES (14, N'2073', 2, 240, 228, N'', N'', N'A', N'A', N'A', N'', N'A', N'A', N'B', N'B', N'B', N'', N'GOOD', N'A', N'A', N'A', N'3F7"/17KG', N'', N'A', N'B', N'A')
INSERT [dbo].[StudentExtraActivities] ([StudentId], [ActivitiesYear], [ExaminationId], [SchoolDays], [Present_Days], [Reading_And_Writing_Skill], [Recognition_of_Letter], [English], [Nepali], [Copying_Skill], [Students_Academic_Attitude], [Concentration], [Co-operation], [Memory], [Curiosity], [Understanding], [Student_Department], [Conduct], [Neatness_And_Tidiness], [Punctuality], [Politeness], [Height_And_Weight], [Extra_Curricular_Activities], [Drill/P.T], [Dance], [Rhymes]) VALUES (15, N'2073', 1, 70, 67, N'', N'', N'A', N'B', N'A', N'', N'A', N'A', N'B', N'A', N'A', N'', N'GOOD', N'A', N'A', N'A', N'3F5"/15KG', N'', N'A', N'A', N'A')
INSERT [dbo].[StudentExtraActivities] ([StudentId], [ActivitiesYear], [ExaminationId], [SchoolDays], [Present_Days], [Reading_And_Writing_Skill], [Recognition_of_Letter], [English], [Nepali], [Copying_Skill], [Students_Academic_Attitude], [Concentration], [Co-operation], [Memory], [Curiosity], [Understanding], [Student_Department], [Conduct], [Neatness_And_Tidiness], [Punctuality], [Politeness], [Height_And_Weight], [Extra_Curricular_Activities], [Drill/P.T], [Dance], [Rhymes]) VALUES (15, N'2073', 2, 240, 213, N'', N'', N'A', N'A', N'A', N'', N'A', N'A', N'B', N'B', N'B', N'', N'GOOD', N'A', N'A', N'A', N'3F7"/17KG', N'', N'A', N'A', N'A')
INSERT [dbo].[StudentExtraActivities] ([StudentId], [ActivitiesYear], [ExaminationId], [SchoolDays], [Present_Days], [Reading_And_Writing_Skill], [Recognition_of_Letter], [English], [Nepali], [Copying_Skill], [Students_Academic_Attitude], [Concentration], [Co-operation], [Memory], [Curiosity], [Understanding], [Student_Department], [Conduct], [Neatness_And_Tidiness], [Punctuality], [Politeness], [Height_And_Weight], [Extra_Curricular_Activities], [Drill/P.T], [Dance], [Rhymes]) VALUES (16, N'2073', 1, 70, 63, N'', N'', N'A', N'B', N'A', N'', N'B', N'B', N'B', N'B', N'B', N'', N'GOOD', N'A', N'A', N'A', N'3F5"/16KG', N'', N'B', N'B', N'B')
INSERT [dbo].[StudentExtraActivities] ([StudentId], [ActivitiesYear], [ExaminationId], [SchoolDays], [Present_Days], [Reading_And_Writing_Skill], [Recognition_of_Letter], [English], [Nepali], [Copying_Skill], [Students_Academic_Attitude], [Concentration], [Co-operation], [Memory], [Curiosity], [Understanding], [Student_Department], [Conduct], [Neatness_And_Tidiness], [Punctuality], [Politeness], [Height_And_Weight], [Extra_Curricular_Activities], [Drill/P.T], [Dance], [Rhymes]) VALUES (16, N'2073', 2, 240, 211, N'', N'', N'A', N'A', N'A', N'', N'A', N'A', N'B', N'B', N'B', N'', N'GOOD', N'A', N'A', N'A', N'3F6"/17KG', N'', N'A', N'B', N'A')
INSERT [dbo].[StudentExtraActivities] ([StudentId], [ActivitiesYear], [ExaminationId], [SchoolDays], [Present_Days], [Reading_And_Writing_Skill], [Recognition_of_Letter], [English], [Nepali], [Copying_Skill], [Students_Academic_Attitude], [Concentration], [Co-operation], [Memory], [Curiosity], [Understanding], [Student_Department], [Conduct], [Neatness_And_Tidiness], [Punctuality], [Politeness], [Height_And_Weight], [Extra_Curricular_Activities], [Drill/P.T], [Dance], [Rhymes]) VALUES (17, N'2073', 1, 70, 68, N'', N'', N'A', N'A', N'A', N'', N'A', N'A', N'A', N'A', N'A', N'', N'GOOD', N'A', N'A', N'A', N'3F3"/14KG', N'', N'A', N'B', N'A')
INSERT [dbo].[StudentExtraActivities] ([StudentId], [ActivitiesYear], [ExaminationId], [SchoolDays], [Present_Days], [Reading_And_Writing_Skill], [Recognition_of_Letter], [English], [Nepali], [Copying_Skill], [Students_Academic_Attitude], [Concentration], [Co-operation], [Memory], [Curiosity], [Understanding], [Student_Department], [Conduct], [Neatness_And_Tidiness], [Punctuality], [Politeness], [Height_And_Weight], [Extra_Curricular_Activities], [Drill/P.T], [Dance], [Rhymes]) VALUES (17, N'2073', 2, 240, 231, N'', N'', N'A', N'A', N'A', N'', N'A', N'A', N'A', N'A', N'A', N'', N'GOOD', N'A', N'A', N'A', N'3F4"/16KG', N'', N'A', N'B', N'A')
INSERT [dbo].[StudentExtraActivities] ([StudentId], [ActivitiesYear], [ExaminationId], [SchoolDays], [Present_Days], [Reading_And_Writing_Skill], [Recognition_of_Letter], [English], [Nepali], [Copying_Skill], [Students_Academic_Attitude], [Concentration], [Co-operation], [Memory], [Curiosity], [Understanding], [Student_Department], [Conduct], [Neatness_And_Tidiness], [Punctuality], [Politeness], [Height_And_Weight], [Extra_Curricular_Activities], [Drill/P.T], [Dance], [Rhymes]) VALUES (18, N'2073', 1, 70, 68, N'', N'', N'A', N'A', N'A', N'', N'A', N'A', N'A', N'A', N'A', N'', N'GOOD', N'A', N'A', N'B', N'3F7"/18KG', N'', N'A', N'A', N'A')
INSERT [dbo].[StudentExtraActivities] ([StudentId], [ActivitiesYear], [ExaminationId], [SchoolDays], [Present_Days], [Reading_And_Writing_Skill], [Recognition_of_Letter], [English], [Nepali], [Copying_Skill], [Students_Academic_Attitude], [Concentration], [Co-operation], [Memory], [Curiosity], [Understanding], [Student_Department], [Conduct], [Neatness_And_Tidiness], [Punctuality], [Politeness], [Height_And_Weight], [Extra_Curricular_Activities], [Drill/P.T], [Dance], [Rhymes]) VALUES (18, N'2073', 2, 240, 231, N'', N'', N'A', N'A', N'A', N'', N'A', N'A', N'A', N'A', N'A', N'', N'GOOD', N'A', N'A', N'A', N'3F8"/19KG', N'', N'A', N'A', N'A')
INSERT [dbo].[StudentExtraActivities] ([StudentId], [ActivitiesYear], [ExaminationId], [SchoolDays], [Present_Days], [Reading_And_Writing_Skill], [Recognition_of_Letter], [English], [Nepali], [Copying_Skill], [Students_Academic_Attitude], [Concentration], [Co-operation], [Memory], [Curiosity], [Understanding], [Student_Department], [Conduct], [Neatness_And_Tidiness], [Punctuality], [Politeness], [Height_And_Weight], [Extra_Curricular_Activities], [Drill/P.T], [Dance], [Rhymes]) VALUES (19, N'2073', 1, 70, 68, N'', N'', N'A', N'A', N'A', N'', N'A', N'A', N'A', N'A', N'A', N'', N'GOOD', N'A', N'A', N'A', N'3F7"/23KG', N'', N'A', N'A', N'A')
INSERT [dbo].[StudentExtraActivities] ([StudentId], [ActivitiesYear], [ExaminationId], [SchoolDays], [Present_Days], [Reading_And_Writing_Skill], [Recognition_of_Letter], [English], [Nepali], [Copying_Skill], [Students_Academic_Attitude], [Concentration], [Co-operation], [Memory], [Curiosity], [Understanding], [Student_Department], [Conduct], [Neatness_And_Tidiness], [Punctuality], [Politeness], [Height_And_Weight], [Extra_Curricular_Activities], [Drill/P.T], [Dance], [Rhymes]) VALUES (19, N'2073', 2, 240, 235, N'', N'', N'A', N'A', N'A', N'', N'A', N'A', N'A', N'A', N'A', N'', N'GOOD', N'A', N'A', N'A', N'3F9"/25G', N'', N'A', N'A', N'A')
INSERT [dbo].[StudentExtraActivities] ([StudentId], [ActivitiesYear], [ExaminationId], [SchoolDays], [Present_Days], [Reading_And_Writing_Skill], [Recognition_of_Letter], [English], [Nepali], [Copying_Skill], [Students_Academic_Attitude], [Concentration], [Co-operation], [Memory], [Curiosity], [Understanding], [Student_Department], [Conduct], [Neatness_And_Tidiness], [Punctuality], [Politeness], [Height_And_Weight], [Extra_Curricular_Activities], [Drill/P.T], [Dance], [Rhymes]) VALUES (20, N'2073', 1, 70, 70, N'', N'', N'A', N'A', N'A', N'', N'A', N'A', N'A', N'A', N'A', N'', N'GOOD', N'A', N'A', N'A', N'', N'', N'A', N'A', N'A')
INSERT [dbo].[StudentExtraActivities] ([StudentId], [ActivitiesYear], [ExaminationId], [SchoolDays], [Present_Days], [Reading_And_Writing_Skill], [Recognition_of_Letter], [English], [Nepali], [Copying_Skill], [Students_Academic_Attitude], [Concentration], [Co-operation], [Memory], [Curiosity], [Understanding], [Student_Department], [Conduct], [Neatness_And_Tidiness], [Punctuality], [Politeness], [Height_And_Weight], [Extra_Curricular_Activities], [Drill/P.T], [Dance], [Rhymes]) VALUES (21, N'2073', 1, 70, 70, N'', N'', N'A', N'A', N'A', N'', N'A', N'A', N'A', N'A', N'A', N'', N'GOOD', N'A', N'A', N'A', N'', N'', N'A', N'A', N'A')
INSERT [dbo].[StudentExtraActivities] ([StudentId], [ActivitiesYear], [ExaminationId], [SchoolDays], [Present_Days], [Reading_And_Writing_Skill], [Recognition_of_Letter], [English], [Nepali], [Copying_Skill], [Students_Academic_Attitude], [Concentration], [Co-operation], [Memory], [Curiosity], [Understanding], [Student_Department], [Conduct], [Neatness_And_Tidiness], [Punctuality], [Politeness], [Height_And_Weight], [Extra_Curricular_Activities], [Drill/P.T], [Dance], [Rhymes]) VALUES (22, N'2073', 1, 70, 57, N'', N'', N'A', N'A', N'A', N'', N'A', N'A', N'A', N'A', N'A', N'', N'GOOD', N'A', N'A', N'A', N'3F5"/15KG', N'', N'A', N'B', N'A')
INSERT [dbo].[StudentExtraActivities] ([StudentId], [ActivitiesYear], [ExaminationId], [SchoolDays], [Present_Days], [Reading_And_Writing_Skill], [Recognition_of_Letter], [English], [Nepali], [Copying_Skill], [Students_Academic_Attitude], [Concentration], [Co-operation], [Memory], [Curiosity], [Understanding], [Student_Department], [Conduct], [Neatness_And_Tidiness], [Punctuality], [Politeness], [Height_And_Weight], [Extra_Curricular_Activities], [Drill/P.T], [Dance], [Rhymes]) VALUES (22, N'2073', 2, 240, 216, N'', N'', N'A', N'A', N'A', N'', N'A', N'A', N'A', N'A', N'A', N'', N'GOOD', N'A', N'A', N'A', N'3F7"/17KG', N'', N'A', N'B', N'A')
INSERT [dbo].[StudentExtraActivities] ([StudentId], [ActivitiesYear], [ExaminationId], [SchoolDays], [Present_Days], [Reading_And_Writing_Skill], [Recognition_of_Letter], [English], [Nepali], [Copying_Skill], [Students_Academic_Attitude], [Concentration], [Co-operation], [Memory], [Curiosity], [Understanding], [Student_Department], [Conduct], [Neatness_And_Tidiness], [Punctuality], [Politeness], [Height_And_Weight], [Extra_Curricular_Activities], [Drill/P.T], [Dance], [Rhymes]) VALUES (23, N'2073', 1, 70, 43, N'', N'', N'A', N'B', N'A', N'', N'A', N'A', N'B', N'B', N'A', N'', N'GOOD', N'A', N'A', N'A', N'3F5"/15KG', N'', N'A', N'B', N'A')
INSERT [dbo].[StudentExtraActivities] ([StudentId], [ActivitiesYear], [ExaminationId], [SchoolDays], [Present_Days], [Reading_And_Writing_Skill], [Recognition_of_Letter], [English], [Nepali], [Copying_Skill], [Students_Academic_Attitude], [Concentration], [Co-operation], [Memory], [Curiosity], [Understanding], [Student_Department], [Conduct], [Neatness_And_Tidiness], [Punctuality], [Politeness], [Height_And_Weight], [Extra_Curricular_Activities], [Drill/P.T], [Dance], [Rhymes]) VALUES (23, N'2073', 2, 240, 198, N'', N'', N'A', N'A', N'A', N'', N'A', N'A', N'A', N'A', N'A', N'', N'GOOD', N'A', N'A', N'A', N'3F7"/16KG', N'', N'A', N'B', N'A')
INSERT [dbo].[StudentExtraActivities] ([StudentId], [ActivitiesYear], [ExaminationId], [SchoolDays], [Present_Days], [Reading_And_Writing_Skill], [Recognition_of_Letter], [English], [Nepali], [Copying_Skill], [Students_Academic_Attitude], [Concentration], [Co-operation], [Memory], [Curiosity], [Understanding], [Student_Department], [Conduct], [Neatness_And_Tidiness], [Punctuality], [Politeness], [Height_And_Weight], [Extra_Curricular_Activities], [Drill/P.T], [Dance], [Rhymes]) VALUES (24, N'2073', 1, 70, 69, N'', N'', N'A', N'A', N'A', N'', N'A', N'A', N'A', N'B', N'A', N'', N'GOOD', N'A', N'A', N'A', N'3F7"/18KG', N'', N'B', N'A', N'A')
INSERT [dbo].[StudentExtraActivities] ([StudentId], [ActivitiesYear], [ExaminationId], [SchoolDays], [Present_Days], [Reading_And_Writing_Skill], [Recognition_of_Letter], [English], [Nepali], [Copying_Skill], [Students_Academic_Attitude], [Concentration], [Co-operation], [Memory], [Curiosity], [Understanding], [Student_Department], [Conduct], [Neatness_And_Tidiness], [Punctuality], [Politeness], [Height_And_Weight], [Extra_Curricular_Activities], [Drill/P.T], [Dance], [Rhymes]) VALUES (24, N'2073', 2, 240, 235, N'', N'', N'A', N'A', N'A', N'', N'A', N'A', N'A', N'A', N'A', N'', N'GOOD', N'`A', N'A', N'A', N'3F8"/18KG', N'', N'A', N'A', N'A')
INSERT [dbo].[StudentExtraActivities] ([StudentId], [ActivitiesYear], [ExaminationId], [SchoolDays], [Present_Days], [Reading_And_Writing_Skill], [Recognition_of_Letter], [English], [Nepali], [Copying_Skill], [Students_Academic_Attitude], [Concentration], [Co-operation], [Memory], [Curiosity], [Understanding], [Student_Department], [Conduct], [Neatness_And_Tidiness], [Punctuality], [Politeness], [Height_And_Weight], [Extra_Curricular_Activities], [Drill/P.T], [Dance], [Rhymes]) VALUES (25, N'2073', 1, 70, 64, N'', N'', N'A', N'A', N'A', N'', N'A', N'A', N'A', N'A', N'A', N'', N'GOOD', N'A', N'A', N'A', N'3F3"/15KG', N'', N'B', N'B', N'A')
INSERT [dbo].[StudentExtraActivities] ([StudentId], [ActivitiesYear], [ExaminationId], [SchoolDays], [Present_Days], [Reading_And_Writing_Skill], [Recognition_of_Letter], [English], [Nepali], [Copying_Skill], [Students_Academic_Attitude], [Concentration], [Co-operation], [Memory], [Curiosity], [Understanding], [Student_Department], [Conduct], [Neatness_And_Tidiness], [Punctuality], [Politeness], [Height_And_Weight], [Extra_Curricular_Activities], [Drill/P.T], [Dance], [Rhymes]) VALUES (25, N'2073', 2, 240, 216, N'', N'', N'A', N'A', N'A', N'', N'A', N'A', N'A', N'A', N'A', N'', N'GOOD', N'A', N'A', N'A', N'3F5"/16KG', N'', N'A', N'B', N'A')
INSERT [dbo].[StudentExtraActivities] ([StudentId], [ActivitiesYear], [ExaminationId], [SchoolDays], [Present_Days], [Reading_And_Writing_Skill], [Recognition_of_Letter], [English], [Nepali], [Copying_Skill], [Students_Academic_Attitude], [Concentration], [Co-operation], [Memory], [Curiosity], [Understanding], [Student_Department], [Conduct], [Neatness_And_Tidiness], [Punctuality], [Politeness], [Height_And_Weight], [Extra_Curricular_Activities], [Drill/P.T], [Dance], [Rhymes]) VALUES (26, N'2073', 1, 70, 70, N'', N'', N'A', N'A', N'A', N'', N'A', N'A', N'A', N'A', N'A', N'', N'GOOD', N'A', N'A', N'A', N'3F4"/16KG', N'', N'A', N'A', N'A')
INSERT [dbo].[StudentExtraActivities] ([StudentId], [ActivitiesYear], [ExaminationId], [SchoolDays], [Present_Days], [Reading_And_Writing_Skill], [Recognition_of_Letter], [English], [Nepali], [Copying_Skill], [Students_Academic_Attitude], [Concentration], [Co-operation], [Memory], [Curiosity], [Understanding], [Student_Department], [Conduct], [Neatness_And_Tidiness], [Punctuality], [Politeness], [Height_And_Weight], [Extra_Curricular_Activities], [Drill/P.T], [Dance], [Rhymes]) VALUES (26, N'2073', 2, 240, 232, N'', N'', N'A', N'A', N'A', N'', N'A', N'A', N'A', N'A', N'A', N'', N'GOOD', N'A', N'A', N'A', N'3F6"/16KG', N'', N'A', N'B', N'A')
INSERT [dbo].[StudentExtraActivities] ([StudentId], [ActivitiesYear], [ExaminationId], [SchoolDays], [Present_Days], [Reading_And_Writing_Skill], [Recognition_of_Letter], [English], [Nepali], [Copying_Skill], [Students_Academic_Attitude], [Concentration], [Co-operation], [Memory], [Curiosity], [Understanding], [Student_Department], [Conduct], [Neatness_And_Tidiness], [Punctuality], [Politeness], [Height_And_Weight], [Extra_Curricular_Activities], [Drill/P.T], [Dance], [Rhymes]) VALUES (27, N'2073', 1, 70, 67, N'', N'', N'A', N'A', N'A', N'', N'A', N'A', N'A', N'A', N'A', N'', N'GOOD', N'A', N'A', N'A', N'4F3"/35KG', N'', N'A', N'A', N'A')
INSERT [dbo].[StudentExtraActivities] ([StudentId], [ActivitiesYear], [ExaminationId], [SchoolDays], [Present_Days], [Reading_And_Writing_Skill], [Recognition_of_Letter], [English], [Nepali], [Copying_Skill], [Students_Academic_Attitude], [Concentration], [Co-operation], [Memory], [Curiosity], [Understanding], [Student_Department], [Conduct], [Neatness_And_Tidiness], [Punctuality], [Politeness], [Height_And_Weight], [Extra_Curricular_Activities], [Drill/P.T], [Dance], [Rhymes]) VALUES (27, N'2073', 2, 240, 223, N'', N'', N'A', N'A', N'A', N'', N'A', N'A', N'A', N'A', N'A', N'', N'GOOD', N'A', N'A', N'A', N'4F4"/36KG', N'', N'A', N'B', N'A')
INSERT [dbo].[StudentExtraActivities] ([StudentId], [ActivitiesYear], [ExaminationId], [SchoolDays], [Present_Days], [Reading_And_Writing_Skill], [Recognition_of_Letter], [English], [Nepali], [Copying_Skill], [Students_Academic_Attitude], [Concentration], [Co-operation], [Memory], [Curiosity], [Understanding], [Student_Department], [Conduct], [Neatness_And_Tidiness], [Punctuality], [Politeness], [Height_And_Weight], [Extra_Curricular_Activities], [Drill/P.T], [Dance], [Rhymes]) VALUES (28, N'2073', 1, 70, 64, N'', N'', N'A', N'A', N'A', N'', N'A', N'A', N'A', N'B', N'A', N'', N'GOOD', N'B', N'A', N'A', N'3F7"/16KG', N'', N'A', N'A', N'A')
INSERT [dbo].[StudentExtraActivities] ([StudentId], [ActivitiesYear], [ExaminationId], [SchoolDays], [Present_Days], [Reading_And_Writing_Skill], [Recognition_of_Letter], [English], [Nepali], [Copying_Skill], [Students_Academic_Attitude], [Concentration], [Co-operation], [Memory], [Curiosity], [Understanding], [Student_Department], [Conduct], [Neatness_And_Tidiness], [Punctuality], [Politeness], [Height_And_Weight], [Extra_Curricular_Activities], [Drill/P.T], [Dance], [Rhymes]) VALUES (28, N'2073', 2, 240, 220, N'', N'', N'A', N'A', N'A', N'', N'A', N'A', N'A', N'A', N'A', N'', N'GOOD', N'A', N'A', N'A', N'3F9"/20KG', N'', N'A', N'A', N'A')
INSERT [dbo].[StudentExtraActivities] ([StudentId], [ActivitiesYear], [ExaminationId], [SchoolDays], [Present_Days], [Reading_And_Writing_Skill], [Recognition_of_Letter], [English], [Nepali], [Copying_Skill], [Students_Academic_Attitude], [Concentration], [Co-operation], [Memory], [Curiosity], [Understanding], [Student_Department], [Conduct], [Neatness_And_Tidiness], [Punctuality], [Politeness], [Height_And_Weight], [Extra_Curricular_Activities], [Drill/P.T], [Dance], [Rhymes]) VALUES (29, N'2073', 1, 70, 65, N'', N'', N'B', N'B', N'B', N'', N'B', N'A', N'A', N'A', N'B', N'', N'GOOD', N'B', N'A', N'A', N'3F6"/19KG', N'', N'A', N'A', N'B')
INSERT [dbo].[StudentExtraActivities] ([StudentId], [ActivitiesYear], [ExaminationId], [SchoolDays], [Present_Days], [Reading_And_Writing_Skill], [Recognition_of_Letter], [English], [Nepali], [Copying_Skill], [Students_Academic_Attitude], [Concentration], [Co-operation], [Memory], [Curiosity], [Understanding], [Student_Department], [Conduct], [Neatness_And_Tidiness], [Punctuality], [Politeness], [Height_And_Weight], [Extra_Curricular_Activities], [Drill/P.T], [Dance], [Rhymes]) VALUES (29, N'2073', 2, 240, 216, N'', N'', N'A', N'A', N'A', N'', N'A', N'A', N'A', N'A', N'A', N'', N'GOOD', N'B', N'A', N'A', N'3F8"/20KG', N'', N'A', N'B', N'A')
INSERT [dbo].[StudentExtraActivities] ([StudentId], [ActivitiesYear], [ExaminationId], [SchoolDays], [Present_Days], [Reading_And_Writing_Skill], [Recognition_of_Letter], [English], [Nepali], [Copying_Skill], [Students_Academic_Attitude], [Concentration], [Co-operation], [Memory], [Curiosity], [Understanding], [Student_Department], [Conduct], [Neatness_And_Tidiness], [Punctuality], [Politeness], [Height_And_Weight], [Extra_Curricular_Activities], [Drill/P.T], [Dance], [Rhymes]) VALUES (30, N'2073', 1, 70, 47, N'', N'', N'B', N'B', N'A', N'', N'B', N'A', N'B', N'B', N'B', N'', N'GOOD', N'C', N'A', N'A', N'3F6"/15KG', N'', N'A', N'A', N'B')
INSERT [dbo].[StudentExtraActivities] ([StudentId], [ActivitiesYear], [ExaminationId], [SchoolDays], [Present_Days], [Reading_And_Writing_Skill], [Recognition_of_Letter], [English], [Nepali], [Copying_Skill], [Students_Academic_Attitude], [Concentration], [Co-operation], [Memory], [Curiosity], [Understanding], [Student_Department], [Conduct], [Neatness_And_Tidiness], [Punctuality], [Politeness], [Height_And_Weight], [Extra_Curricular_Activities], [Drill/P.T], [Dance], [Rhymes]) VALUES (38, N'2073', 2, 240, 44, N'', N'', N'A', N'A', N'A', N'', N'A', N'A', N'A', N'A', N'A', N'', N'GOOD', N'A', N'A', N'A', N'3F3.5"/15KG', N'', N'B', N'B', N'B')
INSERT [dbo].[StudentExtraActivities] ([StudentId], [ActivitiesYear], [ExaminationId], [SchoolDays], [Present_Days], [Reading_And_Writing_Skill], [Recognition_of_Letter], [English], [Nepali], [Copying_Skill], [Students_Academic_Attitude], [Concentration], [Co-operation], [Memory], [Curiosity], [Understanding], [Student_Department], [Conduct], [Neatness_And_Tidiness], [Punctuality], [Politeness], [Height_And_Weight], [Extra_Curricular_Activities], [Drill/P.T], [Dance], [Rhymes]) VALUES (39, N'2074', 3, 59, 51, N'', N'', N'B', N'B', N'B', N'', N'B', N'B', N'B', N'B', N'B', N'', N'GOOD', N'B', N'B', N'B', N'3F/11KG', N'', N'B', N'B', N'B')
INSERT [dbo].[StudentExtraActivities] ([StudentId], [ActivitiesYear], [ExaminationId], [SchoolDays], [Present_Days], [Reading_And_Writing_Skill], [Recognition_of_Letter], [English], [Nepali], [Copying_Skill], [Students_Academic_Attitude], [Concentration], [Co-operation], [Memory], [Curiosity], [Understanding], [Student_Department], [Conduct], [Neatness_And_Tidiness], [Punctuality], [Politeness], [Height_And_Weight], [Extra_Curricular_Activities], [Drill/P.T], [Dance], [Rhymes]) VALUES (39, N'2074', 4, 228, 203, N'', N'', N'A', N'A', N'A', N'', N'A', N'A', N'B', N'A', N'B', N'', N'GOOD', N'B', N'A', N'A', N'3F2"/12KG', N'', N'B', N'B', N'B')
INSERT [dbo].[StudentExtraActivities] ([StudentId], [ActivitiesYear], [ExaminationId], [SchoolDays], [Present_Days], [Reading_And_Writing_Skill], [Recognition_of_Letter], [English], [Nepali], [Copying_Skill], [Students_Academic_Attitude], [Concentration], [Co-operation], [Memory], [Curiosity], [Understanding], [Student_Department], [Conduct], [Neatness_And_Tidiness], [Punctuality], [Politeness], [Height_And_Weight], [Extra_Curricular_Activities], [Drill/P.T], [Dance], [Rhymes]) VALUES (40, N'2074', 3, 59, 51, N'', N'', N'A', N'B', N'A', N'', N'A', N'B', N'A', N'B', N'A', N'', N'GOOD', N'A', N'A', N'A', N'3F1"/12KG', N'', N'A', N'B', N'A')
INSERT [dbo].[StudentExtraActivities] ([StudentId], [ActivitiesYear], [ExaminationId], [SchoolDays], [Present_Days], [Reading_And_Writing_Skill], [Recognition_of_Letter], [English], [Nepali], [Copying_Skill], [Students_Academic_Attitude], [Concentration], [Co-operation], [Memory], [Curiosity], [Understanding], [Student_Department], [Conduct], [Neatness_And_Tidiness], [Punctuality], [Politeness], [Height_And_Weight], [Extra_Curricular_Activities], [Drill/P.T], [Dance], [Rhymes]) VALUES (40, N'2074', 4, 228, 186, N'', N'', N'A', N'A', N'A', N'', N'A', N'A', N'A', N'A', N'A', N'', N'GOOD', N'A', N'A', N'A', N'3F3"/14KG', N'', N'A', N'B', N'A')
INSERT [dbo].[StudentExtraActivities] ([StudentId], [ActivitiesYear], [ExaminationId], [SchoolDays], [Present_Days], [Reading_And_Writing_Skill], [Recognition_of_Letter], [English], [Nepali], [Copying_Skill], [Students_Academic_Attitude], [Concentration], [Co-operation], [Memory], [Curiosity], [Understanding], [Student_Department], [Conduct], [Neatness_And_Tidiness], [Punctuality], [Politeness], [Height_And_Weight], [Extra_Curricular_Activities], [Drill/P.T], [Dance], [Rhymes]) VALUES (41, N'2074', 3, 59, 52, N'', N'', N'B', N'B', N'B', N'', N'B', N'B', N'B', N'A', N'B', N'', N'GOOD', N'A', N'B', N'A', N'2F10.5"/11KG', N'', N'B', N'B', N'B')
INSERT [dbo].[StudentExtraActivities] ([StudentId], [ActivitiesYear], [ExaminationId], [SchoolDays], [Present_Days], [Reading_And_Writing_Skill], [Recognition_of_Letter], [English], [Nepali], [Copying_Skill], [Students_Academic_Attitude], [Concentration], [Co-operation], [Memory], [Curiosity], [Understanding], [Student_Department], [Conduct], [Neatness_And_Tidiness], [Punctuality], [Politeness], [Height_And_Weight], [Extra_Curricular_Activities], [Drill/P.T], [Dance], [Rhymes]) VALUES (41, N'2074', 4, 228, 202, N'', N'', N'A', N'A', N'A', N'', N'A', N'A', N'A', N'A', N'A', N'', N'GOOD', N'A', N'A', N'A', N'2F12"/12KG', N'', N'A', N'A', N'A')
INSERT [dbo].[StudentExtraActivities] ([StudentId], [ActivitiesYear], [ExaminationId], [SchoolDays], [Present_Days], [Reading_And_Writing_Skill], [Recognition_of_Letter], [English], [Nepali], [Copying_Skill], [Students_Academic_Attitude], [Concentration], [Co-operation], [Memory], [Curiosity], [Understanding], [Student_Department], [Conduct], [Neatness_And_Tidiness], [Punctuality], [Politeness], [Height_And_Weight], [Extra_Curricular_Activities], [Drill/P.T], [Dance], [Rhymes]) VALUES (42, N'2074', 3, 59, 55, N'', N'', N'A', N'A', N'A', N'', N'A', N'B', N'A', N'A', N'A', N'', N'GOOD', N'A', N'A', N'A', N'3F3"/16KG', N'', N'A', N'B', N'A')
INSERT [dbo].[StudentExtraActivities] ([StudentId], [ActivitiesYear], [ExaminationId], [SchoolDays], [Present_Days], [Reading_And_Writing_Skill], [Recognition_of_Letter], [English], [Nepali], [Copying_Skill], [Students_Academic_Attitude], [Concentration], [Co-operation], [Memory], [Curiosity], [Understanding], [Student_Department], [Conduct], [Neatness_And_Tidiness], [Punctuality], [Politeness], [Height_And_Weight], [Extra_Curricular_Activities], [Drill/P.T], [Dance], [Rhymes]) VALUES (42, N'2074', 4, 228, 1, N'', N'', N'E', N'E', N'E', N'', N'E', N'E', N'E', N'E', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'')
INSERT [dbo].[StudentExtraActivities] ([StudentId], [ActivitiesYear], [ExaminationId], [SchoolDays], [Present_Days], [Reading_And_Writing_Skill], [Recognition_of_Letter], [English], [Nepali], [Copying_Skill], [Students_Academic_Attitude], [Concentration], [Co-operation], [Memory], [Curiosity], [Understanding], [Student_Department], [Conduct], [Neatness_And_Tidiness], [Punctuality], [Politeness], [Height_And_Weight], [Extra_Curricular_Activities], [Drill/P.T], [Dance], [Rhymes]) VALUES (43, N'2074', 3, 59, 54, N'', N'', N'B', N'A', N'A', N'', N'B', N'B', N'B', N'B', N'B', N'', N'GOOD', N'A', N'A', N'B', N'3F1"/14KG', N'', N'B', N'B', N'B')
INSERT [dbo].[StudentExtraActivities] ([StudentId], [ActivitiesYear], [ExaminationId], [SchoolDays], [Present_Days], [Reading_And_Writing_Skill], [Recognition_of_Letter], [English], [Nepali], [Copying_Skill], [Students_Academic_Attitude], [Concentration], [Co-operation], [Memory], [Curiosity], [Understanding], [Student_Department], [Conduct], [Neatness_And_Tidiness], [Punctuality], [Politeness], [Height_And_Weight], [Extra_Curricular_Activities], [Drill/P.T], [Dance], [Rhymes]) VALUES (43, N'2074', 4, 228, 200, N'', N'', N'A', N'A', N'A', N'', N'A', N'A', N'B', N'A', N'A', N'', N'GOOD', N'A', N'A', N'A', N'3F2"/14KG', N'', N'B', N'A', N'A')
INSERT [dbo].[StudentExtraActivities] ([StudentId], [ActivitiesYear], [ExaminationId], [SchoolDays], [Present_Days], [Reading_And_Writing_Skill], [Recognition_of_Letter], [English], [Nepali], [Copying_Skill], [Students_Academic_Attitude], [Concentration], [Co-operation], [Memory], [Curiosity], [Understanding], [Student_Department], [Conduct], [Neatness_And_Tidiness], [Punctuality], [Politeness], [Height_And_Weight], [Extra_Curricular_Activities], [Drill/P.T], [Dance], [Rhymes]) VALUES (44, N'2074', 3, 59, 58, N'', N'', N'B', N'B', N'B', N'', N'B', N'B', N'B', N'B', N'B', N'', N'GOOD', N'B', N'B', N'B', N'2F11"/11KG', N'', N'B', N'B', N'B')
INSERT [dbo].[StudentExtraActivities] ([StudentId], [ActivitiesYear], [ExaminationId], [SchoolDays], [Present_Days], [Reading_And_Writing_Skill], [Recognition_of_Letter], [English], [Nepali], [Copying_Skill], [Students_Academic_Attitude], [Concentration], [Co-operation], [Memory], [Curiosity], [Understanding], [Student_Department], [Conduct], [Neatness_And_Tidiness], [Punctuality], [Politeness], [Height_And_Weight], [Extra_Curricular_Activities], [Drill/P.T], [Dance], [Rhymes]) VALUES (44, N'2074', 4, 228, 216, N'', N'', N'A', N'A', N'A', N'', N'A', N'A', N'A', N'A', N'A', N'', N'GOOD', N'A', N'A', N'A', N'2F12"/13KG', N'', N'B', N'A', N'A')
INSERT [dbo].[StudentExtraActivities] ([StudentId], [ActivitiesYear], [ExaminationId], [SchoolDays], [Present_Days], [Reading_And_Writing_Skill], [Recognition_of_Letter], [English], [Nepali], [Copying_Skill], [Students_Academic_Attitude], [Concentration], [Co-operation], [Memory], [Curiosity], [Understanding], [Student_Department], [Conduct], [Neatness_And_Tidiness], [Punctuality], [Politeness], [Height_And_Weight], [Extra_Curricular_Activities], [Drill/P.T], [Dance], [Rhymes]) VALUES (53, N'2074', 3, 59, 58, N'', N'', N'B', N'B', N'A', N'', N'B', N'B', N'B', N'B', N'B', N'', N'GOOD', N'A', N'A', N'A', N'3F7"/15KG', N'', N'B', N'C', N'B')
INSERT [dbo].[StudentExtraActivities] ([StudentId], [ActivitiesYear], [ExaminationId], [SchoolDays], [Present_Days], [Reading_And_Writing_Skill], [Recognition_of_Letter], [English], [Nepali], [Copying_Skill], [Students_Academic_Attitude], [Concentration], [Co-operation], [Memory], [Curiosity], [Understanding], [Student_Department], [Conduct], [Neatness_And_Tidiness], [Punctuality], [Politeness], [Height_And_Weight], [Extra_Curricular_Activities], [Drill/P.T], [Dance], [Rhymes]) VALUES (53, N'2074', 4, 228, 223, N'', N'', N'A', N'A', N'A', N'', N'A', N'A', N'A', N'B', N'A', N'', N'GOOD', N'A', N'A', N'A', N'3F9"/20KG', N'', N'A', N'B', N'A')
INSERT [dbo].[StudentExtraActivities] ([StudentId], [ActivitiesYear], [ExaminationId], [SchoolDays], [Present_Days], [Reading_And_Writing_Skill], [Recognition_of_Letter], [English], [Nepali], [Copying_Skill], [Students_Academic_Attitude], [Concentration], [Co-operation], [Memory], [Curiosity], [Understanding], [Student_Department], [Conduct], [Neatness_And_Tidiness], [Punctuality], [Politeness], [Height_And_Weight], [Extra_Curricular_Activities], [Drill/P.T], [Dance], [Rhymes]) VALUES (54, N'2074', 3, 59, 55, N'', N'', N'C', N'C', N'C', N'', N'C', N'B', N'C', N'C', N'C', N'', N'GOOD', N'A', N'A', N'B', N'3F3"/13KG', N'', N'C', N'C', N'C')
INSERT [dbo].[StudentExtraActivities] ([StudentId], [ActivitiesYear], [ExaminationId], [SchoolDays], [Present_Days], [Reading_And_Writing_Skill], [Recognition_of_Letter], [English], [Nepali], [Copying_Skill], [Students_Academic_Attitude], [Concentration], [Co-operation], [Memory], [Curiosity], [Understanding], [Student_Department], [Conduct], [Neatness_And_Tidiness], [Punctuality], [Politeness], [Height_And_Weight], [Extra_Curricular_Activities], [Drill/P.T], [Dance], [Rhymes]) VALUES (54, N'2074', 4, 228, 223, N'', N'', N'B', N'B', N'B', N'', N'B', N'B', N'B', N'B', N'B', N'', N'GOOD', N'A', N'A', N'B', N'3F5"/16KG', N'', N'A', N'B', N'A')
INSERT [dbo].[StudentExtraActivities] ([StudentId], [ActivitiesYear], [ExaminationId], [SchoolDays], [Present_Days], [Reading_And_Writing_Skill], [Recognition_of_Letter], [English], [Nepali], [Copying_Skill], [Students_Academic_Attitude], [Concentration], [Co-operation], [Memory], [Curiosity], [Understanding], [Student_Department], [Conduct], [Neatness_And_Tidiness], [Punctuality], [Politeness], [Height_And_Weight], [Extra_Curricular_Activities], [Drill/P.T], [Dance], [Rhymes]) VALUES (55, N'2074', 3, 59, 59, N'', N'', N'A', N'A', N'A', N'', N'A', N'B', N'A', N'A', N'A', N'', N'GOOD', N'A', N'A', N'B', N'3F2"/13KG', N'', N'A', N'B', N'A')
INSERT [dbo].[StudentExtraActivities] ([StudentId], [ActivitiesYear], [ExaminationId], [SchoolDays], [Present_Days], [Reading_And_Writing_Skill], [Recognition_of_Letter], [English], [Nepali], [Copying_Skill], [Students_Academic_Attitude], [Concentration], [Co-operation], [Memory], [Curiosity], [Understanding], [Student_Department], [Conduct], [Neatness_And_Tidiness], [Punctuality], [Politeness], [Height_And_Weight], [Extra_Curricular_Activities], [Drill/P.T], [Dance], [Rhymes]) VALUES (55, N'2074', 4, 228, 215, N'', N'', N'A', N'A', N'A', N'', N'A', N'A', N'A', N'A', N'A', N'', N'GOOD', N'A', N'A', N'A', N'3F5"/18KG', N'', N'A', N'A', N'A')
INSERT [dbo].[StudentExtraActivities] ([StudentId], [ActivitiesYear], [ExaminationId], [SchoolDays], [Present_Days], [Reading_And_Writing_Skill], [Recognition_of_Letter], [English], [Nepali], [Copying_Skill], [Students_Academic_Attitude], [Concentration], [Co-operation], [Memory], [Curiosity], [Understanding], [Student_Department], [Conduct], [Neatness_And_Tidiness], [Punctuality], [Politeness], [Height_And_Weight], [Extra_Curricular_Activities], [Drill/P.T], [Dance], [Rhymes]) VALUES (56, N'2074', 3, 59, 59, N'', N'', N'A', N'A', N'A', N'', N'A', N'B', N'A', N'B', N'A', N'', N'GOOD', N'A', N'A', N'B', N'3F5"/14KG', N'', N'A', N'A', N'A')
INSERT [dbo].[StudentExtraActivities] ([StudentId], [ActivitiesYear], [ExaminationId], [SchoolDays], [Present_Days], [Reading_And_Writing_Skill], [Recognition_of_Letter], [English], [Nepali], [Copying_Skill], [Students_Academic_Attitude], [Concentration], [Co-operation], [Memory], [Curiosity], [Understanding], [Student_Department], [Conduct], [Neatness_And_Tidiness], [Punctuality], [Politeness], [Height_And_Weight], [Extra_Curricular_Activities], [Drill/P.T], [Dance], [Rhymes]) VALUES (56, N'2074', 4, 228, 216, N'', N'', N'A', N'A', N'A', N'', N'A', N'A', N'A', N'A', N'A', N'', N'GOOD', N'A', N'A', N'A', N'3F8"/19KG', N'', N'A', N'A', N'A')
INSERT [dbo].[StudentExtraActivities] ([StudentId], [ActivitiesYear], [ExaminationId], [SchoolDays], [Present_Days], [Reading_And_Writing_Skill], [Recognition_of_Letter], [English], [Nepali], [Copying_Skill], [Students_Academic_Attitude], [Concentration], [Co-operation], [Memory], [Curiosity], [Understanding], [Student_Department], [Conduct], [Neatness_And_Tidiness], [Punctuality], [Politeness], [Height_And_Weight], [Extra_Curricular_Activities], [Drill/P.T], [Dance], [Rhymes]) VALUES (57, N'2074', 3, 59, 59, N'', N'', N'A', N'A', N'A', N'', N'B', N'B', N'A', N'B', N'A', N'', N'GOOD', N'A', N'A', N'B', N'3F5"/15KG', N'', N'A', N'A', N'A')
INSERT [dbo].[StudentExtraActivities] ([StudentId], [ActivitiesYear], [ExaminationId], [SchoolDays], [Present_Days], [Reading_And_Writing_Skill], [Recognition_of_Letter], [English], [Nepali], [Copying_Skill], [Students_Academic_Attitude], [Concentration], [Co-operation], [Memory], [Curiosity], [Understanding], [Student_Department], [Conduct], [Neatness_And_Tidiness], [Punctuality], [Politeness], [Height_And_Weight], [Extra_Curricular_Activities], [Drill/P.T], [Dance], [Rhymes]) VALUES (57, N'2074', 4, 228, 216, N'', N'', N'A', N'A', N'A', N'', N'A', N'A', N'A', N'A', N'A', N'', N'GOOD', N'A', N'A', N'A', N'3F6"/19KG', N'', N'A', N'A', N'A')
INSERT [dbo].[StudentExtraActivities] ([StudentId], [ActivitiesYear], [ExaminationId], [SchoolDays], [Present_Days], [Reading_And_Writing_Skill], [Recognition_of_Letter], [English], [Nepali], [Copying_Skill], [Students_Academic_Attitude], [Concentration], [Co-operation], [Memory], [Curiosity], [Understanding], [Student_Department], [Conduct], [Neatness_And_Tidiness], [Punctuality], [Politeness], [Height_And_Weight], [Extra_Curricular_Activities], [Drill/P.T], [Dance], [Rhymes]) VALUES (58, N'2074', 3, 59, 56, N'', N'', N'C', N'C', N'B', N'', N'C', N'C', N'C', N'C', N'C', N'', N'GOOD', N'A', N'A', N'B', N'3F3"/14KG', N'', N'B', N'B', N'C')
INSERT [dbo].[StudentExtraActivities] ([StudentId], [ActivitiesYear], [ExaminationId], [SchoolDays], [Present_Days], [Reading_And_Writing_Skill], [Recognition_of_Letter], [English], [Nepali], [Copying_Skill], [Students_Academic_Attitude], [Concentration], [Co-operation], [Memory], [Curiosity], [Understanding], [Student_Department], [Conduct], [Neatness_And_Tidiness], [Punctuality], [Politeness], [Height_And_Weight], [Extra_Curricular_Activities], [Drill/P.T], [Dance], [Rhymes]) VALUES (58, N'2074', 4, 228, 222, N'', N'', N'A', N'A', N'A', N'', N'B', N'A', N'B', N'B', N'A', N'', N'GOOD', N'A', N'A', N'A', N'3F4"/18KG', N'', N'A', N'A', N'A')
INSERT [dbo].[StudentExtraActivities] ([StudentId], [ActivitiesYear], [ExaminationId], [SchoolDays], [Present_Days], [Reading_And_Writing_Skill], [Recognition_of_Letter], [English], [Nepali], [Copying_Skill], [Students_Academic_Attitude], [Concentration], [Co-operation], [Memory], [Curiosity], [Understanding], [Student_Department], [Conduct], [Neatness_And_Tidiness], [Punctuality], [Politeness], [Height_And_Weight], [Extra_Curricular_Activities], [Drill/P.T], [Dance], [Rhymes]) VALUES (59, N'2074', 3, 59, 58, N'', N'', N'A', N'A', N'A', N'', N'A', N'B', N'A', N'A', N'A', N'', N'GOOD', N'A', N'A', N'B', N'3F5"/18KG', N'', N'A', N'B', N'A')
INSERT [dbo].[StudentExtraActivities] ([StudentId], [ActivitiesYear], [ExaminationId], [SchoolDays], [Present_Days], [Reading_And_Writing_Skill], [Recognition_of_Letter], [English], [Nepali], [Copying_Skill], [Students_Academic_Attitude], [Concentration], [Co-operation], [Memory], [Curiosity], [Understanding], [Student_Department], [Conduct], [Neatness_And_Tidiness], [Punctuality], [Politeness], [Height_And_Weight], [Extra_Curricular_Activities], [Drill/P.T], [Dance], [Rhymes]) VALUES (59, N'2074', 4, 228, 222, N'', N'', N'A', N'A', N'A', N'', N'A', N'A', N'A', N'A', N'A', N'', N'GOOD', N'A', N'A', N'A', N'3F7"/22KG', N'', N'A', N'A', N'A')
INSERT [dbo].[StudentExtraActivities] ([StudentId], [ActivitiesYear], [ExaminationId], [SchoolDays], [Present_Days], [Reading_And_Writing_Skill], [Recognition_of_Letter], [English], [Nepali], [Copying_Skill], [Students_Academic_Attitude], [Concentration], [Co-operation], [Memory], [Curiosity], [Understanding], [Student_Department], [Conduct], [Neatness_And_Tidiness], [Punctuality], [Politeness], [Height_And_Weight], [Extra_Curricular_Activities], [Drill/P.T], [Dance], [Rhymes]) VALUES (60, N'2074', 3, 59, 53, N'', N'', N'A', N'A', N'A', N'', N'A', N'B', N'B', N'B', N'A', N'', N'GOOD', N'A', N'A', N'A', N'3F5"/15KG', N'', N'B', N'B', N'B')
INSERT [dbo].[StudentExtraActivities] ([StudentId], [ActivitiesYear], [ExaminationId], [SchoolDays], [Present_Days], [Reading_And_Writing_Skill], [Recognition_of_Letter], [English], [Nepali], [Copying_Skill], [Students_Academic_Attitude], [Concentration], [Co-operation], [Memory], [Curiosity], [Understanding], [Student_Department], [Conduct], [Neatness_And_Tidiness], [Punctuality], [Politeness], [Height_And_Weight], [Extra_Curricular_Activities], [Drill/P.T], [Dance], [Rhymes]) VALUES (60, N'2074', 4, 228, 195, N'', N'', N'A', N'A', N'A', N'', N'A', N'A', N'A', N'A', N'A', N'', N'GOOD', N'A', N'A', N'A', N'3F6"/18KG', N'', N'A', N'A', N'A')
INSERT [dbo].[StudentExtraActivities] ([StudentId], [ActivitiesYear], [ExaminationId], [SchoolDays], [Present_Days], [Reading_And_Writing_Skill], [Recognition_of_Letter], [English], [Nepali], [Copying_Skill], [Students_Academic_Attitude], [Concentration], [Co-operation], [Memory], [Curiosity], [Understanding], [Student_Department], [Conduct], [Neatness_And_Tidiness], [Punctuality], [Politeness], [Height_And_Weight], [Extra_Curricular_Activities], [Drill/P.T], [Dance], [Rhymes]) VALUES (61, N'2074', 3, 59, 39, N'', N'', N'A', N'A', N'A', N'', N'A', N'B', N'A', N'A', N'A', N'', N'GOOD', N'A', N'B', N'B', N'3F6"/17KG', N'', N'A', N'B', N'A')
INSERT [dbo].[StudentExtraActivities] ([StudentId], [ActivitiesYear], [ExaminationId], [SchoolDays], [Present_Days], [Reading_And_Writing_Skill], [Recognition_of_Letter], [English], [Nepali], [Copying_Skill], [Students_Academic_Attitude], [Concentration], [Co-operation], [Memory], [Curiosity], [Understanding], [Student_Department], [Conduct], [Neatness_And_Tidiness], [Punctuality], [Politeness], [Height_And_Weight], [Extra_Curricular_Activities], [Drill/P.T], [Dance], [Rhymes]) VALUES (61, N'2074', 4, 228, 188, N'', N'', N'A', N'A', N'A', N'', N'A', N'A', N'A', N'A', N'A', N'', N'GOOD', N'A', N'A', N'A', N'3F8"/20KG', N'', N'A', N'A', N'A')
INSERT [dbo].[StudentExtraActivities] ([StudentId], [ActivitiesYear], [ExaminationId], [SchoolDays], [Present_Days], [Reading_And_Writing_Skill], [Recognition_of_Letter], [English], [Nepali], [Copying_Skill], [Students_Academic_Attitude], [Concentration], [Co-operation], [Memory], [Curiosity], [Understanding], [Student_Department], [Conduct], [Neatness_And_Tidiness], [Punctuality], [Politeness], [Height_And_Weight], [Extra_Curricular_Activities], [Drill/P.T], [Dance], [Rhymes]) VALUES (67, N'2074', 3, 59, 59, N'', N'', N'B', N'B', N'B', N'', N'B', N'B', N'B', N'B', N'B', N'', N'GOOD', N'A', N'A', N'A', N'3F8"/20KG', N'', N'B', N'B', N'B')
INSERT [dbo].[StudentExtraActivities] ([StudentId], [ActivitiesYear], [ExaminationId], [SchoolDays], [Present_Days], [Reading_And_Writing_Skill], [Recognition_of_Letter], [English], [Nepali], [Copying_Skill], [Students_Academic_Attitude], [Concentration], [Co-operation], [Memory], [Curiosity], [Understanding], [Student_Department], [Conduct], [Neatness_And_Tidiness], [Punctuality], [Politeness], [Height_And_Weight], [Extra_Curricular_Activities], [Drill/P.T], [Dance], [Rhymes]) VALUES (67, N'2074', 4, 228, 226, N'', N'', N'A', N'A', N'A', N'', N'A', N'A', N'A', N'A', N'A', N'', N'GOOD', N'A', N'A', N'A', N'3F10"/22KG', N'', N'A', N'A', N'A')
INSERT [dbo].[StudentExtraActivities] ([StudentId], [ActivitiesYear], [ExaminationId], [SchoolDays], [Present_Days], [Reading_And_Writing_Skill], [Recognition_of_Letter], [English], [Nepali], [Copying_Skill], [Students_Academic_Attitude], [Concentration], [Co-operation], [Memory], [Curiosity], [Understanding], [Student_Department], [Conduct], [Neatness_And_Tidiness], [Punctuality], [Politeness], [Height_And_Weight], [Extra_Curricular_Activities], [Drill/P.T], [Dance], [Rhymes]) VALUES (68, N'2074', 3, 59, 59, N'', N'', N'B', N'B', N'B', N'', N'B', N'B', N'B', N'B', N'B', N'', N'GOOD', N'A', N'A', N'A', N'3F5"/18KG', N'', N'B', N'A', N'A')
INSERT [dbo].[StudentExtraActivities] ([StudentId], [ActivitiesYear], [ExaminationId], [SchoolDays], [Present_Days], [Reading_And_Writing_Skill], [Recognition_of_Letter], [English], [Nepali], [Copying_Skill], [Students_Academic_Attitude], [Concentration], [Co-operation], [Memory], [Curiosity], [Understanding], [Student_Department], [Conduct], [Neatness_And_Tidiness], [Punctuality], [Politeness], [Height_And_Weight], [Extra_Curricular_Activities], [Drill/P.T], [Dance], [Rhymes]) VALUES (68, N'2074', 4, 228, 223, N'', N'', N'A', N'A', N'A', N'', N'A', N'A', N'A', N'A', N'A', N'', N'GOOD', N'A', N'A', N'A', N'3F7"/20KG', N'', N'A', N'A', N'A')
INSERT [dbo].[StudentExtraActivities] ([StudentId], [ActivitiesYear], [ExaminationId], [SchoolDays], [Present_Days], [Reading_And_Writing_Skill], [Recognition_of_Letter], [English], [Nepali], [Copying_Skill], [Students_Academic_Attitude], [Concentration], [Co-operation], [Memory], [Curiosity], [Understanding], [Student_Department], [Conduct], [Neatness_And_Tidiness], [Punctuality], [Politeness], [Height_And_Weight], [Extra_Curricular_Activities], [Drill/P.T], [Dance], [Rhymes]) VALUES (69, N'2074', 3, 59, 59, N'', N'', N'B', N'B', N'B', N'', N'B', N'B', N'B', N'B', N'B', N'', N'GOOD', N'A', N'A', N'A', N'3F6"/17KG', N'', N'B', N'B', N'B')
INSERT [dbo].[StudentExtraActivities] ([StudentId], [ActivitiesYear], [ExaminationId], [SchoolDays], [Present_Days], [Reading_And_Writing_Skill], [Recognition_of_Letter], [English], [Nepali], [Copying_Skill], [Students_Academic_Attitude], [Concentration], [Co-operation], [Memory], [Curiosity], [Understanding], [Student_Department], [Conduct], [Neatness_And_Tidiness], [Punctuality], [Politeness], [Height_And_Weight], [Extra_Curricular_Activities], [Drill/P.T], [Dance], [Rhymes]) VALUES (69, N'2074', 4, 228, 224, N'', N'', N'A', N'A', N'A', N'', N'A', N'A', N'A', N'A', N'A', N'', N'GOOD', N'A', N'A', N'A', N'3F7"/20KG', N'', N'A', N'A', N'A')
INSERT [dbo].[StudentExtraActivities] ([StudentId], [ActivitiesYear], [ExaminationId], [SchoolDays], [Present_Days], [Reading_And_Writing_Skill], [Recognition_of_Letter], [English], [Nepali], [Copying_Skill], [Students_Academic_Attitude], [Concentration], [Co-operation], [Memory], [Curiosity], [Understanding], [Student_Department], [Conduct], [Neatness_And_Tidiness], [Punctuality], [Politeness], [Height_And_Weight], [Extra_Curricular_Activities], [Drill/P.T], [Dance], [Rhymes]) VALUES (70, N'2074', 3, 59, 55, N'', N'', N'B', N'A', N'A', N'', N'A', N'B', N'A', N'A', N'A', N'', N'GOOD', N'A', N'A', N'A', N'3F10"/20KG', N'', N'B', N'A', N'A')
INSERT [dbo].[StudentExtraActivities] ([StudentId], [ActivitiesYear], [ExaminationId], [SchoolDays], [Present_Days], [Reading_And_Writing_Skill], [Recognition_of_Letter], [English], [Nepali], [Copying_Skill], [Students_Academic_Attitude], [Concentration], [Co-operation], [Memory], [Curiosity], [Understanding], [Student_Department], [Conduct], [Neatness_And_Tidiness], [Punctuality], [Politeness], [Height_And_Weight], [Extra_Curricular_Activities], [Drill/P.T], [Dance], [Rhymes]) VALUES (70, N'2074', 4, 228, 217, N'', N'', N'A', N'A', N'A', N'', N'A', N'A', N'A', N'A', N'A', N'', N'GOOD', N'A', N'A', N'A', N'4F/22KG', N'', N'A', N'A', N'A')
INSERT [dbo].[StudentExtraActivities] ([StudentId], [ActivitiesYear], [ExaminationId], [SchoolDays], [Present_Days], [Reading_And_Writing_Skill], [Recognition_of_Letter], [English], [Nepali], [Copying_Skill], [Students_Academic_Attitude], [Concentration], [Co-operation], [Memory], [Curiosity], [Understanding], [Student_Department], [Conduct], [Neatness_And_Tidiness], [Punctuality], [Politeness], [Height_And_Weight], [Extra_Curricular_Activities], [Drill/P.T], [Dance], [Rhymes]) VALUES (71, N'2074', 3, 59, 57, N'', N'', N'B', N'B', N'B', N'', N'B', N'B', N'A', N'B', N'A', N'', N'GOOD', N'A', N'B', N'A', N'3F10"/30KG', N'', N'B', N'B', N'A')
INSERT [dbo].[StudentExtraActivities] ([StudentId], [ActivitiesYear], [ExaminationId], [SchoolDays], [Present_Days], [Reading_And_Writing_Skill], [Recognition_of_Letter], [English], [Nepali], [Copying_Skill], [Students_Academic_Attitude], [Concentration], [Co-operation], [Memory], [Curiosity], [Understanding], [Student_Department], [Conduct], [Neatness_And_Tidiness], [Punctuality], [Politeness], [Height_And_Weight], [Extra_Curricular_Activities], [Drill/P.T], [Dance], [Rhymes]) VALUES (71, N'2074', 4, 228, 219, N'', N'', N'A', N'A', N'A', N'', N'A', N'A', N'A', N'A', N'A', N'', N'GOOD', N'A', N'A', N'A', N'4F/32KG', N'', N'A', N'A', N'A')
INSERT [dbo].[StudentExtraActivities] ([StudentId], [ActivitiesYear], [ExaminationId], [SchoolDays], [Present_Days], [Reading_And_Writing_Skill], [Recognition_of_Letter], [English], [Nepali], [Copying_Skill], [Students_Academic_Attitude], [Concentration], [Co-operation], [Memory], [Curiosity], [Understanding], [Student_Department], [Conduct], [Neatness_And_Tidiness], [Punctuality], [Politeness], [Height_And_Weight], [Extra_Curricular_Activities], [Drill/P.T], [Dance], [Rhymes]) VALUES (72, N'2074', 3, 59, 58, N'', N'', N'B', N'B', N'B', N'', N'B', N'B', N'B', N'B', N'A', N'', N'GOOD', N'A', N'A', N'B', N'3F9"/20KG', N'', N'B', N'B', N'B')
INSERT [dbo].[StudentExtraActivities] ([StudentId], [ActivitiesYear], [ExaminationId], [SchoolDays], [Present_Days], [Reading_And_Writing_Skill], [Recognition_of_Letter], [English], [Nepali], [Copying_Skill], [Students_Academic_Attitude], [Concentration], [Co-operation], [Memory], [Curiosity], [Understanding], [Student_Department], [Conduct], [Neatness_And_Tidiness], [Punctuality], [Politeness], [Height_And_Weight], [Extra_Curricular_Activities], [Drill/P.T], [Dance], [Rhymes]) VALUES (72, N'2074', 4, 228, 219, N'', N'', N'A', N'A', N'A', N'', N'A', N'A', N'A', N'A', N'A', N'', N'GOOD', N'A', N'A', N'A', N'3F11"/23KG', N'', N'A', N'A', N'A')
INSERT [dbo].[StudentExtraActivities] ([StudentId], [ActivitiesYear], [ExaminationId], [SchoolDays], [Present_Days], [Reading_And_Writing_Skill], [Recognition_of_Letter], [English], [Nepali], [Copying_Skill], [Students_Academic_Attitude], [Concentration], [Co-operation], [Memory], [Curiosity], [Understanding], [Student_Department], [Conduct], [Neatness_And_Tidiness], [Punctuality], [Politeness], [Height_And_Weight], [Extra_Curricular_Activities], [Drill/P.T], [Dance], [Rhymes]) VALUES (73, N'2074', 3, 59, 57, N'', N'', N'B', N'B', N'B', N'', N'A', N'A', N'A', N'A', N'A', N'', N'GOOD', N'B', N'A', N'A', N'3F6"/16KG', N'', N'B', N'A', N'A')
INSERT [dbo].[StudentExtraActivities] ([StudentId], [ActivitiesYear], [ExaminationId], [SchoolDays], [Present_Days], [Reading_And_Writing_Skill], [Recognition_of_Letter], [English], [Nepali], [Copying_Skill], [Students_Academic_Attitude], [Concentration], [Co-operation], [Memory], [Curiosity], [Understanding], [Student_Department], [Conduct], [Neatness_And_Tidiness], [Punctuality], [Politeness], [Height_And_Weight], [Extra_Curricular_Activities], [Drill/P.T], [Dance], [Rhymes]) VALUES (73, N'2074', 4, 228, 219, N'', N'', N'A', N'A', N'A', N'', N'A', N'A', N'A', N'A', N'A', N'', N'GOOD', N'A', N'A', N'A', N'3F8"/18KG', N'', N'A', N'A', N'A')
GO
INSERT [dbo].[StudentExtraActivities] ([StudentId], [ActivitiesYear], [ExaminationId], [SchoolDays], [Present_Days], [Reading_And_Writing_Skill], [Recognition_of_Letter], [English], [Nepali], [Copying_Skill], [Students_Academic_Attitude], [Concentration], [Co-operation], [Memory], [Curiosity], [Understanding], [Student_Department], [Conduct], [Neatness_And_Tidiness], [Punctuality], [Politeness], [Height_And_Weight], [Extra_Curricular_Activities], [Drill/P.T], [Dance], [Rhymes]) VALUES (74, N'2074', 3, 59, 55, N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'')
INSERT [dbo].[StudentExtraActivities] ([StudentId], [ActivitiesYear], [ExaminationId], [SchoolDays], [Present_Days], [Reading_And_Writing_Skill], [Recognition_of_Letter], [English], [Nepali], [Copying_Skill], [Students_Academic_Attitude], [Concentration], [Co-operation], [Memory], [Curiosity], [Understanding], [Student_Department], [Conduct], [Neatness_And_Tidiness], [Punctuality], [Politeness], [Height_And_Weight], [Extra_Curricular_Activities], [Drill/P.T], [Dance], [Rhymes]) VALUES (74, N'2074', 4, 228, 1, N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'A', N'A', N'A', N'', N'', N'A', N'A', N'A')
INSERT [dbo].[StudentExtraActivities] ([StudentId], [ActivitiesYear], [ExaminationId], [SchoolDays], [Present_Days], [Reading_And_Writing_Skill], [Recognition_of_Letter], [English], [Nepali], [Copying_Skill], [Students_Academic_Attitude], [Concentration], [Co-operation], [Memory], [Curiosity], [Understanding], [Student_Department], [Conduct], [Neatness_And_Tidiness], [Punctuality], [Politeness], [Height_And_Weight], [Extra_Curricular_Activities], [Drill/P.T], [Dance], [Rhymes]) VALUES (75, N'2074', 3, 59, 54, N'', N'', N'B', N'B', N'B', N'', N'B', N'B', N'B', N'B', N'B', N'', N'GOOD', N'B', N'B', N'B', N'3F7"/18KG', N'', N'B', N'B', N'B')
INSERT [dbo].[StudentExtraActivities] ([StudentId], [ActivitiesYear], [ExaminationId], [SchoolDays], [Present_Days], [Reading_And_Writing_Skill], [Recognition_of_Letter], [English], [Nepali], [Copying_Skill], [Students_Academic_Attitude], [Concentration], [Co-operation], [Memory], [Curiosity], [Understanding], [Student_Department], [Conduct], [Neatness_And_Tidiness], [Punctuality], [Politeness], [Height_And_Weight], [Extra_Curricular_Activities], [Drill/P.T], [Dance], [Rhymes]) VALUES (75, N'2074', 4, 228, 215, N'', N'', N'B', N'B', N'B', N'', N'B', N'B', N'B', N'B', N'B', N'', N'GOOD', N'A', N'A', N'A', N'3F9"/20KG', N'', N'A', N'B', N'B')
INSERT [dbo].[StudentExtraActivities] ([StudentId], [ActivitiesYear], [ExaminationId], [SchoolDays], [Present_Days], [Reading_And_Writing_Skill], [Recognition_of_Letter], [English], [Nepali], [Copying_Skill], [Students_Academic_Attitude], [Concentration], [Co-operation], [Memory], [Curiosity], [Understanding], [Student_Department], [Conduct], [Neatness_And_Tidiness], [Punctuality], [Politeness], [Height_And_Weight], [Extra_Curricular_Activities], [Drill/P.T], [Dance], [Rhymes]) VALUES (76, N'2074', 3, 59, 56, N'', N'', N'B', N'B', N'B', N'', N'A', N'A', N'A', N'B', N'B', N'', N'GOOD', N'B', N'B', N'B', N'3F7"/16KG', N'', N'B', N'B', N'B')
INSERT [dbo].[StudentExtraActivities] ([StudentId], [ActivitiesYear], [ExaminationId], [SchoolDays], [Present_Days], [Reading_And_Writing_Skill], [Recognition_of_Letter], [English], [Nepali], [Copying_Skill], [Students_Academic_Attitude], [Concentration], [Co-operation], [Memory], [Curiosity], [Understanding], [Student_Department], [Conduct], [Neatness_And_Tidiness], [Punctuality], [Politeness], [Height_And_Weight], [Extra_Curricular_Activities], [Drill/P.T], [Dance], [Rhymes]) VALUES (76, N'2074', 4, 228, 204, N'', N'', N'B', N'B', N'B', N'', N'B', N'B', N'B', N'B', N'B', N'', N'GOOD', N'A', N'A', N'A', N'3F9"/20KG', N'', N'A', N'A', N'A')
INSERT [dbo].[StudentExtraActivities] ([StudentId], [ActivitiesYear], [ExaminationId], [SchoolDays], [Present_Days], [Reading_And_Writing_Skill], [Recognition_of_Letter], [English], [Nepali], [Copying_Skill], [Students_Academic_Attitude], [Concentration], [Co-operation], [Memory], [Curiosity], [Understanding], [Student_Department], [Conduct], [Neatness_And_Tidiness], [Punctuality], [Politeness], [Height_And_Weight], [Extra_Curricular_Activities], [Drill/P.T], [Dance], [Rhymes]) VALUES (77, N'2074', 3, 59, 55, N'', N'', N'B', N'B', N'B', N'', N'B', N'B', N'B', N'B', N'B', N'', N'GOOD', N'B', N'B', N'B', N'3F8"/16KG', N'', N'B', N'B', N'B')
INSERT [dbo].[StudentExtraActivities] ([StudentId], [ActivitiesYear], [ExaminationId], [SchoolDays], [Present_Days], [Reading_And_Writing_Skill], [Recognition_of_Letter], [English], [Nepali], [Copying_Skill], [Students_Academic_Attitude], [Concentration], [Co-operation], [Memory], [Curiosity], [Understanding], [Student_Department], [Conduct], [Neatness_And_Tidiness], [Punctuality], [Politeness], [Height_And_Weight], [Extra_Curricular_Activities], [Drill/P.T], [Dance], [Rhymes]) VALUES (77, N'2074', 4, 228, 210, N'', N'', N'A', N'A', N'A', N'', N'A', N'A', N'A', N'A', N'A', N'', N'GOOD', N'A', N'A', N'A', N'3F9"/18KG', N'', N'A', N'A', N'A')
INSERT [dbo].[StudentExtraActivities] ([StudentId], [ActivitiesYear], [ExaminationId], [SchoolDays], [Present_Days], [Reading_And_Writing_Skill], [Recognition_of_Letter], [English], [Nepali], [Copying_Skill], [Students_Academic_Attitude], [Concentration], [Co-operation], [Memory], [Curiosity], [Understanding], [Student_Department], [Conduct], [Neatness_And_Tidiness], [Punctuality], [Politeness], [Height_And_Weight], [Extra_Curricular_Activities], [Drill/P.T], [Dance], [Rhymes]) VALUES (78, N'2074', 3, 59, 59, N'', N'', N'B', N'B', N'B', N'', N'B', N'B', N'B', N'B', N'B', N'', N'GOOD', N'B', N'B', N'B', N'3F7.5"/18KG', N'', N'B', N'B', N'B')
INSERT [dbo].[StudentExtraActivities] ([StudentId], [ActivitiesYear], [ExaminationId], [SchoolDays], [Present_Days], [Reading_And_Writing_Skill], [Recognition_of_Letter], [English], [Nepali], [Copying_Skill], [Students_Academic_Attitude], [Concentration], [Co-operation], [Memory], [Curiosity], [Understanding], [Student_Department], [Conduct], [Neatness_And_Tidiness], [Punctuality], [Politeness], [Height_And_Weight], [Extra_Curricular_Activities], [Drill/P.T], [Dance], [Rhymes]) VALUES (78, N'2074', 4, 228, 223, N'', N'', N'A', N'A', N'A', N'', N'A', N'A', N'A', N'A', N'A', N'', N'GOOD', N'A', N'A', N'A', N'3F9"/20KG', N'', N'A', N'A', N'A')
INSERT [dbo].[StudentExtraActivities] ([StudentId], [ActivitiesYear], [ExaminationId], [SchoolDays], [Present_Days], [Reading_And_Writing_Skill], [Recognition_of_Letter], [English], [Nepali], [Copying_Skill], [Students_Academic_Attitude], [Concentration], [Co-operation], [Memory], [Curiosity], [Understanding], [Student_Department], [Conduct], [Neatness_And_Tidiness], [Punctuality], [Politeness], [Height_And_Weight], [Extra_Curricular_Activities], [Drill/P.T], [Dance], [Rhymes]) VALUES (79, N'2074', 3, 59, 53, N'', N'', N'C', N'C', N'C', N'', N'C', N'C', N'C', N'C', N'C', N'', N'GOOD', N'C', N'C', N'C', N'3F7"/20KG', N'', N'C', N'C', N'C')
INSERT [dbo].[StudentExtraActivities] ([StudentId], [ActivitiesYear], [ExaminationId], [SchoolDays], [Present_Days], [Reading_And_Writing_Skill], [Recognition_of_Letter], [English], [Nepali], [Copying_Skill], [Students_Academic_Attitude], [Concentration], [Co-operation], [Memory], [Curiosity], [Understanding], [Student_Department], [Conduct], [Neatness_And_Tidiness], [Punctuality], [Politeness], [Height_And_Weight], [Extra_Curricular_Activities], [Drill/P.T], [Dance], [Rhymes]) VALUES (79, N'2074', 4, 228, 213, N'', N'', N'B', N'B', N'B', N'', N'B', N'B', N'B', N'B', N'B', N'', N'GOOD', N'A', N'A', N'A', N'3F9"/21KG', N'', N'B', N'B', N'B')
INSERT [dbo].[StudentExtraActivities] ([StudentId], [ActivitiesYear], [ExaminationId], [SchoolDays], [Present_Days], [Reading_And_Writing_Skill], [Recognition_of_Letter], [English], [Nepali], [Copying_Skill], [Students_Academic_Attitude], [Concentration], [Co-operation], [Memory], [Curiosity], [Understanding], [Student_Department], [Conduct], [Neatness_And_Tidiness], [Punctuality], [Politeness], [Height_And_Weight], [Extra_Curricular_Activities], [Drill/P.T], [Dance], [Rhymes]) VALUES (85, N'2075', 5, 70, 68, N'', N'', N'A', N'B', N'A', N'', N'B', N'B', N'B', N'A', N'A', N'', N'GOOD', N'A', N'A', N'B', N'3F2"/13KG', N'', N'B', N'B', N'B')
INSERT [dbo].[StudentExtraActivities] ([StudentId], [ActivitiesYear], [ExaminationId], [SchoolDays], [Present_Days], [Reading_And_Writing_Skill], [Recognition_of_Letter], [English], [Nepali], [Copying_Skill], [Students_Academic_Attitude], [Concentration], [Co-operation], [Memory], [Curiosity], [Understanding], [Student_Department], [Conduct], [Neatness_And_Tidiness], [Punctuality], [Politeness], [Height_And_Weight], [Extra_Curricular_Activities], [Drill/P.T], [Dance], [Rhymes]) VALUES (85, N'2075', 6, 53, 51, N'', N'', N'A', N'A', N'A', N'', N'A', N'B', N'B', N'A', N'A', N'', N'GOOD', N'A', N'A', N'A', N'3F4"/15KG', N'', N'B', N'B', N'B')
INSERT [dbo].[StudentExtraActivities] ([StudentId], [ActivitiesYear], [ExaminationId], [SchoolDays], [Present_Days], [Reading_And_Writing_Skill], [Recognition_of_Letter], [English], [Nepali], [Copying_Skill], [Students_Academic_Attitude], [Concentration], [Co-operation], [Memory], [Curiosity], [Understanding], [Student_Department], [Conduct], [Neatness_And_Tidiness], [Punctuality], [Politeness], [Height_And_Weight], [Extra_Curricular_Activities], [Drill/P.T], [Dance], [Rhymes]) VALUES (85, N'2075', 7, 244, 236, N'', N'', N'A', N'A', N'A', N'', N'A', N'B', N'B', N'A', N'A', N'', N'GOOD', N'A', N'A', N'A', N'3F5''/16KG', N'', N'B', N'B', N'B')
INSERT [dbo].[StudentExtraActivities] ([StudentId], [ActivitiesYear], [ExaminationId], [SchoolDays], [Present_Days], [Reading_And_Writing_Skill], [Recognition_of_Letter], [English], [Nepali], [Copying_Skill], [Students_Academic_Attitude], [Concentration], [Co-operation], [Memory], [Curiosity], [Understanding], [Student_Department], [Conduct], [Neatness_And_Tidiness], [Punctuality], [Politeness], [Height_And_Weight], [Extra_Curricular_Activities], [Drill/P.T], [Dance], [Rhymes]) VALUES (86, N'2075', 5, 70, 60, N'', N'', N'A', N'A', N'A', N'', N'A', N'A', N'A', N'A', N'A', N'', N'GOOD', N'A', N'A', N'A', N'2F/11KG', N'', N'B', N'B', N'B')
INSERT [dbo].[StudentExtraActivities] ([StudentId], [ActivitiesYear], [ExaminationId], [SchoolDays], [Present_Days], [Reading_And_Writing_Skill], [Recognition_of_Letter], [English], [Nepali], [Copying_Skill], [Students_Academic_Attitude], [Concentration], [Co-operation], [Memory], [Curiosity], [Understanding], [Student_Department], [Conduct], [Neatness_And_Tidiness], [Punctuality], [Politeness], [Height_And_Weight], [Extra_Curricular_Activities], [Drill/P.T], [Dance], [Rhymes]) VALUES (86, N'2075', 6, 53, 49, N'', N'', N'A', N'A', N'A', N'', N'A', N'A', N'A', N'A', N'A', N'', N'GOOD', N'A', N'A', N'A', N'3F2"/13KG', N'', N'B', N'B', N'B')
INSERT [dbo].[StudentExtraActivities] ([StudentId], [ActivitiesYear], [ExaminationId], [SchoolDays], [Present_Days], [Reading_And_Writing_Skill], [Recognition_of_Letter], [English], [Nepali], [Copying_Skill], [Students_Academic_Attitude], [Concentration], [Co-operation], [Memory], [Curiosity], [Understanding], [Student_Department], [Conduct], [Neatness_And_Tidiness], [Punctuality], [Politeness], [Height_And_Weight], [Extra_Curricular_Activities], [Drill/P.T], [Dance], [Rhymes]) VALUES (86, N'2075', 7, 244, 230, N'', N'', N'A', N'A', N'A', N'', N'A', N'A', N'A', N'A', N'A', N'', N'GOOD', N'A', N'A', N'A', N'3F4''/13KG', N'', N'B', N'B', N'B')
INSERT [dbo].[StudentExtraActivities] ([StudentId], [ActivitiesYear], [ExaminationId], [SchoolDays], [Present_Days], [Reading_And_Writing_Skill], [Recognition_of_Letter], [English], [Nepali], [Copying_Skill], [Students_Academic_Attitude], [Concentration], [Co-operation], [Memory], [Curiosity], [Understanding], [Student_Department], [Conduct], [Neatness_And_Tidiness], [Punctuality], [Politeness], [Height_And_Weight], [Extra_Curricular_Activities], [Drill/P.T], [Dance], [Rhymes]) VALUES (99, N'2075', 5, 70, 68, N'', N'', N'A', N'B', N'B', N'', N'B', N'A', N'B', N'C', N'B', N'', N'GOOD', N'A', N'A', N'A', N'3F5"/14KG', N'', N'B', N'B', N'B')
INSERT [dbo].[StudentExtraActivities] ([StudentId], [ActivitiesYear], [ExaminationId], [SchoolDays], [Present_Days], [Reading_And_Writing_Skill], [Recognition_of_Letter], [English], [Nepali], [Copying_Skill], [Students_Academic_Attitude], [Concentration], [Co-operation], [Memory], [Curiosity], [Understanding], [Student_Department], [Conduct], [Neatness_And_Tidiness], [Punctuality], [Politeness], [Height_And_Weight], [Extra_Curricular_Activities], [Drill/P.T], [Dance], [Rhymes]) VALUES (99, N'2075', 6, 53, 49, N'', N'', N'A', N'B', N'B', N'', N'B', N'A', N'B', N'B', N'B', N'', N'GOOD', N'A', N'A', N'A', N'3F7"/17KG', N'', N'B', N'B', N'B')
INSERT [dbo].[StudentExtraActivities] ([StudentId], [ActivitiesYear], [ExaminationId], [SchoolDays], [Present_Days], [Reading_And_Writing_Skill], [Recognition_of_Letter], [English], [Nepali], [Copying_Skill], [Students_Academic_Attitude], [Concentration], [Co-operation], [Memory], [Curiosity], [Understanding], [Student_Department], [Conduct], [Neatness_And_Tidiness], [Punctuality], [Politeness], [Height_And_Weight], [Extra_Curricular_Activities], [Drill/P.T], [Dance], [Rhymes]) VALUES (99, N'2075', 7, 244, 236, N'', N'', N'A', N'A', N'A', N'', N'A', N'A', N'B', N'B', N'A', N'', N'GOOD', N'A', N'A', N'A', N'3F8''/17KG', N'', N'A', N'B', N'A')
INSERT [dbo].[StudentExtraActivities] ([StudentId], [ActivitiesYear], [ExaminationId], [SchoolDays], [Present_Days], [Reading_And_Writing_Skill], [Recognition_of_Letter], [English], [Nepali], [Copying_Skill], [Students_Academic_Attitude], [Concentration], [Co-operation], [Memory], [Curiosity], [Understanding], [Student_Department], [Conduct], [Neatness_And_Tidiness], [Punctuality], [Politeness], [Height_And_Weight], [Extra_Curricular_Activities], [Drill/P.T], [Dance], [Rhymes]) VALUES (100, N'2075', 5, 70, 66, N'', N'', N'A', N'B', N'B', N'', N'B', N'A', N'B', N'C', N'B', N'', N'GOOD', N'A', N'A', N'A', N'3F1"/12KG', N'', N'B', N'A', N'B')
INSERT [dbo].[StudentExtraActivities] ([StudentId], [ActivitiesYear], [ExaminationId], [SchoolDays], [Present_Days], [Reading_And_Writing_Skill], [Recognition_of_Letter], [English], [Nepali], [Copying_Skill], [Students_Academic_Attitude], [Concentration], [Co-operation], [Memory], [Curiosity], [Understanding], [Student_Department], [Conduct], [Neatness_And_Tidiness], [Punctuality], [Politeness], [Height_And_Weight], [Extra_Curricular_Activities], [Drill/P.T], [Dance], [Rhymes]) VALUES (100, N'2075', 6, 53, 48, N'', N'', N'A', N'A', N'A', N'', N'A', N'A', N'B', N'B', N'B', N'', N'GOOD', N'A', N'A', N'A', N'3F3"/14KG', N'', N'B', N'B', N'B')
INSERT [dbo].[StudentExtraActivities] ([StudentId], [ActivitiesYear], [ExaminationId], [SchoolDays], [Present_Days], [Reading_And_Writing_Skill], [Recognition_of_Letter], [English], [Nepali], [Copying_Skill], [Students_Academic_Attitude], [Concentration], [Co-operation], [Memory], [Curiosity], [Understanding], [Student_Department], [Conduct], [Neatness_And_Tidiness], [Punctuality], [Politeness], [Height_And_Weight], [Extra_Curricular_Activities], [Drill/P.T], [Dance], [Rhymes]) VALUES (100, N'2075', 7, 244, 228, N'', N'', N'A', N'A', N'A', N'', N'A', N'A', N'B', N'A', N'A', N'', N'GOOD', N'A', N'A', N'A', N'3F4''/14KG', N'', N'A', N'B', N'A')
INSERT [dbo].[StudentExtraActivities] ([StudentId], [ActivitiesYear], [ExaminationId], [SchoolDays], [Present_Days], [Reading_And_Writing_Skill], [Recognition_of_Letter], [English], [Nepali], [Copying_Skill], [Students_Academic_Attitude], [Concentration], [Co-operation], [Memory], [Curiosity], [Understanding], [Student_Department], [Conduct], [Neatness_And_Tidiness], [Punctuality], [Politeness], [Height_And_Weight], [Extra_Curricular_Activities], [Drill/P.T], [Dance], [Rhymes]) VALUES (101, N'2075', 5, 70, 68, N'', N'', N'A', N'A', N'A', N'', N'A', N'B', N'A', N'B', N'A', N'', N'GOOD', N'A', N'A', N'B', N'3F1"/13KG', N'', N'B', N'B', N'B')
INSERT [dbo].[StudentExtraActivities] ([StudentId], [ActivitiesYear], [ExaminationId], [SchoolDays], [Present_Days], [Reading_And_Writing_Skill], [Recognition_of_Letter], [English], [Nepali], [Copying_Skill], [Students_Academic_Attitude], [Concentration], [Co-operation], [Memory], [Curiosity], [Understanding], [Student_Department], [Conduct], [Neatness_And_Tidiness], [Punctuality], [Politeness], [Height_And_Weight], [Extra_Curricular_Activities], [Drill/P.T], [Dance], [Rhymes]) VALUES (101, N'2075', 6, 53, 52, N'', N'', N'A', N'A', N'A', N'', N'A', N'A', N'A', N'A', N'A', N'', N'GOOD', N'A', N'A', N'A', N'3F3"/14KG', N'', N'B', N'B', N'A')
INSERT [dbo].[StudentExtraActivities] ([StudentId], [ActivitiesYear], [ExaminationId], [SchoolDays], [Present_Days], [Reading_And_Writing_Skill], [Recognition_of_Letter], [English], [Nepali], [Copying_Skill], [Students_Academic_Attitude], [Concentration], [Co-operation], [Memory], [Curiosity], [Understanding], [Student_Department], [Conduct], [Neatness_And_Tidiness], [Punctuality], [Politeness], [Height_And_Weight], [Extra_Curricular_Activities], [Drill/P.T], [Dance], [Rhymes]) VALUES (101, N'2075', 7, 244, 238, N'', N'', N'A', N'A', N'A', N'', N'A', N'A', N'A', N'A', N'A', N'', N'GOOD', N'A', N'A', N'A', N'3F4''/14KG', N'', N'A', N'B', N'A')
INSERT [dbo].[StudentExtraActivities] ([StudentId], [ActivitiesYear], [ExaminationId], [SchoolDays], [Present_Days], [Reading_And_Writing_Skill], [Recognition_of_Letter], [English], [Nepali], [Copying_Skill], [Students_Academic_Attitude], [Concentration], [Co-operation], [Memory], [Curiosity], [Understanding], [Student_Department], [Conduct], [Neatness_And_Tidiness], [Punctuality], [Politeness], [Height_And_Weight], [Extra_Curricular_Activities], [Drill/P.T], [Dance], [Rhymes]) VALUES (102, N'2075', 5, 70, 66, N'', N'', N'A', N'B', N'B', N'', N'B', N'B', N'B', N'B', N'A', N'', N'GOOD', N'A', N'A', N'B', N'3F5"/13KG', N'', N'B', N'B', N'B')
INSERT [dbo].[StudentExtraActivities] ([StudentId], [ActivitiesYear], [ExaminationId], [SchoolDays], [Present_Days], [Reading_And_Writing_Skill], [Recognition_of_Letter], [English], [Nepali], [Copying_Skill], [Students_Academic_Attitude], [Concentration], [Co-operation], [Memory], [Curiosity], [Understanding], [Student_Department], [Conduct], [Neatness_And_Tidiness], [Punctuality], [Politeness], [Height_And_Weight], [Extra_Curricular_Activities], [Drill/P.T], [Dance], [Rhymes]) VALUES (102, N'2075', 6, 53, 47, N'', N'', N'A', N'A', N'A', N'', N'A', N'A', N'A', N'A', N'A', N'', N'GOOD', N'A', N'A', N'B', N'3F7"/15KG', N'', N'B', N'A', N'B')
INSERT [dbo].[StudentExtraActivities] ([StudentId], [ActivitiesYear], [ExaminationId], [SchoolDays], [Present_Days], [Reading_And_Writing_Skill], [Recognition_of_Letter], [English], [Nepali], [Copying_Skill], [Students_Academic_Attitude], [Concentration], [Co-operation], [Memory], [Curiosity], [Understanding], [Student_Department], [Conduct], [Neatness_And_Tidiness], [Punctuality], [Politeness], [Height_And_Weight], [Extra_Curricular_Activities], [Drill/P.T], [Dance], [Rhymes]) VALUES (102, N'2075', 7, 244, 226, N'', N'', N'A', N'A', N'A', N'', N'A', N'A', N'A', N'A', N'A', N'', N'GOOD', N'A', N'A', N'A', N'3F8''/16KG', N'', N'A', N'A', N'A')
INSERT [dbo].[StudentExtraActivities] ([StudentId], [ActivitiesYear], [ExaminationId], [SchoolDays], [Present_Days], [Reading_And_Writing_Skill], [Recognition_of_Letter], [English], [Nepali], [Copying_Skill], [Students_Academic_Attitude], [Concentration], [Co-operation], [Memory], [Curiosity], [Understanding], [Student_Department], [Conduct], [Neatness_And_Tidiness], [Punctuality], [Politeness], [Height_And_Weight], [Extra_Curricular_Activities], [Drill/P.T], [Dance], [Rhymes]) VALUES (113, N'2075', 5, 70, 70, N'', N'', N'B', N'B', N'B', N'', N'A', N'B', N'B', N'A', N'B', N'', N'B', N'A', N'A', N'B', N'3F6"/15KG', N'', N'A', N'B', N'A')
INSERT [dbo].[StudentExtraActivities] ([StudentId], [ActivitiesYear], [ExaminationId], [SchoolDays], [Present_Days], [Reading_And_Writing_Skill], [Recognition_of_Letter], [English], [Nepali], [Copying_Skill], [Students_Academic_Attitude], [Concentration], [Co-operation], [Memory], [Curiosity], [Understanding], [Student_Department], [Conduct], [Neatness_And_Tidiness], [Punctuality], [Politeness], [Height_And_Weight], [Extra_Curricular_Activities], [Drill/P.T], [Dance], [Rhymes]) VALUES (113, N'2075', 6, 53, 38, N'', N'', N'B', N'B', N'B', N'', N'A', N'B', N'B', N'A', N'B', N'', N'GOOD', N'A', N'A', N'A', N'3F7"/17KG', N'', N'A', N'B', N'B')
INSERT [dbo].[StudentExtraActivities] ([StudentId], [ActivitiesYear], [ExaminationId], [SchoolDays], [Present_Days], [Reading_And_Writing_Skill], [Recognition_of_Letter], [English], [Nepali], [Copying_Skill], [Students_Academic_Attitude], [Concentration], [Co-operation], [Memory], [Curiosity], [Understanding], [Student_Department], [Conduct], [Neatness_And_Tidiness], [Punctuality], [Politeness], [Height_And_Weight], [Extra_Curricular_Activities], [Drill/P.T], [Dance], [Rhymes]) VALUES (113, N'2075', 7, 244, 224, N'', N'', N'B', N'B', N'B', N'', N'B', N'B', N'B', N'A', N'B', N'', N'A', N'A', N'A', N'A', N'3F8''/17KG', N'', N'B', N'B', N'A')
INSERT [dbo].[StudentExtraActivities] ([StudentId], [ActivitiesYear], [ExaminationId], [SchoolDays], [Present_Days], [Reading_And_Writing_Skill], [Recognition_of_Letter], [English], [Nepali], [Copying_Skill], [Students_Academic_Attitude], [Concentration], [Co-operation], [Memory], [Curiosity], [Understanding], [Student_Department], [Conduct], [Neatness_And_Tidiness], [Punctuality], [Politeness], [Height_And_Weight], [Extra_Curricular_Activities], [Drill/P.T], [Dance], [Rhymes]) VALUES (114, N'2075', 5, 70, 65, N'', N'', N'A', N'A', N'A', N'', N'A', N'B', N'A', N'A', N'A', N'', N'A', N'A', N'B', N'B', N'3F9"/18KG', N'', N'A', N'A', N'A')
INSERT [dbo].[StudentExtraActivities] ([StudentId], [ActivitiesYear], [ExaminationId], [SchoolDays], [Present_Days], [Reading_And_Writing_Skill], [Recognition_of_Letter], [English], [Nepali], [Copying_Skill], [Students_Academic_Attitude], [Concentration], [Co-operation], [Memory], [Curiosity], [Understanding], [Student_Department], [Conduct], [Neatness_And_Tidiness], [Punctuality], [Politeness], [Height_And_Weight], [Extra_Curricular_Activities], [Drill/P.T], [Dance], [Rhymes]) VALUES (114, N'2075', 6, 53, 51, N'', N'', N'A', N'A', N'A', N'', N'A', N'A', N'A', N'A', N'A', N'', N'GOOD', N'A', N'A', N'A', N'3F11"/21KG', N'', N'A', N'A', N'A')
INSERT [dbo].[StudentExtraActivities] ([StudentId], [ActivitiesYear], [ExaminationId], [SchoolDays], [Present_Days], [Reading_And_Writing_Skill], [Recognition_of_Letter], [English], [Nepali], [Copying_Skill], [Students_Academic_Attitude], [Concentration], [Co-operation], [Memory], [Curiosity], [Understanding], [Student_Department], [Conduct], [Neatness_And_Tidiness], [Punctuality], [Politeness], [Height_And_Weight], [Extra_Curricular_Activities], [Drill/P.T], [Dance], [Rhymes]) VALUES (114, N'2075', 7, 244, 232, N'', N'', N'A', N'A', N'A', N'', N'A', N'A', N'A', N'A', N'A', N'', N'A', N'A', N'A', N'A', N'4F/21KG', N'', N'A', N'A', N'A')
INSERT [dbo].[StudentExtraActivities] ([StudentId], [ActivitiesYear], [ExaminationId], [SchoolDays], [Present_Days], [Reading_And_Writing_Skill], [Recognition_of_Letter], [English], [Nepali], [Copying_Skill], [Students_Academic_Attitude], [Concentration], [Co-operation], [Memory], [Curiosity], [Understanding], [Student_Department], [Conduct], [Neatness_And_Tidiness], [Punctuality], [Politeness], [Height_And_Weight], [Extra_Curricular_Activities], [Drill/P.T], [Dance], [Rhymes]) VALUES (115, N'2075', 5, 70, 70, N'', N'', N'B', N'B', N'B', N'', N'A', N'B', N'B', N'A', N'B', N'', N'B', N'B', N'A', N'B', N'3F5"/15KG', N'', N'B', N'B', N'B')
INSERT [dbo].[StudentExtraActivities] ([StudentId], [ActivitiesYear], [ExaminationId], [SchoolDays], [Present_Days], [Reading_And_Writing_Skill], [Recognition_of_Letter], [English], [Nepali], [Copying_Skill], [Students_Academic_Attitude], [Concentration], [Co-operation], [Memory], [Curiosity], [Understanding], [Student_Department], [Conduct], [Neatness_And_Tidiness], [Punctuality], [Politeness], [Height_And_Weight], [Extra_Curricular_Activities], [Drill/P.T], [Dance], [Rhymes]) VALUES (115, N'2075', 6, 53, 52, N'', N'', N'B', N'A', N'B', N'', N'A', N'A', N'B', N'A', N'B', N'', N'GOOD', N'A', N'B', N'B', N'3F6"/16KG', N'', N'B', N'A', N'A')
INSERT [dbo].[StudentExtraActivities] ([StudentId], [ActivitiesYear], [ExaminationId], [SchoolDays], [Present_Days], [Reading_And_Writing_Skill], [Recognition_of_Letter], [English], [Nepali], [Copying_Skill], [Students_Academic_Attitude], [Concentration], [Co-operation], [Memory], [Curiosity], [Understanding], [Student_Department], [Conduct], [Neatness_And_Tidiness], [Punctuality], [Politeness], [Height_And_Weight], [Extra_Curricular_Activities], [Drill/P.T], [Dance], [Rhymes]) VALUES (115, N'2075', 7, 244, 239, N'', N'', N'A', N'B', N'A', N'', N'A', N'B', N'B', N'A', N'A', N'', N'A', N'A', N'B', N'A', N'3F7''/16KG', N'', N'A', N'A', N'A')
INSERT [dbo].[StudentExtraActivities] ([StudentId], [ActivitiesYear], [ExaminationId], [SchoolDays], [Present_Days], [Reading_And_Writing_Skill], [Recognition_of_Letter], [English], [Nepali], [Copying_Skill], [Students_Academic_Attitude], [Concentration], [Co-operation], [Memory], [Curiosity], [Understanding], [Student_Department], [Conduct], [Neatness_And_Tidiness], [Punctuality], [Politeness], [Height_And_Weight], [Extra_Curricular_Activities], [Drill/P.T], [Dance], [Rhymes]) VALUES (116, N'2075', 5, 70, 70, N'', N'', N'A', N'B', N'A', N'', N'A', N'B', N'A', N'A', N'B', N'', N'B', N'A', N'A', N'A', N'3F7"/16KG', N'', N'A', N'B', N'A')
INSERT [dbo].[StudentExtraActivities] ([StudentId], [ActivitiesYear], [ExaminationId], [SchoolDays], [Present_Days], [Reading_And_Writing_Skill], [Recognition_of_Letter], [English], [Nepali], [Copying_Skill], [Students_Academic_Attitude], [Concentration], [Co-operation], [Memory], [Curiosity], [Understanding], [Student_Department], [Conduct], [Neatness_And_Tidiness], [Punctuality], [Politeness], [Height_And_Weight], [Extra_Curricular_Activities], [Drill/P.T], [Dance], [Rhymes]) VALUES (116, N'2075', 6, 53, 48, N'', N'', N'A', N'A', N'A', N'', N'A', N'A', N'A', N'A', N'A', N'', N'GOOD', N'A', N'A', N'A', N'3F9"/19KG', N'', N'A', N'A', N'A')
INSERT [dbo].[StudentExtraActivities] ([StudentId], [ActivitiesYear], [ExaminationId], [SchoolDays], [Present_Days], [Reading_And_Writing_Skill], [Recognition_of_Letter], [English], [Nepali], [Copying_Skill], [Students_Academic_Attitude], [Concentration], [Co-operation], [Memory], [Curiosity], [Understanding], [Student_Department], [Conduct], [Neatness_And_Tidiness], [Punctuality], [Politeness], [Height_And_Weight], [Extra_Curricular_Activities], [Drill/P.T], [Dance], [Rhymes]) VALUES (116, N'2075', 7, 244, 232, N'', N'', N'A', N'A', N'A', N'', N'A', N'A', N'A', N'A', N'A', N'', N'A', N'A', N'A', N'A', N'3F9''/20KG', N'', N'A', N'A', N'A')
INSERT [dbo].[StudentExtraActivities] ([StudentId], [ActivitiesYear], [ExaminationId], [SchoolDays], [Present_Days], [Reading_And_Writing_Skill], [Recognition_of_Letter], [English], [Nepali], [Copying_Skill], [Students_Academic_Attitude], [Concentration], [Co-operation], [Memory], [Curiosity], [Understanding], [Student_Department], [Conduct], [Neatness_And_Tidiness], [Punctuality], [Politeness], [Height_And_Weight], [Extra_Curricular_Activities], [Drill/P.T], [Dance], [Rhymes]) VALUES (117, N'2075', 5, 70, 70, N'', N'', N'A', N'A', N'A', N'', N'A', N'B', N'A', N'A', N'B', N'', N'A+', N'A', N'A', N'A', N'3F6"/18KG', N'', N'A', N'A', N'A')
INSERT [dbo].[StudentExtraActivities] ([StudentId], [ActivitiesYear], [ExaminationId], [SchoolDays], [Present_Days], [Reading_And_Writing_Skill], [Recognition_of_Letter], [English], [Nepali], [Copying_Skill], [Students_Academic_Attitude], [Concentration], [Co-operation], [Memory], [Curiosity], [Understanding], [Student_Department], [Conduct], [Neatness_And_Tidiness], [Punctuality], [Politeness], [Height_And_Weight], [Extra_Curricular_Activities], [Drill/P.T], [Dance], [Rhymes]) VALUES (117, N'2075', 6, 53, 38, N'', N'', N'A', N'A', N'A', N'', N'A', N'A', N'A', N'A', N'A', N'', N'GOOD', N'A', N'A', N'A', N'3F7"/21KG', N'', N'A', N'A', N'A')
INSERT [dbo].[StudentExtraActivities] ([StudentId], [ActivitiesYear], [ExaminationId], [SchoolDays], [Present_Days], [Reading_And_Writing_Skill], [Recognition_of_Letter], [English], [Nepali], [Copying_Skill], [Students_Academic_Attitude], [Concentration], [Co-operation], [Memory], [Curiosity], [Understanding], [Student_Department], [Conduct], [Neatness_And_Tidiness], [Punctuality], [Politeness], [Height_And_Weight], [Extra_Curricular_Activities], [Drill/P.T], [Dance], [Rhymes]) VALUES (117, N'2075', 7, 244, 221, N'', N'', N'A', N'A', N'A', N'', N'A', N'A', N'A', N'A', N'A', N'', N'A', N'A', N'A', N'A', N'3F8''/22KG', N'', N'A', N'A', N'A')
INSERT [dbo].[StudentExtraActivities] ([StudentId], [ActivitiesYear], [ExaminationId], [SchoolDays], [Present_Days], [Reading_And_Writing_Skill], [Recognition_of_Letter], [English], [Nepali], [Copying_Skill], [Students_Academic_Attitude], [Concentration], [Co-operation], [Memory], [Curiosity], [Understanding], [Student_Department], [Conduct], [Neatness_And_Tidiness], [Punctuality], [Politeness], [Height_And_Weight], [Extra_Curricular_Activities], [Drill/P.T], [Dance], [Rhymes]) VALUES (118, N'2075', 5, 70, 69, N'', N'', N'B', N'B', N'B', N'', N'A', N'B', N'A', N'A', N'B', N'', N'B', N'B', N'A', N'A', N'3F11"/17KG', N'', N'B', N'B', N'B')
INSERT [dbo].[StudentExtraActivities] ([StudentId], [ActivitiesYear], [ExaminationId], [SchoolDays], [Present_Days], [Reading_And_Writing_Skill], [Recognition_of_Letter], [English], [Nepali], [Copying_Skill], [Students_Academic_Attitude], [Concentration], [Co-operation], [Memory], [Curiosity], [Understanding], [Student_Department], [Conduct], [Neatness_And_Tidiness], [Punctuality], [Politeness], [Height_And_Weight], [Extra_Curricular_Activities], [Drill/P.T], [Dance], [Rhymes]) VALUES (118, N'2075', 6, 53, 51, N'', N'', N'B', N'B', N'A', N'', N'A', N'A', N'B', N'A', N'B', N'', N'GOOD', N'A', N'B', N'A', N'4F/21KG', N'', N'A', N'B', N'B')
INSERT [dbo].[StudentExtraActivities] ([StudentId], [ActivitiesYear], [ExaminationId], [SchoolDays], [Present_Days], [Reading_And_Writing_Skill], [Recognition_of_Letter], [English], [Nepali], [Copying_Skill], [Students_Academic_Attitude], [Concentration], [Co-operation], [Memory], [Curiosity], [Understanding], [Student_Department], [Conduct], [Neatness_And_Tidiness], [Punctuality], [Politeness], [Height_And_Weight], [Extra_Curricular_Activities], [Drill/P.T], [Dance], [Rhymes]) VALUES (118, N'2075', 7, 244, 236, N'', N'', N'A', N'B', N'A', N'', N'B', N'A', N'B', N'A', N'A', N'', N'A', N'A', N'A', N'A', N'4F9''/22KG', N'', N'A', N'B', N'A')
INSERT [dbo].[StudentExtraActivities] ([StudentId], [ActivitiesYear], [ExaminationId], [SchoolDays], [Present_Days], [Reading_And_Writing_Skill], [Recognition_of_Letter], [English], [Nepali], [Copying_Skill], [Students_Academic_Attitude], [Concentration], [Co-operation], [Memory], [Curiosity], [Understanding], [Student_Department], [Conduct], [Neatness_And_Tidiness], [Punctuality], [Politeness], [Height_And_Weight], [Extra_Curricular_Activities], [Drill/P.T], [Dance], [Rhymes]) VALUES (119, N'2075', 5, 70, 70, N'', N'', N'A', N'A', N'A', N'', N'A', N'B', N'A', N'A', N'A', N'', N'A', N'A', N'A', N'A', N'3F7"/16KG', N'', N'B', N'A', N'A')
INSERT [dbo].[StudentExtraActivities] ([StudentId], [ActivitiesYear], [ExaminationId], [SchoolDays], [Present_Days], [Reading_And_Writing_Skill], [Recognition_of_Letter], [English], [Nepali], [Copying_Skill], [Students_Academic_Attitude], [Concentration], [Co-operation], [Memory], [Curiosity], [Understanding], [Student_Department], [Conduct], [Neatness_And_Tidiness], [Punctuality], [Politeness], [Height_And_Weight], [Extra_Curricular_Activities], [Drill/P.T], [Dance], [Rhymes]) VALUES (119, N'2075', 6, 53, 51, N'', N'', N'A', N'A', N'A', N'', N'A', N'A', N'A', N'A', N'A', N'', N'GOOD', N'A', N'A', N'A', N'3F8"/19KG', N'', N'A', N'A', N'A')
INSERT [dbo].[StudentExtraActivities] ([StudentId], [ActivitiesYear], [ExaminationId], [SchoolDays], [Present_Days], [Reading_And_Writing_Skill], [Recognition_of_Letter], [English], [Nepali], [Copying_Skill], [Students_Academic_Attitude], [Concentration], [Co-operation], [Memory], [Curiosity], [Understanding], [Student_Department], [Conduct], [Neatness_And_Tidiness], [Punctuality], [Politeness], [Height_And_Weight], [Extra_Curricular_Activities], [Drill/P.T], [Dance], [Rhymes]) VALUES (119, N'2075', 7, 244, 237, N'', N'', N'A', N'A', N'A', N'', N'A', N'A', N'A', N'A', N'A', N'', N'A', N'A', N'A', N'A', N'3F9''/19KG', N'', N'A', N'A', N'A')
INSERT [dbo].[StudentExtraActivities] ([StudentId], [ActivitiesYear], [ExaminationId], [SchoolDays], [Present_Days], [Reading_And_Writing_Skill], [Recognition_of_Letter], [English], [Nepali], [Copying_Skill], [Students_Academic_Attitude], [Concentration], [Co-operation], [Memory], [Curiosity], [Understanding], [Student_Department], [Conduct], [Neatness_And_Tidiness], [Punctuality], [Politeness], [Height_And_Weight], [Extra_Curricular_Activities], [Drill/P.T], [Dance], [Rhymes]) VALUES (120, N'2075', 5, 70, 57, N'', N'', N'A', N'B', N'A', N'', N'A', N'B', N'A', N'A', N'A', N'', N'A', N'A', N'B', N'B', N'3F3"/18KG', N'', N'B', N'A', N'A')
INSERT [dbo].[StudentExtraActivities] ([StudentId], [ActivitiesYear], [ExaminationId], [SchoolDays], [Present_Days], [Reading_And_Writing_Skill], [Recognition_of_Letter], [English], [Nepali], [Copying_Skill], [Students_Academic_Attitude], [Concentration], [Co-operation], [Memory], [Curiosity], [Understanding], [Student_Department], [Conduct], [Neatness_And_Tidiness], [Punctuality], [Politeness], [Height_And_Weight], [Extra_Curricular_Activities], [Drill/P.T], [Dance], [Rhymes]) VALUES (120, N'2075', 6, 53, 39, N'', N'', N'A', N'A', N'A', N'', N'A', N'A', N'A', N'A', N'A', N'', N'GOOD', N'A', N'A', N'B', N'3F9"/21KG', N'', N'B', N'A', N'A')
INSERT [dbo].[StudentExtraActivities] ([StudentId], [ActivitiesYear], [ExaminationId], [SchoolDays], [Present_Days], [Reading_And_Writing_Skill], [Recognition_of_Letter], [English], [Nepali], [Copying_Skill], [Students_Academic_Attitude], [Concentration], [Co-operation], [Memory], [Curiosity], [Understanding], [Student_Department], [Conduct], [Neatness_And_Tidiness], [Punctuality], [Politeness], [Height_And_Weight], [Extra_Curricular_Activities], [Drill/P.T], [Dance], [Rhymes]) VALUES (120, N'2075', 7, 244, 205, N'', N'', N'A', N'A', N'A', N'', N'A', N'A', N'A', N'A', N'A', N'', N'A', N'A', N'A', N'A', N'3F10''/21KG', N'', N'A', N'A', N'A')
INSERT [dbo].[StudentExtraActivities] ([StudentId], [ActivitiesYear], [ExaminationId], [SchoolDays], [Present_Days], [Reading_And_Writing_Skill], [Recognition_of_Letter], [English], [Nepali], [Copying_Skill], [Students_Academic_Attitude], [Concentration], [Co-operation], [Memory], [Curiosity], [Understanding], [Student_Department], [Conduct], [Neatness_And_Tidiness], [Punctuality], [Politeness], [Height_And_Weight], [Extra_Curricular_Activities], [Drill/P.T], [Dance], [Rhymes]) VALUES (131, N'2075', 5, 70, 36, N'', N'', N'C', N'C', N'B', N'', N'B', N'B', N'B', N'B', N'B', N'', N'GOOD', N'A', N'A', N'B', N'3F2"/14KG', N'', N'B', N'B', N'B')
INSERT [dbo].[StudentExtraActivities] ([StudentId], [ActivitiesYear], [ExaminationId], [SchoolDays], [Present_Days], [Reading_And_Writing_Skill], [Recognition_of_Letter], [English], [Nepali], [Copying_Skill], [Students_Academic_Attitude], [Concentration], [Co-operation], [Memory], [Curiosity], [Understanding], [Student_Department], [Conduct], [Neatness_And_Tidiness], [Punctuality], [Politeness], [Height_And_Weight], [Extra_Curricular_Activities], [Drill/P.T], [Dance], [Rhymes]) VALUES (131, N'2075', 6, 53, 47, N'', N'', N'B', N'B', N'B', N'', N'B', N'B', N'B', N'B', N'B', N'', N'GOOD', N'A', N'A', N'B', N'3F4"/16KG', N'', N'B', N'B', N'B')
INSERT [dbo].[StudentExtraActivities] ([StudentId], [ActivitiesYear], [ExaminationId], [SchoolDays], [Present_Days], [Reading_And_Writing_Skill], [Recognition_of_Letter], [English], [Nepali], [Copying_Skill], [Students_Academic_Attitude], [Concentration], [Co-operation], [Memory], [Curiosity], [Understanding], [Student_Department], [Conduct], [Neatness_And_Tidiness], [Punctuality], [Politeness], [Height_And_Weight], [Extra_Curricular_Activities], [Drill/P.T], [Dance], [Rhymes]) VALUES (131, N'2075', 7, 244, 156, N'', N'', N'A', N'A', N'A', N'', N'A', N'B', N'B', N'A', N'B', N'', N'GOOD', N'A', N'A', N'A', N'3F5''/18KG', N'', N'B', N'B', N'B')
INSERT [dbo].[StudentExtraActivities] ([StudentId], [ActivitiesYear], [ExaminationId], [SchoolDays], [Present_Days], [Reading_And_Writing_Skill], [Recognition_of_Letter], [English], [Nepali], [Copying_Skill], [Students_Academic_Attitude], [Concentration], [Co-operation], [Memory], [Curiosity], [Understanding], [Student_Department], [Conduct], [Neatness_And_Tidiness], [Punctuality], [Politeness], [Height_And_Weight], [Extra_Curricular_Activities], [Drill/P.T], [Dance], [Rhymes]) VALUES (132, N'2076', 8, 70, 68, N'', N'', N'A', N'A', N'A', N'', N'A', N'A', N'A', N'A', N'A', N'', N'GOOD', N'A', N'A', N'A', N'3F/14KG', N'', N'A', N'B', N'B')
INSERT [dbo].[StudentExtraActivities] ([StudentId], [ActivitiesYear], [ExaminationId], [SchoolDays], [Present_Days], [Reading_And_Writing_Skill], [Recognition_of_Letter], [English], [Nepali], [Copying_Skill], [Students_Academic_Attitude], [Concentration], [Co-operation], [Memory], [Curiosity], [Understanding], [Student_Department], [Conduct], [Neatness_And_Tidiness], [Punctuality], [Politeness], [Height_And_Weight], [Extra_Curricular_Activities], [Drill/P.T], [Dance], [Rhymes]) VALUES (132, N'2076', 9, 58, 44, N'', N'', N'A', N'A', N'A', N'', N'A', N'A', N'A', N'A', N'A', N'', N'GOOD', N'A', N'A', N'A', N'3F2''/14KG', N'', N'A', N'B', N'A')
INSERT [dbo].[StudentExtraActivities] ([StudentId], [ActivitiesYear], [ExaminationId], [SchoolDays], [Present_Days], [Reading_And_Writing_Skill], [Recognition_of_Letter], [English], [Nepali], [Copying_Skill], [Students_Academic_Attitude], [Concentration], [Co-operation], [Memory], [Curiosity], [Understanding], [Student_Department], [Conduct], [Neatness_And_Tidiness], [Punctuality], [Politeness], [Height_And_Weight], [Extra_Curricular_Activities], [Drill/P.T], [Dance], [Rhymes]) VALUES (132, N'2076', 10, 60, 56, N'', N'', N'A', N'A', N'A', N'', N'A', N'A', N'A', N'A', N'A', N'', N'GOOD', N'A', N'A', N'A', N'3F2''/14KG', N'', N'A', N'B', N'A')
INSERT [dbo].[StudentExtraActivities] ([StudentId], [ActivitiesYear], [ExaminationId], [SchoolDays], [Present_Days], [Reading_And_Writing_Skill], [Recognition_of_Letter], [English], [Nepali], [Copying_Skill], [Students_Academic_Attitude], [Concentration], [Co-operation], [Memory], [Curiosity], [Understanding], [Student_Department], [Conduct], [Neatness_And_Tidiness], [Punctuality], [Politeness], [Height_And_Weight], [Extra_Curricular_Activities], [Drill/P.T], [Dance], [Rhymes]) VALUES (133, N'2076', 8, 70, 60, N'', N'', N'B', N'B', N'C', N'', N'C', N'C', N'B', N'B', N'B', N'', N'GOOD', N'A', N'A', N'B', N'3F3''/15KG', N'', N'A', N'B', N'B')
INSERT [dbo].[StudentExtraActivities] ([StudentId], [ActivitiesYear], [ExaminationId], [SchoolDays], [Present_Days], [Reading_And_Writing_Skill], [Recognition_of_Letter], [English], [Nepali], [Copying_Skill], [Students_Academic_Attitude], [Concentration], [Co-operation], [Memory], [Curiosity], [Understanding], [Student_Department], [Conduct], [Neatness_And_Tidiness], [Punctuality], [Politeness], [Height_And_Weight], [Extra_Curricular_Activities], [Drill/P.T], [Dance], [Rhymes]) VALUES (133, N'2076', 9, 58, 55, N'', N'', N'A', N'A', N'B', N'', N'B', N'B', N'A', N'A', N'A', N'', N'GOOD', N'A', N'A', N'B', N'3F5''/16KG', N'', N'A', N'B', N'A')
INSERT [dbo].[StudentExtraActivities] ([StudentId], [ActivitiesYear], [ExaminationId], [SchoolDays], [Present_Days], [Reading_And_Writing_Skill], [Recognition_of_Letter], [English], [Nepali], [Copying_Skill], [Students_Academic_Attitude], [Concentration], [Co-operation], [Memory], [Curiosity], [Understanding], [Student_Department], [Conduct], [Neatness_And_Tidiness], [Punctuality], [Politeness], [Height_And_Weight], [Extra_Curricular_Activities], [Drill/P.T], [Dance], [Rhymes]) VALUES (133, N'2076', 10, 60, 0, N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'')
INSERT [dbo].[StudentExtraActivities] ([StudentId], [ActivitiesYear], [ExaminationId], [SchoolDays], [Present_Days], [Reading_And_Writing_Skill], [Recognition_of_Letter], [English], [Nepali], [Copying_Skill], [Students_Academic_Attitude], [Concentration], [Co-operation], [Memory], [Curiosity], [Understanding], [Student_Department], [Conduct], [Neatness_And_Tidiness], [Punctuality], [Politeness], [Height_And_Weight], [Extra_Curricular_Activities], [Drill/P.T], [Dance], [Rhymes]) VALUES (134, N'2076', 8, 70, 56, N'', N'', N'B', N'B', N'B', N'', N'B', N'B', N'B', N'A', N'B', N'', N'GOOD', N'A', N'A', N'B', N'2F11''/13KG', N'', N'A', N'B', N'B')
INSERT [dbo].[StudentExtraActivities] ([StudentId], [ActivitiesYear], [ExaminationId], [SchoolDays], [Present_Days], [Reading_And_Writing_Skill], [Recognition_of_Letter], [English], [Nepali], [Copying_Skill], [Students_Academic_Attitude], [Concentration], [Co-operation], [Memory], [Curiosity], [Understanding], [Student_Department], [Conduct], [Neatness_And_Tidiness], [Punctuality], [Politeness], [Height_And_Weight], [Extra_Curricular_Activities], [Drill/P.T], [Dance], [Rhymes]) VALUES (134, N'2076', 9, 58, 49, N'', N'', N'A', N'A', N'B', N'', N'B', N'B', N'A', N'A', N'A', N'', N'GOOD', N'A', N'A', N'B', N'3F/13KG', N'', N'A', N'B', N'A')
INSERT [dbo].[StudentExtraActivities] ([StudentId], [ActivitiesYear], [ExaminationId], [SchoolDays], [Present_Days], [Reading_And_Writing_Skill], [Recognition_of_Letter], [English], [Nepali], [Copying_Skill], [Students_Academic_Attitude], [Concentration], [Co-operation], [Memory], [Curiosity], [Understanding], [Student_Department], [Conduct], [Neatness_And_Tidiness], [Punctuality], [Politeness], [Height_And_Weight], [Extra_Curricular_Activities], [Drill/P.T], [Dance], [Rhymes]) VALUES (134, N'2076', 10, 60, 45, N'', N'', N'A', N'A', N'A', N'', N'A', N'A', N'A', N'A', N'A', N'', N'GOOD', N'A', N'A', N'A', N'3F1''/14KF', N'', N'A', N'B', N'A')
INSERT [dbo].[StudentExtraActivities] ([StudentId], [ActivitiesYear], [ExaminationId], [SchoolDays], [Present_Days], [Reading_And_Writing_Skill], [Recognition_of_Letter], [English], [Nepali], [Copying_Skill], [Students_Academic_Attitude], [Concentration], [Co-operation], [Memory], [Curiosity], [Understanding], [Student_Department], [Conduct], [Neatness_And_Tidiness], [Punctuality], [Politeness], [Height_And_Weight], [Extra_Curricular_Activities], [Drill/P.T], [Dance], [Rhymes]) VALUES (135, N'2076', 8, 70, 64, N'', N'', N'B', N'B', N'C', N'', N'C', N'C', N'C', N'B', N'B', N'', N'GOOD', N'A', N'A', N'B', N'2F11''/14KG', N'', N'A', N'B', N'B')
INSERT [dbo].[StudentExtraActivities] ([StudentId], [ActivitiesYear], [ExaminationId], [SchoolDays], [Present_Days], [Reading_And_Writing_Skill], [Recognition_of_Letter], [English], [Nepali], [Copying_Skill], [Students_Academic_Attitude], [Concentration], [Co-operation], [Memory], [Curiosity], [Understanding], [Student_Department], [Conduct], [Neatness_And_Tidiness], [Punctuality], [Politeness], [Height_And_Weight], [Extra_Curricular_Activities], [Drill/P.T], [Dance], [Rhymes]) VALUES (135, N'2076', 9, 58, 55, N'', N'', N'B', N'B', N'C', N'', N'C', N'C', N'C', N'C', N'C', N'', N'GOOD', N'A', N'A', N'B', N'3F/14KG', N'', N'A', N'B', N'B')
INSERT [dbo].[StudentExtraActivities] ([StudentId], [ActivitiesYear], [ExaminationId], [SchoolDays], [Present_Days], [Reading_And_Writing_Skill], [Recognition_of_Letter], [English], [Nepali], [Copying_Skill], [Students_Academic_Attitude], [Concentration], [Co-operation], [Memory], [Curiosity], [Understanding], [Student_Department], [Conduct], [Neatness_And_Tidiness], [Punctuality], [Politeness], [Height_And_Weight], [Extra_Curricular_Activities], [Drill/P.T], [Dance], [Rhymes]) VALUES (135, N'2076', 10, 60, 53, N'', N'', N'B', N'B', N'B', N'', N'B', N'B', N'B', N'B', N'B', N'', N'GOOD', N'A', N'A', N'B', N'3F1''/14KF', N'', N'A', N'B', N'B')
INSERT [dbo].[StudentExtraActivities] ([StudentId], [ActivitiesYear], [ExaminationId], [SchoolDays], [Present_Days], [Reading_And_Writing_Skill], [Recognition_of_Letter], [English], [Nepali], [Copying_Skill], [Students_Academic_Attitude], [Concentration], [Co-operation], [Memory], [Curiosity], [Understanding], [Student_Department], [Conduct], [Neatness_And_Tidiness], [Punctuality], [Politeness], [Height_And_Weight], [Extra_Curricular_Activities], [Drill/P.T], [Dance], [Rhymes]) VALUES (146, N'2076', 8, 70, 63, N'', N'', N'A', N'A', N'A', N'', N'A', N'A', N'A', N'A', N'B', N'', N'GOOD', N'A', N'A', N'B', N'3F5''/16KG', N'', N'A', N'B', N'A')
INSERT [dbo].[StudentExtraActivities] ([StudentId], [ActivitiesYear], [ExaminationId], [SchoolDays], [Present_Days], [Reading_And_Writing_Skill], [Recognition_of_Letter], [English], [Nepali], [Copying_Skill], [Students_Academic_Attitude], [Concentration], [Co-operation], [Memory], [Curiosity], [Understanding], [Student_Department], [Conduct], [Neatness_And_Tidiness], [Punctuality], [Politeness], [Height_And_Weight], [Extra_Curricular_Activities], [Drill/P.T], [Dance], [Rhymes]) VALUES (146, N'2076', 9, 58, 58, N'', N'', N'A', N'A', N'A', N'', N'A', N'A', N'A', N'A', N'A', N'', N'GOOD', N'A', N'A', N'B', N'3F5''/17KG', N'', N'A', N'B', N'A')
INSERT [dbo].[StudentExtraActivities] ([StudentId], [ActivitiesYear], [ExaminationId], [SchoolDays], [Present_Days], [Reading_And_Writing_Skill], [Recognition_of_Letter], [English], [Nepali], [Copying_Skill], [Students_Academic_Attitude], [Concentration], [Co-operation], [Memory], [Curiosity], [Understanding], [Student_Department], [Conduct], [Neatness_And_Tidiness], [Punctuality], [Politeness], [Height_And_Weight], [Extra_Curricular_Activities], [Drill/P.T], [Dance], [Rhymes]) VALUES (146, N'2076', 10, 60, 60, N'', N'', N'A', N'A', N'A', N'', N'A', N'A', N'A', N'A', N'A', N'', N'GOOD', N'A', N'A', N'A', N'3F6''/17KG', N'', N'A', N'A', N'A')
INSERT [dbo].[StudentExtraActivities] ([StudentId], [ActivitiesYear], [ExaminationId], [SchoolDays], [Present_Days], [Reading_And_Writing_Skill], [Recognition_of_Letter], [English], [Nepali], [Copying_Skill], [Students_Academic_Attitude], [Concentration], [Co-operation], [Memory], [Curiosity], [Understanding], [Student_Department], [Conduct], [Neatness_And_Tidiness], [Punctuality], [Politeness], [Height_And_Weight], [Extra_Curricular_Activities], [Drill/P.T], [Dance], [Rhymes]) VALUES (147, N'2076', 8, 70, 69, N'', N'', N'A', N'A', N'A', N'', N'A', N'A', N'A', N'A', N'B', N'', N'GOOD', N'B', N'A', N'B', N'3F5''/19KG', N'', N'A', N'B', N'A')
INSERT [dbo].[StudentExtraActivities] ([StudentId], [ActivitiesYear], [ExaminationId], [SchoolDays], [Present_Days], [Reading_And_Writing_Skill], [Recognition_of_Letter], [English], [Nepali], [Copying_Skill], [Students_Academic_Attitude], [Concentration], [Co-operation], [Memory], [Curiosity], [Understanding], [Student_Department], [Conduct], [Neatness_And_Tidiness], [Punctuality], [Politeness], [Height_And_Weight], [Extra_Curricular_Activities], [Drill/P.T], [Dance], [Rhymes]) VALUES (147, N'2076', 9, 58, 55, N'', N'', N'A', N'A', N'A', N'', N'A', N'A', N'A', N'B', N'B', N'', N'GOOD', N'B', N'B', N'A', N'3F5''/19KG', N'', N'A', N'B', N'A')
INSERT [dbo].[StudentExtraActivities] ([StudentId], [ActivitiesYear], [ExaminationId], [SchoolDays], [Present_Days], [Reading_And_Writing_Skill], [Recognition_of_Letter], [English], [Nepali], [Copying_Skill], [Students_Academic_Attitude], [Concentration], [Co-operation], [Memory], [Curiosity], [Understanding], [Student_Department], [Conduct], [Neatness_And_Tidiness], [Punctuality], [Politeness], [Height_And_Weight], [Extra_Curricular_Activities], [Drill/P.T], [Dance], [Rhymes]) VALUES (147, N'2076', 10, 60, 57, N'', N'', N'A', N'A', N'A', N'', N'A', N'A', N'A', N'B', N'A', N'', N'GOOD', N'A', N'A', N'A', N'3F6''/21KG', N'', N'A', N'B', N'A')
INSERT [dbo].[StudentExtraActivities] ([StudentId], [ActivitiesYear], [ExaminationId], [SchoolDays], [Present_Days], [Reading_And_Writing_Skill], [Recognition_of_Letter], [English], [Nepali], [Copying_Skill], [Students_Academic_Attitude], [Concentration], [Co-operation], [Memory], [Curiosity], [Understanding], [Student_Department], [Conduct], [Neatness_And_Tidiness], [Punctuality], [Politeness], [Height_And_Weight], [Extra_Curricular_Activities], [Drill/P.T], [Dance], [Rhymes]) VALUES (148, N'2076', 8, 70, 66, N'', N'', N'A', N'A', N'A', N'', N'A', N'A', N'A', N'A', N'A', N'', N'GOOD', N'A', N'A', N'B', N'3F4''/14KG', N'', N'A', N'B', N'A')
INSERT [dbo].[StudentExtraActivities] ([StudentId], [ActivitiesYear], [ExaminationId], [SchoolDays], [Present_Days], [Reading_And_Writing_Skill], [Recognition_of_Letter], [English], [Nepali], [Copying_Skill], [Students_Academic_Attitude], [Concentration], [Co-operation], [Memory], [Curiosity], [Understanding], [Student_Department], [Conduct], [Neatness_And_Tidiness], [Punctuality], [Politeness], [Height_And_Weight], [Extra_Curricular_Activities], [Drill/P.T], [Dance], [Rhymes]) VALUES (148, N'2076', 9, 58, 56, N'', N'', N'A', N'A', N'A', N'', N'A', N'A', N'A', N'A', N'A', N'', N'GOOD', N'A', N'A', N'A', N'3F4''/14KG', N'', N'A', N'B', N'A')
INSERT [dbo].[StudentExtraActivities] ([StudentId], [ActivitiesYear], [ExaminationId], [SchoolDays], [Present_Days], [Reading_And_Writing_Skill], [Recognition_of_Letter], [English], [Nepali], [Copying_Skill], [Students_Academic_Attitude], [Concentration], [Co-operation], [Memory], [Curiosity], [Understanding], [Student_Department], [Conduct], [Neatness_And_Tidiness], [Punctuality], [Politeness], [Height_And_Weight], [Extra_Curricular_Activities], [Drill/P.T], [Dance], [Rhymes]) VALUES (148, N'2076', 10, 60, 57, N'', N'', N'A', N'A', N'A', N'', N'A', N'A', N'A', N'A', N'A', N'', N'GOOD', N'A', N'A', N'A', N'3F5''/15KG', N'', N'A', N'B', N'A')
INSERT [dbo].[StudentExtraActivities] ([StudentId], [ActivitiesYear], [ExaminationId], [SchoolDays], [Present_Days], [Reading_And_Writing_Skill], [Recognition_of_Letter], [English], [Nepali], [Copying_Skill], [Students_Academic_Attitude], [Concentration], [Co-operation], [Memory], [Curiosity], [Understanding], [Student_Department], [Conduct], [Neatness_And_Tidiness], [Punctuality], [Politeness], [Height_And_Weight], [Extra_Curricular_Activities], [Drill/P.T], [Dance], [Rhymes]) VALUES (160, N'2076', 8, 70, 67, N'', N'', N'A', N'A', N'B', N'', N'A', N'A', N'A', N'A', N'A', N'', N'A', N'A', N'A', N'A', N'3F4''/15KG', N'', N'A', N'B', N'A')
INSERT [dbo].[StudentExtraActivities] ([StudentId], [ActivitiesYear], [ExaminationId], [SchoolDays], [Present_Days], [Reading_And_Writing_Skill], [Recognition_of_Letter], [English], [Nepali], [Copying_Skill], [Students_Academic_Attitude], [Concentration], [Co-operation], [Memory], [Curiosity], [Understanding], [Student_Department], [Conduct], [Neatness_And_Tidiness], [Punctuality], [Politeness], [Height_And_Weight], [Extra_Curricular_Activities], [Drill/P.T], [Dance], [Rhymes]) VALUES (160, N'2076', 9, 58, 57, N'', N'', N'A', N'A', N'B', N'', N'A', N'A', N'A', N'A', N'A', N'', N'GOOD', N'A', N'A', N'A', N'3F5''/17KG', N'', N'A', N'A', N'A')
INSERT [dbo].[StudentExtraActivities] ([StudentId], [ActivitiesYear], [ExaminationId], [SchoolDays], [Present_Days], [Reading_And_Writing_Skill], [Recognition_of_Letter], [English], [Nepali], [Copying_Skill], [Students_Academic_Attitude], [Concentration], [Co-operation], [Memory], [Curiosity], [Understanding], [Student_Department], [Conduct], [Neatness_And_Tidiness], [Punctuality], [Politeness], [Height_And_Weight], [Extra_Curricular_Activities], [Drill/P.T], [Dance], [Rhymes]) VALUES (160, N'2076', 10, 60, 60, N'', N'', N'A', N'A', N'A', N'', N'A', N'A', N'A', N'A', N'A', N'', N'GOOD', N'A', N'A', N'A', N'3F6''/17KG', N'', N'A', N'A', N'A')
INSERT [dbo].[StudentExtraActivities] ([StudentId], [ActivitiesYear], [ExaminationId], [SchoolDays], [Present_Days], [Reading_And_Writing_Skill], [Recognition_of_Letter], [English], [Nepali], [Copying_Skill], [Students_Academic_Attitude], [Concentration], [Co-operation], [Memory], [Curiosity], [Understanding], [Student_Department], [Conduct], [Neatness_And_Tidiness], [Punctuality], [Politeness], [Height_And_Weight], [Extra_Curricular_Activities], [Drill/P.T], [Dance], [Rhymes]) VALUES (161, N'2076', 8, 70, 65, N'', N'', N'A', N'A', N'A', N'', N'A', N'B', N'A', N'A', N'A', N'', N'B', N'A', N'A', N'A', N'3F4''/15KG', N'', N'A', N'A', N'A')
INSERT [dbo].[StudentExtraActivities] ([StudentId], [ActivitiesYear], [ExaminationId], [SchoolDays], [Present_Days], [Reading_And_Writing_Skill], [Recognition_of_Letter], [English], [Nepali], [Copying_Skill], [Students_Academic_Attitude], [Concentration], [Co-operation], [Memory], [Curiosity], [Understanding], [Student_Department], [Conduct], [Neatness_And_Tidiness], [Punctuality], [Politeness], [Height_And_Weight], [Extra_Curricular_Activities], [Drill/P.T], [Dance], [Rhymes]) VALUES (161, N'2076', 9, 58, 57, N'', N'', N'A', N'A', N'B', N'', N'A', N'B', N'B', N'A', N'A', N'', N'GOOD', N'A', N'A', N'A', N'3F4''/15KG', N'', N'A', N'A', N'A')
INSERT [dbo].[StudentExtraActivities] ([StudentId], [ActivitiesYear], [ExaminationId], [SchoolDays], [Present_Days], [Reading_And_Writing_Skill], [Recognition_of_Letter], [English], [Nepali], [Copying_Skill], [Students_Academic_Attitude], [Concentration], [Co-operation], [Memory], [Curiosity], [Understanding], [Student_Department], [Conduct], [Neatness_And_Tidiness], [Punctuality], [Politeness], [Height_And_Weight], [Extra_Curricular_Activities], [Drill/P.T], [Dance], [Rhymes]) VALUES (161, N'2076', 10, 60, 57, N'', N'', N'A', N'A', N'A', N'', N'A', N'A', N'B', N'A', N'A', N'', N'GOOD', N'A', N'A', N'A', N'3F5''/17KG', N'', N'A', N'A', N'A')
INSERT [dbo].[StudentExtraActivities] ([StudentId], [ActivitiesYear], [ExaminationId], [SchoolDays], [Present_Days], [Reading_And_Writing_Skill], [Recognition_of_Letter], [English], [Nepali], [Copying_Skill], [Students_Academic_Attitude], [Concentration], [Co-operation], [Memory], [Curiosity], [Understanding], [Student_Department], [Conduct], [Neatness_And_Tidiness], [Punctuality], [Politeness], [Height_And_Weight], [Extra_Curricular_Activities], [Drill/P.T], [Dance], [Rhymes]) VALUES (162, N'2076', 8, 70, 65, N'', N'', N'B', N'B', N'B', N'', N'A', N'B', N'B', N'B', N'A', N'', N'B', N'A', N'A', N'B', N'3F9''/17KG', N'', N'A', N'B', N'A')
INSERT [dbo].[StudentExtraActivities] ([StudentId], [ActivitiesYear], [ExaminationId], [SchoolDays], [Present_Days], [Reading_And_Writing_Skill], [Recognition_of_Letter], [English], [Nepali], [Copying_Skill], [Students_Academic_Attitude], [Concentration], [Co-operation], [Memory], [Curiosity], [Understanding], [Student_Department], [Conduct], [Neatness_And_Tidiness], [Punctuality], [Politeness], [Height_And_Weight], [Extra_Curricular_Activities], [Drill/P.T], [Dance], [Rhymes]) VALUES (162, N'2076', 9, 58, 52, N'', N'', N'B', N'A', N'B', N'', N'A', N'B', N'B', N'B', N'A', N'', N'GOOD', N'A', N'A', N'B', N'3F9''/20KG', N'', N'A', N'A', N'A')
INSERT [dbo].[StudentExtraActivities] ([StudentId], [ActivitiesYear], [ExaminationId], [SchoolDays], [Present_Days], [Reading_And_Writing_Skill], [Recognition_of_Letter], [English], [Nepali], [Copying_Skill], [Students_Academic_Attitude], [Concentration], [Co-operation], [Memory], [Curiosity], [Understanding], [Student_Department], [Conduct], [Neatness_And_Tidiness], [Punctuality], [Politeness], [Height_And_Weight], [Extra_Curricular_Activities], [Drill/P.T], [Dance], [Rhymes]) VALUES (162, N'2076', 10, 60, 51, N'', N'', N'A', N'B', N'B', N'', N'A', N'A', N'B', N'B', N'A', N'', N'GOOD', N'A', N'A', N'B', N'3F10''/20KG', N'', N'A', N'A', N'A')
INSERT [dbo].[StudentExtraActivities] ([StudentId], [ActivitiesYear], [ExaminationId], [SchoolDays], [Present_Days], [Reading_And_Writing_Skill], [Recognition_of_Letter], [English], [Nepali], [Copying_Skill], [Students_Academic_Attitude], [Concentration], [Co-operation], [Memory], [Curiosity], [Understanding], [Student_Department], [Conduct], [Neatness_And_Tidiness], [Punctuality], [Politeness], [Height_And_Weight], [Extra_Curricular_Activities], [Drill/P.T], [Dance], [Rhymes]) VALUES (163, N'2076', 8, 70, 60, N'', N'', N'A', N'A', N'A', N'', N'A', N'B', N'B', N'B', N'A', N'', N'B', N'A', N'B', N'A', N'3F9''/18KG', N'', N'A', N'A', N'A')
INSERT [dbo].[StudentExtraActivities] ([StudentId], [ActivitiesYear], [ExaminationId], [SchoolDays], [Present_Days], [Reading_And_Writing_Skill], [Recognition_of_Letter], [English], [Nepali], [Copying_Skill], [Students_Academic_Attitude], [Concentration], [Co-operation], [Memory], [Curiosity], [Understanding], [Student_Department], [Conduct], [Neatness_And_Tidiness], [Punctuality], [Politeness], [Height_And_Weight], [Extra_Curricular_Activities], [Drill/P.T], [Dance], [Rhymes]) VALUES (163, N'2076', 9, 58, 52, N'', N'', N'A', N'A', N'A', N'', N'A', N'B', N'A', N'A', N'A', N'', N'GOOD', N'A', N'A', N'A', N'3F9''/20KG', N'', N'A', N'A', N'A')
INSERT [dbo].[StudentExtraActivities] ([StudentId], [ActivitiesYear], [ExaminationId], [SchoolDays], [Present_Days], [Reading_And_Writing_Skill], [Recognition_of_Letter], [English], [Nepali], [Copying_Skill], [Students_Academic_Attitude], [Concentration], [Co-operation], [Memory], [Curiosity], [Understanding], [Student_Department], [Conduct], [Neatness_And_Tidiness], [Punctuality], [Politeness], [Height_And_Weight], [Extra_Curricular_Activities], [Drill/P.T], [Dance], [Rhymes]) VALUES (163, N'2076', 10, 60, 57, N'', N'', N'A', N'A', N'A', N'', N'A', N'A', N'A', N'A', N'A', N'', N'GOOD', N'A', N'A', N'A', N'6F10''/20KG', N'', N'A', N'A', N'A')
SET IDENTITY_INSERT [dbo].[Subjects] ON 

INSERT [dbo].[Subjects] ([SubjectId], [SubjectName], [ClassId]) VALUES (26, N'English (Writing)', 1)
INSERT [dbo].[Subjects] ([SubjectId], [SubjectName], [ClassId]) VALUES (27, N'English (Oral)', 1)
INSERT [dbo].[Subjects] ([SubjectId], [SubjectName], [ClassId]) VALUES (28, N'Nepali (Writing)', 1)
INSERT [dbo].[Subjects] ([SubjectId], [SubjectName], [ClassId]) VALUES (29, N'Nepali (Oral)', 1)
INSERT [dbo].[Subjects] ([SubjectId], [SubjectName], [ClassId]) VALUES (30, N'Math (Writing)', 1)
INSERT [dbo].[Subjects] ([SubjectId], [SubjectName], [ClassId]) VALUES (31, N'Math (Oral)', 1)
INSERT [dbo].[Subjects] ([SubjectId], [SubjectName], [ClassId]) VALUES (32, N'Drawing and Colour', 1)
INSERT [dbo].[Subjects] ([SubjectId], [SubjectName], [ClassId]) VALUES (33, N'Origami', 1)
INSERT [dbo].[Subjects] ([SubjectId], [SubjectName], [ClassId]) VALUES (34, N'Conversation', 1)
INSERT [dbo].[Subjects] ([SubjectId], [SubjectName], [ClassId]) VALUES (60, N'English', 2)
INSERT [dbo].[Subjects] ([SubjectId], [SubjectName], [ClassId]) VALUES (61, N'Nepali', 2)
INSERT [dbo].[Subjects] ([SubjectId], [SubjectName], [ClassId]) VALUES (62, N'Mathematics', 2)
INSERT [dbo].[Subjects] ([SubjectId], [SubjectName], [ClassId]) VALUES (63, N'Science', 2)
INSERT [dbo].[Subjects] ([SubjectId], [SubjectName], [ClassId]) VALUES (65, N'Drawing and Colour', 2)
INSERT [dbo].[Subjects] ([SubjectId], [SubjectName], [ClassId]) VALUES (66, N'Origami', 2)
INSERT [dbo].[Subjects] ([SubjectId], [SubjectName], [ClassId]) VALUES (67, N'Conversation', 2)
INSERT [dbo].[Subjects] ([SubjectId], [SubjectName], [ClassId]) VALUES (68, N'English', 3)
INSERT [dbo].[Subjects] ([SubjectId], [SubjectName], [ClassId]) VALUES (69, N'Nepali', 3)
INSERT [dbo].[Subjects] ([SubjectId], [SubjectName], [ClassId]) VALUES (70, N'Mathematics', 3)
INSERT [dbo].[Subjects] ([SubjectId], [SubjectName], [ClassId]) VALUES (71, N'Science', 3)
INSERT [dbo].[Subjects] ([SubjectId], [SubjectName], [ClassId]) VALUES (72, N'Social and Informative', 3)
INSERT [dbo].[Subjects] ([SubjectId], [SubjectName], [ClassId]) VALUES (73, N'Drawing and Colour', 3)
INSERT [dbo].[Subjects] ([SubjectId], [SubjectName], [ClassId]) VALUES (74, N'Origami', 3)
INSERT [dbo].[Subjects] ([SubjectId], [SubjectName], [ClassId]) VALUES (75, N'Conversation', 3)
SET IDENTITY_INSERT [dbo].[Subjects] OFF
ALTER TABLE [dbo].[Examination]  WITH CHECK ADD FOREIGN KEY([ExamId])
REFERENCES [dbo].[Exam] ([ExamID])
GO
ALTER TABLE [dbo].[Remarks]  WITH CHECK ADD FOREIGN KEY([ClassId])
REFERENCES [dbo].[Class] ([ClassId])
GO
ALTER TABLE [dbo].[Remarks]  WITH CHECK ADD FOREIGN KEY([ExaminationId])
REFERENCES [dbo].[Examination] ([ExaminationId])
GO
ALTER TABLE [dbo].[Remarks]  WITH CHECK ADD FOREIGN KEY([StudentId])
REFERENCES [dbo].[Student] ([StudentId])
GO
ALTER TABLE [dbo].[StudentClass]  WITH CHECK ADD FOREIGN KEY([ClassId])
REFERENCES [dbo].[Class] ([ClassId])
GO
ALTER TABLE [dbo].[StudentClass]  WITH CHECK ADD FOREIGN KEY([StudentId])
REFERENCES [dbo].[Student] ([StudentId])
GO
ALTER TABLE [dbo].[StudentExams]  WITH CHECK ADD FOREIGN KEY([ClassId])
REFERENCES [dbo].[Class] ([ClassId])
GO
ALTER TABLE [dbo].[StudentExams]  WITH CHECK ADD FOREIGN KEY([ExaminationId])
REFERENCES [dbo].[Examination] ([ExaminationId])
GO
ALTER TABLE [dbo].[StudentExams]  WITH CHECK ADD FOREIGN KEY([StudentId])
REFERENCES [dbo].[Student] ([StudentId])
GO
ALTER TABLE [dbo].[StudentExams]  WITH CHECK ADD FOREIGN KEY([SubjectId])
REFERENCES [dbo].[Subjects] ([SubjectId])
GO
ALTER TABLE [dbo].[StudentExtraActivities]  WITH CHECK ADD  CONSTRAINT [FK__StudentEx__Exami__5441852A] FOREIGN KEY([ExaminationId])
REFERENCES [dbo].[Examination] ([ExaminationId])
GO
ALTER TABLE [dbo].[StudentExtraActivities] CHECK CONSTRAINT [FK__StudentEx__Exami__5441852A]
GO
ALTER TABLE [dbo].[StudentExtraActivities]  WITH CHECK ADD  CONSTRAINT [FK__StudentEx__Stude__5535A963] FOREIGN KEY([StudentId])
REFERENCES [dbo].[Student] ([StudentId])
GO
ALTER TABLE [dbo].[StudentExtraActivities] CHECK CONSTRAINT [FK__StudentEx__Stude__5535A963]
GO
ALTER TABLE [dbo].[Subjects]  WITH CHECK ADD FOREIGN KEY([ClassId])
REFERENCES [dbo].[Class] ([ClassId])
GO
ALTER TABLE [dbo].[GradingSystem]  WITH CHECK ADD CHECK  (([MarksFrom]<=(100)))
GO
ALTER TABLE [dbo].[GradingSystem]  WITH CHECK ADD CHECK  (([MarksTo]<=(100)))
GO
ALTER TABLE [dbo].[GradingSystem]  WITH CHECK ADD CHECK  (([MarksFrom]<=(100)))
GO
ALTER TABLE [dbo].[GradingSystem]  WITH CHECK ADD CHECK  (([MarksTo]<=(100)))
GO
ALTER TABLE [dbo].[GradingSystem]  WITH CHECK ADD CHECK  (([MarksFrom]<=(100)))
GO
ALTER TABLE [dbo].[GradingSystem]  WITH CHECK ADD CHECK  (([MarksTo]<=(100)))
GO
/****** Object:  StoredProcedure [dbo].[Extra_Activities]    Script Date: 3/9/2020 7:31:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Extra_Activities]
	@StudentId int,
	@ExaminationId int
as
begin
SELECT  
	Reading_And_Writing_Skill AS '1. Reading and Writing Skill', 
	Recognition_of_Letter as '  a) Recognition of letters',
	English AS '      English',
	Nepali AS '      Nepali',
	Copying_Skill AS '  b) Copying Skill',
	Students_Academic_Attitude AS '2. Students Academic Attitude',
	Concentration AS '  a) Concentration',
	[Co-operation]  AS  '  b) Co-operative',
	Memory  AS  '  c) Memory',
	Curiosity  AS '  d) Curiosity',
	Understanding AS '  e) Understanding',
	Student_Department AS '3. Student Department',
	Conduct AS '  a) Conduct',
	Neatness_And_Tidiness AS '  b) Neatness and tidiness',
	Punctuality AS '  c) Punctuality',
	Politeness AS '  d) Politeness',
	Height_And_Weight AS '  e) Height and Weight',
	Extra_Curricular_Activities AS '4. Extra Curricular Activities',
	[Drill/P.T] AS '  a) Drill/P.T',
	Dance AS '  b) Dance',
	Rhymes AS '  c) Rhymes',
	SchoolDays,
	Present_Days
	
FROM StudentExtraActivities
WHERE StudentId = @StudentId AND ExaminationId = @ExaminationId 
END
GO
/****** Object:  StoredProcedure [dbo].[GetSchoolInfo]    Script Date: 3/9/2020 7:31:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[GetSchoolInfo]
as
begin
	select top 1 * from School

end

GO
/****** Object:  StoredProcedure [dbo].[SaveUpdateSchool]    Script Date: 3/9/2020 7:31:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[SaveUpdateSchool]
@Id int,
@SchoolName nvarchar(500),
@ShortName nvarchar(10),
@Address nvarchar(500),
@PhoneNo nvarchar(40),
@Email nvarchar(100),
@WebSite nvarchar(100),
@Logo varbinary(max),
@EstiblishedYear int,
@Slogan nvarchar(1000)
as
begin
	if @Id>0
	begin
		update School set SchoolName = @SchoolName, ShortName = @ShortName, Address = @Address, Phone = @PhoneNo, Email = @Email, Website = @WebSite, Logo = @Logo, EstiblishedYear =@EstiblishedYear, Slogan = @Slogan
		where ID = @Id
		select @Id
	end
	else
	begin
		insert into School (SchoolName, ShortName, Address, Phone, Email, Website, Logo, EstiblishedYear,Slogan) values
		(@SchoolName, @ShortName, @Address, @PhoneNo, @Email, @WebSite, @Logo,@EstiblishedYear,@Slogan)
		select @@IDENTITY
	end

end

GO
/****** Object:  StoredProcedure [dbo].[usp_Class_Delete]    Script Date: 3/9/2020 7:31:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[usp_Class_Delete]
	@ClassId int
 as
 begin
	Delete FROM Class WHERE ClassId = @ClassId
 end
GO
/****** Object:  StoredProcedure [dbo].[usp_Class_Save]    Script Date: 3/9/2020 7:31:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[usp_Class_Save]
 @ClassName nvarchar(15)
 as
 begin
	insert INTO Class(ClassName) VALUES(@ClassName)
 end
GO
/****** Object:  StoredProcedure [dbo].[usp_Class_Select]    Script Date: 3/9/2020 7:31:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[usp_Class_Select]
 as
 begin
	select ClassId, ROW_NUMBER() OVER (ORDER BY ClassName) 'S.N', ClassName AS 'Class Name' FROM Class ORDER BY ClassId
 end
GO
/****** Object:  StoredProcedure [dbo].[usp_Class_Update]    Script Date: 3/9/2020 7:31:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[usp_Class_Update]
	@ClassId int,
	@ClassName nvarchar(15)
 as
 begin
	update Class SET ClassName = @ClassName WHERE ClassId = @ClassId 
end
GO
/****** Object:  StoredProcedure [dbo].[usp_Exam_ByYear]    Script Date: 3/9/2020 7:31:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[usp_Exam_ByYear]
	@Year nvarchar(4)
as
begin
	select ex.ExaminationId,  e.ExamName  + ' (' + ex.ExamHeldYear + ')' as  'Exam'	 
	 FROM Examination ex
	INNER JOIN Exam e on ex.ExamId = e.ExamID
	WHERE ex.ExamHeldYear = @Year
end
GO
/****** Object:  StoredProcedure [dbo].[usp_Exam_Delete]    Script Date: 3/9/2020 7:31:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[usp_Exam_Delete]
	@ExaminationID int
as
begin
begin try
begin tran
	DELETE FROM StudentExams WHERE ExaminationId = @ExaminationID
	DELETE FROM Remarks where ExaminationId = @ExaminationID
	DELETE FROM StudentExtraActivities where ExaminationId = @ExaminationID
	DELETE FROM Examination WHERE ExaminationId = @ExaminationID
commit
end try
begin catch
	rollback
end catch
end


GO
/****** Object:  StoredProcedure [dbo].[usp_Exam_Save]    Script Date: 3/9/2020 7:31:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[usp_Exam_Save]
	@HeldYear nvarchar(4),
	@ExamId int,
	@PrintDate date
as
begin
	insert INTO Examination(ExamHeldYear, ExamId,ResultPrintDate) VALUES
	(@HeldYear, @ExamId, @PrintDate)
end
GO
/****** Object:  StoredProcedure [dbo].[usp_Exam_Select]    Script Date: 3/9/2020 7:31:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[usp_Exam_Select]
as
begin
	SELECT ExamID, ExamName FROM Exam
end
GO
/****** Object:  StoredProcedure [dbo].[usp_Exam_Update]    Script Date: 3/9/2020 7:31:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[usp_Exam_Update]
	@HeldYear nvarchar(4),
	@ExamId int,
	@PrintDate date,
	@ExaminationID int
as
begin
	UPDATE Examination SET ExamHeldYear = @HeldYear, ExamId = @ExamId, ResultPrintDate = @PrintDate
	WHERE ExaminationId = @ExaminationID
end
GO
/****** Object:  StoredProcedure [dbo].[usp_Examination_GetByYear]    Script Date: 3/9/2020 7:31:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[usp_Examination_GetByYear]
	@Year nvarchar(4)
as
begin
	select ex.ExaminationId, ROW_NUMBER() OVER (ORDER BY ex.ExamHeldYear desc, ex.ResultPrintDate asc) as 'S.N', e.ExamName as 'Exam', ex.ExamHeldYear as 'Exam Held Year',
	 ex.ResultPrintDate as 'Result Print Date'
	 FROM Examination ex
	INNER JOIN Exam e on ex.ExamId = e.ExamID
	where ex.ExamHeldYear = @Year
end

GO
/****** Object:  StoredProcedure [dbo].[usp_Examination_Select]    Script Date: 3/9/2020 7:31:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[usp_Examination_Select]
as
begin


	select top 20 ex.ExaminationId, ROW_NUMBER() OVER (ORDER BY ex.ExamHeldYear desc, ex.ResultPrintDate asc) as 'S.N', e.ExamName as 'Exam', ex.ExamHeldYear as 'Exam Held Year',
	 ex.ResultPrintDate as 'Result Print Date'
	 FROM Examination ex
	INNER JOIN Exam e on ex.ExamId = e.ExamID


end

GO
/****** Object:  StoredProcedure [dbo].[usp_Examination_SelectById]    Script Date: 3/9/2020 7:31:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[usp_Examination_SelectById]
	@ExamId int
as
begin
	Select ExaminationId, ExamHeldYear, ExamId,ResultPrintDate FROM Examination WHERE ExaminationId = @ExamId
end
GO
/****** Object:  StoredProcedure [dbo].[usp_ExamResult]    Script Date: 3/9/2020 7:31:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



	
CREATE proc [dbo].[usp_ExamResult]
@ExaminationId int,
@ClassId int
as
begin
	declare @minId int, @maxId int
	
	select SN=identity(int ,1,1), sub.ClassId, s.StudentId, ex.ExamName, e.ExamHeldYear, e.ResultPrintDate, 
	c.ClassName, s.StudentFullName,  sc.RollNumber, sub.SubjectName,  se.Grade as 'ObtainedGrade', r.Remarks
	INTO #tempResult   FROM StudentExams se
	INNER JOIN Student s on se.StudentId = s.StudentId
	INNER JOIN Examination e on se.ExaminationId = e.ExaminationId
	INNER JOIN Exam ex on e.ExamId = ex.ExamID
	INNER JOIN Class c on se.ClassId = c.ClassId
	INNER JOIN StudentClass sc on se.StudentId = sc.StudentId AND se.ClassId = sc.ClassId
	INNER JOIN Subjects sub on se.SubjectId = sub.SubjectId
	LEFT JOIN Remarks r ON s.StudentId  =r.StudentId AND sc.ClassId = r.ClassId AND e.ExaminationId = r.ExaminationId
	WHERE se.ExaminationId = @ExaminationId AND se.ClassId = @ClassId
	
	SELECT DISTINCT  StudentId into #StudentRecord FROM #tempResult
	
	
	set @minId = (SELECT MIN(StudentId) from #StudentRecord)
	set @maxId = (SELECT MAX(StudentId) from #StudentRecord)
	WHILE (@minId<= @maxId)
	BEGIN
		if(SELECT COUNT(*) from	#tempResult WHERE StudentId = (SELECT StudentId FROM #StudentRecord WHERE StudentId= @minId) )>0
	BEGIN	
		SELECT * FROM #tempResult WHERE StudentId = (SELECT StudentId FROM #StudentRecord WHERE StudentId= @minId) ORDER BY ClassID
		END
		SET @minId = @minId +1
	END
	
	DROP TABLE #tempResult
	DROP TABLE #StudentRecord
end
GO
/****** Object:  StoredProcedure [dbo].[usp_GetStudentActivities]    Script Date: 3/9/2020 7:31:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[usp_GetStudentActivities]
	@StudentId int,
	@ExaminationId int
as
begin
	declare @Year nvarchar(4)
	set NOCOUNT ON
	SELECT  @Year = ExamHeldYear from Examination WHERE ExaminationId = @ExaminationId
	SELECT * FROM StudentExtraActivities WHERE StudentId = @StudentId 
		AND ActivitiesYear = @Year AND ExaminationId = @ExaminationId
end
GO
/****** Object:  StoredProcedure [dbo].[usp_GradingSystem_Delete]    Script Date: 3/9/2020 7:31:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[usp_GradingSystem_Delete]
@GradingId int
as
begin
	Delete from GradingSystem where GradingSystemId = @GradingId
end
GO
/****** Object:  StoredProcedure [dbo].[usp_GradingSystem_Save]    Script Date: 3/9/2020 7:31:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[usp_GradingSystem_Save]
	@MarksFrom decimal(6,2),
	@MarksTo decimal(6,2),
	@Grade nvarchar(5),
	@Remarks nvarchar(200)
as
begin
	insert into GradingSystem(MarksFrom,MarksTo,Grade,Remarks) values (@MarksFrom,@MarksTo,@Grade,@Remarks)
end
GO
/****** Object:  StoredProcedure [dbo].[usp_GradingSystem_Select]    Script Date: 3/9/2020 7:31:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[usp_GradingSystem_Select]
as
begin
	Select GradingSystemId, 
	ROW_NUMBER() over(order by GradingSystemId) as 'S.N',
	MarksFrom as 'Marks From',
	MarksTo as 'Marks To',Grade,Remarks from GradingSystem
end
GO
/****** Object:  StoredProcedure [dbo].[usp_GradingSystem_Update]    Script Date: 3/9/2020 7:31:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[usp_GradingSystem_Update]
	@GradingId int,
	@MarksFrom decimal(6,2),
	@MarksTo decimal(6,2),
	@Grade nvarchar(5),
	@Remarks nvarchar(200)
as
begin
	update GradingSystem set MarksFrom = @MarksFrom, MarksTo = @MarksTo, Grade = @Grade, Remarks = @Remarks
	where GradingSystemId = @GradingId
end
GO
/****** Object:  StoredProcedure [dbo].[usp_Remarks_Get]    Script Date: 3/9/2020 7:31:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[usp_Remarks_Get]
		@ClassId int,
	@ExaminationId int,
	@ExamHeldYear int
as
begin
	select r.RemarksID, s.StudentId, DENSE_RANK() over(order by s.StudentId) as SN, s.StudentFullName  AS [Student Name], sc.RollNumber as [Roll Number] , r.Remarks
	FROM Student  s
	LEFT JOIN Remarks r on r.StudentId = s.StudentId AND ExaminationId = @ExaminationId 
						AND ExamHeldYear = @ExamHeldYear
	LEFT JOIN StudentClass sc ON s.StudentId = sc.StudentId
	WHERE sc.ClassId =@ClassId  and sc.EnrolledYear = @ExamHeldYear
end


GO
/****** Object:  StoredProcedure [dbo].[usp_Remarks_GetByStudent]    Script Date: 3/9/2020 7:31:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[usp_Remarks_GetByStudent]
	@ClassId int,
	@ExaminationId int,
	@StudentId int
AS
	BEGIN
			select Remarks FROM Remarks WHERE ClassId =@ClassId AND ExaminationId = @ExaminationId 
						AND StudentId = @StudentId	
	END
	
	
GO
/****** Object:  StoredProcedure [dbo].[usp_Remarks_Save]    Script Date: 3/9/2020 7:31:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[usp_Remarks_Save]
	@StudentId int,
	@ClassId int,
	@ExaminationId int,
	@ExamHeldYear int,
	@Remark nvarchar (250)
as
begin
	if not exists(select 'a' from Remarks WHERE StudentId = @StudentId 
											AND ClassId = @ClassId AND ExaminationId = @ExaminationId)
	BEGIN
		INSERT INTO Remarks(StudentId, ClassId, ExaminationId, ExamHeldYear, Remarks) VALUES
			(@StudentId, @ClassId, @ExaminationId, @ExamHeldYear, @Remark)
	END
	ELSE
	BEGIN
		UPDATE Remarks SET Remarks =@Remark WHERE StudentId = @StudentId
					AND ClassId = @ClassId AND ExaminationId = @ExaminationId
	END
end

GO
/****** Object:  StoredProcedure [dbo].[usp_Student_BulkInsert]    Script Date: 3/9/2020 7:31:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[usp_Student_BulkInsert]
@Name nvarchar(100),
@Gender char(1),
@ClassName nvarchar(20),
@Enrolledyear nvarchar(4),
@RollNumber nvarchar(5)
as
begin
begin try
begin tran
	declare @ClassId int, @StudentId int
	set @ClassId = (Select ClassId from Class where ClassName = @ClassName);
	insert into Student(StudentFullName,Gender) values (@Name,@Gender)
	select @StudentId = SCOPE_IDENTITY() from Student
	insert into StudentClass(StudentId,ClassId,EnrolledYear,RollNumber) values (@StudentId,@ClassId,@Enrolledyear,@RollNumber)
commit
end try
begin catch
	rollback
end catch
end
GO
/****** Object:  StoredProcedure [dbo].[usp_Student_Delete]    Script Date: 3/9/2020 7:31:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[usp_Student_Delete]
	@StudentId int
as
begin
begin try
begin tran
	delete from StudentExams where StudentId = @StudentId
	delete from StudentClass where StudentId = @StudentId
	delete from Remarks where StudentId = @StudentId
	delete from StudentExtraActivities where StudentId = @StudentId
	delete from  Student where StudentId = @StudentId
commit
end try
begin catch
	select ERROR_MESSAGE()
	rollback
end catch
end



GO
/****** Object:  StoredProcedure [dbo].[usp_Student_Names]    Script Date: 3/9/2020 7:31:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[usp_Student_Names]
as
begin
	select distinct  StudentFullName from Student s
	inner join StudentClass sc on s.StudentId= sc.StudentId
	order by StudentFullName asc
	
end
GO
/****** Object:  StoredProcedure [dbo].[usp_Student_Save]    Script Date: 3/9/2020 7:31:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[usp_Student_Save]
	@StudentName nvarchar(100),
	@Gender char(1),
	@ClassId int,
	@EnrolledYear nvarchar(4),
	@RollNumber nvarchar(5)
as
begin
begin try
begin tran
	declare @studentId int
	insert into Student(StudentFullName,Gender ) values (@StudentName,@Gender)
	select @studentId = SCOPE_IDENTITY() from Student
	insert into StudentClass(StudentId,ClassId,EnrolledYear,RollNumber) values (@studentId, @ClassId, @EnrolledYear,@RollNumber)
commit
end try
begin catch
	rollback
end catch
end
GO
/****** Object:  StoredProcedure [dbo].[usp_Student_Search]    Script Date: 3/9/2020 7:31:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[usp_Student_Search]
	@Name nvarchar(100),
	@ClassId int,
	@AcademicYear nvarchar(4)
as
begin
	select s.StudentId, ROW_NUMBER() over (order by s.StudentFullName) as 'S.N', s.StudentFullName as 'Name', 
	case 
	when s.Gender = 'M' then 'Male'
	else 'Female'
	end as Gender, c.ClassName as 'Class', sc.EnrolledYear as 'Academic Year', sc.RollNumber from Student s
	inner join StudentClass sc on s.StudentId = sc.StudentId
	inner join Class c on sc.ClassId = c.ClassId
	where (s.StudentFullName like @Name + '%'  or @Name = '' )and sc.ClassId = @ClassId and sc.EnrolledYear  = @AcademicYear
	
end
GO
/****** Object:  StoredProcedure [dbo].[usp_Student_Select]    Script Date: 3/9/2020 7:31:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[usp_Student_Select]
as
begin
	select s.StudentId, ROW_NUMBER() over (order by sc.EnrolledYear desc, c.ClassID desc, CONVERT(INT, sc.RollNumber) asc ) as 'S.N', s.StudentFullName as 'Name', 
	case 
	when s.Gender = 'M' then 'Male'
	else 'Female'
	end as Gender, c.ClassName as 'Class', sc.EnrolledYear as 'Academic Year', sc.RollNumber as [Roll Number] from Student s
	inner join StudentClass sc on s.StudentId = sc.StudentId
	inner join Class c on sc.ClassId = c.ClassId
	where sc.EnrolledYear = (select ISNULL(MAX(EnrolledYear),0) from StudentClass)
end

GO
/****** Object:  StoredProcedure [dbo].[usp_Student_Select_By_Class_Year]    Script Date: 3/9/2020 7:31:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[usp_Student_Select_By_Class_Year]
@ClassId int,
@EnrolledYear varchar(4),
@SubjectId int,
@ExaminationId int
as
begin
	select sc.RollNumber, s.StudentFullName, ISNULL( se.Grade,'')Grade
	 from Student s
	inner join StudentClass sc on s.StudentId = sc.StudentId
	LEFT JOIN StudentExams se on s.StudentId = se.StudentId and sc.ClassId = sc.ClassId 
	AND se.SubjectId = @SubjectId
	AND se.ExaminationId = @ExaminationId
	 LEFT JOIN Subjects sub on se.SubjectId = sub.SubjectId
	where sc.ClassId = @ClassId AND sc.EnrolledYear = @EnrolledYear
	ORDER BY convert(int, sc.RollNumber) ASC
end

GO
/****** Object:  StoredProcedure [dbo].[usp_Student_SelectById]    Script Date: 3/9/2020 7:31:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[usp_Student_SelectById]
@StudentId int,
@EnrolledYear varchar(5)
as
begin
	select s.StudentFullName, s.Gender, sc.ClassId, sc.EnrolledYear, sc.RollNumber from Student s
	inner join StudentClass sc on s.StudentId = sc.StudentId
	where s.StudentId = @StudentId and sc.EnrolledYear = @EnrolledYear
end
GO
/****** Object:  StoredProcedure [dbo].[usp_Student_Transfer]    Script Date: 3/9/2020 7:31:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[usp_Student_Transfer]
	@ClassId int,
	@AcademicYear nvarchar(4)
as
begin
	select s.StudentId, ROW_NUMBER() over (order by s.StudentFullName) as 'S.N', s.StudentFullName as 'Name', 
	case 
	when s.Gender = 'M' then 'Male'
	else 'Female'
	end as Gender, c.ClassName as 'Class', sc.EnrolledYear as 'Academic Year', 
	sc.RollNumber as 'Roll Number', sc.RollNumber as 'New Roll Number'
	 from Student s
	inner join StudentClass sc on s.StudentId = sc.StudentId
	inner join Class c on sc.ClassId = c.ClassId
	where  sc.ClassId = @ClassId and sc.EnrolledYear  = @AcademicYear
	
end
GO
/****** Object:  StoredProcedure [dbo].[usp_Student_TransferStudent]    Script Date: 3/9/2020 7:31:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[usp_Student_TransferStudent]
	@StudentId int,
	@ClassId int,
	@EnrolledYear nvarchar(4),
	@RollNumber nvarchar(5)
as
	begin
		insert into StudentClass(StudentId,ClassId,EnrolledYear,RollNumber) values
		(@StudentId, @ClassId, @EnrolledYear, @RollNumber)
	end
GO
/****** Object:  StoredProcedure [dbo].[usp_Student_Update]    Script Date: 3/9/2020 7:31:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[usp_Student_Update]
	@StudentName nvarchar(100),
	@Gender char(1),
	@ClassId int,
	@EnrolledYear nvarchar(4),
	@RollNumber nvarchar(5),
	@StudentId int
as
begin
begin try
begin tran
	update Student set StudentFullName = @StudentName, Gender=@Gender where StudentId = @StudentId
	if(select count(studentid) from StudentClass where StudentId=@StudentId)=1
	begin
		update StudentClass set ClassId = @ClassId, EnrolledYear = @EnrolledYear, RollNumber = @RollNumber
		where StudentId = @StudentId and EnrolledYear = @EnrolledYear
	end
commit
end try
begin catch
	rollback
end catch
end



GO
/****** Object:  StoredProcedure [dbo].[usp_StudentExam_Save]    Script Date: 3/9/2020 7:31:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[usp_StudentExam_Save]
@RollNumber varchar(5),
@ExaminationId int,
@ClassId int,
@SubjectId int,
@Grade nchar(2),
@ExamYear nvarchar(4)
as
begin
begin try
begin tran
	declare @StudentId int
	set @StudentId = (SELECT TOP 1  StudentId from StudentClass WHERE ClassId = @ClassId AND RollNumber = @RollNumber AND EnrolledYear = @ExamYear)

	if EXISTS(SELECT 'a' FROM StudentExams WHERE StudentId = @StudentId AND ExaminationId = @ExaminationId AND ClassId = @ClassId AND SubjectId = @SubjectId)
	BEGIN
		UPDATE StudentExams SET Grade = @Grade
			 WHERE StudentId = @StudentId AND ExaminationId = @ExaminationId AND ClassId = @ClassId AND SubjectId = @SubjectId
	END
	ELSE
	BEGIN
		INSERT INTO StudentExams (StudentId, ExaminationId, ClassId, SubjectId, Grade) VALUES
		(@StudentId, @ExaminationId, @ClassId, @SubjectId, @Grade)
	END
commit
end try
begin catch
	rollback
end catch
end
GO
/****** Object:  StoredProcedure [dbo].[usp_StudentExtraActivities_Get]    Script Date: 3/9/2020 7:31:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[usp_StudentExtraActivities_Get]
	@Year nvarchar(4) ,
	@Examination nvarchar(4),
	@ClassId int
as
begin 
		select sc.StudentId, 
		s. StudentFullName, 
		sea.SchoolDays,
		 sea.Present_Days, 
		-- sea.Reading_And_Writing_Skill, 
		 --sea.Recognition_of_Letter, 
		 sea.English, sea.Nepali, 
		 sea.Copying_Skill, 
		 --sea.Students_Academic_Attitude, 
		 sea.Concentration, 
		 sea.[Co-operation], 
		 sea.Memory, 
		 sea.Curiosity, 
		 sea.Understanding, 
		 --sea.Student_Department, 
		 sea.Conduct, 
		 sea.Neatness_And_Tidiness, 
		 sea.Punctuality, 
		 sea.Politeness, 
		 sea.Height_And_Weight, 
		 --sea.Extra_Curricular_Activities, 
		 sea.[Drill/P.T], 
		 sea.Dance, 
		 sea.Rhymes
		 FROM Student s
		INNER JOIN StudentClass sc on s.StudentId = sc.StudentId AND sc.EnrolledYear = @Year AND sc.ClassId = @ClassId
		LEFT JOIN StudentExtraActivities sea on s.StudentId = sea.StudentId AND sea.ExaminationId = @Examination	
end

GO
/****** Object:  StoredProcedure [dbo].[usp_StudentExtraActivities_Save]    Script Date: 3/9/2020 7:31:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[usp_StudentExtraActivities_Save]
	@StudentId int, 
	@ActivitiesYear nvarchar(50),
	@ExaminationId int,
	@SchoolDays int,
	@PresentDays int,
	@ReadingAndWriting nvarchar(50),
	@RecognitionofLetter nvarchar(50),
	@English nvarchar(50),
	@Nepali nvarchar(50),
	@CopyingSkill nvarchar(50),
	@StudentsAcademicAttitude nvarchar(50),
	@Concentration nvarchar(50),
	@Cooperation nvarchar(50),
	@Memory nvarchar(50),
	@Curiosity nvarchar(50),
	@Understanding nvarchar(50),
	@StudentDepartment nvarchar(50),
	@Conduct nvarchar(50),
	@Neatness  nvarchar(50),
	@Punctuality  nvarchar(50),
	@Politeness nvarchar(50),
	@HeightAndWeight nvarchar(50),
	@ExtraCurricular nvarchar(50),
	@Drill nvarchar(50),
	@Dance nvarchar(50),
	@Rhymes nvarchar(50)
as
begin 
	IF NOT EXISTS (SELECT 'a' FROM StudentExtraActivities WHERE StudentId = @StudentId 
		AND ExaminationId = @ExaminationId AND ActivitiesYear = @ActivitiesYear)
BEGIN	
		INSERT INTO StudentExtraActivities (StudentId, ActivitiesYear, ExaminationId, SchoolDays, Present_Days, 
		Reading_And_Writing_Skill, Recognition_of_Letter, English, Nepali, Copying_Skill, Students_Academic_Attitude,
		Concentration, [Co-operation], Memory, Curiosity, Understanding, Student_Department, Conduct,
		 Neatness_And_Tidiness, Punctuality, Politeness, Height_And_Weight, Extra_Curricular_Activities, 
		 [Drill/P.T], Dance, Rhymes) VALUES
		(@StudentId, @ActivitiesYear,@ExaminationId,  @SchoolDays, @PresentDays, @ReadingAndWriting, 
		@RecognitionofLetter,@English,@Nepali, @CopyingSkill,@StudentsAcademicAttitude, @Concentration,
		@Cooperation,	@Memory, @Curiosity, @Understanding, @StudentDepartment,@Conduct, @Neatness, 
		@Punctuality, @Politeness, @HeightAndWeight, @ExtraCurricular, @Drill, @Dance, @Rhymes) 
END
ELSE
BEGIN
	UPDATE StudentExtraActivities SET
		SchoolDays = @SchoolDays,
		Present_Days = @PresentDays,
		Reading_And_Writing_Skill = @ReadingAndWriting,
		Recognition_of_Letter=@RecognitionofLetter,
		English = @English,
		Nepali =@Nepali,
		Copying_Skill=@CopyingSkill,
		Students_Academic_Attitude =@StudentsAcademicAttitude,
		Concentration =@Concentration ,
		[Co-operation] = @Cooperation,
		Memory = @Memory,
		Curiosity = @Curiosity,
		Understanding = @Understanding,
		Student_Department = @StudentDepartment,
		Conduct = @Conduct,
		Neatness_And_Tidiness = @Neatness,
		Punctuality = @Punctuality,
		Politeness = @Politeness,
		Height_And_Weight = @HeightAndWeight,
		Extra_Curricular_Activities = @ExtraCurricular ,
		[Drill/P.T] =@Drill ,
		Dance = @Dance,
		Rhymes = @Rhymes
		WHERE StudentId = @StudentId 
		AND ExaminationId = @ExaminationId AND ActivitiesYear = @ActivitiesYear
END
end
GO
/****** Object:  StoredProcedure [dbo].[usp_Subject_ByClass]    Script Date: 3/9/2020 7:31:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[usp_Subject_ByClass]
	@ClassId int
as
begin	
	select s.SubjectId, ROW_NUMBER() over (order by c.ClassId, s.SubjectName) as 'S.N',
	 c.ClassName as 'Class', s.SubjectName as 'Subject'
	 from Subjects s
	inner join Class c on s.ClassId = c.ClassId
	where s.ClassId = @ClassId OR @ClassId = 0
	order by c.ClassId asc, s.SubjectName asc
	
end
GO
/****** Object:  StoredProcedure [dbo].[usp_Subject_Delete]    Script Date: 3/9/2020 7:31:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[usp_Subject_Delete]
	@SubjectId int
as
begin
	delete from Subjects
	where SubjectId = @SubjectId
end
GO
/****** Object:  StoredProcedure [dbo].[usp_Subject_Save]    Script Date: 3/9/2020 7:31:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[usp_Subject_Save]
	@SubjectName nvarchar(100),
	@ClassId int
as
begin
	insert into Subjects(SubjectName, ClassId) values 
	(@SubjectName, @ClassId)
end
GO
/****** Object:  StoredProcedure [dbo].[usp_Subject_Select]    Script Date: 3/9/2020 7:31:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[usp_Subject_Select]
as
begin
	select s.SubjectId, ROW_NUMBER() over (order by s.SubjectId, s.SubjectName) as 'S.N',
	 c.ClassName as 'Class', s.SubjectName as 'Subject'
	 from Subjects s
	inner join Class c on s.ClassId = c.ClassId
	order by s.SubjectId
end
GO
/****** Object:  StoredProcedure [dbo].[usp_Subject_SelectById]    Script Date: 3/9/2020 7:31:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[usp_Subject_SelectById]
	@SubjectId int
as
begin
	select s.SubjectId, 
	 s.ClassId, s.SubjectName 
	 from Subjects s
	where s.SubjectId = @SubjectId
end
GO
/****** Object:  StoredProcedure [dbo].[usp_Subject_Update]    Script Date: 3/9/2020 7:31:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[usp_Subject_Update]
	@SubjectName nvarchar(100),
	@ClassId int,
	@SubjectId int
as
begin
	update Subjects set 
		SubjectName = @SubjectName, 
		ClassId = @ClassId
	where SubjectId = @SubjectId
end
GO
USE [master]
GO
ALTER DATABASE [KidsZone] SET  READ_WRITE 
GO
