USE [master]
GO
/****** Object:  Database [TrainIT]    Script Date: 10/16/2013 10:58:21 ******/
CREATE DATABASE [TrainIT] ON  PRIMARY 
( NAME = N'TrainIT', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.SQLSERVER1\MSSQL\DATA\TrainIT.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'TrainIT_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.SQLSERVER1\MSSQL\DATA\TrainIT_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [TrainIT] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [TrainIT].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [TrainIT] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [TrainIT] SET ANSI_NULLS OFF
GO
ALTER DATABASE [TrainIT] SET ANSI_PADDING OFF
GO
ALTER DATABASE [TrainIT] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [TrainIT] SET ARITHABORT OFF
GO
ALTER DATABASE [TrainIT] SET AUTO_CLOSE OFF
GO
ALTER DATABASE [TrainIT] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [TrainIT] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [TrainIT] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [TrainIT] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [TrainIT] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [TrainIT] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [TrainIT] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [TrainIT] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [TrainIT] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [TrainIT] SET  DISABLE_BROKER
GO
ALTER DATABASE [TrainIT] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [TrainIT] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [TrainIT] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [TrainIT] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [TrainIT] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [TrainIT] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [TrainIT] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [TrainIT] SET  READ_WRITE
GO
ALTER DATABASE [TrainIT] SET RECOVERY FULL
GO
ALTER DATABASE [TrainIT] SET  MULTI_USER
GO
ALTER DATABASE [TrainIT] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [TrainIT] SET DB_CHAINING OFF
GO
EXEC sys.sp_db_vardecimal_storage_format N'TrainIT', N'ON'
GO
USE [TrainIT]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 10/16/2013 10:58:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Users](
	[UserID] [int] IDENTITY(1,1) NOT NULL,
	[UserFirstName] [varchar](50) NULL,
	[UserSecondName] [varchar](50) NULL,
	[UserBDate] [date] NULL,
	[UserName] [varchar](10) NOT NULL,
	[UserPass] [varbinary](50) NULL,
	[UserMail] [varchar](50) NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[UserRegs]    Script Date: 10/16/2013 10:58:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserRegs](
	[UserRegID] [int] IDENTITY(1,1) NOT NULL,
	[UserID] [int] NOT NULL,
	[RegDate] [date] NOT NULL,
	[Weight] [float] NULL,
	[RHR] [smallint] NULL,
	[FatIndex] [float] NULL,
	[Height] [float] NULL,
 CONSTRAINT [PK_UserRegs] PRIMARY KEY CLUSTERED 
(
	[UserRegID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Trainings]    Script Date: 10/16/2013 10:58:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Trainings](
	[TrainID] [int] IDENTITY(1,1) NOT NULL,
	[UserID] [int] NOT NULL,
	[TarinDate] [date] NOT NULL,
 CONSTRAINT [PK_Trainings] PRIMARY KEY CLUSTERED 
(
	[TrainID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SportTypes]    Script Date: 10/16/2013 10:58:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SportTypes](
	[SportTypeID] [int] IDENTITY(1,1) NOT NULL,
	[SportTypeName] [varchar](10) NOT NULL,
	[ParentSportTypeID] [int] NULL,
	[Memo] [varchar](50) NULL,
 CONSTRAINT [PK_SportTypes] PRIMARY KEY CLUSTERED 
(
	[SportTypeID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Materials]    Script Date: 10/16/2013 10:58:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Materials](
	[MatID] [int] IDENTITY(1,1) NOT NULL,
	[MatName] [varchar](50) NOT NULL,
	[BuyDate] [date] NULL,
	[Cost] [money] NULL,
	[initTime] [time](7) NULL,
	[initDist] [float] NULL,
 CONSTRAINT [PK_Materials] PRIMARY KEY CLUSTERED 
(
	[MatID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  StoredProcedure [dbo].[FillByUserName]    Script Date: 10/16/2013 10:58:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[FillByUserName]
(
	@UserName varchar(10)
)
AS
	SET NOCOUNT ON;
SELECT UserID, UserFirstName, UserSecondName, UserBDate, UserName, UserPass, UserMail FROM dbo.Users WHERE UserName =@UserName
GO
/****** Object:  Table [dbo].[Sports]    Script Date: 10/16/2013 10:58:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Sports](
	[SportID] [int] IDENTITY(1,1) NOT NULL,
	[SportName] [varchar](10) NOT NULL,
	[SportTypeID] [int] NOT NULL,
	[Memo] [varchar](50) NULL,
 CONSTRAINT [PK_Sports] PRIMARY KEY CLUSTERED 
(
	[SportID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Sessions]    Script Date: 10/16/2013 10:58:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Sessions](
	[SessionID] [int] IDENTITY(1,1) NOT NULL,
	[TrainID] [int] NOT NULL,
	[UserID] [int] NOT NULL,
	[SportID] [int] NOT NULL,
	[Competition] [smallint] NULL,
	[Transition] [smallint] NULL,
	[Distance] [float] NULL,
	[Time] [time](7) NULL,
	[MedHR] [smallint] NULL,
	[MaxHR] [smallint] NULL,
	[Value] [smallint] NULL,
	[Memo] [varchar](50) NULL,
 CONSTRAINT [PK_Sessions] PRIMARY KEY CLUSTERED 
(
	[SessionID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[MaterialSession]    Script Date: 10/16/2013 10:58:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MaterialSession](
	[MatID] [int] NOT NULL,
	[SessionID] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Default [DF_Materials_initTime]    Script Date: 10/16/2013 10:58:21 ******/
ALTER TABLE [dbo].[Materials] ADD  CONSTRAINT [DF_Materials_initTime]  DEFAULT ('00:00:00') FOR [initTime]
GO
/****** Object:  Default [DF_Materials_initDist]    Script Date: 10/16/2013 10:58:21 ******/
ALTER TABLE [dbo].[Materials] ADD  CONSTRAINT [DF_Materials_initDist]  DEFAULT ((0.0)) FOR [initDist]
GO
/****** Object:  Default [DF_Sessions_Competition]    Script Date: 10/16/2013 10:58:22 ******/
ALTER TABLE [dbo].[Sessions] ADD  CONSTRAINT [DF_Sessions_Competition]  DEFAULT ((0)) FOR [Competition]
GO
/****** Object:  Default [DF_Sessions_Transition]    Script Date: 10/16/2013 10:58:22 ******/
ALTER TABLE [dbo].[Sessions] ADD  CONSTRAINT [DF_Sessions_Transition]  DEFAULT ((0)) FOR [Transition]
GO
/****** Object:  Default [DF_Sessions_Distance]    Script Date: 10/16/2013 10:58:22 ******/
ALTER TABLE [dbo].[Sessions] ADD  CONSTRAINT [DF_Sessions_Distance]  DEFAULT ((0)) FOR [Distance]
GO
/****** Object:  Default [DF_Sessions_Time]    Script Date: 10/16/2013 10:58:22 ******/
ALTER TABLE [dbo].[Sessions] ADD  CONSTRAINT [DF_Sessions_Time]  DEFAULT ('00:00:00') FOR [Time]
GO
/****** Object:  ForeignKey [FK_SportTypes_SportTypes]    Script Date: 10/16/2013 10:58:21 ******/
ALTER TABLE [dbo].[SportTypes]  WITH CHECK ADD  CONSTRAINT [FK_SportTypes_SportTypes] FOREIGN KEY([ParentSportTypeID])
REFERENCES [dbo].[SportTypes] ([SportTypeID])
GO
ALTER TABLE [dbo].[SportTypes] CHECK CONSTRAINT [FK_SportTypes_SportTypes]
GO
/****** Object:  ForeignKey [FK_Sports_SportTypes]    Script Date: 10/16/2013 10:58:22 ******/
ALTER TABLE [dbo].[Sports]  WITH CHECK ADD  CONSTRAINT [FK_Sports_SportTypes] FOREIGN KEY([SportTypeID])
REFERENCES [dbo].[SportTypes] ([SportTypeID])
GO
ALTER TABLE [dbo].[Sports] CHECK CONSTRAINT [FK_Sports_SportTypes]
GO
/****** Object:  ForeignKey [FK_Sessions_Sports]    Script Date: 10/16/2013 10:58:22 ******/
ALTER TABLE [dbo].[Sessions]  WITH CHECK ADD  CONSTRAINT [FK_Sessions_Sports] FOREIGN KEY([SportID])
REFERENCES [dbo].[Sports] ([SportID])
GO
ALTER TABLE [dbo].[Sessions] CHECK CONSTRAINT [FK_Sessions_Sports]
GO
/****** Object:  ForeignKey [FK_Sessions_Trainings]    Script Date: 10/16/2013 10:58:22 ******/
ALTER TABLE [dbo].[Sessions]  WITH CHECK ADD  CONSTRAINT [FK_Sessions_Trainings] FOREIGN KEY([TrainID])
REFERENCES [dbo].[Trainings] ([TrainID])
GO
ALTER TABLE [dbo].[Sessions] CHECK CONSTRAINT [FK_Sessions_Trainings]
GO
/****** Object:  ForeignKey [FK_MaterialSession_Materials]    Script Date: 10/16/2013 10:58:22 ******/
ALTER TABLE [dbo].[MaterialSession]  WITH CHECK ADD  CONSTRAINT [FK_MaterialSession_Materials] FOREIGN KEY([MatID])
REFERENCES [dbo].[Materials] ([MatID])
GO
ALTER TABLE [dbo].[MaterialSession] CHECK CONSTRAINT [FK_MaterialSession_Materials]
GO
/****** Object:  ForeignKey [FK_MaterialSession_Sessions]    Script Date: 10/16/2013 10:58:22 ******/
ALTER TABLE [dbo].[MaterialSession]  WITH CHECK ADD  CONSTRAINT [FK_MaterialSession_Sessions] FOREIGN KEY([SessionID])
REFERENCES [dbo].[Sessions] ([SessionID])
GO
ALTER TABLE [dbo].[MaterialSession] CHECK CONSTRAINT [FK_MaterialSession_Sessions]
GO
