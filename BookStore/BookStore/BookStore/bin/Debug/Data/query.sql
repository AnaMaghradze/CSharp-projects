USE MASTER;
GO
DROP DATABASE IF EXISTS BookStore;
GO
CREATE DATABASE BookStore;
GO
USE [BookStore]
GO
/* Object:  Table [dbo].[Books]*/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
DROP TABLE IF EXISTS Books;
GO
CREATE TABLE [dbo].[Books](
	[Title] [nvarchar](200) NULL,
	[Author] [nvarchar](150) NULL,
	[ISBN] [nvarchar](25) NOT NULL,
	[Price] [decimal](18, 2) NULL,
 CONSTRAINT [PK_Books] PRIMARY KEY CLUSTERED 
(
	[ISBN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/* Object:  Table [dbo].[Customers] */
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
DROP TABLE IF EXISTS Customers;
GO
CREATE TABLE [dbo].[Customers](
	[FirstName] [nvarchar](100) NULL,
	[LastName] [nvarchar](100) NULL,
	[Email] [nvarchar](150) NULL,
	[Phone] [nvarchar](25) NULL,
	[Address] [nvarchar](200) NULL,
	[City] [nvarchar](50) NULL,
	[State] [nvarchar](50) NULL,
	[Zip] [nvarchar](20) NULL,
	[ID] [int] IDENTITY(1,1) NOT NULL
) ON [PRIMARY]
GO
/* Object:  Table [dbo].[OrderDetails] */
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
DROP TABLE IF EXISTS OrderDetails;
GO
CREATE TABLE [dbo].[OrderDetails](
	[OrderID] [int] NULL,
	[BookID] [nvarchar](100) NULL,
	[Quantity] [int] NULL,
	[LinesTotal] [decimal](18, 2) NULL
) ON [PRIMARY]
GO
/* Object:  Table [dbo].[Orders] */
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
DROP TABLE IF EXISTS Orders;
GO
CREATE TABLE [dbo].[Orders](
	[CustomerID] [nvarchar](100) NULL,
	[SubTotal] [decimal](18, 2) NULL,
	[Total] [decimal](18, 2) NULL,
	[Tax] [decimal](18, 2) NULL,
	[OrderDate] [datetime] NULL,
	[OrderID] [int] IDENTITY(1,1) NOT NULL
) ON [PRIMARY]
GO