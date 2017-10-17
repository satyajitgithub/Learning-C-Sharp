---------------- Create Database --------------------------------------
USE [master]
GO

/****** Object:  Database [BillingSystem]    Script Date: 10/11/2017 2:33:21 PM ******/
CREATE DATABASE [BillingSystem]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'BillingSystem', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\BillingSystem.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'BillingSystem_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\BillingSystem_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO

ALTER DATABASE [BillingSystem] SET COMPATIBILITY_LEVEL = 120
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [BillingSystem].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [BillingSystem] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [BillingSystem] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [BillingSystem] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [BillingSystem] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [BillingSystem] SET ARITHABORT OFF 
GO

ALTER DATABASE [BillingSystem] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [BillingSystem] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [BillingSystem] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [BillingSystem] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [BillingSystem] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [BillingSystem] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [BillingSystem] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [BillingSystem] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [BillingSystem] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [BillingSystem] SET  DISABLE_BROKER 
GO

ALTER DATABASE [BillingSystem] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [BillingSystem] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [BillingSystem] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [BillingSystem] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [BillingSystem] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [BillingSystem] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [BillingSystem] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [BillingSystem] SET RECOVERY SIMPLE 
GO

ALTER DATABASE [BillingSystem] SET  MULTI_USER 
GO

ALTER DATABASE [BillingSystem] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [BillingSystem] SET DB_CHAINING OFF 
GO

ALTER DATABASE [BillingSystem] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [BillingSystem] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO

ALTER DATABASE [BillingSystem] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [BillingSystem] SET  READ_WRITE 
GO


------------------------------------------------ Create required Tables ----------------------------------

USE [BillingSystem]
GO

/****** Object:  Table [dbo].[Customer]    Script Date: 10/11/2017 2:35:04 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Customer](
	[Cust_Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nchar](50) NULL,
	[Address] [nchar](100) NULL,
	[PhoneNo] [nchar](20) NULL,
 CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED 
(
	[Cust_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

----------------------------------------------------------------------------------------------------------------

USE [BillingSystem]
GO

/****** Object:  Table [dbo].[Item]    Script Date: 10/11/2017 2:35:34 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Item](
	[ItemID] [int] IDENTITY(1,1) NOT NULL,
	[ItemName] [nchar](50) NULL,
	[Qty_In_Hand] [int] NULL,
	[Qty_Sold] [int] NULL,
	[ItemWholeSalePrice] [decimal](10, 2) NULL,
	[ItemRetailPrice] [decimal](10, 2) NULL,
	[Vendor_Price] [decimal](10, 2) NULL,
	[Last_Purchased_Price] [decimal](10, 2) NULL,
	[ReOrderLevel] [int] NULL,
	[ReOrderQty] [int] NULL,
	[PriceLastUpdated] [date] NULL,
 CONSTRAINT [PK_Item] PRIMARY KEY CLUSTERED 
(
	[ItemID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

--------------------------------------------------------------------------------------------------------------------

USE [BillingSystem]
GO

/****** Object:  Table [dbo].[Purchase]    Script Date: 10/11/2017 2:36:02 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Purchase](
	[Purchase_ID] [int] IDENTITY(1,1) NOT NULL,
	[SubAmount] [decimal](10, 2) NULL,
	[TotalVAT] [decimal](10, 2) NULL,
	[TotalAmount] [decimal](10, 2) NULL,
	[PurchaseDate] [date] NULL,
	[Vendor] [nchar](50) NULL,
	[Lot_No1] [nchar](50) NULL,
 CONSTRAINT [PK_Purchase] PRIMARY KEY CLUSTERED 
(
	[Purchase_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

------------------------------------------------------------------------------------------------------------------

USE [BillingSystem]
GO

/****** Object:  Table [dbo].[Purchase_Details]    Script Date: 10/11/2017 2:36:28 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Purchase_Details](
	[P_Detail_ID] [int] IDENTITY(1,1) NOT NULL,
	[ItemName] [nchar](50) NULL,
	[Qty] [int] NULL,
	[VendorRate] [decimal](10, 2) NULL,
	[VAT] [decimal](10, 2) NULL,
	[FinalRate] [decimal](10, 2) NULL,
	[SubAmount] [decimal](10, 2) NULL,
	[Amount] [decimal](10, 2) NULL,
	[Vendor] [nchar](50) NULL,
	[PurchaseDate] [date] NULL,
	[Purchase_ID] [int] NULL,
 CONSTRAINT [PK_Purchase_Details] PRIMARY KEY CLUSTERED 
(
	[P_Detail_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

-----------------------------------------------------------------------------------------------------------

USE [BillingSystem]
GO

/****** Object:  Table [dbo].[Sale]    Script Date: 10/11/2017 2:36:56 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Sale](
	[SaleID] [int] IDENTITY(1,1) NOT NULL,
	[SubAmount] [decimal](10, 2) NULL,
	[VAT] [decimal](10, 2) NULL,
	[SaleAmount] [decimal](10, 2) NULL,
	[SaleType] [varchar](50) NULL,
	[Cust_Name] [varchar](50) NULL,
	[SaleDate] [date] NULL,
 CONSTRAINT [PK_Sale] PRIMARY KEY CLUSTERED 
(
	[SaleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

---------------------------------------------------------------------------------------------------------

USE [BillingSystem]
GO

/****** Object:  Table [dbo].[Sale_Details]    Script Date: 10/11/2017 2:37:20 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Sale_Details](
	[SaleDetailId] [int] IDENTITY(1,1) NOT NULL,
	[SaleID] [int] NULL,
	[Item_Name] [nchar](50) NULL,
	[Qty] [int] NULL,
	[Before_VAT] [decimal](8, 2) NULL,
	[VAT] [decimal](8, 2) NULL,
	[Rate] [decimal](8, 2) NULL,
	[SaleAmount] [decimal](10, 2) NULL,
	[SaleDate] [date] NULL,
	[SaleType] [nchar](10) NULL,
	[Cust_Name] [nchar](50) NULL,
 CONSTRAINT [PK_Sale_Details] PRIMARY KEY CLUSTERED 
(
	[SaleDetailId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO