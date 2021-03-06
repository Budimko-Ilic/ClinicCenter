USE [ClinicalCenter]
GO
/****** Object:  Table [dbo].[Clinic]    Script Date: 9/29/2020 6:58:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clinic](
	[Id] [uniqueidentifier] NOT NULL,
	[Description] [nvarchar](max) NOT NULL,
	[Adress] [nvarchar](50) NOT NULL,
	[Name] [nvarchar](100) NOT NULL,
	[City] [nchar](50) NOT NULL,
 CONSTRAINT [PK_Clinic] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ClinicExamination]    Script Date: 9/29/2020 6:58:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ClinicExamination](
	[Id] [uniqueidentifier] NOT NULL,
	[TypeOfExaminationId] [uniqueidentifier] NOT NULL,
	[ClinicId] [uniqueidentifier] NOT NULL,
	[Price] [money] NOT NULL,
	[Description] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_ClinicExamination] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ClinicMark]    Script Date: 9/29/2020 6:58:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ClinicMark](
	[Id] [uniqueidentifier] NOT NULL,
	[ClinicId] [uniqueidentifier] NOT NULL,
	[UserId] [uniqueidentifier] NOT NULL,
	[Mark] [float] NOT NULL,
 CONSTRAINT [PK_ClinicMark] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HealthCard]    Script Date: 9/29/2020 6:58:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HealthCard](
	[Id] [uniqueidentifier] NOT NULL,
	[Diopter] [numeric](2, 2) NOT NULL,
	[UserId] [uniqueidentifier] NOT NULL,
	[BloodType] [nchar](30) NOT NULL,
 CONSTRAINT [PK_HealthCard] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MedicalExamination]    Script Date: 9/29/2020 6:58:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MedicalExamination](
	[Id] [uniqueidentifier] NOT NULL,
	[UserId] [uniqueidentifier] NULL,
	[TypeId] [uniqueidentifier] NOT NULL,
	[MedicalStaffId] [uniqueidentifier] NOT NULL,
	[DateAndTimeOfStart] [datetime] NOT NULL,
	[DateAndTimeOfEnd] [datetime] NOT NULL,
	[DiscauntPrice] [money] NULL,
 CONSTRAINT [PK_MedicalExamination] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MedicalStaffMark]    Script Date: 9/29/2020 6:58:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MedicalStaffMark](
	[Id] [uniqueidentifier] NOT NULL,
	[UserId] [uniqueidentifier] NOT NULL,
	[StaffId] [uniqueidentifier] NOT NULL,
	[Mark] [decimal](18, 0) NOT NULL,
 CONSTRAINT [PK_MedicalStaffMark] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MedicalStaffOnExamination]    Script Date: 9/29/2020 6:58:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MedicalStaffOnExamination](
	[Id] [uniqueidentifier] NOT NULL,
	[MedicalStaffId] [uniqueidentifier] NOT NULL,
	[ClinicExaminationId] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_MedicalStaffOnExamination] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Role]    Script Date: 9/29/2020 6:58:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Role](
	[Id] [uniqueidentifier] NOT NULL,
	[Type] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Role] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Staff]    Script Date: 9/29/2020 6:58:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Staff](
	[Id] [uniqueidentifier] NOT NULL,
	[RoleId] [uniqueidentifier] NOT NULL,
	[ClinicId] [uniqueidentifier] NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[Email] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](256) NOT NULL,
	[ShiftStart] [time](7) NULL,
	[ShiftEnd] [time](7) NULL,
	[Info] [nvarchar](max) NULL,
 CONSTRAINT [PK_Staff] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TypeOfMedicalExamination]    Script Date: 9/29/2020 6:58:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TypeOfMedicalExamination](
	[Id] [uniqueidentifier] NOT NULL,
	[Type] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_TypeOfMedicalExamination] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 9/29/2020 6:58:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[Id] [uniqueidentifier] NOT NULL,
	[RoleId] [uniqueidentifier] NOT NULL,
	[HealthCareId] [uniqueidentifier] NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[Email] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](256) NOT NULL,
	[City] [nvarchar](50) NOT NULL,
	[PhoneNumber] [nvarchar](25) NOT NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Vacation]    Script Date: 9/29/2020 6:58:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Vacation](
	[Id] [uniqueidentifier] NOT NULL,
	[MedicalStaffId] [uniqueidentifier] NOT NULL,
	[DateStart] [datetime] NOT NULL,
	[DateEnd] [datetime] NOT NULL,
 CONSTRAINT [PK_Vacation] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[ClinicExamination]  WITH CHECK ADD  CONSTRAINT [ClinicExaminationType] FOREIGN KEY([TypeOfExaminationId])
REFERENCES [dbo].[TypeOfMedicalExamination] ([Id])
GO
ALTER TABLE [dbo].[ClinicExamination] CHECK CONSTRAINT [ClinicExaminationType]
GO
ALTER TABLE [dbo].[ClinicExamination]  WITH CHECK ADD  CONSTRAINT [FK_ClinicExamination_Clinic] FOREIGN KEY([ClinicId])
REFERENCES [dbo].[Clinic] ([Id])
GO
ALTER TABLE [dbo].[ClinicExamination] CHECK CONSTRAINT [FK_ClinicExamination_Clinic]
GO
ALTER TABLE [dbo].[ClinicMark]  WITH CHECK ADD  CONSTRAINT [FKClinicMark] FOREIGN KEY([ClinicId])
REFERENCES [dbo].[Clinic] ([Id])
GO
ALTER TABLE [dbo].[ClinicMark] CHECK CONSTRAINT [FKClinicMark]
GO
ALTER TABLE [dbo].[ClinicMark]  WITH CHECK ADD  CONSTRAINT [UserEvaluateClinic] FOREIGN KEY([UserId])
REFERENCES [dbo].[User] ([Id])
GO
ALTER TABLE [dbo].[ClinicMark] CHECK CONSTRAINT [UserEvaluateClinic]
GO
ALTER TABLE [dbo].[MedicalExamination]  WITH CHECK ADD  CONSTRAINT [FK_MedicalExamination_ClinicExamination] FOREIGN KEY([TypeId])
REFERENCES [dbo].[ClinicExamination] ([Id])
GO
ALTER TABLE [dbo].[MedicalExamination] CHECK CONSTRAINT [FK_MedicalExamination_ClinicExamination]
GO
ALTER TABLE [dbo].[MedicalExamination]  WITH CHECK ADD  CONSTRAINT [FK_MedicalExamination_MedicalStaffOnExamination] FOREIGN KEY([MedicalStaffId])
REFERENCES [dbo].[MedicalStaffOnExamination] ([Id])
GO
ALTER TABLE [dbo].[MedicalExamination] CHECK CONSTRAINT [FK_MedicalExamination_MedicalStaffOnExamination]
GO
ALTER TABLE [dbo].[MedicalExamination]  WITH CHECK ADD  CONSTRAINT [FK_MedicalExamination_User] FOREIGN KEY([UserId])
REFERENCES [dbo].[User] ([Id])
GO
ALTER TABLE [dbo].[MedicalExamination] CHECK CONSTRAINT [FK_MedicalExamination_User]
GO
ALTER TABLE [dbo].[MedicalStaffMark]  WITH CHECK ADD  CONSTRAINT [StaffMark] FOREIGN KEY([StaffId])
REFERENCES [dbo].[Staff] ([Id])
GO
ALTER TABLE [dbo].[MedicalStaffMark] CHECK CONSTRAINT [StaffMark]
GO
ALTER TABLE [dbo].[MedicalStaffMark]  WITH CHECK ADD  CONSTRAINT [UserEvaluatesStaff] FOREIGN KEY([UserId])
REFERENCES [dbo].[User] ([Id])
GO
ALTER TABLE [dbo].[MedicalStaffMark] CHECK CONSTRAINT [UserEvaluatesStaff]
GO
ALTER TABLE [dbo].[MedicalStaffOnExamination]  WITH CHECK ADD  CONSTRAINT [FK_MedicalStaffOnExamination_ClinicExamination] FOREIGN KEY([ClinicExaminationId])
REFERENCES [dbo].[ClinicExamination] ([Id])
GO
ALTER TABLE [dbo].[MedicalStaffOnExamination] CHECK CONSTRAINT [FK_MedicalStaffOnExamination_ClinicExamination]
GO
ALTER TABLE [dbo].[MedicalStaffOnExamination]  WITH CHECK ADD  CONSTRAINT [FK_MedicalStaffOnExamination_Staff] FOREIGN KEY([MedicalStaffId])
REFERENCES [dbo].[Staff] ([Id])
GO
ALTER TABLE [dbo].[MedicalStaffOnExamination] CHECK CONSTRAINT [FK_MedicalStaffOnExamination_Staff]
GO
ALTER TABLE [dbo].[Staff]  WITH CHECK ADD  CONSTRAINT [StaffEmployedInClinic] FOREIGN KEY([ClinicId])
REFERENCES [dbo].[Clinic] ([Id])
GO
ALTER TABLE [dbo].[Staff] CHECK CONSTRAINT [StaffEmployedInClinic]
GO
ALTER TABLE [dbo].[Staff]  WITH CHECK ADD  CONSTRAINT [StaffRole] FOREIGN KEY([RoleId])
REFERENCES [dbo].[Role] ([Id])
GO
ALTER TABLE [dbo].[Staff] CHECK CONSTRAINT [StaffRole]
GO
ALTER TABLE [dbo].[User]  WITH CHECK ADD  CONSTRAINT [UserRole] FOREIGN KEY([RoleId])
REFERENCES [dbo].[Role] ([Id])
GO
ALTER TABLE [dbo].[User] CHECK CONSTRAINT [UserRole]
GO
ALTER TABLE [dbo].[Vacation]  WITH CHECK ADD  CONSTRAINT [VacationStaff] FOREIGN KEY([MedicalStaffId])
REFERENCES [dbo].[Staff] ([Id])
GO
ALTER TABLE [dbo].[Vacation] CHECK CONSTRAINT [VacationStaff]
GO
