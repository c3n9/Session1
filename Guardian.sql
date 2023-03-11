USE [master]
GO
/****** Object:  Database [Guardian]    Script Date: 11.03.2023 15:42:15 ******/
CREATE DATABASE [Guardian]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Guardian', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\Guardian.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Guardian_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\Guardian_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [Guardian] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Guardian].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Guardian] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Guardian] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Guardian] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Guardian] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Guardian] SET ARITHABORT OFF 
GO
ALTER DATABASE [Guardian] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Guardian] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Guardian] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Guardian] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Guardian] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Guardian] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Guardian] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Guardian] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Guardian] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Guardian] SET  ENABLE_BROKER 
GO
ALTER DATABASE [Guardian] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Guardian] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Guardian] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Guardian] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Guardian] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Guardian] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Guardian] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Guardian] SET RECOVERY FULL 
GO
ALTER DATABASE [Guardian] SET  MULTI_USER 
GO
ALTER DATABASE [Guardian] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Guardian] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Guardian] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Guardian] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Guardian] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Guardian] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'Guardian', N'ON'
GO
ALTER DATABASE [Guardian] SET QUERY_STORE = ON
GO
ALTER DATABASE [Guardian] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [Guardian]
GO
/****** Object:  Table [dbo].[Department]    Script Date: 11.03.2023 15:42:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Department](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Unit] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employee]    Script Date: 11.03.2023 15:42:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employee](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FullName] [nvarchar](150) NOT NULL,
	[DepertmentId] [int] NOT NULL,
 CONSTRAINT [PK_Employee] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pass]    Script Date: 11.03.2023 15:42:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pass](
	[int] [int] IDENTITY(1,1) NOT NULL,
	[DateStart] [date] NOT NULL,
	[DateEnd] [date] NOT NULL,
	[VisitPurpose] [nvarchar](100) NOT NULL,
	[EmployeeId] [int] NOT NULL,
	[UserId] [int] NULL,
	[PassStatusId] [int] NOT NULL,
 CONSTRAINT [PK_Pass] PRIMARY KEY CLUSTERED 
(
	[int] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PassDocument]    Script Date: 11.03.2023 15:42:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PassDocument](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[DocumentFile] [nchar](10) NOT NULL,
	[PassId] [int] NOT NULL,
 CONSTRAINT [PK_PassDocument] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PassGuest]    Script Date: 11.03.2023 15:42:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PassGuest](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Surname] [nvarchar](50) NULL,
	[Patromic] [nvarchar](50) NULL,
	[Phone] [nvarchar](20) NULL,
	[Email] [nvarchar](150) NULL,
	[Organization] [nvarchar](50) NULL,
	[Description] [nvarchar](200) NULL,
	[BirthDate] [date] NULL,
	[PassportSeria] [nvarchar](4) NULL,
	[PassportNumber] [nvarchar](6) NULL,
	[Photo] [image] NULL,
	[PassId] [int] NOT NULL,
 CONSTRAINT [PK_PassGuest] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PassStatus]    Script Date: 11.03.2023 15:42:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PassStatus](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_PassStatus] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 11.03.2023 15:42:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FullName] [nvarchar](150) NOT NULL,
	[Number] [nvarchar](20) NOT NULL,
	[Email] [nvarchar](25) NOT NULL,
	[Birthday] [date] NOT NULL,
	[PassportSeria] [nvarchar](4) NOT NULL,
	[PassportNumber] [nvarchar](6) NOT NULL,
	[Login] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
	[Appointment] [date] NOT NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Department] ON 

INSERT [dbo].[Department] ([Id], [Name]) VALUES (1, N'Производство')
INSERT [dbo].[Department] ([Id], [Name]) VALUES (2, N'Сбыт')
INSERT [dbo].[Department] ([Id], [Name]) VALUES (3, N'Администрация')
INSERT [dbo].[Department] ([Id], [Name]) VALUES (4, N'Служба безопасности')
INSERT [dbo].[Department] ([Id], [Name]) VALUES (5, N'Планирование')
INSERT [dbo].[Department] ([Id], [Name]) VALUES (6, N'Общий отдел')
INSERT [dbo].[Department] ([Id], [Name]) VALUES (7, N'Охрана')
SET IDENTITY_INSERT [dbo].[Department] OFF
GO
SET IDENTITY_INSERT [dbo].[Employee] ON 

INSERT [dbo].[Employee] ([Id], [FullName], [DepertmentId]) VALUES (15, N'Фомичева Авдотья Трофимовна', 1)
INSERT [dbo].[Employee] ([Id], [FullName], [DepertmentId]) VALUES (16, N'Гаврилова Римма Ефимовна', 2)
INSERT [dbo].[Employee] ([Id], [FullName], [DepertmentId]) VALUES (17, N'Носкова Наталия Прохоровна', 3)
INSERT [dbo].[Employee] ([Id], [FullName], [DepertmentId]) VALUES (18, N'Архипов Тимофей Васильевич', 4)
INSERT [dbo].[Employee] ([Id], [FullName], [DepertmentId]) VALUES (19, N'Орехова Вероника Артемовна', 5)
INSERT [dbo].[Employee] ([Id], [FullName], [DepertmentId]) VALUES (20, N'Савельев Павел Степанович', 6)
INSERT [dbo].[Employee] ([Id], [FullName], [DepertmentId]) VALUES (22, N'Чернов Всеволод Наумович', 7)
SET IDENTITY_INSERT [dbo].[Employee] OFF
GO
SET IDENTITY_INSERT [dbo].[PassStatus] ON 

INSERT [dbo].[PassStatus] ([Id], [Name]) VALUES (1, N'На рассмотрении')
INSERT [dbo].[PassStatus] ([Id], [Name]) VALUES (2, N'Одобрено')
INSERT [dbo].[PassStatus] ([Id], [Name]) VALUES (3, N'Отклонено')
SET IDENTITY_INSERT [dbo].[PassStatus] OFF
GO
SET IDENTITY_INSERT [dbo].[User] ON 

INSERT [dbo].[User] ([Id], [FullName], [Number], [Email], [Birthday], [PassportSeria], [PassportNumber], [Login], [Password], [Appointment]) VALUES (1, N'Степанова Радинка Власовна', N'+7 (613) 272-60-62', N'Radinka100@yandex.ru', CAST(N'1986-10-18' AS Date), N'0208', N'530509', N'Vlas86', N'b3uWS6#Thuvq', CAST(N'2023-04-24' AS Date))
INSERT [dbo].[User] ([Id], [FullName], [Number], [Email], [Birthday], [PassportSeria], [PassportNumber], [Login], [Password], [Appointment]) VALUES (2, N'Шилов Прохор Герасимович', N'+7 (615) 594-77-66', N'Prohor156@list.ru', CAST(N'1977-10-09' AS Date), N'3036', N'796488', N'Prohor156', N'zDdom}SIhWs?', CAST(N'2023-04-24' AS Date))
INSERT [dbo].[User] ([Id], [FullName], [Number], [Email], [Birthday], [PassportSeria], [PassportNumber], [Login], [Password], [Appointment]) VALUES (3, N'Кононов Юрин Романович', N'+7 (784) 673-51-91', N'YUrin155@gmail.com', CAST(N'1971-10-08' AS Date), N'2747', N'790512', N'YUrin155', N'u@m*~ACBCqNQ', CAST(N'2023-04-24' AS Date))
INSERT [dbo].[User] ([Id], [FullName], [Number], [Email], [Birthday], [PassportSeria], [PassportNumber], [Login], [Password], [Appointment]) VALUES (4, N'Елисеева Альбина Николаевна', N'+7 (654) 864-77-46', N'Aljbina33@lenta.ru', CAST(N'1983-02-15' AS Date), N'5241', N'213304', N'Aljbina33', N'Bu?BHCtwDFin', CAST(N'2023-04-25' AS Date))
INSERT [dbo].[User] ([Id], [FullName], [Number], [Email], [Birthday], [PassportSeria], [PassportNumber], [Login], [Password], [Appointment]) VALUES (5, N'Шарова Клавдия Макаровна', N'+7 (822) 525-82-40', N'Klavdiya113@live.com', CAST(N'1980-07-22' AS Date), N'8143', N'593309', N'Klavdiya113', N'FjC#hNIJori}', CAST(N'2023-04-25' AS Date))
INSERT [dbo].[User] ([Id], [FullName], [Number], [Email], [Birthday], [PassportSeria], [PassportNumber], [Login], [Password], [Appointment]) VALUES (6, N'Сидорова Тамара Григорьевна', N'+7 (334) 692-79-77', N'Tamara179@live.com', CAST(N'1995-11-22' AS Date), N'8143', N'905520', N'Tamara179', N'TJxVqMXrbesI', CAST(N'2023-04-25' AS Date))
INSERT [dbo].[User] ([Id], [FullName], [Number], [Email], [Birthday], [PassportSeria], [PassportNumber], [Login], [Password], [Appointment]) VALUES (7, N'Петухов Тарас Фадеевич', N'+7 (376) 220-62-51', N'Taras24@rambler.ru', CAST(N'1991-01-05' AS Date), N'1609', N'171096', N'Taras24', N'07m5yspn3K~K', CAST(N'2023-04-26' AS Date))
INSERT [dbo].[User] ([Id], [FullName], [Number], [Email], [Birthday], [PassportSeria], [PassportNumber], [Login], [Password], [Appointment]) VALUES (8, N'Родионов Аркадий Власович', N'+7 (491) 696-17-11', N'Arkadij123@inbox.ru', CAST(N'1993-08-11' AS Date), N'3841', N'642594', N'Arkadij123', N'vk2N7lxX}ck%', CAST(N'2023-04-26' AS Date))
INSERT [dbo].[User] ([Id], [FullName], [Number], [Email], [Birthday], [PassportSeria], [PassportNumber], [Login], [Password], [Appointment]) VALUES (9, N'Горшкова Глафира Валентиновна', N'+7 (553) 343-38-82', N'Glafira73@outlook.com', CAST(N'1978-05-25' AS Date), N'9170', N'402601', N'Glafira73', N'Zz8POQlP}M4~', CAST(N'2023-04-26' AS Date))
INSERT [dbo].[User] ([Id], [FullName], [Number], [Email], [Birthday], [PassportSeria], [PassportNumber], [Login], [Password], [Appointment]) VALUES (10, N'Кириллова Гавриила Яковна', N'+7 (648) 700-43-34', N'Gavriila68@msn.com', CAST(N'1992-04-26' AS Date), N'9438', N'379667', N'Gavriila68', N'x4K5WthEe8ua', CAST(N'2023-04-27' AS Date))
INSERT [dbo].[User] ([Id], [FullName], [Number], [Email], [Birthday], [PassportSeria], [PassportNumber], [Login], [Password], [Appointment]) VALUES (11, N'Овчинников Кузьма Ефимович', N'+7 (562) 866-15-27', N'Kuzjma124@yandex.ru', CAST(N'1993-08-02' AS Date), N'0766', N'647226', N'Kuzjma124', N'OsByQJ}vYznW', CAST(N'2023-04-27' AS Date))
INSERT [dbo].[User] ([Id], [FullName], [Number], [Email], [Birthday], [PassportSeria], [PassportNumber], [Login], [Password], [Appointment]) VALUES (12, N'Беляков Роман Викторович', N'+7 (595) 196-56-28', N'Roman89@gmail.com', CAST(N'1991-06-07' AS Date), N'2411', N'478305', N'Roman89', N'Xd?xP$2yICcG', CAST(N'2023-04-27' AS Date))
INSERT [dbo].[User] ([Id], [FullName], [Number], [Email], [Birthday], [PassportSeria], [PassportNumber], [Login], [Password], [Appointment]) VALUES (13, N'Лыткин Алексей Максимович', N'+7 (994) 353-29-52', N'Aleksej43@gmail.com', CAST(N'1996-03-07' AS Date), N'2383', N'259825', N'Aleksej43', N'~c%PlTY0?qgl', CAST(N'2023-04-28' AS Date))
INSERT [dbo].[User] ([Id], [FullName], [Number], [Email], [Birthday], [PassportSeria], [PassportNumber], [Login], [Password], [Appointment]) VALUES (14, N'Шубина Надежда Викторовна', N'+7 (736) 488-66-95', N'Nadezhda137@outlook.com', CAST(N'1981-09-24' AS Date), N'8844', N'708476', N'Nadezhda137', N'QQ~0q~rXHb?p', CAST(N'2023-04-28' AS Date))
INSERT [dbo].[User] ([Id], [FullName], [Number], [Email], [Birthday], [PassportSeria], [PassportNumber], [Login], [Password], [Appointment]) VALUES (15, N'Зиновьева Бронислава Викторовна', N'+7 (778) 565-12-18', N'Bronislava56@yahoo.com', CAST(N'1981-03-19' AS Date), N'6736', N'319423', N'Bronislava56', N'LO}xyC~1S4l6', CAST(N'2023-04-28' AS Date))
INSERT [dbo].[User] ([Id], [FullName], [Number], [Email], [Birthday], [PassportSeria], [PassportNumber], [Login], [Password], [Appointment]) VALUES (16, N'Манаков Арсений Игоревич', N'+7 (999) 888-77-66', N'cenq@yandex.ru', CAST(N'2005-04-11' AS Date), N'9217', N'894823', N'c3n9', N'uex9jA0ZKdFZg93PclgCrg==', CAST(N'2023-04-03' AS Date))
SET IDENTITY_INSERT [dbo].[User] OFF
GO
ALTER TABLE [dbo].[Employee]  WITH CHECK ADD  CONSTRAINT [FK_Employee_Department] FOREIGN KEY([DepertmentId])
REFERENCES [dbo].[Department] ([Id])
GO
ALTER TABLE [dbo].[Employee] CHECK CONSTRAINT [FK_Employee_Department]
GO
ALTER TABLE [dbo].[Pass]  WITH CHECK ADD  CONSTRAINT [FK_Pass_Employee] FOREIGN KEY([EmployeeId])
REFERENCES [dbo].[Employee] ([Id])
GO
ALTER TABLE [dbo].[Pass] CHECK CONSTRAINT [FK_Pass_Employee]
GO
ALTER TABLE [dbo].[Pass]  WITH CHECK ADD  CONSTRAINT [FK_Pass_PassStatus] FOREIGN KEY([PassStatusId])
REFERENCES [dbo].[PassStatus] ([Id])
GO
ALTER TABLE [dbo].[Pass] CHECK CONSTRAINT [FK_Pass_PassStatus]
GO
ALTER TABLE [dbo].[Pass]  WITH CHECK ADD  CONSTRAINT [FK_Pass_User] FOREIGN KEY([UserId])
REFERENCES [dbo].[User] ([Id])
GO
ALTER TABLE [dbo].[Pass] CHECK CONSTRAINT [FK_Pass_User]
GO
ALTER TABLE [dbo].[PassDocument]  WITH CHECK ADD  CONSTRAINT [FK_PassDocument_Pass] FOREIGN KEY([PassId])
REFERENCES [dbo].[Pass] ([int])
GO
ALTER TABLE [dbo].[PassDocument] CHECK CONSTRAINT [FK_PassDocument_Pass]
GO
ALTER TABLE [dbo].[PassGuest]  WITH CHECK ADD  CONSTRAINT [FK_PassGuest_Pass] FOREIGN KEY([PassId])
REFERENCES [dbo].[Pass] ([int])
GO
ALTER TABLE [dbo].[PassGuest] CHECK CONSTRAINT [FK_PassGuest_Pass]
GO
USE [master]
GO
ALTER DATABASE [Guardian] SET  READ_WRITE 
GO
