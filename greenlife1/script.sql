USE [master]
GO
/****** Object:  Database [greenlife]    Script Date: 12/5/2016 4:52:36 PM ******/
CREATE DATABASE [greenlife]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'greenlife', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\greenlife.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'greenlife_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\greenlife_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [greenlife] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [greenlife].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [greenlife] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [greenlife] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [greenlife] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [greenlife] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [greenlife] SET ARITHABORT OFF 
GO
ALTER DATABASE [greenlife] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [greenlife] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [greenlife] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [greenlife] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [greenlife] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [greenlife] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [greenlife] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [greenlife] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [greenlife] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [greenlife] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [greenlife] SET  DISABLE_BROKER 
GO
ALTER DATABASE [greenlife] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [greenlife] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [greenlife] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [greenlife] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [greenlife] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [greenlife] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [greenlife] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [greenlife] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [greenlife] SET  MULTI_USER 
GO
ALTER DATABASE [greenlife] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [greenlife] SET DB_CHAINING OFF 
GO
ALTER DATABASE [greenlife] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [greenlife] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [greenlife]
GO
/****** Object:  Table [dbo].[doctor]    Script Date: 12/5/2016 4:52:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[doctor](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[doctor_id] [varchar](50) NULL,
	[name] [varchar](50) NULL,
	[gender] [varchar](50) NULL,
	[email] [varchar](50) NULL,
	[address] [varchar](255) NULL,
	[nid] [varchar](50) NULL,
	[date_of_birth] [date] NULL,
	[image] [varchar](50) NULL,
	[phone] [varchar](50) NULL,
	[qualification] [text] NULL,
 CONSTRAINT [PK_doctor] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[doctor_patient]    Script Date: 12/5/2016 4:52:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[doctor_patient](
	[id] [int] NULL,
	[doctor_id] [varchar](50) NULL,
	[patient_id] [varchar](50) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[doctor_specialization]    Script Date: 12/5/2016 4:52:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[doctor_specialization](
	[doctor_id] [int] NOT NULL,
	[specialize_id] [int] NULL,
 CONSTRAINT [PK_doctor_specialization] PRIMARY KEY CLUSTERED 
(
	[doctor_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[patient]    Script Date: 12/5/2016 4:52:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[patient](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[patient_id] [varchar](50) NULL,
	[name] [varchar](50) NULL,
	[date_of_birth] [datetime] NULL,
	[email] [varchar](50) NULL,
	[address] [varchar](255) NULL,
	[nid] [varchar](255) NULL,
	[phone] [varchar](50) NULL,
	[image] [varchar](50) NULL,
	[problems] [text] NULL,
	[gender] [varchar](50) NULL,
 CONSTRAINT [PK_patient] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Schedule]    Script Date: 12/5/2016 4:52:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Schedule](
	[id] [int] NULL,
	[day] [varchar](50) NULL,
	[start_time] [varchar](50) NULL,
	[end_time] [varchar](50) NULL,
	[doctor_id] [varchar](50) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Specialize]    Script Date: 12/5/2016 4:52:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Specialize](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](50) NULL,
 CONSTRAINT [PK_Specialize] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
USE [master]
GO
ALTER DATABASE [greenlife] SET  READ_WRITE 
GO
