USE [master]
GO
/****** Object:  Database [Hotel_Management]    Script Date: 12/12/2019 2:22:08 PM ******/
CREATE DATABASE [Hotel_Management]
 GO
ALTER DATABASE [Hotel_Management] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Hotel_Management].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Hotel_Management] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Hotel_Management] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Hotel_Management] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Hotel_Management] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Hotel_Management] SET ARITHABORT OFF 
GO
ALTER DATABASE [Hotel_Management] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Hotel_Management] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Hotel_Management] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Hotel_Management] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Hotel_Management] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Hotel_Management] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Hotel_Management] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Hotel_Management] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Hotel_Management] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Hotel_Management] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Hotel_Management] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Hotel_Management] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Hotel_Management] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Hotel_Management] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Hotel_Management] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Hotel_Management] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Hotel_Management] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Hotel_Management] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Hotel_Management] SET  MULTI_USER 
GO
ALTER DATABASE [Hotel_Management] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Hotel_Management] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Hotel_Management] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Hotel_Management] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Hotel_Management] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Hotel_Management] SET QUERY_STORE = OFF
GO
USE [Hotel_Management]
GO
/****** Object:  Table [dbo].[bill]    Script Date: 12/12/2019 2:22:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[bill](
	[idb] [nvarchar](50) NOT NULL,
	[idr] [nvarchar](50) NOT NULL,
	[idc] [int] NOT NULL,
	[idm] [nvarchar](50) NOT NULL,
	[cost] [money] NOT NULL,
	[checkin] [datetime] NOT NULL,
	[checkout] [datetime] NOT NULL,
 CONSTRAINT [PK_bill] PRIMARY KEY CLUSTERED 
(
	[idb] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[customer]    Script Date: 12/12/2019 2:22:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[customer](
	[idc] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NOT NULL,
	[phone] [nvarchar](50) NULL,
	[date] [datetime] NOT NULL,
	[cmnd] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_customer] PRIMARY KEY CLUSTERED 
(
	[idc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[manager]    Script Date: 12/12/2019 2:22:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[manager](
	[idm] [nvarchar](50) NOT NULL default N'admin',
	[name] [nvarchar](50) NOT NULL default N'user',
	[phone] [nvarchar](50) NOT NULL default N'0123456789',
	[email] [nvarchar](50) NOT NULL default N'user@gmail.com',
	[password] [nvarchar](50) NOT NULL default N'0',
	[level] [int] NOT NULL default 1,
	[gender] [nvarchar](50) NOT NULL default N'Nam',
	[cmnd] [nvarchar](50) NOT NULL default N'00000000',
 CONSTRAINT [PK_manager] PRIMARY KEY CLUSTERED 
(
	[idm] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].manager (idm,name,phone,email,password,level,gender,cmnd) VALUES (N'admin',N'user',N'0123456789',N'user@gmail.com',N'0',1, N'Nam',N'00000000')
go
/****** Object:  Table [dbo].[room]    Script Date: 12/12/2019 2:22:09 PM ******/

SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[room](
	[idr] [nvarchar](50) NOT NULL,
	[name] [nvarchar](50) NOT NULL,
	[status] [nvarchar](50) NOT NULL,
	[cost] [money] NOT NULL,
	[bedamount] [int] NOT NULL,
	[roomkind] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_room] PRIMARY KEY CLUSTERED 
(
	[idr] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
insert dbo.room (idr,name,status,cost,bedamount,roomkind) values (N'1',N'101',N'null',N'',1,N'0')
insert dbo.room (idr,name,status,cost,bedamount,roomkind) values (N'11',N'102',N'null',N'',1,N'0')
insert dbo.room (idr,name,status,cost,bedamount,roomkind) values (N'111',N'103',N'nnull',N'',1,N'0')
insert dbo.room (idr,name,status,cost,bedamount,roomkind) values (N'1111',N'104',N'nnull',N'',1,N'0')
insert dbo.room (idr,name,status,cost,bedamount,roomkind) values (N'11111',N'405',N'nnull',N'',1,N'0')

create proc use_getroomlist
as select *from dbo.room
go
exec dbo.use_getroomlist
/****** Object:  Table [dbo].[room_service]    Script Date: 12/12/2019 2:22:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[room_service](
	[idrs] [nvarchar](50) NOT NULL,
	[idr] [nvarchar](50) NOT NULL,
	[ids] [nvarchar](50) NOT NULL,
	[time] [smalldatetime] NOT NULL,
	[number] [nvarchar](50) NOT NULL,
	[cost] [money] NOT NULL,
 CONSTRAINT [PK_room_service] PRIMARY KEY CLUSTERED 
(
	[idrs] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[service]    Script Date: 12/12/2019 2:22:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[service](
	[ids] [nvarchar](50) NOT NULL,
	[name] [nvarchar](50) NOT NULL,
	[kind] [nvarchar](50) NOT NULL,
	[cost] [money] NOT NULL,
 CONSTRAINT [PK_service] PRIMARY KEY CLUSTERED 
(
	[ids] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[bill]  WITH CHECK ADD  CONSTRAINT [FK_bill_customer] FOREIGN KEY([idc])
REFERENCES [dbo].[customer] ([idc])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[bill] CHECK CONSTRAINT [FK_bill_customer]
GO
ALTER TABLE [dbo].[bill]  WITH CHECK ADD  CONSTRAINT [FK_bill_manager] FOREIGN KEY([idm])
REFERENCES [dbo].[manager] ([idm])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[bill] CHECK CONSTRAINT [FK_bill_manager]
GO
ALTER TABLE [dbo].[bill]  WITH CHECK ADD  CONSTRAINT [FK_bill_room] FOREIGN KEY([idr])
REFERENCES [dbo].[room] ([idr])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[bill] CHECK CONSTRAINT [FK_bill_room]
GO
ALTER TABLE [dbo].[room_service]  WITH CHECK ADD  CONSTRAINT [FK_room_service_room] FOREIGN KEY([idr])
REFERENCES [dbo].[room] ([idr])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[room_service] CHECK CONSTRAINT [FK_room_service_room]
GO
ALTER TABLE [dbo].[room_service]  WITH CHECK ADD  CONSTRAINT [FK_room_service_service] FOREIGN KEY([ids])
REFERENCES [dbo].[service] ([ids])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[room_service] CHECK CONSTRAINT [FK_room_service_service]
GO
USE [master]
GO
ALTER DATABASE [Hotel_Management] SET  READ_WRITE 
GO
