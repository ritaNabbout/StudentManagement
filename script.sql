USE [StudentManagment]
GO
/****** Object:  Table [dbo].[tbl_insertion]    Script Date: 6/4/2021 10:18:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_insertion](
	[Id] [nvarchar](50) NULL,
	[Name] [nvarchar](50) NULL,
	[Fname] [nvarchar](50) NULL,
	[Age] [int] NULL,
	[Gender] [nvarchar](50) NULL,
	[Address] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_registration]    Script Date: 6/4/2021 10:18:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_registration](
	[Id] [nvarchar](50) NULL,
	[Rcourse] [nvarchar](50) NULL
) ON [PRIMARY]
GO
