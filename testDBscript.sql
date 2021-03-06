USE [master]
GO
/****** Object:  Database [testDB]    Script Date: 6/9/2561 13:23:05 ******/
CREATE DATABASE [testDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'testDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\testDB.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'testDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\testDB_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [testDB] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [testDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [testDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [testDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [testDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [testDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [testDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [testDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [testDB] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [testDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [testDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [testDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [testDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [testDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [testDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [testDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [testDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [testDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [testDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [testDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [testDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [testDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [testDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [testDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [testDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [testDB] SET RECOVERY FULL 
GO
ALTER DATABASE [testDB] SET  MULTI_USER 
GO
ALTER DATABASE [testDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [testDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [testDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [testDB] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
EXEC sys.sp_db_vardecimal_storage_format N'testDB', N'ON'
GO
USE [testDB]
GO
/****** Object:  Table [dbo].[billing]    Script Date: 6/9/2561 13:23:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[billing](
	[custID] [int] NULL,
	[totalunit] [int] NULL,
	[installation] [nchar](10) NULL,
	[amount] [int] NULL,
	[payment] [int] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[members]    Script Date: 6/9/2561 13:23:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[members](
	[memberID] [nchar](2) NULL,
	[memberName] [nvarchar](50) NULL,
	[password] [nchar](10) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[student]    Script Date: 6/9/2561 13:23:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[student](
	[id] [int] NULL,
	[name] [nchar](50) NULL,
	[age] [int] NULL
) ON [PRIMARY]

GO
INSERT [dbo].[billing] ([custID], [totalunit], [installation], [amount], [payment]) VALUES (12, 235, N'11-225    ', 678, 0)
INSERT [dbo].[billing] ([custID], [totalunit], [installation], [amount], [payment]) VALUES (12, 235, N'11-225    ', 678, 0)
INSERT [dbo].[billing] ([custID], [totalunit], [installation], [amount], [payment]) VALUES (99, 78, N'1234      ', 300, 1)
INSERT [dbo].[billing] ([custID], [totalunit], [installation], [amount], [payment]) VALUES (545, 545, N'12        ', 455, 1)
INSERT [dbo].[members] ([memberID], [memberName], [password]) VALUES (N'11', N'John', N'1234      ')
INSERT [dbo].[members] ([memberID], [memberName], [password]) VALUES (N'55', N'Mark', N'6789      ')
INSERT [dbo].[members] ([memberID], [memberName], [password]) VALUES (N'33', N'Chai', N'4587      ')
INSERT [dbo].[members] ([memberID], [memberName], [password]) VALUES (N'66', N'xxxxChai', N'4545487   ')
INSERT [dbo].[student] ([id], [name], [age]) VALUES (1, N'AA                                                ', 33)
INSERT [dbo].[student] ([id], [name], [age]) VALUES (8, N'BB                                                ', 40)
INSERT [dbo].[student] ([id], [name], [age]) VALUES (5, N'CC                                                ', 45)
USE [master]
GO
ALTER DATABASE [testDB] SET  READ_WRITE 
GO
