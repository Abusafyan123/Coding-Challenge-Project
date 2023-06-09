USE [master]
GO
/****** Object:  Database [CodingChallengeDB]    Script Date: 3/11/2023 3:43:32 AM ******/
CREATE DATABASE [CodingChallengeDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'CodingChallengeDB', FILENAME = N'C:\Users\abu.safyan\CodingChallengeDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'CodingChallengeDB_log', FILENAME = N'C:\Users\abu.safyan\CodingChallengeDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [CodingChallengeDB] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [CodingChallengeDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [CodingChallengeDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [CodingChallengeDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [CodingChallengeDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [CodingChallengeDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [CodingChallengeDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [CodingChallengeDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [CodingChallengeDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [CodingChallengeDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [CodingChallengeDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [CodingChallengeDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [CodingChallengeDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [CodingChallengeDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [CodingChallengeDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [CodingChallengeDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [CodingChallengeDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [CodingChallengeDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [CodingChallengeDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [CodingChallengeDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [CodingChallengeDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [CodingChallengeDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [CodingChallengeDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [CodingChallengeDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [CodingChallengeDB] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [CodingChallengeDB] SET  MULTI_USER 
GO
ALTER DATABASE [CodingChallengeDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [CodingChallengeDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [CodingChallengeDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [CodingChallengeDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [CodingChallengeDB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [CodingChallengeDB] SET QUERY_STORE = OFF
GO
USE [CodingChallengeDB]
GO
/****** Object:  Table [dbo].[CARRIER]    Script Date: 3/11/2023 3:43:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CARRIER](
	[carrier_id] [int] NOT NULL,
	[carrier_name] [varchar](100) NOT NULL,
	[carrier_mode] [varchar](25) NOT NULL,
 CONSTRAINT [PK_CARRIER] PRIMARY KEY CLUSTERED 
(
	[carrier_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SHIPMENT]    Script Date: 3/11/2023 3:43:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SHIPMENT](
	[shipment_id] [int] NOT NULL,
	[shipper_id] [int] NOT NULL,
	[shipment_description] [varchar](100) NOT NULL,
	[shipment_weight] [numeric](18, 2) NOT NULL,
	[shipment_rate_id] [int] NOT NULL,
	[carrier_id] [int] NOT NULL,
 CONSTRAINT [PK_SHIPMENT] PRIMARY KEY CLUSTERED 
(
	[shipment_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SHIPMENT_RATE]    Script Date: 3/11/2023 3:43:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SHIPMENT_RATE](
	[shipment_rate_id] [int] NOT NULL,
	[shipment_rate_class] [varchar](10) NOT NULL,
	[shipment_rate_description] [varchar](25) NOT NULL,
 CONSTRAINT [PK_SHIPMENT_RATE] PRIMARY KEY CLUSTERED 
(
	[shipment_rate_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SHIPPER]    Script Date: 3/11/2023 3:43:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SHIPPER](
	[shipper_id] [int] NOT NULL,
	[shipper_name] [varchar](100) NOT NULL,
 CONSTRAINT [PK_SHIPPER] PRIMARY KEY CLUSTERED 
(
	[shipper_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[CARRIER] ([carrier_id], [carrier_name], [carrier_mode]) VALUES (1, N'Short Line RailRoad', N'RAIL')
INSERT [dbo].[CARRIER] ([carrier_id], [carrier_name], [carrier_mode]) VALUES (2, N'Planet Express', N'TRUCK')
INSERT [dbo].[CARRIER] ([carrier_id], [carrier_name], [carrier_mode]) VALUES (3, N'Greene Transport', N'TRUCK')
INSERT [dbo].[CARRIER] ([carrier_id], [carrier_name], [carrier_mode]) VALUES (4, N'Big Boats R Us', N'OCEAN')
INSERT [dbo].[CARRIER] ([carrier_id], [carrier_name], [carrier_mode]) VALUES (5, N'Speedy Delivery', N'TRUCK')
GO
INSERT [dbo].[SHIPMENT] ([shipment_id], [shipper_id], [shipment_description], [shipment_weight], [shipment_rate_id], [carrier_id]) VALUES (1, 1, N'Machine Parts', CAST(130.54 AS Numeric(18, 2)), 1, 1)
INSERT [dbo].[SHIPMENT] ([shipment_id], [shipper_id], [shipment_description], [shipment_weight], [shipment_rate_id], [carrier_id]) VALUES (2, 3, N'Office Supplies', CAST(10.05 AS Numeric(18, 2)), 2, 3)
INSERT [dbo].[SHIPMENT] ([shipment_id], [shipper_id], [shipment_description], [shipment_weight], [shipment_rate_id], [carrier_id]) VALUES (3, 2, N'Basketball Hoops', CAST(13.40 AS Numeric(18, 2)), 2, 4)
INSERT [dbo].[SHIPMENT] ([shipment_id], [shipper_id], [shipment_description], [shipment_weight], [shipment_rate_id], [carrier_id]) VALUES (4, 2, N'Football Helmets', CAST(25.98 AS Numeric(18, 2)), 2, 2)
INSERT [dbo].[SHIPMENT] ([shipment_id], [shipper_id], [shipment_description], [shipment_weight], [shipment_rate_id], [carrier_id]) VALUES (5, 1, N'Conveyor System', CAST(250.10 AS Numeric(18, 2)), 1, 5)
INSERT [dbo].[SHIPMENT] ([shipment_id], [shipper_id], [shipment_description], [shipment_weight], [shipment_rate_id], [carrier_id]) VALUES (6, 3, N'Automobile Engines', CAST(65.25 AS Numeric(18, 2)), 3, 2)
GO
INSERT [dbo].[SHIPMENT_RATE] ([shipment_rate_id], [shipment_rate_class], [shipment_rate_description]) VALUES (1, N'FULL', N'Full Price')
INSERT [dbo].[SHIPMENT_RATE] ([shipment_rate_id], [shipment_rate_class], [shipment_rate_description]) VALUES (2, N'50OFF', N'50% Discount')
INSERT [dbo].[SHIPMENT_RATE] ([shipment_rate_id], [shipment_rate_class], [shipment_rate_description]) VALUES (3, N'10OFF', N'10% Discount')
GO
INSERT [dbo].[SHIPPER] ([shipper_id], [shipper_name]) VALUES (1, N'Blossom Manufacturing')
INSERT [dbo].[SHIPPER] ([shipper_id], [shipper_name]) VALUES (2, N'Sporting Partners')
INSERT [dbo].[SHIPPER] ([shipper_id], [shipper_name]) VALUES (3, N'Associates and Company')
GO
ALTER TABLE [dbo].[SHIPMENT]  WITH CHECK ADD  CONSTRAINT [FK_SHIPMENT_CARRIER] FOREIGN KEY([carrier_id])
REFERENCES [dbo].[CARRIER] ([carrier_id])
GO
ALTER TABLE [dbo].[SHIPMENT] CHECK CONSTRAINT [FK_SHIPMENT_CARRIER]
GO
ALTER TABLE [dbo].[SHIPMENT]  WITH CHECK ADD  CONSTRAINT [FK_SHIPMENT_SHIPMENT_RATE] FOREIGN KEY([shipment_rate_id])
REFERENCES [dbo].[SHIPMENT_RATE] ([shipment_rate_id])
GO
ALTER TABLE [dbo].[SHIPMENT] CHECK CONSTRAINT [FK_SHIPMENT_SHIPMENT_RATE]
GO
ALTER TABLE [dbo].[SHIPMENT]  WITH CHECK ADD  CONSTRAINT [FK_SHIPMENT_SHIPPER] FOREIGN KEY([shipper_id])
REFERENCES [dbo].[SHIPPER] ([shipper_id])
GO
ALTER TABLE [dbo].[SHIPMENT] CHECK CONSTRAINT [FK_SHIPMENT_SHIPPER]
GO
/****** Object:  StoredProcedure [dbo].[Shipper_Shipment_Details]    Script Date: 3/11/2023 3:43:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Shipper_Shipment_Details] 
	-- Add the parameters for the stored procedure here
	@shipper_id int

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	
Select spmt.shipment_id, spmt.shipment_description, spmt.shipment_weight, spr.shipper_name, crr.carrier_name, rate.shipment_rate_description

from SHIPMENT spmt 
JOIN SHIPPER spr on spr.shipper_id = spmt.shipment_id
JOIN CARRIER crr on crr.carrier_id = spmt.carrier_id
JOIN SHIPMENT_RATE rate on rate.shipment_rate_id = spmt.shipment_rate_id

Where spmt.shipper_id = @shipper_id

END
GO
USE [master]
GO
ALTER DATABASE [CodingChallengeDB] SET  READ_WRITE 
GO
