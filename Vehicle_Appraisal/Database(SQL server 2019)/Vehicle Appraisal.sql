USE [master]
GO
/****** Object:  Database [VehicleAppraisal]    Script Date: 11/22/2020 1:02:13 PM ******/
CREATE DATABASE [VehicleAppraisal]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'VehicleAppraisal', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\VehicleAppraisal.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'VehicleAppraisal_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\VehicleAppraisal_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [VehicleAppraisal] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [VehicleAppraisal].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [VehicleAppraisal] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [VehicleAppraisal] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [VehicleAppraisal] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [VehicleAppraisal] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [VehicleAppraisal] SET ARITHABORT OFF 
GO
ALTER DATABASE [VehicleAppraisal] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [VehicleAppraisal] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [VehicleAppraisal] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [VehicleAppraisal] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [VehicleAppraisal] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [VehicleAppraisal] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [VehicleAppraisal] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [VehicleAppraisal] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [VehicleAppraisal] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [VehicleAppraisal] SET  ENABLE_BROKER 
GO
ALTER DATABASE [VehicleAppraisal] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [VehicleAppraisal] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [VehicleAppraisal] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [VehicleAppraisal] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [VehicleAppraisal] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [VehicleAppraisal] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [VehicleAppraisal] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [VehicleAppraisal] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [VehicleAppraisal] SET  MULTI_USER 
GO
ALTER DATABASE [VehicleAppraisal] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [VehicleAppraisal] SET DB_CHAINING OFF 
GO
ALTER DATABASE [VehicleAppraisal] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [VehicleAppraisal] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [VehicleAppraisal] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [VehicleAppraisal] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [VehicleAppraisal] SET QUERY_STORE = OFF
GO
USE [VehicleAppraisal]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 11/22/2020 1:02:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AppUserRoles]    Script Date: 11/22/2020 1:02:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AppUserRoles](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CreateAt] [datetime2](7) NOT NULL,
	[UpdateAt] [datetime2](7) NOT NULL,
	[Name] [nvarchar](max) NULL,
 CONSTRAINT [PK_AppUserRoles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AppUsers]    Script Date: 11/22/2020 1:02:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AppUsers](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CreateAt] [datetime2](7) NOT NULL,
	[UpdateAt] [datetime2](7) NOT NULL,
	[UserName] [nvarchar](max) NULL,
	[PassWord] [nvarchar](max) NULL,
	[Email] [nvarchar](max) NULL,
	[ConfirmEmail] [bit] NOT NULL,
	[FullName] [nvarchar](max) NULL,
	[AppUserRolesId] [int] NOT NULL,
 CONSTRAINT [PK_AppUsers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Conditions]    Script Date: 11/22/2020 1:02:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Conditions](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CreateAt] [datetime2](7) NOT NULL,
	[UpdateAt] [datetime2](7) NOT NULL,
	[Type] [nvarchar](max) NULL,
	[ImagePath] [nvarchar](max) NULL,
	[Note] [nvarchar](max) NULL,
	[VehicleId] [int] NOT NULL,
 CONSTRAINT [PK_Conditions] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customers]    Script Date: 11/22/2020 1:02:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customers](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CreateAt] [datetime2](7) NOT NULL,
	[UpdateAt] [datetime2](7) NOT NULL,
	[FirstName] [nvarchar](max) NULL,
	[LastName] [nvarchar](max) NULL,
	[Phone] [nvarchar](max) NULL,
	[Email] [nvarchar](max) NULL,
	[Address1] [nvarchar](max) NULL,
	[Address2] [nvarchar](max) NULL,
	[City] [nvarchar](max) NULL,
	[Country] [nvarchar](max) NULL,
	[isDelete] [bit] NOT NULL,
 CONSTRAINT [PK_Customers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Makes]    Script Date: 11/22/2020 1:02:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Makes](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CreateAt] [datetime2](7) NOT NULL,
	[UpdateAt] [datetime2](7) NOT NULL,
	[Name] [nvarchar](max) NULL,
	[isDelete] [bit] NOT NULL,
 CONSTRAINT [PK_Makes] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Models]    Script Date: 11/22/2020 1:02:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Models](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CreateAt] [datetime2](7) NOT NULL,
	[UpdateAt] [datetime2](7) NOT NULL,
	[Name] [nvarchar](max) NULL,
	[Year] [nvarchar](max) NULL,
	[isDelete] [bit] NOT NULL,
 CONSTRAINT [PK_Models] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[VehicleAppraisals]    Script Date: 11/22/2020 1:02:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VehicleAppraisals](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CreateAt] [datetime2](7) NOT NULL,
	[UpdateAt] [datetime2](7) NOT NULL,
	[AppraisalValue] [nvarchar](max) NULL,
	[VehicleId] [int] NOT NULL,
 CONSTRAINT [PK_VehicleAppraisals] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[VehicleCrawlDatas]    Script Date: 11/22/2020 1:02:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VehicleCrawlDatas](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CreateAt] [datetime2](7) NOT NULL,
	[UpdateAt] [datetime2](7) NOT NULL,
	[Name] [nvarchar](max) NULL,
	[Image] [nvarchar](max) NULL,
	[Value] [nvarchar](max) NULL,
 CONSTRAINT [PK_VehicleCrawlDatas] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Vehicles]    Script Date: 11/22/2020 1:02:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Vehicles](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CreateAt] [datetime2](7) NOT NULL,
	[UpdateAt] [datetime2](7) NOT NULL,
	[CustomerId] [int] NOT NULL,
	[MakeId] [int] NOT NULL,
	[ModelId] [int] NOT NULL,
	[Odometer] [nvarchar](max) NULL,
	[VIN] [nvarchar](max) NULL,
	[Engine] [nvarchar](max) NULL,
	[isDelete] [bit] NOT NULL,
 CONSTRAINT [PK_Vehicles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20201105071520_InitialDB', N'2.2.6-servicing-10079')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20201105072544_update', N'2.2.6-servicing-10079')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20201105074244_Update2', N'2.2.6-servicing-10079')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20201107030813_InitialDB', N'2.2.6-servicing-10079')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20201107032704_InitialDb', N'2.2.6-servicing-10079')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20201115004543_UpdateModel', N'2.2.6-servicing-10079')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20201118034045_InitialCrawlData', N'2.2.6-servicing-10079')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20201120042418_removeValueofModel', N'2.2.6-servicing-10079')
GO
SET IDENTITY_INSERT [dbo].[AppUserRoles] ON 

INSERT [dbo].[AppUserRoles] ([Id], [CreateAt], [UpdateAt], [Name]) VALUES (1, CAST(N'2020-05-11T00:00:00.0000000' AS DateTime2), CAST(N'2020-05-11T00:00:00.0000000' AS DateTime2), N'Admin')
INSERT [dbo].[AppUserRoles] ([Id], [CreateAt], [UpdateAt], [Name]) VALUES (2, CAST(N'2020-05-11T00:00:00.0000000' AS DateTime2), CAST(N'2020-05-11T00:00:00.0000000' AS DateTime2), N'Users')
SET IDENTITY_INSERT [dbo].[AppUserRoles] OFF
GO
SET IDENTITY_INSERT [dbo].[AppUsers] ON 

INSERT [dbo].[AppUsers] ([Id], [CreateAt], [UpdateAt], [UserName], [PassWord], [Email], [ConfirmEmail], [FullName], [AppUserRolesId]) VALUES (5, CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), CAST(N'2020-11-18T16:05:12.5877519' AS DateTime2), N'Admin', N'K/pXx+2bppVSdrvFjtc3UGc6WvLnq/s9vQRRG3DRfa0=', N'thanhson3121999@gmail.com', 1, N'Nguyễn Viết Thanh Sơn', 1)
INSERT [dbo].[AppUsers] ([Id], [CreateAt], [UpdateAt], [UserName], [PassWord], [Email], [ConfirmEmail], [FullName], [AppUserRolesId]) VALUES (10, CAST(N'2020-11-14T16:18:55.4585649' AS DateTime2), CAST(N'2020-11-15T08:46:28.8084788' AS DateTime2), N'Users', N'K/pXx+2bppVSdrvFjtc3UGc6WvLnq/s9vQRRG3DRfa0=', N'bobamarin1999@gmail.com', 1, N'Thanh Sơn 2', 2)
SET IDENTITY_INSERT [dbo].[AppUsers] OFF
GO
SET IDENTITY_INSERT [dbo].[Conditions] ON 

INSERT [dbo].[Conditions] ([Id], [CreateAt], [UpdateAt], [Type], [ImagePath], [Note], [VehicleId]) VALUES (1, CAST(N'2020-05-11T00:00:00.0000000' AS DateTime2), CAST(N'2020-05-11T00:00:00.0000000' AS DateTime2), N'Mark', N'Xe_Trang.png', N'không', 1)
INSERT [dbo].[Conditions] ([Id], [CreateAt], [UpdateAt], [Type], [ImagePath], [Note], [VehicleId]) VALUES (7, CAST(N'2020-11-17T10:55:59.2882832' AS DateTime2), CAST(N'2020-11-17T10:55:59.2884422' AS DateTime2), N'Dent', N'Xe_Xam.png', N'Không', 7)
INSERT [dbo].[Conditions] ([Id], [CreateAt], [UpdateAt], [Type], [ImagePath], [Note], [VehicleId]) VALUES (8, CAST(N'2020-11-17T10:56:17.6446627' AS DateTime2), CAST(N'2020-11-17T10:56:17.6446641' AS DateTime2), N'Mark', N'Xe_Vang.png', N'Không', 7)
INSERT [dbo].[Conditions] ([Id], [CreateAt], [UpdateAt], [Type], [ImagePath], [Note], [VehicleId]) VALUES (9, CAST(N'2020-11-20T15:28:47.4704927' AS DateTime2), CAST(N'2020-11-20T15:28:47.4705634' AS DateTime2), N'asdsa', N'Xe_Vang.png', N'Không', 3)
INSERT [dbo].[Conditions] ([Id], [CreateAt], [UpdateAt], [Type], [ImagePath], [Note], [VehicleId]) VALUES (10, CAST(N'2020-11-20T15:33:57.5107265' AS DateTime2), CAST(N'2020-11-20T15:33:57.5108885' AS DateTime2), N'Mark', N'Xe_Xam.png', N'Không', 2)
SET IDENTITY_INSERT [dbo].[Conditions] OFF
GO
SET IDENTITY_INSERT [dbo].[Customers] ON 

INSERT [dbo].[Customers] ([Id], [CreateAt], [UpdateAt], [FirstName], [LastName], [Phone], [Email], [Address1], [Address2], [City], [Country], [isDelete]) VALUES (4, CAST(N'2020-05-11T00:00:00.0000000' AS DateTime2), CAST(N'2020-05-11T00:00:00.0000000' AS DateTime2), N'Thanh', N'Sơn', N'0965746581', N'Bobamarin1999@gmail.com', N'13 Hà Lê', N'Không', N'HCM', N'Bình Định', 0)
INSERT [dbo].[Customers] ([Id], [CreateAt], [UpdateAt], [FirstName], [LastName], [Phone], [Email], [Address1], [Address2], [City], [Country], [isDelete]) VALUES (6, CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), CAST(N'2020-11-18T17:07:17.5332876' AS DateTime2), N'Hà', N'Đoàn', N'0984678264', N'HaDoan@gmail.com', N'67 Tĩnh Vinh', N'Không', N'HN', N'Việt Nam', 0)
INSERT [dbo].[Customers] ([Id], [CreateAt], [UpdateAt], [FirstName], [LastName], [Phone], [Email], [Address1], [Address2], [City], [Country], [isDelete]) VALUES (7, CAST(N'2020-05-11T00:00:00.0000000' AS DateTime2), CAST(N'2020-05-11T00:00:00.0000000' AS DateTime2), N'Dũng', N'Cò', N'0943268543', N'DungCo@gmail.com', N'55 Hà Đông', N'Không', N'HCM', N'Gia Lai', 0)
INSERT [dbo].[Customers] ([Id], [CreateAt], [UpdateAt], [FirstName], [LastName], [Phone], [Email], [Address1], [Address2], [City], [Country], [isDelete]) VALUES (8, CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), N'Test', N'test', N'0965746574', N'hs@gmail.com', N'15 le han', N'65 le duan', N'HCM', N'BD', 1)
INSERT [dbo].[Customers] ([Id], [CreateAt], [UpdateAt], [FirstName], [LastName], [Phone], [Email], [Address1], [Address2], [City], [Country], [isDelete]) VALUES (9, CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), CAST(N'2020-11-13T10:03:58.5758147' AS DateTime2), N'Test', N'Test', N'Test', N'Test', N'Test', N'Kh', N'Test', N'Test', 1)
INSERT [dbo].[Customers] ([Id], [CreateAt], [UpdateAt], [FirstName], [LastName], [Phone], [Email], [Address1], [Address2], [City], [Country], [isDelete]) VALUES (10, CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), CAST(N'2020-11-17T09:29:57.5516969' AS DateTime2), N'Test6', N'Test6', N'Test6', N'Test6', N'Test6', N'Test6', N'Test6', N'Test6', 1)
SET IDENTITY_INSERT [dbo].[Customers] OFF
GO
SET IDENTITY_INSERT [dbo].[Makes] ON 

INSERT [dbo].[Makes] ([Id], [CreateAt], [UpdateAt], [Name], [isDelete]) VALUES (2, CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), CAST(N'2020-11-20T15:05:33.4260914' AS DateTime2), N'BMW', 0)
INSERT [dbo].[Makes] ([Id], [CreateAt], [UpdateAt], [Name], [isDelete]) VALUES (3, CAST(N'2020-05-11T00:00:00.0000000' AS DateTime2), CAST(N'2020-05-11T00:00:00.0000000' AS DateTime2), N'Toyota', 0)
INSERT [dbo].[Makes] ([Id], [CreateAt], [UpdateAt], [Name], [isDelete]) VALUES (4, CAST(N'2020-05-11T00:00:00.0000000' AS DateTime2), CAST(N'2020-05-11T00:00:00.0000000' AS DateTime2), N'Yamaha', 0)
INSERT [dbo].[Makes] ([Id], [CreateAt], [UpdateAt], [Name], [isDelete]) VALUES (5, CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), CAST(N'2020-11-17T09:30:08.5492789' AS DateTime2), N'TestUpdate', 1)
INSERT [dbo].[Makes] ([Id], [CreateAt], [UpdateAt], [Name], [isDelete]) VALUES (6, CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), CAST(N'2020-11-20T15:08:17.9128251' AS DateTime2), N'test6', 1)
INSERT [dbo].[Makes] ([Id], [CreateAt], [UpdateAt], [Name], [isDelete]) VALUES (7, CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), CAST(N'2020-11-06T10:01:59.4334870' AS DateTime2), N'Testtt', 1)
INSERT [dbo].[Makes] ([Id], [CreateAt], [UpdateAt], [Name], [isDelete]) VALUES (8, CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), CAST(N'2020-11-20T11:28:30.5838410' AS DateTime2), N'Testtt', 1)
INSERT [dbo].[Makes] ([Id], [CreateAt], [UpdateAt], [Name], [isDelete]) VALUES (9, CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), CAST(N'2020-11-06T10:33:58.7457859' AS DateTime2), N'testtt', 1)
INSERT [dbo].[Makes] ([Id], [CreateAt], [UpdateAt], [Name], [isDelete]) VALUES (10, CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), N'testtt', 1)
INSERT [dbo].[Makes] ([Id], [CreateAt], [UpdateAt], [Name], [isDelete]) VALUES (11, CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), CAST(N'2020-11-13T09:55:46.5552840' AS DateTime2), N'Test11', 0)
SET IDENTITY_INSERT [dbo].[Makes] OFF
GO
SET IDENTITY_INSERT [dbo].[Models] ON 

INSERT [dbo].[Models] ([Id], [CreateAt], [UpdateAt], [Name], [Year], [isDelete]) VALUES (1, CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), CAST(N'2020-11-20T15:24:55.2128986' AS DateTime2), N'Loop', N'1989', 0)
INSERT [dbo].[Models] ([Id], [CreateAt], [UpdateAt], [Name], [Year], [isDelete]) VALUES (2, CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), CAST(N'2020-11-15T07:52:30.8976676' AS DateTime2), N'Tool', N'1987', 0)
INSERT [dbo].[Models] ([Id], [CreateAt], [UpdateAt], [Name], [Year], [isDelete]) VALUES (3, CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), CAST(N'2020-11-15T07:52:46.8345971' AS DateTime2), N'Sephia', N'1988', 0)
INSERT [dbo].[Models] ([Id], [CreateAt], [UpdateAt], [Name], [Year], [isDelete]) VALUES (4, CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), N'testttt', N'1901', 1)
INSERT [dbo].[Models] ([Id], [CreateAt], [UpdateAt], [Name], [Year], [isDelete]) VALUES (5, CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), CAST(N'2020-11-13T09:58:56.6314996' AS DateTime2), N'Test11', N'1999', 1)
INSERT [dbo].[Models] ([Id], [CreateAt], [UpdateAt], [Name], [Year], [isDelete]) VALUES (6, CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), CAST(N'2020-11-17T09:30:14.1424586' AS DateTime2), N'Test6', N'Test6', 1)
SET IDENTITY_INSERT [dbo].[Models] OFF
GO
SET IDENTITY_INSERT [dbo].[VehicleAppraisals] ON 

INSERT [dbo].[VehicleAppraisals] ([Id], [CreateAt], [UpdateAt], [AppraisalValue], [VehicleId]) VALUES (1, CAST(N'2020-05-11T00:00:00.0000000' AS DateTime2), CAST(N'2020-05-11T00:00:00.0000000' AS DateTime2), N'10000', 1)
INSERT [dbo].[VehicleAppraisals] ([Id], [CreateAt], [UpdateAt], [AppraisalValue], [VehicleId]) VALUES (3, CAST(N'2020-05-11T00:00:00.0000000' AS DateTime2), CAST(N'2020-05-11T00:00:00.0000000' AS DateTime2), N'30000', 3)
INSERT [dbo].[VehicleAppraisals] ([Id], [CreateAt], [UpdateAt], [AppraisalValue], [VehicleId]) VALUES (9, CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), CAST(N'2020-11-14T08:27:31.4845707' AS DateTime2), N'30001', 1)
INSERT [dbo].[VehicleAppraisals] ([Id], [CreateAt], [UpdateAt], [AppraisalValue], [VehicleId]) VALUES (13, CAST(N'2020-11-20T15:34:36.1492132' AS DateTime2), CAST(N'2020-11-20T15:34:36.1492148' AS DateTime2), N'25000000', 2)
SET IDENTITY_INSERT [dbo].[VehicleAppraisals] OFF
GO
SET IDENTITY_INSERT [dbo].[VehicleCrawlDatas] ON 

INSERT [dbo].[VehicleCrawlDatas] ([Id], [CreateAt], [UpdateAt], [Name], [Image], [Value]) VALUES (242, CAST(N'2020-11-19T09:08:15.2898855' AS DateTime2), CAST(N'2020-11-19T09:08:15.2899934' AS DateTime2), N'Audi A4', N'https://img.tinbanxe.vn/images/Audi/Audi-A4/ANHDAIDIENaudi-a4-argus-brown.png', N'1,695,000,000  VND')
INSERT [dbo].[VehicleCrawlDatas] ([Id], [CreateAt], [UpdateAt], [Name], [Image], [Value]) VALUES (243, CAST(N'2020-11-19T09:08:24.3264375' AS DateTime2), CAST(N'2020-11-19T09:08:24.3264387' AS DateTime2), N'Suzuki XL7', N'https://img.tinbanxe.vn/images/Suzuki/anh-dai-dien-suzuki-xl7-2020.png', N'589,000,000  VND')
INSERT [dbo].[VehicleCrawlDatas] ([Id], [CreateAt], [UpdateAt], [Name], [Image], [Value]) VALUES (244, CAST(N'2020-11-19T09:08:24.3267928' AS DateTime2), CAST(N'2020-11-19T09:08:24.3267938' AS DateTime2), N'Suzuki Ertiga', N'https://img.tinbanxe.vn/images/Suzuki/suzuki-ertiga-2020(1).png', N'499,000,000  VND')
INSERT [dbo].[VehicleCrawlDatas] ([Id], [CreateAt], [UpdateAt], [Name], [Image], [Value]) VALUES (245, CAST(N'2020-11-19T09:08:24.3270532' AS DateTime2), CAST(N'2020-11-19T09:08:24.3270541' AS DateTime2), N'Suzuki Vitara', N'https://img.tinbanxe.vn/images/Suzuki/anh-dai-dien-suzuki-vitara-2020.png', N'779,000,000  VND')
INSERT [dbo].[VehicleCrawlDatas] ([Id], [CreateAt], [UpdateAt], [Name], [Image], [Value]) VALUES (246, CAST(N'2020-11-19T09:08:24.3272773' AS DateTime2), CAST(N'2020-11-19T09:08:24.3272778' AS DateTime2), N'Suzuki Ciaz', N'https://img.tinbanxe.vn/images/Suzuki/anh-dai-dien-suzuki-ciaz-2020.png', N'499,000,000  VND')
INSERT [dbo].[VehicleCrawlDatas] ([Id], [CreateAt], [UpdateAt], [Name], [Image], [Value]) VALUES (247, CAST(N'2020-11-19T09:08:24.3274894' AS DateTime2), CAST(N'2020-11-19T09:08:24.3274899' AS DateTime2), N'Suzuki Swift', N'https://img.tinbanxe.vn/images/Suzuki/anh-dai-dien-suzuki-swift-2020.png', N'499,000,000  VND')
INSERT [dbo].[VehicleCrawlDatas] ([Id], [CreateAt], [UpdateAt], [Name], [Image], [Value]) VALUES (248, CAST(N'2020-11-19T09:08:24.3277327' AS DateTime2), CAST(N'2020-11-19T09:08:24.3277335' AS DateTime2), N'Suzuki Celerio', N'https://img.tinbanxe.vn/images/Suzuki/suzuki-celerio-2020.png', N'359,000,000  VND')
INSERT [dbo].[VehicleCrawlDatas] ([Id], [CreateAt], [UpdateAt], [Name], [Image], [Value]) VALUES (249, CAST(N'2020-11-19T09:08:26.6074856' AS DateTime2), CAST(N'2020-11-19T09:08:26.6074867' AS DateTime2), N'Toyota Land Cruiser Prado', N'https://img.tinbanxe.vn/images/Toyota/Toyota-Land-Cruiser-Prado/ANHDAIDIEN-ToyotaandCruiserPrado.png', N'2,379,000,000  VND')
INSERT [dbo].[VehicleCrawlDatas] ([Id], [CreateAt], [UpdateAt], [Name], [Image], [Value]) VALUES (250, CAST(N'2020-11-19T09:08:26.6076936' AS DateTime2), CAST(N'2020-11-19T09:08:26.6076939' AS DateTime2), N'Toyota Sienta', N'https://img.tinbanxe.vn/images/Toyota/toyota-sienta/hinh-xe-toyota-sienta.png', N'44,310  USD')
INSERT [dbo].[VehicleCrawlDatas] ([Id], [CreateAt], [UpdateAt], [Name], [Image], [Value]) VALUES (251, CAST(N'2020-11-19T09:08:26.6083801' AS DateTime2), CAST(N'2020-11-19T09:08:26.6083809' AS DateTime2), N'Toyota Alphard', N'https://img.tinbanxe.vn/images/Toyota/toyota-alphard/dai-dien-toyota-alphard.png', N'4,038,000,000  VND')
INSERT [dbo].[VehicleCrawlDatas] ([Id], [CreateAt], [UpdateAt], [Name], [Image], [Value]) VALUES (252, CAST(N'2020-11-19T09:08:26.6086016' AS DateTime2), CAST(N'2020-11-19T09:08:26.6086019' AS DateTime2), N'Toyota Yaris Cross', N'https://img.tinbanxe.vn/images/Toyota/toyota-yaris-cross/dai-dien-toyota-yaris-cross.png', N'19,200  USD')
INSERT [dbo].[VehicleCrawlDatas] ([Id], [CreateAt], [UpdateAt], [Name], [Image], [Value]) VALUES (253, CAST(N'2020-11-19T09:08:26.6087338' AS DateTime2), CAST(N'2020-11-19T09:08:26.6087341' AS DateTime2), N'Toyota Hiace', N'https://img.tinbanxe.vn/images/Toyota/toyota-hiace-2020.png', N'1,176,000,000  VND')
INSERT [dbo].[VehicleCrawlDatas] ([Id], [CreateAt], [UpdateAt], [Name], [Image], [Value]) VALUES (254, CAST(N'2020-11-19T09:08:26.6088604' AS DateTime2), CAST(N'2020-11-19T09:08:26.6088607' AS DateTime2), N'Toyota Fortuner', N'https://img.tinbanxe.vn/images/Toyota/Toyota-Fortuner/anh-dai-dien-toyota-fortuner-2020.png', N'1,096,000,000  VND')
INSERT [dbo].[VehicleCrawlDatas] ([Id], [CreateAt], [UpdateAt], [Name], [Image], [Value]) VALUES (255, CAST(N'2020-11-19T09:08:26.6090022' AS DateTime2), CAST(N'2020-11-19T09:08:26.6090025' AS DateTime2), N'Toyota Camry', N'https://img.tinbanxe.vn/images/Toyota/toyota-camry-2020.png', N'1,029,000,000  VND')
INSERT [dbo].[VehicleCrawlDatas] ([Id], [CreateAt], [UpdateAt], [Name], [Image], [Value]) VALUES (256, CAST(N'2020-11-19T09:08:26.6091396' AS DateTime2), CAST(N'2020-11-19T09:08:26.6091399' AS DateTime2), N'Toyota FT-86', N'https://img.tinbanxe.vn/images/Toyota/Toyota-ft-86-2020.png', N'1,687,000,000  VND')
INSERT [dbo].[VehicleCrawlDatas] ([Id], [CreateAt], [UpdateAt], [Name], [Image], [Value]) VALUES (257, CAST(N'2020-11-19T09:08:26.6092648' AS DateTime2), CAST(N'2020-11-19T09:08:26.6092650' AS DateTime2), N'Toyota Avanza', N'https://img.tinbanxe.vn/images/Toyota/toyota-avanza.png', N'544,000,000  VND')
INSERT [dbo].[VehicleCrawlDatas] ([Id], [CreateAt], [UpdateAt], [Name], [Image], [Value]) VALUES (258, CAST(N'2020-11-19T09:08:26.6093830' AS DateTime2), CAST(N'2020-11-19T09:08:26.6093833' AS DateTime2), N'Toyota Corolla Altis', N'https://img.tinbanxe.vn/images/Toyota/toyota-corolla-altis-2020.png', N'733,000,000  VND')
INSERT [dbo].[VehicleCrawlDatas] ([Id], [CreateAt], [UpdateAt], [Name], [Image], [Value]) VALUES (259, CAST(N'2020-11-19T09:08:26.6094957' AS DateTime2), CAST(N'2020-11-19T09:08:26.6094959' AS DateTime2), N'Toyota Hilux', N'https://img.tinbanxe.vn/images/Toyota/Toyota-Hilux/khac/toyota-hilux-2020-94754.png', N'674,000,000  VND')
INSERT [dbo].[VehicleCrawlDatas] ([Id], [CreateAt], [UpdateAt], [Name], [Image], [Value]) VALUES (260, CAST(N'2020-11-19T09:08:26.6096347' AS DateTime2), CAST(N'2020-11-19T09:08:26.6096350' AS DateTime2), N'Toyota Innova', N'https://img.tinbanxe.vn/images/Toyota/toyota-innova-crysta-2020.png', N'771,000,000  VND')
INSERT [dbo].[VehicleCrawlDatas] ([Id], [CreateAt], [UpdateAt], [Name], [Image], [Value]) VALUES (261, CAST(N'2020-11-19T09:08:26.6097547' AS DateTime2), CAST(N'2020-11-19T09:08:26.6097550' AS DateTime2), N'Toyota Rush', N'https://img.tinbanxe.vn/images/Toyota/toyota-rush-2020.png', N'668,000,000  VND')
INSERT [dbo].[VehicleCrawlDatas] ([Id], [CreateAt], [UpdateAt], [Name], [Image], [Value]) VALUES (262, CAST(N'2020-11-19T09:08:23.2111577' AS DateTime2), CAST(N'2020-11-19T09:08:23.2111581' AS DateTime2), N'Lexus RC 300', N'https://img.tinbanxe.vn/images/Lexus/lexus-rc-300.png', N'3,270,000,000  VND')
INSERT [dbo].[VehicleCrawlDatas] ([Id], [CreateAt], [UpdateAt], [Name], [Image], [Value]) VALUES (263, CAST(N'2020-11-19T09:08:26.6098717' AS DateTime2), CAST(N'2020-11-19T09:08:26.6098720' AS DateTime2), N'Toyota Sienna', N'https://img.tinbanxe.vn/images/Toyota/toytota-siena-2020.png', N'4,000,000,000  VND')
INSERT [dbo].[VehicleCrawlDatas] ([Id], [CreateAt], [UpdateAt], [Name], [Image], [Value]) VALUES (264, CAST(N'2020-11-19T09:08:23.2109223' AS DateTime2), CAST(N'2020-11-19T09:08:23.2109230' AS DateTime2), N'Lexus GS350', N'https://img.tinbanxe.vn/images/Lexus/lexus-gs-350-2018.png', N'3,130,000,000  VND')
INSERT [dbo].[VehicleCrawlDatas] ([Id], [CreateAt], [UpdateAt], [Name], [Image], [Value]) VALUES (265, CAST(N'2020-11-19T09:08:23.2103771' AS DateTime2), CAST(N'2020-11-19T09:08:23.2103779' AS DateTime2), N'Lexus LC500', N'https://img.tinbanxe.vn/images/Lexus/lexus-LC-500-2020.png', N'12,400,000,000  VND')
INSERT [dbo].[VehicleCrawlDatas] ([Id], [CreateAt], [UpdateAt], [Name], [Image], [Value]) VALUES (266, CAST(N'2020-11-19T09:08:21.7723150' AS DateTime2), CAST(N'2020-11-19T09:08:21.7723153' AS DateTime2), N'Honda HR – V', N'https://img.tinbanxe.vn/images/Honda/Honda-HR-V/khac/Honda%20hr-v.png', N'786,000,000  VND')
INSERT [dbo].[VehicleCrawlDatas] ([Id], [CreateAt], [UpdateAt], [Name], [Image], [Value]) VALUES (267, CAST(N'2020-11-19T09:08:21.7724770' AS DateTime2), CAST(N'2020-11-19T09:08:21.7724773' AS DateTime2), N'Honda Passport', N'https://img.tinbanxe.vn/images/Honda%20Passport.png', N'27,000  USD')
INSERT [dbo].[VehicleCrawlDatas] ([Id], [CreateAt], [UpdateAt], [Name], [Image], [Value]) VALUES (268, CAST(N'2020-11-19T09:08:21.7726147' AS DateTime2), CAST(N'2020-11-19T09:08:21.7726149' AS DateTime2), N'Honda Jazz', N'https://img.tinbanxe.vn/images/Honda/Honda-Jazz/khac/Honda%20Jazz(1).png', N'624,000,000  VND')
INSERT [dbo].[VehicleCrawlDatas] ([Id], [CreateAt], [UpdateAt], [Name], [Image], [Value]) VALUES (269, CAST(N'2020-11-19T09:08:21.7727508' AS DateTime2), CAST(N'2020-11-19T09:08:21.7727510' AS DateTime2), N'Honda Odyssey', N'https://img.tinbanxe.vn/images/Honda/Honda-odyssey/dai-dien-honda-odyssey.png', N'1,990,000,000  VND')
INSERT [dbo].[VehicleCrawlDatas] ([Id], [CreateAt], [UpdateAt], [Name], [Image], [Value]) VALUES (270, CAST(N'2020-11-19T09:08:23.2066725' AS DateTime2), CAST(N'2020-11-19T09:08:23.2066738' AS DateTime2), N'Lexus ES350', N'https://img.tinbanxe.vn/images/Lexus/lexus-es-350-nam-2020.png', N'3,210,000,000  VND')
INSERT [dbo].[VehicleCrawlDatas] ([Id], [CreateAt], [UpdateAt], [Name], [Image], [Value]) VALUES (271, CAST(N'2020-11-19T09:08:23.2068908' AS DateTime2), CAST(N'2020-11-19T09:08:23.2068910' AS DateTime2), N'Lexus GX 460', N'https://img.tinbanxe.vn/images/Lexus/lexus-gx-460-nam-2020.png', N'5,690,000,000  VND')
INSERT [dbo].[VehicleCrawlDatas] ([Id], [CreateAt], [UpdateAt], [Name], [Image], [Value]) VALUES (272, CAST(N'2020-11-19T09:08:23.2070128' AS DateTime2), CAST(N'2020-11-19T09:08:23.2070131' AS DateTime2), N'Lexus LS460', N'https://img.tinbanxe.vn/images/Lexus/lexus-ls-460-nam-2020.png', NULL)
INSERT [dbo].[VehicleCrawlDatas] ([Id], [CreateAt], [UpdateAt], [Name], [Image], [Value]) VALUES (273, CAST(N'2020-11-19T09:08:23.2071408' AS DateTime2), CAST(N'2020-11-19T09:08:23.2071410' AS DateTime2), N'Lexus NX300', N'https://img.tinbanxe.vn/images/Lexus/lexus-nx-300-nam-2020.png', N'2,510,000,000  VND')
INSERT [dbo].[VehicleCrawlDatas] ([Id], [CreateAt], [UpdateAt], [Name], [Image], [Value]) VALUES (274, CAST(N'2020-11-19T09:08:23.2072989' AS DateTime2), CAST(N'2020-11-19T09:08:23.2072992' AS DateTime2), N'Lexus RX200t', N'https://img.tinbanxe.vn/images/Lexus/lexus-rx200t-2017.png', NULL)
INSERT [dbo].[VehicleCrawlDatas] ([Id], [CreateAt], [UpdateAt], [Name], [Image], [Value]) VALUES (275, CAST(N'2020-11-19T09:08:23.2074187' AS DateTime2), CAST(N'2020-11-19T09:08:23.2074190' AS DateTime2), N'Lexus ES 250', N'https://img.tinbanxe.vn/images/Lexus/lexus-es-250-2020.png', N'2,500,000,000  VND')
INSERT [dbo].[VehicleCrawlDatas] ([Id], [CreateAt], [UpdateAt], [Name], [Image], [Value]) VALUES (276, CAST(N'2020-11-19T09:08:23.2075561' AS DateTime2), CAST(N'2020-11-19T09:08:23.2075564' AS DateTime2), N'Lexus RX350', N'https://img.tinbanxe.vn/images/Lexus/lexus-rx-350-nam-2020.png', N'4,120,000,000  VND')
INSERT [dbo].[VehicleCrawlDatas] ([Id], [CreateAt], [UpdateAt], [Name], [Image], [Value]) VALUES (277, CAST(N'2020-11-19T09:08:23.2076822' AS DateTime2), CAST(N'2020-11-19T09:08:23.2076825' AS DateTime2), N'Lexus LX 570', N'https://img.tinbanxe.vn/images/Lexus/lexus-lx-570.png', N'8,340,000,000  VND')
INSERT [dbo].[VehicleCrawlDatas] ([Id], [CreateAt], [UpdateAt], [Name], [Image], [Value]) VALUES (278, CAST(N'2020-11-19T09:08:23.2078060' AS DateTime2), CAST(N'2020-11-19T09:08:23.2078063' AS DateTime2), N'Lexus RX450', N'https://img.tinbanxe.vn/images/Lexus/lexus-rx-450h-nam-2020.png', N'4,120,000,000  VND')
INSERT [dbo].[VehicleCrawlDatas] ([Id], [CreateAt], [UpdateAt], [Name], [Image], [Value]) VALUES (279, CAST(N'2020-11-19T09:08:23.2079311' AS DateTime2), CAST(N'2020-11-19T09:08:23.2079314' AS DateTime2), N'Lexus RX300', N'https://img.tinbanxe.vn/images/Lexus/lexus-rx-300-nam-2020.png', N'3,180,000,000  VND')
INSERT [dbo].[VehicleCrawlDatas] ([Id], [CreateAt], [UpdateAt], [Name], [Image], [Value]) VALUES (280, CAST(N'2020-11-19T09:08:23.2080483' AS DateTime2), CAST(N'2020-11-19T09:08:23.2080485' AS DateTime2), N'Lexus UX200', N'https://img.tinbanxe.vn/images/Lexus/lexus-ux-200-new-2020.jpg', N'32,000  USD')
INSERT [dbo].[VehicleCrawlDatas] ([Id], [CreateAt], [UpdateAt], [Name], [Image], [Value]) VALUES (281, CAST(N'2020-11-19T09:08:23.2081763' AS DateTime2), CAST(N'2020-11-19T09:08:23.2081767' AS DateTime2), N'Lexus CT 200', N'https://img.tinbanxe.vn/images/Lexus/lexus-ct-200-2020.png', N'805,000,000  VND')
INSERT [dbo].[VehicleCrawlDatas] ([Id], [CreateAt], [UpdateAt], [Name], [Image], [Value]) VALUES (282, CAST(N'2020-11-19T09:08:23.2092214' AS DateTime2), CAST(N'2020-11-19T09:08:23.2092226' AS DateTime2), N'Lexus LM300h', N'https://img.tinbanxe.vn/images/Lexus/lexus-lm-300h-2020.png', N'11,000,000,000  VND')
INSERT [dbo].[VehicleCrawlDatas] ([Id], [CreateAt], [UpdateAt], [Name], [Image], [Value]) VALUES (283, CAST(N'2020-11-19T09:08:23.2095155' AS DateTime2), CAST(N'2020-11-19T09:08:23.2095159' AS DateTime2), N'Lexus GX470', N'https://img.tinbanxe.vn/images/Lexus/lexus-gx-470-2009.png', N'5,690,000,000  VND')
INSERT [dbo].[VehicleCrawlDatas] ([Id], [CreateAt], [UpdateAt], [Name], [Image], [Value]) VALUES (284, CAST(N'2020-11-19T09:08:23.2099566' AS DateTime2), CAST(N'2020-11-19T09:08:23.2099573' AS DateTime2), N'Lexus IS250', N'https://img.tinbanxe.vn/images/Lexus/lexus-is-250-nam-2020.png', N'2,450,000,000  VND')
INSERT [dbo].[VehicleCrawlDatas] ([Id], [CreateAt], [UpdateAt], [Name], [Image], [Value]) VALUES (285, CAST(N'2020-11-19T09:08:23.2106426' AS DateTime2), CAST(N'2020-11-19T09:08:23.2106434' AS DateTime2), N'Lexus LS 500', N'https://img.tinbanxe.vn/images/Lexus/lexus-ls-500-2020.png', NULL)
INSERT [dbo].[VehicleCrawlDatas] ([Id], [CreateAt], [UpdateAt], [Name], [Image], [Value]) VALUES (286, CAST(N'2020-11-19T09:08:26.6099859' AS DateTime2), CAST(N'2020-11-19T09:08:26.6099861' AS DateTime2), N'Toyota Vios', N'https://img.tinbanxe.vn/images/Toyota/toyota-vios-2020.png', N'520,000,000  VND')
INSERT [dbo].[VehicleCrawlDatas] ([Id], [CreateAt], [UpdateAt], [Name], [Image], [Value]) VALUES (287, CAST(N'2020-11-19T09:08:26.6101161' AS DateTime2), CAST(N'2020-11-19T09:08:26.6101164' AS DateTime2), N'Toyota Wigo', N'https://img.tinbanxe.vn/images/Toyota/toyota-wigo-2020.png', N'384,000,000  VND')
INSERT [dbo].[VehicleCrawlDatas] ([Id], [CreateAt], [UpdateAt], [Name], [Image], [Value]) VALUES (288, CAST(N'2020-11-19T09:08:26.6102390' AS DateTime2), CAST(N'2020-11-19T09:08:26.6102393' AS DateTime2), N'Toyota Yaris', N'https://img.tinbanxe.vn/images/Toyota/toyota-yaris.png', N'650,000,000  VND')
INSERT [dbo].[VehicleCrawlDatas] ([Id], [CreateAt], [UpdateAt], [Name], [Image], [Value]) VALUES (289, CAST(N'2020-11-19T09:08:28.4894543' AS DateTime2), CAST(N'2020-11-19T09:08:28.4894546' AS DateTime2), N'Hyundai Tucson', N'https://img.tinbanxe.vn/images/HYUNDAI/hyundai-tucson/bao_gia_hyundai_tucson-ANHDAIDIEN.png', N'932,000,000  VND')
INSERT [dbo].[VehicleCrawlDatas] ([Id], [CreateAt], [UpdateAt], [Name], [Image], [Value]) VALUES (290, CAST(N'2020-11-19T09:08:28.4896033' AS DateTime2), CAST(N'2020-11-19T09:08:28.4896036' AS DateTime2), N'Hyundai i10', N'https://img.tinbanxe.vn/images/HYUNDAI/hyundai-i10-hatchback/hyundai-i10-sedan.png', N'405,000,000  VND')
INSERT [dbo].[VehicleCrawlDatas] ([Id], [CreateAt], [UpdateAt], [Name], [Image], [Value]) VALUES (291, CAST(N'2020-11-19T09:08:28.4897231' AS DateTime2), CAST(N'2020-11-19T09:08:28.4897235' AS DateTime2), N'Hyundai Avante', N'https://img.tinbanxe.vn/images/HYUNDAI/HYUNDAI_AVANTE/Hyundai-Avante-ANHDAIDIEN.png', N'580,000,000  VND')
INSERT [dbo].[VehicleCrawlDatas] ([Id], [CreateAt], [UpdateAt], [Name], [Image], [Value]) VALUES (292, CAST(N'2020-11-19T09:08:28.4898432' AS DateTime2), CAST(N'2020-11-19T09:08:28.4898434' AS DateTime2), N'Hyundai I20', N'https://img.tinbanxe.vn/images/HYUNDAI/HYUNDAI-I20/87-877773_2020-hyundai-i20-ANHDAIDIEN.png', N'606,000,000  VND')
INSERT [dbo].[VehicleCrawlDatas] ([Id], [CreateAt], [UpdateAt], [Name], [Image], [Value]) VALUES (293, CAST(N'2020-11-19T09:08:28.4899655' AS DateTime2), CAST(N'2020-11-19T09:08:28.4899657' AS DateTime2), N'Hyundai Creta', N'https://img.tinbanxe.vn/images/HYUNDAI/HYUNDAI-CRETA/mau-xe-hyundai-cretaANHDAIDIEN.png', N'787,000,000  VND')
INSERT [dbo].[VehicleCrawlDatas] ([Id], [CreateAt], [UpdateAt], [Name], [Image], [Value]) VALUES (294, CAST(N'2020-11-19T09:08:28.4900866' AS DateTime2), CAST(N'2020-11-19T09:08:28.4900868' AS DateTime2), N'Hyundai Starex', N'https://img.tinbanxe.vn/images/HYUNDAI/HYUNDAI_STAREX/Starex_9_cho_ANHDAIDIEN.png', N'1,019,000,000  VND')
INSERT [dbo].[VehicleCrawlDatas] ([Id], [CreateAt], [UpdateAt], [Name], [Image], [Value]) VALUES (295, CAST(N'2020-11-19T09:08:28.4902230' AS DateTime2), CAST(N'2020-11-19T09:08:28.4902232' AS DateTime2), N'Hyundai Veloster', N'https://img.tinbanxe.vn/images/HYUNDAI/HYUNDAI-VELOSTER/HYUNDAI-VELOSTER-ANHDAIDIEN.png', N'510,000,000  VND')
INSERT [dbo].[VehicleCrawlDatas] ([Id], [CreateAt], [UpdateAt], [Name], [Image], [Value]) VALUES (296, CAST(N'2020-11-19T09:08:28.4903407' AS DateTime2), CAST(N'2020-11-19T09:08:28.4903410' AS DateTime2), N'Hyundai Azera', N'https://img.tinbanxe.vn/images/HYUNDAI/HUYNDAI-AZERA/hyundai-azera-2020_ANHDAIDIENpng.png', N'648,000,000  VND')
INSERT [dbo].[VehicleCrawlDatas] ([Id], [CreateAt], [UpdateAt], [Name], [Image], [Value]) VALUES (297, CAST(N'2020-11-19T09:08:28.4904639' AS DateTime2), CAST(N'2020-11-19T09:08:28.4904644' AS DateTime2), N'Hyundai Nexo', N'https://img.tinbanxe.vn/images/HYUNDAI/HYUNDAI-Nexo/hyundai-nexo-2020_%C3%81NHDAIDIEN.png', N'1,500,000,000  VND')
INSERT [dbo].[VehicleCrawlDatas] ([Id], [CreateAt], [UpdateAt], [Name], [Image], [Value]) VALUES (298, CAST(N'2020-11-19T09:08:28.4907916' AS DateTime2), CAST(N'2020-11-19T09:08:28.4907922' AS DateTime2), N'Hyundai Palisade', N'https://img.tinbanxe.vn/images/HYUNDAI/hyundai-palisade/Hyundai-palisade_ANHDAIDIEN.png', N'4,050,000,000  VND')
INSERT [dbo].[VehicleCrawlDatas] ([Id], [CreateAt], [UpdateAt], [Name], [Image], [Value]) VALUES (299, CAST(N'2020-11-19T09:08:28.4913555' AS DateTime2), CAST(N'2020-11-19T09:08:28.4913566' AS DateTime2), N'Hyundai Ioniq', N'https://img.tinbanxe.vn/images/HYUNDAI/Hyundai-Ioniq/Hyundai-Ioniq-ANHDAIDIEN.png', N'572,000,000  VND')
INSERT [dbo].[VehicleCrawlDatas] ([Id], [CreateAt], [UpdateAt], [Name], [Image], [Value]) VALUES (300, CAST(N'2020-11-19T09:08:28.4919882' AS DateTime2), CAST(N'2020-11-19T09:08:28.4919894' AS DateTime2), N'Hyundai Grandeur', N'https://img.tinbanxe.vn/images/HYUNDAI/Hyundai-Grandeur/Hyundai-Grandeur-ANHDAIDIENpng.png', N'667,000,000  VND')
INSERT [dbo].[VehicleCrawlDatas] ([Id], [CreateAt], [UpdateAt], [Name], [Image], [Value]) VALUES (301, CAST(N'2020-11-19T09:08:28.4923273' AS DateTime2), CAST(N'2020-11-19T09:08:28.4923282' AS DateTime2), N'Hyundai Santa Cruz', N'https://img.tinbanxe.vn/images/HYUNDAI/Hyundai-Santa-Cruz/hyundai-santa-cruz-2021ANHDAIDIEN.png', N'25,000  USD')
INSERT [dbo].[VehicleCrawlDatas] ([Id], [CreateAt], [UpdateAt], [Name], [Image], [Value]) VALUES (302, CAST(N'2020-11-19T09:08:29.5396227' AS DateTime2), CAST(N'2020-11-19T09:08:29.5396238' AS DateTime2), N'Mitsubishi Xpander Cross', N'https://img.tinbanxe.vn/images/Mitsubishi/Mitsubishi-Xpander-Cross/dai-dien-mitsubishi-xpander-cross.png', N'670,000,000  VND')
INSERT [dbo].[VehicleCrawlDatas] ([Id], [CreateAt], [UpdateAt], [Name], [Image], [Value]) VALUES (303, CAST(N'2020-11-19T09:08:29.5398269' AS DateTime2), CAST(N'2020-11-19T09:08:29.5398272' AS DateTime2), N'Mitsubishi Grandis', N'https://img.tinbanxe.vn/images/Mitsubishi/mitsubishi-grandis-1.png', N'44  USD')
INSERT [dbo].[VehicleCrawlDatas] ([Id], [CreateAt], [UpdateAt], [Name], [Image], [Value]) VALUES (304, CAST(N'2020-11-19T09:08:29.5399455' AS DateTime2), CAST(N'2020-11-19T09:08:29.5399457' AS DateTime2), N'Mitsubishi Triton', N'https://img.tinbanxe.vn/images/Mitsubishi/mitsubishi-triton-2020.png', N'730,000,000  VND')
INSERT [dbo].[VehicleCrawlDatas] ([Id], [CreateAt], [UpdateAt], [Name], [Image], [Value]) VALUES (305, CAST(N'2020-11-19T09:08:29.5401209' AS DateTime2), CAST(N'2020-11-19T09:08:29.5401213' AS DateTime2), N'Mitsubishi Pajero Sport', N'https://img.tinbanxe.vn/images/Mitsubishi/mitsubishi-pajero-sport-2020.png', N'1,062,000,000  VND')
INSERT [dbo].[VehicleCrawlDatas] ([Id], [CreateAt], [UpdateAt], [Name], [Image], [Value]) VALUES (306, CAST(N'2020-11-19T09:08:29.5403500' AS DateTime2), CAST(N'2020-11-19T09:08:29.5403504' AS DateTime2), N'Mitsubishi Attrage', N'https://img.tinbanxe.vn/images/Mitsubishi/mitsubishi-attrage.png', N'460,000,000  VND')
INSERT [dbo].[VehicleCrawlDatas] ([Id], [CreateAt], [UpdateAt], [Name], [Image], [Value]) VALUES (307, CAST(N'2020-11-19T09:08:29.5405777' AS DateTime2), CAST(N'2020-11-19T09:08:29.5405781' AS DateTime2), N'Mitsubishi Mirage', N'https://img.tinbanxe.vn/images/Mitsubishi/mitsubishi-mirage.png', N'475,000,000  VND')
INSERT [dbo].[VehicleCrawlDatas] ([Id], [CreateAt], [UpdateAt], [Name], [Image], [Value]) VALUES (308, CAST(N'2020-11-19T09:08:28.4893358' AS DateTime2), CAST(N'2020-11-19T09:08:28.4893361' AS DateTime2), N'Hyundai Santafe', N'https://img.tinbanxe.vn/images/HYUNDAI/Hyundai-santafe/ANHDAIDIEN-hyundai-santa-fe-calypso-red.png', N'995,000,000  VND')
INSERT [dbo].[VehicleCrawlDatas] ([Id], [CreateAt], [UpdateAt], [Name], [Image], [Value]) VALUES (309, CAST(N'2020-11-19T09:08:28.4892132' AS DateTime2), CAST(N'2020-11-19T09:08:28.4892135' AS DateTime2), N'Hyundai Kona', N'https://img.tinbanxe.vn/images/HYUNDAI/hyundai-kona/ANHDAIDIENhyundai-kona-.png', N'725,000,000  VND')
INSERT [dbo].[VehicleCrawlDatas] ([Id], [CreateAt], [UpdateAt], [Name], [Image], [Value]) VALUES (310, CAST(N'2020-11-19T09:08:28.4890850' AS DateTime2), CAST(N'2020-11-19T09:08:28.4890853' AS DateTime2), N'Hyundai Elantra', N'https://img.tinbanxe.vn/images/HYUNDAI/hyundai-elantra/hyundai-elantra-2020-anhdaidien.png', N'655,000,000  VND')
INSERT [dbo].[VehicleCrawlDatas] ([Id], [CreateAt], [UpdateAt], [Name], [Image], [Value]) VALUES (311, CAST(N'2020-11-19T09:08:28.4889602' AS DateTime2), CAST(N'2020-11-19T09:08:28.4889605' AS DateTime2), N'Hyundai Accent', N'https://img.tinbanxe.vn/images/HYUNDAI/HYUNDAI_ACCENT/hyundai_accent_-anhdaidien-min.png', N'499,000,000  VND')
INSERT [dbo].[VehicleCrawlDatas] ([Id], [CreateAt], [UpdateAt], [Name], [Image], [Value]) VALUES (312, CAST(N'2020-11-19T09:08:26.6103619' AS DateTime2), CAST(N'2020-11-19T09:08:26.6103621' AS DateTime2), N'Toyota Land Cruiser', N'https://img.tinbanxe.vn/images/Toyota/toyota-land-cruiser-2020.png', N'4,030,000,000  VND')
INSERT [dbo].[VehicleCrawlDatas] ([Id], [CreateAt], [UpdateAt], [Name], [Image], [Value]) VALUES (313, CAST(N'2020-11-19T09:08:26.6104803' AS DateTime2), CAST(N'2020-11-19T09:08:26.6104806' AS DateTime2), N'Toyota Highlander', N'https://img.tinbanxe.vn/images/Toyota/toyota-highlander-2020.png', N'4,413,000,000  VND')
INSERT [dbo].[VehicleCrawlDatas] ([Id], [CreateAt], [UpdateAt], [Name], [Image], [Value]) VALUES (314, CAST(N'2020-11-19T09:08:26.6105963' AS DateTime2), CAST(N'2020-11-19T09:08:26.6105965' AS DateTime2), N'Toyota Prius', N'https://img.tinbanxe.vn/images/Toyota/toyota-prius-2020.png', N'1,000,000,000  VND')
INSERT [dbo].[VehicleCrawlDatas] ([Id], [CreateAt], [UpdateAt], [Name], [Image], [Value]) VALUES (315, CAST(N'2020-11-19T09:08:26.6107275' AS DateTime2), CAST(N'2020-11-19T09:08:26.6107278' AS DateTime2), N'Toyota Venza', N'https://img.tinbanxe.vn/images/Toyota/anh-dai-dien-toyota-venza-2020.png', N'33,645  USD')
INSERT [dbo].[VehicleCrawlDatas] ([Id], [CreateAt], [UpdateAt], [Name], [Image], [Value]) VALUES (316, CAST(N'2020-11-19T09:08:26.6108465' AS DateTime2), CAST(N'2020-11-19T09:08:26.6108467' AS DateTime2), N'Toyota GR Supra', N'https://img.tinbanxe.vn/images/Toyota/toyota-gr-supra-2020.png', N'3,840,000,000  VND')
INSERT [dbo].[VehicleCrawlDatas] ([Id], [CreateAt], [UpdateAt], [Name], [Image], [Value]) VALUES (317, CAST(N'2020-11-19T09:08:26.6109643' AS DateTime2), CAST(N'2020-11-19T09:08:26.6109644' AS DateTime2), N'Toyota Harrier', N'https://img.tinbanxe.vn/images/Toyota/Toyota-Harrier/ANHDAIDIENtoyota-harrier-dark-blue-mica-metallic.png', N'900,000,000  VND')
INSERT [dbo].[VehicleCrawlDatas] ([Id], [CreateAt], [UpdateAt], [Name], [Image], [Value]) VALUES (318, CAST(N'2020-11-19T09:08:26.6110937' AS DateTime2), CAST(N'2020-11-19T09:08:26.6110940' AS DateTime2), N'Toyota C-HR', N'https://img.tinbanxe.vn/images/Toyota/toyota-c-hr-2020.png', N'980,000,000  VND')
INSERT [dbo].[VehicleCrawlDatas] ([Id], [CreateAt], [UpdateAt], [Name], [Image], [Value]) VALUES (319, CAST(N'2020-11-19T09:08:26.6112107' AS DateTime2), CAST(N'2020-11-19T09:08:26.6112109' AS DateTime2), N'Toyota Granvia', N'https://img.tinbanxe.vn/images/Toyota/toyota-granvia-2020.png', N'3,072,000,000  VND')
INSERT [dbo].[VehicleCrawlDatas] ([Id], [CreateAt], [UpdateAt], [Name], [Image], [Value]) VALUES (320, CAST(N'2020-11-19T09:08:26.6113404' AS DateTime2), CAST(N'2020-11-19T09:08:26.6113407' AS DateTime2), N'Toyota Supra', N'https://img.tinbanxe.vn/images/Toyota/toyota-supra-2020.png', N'3,500,000,000  VND')
INSERT [dbo].[VehicleCrawlDatas] ([Id], [CreateAt], [UpdateAt], [Name], [Image], [Value]) VALUES (321, CAST(N'2020-11-19T09:08:21.7721742' AS DateTime2), CAST(N'2020-11-19T09:08:21.7721746' AS DateTime2), N'Honda Insight', N'https://img.tinbanxe.vn/images/Honda/honda-insight/khac/Honda%20Insight(1).png', NULL)
INSERT [dbo].[VehicleCrawlDatas] ([Id], [CreateAt], [UpdateAt], [Name], [Image], [Value]) VALUES (322, CAST(N'2020-11-19T09:08:26.6114611' AS DateTime2), CAST(N'2020-11-19T09:08:26.6114615' AS DateTime2), N'Toyota Rav4', N'https://img.tinbanxe.vn/images/Toyota/toyota-rav4-2020.png', N'2,600,000,000  VND')
INSERT [dbo].[VehicleCrawlDatas] ([Id], [CreateAt], [UpdateAt], [Name], [Image], [Value]) VALUES (323, CAST(N'2020-11-19T09:08:26.6116979' AS DateTime2), CAST(N'2020-11-19T09:08:26.6116982' AS DateTime2), N'Toyota Tacoma', N'https://img.tinbanxe.vn/images/Toyota/toyota-tacoma-2020.png', N'980,000,000  VND')
INSERT [dbo].[VehicleCrawlDatas] ([Id], [CreateAt], [UpdateAt], [Name], [Image], [Value]) VALUES (324, CAST(N'2020-11-19T09:08:26.6118193' AS DateTime2), CAST(N'2020-11-19T09:08:26.6118196' AS DateTime2), N'Toyota Avalon', N'https://img.tinbanxe.vn/images/Toyota/toyota-avalon-20.png', N'2,900,000,000  VND')
INSERT [dbo].[VehicleCrawlDatas] ([Id], [CreateAt], [UpdateAt], [Name], [Image], [Value]) VALUES (325, CAST(N'2020-11-19T09:08:26.6122258' AS DateTime2), CAST(N'2020-11-19T09:08:26.6122263' AS DateTime2), N'Toyota Corolla Cross', N'https://img.tinbanxe.vn/images/Toyota/Toyota-Corolla-Cross/khac/ANHDAIDIEN-toyota-corolla-cross-attitude-black-mica.png', N'720,000,000  VND')
INSERT [dbo].[VehicleCrawlDatas] ([Id], [CreateAt], [UpdateAt], [Name], [Image], [Value]) VALUES (326, CAST(N'2020-11-19T09:08:26.6123832' AS DateTime2), CAST(N'2020-11-19T09:08:26.6123835' AS DateTime2), N'Toyota Previa', N'https://img.tinbanxe.vn/images/Toyota/toyota-previa-2020.png', N'1,100,000,000  VND')
INSERT [dbo].[VehicleCrawlDatas] ([Id], [CreateAt], [UpdateAt], [Name], [Image], [Value]) VALUES (327, CAST(N'2020-11-19T09:08:28.4877656' AS DateTime2), CAST(N'2020-11-19T09:08:28.4877671' AS DateTime2), N'Hyundai Solati', N'https://img.tinbanxe.vn/images/HYUNDAI/Hyundai-solati/61c625cf-b398-67d4-9166-1b877f3032aa-1531288751-.png', N'980,000,000  VND')
INSERT [dbo].[VehicleCrawlDatas] ([Id], [CreateAt], [UpdateAt], [Name], [Image], [Value]) VALUES (328, CAST(N'2020-11-19T09:08:28.4881005' AS DateTime2), CAST(N'2020-11-19T09:08:28.4881015' AS DateTime2), N'Hyundai i10 Hatchback', N'https://img.tinbanxe.vn/images/HYUNDAI/hyundai-i10-hatchback/hyundai-i10-hatchback.png', N'380,000,000  VND')
INSERT [dbo].[VehicleCrawlDatas] ([Id], [CreateAt], [UpdateAt], [Name], [Image], [Value]) VALUES (329, CAST(N'2020-11-19T09:08:28.4883548' AS DateTime2), CAST(N'2020-11-19T09:08:28.4883558' AS DateTime2), N'Hyundai Venue', N'https://img.tinbanxe.vn/images/HYUNDAI/HYUNDAI-VENUE/hyundai-venue-ANHDAIDIEN6mt-(1).png', N'23,190  USD')
INSERT [dbo].[VehicleCrawlDatas] ([Id], [CreateAt], [UpdateAt], [Name], [Image], [Value]) VALUES (330, CAST(N'2020-11-19T09:08:28.4886179' AS DateTime2), CAST(N'2020-11-19T09:08:28.4886185' AS DateTime2), N'Hyundai Sonata', N'https://img.tinbanxe.vn/images/HYUNDAI/HYUNDAI-SONATA/hyundai-sonata-2020-ANHDAIDIEN.png', N'999,000,000  VND')
INSERT [dbo].[VehicleCrawlDatas] ([Id], [CreateAt], [UpdateAt], [Name], [Image], [Value]) VALUES (331, CAST(N'2020-11-19T09:08:28.4888116' AS DateTime2), CAST(N'2020-11-19T09:08:28.4888120' AS DateTime2), N'Hyundai Santro', N'https://img.tinbanxe.vn/images/HYUNDAI/HYUNDAI_Santro/hyundai-new-santro-anhdaidien.png', N'5,300  USD')
INSERT [dbo].[VehicleCrawlDatas] ([Id], [CreateAt], [UpdateAt], [Name], [Image], [Value]) VALUES (332, CAST(N'2020-11-19T09:08:26.6115785' AS DateTime2), CAST(N'2020-11-19T09:08:26.6115788' AS DateTime2), N'Toyota Kluger', N'https://img.tinbanxe.vn/images/Toyota/Toyota-Kluger-2020.png', N'69,246  USD')
INSERT [dbo].[VehicleCrawlDatas] ([Id], [CreateAt], [UpdateAt], [Name], [Image], [Value]) VALUES (333, CAST(N'2020-11-19T09:08:29.5409845' AS DateTime2), CAST(N'2020-11-19T09:08:29.5409856' AS DateTime2), N'Mitsubishi Outlander', N'https://img.tinbanxe.vn/images/Mitsubishi/mitsubishi-outlander.png', N'807,000,000  VND')
INSERT [dbo].[VehicleCrawlDatas] ([Id], [CreateAt], [UpdateAt], [Name], [Image], [Value]) VALUES (334, CAST(N'2020-11-19T09:08:21.7720401' AS DateTime2), CAST(N'2020-11-19T09:08:21.7720404' AS DateTime2), N'Honda Mobilio', N'https://img.tinbanxe.vn/images/Honda/honda-mobolio/khac/Honda%20Mobilio.png', N'620,000,000  VND')
INSERT [dbo].[VehicleCrawlDatas] ([Id], [CreateAt], [UpdateAt], [Name], [Image], [Value]) VALUES (335, CAST(N'2020-11-19T09:08:21.7716400' AS DateTime2), CAST(N'2020-11-19T09:08:21.7716404' AS DateTime2), N'Honda Pilot', N'https://img.tinbanxe.vn/images/Honda/Honda-pilot/anh-dai-dien-honda-pilot-2020.png', N'43,500  USD')
INSERT [dbo].[VehicleCrawlDatas] ([Id], [CreateAt], [UpdateAt], [Name], [Image], [Value]) VALUES (336, CAST(N'2020-11-19T09:08:15.3398959' AS DateTime2), CAST(N'2020-11-19T09:08:15.3398962' AS DateTime2), N'Audi Q5', N'https://img.tinbanxe.vn/images/Audi/audi-Q5/mau-xe-audi-q5-anhdaidien.png', N'2,370,000,000  VND')
INSERT [dbo].[VehicleCrawlDatas] ([Id], [CreateAt], [UpdateAt], [Name], [Image], [Value]) VALUES (337, CAST(N'2020-11-19T09:08:15.3400227' AS DateTime2), CAST(N'2020-11-19T09:08:15.3400230' AS DateTime2), N'Audi Q8', N'https://img.tinbanxe.vn/images/Audi/audi-q8/mau-xe-audi-q8-carrara-white-anhdaidien.png', N'4,505,000,000  VND')
INSERT [dbo].[VehicleCrawlDatas] ([Id], [CreateAt], [UpdateAt], [Name], [Image], [Value]) VALUES (338, CAST(N'2020-11-19T09:08:15.3401445' AS DateTime2), CAST(N'2020-11-19T09:08:15.3401447' AS DateTime2), N'Audi Q3', N'https://img.tinbanxe.vn/images/audi-q3/mau-xe-audi-q3-turbo-blue-hinhanhdaidien.png', N'1,760,000,000  VND')
INSERT [dbo].[VehicleCrawlDatas] ([Id], [CreateAt], [UpdateAt], [Name], [Image], [Value]) VALUES (339, CAST(N'2020-11-19T09:08:15.3402650' AS DateTime2), CAST(N'2020-11-19T09:08:15.3402652' AS DateTime2), N'Audi Q2', N'https://img.tinbanxe.vn/images/Audi/audi%20q2/ANHDAIDIENAudi-Q2_0.png', N'1,350,000,000  VND')
INSERT [dbo].[VehicleCrawlDatas] ([Id], [CreateAt], [UpdateAt], [Name], [Image], [Value]) VALUES (340, CAST(N'2020-11-19T09:08:16.3335630' AS DateTime2), CAST(N'2020-11-19T09:08:16.3335640' AS DateTime2), N'Vinfast President', N'https://img.tinbanxe.vn/images/Vinfast/vinfast%20president/ANHDAIDIEN2_o-removebg-preview.png', N'4,600,000,000  VND')
GO
INSERT [dbo].[VehicleCrawlDatas] ([Id], [CreateAt], [UpdateAt], [Name], [Image], [Value]) VALUES (341, CAST(N'2020-11-19T09:08:16.3337583' AS DateTime2), CAST(N'2020-11-19T09:08:16.3337585' AS DateTime2), N'Vinfast Lux A2.0', N'https://img.tinbanxe.vn/images/vinfast-dung/vinfast-LuxA2.0/mau-xe-vinfast-lux-a20-action-anhdaidien.png', N'1,419,000,000  VND')
INSERT [dbo].[VehicleCrawlDatas] ([Id], [CreateAt], [UpdateAt], [Name], [Image], [Value]) VALUES (342, CAST(N'2020-11-19T09:08:16.3338814' AS DateTime2), CAST(N'2020-11-19T09:08:16.3338817' AS DateTime2), N'Vinfast Lux sa2.0', N'https://img.tinbanxe.vn/images/vinfast-dung/Vinfast-SA-Lux2.0/mau-xe-vinfast-lux-sa20-brahminy-white-anhdaidien.png', N'1,929,000,000  VND')
INSERT [dbo].[VehicleCrawlDatas] ([Id], [CreateAt], [UpdateAt], [Name], [Image], [Value]) VALUES (343, CAST(N'2020-11-19T09:08:16.3340097' AS DateTime2), CAST(N'2020-11-19T09:08:16.3340099' AS DateTime2), N'Vinfast Fadil', N'https://img.tinbanxe.vn/images/Vinfast/Vinfast%20Fadil/mau-xe-vinfast-fadil-brahminy-white_ANHDAIDIENpng.png', N'499,000,000  VND')
INSERT [dbo].[VehicleCrawlDatas] ([Id], [CreateAt], [UpdateAt], [Name], [Image], [Value]) VALUES (344, CAST(N'2020-11-19T09:08:18.3855511' AS DateTime2), CAST(N'2020-11-19T09:08:18.3855525' AS DateTime2), N'BMW Z4', N'https://img.tinbanxe.vn/images/bmw/ADDAIDIENbmw-z4-2020.png', N'3,099,000,000  VND')
INSERT [dbo].[VehicleCrawlDatas] ([Id], [CreateAt], [UpdateAt], [Name], [Image], [Value]) VALUES (345, CAST(N'2020-11-19T09:08:18.3858569' AS DateTime2), CAST(N'2020-11-19T09:08:18.3858577' AS DateTime2), N'BMW 528i', N'https://img.tinbanxe.vn/images/bmw/bmw-528i/bmw-520i-2020-ANHDAIDIEN.png', N'2,998,000,000  VND')
INSERT [dbo].[VehicleCrawlDatas] ([Id], [CreateAt], [UpdateAt], [Name], [Image], [Value]) VALUES (346, CAST(N'2020-11-19T09:08:18.3860885' AS DateTime2), CAST(N'2020-11-19T09:08:18.3860890' AS DateTime2), N'BMW I8', N'https://img.tinbanxe.vn/images/bmw/bmw%20i8/bmw-i8-2020_anhdaidienpng.png', N'3,460,000,000  VND')
INSERT [dbo].[VehicleCrawlDatas] ([Id], [CreateAt], [UpdateAt], [Name], [Image], [Value]) VALUES (347, CAST(N'2020-11-19T09:08:18.3862778' AS DateTime2), CAST(N'2020-11-19T09:08:18.3862784' AS DateTime2), N'BMW X1', N'https://img.tinbanxe.vn/images/bmw/bmw%20x1/bmw-x2-anhdaidien.png', NULL)
INSERT [dbo].[VehicleCrawlDatas] ([Id], [CreateAt], [UpdateAt], [Name], [Image], [Value]) VALUES (348, CAST(N'2020-11-19T09:08:18.3865091' AS DateTime2), CAST(N'2020-11-19T09:08:18.3865096' AS DateTime2), N'BMW 320i', N'https://img.tinbanxe.vn/images/bmw/bmw%20320i/mau-xe-bmw-320i-snow-white-anhdaidien(1).png', N'1,988,000,000  VND')
INSERT [dbo].[VehicleCrawlDatas] ([Id], [CreateAt], [UpdateAt], [Name], [Image], [Value]) VALUES (349, CAST(N'2020-11-19T09:08:18.3867390' AS DateTime2), CAST(N'2020-11-19T09:08:18.3867395' AS DateTime2), N'BMW 750Li', N'https://img.tinbanxe.vn/images/bmw/bmw%20750li/bmw-750li-2020-anhdaidien.png', N'9,299,000,000  VND')
INSERT [dbo].[VehicleCrawlDatas] ([Id], [CreateAt], [UpdateAt], [Name], [Image], [Value]) VALUES (350, CAST(N'2020-11-19T09:08:18.3869973' AS DateTime2), CAST(N'2020-11-19T09:08:18.3869978' AS DateTime2), N'BMW 730Li', N'https://img.tinbanxe.vn/images/bmw/bmw%20730li/bmw-520i-2020-ANHDAIDIEN.png', N'4,099,000,000  VND')
INSERT [dbo].[VehicleCrawlDatas] ([Id], [CreateAt], [UpdateAt], [Name], [Image], [Value]) VALUES (351, CAST(N'2020-11-19T09:08:18.3872316' AS DateTime2), CAST(N'2020-11-19T09:08:18.3872322' AS DateTime2), N'BMW 520i', N'https://img.tinbanxe.vn/images/bmw/bmw-520i/bmw-520i-anhdaidien.png', N'2,389,000,000  VND')
INSERT [dbo].[VehicleCrawlDatas] ([Id], [CreateAt], [UpdateAt], [Name], [Image], [Value]) VALUES (352, CAST(N'2020-11-19T09:08:18.3874576' AS DateTime2), CAST(N'2020-11-19T09:08:18.3874581' AS DateTime2), N'BMW 530i', N'https://img.tinbanxe.vn/images/bmw/bmw-530i/bmw-530i-anhdaidien-alpinewhite.png', N'3,069,000,000  VND')
INSERT [dbo].[VehicleCrawlDatas] ([Id], [CreateAt], [UpdateAt], [Name], [Image], [Value]) VALUES (353, CAST(N'2020-11-19T09:08:18.3877056' AS DateTime2), CAST(N'2020-11-19T09:08:18.3877061' AS DateTime2), N'BMW X5', N'https://img.tinbanxe.vn/images/bmw-x5/2020-BMW-x5ANHDAIDIEN.png', N'4,199,000,000  VND')
INSERT [dbo].[VehicleCrawlDatas] ([Id], [CreateAt], [UpdateAt], [Name], [Image], [Value]) VALUES (354, CAST(N'2020-11-19T09:08:18.3879249' AS DateTime2), CAST(N'2020-11-19T09:08:18.3879257' AS DateTime2), N'BMW X6', N'https://img.tinbanxe.vn/images/bmw/bmw%20x6/2020_bmwx6-anhdaidien.png', N'3,969,000,000  VND')
INSERT [dbo].[VehicleCrawlDatas] ([Id], [CreateAt], [UpdateAt], [Name], [Image], [Value]) VALUES (355, CAST(N'2020-11-19T09:08:15.3397835' AS DateTime2), CAST(N'2020-11-19T09:08:15.3397837' AS DateTime2), N'Audi TT', N'https://img.tinbanxe.vn/images/Audi/audi-tt/audi-tt-anhdaidien.png', N'2,060,000,000  VND')
INSERT [dbo].[VehicleCrawlDatas] ([Id], [CreateAt], [UpdateAt], [Name], [Image], [Value]) VALUES (356, CAST(N'2020-11-19T09:08:18.3882107' AS DateTime2), CAST(N'2020-11-19T09:08:18.3882119' AS DateTime2), N'BMW M2', N'https://img.tinbanxe.vn/images/bmw/bmw-m2/bmw-m2-anhdaidien.png', N'2,999,000,000  VND')
INSERT [dbo].[VehicleCrawlDatas] ([Id], [CreateAt], [UpdateAt], [Name], [Image], [Value]) VALUES (357, CAST(N'2020-11-19T09:08:15.3396643' AS DateTime2), CAST(N'2020-11-19T09:08:15.3396646' AS DateTime2), N'Audi A5 Cabriolet', N'https://img.tinbanxe.vn/images/Audi/audi-a5-cabriolet.jpg', N'2,510,000,000  VND')
INSERT [dbo].[VehicleCrawlDatas] ([Id], [CreateAt], [UpdateAt], [Name], [Image], [Value]) VALUES (358, CAST(N'2020-11-19T09:08:15.3394267' AS DateTime2), CAST(N'2020-11-19T09:08:15.3394270' AS DateTime2), N'Audi R8', N'https://img.tinbanxe.vn/images/Audi/audi%20r8/chrome-image-406135.png', N'4,500,000,000  VND')
INSERT [dbo].[VehicleCrawlDatas] ([Id], [CreateAt], [UpdateAt], [Name], [Image], [Value]) VALUES (359, CAST(N'2020-11-19T09:08:15.3363113' AS DateTime2), CAST(N'2020-11-19T09:08:15.3363123' AS DateTime2), N'Audi Q7', N'https://img.tinbanxe.vn/images/Audi/audi-q7/ANHDAIDIENaudi-q7-navarra-blue.png', N'3,420,000,000  VND')
INSERT [dbo].[VehicleCrawlDatas] ([Id], [CreateAt], [UpdateAt], [Name], [Image], [Value]) VALUES (360, CAST(N'2020-11-19T09:08:15.3371134' AS DateTime2), CAST(N'2020-11-19T09:08:15.3371141' AS DateTime2), N'Audi A6', N'https://img.tinbanxe.vn/images/Audi/audi-a6/ANHDAIDIENaudi-a6-avalon-green.png', N'2,500,000,000  VND')
INSERT [dbo].[VehicleCrawlDatas] ([Id], [CreateAt], [UpdateAt], [Name], [Image], [Value]) VALUES (361, CAST(N'2020-11-19T09:08:15.3372949' AS DateTime2), CAST(N'2020-11-19T09:08:15.3372953' AS DateTime2), N'Audi A7', N'https://img.tinbanxe.vn/images/Audi/audi-a7/ANHDAIDIENaudi-a7-customized-audi-exclusive-bodywork.png', N'2,500,000,000  VND')
INSERT [dbo].[VehicleCrawlDatas] ([Id], [CreateAt], [UpdateAt], [Name], [Image], [Value]) VALUES (362, CAST(N'2020-11-19T09:08:15.3374278' AS DateTime2), CAST(N'2020-11-19T09:08:15.3374282' AS DateTime2), N'Audi A5 Coupe', N'https://img.tinbanxe.vn/images/Audi/audi-a5-coupe/dai-dien-audi-a5-coupe.png', N'2,500,000,000  VND')
INSERT [dbo].[VehicleCrawlDatas] ([Id], [CreateAt], [UpdateAt], [Name], [Image], [Value]) VALUES (363, CAST(N'2020-11-19T09:08:15.3375446' AS DateTime2), CAST(N'2020-11-19T09:08:15.3375448' AS DateTime2), N'Audi A1', N'https://img.tinbanxe.vn/images/Audi/audi-a1/audi-a1-2020-ANHDAIDIEN.png', N'23,000  USD')
INSERT [dbo].[VehicleCrawlDatas] ([Id], [CreateAt], [UpdateAt], [Name], [Image], [Value]) VALUES (364, CAST(N'2020-11-19T09:08:15.3376665' AS DateTime2), CAST(N'2020-11-19T09:08:15.3376667' AS DateTime2), N'Audi S4', N'https://img.tinbanxe.vn/images/Audi/audi%20s4/khac/Untitled-1.png', N'1,166,000,000  VND')
INSERT [dbo].[VehicleCrawlDatas] ([Id], [CreateAt], [UpdateAt], [Name], [Image], [Value]) VALUES (365, CAST(N'2020-11-19T09:08:15.3377876' AS DateTime2), CAST(N'2020-11-19T09:08:15.3377878' AS DateTime2), N'Audi S6', N'https://img.tinbanxe.vn/images/Audi/audi%20s6/khac/Untitled-2.png', N'1,610,000,000  VND')
INSERT [dbo].[VehicleCrawlDatas] ([Id], [CreateAt], [UpdateAt], [Name], [Image], [Value]) VALUES (366, CAST(N'2020-11-19T09:08:15.3379192' AS DateTime2), CAST(N'2020-11-19T09:08:15.3379194' AS DateTime2), N'Audi RS4', N'https://img.tinbanxe.vn/images/Audi/audi%20rs4/khac/Audi-RS4.png', N'2,000,000,000  VND')
INSERT [dbo].[VehicleCrawlDatas] ([Id], [CreateAt], [UpdateAt], [Name], [Image], [Value]) VALUES (367, CAST(N'2020-11-19T09:08:15.3380377' AS DateTime2), CAST(N'2020-11-19T09:08:15.3380379' AS DateTime2), N'Audi Q4', N'https://img.tinbanxe.vn/images/Audi/audi%20q4/audi-q4-phien-ban-e-tron.png', N'1,650,000,000  VND')
INSERT [dbo].[VehicleCrawlDatas] ([Id], [CreateAt], [UpdateAt], [Name], [Image], [Value]) VALUES (368, CAST(N'2020-11-19T09:08:15.3381547' AS DateTime2), CAST(N'2020-11-19T09:08:15.3381550' AS DateTime2), N'Audi S8', N'https://img.tinbanxe.vn/images/Audi/audi%20s8/khac/Audi-S8.png', N'2,700,000,000  VND')
INSERT [dbo].[VehicleCrawlDatas] ([Id], [CreateAt], [UpdateAt], [Name], [Image], [Value]) VALUES (369, CAST(N'2020-11-19T09:08:15.3382954' AS DateTime2), CAST(N'2020-11-19T09:08:15.3382957' AS DateTime2), N'Audi E-Tron', N'https://img.tinbanxe.vn/images/Audi/audi%20etron/khac/mau-xe-audi-e-tron-antigua-blue-metallic-anhdaidien.png', N'1,700,000,000  VND')
INSERT [dbo].[VehicleCrawlDatas] ([Id], [CreateAt], [UpdateAt], [Name], [Image], [Value]) VALUES (370, CAST(N'2020-11-19T09:08:15.3384243' AS DateTime2), CAST(N'2020-11-19T09:08:15.3384246' AS DateTime2), N'Audi S7', N'https://img.tinbanxe.vn/images/Audi/audi%20s7/khac/audi-s7-anhdaidien.png', NULL)
INSERT [dbo].[VehicleCrawlDatas] ([Id], [CreateAt], [UpdateAt], [Name], [Image], [Value]) VALUES (371, CAST(N'2020-11-19T09:08:15.3385764' AS DateTime2), CAST(N'2020-11-19T09:08:15.3385768' AS DateTime2), N'Audi RS6', N'https://img.tinbanxe.vn/images/Audi-RS6-anhdaidien.png', N'2,800,000,000  VND')
INSERT [dbo].[VehicleCrawlDatas] ([Id], [CreateAt], [UpdateAt], [Name], [Image], [Value]) VALUES (372, CAST(N'2020-11-19T09:08:15.3386889' AS DateTime2), CAST(N'2020-11-19T09:08:15.3386892' AS DateTime2), N'Audi A8', N'https://img.tinbanxe.vn/images/Audi/audi-a8/mau-xe-audi-a8-anhdaidien-black.png', N'5,600,000,000  VND')
INSERT [dbo].[VehicleCrawlDatas] ([Id], [CreateAt], [UpdateAt], [Name], [Image], [Value]) VALUES (373, CAST(N'2020-11-19T09:08:15.3388083' AS DateTime2), CAST(N'2020-11-19T09:08:15.3388085' AS DateTime2), N'Audi RS7', N'https://img.tinbanxe.vn/images/Audi/audi-rs7/audi-rs7-anhdaidien-png.png', N'3,000,000,000  VND')
INSERT [dbo].[VehicleCrawlDatas] ([Id], [CreateAt], [UpdateAt], [Name], [Image], [Value]) VALUES (374, CAST(N'2020-11-19T09:08:15.3389373' AS DateTime2), CAST(N'2020-11-19T09:08:15.3389377' AS DateTime2), N'Audi A9', N'https://img.tinbanxe.vn/images/Audi/audi-a9/2021-Audi-A9-E-Tron-Rumors-Concept.png', N'2,700,000,000  VND')
INSERT [dbo].[VehicleCrawlDatas] ([Id], [CreateAt], [UpdateAt], [Name], [Image], [Value]) VALUES (375, CAST(N'2020-11-19T09:08:15.3390582' AS DateTime2), CAST(N'2020-11-19T09:08:15.3390586' AS DateTime2), N'Audi A3', N'https://img.tinbanxe.vn/images/Audi/audi%20a3/khac/mau-xe-audi-a3-anhdaidien.png', N'1,520,000,000  VND')
INSERT [dbo].[VehicleCrawlDatas] ([Id], [CreateAt], [UpdateAt], [Name], [Image], [Value]) VALUES (376, CAST(N'2020-11-19T09:08:15.3391752' AS DateTime2), CAST(N'2020-11-19T09:08:15.3391754' AS DateTime2), N'Audi A2', N'https://img.tinbanxe.vn/images/Audi/audi-A2/audi-a2-2020-redesign-1200-x-800-removebg-preview.png', N'1,500,000,000  VND')
INSERT [dbo].[VehicleCrawlDatas] ([Id], [CreateAt], [UpdateAt], [Name], [Image], [Value]) VALUES (377, CAST(N'2020-11-19T09:08:15.3392988' AS DateTime2), CAST(N'2020-11-19T09:08:15.3392989' AS DateTime2), N'Audi RS5', N'https://img.tinbanxe.vn/images/Audi/audi%20rs5/cc_2019AUC290012_01_1280_2Y2Y.png', N'2,000,000,000  VND')
INSERT [dbo].[VehicleCrawlDatas] ([Id], [CreateAt], [UpdateAt], [Name], [Image], [Value]) VALUES (378, CAST(N'2020-11-19T09:08:15.3395476' AS DateTime2), CAST(N'2020-11-19T09:08:15.3395478' AS DateTime2), N'Audi A5 Sportback', N'https://img.tinbanxe.vn/images/Audi/AUDI-A5/AUDI-A5-ANHDAIDIEN.PNG', N'2,510,000,000  VND')
INSERT [dbo].[VehicleCrawlDatas] ([Id], [CreateAt], [UpdateAt], [Name], [Image], [Value]) VALUES (379, CAST(N'2020-11-19T09:08:18.3885265' AS DateTime2), CAST(N'2020-11-19T09:08:18.3885274' AS DateTime2), N'BMW 428i Convertible', N'https://img.tinbanxe.vn/images/bmw/bmw-428i/bmw-428i-phien-ban-convertible-anhdaidien.png', N'2,898,000,000  VND')
INSERT [dbo].[VehicleCrawlDatas] ([Id], [CreateAt], [UpdateAt], [Name], [Image], [Value]) VALUES (380, CAST(N'2020-11-19T09:08:18.3887793' AS DateTime2), CAST(N'2020-11-19T09:08:18.3887798' AS DateTime2), N'BMW 420i Convertible', N'https://img.tinbanxe.vn/images/bmw/bmw-420i/mau-xe-bmw-420i-convertible-xanh-troi-anhdaidien.png', N'2,898,000,000  VND')
INSERT [dbo].[VehicleCrawlDatas] ([Id], [CreateAt], [UpdateAt], [Name], [Image], [Value]) VALUES (381, CAST(N'2020-11-19T09:08:18.3890312' AS DateTime2), CAST(N'2020-11-19T09:08:18.3890317' AS DateTime2), N'BMW 430i Gran Coupe', N'https://img.tinbanxe.vn/images/bmw/bmw-430i/bmw-430i-hinhdaidienpng.png', N'2,198,000,000  VND')
INSERT [dbo].[VehicleCrawlDatas] ([Id], [CreateAt], [UpdateAt], [Name], [Image], [Value]) VALUES (382, CAST(N'2020-11-19T09:08:20.1888706' AS DateTime2), CAST(N'2020-11-19T09:08:20.1888708' AS DateTime2), N'Ford Focus', N'https://img.tinbanxe.vn/images/FORD/FORD-FOCUS/ford-focus-anhdaidien.png', N'770,000,000  VND')
INSERT [dbo].[VehicleCrawlDatas] ([Id], [CreateAt], [UpdateAt], [Name], [Image], [Value]) VALUES (383, CAST(N'2020-11-19T09:08:20.1890080' AS DateTime2), CAST(N'2020-11-19T09:08:20.1890083' AS DateTime2), N'Ford Transit', N'https://img.tinbanxe.vn/images/FORD/Ford%20Transit/ford-transitANHDAIDIEN.png', N'1,355,000,000  VND')
INSERT [dbo].[VehicleCrawlDatas] ([Id], [CreateAt], [UpdateAt], [Name], [Image], [Value]) VALUES (384, CAST(N'2020-11-19T09:08:20.1891239' AS DateTime2), CAST(N'2020-11-19T09:08:20.1891241' AS DateTime2), N'Ford Mustang', N'https://img.tinbanxe.vn/images/FORD/Ford%20Mustang/2020-Ford-Mustang-ANHDAIDIEN4.png', N'4,400,000,000  VND')
INSERT [dbo].[VehicleCrawlDatas] ([Id], [CreateAt], [UpdateAt], [Name], [Image], [Value]) VALUES (385, CAST(N'2020-11-19T09:08:20.1892414' AS DateTime2), CAST(N'2020-11-19T09:08:20.1892416' AS DateTime2), N'Ford Fusion', N'https://img.tinbanxe.vn/images/FORD/Ford%20Fusion/ford-fusion-2020-ANHDAIDIEN.png', N'41,000  USD')
INSERT [dbo].[VehicleCrawlDatas] ([Id], [CreateAt], [UpdateAt], [Name], [Image], [Value]) VALUES (386, CAST(N'2020-11-19T09:08:20.1893611' AS DateTime2), CAST(N'2020-11-19T09:08:20.1893614' AS DateTime2), N'Ford Expedition', N'https://img.tinbanxe.vn/images/FORD/Ford%20Expedition/Ford-Expedition-ANHDAIDIEN.png', N'2,180,000,000  VND')
INSERT [dbo].[VehicleCrawlDatas] ([Id], [CreateAt], [UpdateAt], [Name], [Image], [Value]) VALUES (387, CAST(N'2020-11-19T09:08:20.1894879' AS DateTime2), CAST(N'2020-11-19T09:08:20.1894882' AS DateTime2), N'Ford Taurus', N'https://img.tinbanxe.vn/images/FORD/Ford%20Taurus/ANHDAIDIENford-taurus-2020.png', N'40,600  USD')
INSERT [dbo].[VehicleCrawlDatas] ([Id], [CreateAt], [UpdateAt], [Name], [Image], [Value]) VALUES (388, CAST(N'2020-11-19T09:08:20.1896084' AS DateTime2), CAST(N'2020-11-19T09:08:20.1896086' AS DateTime2), N'Ford Edge', N'https://img.tinbanxe.vn/images/FORD/Ford-Edge/ANHDAIDIENford-edge-34-front-glamour.png', N'1,000,000,000  VND')
INSERT [dbo].[VehicleCrawlDatas] ([Id], [CreateAt], [UpdateAt], [Name], [Image], [Value]) VALUES (389, CAST(N'2020-11-19T09:08:20.1897236' AS DateTime2), CAST(N'2020-11-19T09:08:20.1897238' AS DateTime2), N'Ford Fiesta', N'https://img.tinbanxe.vn/images/FORD/Ford%20Fiesta/ANHDAIDIEN-FORD-FIESTA.png', N'564,000,000  VND')
INSERT [dbo].[VehicleCrawlDatas] ([Id], [CreateAt], [UpdateAt], [Name], [Image], [Value]) VALUES (390, CAST(N'2020-11-19T09:08:20.1898418' AS DateTime2), CAST(N'2020-11-19T09:08:20.1898421' AS DateTime2), N'Ford Everest', N'https://img.tinbanxe.vn/images/FORD/Ford%20Everest/Ford-Everest-ANHDAIDIEN.png', N'1,052,000,000  VND')
INSERT [dbo].[VehicleCrawlDatas] ([Id], [CreateAt], [UpdateAt], [Name], [Image], [Value]) VALUES (391, CAST(N'2020-11-19T09:08:20.1901288' AS DateTime2), CAST(N'2020-11-19T09:08:20.1901296' AS DateTime2), N'Ford Ecosport', N'https://img.tinbanxe.vn/images/FORD/Ford%20Ecosport/355-3552372_ford-ecosport-tANHDAIDIEN.png', N'689,000,000  VND')
INSERT [dbo].[VehicleCrawlDatas] ([Id], [CreateAt], [UpdateAt], [Name], [Image], [Value]) VALUES (392, CAST(N'2020-11-19T09:08:20.1904196' AS DateTime2), CAST(N'2020-11-19T09:08:20.1904200' AS DateTime2), N'Ford Tourneo', N'https://img.tinbanxe.vn/images/FORD/Ford%20Tourneo/mau-xe-ford-tourneo-ANHDAIDIENk.png', N'999,000,000  VND')
INSERT [dbo].[VehicleCrawlDatas] ([Id], [CreateAt], [UpdateAt], [Name], [Image], [Value]) VALUES (393, CAST(N'2020-11-19T09:08:21.7696227' AS DateTime2), CAST(N'2020-11-19T09:08:21.7696242' AS DateTime2), N'Honda CR – V', N'https://img.tinbanxe.vn/images/Honda/honda-crv/honda-cr-v-phien-ban-l-ANHDAIDIEN.png', N'983,000,000  VND')
INSERT [dbo].[VehicleCrawlDatas] ([Id], [CreateAt], [UpdateAt], [Name], [Image], [Value]) VALUES (394, CAST(N'2020-11-19T09:08:21.7699740' AS DateTime2), CAST(N'2020-11-19T09:08:21.7699747' AS DateTime2), N'Honda City', N'https://img.tinbanxe.vn/images/Honda%20City.png', N'559,000,000  VND')
INSERT [dbo].[VehicleCrawlDatas] ([Id], [CreateAt], [UpdateAt], [Name], [Image], [Value]) VALUES (395, CAST(N'2020-11-19T09:08:21.7702985' AS DateTime2), CAST(N'2020-11-19T09:08:21.7702990' AS DateTime2), N'Honda Brio', N'https://img.tinbanxe.vn/images/Honda/Honda-brio/khac/Honda%20Brio(1).png', N'418,000,000  VND')
INSERT [dbo].[VehicleCrawlDatas] ([Id], [CreateAt], [UpdateAt], [Name], [Image], [Value]) VALUES (396, CAST(N'2020-11-19T09:08:21.7705850' AS DateTime2), CAST(N'2020-11-19T09:08:21.7705855' AS DateTime2), N'Honda Civic', N'https://img.tinbanxe.vn/images/Honda/Honda%20Civic/honda-civic.png', N'929,000,000  VND')
INSERT [dbo].[VehicleCrawlDatas] ([Id], [CreateAt], [UpdateAt], [Name], [Image], [Value]) VALUES (397, CAST(N'2020-11-19T09:08:21.7707867' AS DateTime2), CAST(N'2020-11-19T09:08:21.7707869' AS DateTime2), N'Honda Accord', N'https://img.tinbanxe.vn/images/Honda/Honda-Accord/kh%C3%A1c/Honda%20Accord.png', N'1,319,000,000  VND')
INSERT [dbo].[VehicleCrawlDatas] ([Id], [CreateAt], [UpdateAt], [Name], [Image], [Value]) VALUES (398, CAST(N'2020-11-19T09:08:21.7709314' AS DateTime2), CAST(N'2020-11-19T09:08:21.7709317' AS DateTime2), N'Honda Legend', N'https://img.tinbanxe.vn/images/Honda/Honda-Legend/khac/Honda%20Legend.png', N'1,470,000,000  VND')
INSERT [dbo].[VehicleCrawlDatas] ([Id], [CreateAt], [UpdateAt], [Name], [Image], [Value]) VALUES (399, CAST(N'2020-11-19T09:08:21.7711521' AS DateTime2), CAST(N'2020-11-19T09:08:21.7711529' AS DateTime2), N'Honda Clarity', N'https://img.tinbanxe.vn/images/Honda/Honda%20Clarity/khac/Honda%20Clarity%20Hybrid.png', N'1,320,000,000  VND')
INSERT [dbo].[VehicleCrawlDatas] ([Id], [CreateAt], [UpdateAt], [Name], [Image], [Value]) VALUES (400, CAST(N'2020-11-19T09:08:21.7714297' AS DateTime2), CAST(N'2020-11-19T09:08:21.7714304' AS DateTime2), N'Honda Ridgeline', N'https://img.tinbanxe.vn/images/Honda/honda%20ridgeline/khac/Honda%20Ridgeline%20Sport.png', N'1,450,000,000  VND')
INSERT [dbo].[VehicleCrawlDatas] ([Id], [CreateAt], [UpdateAt], [Name], [Image], [Value]) VALUES (401, CAST(N'2020-11-19T09:08:20.1887358' AS DateTime2), CAST(N'2020-11-19T09:08:20.1887361' AS DateTime2), N'Ford Ranger Raptor', N'https://img.tinbanxe.vn/images/FORD/Ford%20Ranger%20Raptor/Ford-Ranger-Raptor-anhdaidien.png', N'1,198,000,000  VND')
INSERT [dbo].[VehicleCrawlDatas] ([Id], [CreateAt], [UpdateAt], [Name], [Image], [Value]) VALUES (402, CAST(N'2020-11-19T09:08:20.1886166' AS DateTime2), CAST(N'2020-11-19T09:08:20.1886168' AS DateTime2), N'Ford F150', N'https://img.tinbanxe.vn/images/FORD/Ford%20F150/FOR_F150-ANHDAIDIENpng.png', NULL)
INSERT [dbo].[VehicleCrawlDatas] ([Id], [CreateAt], [UpdateAt], [Name], [Image], [Value]) VALUES (403, CAST(N'2020-11-19T09:08:20.1885119' AS DateTime2), CAST(N'2020-11-19T09:08:20.1885121' AS DateTime2), N'Ford Escape', N'https://img.tinbanxe.vn/images/FORD/Ford%20Escape/ford-escape-ANHDAIDIEN.png', N'24,885  USD')
INSERT [dbo].[VehicleCrawlDatas] ([Id], [CreateAt], [UpdateAt], [Name], [Image], [Value]) VALUES (404, CAST(N'2020-11-19T09:08:20.1883905' AS DateTime2), CAST(N'2020-11-19T09:08:20.1883908' AS DateTime2), N'Ford Explorer', N'https://img.tinbanxe.vn/images/FORD/Ford-Explorer/Ford-Explorer-ANHDAIDIEN.png', N'1,999,000,000  VND')
INSERT [dbo].[VehicleCrawlDatas] ([Id], [CreateAt], [UpdateAt], [Name], [Image], [Value]) VALUES (405, CAST(N'2020-11-19T09:08:18.3892773' AS DateTime2), CAST(N'2020-11-19T09:08:18.3892778' AS DateTime2), N'BMW 420i Coupe', N'https://img.tinbanxe.vn/images/bmw/bmw-420i-couple/mau-xe-bmw-420i-red-hinhanhdaidien.png', N'1,998,000,000  VND')
INSERT [dbo].[VehicleCrawlDatas] ([Id], [CreateAt], [UpdateAt], [Name], [Image], [Value]) VALUES (406, CAST(N'2020-11-19T09:08:18.3894922' AS DateTime2), CAST(N'2020-11-19T09:08:18.3894926' AS DateTime2), N'BMW 118i', N'https://img.tinbanxe.vn/images/bmw/bmw-118i/ngoai-that-bmw-118i-anhdaidien-11768.png', N'1,439,000,000  VND')
INSERT [dbo].[VehicleCrawlDatas] ([Id], [CreateAt], [UpdateAt], [Name], [Image], [Value]) VALUES (407, CAST(N'2020-11-19T09:08:18.3897056' AS DateTime2), CAST(N'2020-11-19T09:08:18.3897060' AS DateTime2), N'BMW X2', N'https://img.tinbanxe.vn/images/bmw/bmw-x2/bmw-x2-2020-anhdaidien.png', N'2,004,000,000  VND')
INSERT [dbo].[VehicleCrawlDatas] ([Id], [CreateAt], [UpdateAt], [Name], [Image], [Value]) VALUES (408, CAST(N'2020-11-19T09:08:18.3899324' AS DateTime2), CAST(N'2020-11-19T09:08:18.3899328' AS DateTime2), N'BMW 218i active tourer', N'https://img.tinbanxe.vn/images/bmw/bmw-218i/bmw-218-active/BMW-2-Series_Active_Tourer--anhdaidienpreview.png', N'1,299,000,000  VND')
INSERT [dbo].[VehicleCrawlDatas] ([Id], [CreateAt], [UpdateAt], [Name], [Image], [Value]) VALUES (409, CAST(N'2020-11-19T09:08:18.3901608' AS DateTime2), CAST(N'2020-11-19T09:08:18.3901611' AS DateTime2), N'BMW X4', N'https://img.tinbanxe.vn/images/bmw/bmw-x4-2020-anhdaidien.png', NULL)
INSERT [dbo].[VehicleCrawlDatas] ([Id], [CreateAt], [UpdateAt], [Name], [Image], [Value]) VALUES (410, CAST(N'2020-11-19T09:08:18.3904336' AS DateTime2), CAST(N'2020-11-19T09:08:18.3904342' AS DateTime2), N'BMW 328i', N'https://img.tinbanxe.vn/images/bmw/bmw-328i/bmw-1-series-anhdaidien.png', NULL)
INSERT [dbo].[VehicleCrawlDatas] ([Id], [CreateAt], [UpdateAt], [Name], [Image], [Value]) VALUES (411, CAST(N'2020-11-19T09:08:18.3906510' AS DateTime2), CAST(N'2020-11-19T09:08:18.3906514' AS DateTime2), N'BMW X3', N'https://img.tinbanxe.vn/images/bmw/bmw-x3/mau-xe-bmw-x3-alpine-white_-anhdaidienpng.png', N'2,499,000,000  VND')
INSERT [dbo].[VehicleCrawlDatas] ([Id], [CreateAt], [UpdateAt], [Name], [Image], [Value]) VALUES (412, CAST(N'2020-11-19T09:08:18.3908738' AS DateTime2), CAST(N'2020-11-19T09:08:18.3908743' AS DateTime2), N'BMW 740Li', N'https://img.tinbanxe.vn/images/bmw/bmw-740Li/bmw-740li-sedan-2019-hinhanhdaidien-1.png', N'5,359,000,000  VND')
INSERT [dbo].[VehicleCrawlDatas] ([Id], [CreateAt], [UpdateAt], [Name], [Image], [Value]) VALUES (413, CAST(N'2020-11-19T09:08:18.3911682' AS DateTime2), CAST(N'2020-11-19T09:08:18.3911690' AS DateTime2), N'BMW 330i', N'https://img.tinbanxe.vn/images/bmw/bmw%20330i/bmw-330i-phien-ban-sport-line_-anhdaidienpng.png', N'2,351,000,000  VND')
INSERT [dbo].[VehicleCrawlDatas] ([Id], [CreateAt], [UpdateAt], [Name], [Image], [Value]) VALUES (414, CAST(N'2020-11-19T09:08:21.7718643' AS DateTime2), CAST(N'2020-11-19T09:08:21.7718648' AS DateTime2), N'Honda BR-V', N'https://img.tinbanxe.vn/images/Honda/Honda-BR-V/honda-br-v-2020.png', N'635,000,000  VND')
INSERT [dbo].[VehicleCrawlDatas] ([Id], [CreateAt], [UpdateAt], [Name], [Image], [Value]) VALUES (415, CAST(N'2020-11-19T09:08:18.3913789' AS DateTime2), CAST(N'2020-11-19T09:08:18.3913796' AS DateTime2), N'BMW M3', N'https://img.tinbanxe.vn/images/bmw/bmw-m3/bmw-m3-2020-anhdaidien.png', NULL)
INSERT [dbo].[VehicleCrawlDatas] ([Id], [CreateAt], [UpdateAt], [Name], [Image], [Value]) VALUES (416, CAST(N'2020-11-19T09:08:18.3919066' AS DateTime2), CAST(N'2020-11-19T09:08:18.3919071' AS DateTime2), N'BMW M6', N'https://img.tinbanxe.vn/images/bmw/BMW-m6/bmw-anhdaidien-428i-2020.png', N'6,688,000,000  VND')
INSERT [dbo].[VehicleCrawlDatas] ([Id], [CreateAt], [UpdateAt], [Name], [Image], [Value]) VALUES (417, CAST(N'2020-11-19T09:08:18.3932924' AS DateTime2), CAST(N'2020-11-19T09:08:18.3932940' AS DateTime2), N'BMW M850i', N'https://img.tinbanxe.vn/images/bmw/bmw-m850i/bmw-m850i-anhdaidien.png', N'9,500,000,000  VND')
INSERT [dbo].[VehicleCrawlDatas] ([Id], [CreateAt], [UpdateAt], [Name], [Image], [Value]) VALUES (418, CAST(N'2020-11-19T09:08:18.3942174' AS DateTime2), CAST(N'2020-11-19T09:08:18.3942187' AS DateTime2), N'BMW 840i Gran Coupe', N'https://img.tinbanxe.vn/images/bmw/bmw-840/WHITE_cc_2020BMC920005_01_1280_A96-removebg-preview.png', N'5,800,000,000  VND')
INSERT [dbo].[VehicleCrawlDatas] ([Id], [CreateAt], [UpdateAt], [Name], [Image], [Value]) VALUES (419, CAST(N'2020-11-19T09:08:18.3948889' AS DateTime2), CAST(N'2020-11-19T09:08:18.3948900' AS DateTime2), N'BMW 218i Coupe', N'https://img.tinbanxe.vn/images/bmw/bmw-218i/bmw-218i-active-anhdaidien-preview.png', N'1,996,000,000  VND')
INSERT [dbo].[VehicleCrawlDatas] ([Id], [CreateAt], [UpdateAt], [Name], [Image], [Value]) VALUES (420, CAST(N'2020-11-19T09:08:18.3954227' AS DateTime2), CAST(N'2020-11-19T09:08:18.3954237' AS DateTime2), N'BMW 640i Gran Coupe', N'https://img.tinbanxe.vn/images/bmw/bmw-640i/bmw-anhdaidien-428i-2020.png', N'3,888,000,000  VND')
INSERT [dbo].[VehicleCrawlDatas] ([Id], [CreateAt], [UpdateAt], [Name], [Image], [Value]) VALUES (421, CAST(N'2020-11-19T09:08:18.3960237' AS DateTime2), CAST(N'2020-11-19T09:08:18.3960250' AS DateTime2), N'BMW X7', N'https://img.tinbanxe.vn/images/BMW-X7/bmw-x7-anhdaidien.png', N'7,499,000,000  VND')
INSERT [dbo].[VehicleCrawlDatas] ([Id], [CreateAt], [UpdateAt], [Name], [Image], [Value]) VALUES (422, CAST(N'2020-11-19T09:08:20.1879387' AS DateTime2), CAST(N'2020-11-19T09:08:20.1879397' AS DateTime2), N'Ford Focus hatchback', N'https://img.tinbanxe.vn/images/FORD/ford-focus-hatchback/dai-dien-ford-focus-hatchback.png', N'770,000,000  VND')
INSERT [dbo].[VehicleCrawlDatas] ([Id], [CreateAt], [UpdateAt], [Name], [Image], [Value]) VALUES (423, CAST(N'2020-11-19T09:08:20.1881321' AS DateTime2), CAST(N'2020-11-19T09:08:20.1881323' AS DateTime2), N'Ford Mondeo', N'https://img.tinbanxe.vn/images/FORD/FORD-MONDEO/Ford-Mondeo-ANHDAIDIEN.png', N'32,500  USD')
INSERT [dbo].[VehicleCrawlDatas] ([Id], [CreateAt], [UpdateAt], [Name], [Image], [Value]) VALUES (424, CAST(N'2020-11-19T09:08:20.1882580' AS DateTime2), CAST(N'2020-11-19T09:08:20.1882582' AS DateTime2), N'Ford Ranger', N'https://img.tinbanxe.vn/images/FORD/Ford%20Ranger/Ford-Ranger-ANHDAIDIEN.png', N'853,000,000  VND')
INSERT [dbo].[VehicleCrawlDatas] ([Id], [CreateAt], [UpdateAt], [Name], [Image], [Value]) VALUES (425, CAST(N'2020-11-19T09:08:18.3916604' AS DateTime2), CAST(N'2020-11-19T09:08:18.3916611' AS DateTime2), N'BMW M4', N'https://img.tinbanxe.vn/images/bmw/Bmw%20m4/anh-dai-dien-bmw-m4-2020.png', N'4,239,000,000  VND')
INSERT [dbo].[VehicleCrawlDatas] ([Id], [CreateAt], [UpdateAt], [Name], [Image], [Value]) VALUES (426, CAST(N'2020-11-19T09:08:29.5412378' AS DateTime2), CAST(N'2020-11-19T09:08:29.5412382' AS DateTime2), N'Mitsubishi Xpander', N'https://img.tinbanxe.vn/images/Mitsubishi/mitsubishi-xpander.png', N'620,000,000  VND')
SET IDENTITY_INSERT [dbo].[VehicleCrawlDatas] OFF
GO
SET IDENTITY_INSERT [dbo].[Vehicles] ON 

INSERT [dbo].[Vehicles] ([Id], [CreateAt], [UpdateAt], [CustomerId], [MakeId], [ModelId], [Odometer], [VIN], [Engine], [isDelete]) VALUES (1, CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), CAST(N'2020-11-14T10:07:52.7272910' AS DateTime2), 4, 2, 2, N'10001', N'EF27564733HS', N'Loto', 0)
INSERT [dbo].[Vehicles] ([Id], [CreateAt], [UpdateAt], [CustomerId], [MakeId], [ModelId], [Odometer], [VIN], [Engine], [isDelete]) VALUES (2, CAST(N'2020-05-11T00:00:00.0000000' AS DateTime2), CAST(N'2020-05-11T00:00:00.0000000' AS DateTime2), 6, 3, 2, N'20000', N'HD7567465US', N'Zolo', 0)
INSERT [dbo].[Vehicles] ([Id], [CreateAt], [UpdateAt], [CustomerId], [MakeId], [ModelId], [Odometer], [VIN], [Engine], [isDelete]) VALUES (3, CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), CAST(N'2020-11-20T15:25:48.6217184' AS DateTime2), 7, 4, 3, N'30000', N'JK85627562AK', N'Poco', 0)
INSERT [dbo].[Vehicles] ([Id], [CreateAt], [UpdateAt], [CustomerId], [MakeId], [ModelId], [Odometer], [VIN], [Engine], [isDelete]) VALUES (4, CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), CAST(N'2020-11-14T17:08:38.8538660' AS DateTime2), 6, 2, 2, N'30000', N'HD27562756KS', N'Loto', 0)
INSERT [dbo].[Vehicles] ([Id], [CreateAt], [UpdateAt], [CustomerId], [MakeId], [ModelId], [Odometer], [VIN], [Engine], [isDelete]) VALUES (5, CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), CAST(N'2020-11-14T17:07:18.9573696' AS DateTime2), 4, 2, 1, N'190000', N'HD27584756VC', N'lolo', 0)
INSERT [dbo].[Vehicles] ([Id], [CreateAt], [UpdateAt], [CustomerId], [MakeId], [ModelId], [Odometer], [VIN], [Engine], [isDelete]) VALUES (6, CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), CAST(N'2020-11-20T15:27:39.8070444' AS DateTime2), 4, 2, 1, N'190000', N'HD27584756VC', N'lolo', 1)
INSERT [dbo].[Vehicles] ([Id], [CreateAt], [UpdateAt], [CustomerId], [MakeId], [ModelId], [Odometer], [VIN], [Engine], [isDelete]) VALUES (7, CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), CAST(N'2020-11-20T15:27:01.4238195' AS DateTime2), 10, 5, 1, N'100000', N'HD75847574US', N'4 thì', 1)
INSERT [dbo].[Vehicles] ([Id], [CreateAt], [UpdateAt], [CustomerId], [MakeId], [ModelId], [Odometer], [VIN], [Engine], [isDelete]) VALUES (8, CAST(N'2020-11-21T10:08:50.8068173' AS DateTime2), CAST(N'2020-11-21T10:08:50.8069224' AS DateTime2), 4, 3, 2, N'asdaasas', N'asdadasd', N'aasdasd', 0)
SET IDENTITY_INSERT [dbo].[Vehicles] OFF
GO
/****** Object:  Index [IX_AppUsers_AppUserRolesId]    Script Date: 11/22/2020 1:02:13 PM ******/
CREATE NONCLUSTERED INDEX [IX_AppUsers_AppUserRolesId] ON [dbo].[AppUsers]
(
	[AppUserRolesId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Conditions_VehicleId]    Script Date: 11/22/2020 1:02:13 PM ******/
CREATE NONCLUSTERED INDEX [IX_Conditions_VehicleId] ON [dbo].[Conditions]
(
	[VehicleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_VehicleAppraisals_VehicleId]    Script Date: 11/22/2020 1:02:13 PM ******/
CREATE NONCLUSTERED INDEX [IX_VehicleAppraisals_VehicleId] ON [dbo].[VehicleAppraisals]
(
	[VehicleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Vehicles_CustomerId]    Script Date: 11/22/2020 1:02:13 PM ******/
CREATE NONCLUSTERED INDEX [IX_Vehicles_CustomerId] ON [dbo].[Vehicles]
(
	[CustomerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Vehicles_MakeId]    Script Date: 11/22/2020 1:02:13 PM ******/
CREATE NONCLUSTERED INDEX [IX_Vehicles_MakeId] ON [dbo].[Vehicles]
(
	[MakeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Vehicles_ModelId]    Script Date: 11/22/2020 1:02:13 PM ******/
CREATE NONCLUSTERED INDEX [IX_Vehicles_ModelId] ON [dbo].[Vehicles]
(
	[ModelId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[AppUsers]  WITH CHECK ADD  CONSTRAINT [FK_AppUsers_AppUserRoles_AppUserRolesId] FOREIGN KEY([AppUserRolesId])
REFERENCES [dbo].[AppUserRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AppUsers] CHECK CONSTRAINT [FK_AppUsers_AppUserRoles_AppUserRolesId]
GO
ALTER TABLE [dbo].[Conditions]  WITH CHECK ADD  CONSTRAINT [FK_Conditions_Vehicles_VehicleId] FOREIGN KEY([VehicleId])
REFERENCES [dbo].[Vehicles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Conditions] CHECK CONSTRAINT [FK_Conditions_Vehicles_VehicleId]
GO
ALTER TABLE [dbo].[VehicleAppraisals]  WITH CHECK ADD  CONSTRAINT [FK_VehicleAppraisals_Vehicles_VehicleId] FOREIGN KEY([VehicleId])
REFERENCES [dbo].[Vehicles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[VehicleAppraisals] CHECK CONSTRAINT [FK_VehicleAppraisals_Vehicles_VehicleId]
GO
ALTER TABLE [dbo].[Vehicles]  WITH CHECK ADD  CONSTRAINT [FK_Vehicles_Customers_CustomerId] FOREIGN KEY([CustomerId])
REFERENCES [dbo].[Customers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Vehicles] CHECK CONSTRAINT [FK_Vehicles_Customers_CustomerId]
GO
ALTER TABLE [dbo].[Vehicles]  WITH CHECK ADD  CONSTRAINT [FK_Vehicles_Makes_MakeId] FOREIGN KEY([MakeId])
REFERENCES [dbo].[Makes] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Vehicles] CHECK CONSTRAINT [FK_Vehicles_Makes_MakeId]
GO
ALTER TABLE [dbo].[Vehicles]  WITH CHECK ADD  CONSTRAINT [FK_Vehicles_Models_ModelId] FOREIGN KEY([ModelId])
REFERENCES [dbo].[Models] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Vehicles] CHECK CONSTRAINT [FK_Vehicles_Models_ModelId]
GO
USE [master]
GO
ALTER DATABASE [VehicleAppraisal] SET  READ_WRITE 
GO
