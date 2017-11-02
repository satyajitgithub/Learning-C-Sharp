---------------- Create Database --------------------------------------
USE [master]
GO

/****** Object:  Database [CustomerManagement]    Script Date: 10/11/2017 2:33:21 PM ******/
CREATE DATABASE [CustomerManagement]
GO

------------------------------------------------ Create required Tables ----------------------------------
USE [CustomerManagement]
GO

/****** Object:  Table [dbo].[Account]    Script Date: 11/1/2017 11:13:55 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Account](
	[SN] [int] IDENTITY(1,1) NOT NULL,
	[Particulars] [nchar](50) NULL,
	[Deposit] [numeric](10, 2) NULL,
	[Withdrawl] [numeric](10, 2) NULL,
	[Balance] [numeric](10, 2) NULL,
	[Date] [date] NULL,
	[Cust_Name] [nchar](50) NULL,
 CONSTRAINT [PK_Account] PRIMARY KEY CLUSTERED 
(
	[SN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

----------------------------------------------------------------------------------------------------------------
USE [CustomerManagement]
GO

/****** Object:  Table [dbo].[Customer]    Script Date: 11/1/2017 11:14:35 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Customer](
	[Cust_Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nchar](50) NULL,
	[Address] [nchar](100) NULL,
	[PhoneNo] [nchar](20) NULL,
	[TypeofAC] [nchar](50) NULL,
	[InterestRate] [nchar](20) NULL,
	[NameofNominee] [nchar](50) NULL,
	[Relation] [nchar](50) NULL,
 CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED 
(
	[Cust_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
