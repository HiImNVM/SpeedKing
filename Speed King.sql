USE [master]
GO
/****** Object:  Database [Speed King]    Script Date: 21/08/2016 8:23:52 CH ******/
CREATE DATABASE [Speed King]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Speed King', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\Speed King.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Speed King_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\Speed King_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Speed King].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Speed King] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Speed King] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Speed King] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Speed King] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Speed King] SET ARITHABORT OFF 
GO
ALTER DATABASE [Speed King] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Speed King] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Speed King] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Speed King] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Speed King] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Speed King] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Speed King] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Speed King] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Speed King] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Speed King] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Speed King] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Speed King] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Speed King] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Speed King] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Speed King] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Speed King] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Speed King] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Speed King] SET RECOVERY FULL 
GO
ALTER DATABASE [Speed King] SET  MULTI_USER 
GO
ALTER DATABASE [Speed King] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Speed King] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Speed King] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Speed King] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Speed King] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'Speed King', N'ON'
GO
USE [Speed King]
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [Speed King]
GO
/****** Object:  Table [dbo].[Account]    Script Date: 21/08/2016 8:23:52 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Account](
	[ID] [varchar](50) NOT NULL,
	[Pass] [varchar](50) NULL,
	[Note] [bit] NULL,
	[DateTimePlayer] [datetime] NULL,
 CONSTRAINT [PK_Account] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[BangXepHang]    Script Date: 21/08/2016 8:23:53 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BangXepHang](
	[Name] [nvarchar](50) NOT NULL,
	[Diem] [int] NOT NULL,
 CONSTRAINT [PK_BangXepHang] PRIMARY KEY CLUSTERED 
(
	[Name] ASC,
	[Diem] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Item]    Script Date: 21/08/2016 8:23:53 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Item](
	[Name] [nvarchar](50) NOT NULL,
	[LoaiXe] [varchar](50) NOT NULL,
	[Dan] [int] NULL,
	[SamSet] [int] NULL,
	[Boom] [int] NULL,
	[Diem] [int] NOT NULL,
 CONSTRAINT [PK_Item] PRIMARY KEY CLUSTERED 
(
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Shop]    Script Date: 21/08/2016 8:23:53 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Shop](
	[LoaiXe] [varchar](50) NOT NULL,
	[Dan] [int] NOT NULL,
	[SamSet] [int] NOT NULL,
	[Boom] [int] NOT NULL,
 CONSTRAINT [PK_Shop] PRIMARY KEY CLUSTERED 
(
	[LoaiXe] ASC,
	[Dan] ASC,
	[SamSet] ASC,
	[Boom] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[User]    Script Date: 21/08/2016 8:23:53 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[User](
	[Name] [nvarchar](50) NOT NULL,
	[ID] [varchar](50) NOT NULL,
	[Image] [varchar](100) NULL,
	[NgaySinh] [date] NULL,
	[GioiTinh] [bit] NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Account] ([ID], [Pass], [Note], [DateTimePlayer]) VALUES (N'Admin', N'Admin', 1, CAST(N'2016-08-16T08:48:17.000' AS DateTime))
INSERT [dbo].[BangXepHang] ([Name], [Diem]) VALUES (N'NVM', 1000)
INSERT [dbo].[Item] ([Name], [LoaiXe], [Dan], [SamSet], [Boom], [Diem]) VALUES (N'NVM', N'1,2,3,1', 105, 106, 100, 1000)
INSERT [dbo].[Shop] ([LoaiXe], [Dan], [SamSet], [Boom]) VALUES (N'1,2,3,4', 1000, 1000, 1000)
INSERT [dbo].[User] ([Name], [ID], [Image], [NgaySinh], [GioiTinh]) VALUES (N'NVM', N'Admin', N'Image\Default.jpg', CAST(N'1996-09-14' AS Date), 1)
ALTER TABLE [dbo].[BangXepHang] ADD  CONSTRAINT [DF_BangXepHang_Diem]  DEFAULT ((0)) FOR [Diem]
GO
ALTER TABLE [dbo].[Item] ADD  CONSTRAINT [DF_Item_Diem]  DEFAULT ((0)) FOR [Diem]
GO
ALTER TABLE [dbo].[User] ADD  CONSTRAINT [DF_User_Image]  DEFAULT ('Image\Default.jpg') FOR [Image]
GO
ALTER TABLE [dbo].[BangXepHang]  WITH CHECK ADD  CONSTRAINT [FK_BangXepHang_Item] FOREIGN KEY([Name])
REFERENCES [dbo].[Item] ([Name])
GO
ALTER TABLE [dbo].[BangXepHang] CHECK CONSTRAINT [FK_BangXepHang_Item]
GO
ALTER TABLE [dbo].[Item]  WITH CHECK ADD  CONSTRAINT [FK_Item_User] FOREIGN KEY([Name])
REFERENCES [dbo].[User] ([Name])
GO
ALTER TABLE [dbo].[Item] CHECK CONSTRAINT [FK_Item_User]
GO
ALTER TABLE [dbo].[User]  WITH CHECK ADD  CONSTRAINT [FK_User_Account] FOREIGN KEY([ID])
REFERENCES [dbo].[Account] ([ID])
GO
ALTER TABLE [dbo].[User] CHECK CONSTRAINT [FK_User_Account]
GO
USE [master]
GO
ALTER DATABASE [Speed King] SET  READ_WRITE 
GO
