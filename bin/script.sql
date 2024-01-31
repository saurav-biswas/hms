USE [master]
GO
/****** Object:  Database [HMS]    Script Date: 11-01-2024 01:16:22 ******/
CREATE DATABASE [HMS]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'HMS', FILENAME = N'D:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\HMS.mdf' , SIZE = 80704KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'HMS_log', FILENAME = N'D:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\HMS_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [HMS] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [HMS].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [HMS] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [HMS] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [HMS] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [HMS] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [HMS] SET ARITHABORT OFF 
GO
ALTER DATABASE [HMS] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [HMS] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [HMS] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [HMS] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [HMS] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [HMS] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [HMS] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [HMS] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [HMS] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [HMS] SET  DISABLE_BROKER 
GO
ALTER DATABASE [HMS] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [HMS] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [HMS] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [HMS] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [HMS] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [HMS] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [HMS] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [HMS] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [HMS] SET  MULTI_USER 
GO
ALTER DATABASE [HMS] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [HMS] SET DB_CHAINING OFF 
GO
ALTER DATABASE [HMS] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [HMS] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [HMS] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [HMS] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [HMS] SET QUERY_STORE = ON
GO
ALTER DATABASE [HMS] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [HMS]
GO
/****** Object:  Table [dbo].[IPD]    Script Date: 11-01-2024 01:16:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[IPD](
	[Id] [varchar](10) NOT NULL,
	[Patient] [nvarchar](50) NOT NULL,
	[Age] [nvarchar](3) NOT NULL,
	[Height] [nvarchar](50) NULL,
	[Weight] [nvarchar](10) NULL,
	[BloodPressure] [nvarchar](20) NULL,
	[PrecheckedBy] [nvarchar](50) NULL,
	[AdmissionDate] [datetime] NOT NULL,
	[Symptoms] [nvarchar](max) NULL,
	[GarName] [nvarchar](50) NOT NULL,
	[GarRelation] [nvarchar](50) NOT NULL,
	[GarPhone] [nvarchar](10) NOT NULL,
	[GarAddress1] [nvarchar](50) NOT NULL,
	[GarAddress2] [nvarchar](50) NOT NULL,
	[GarCity] [nvarchar](50) NOT NULL,
	[GarPIN] [nvarchar](6) NOT NULL,
	[AdmitName] [nvarchar](50) NULL,
	[AdmitRelation] [nvarchar](50) NULL,
	[AdmitPhone] [nvarchar](10) NULL,
	[AdmitAddress1] [nvarchar](50) NULL,
	[AdmitAddress2] [nvarchar](50) NULL,
	[AdmitCity] [nvarchar](50) NULL,
	[AdmitPIN] [nvarchar](6) NULL,
	[PatID] [varchar](10) NOT NULL,
	[Status] [nvarchar](1) NULL,
 CONSTRAINT [PK__IPD__3214EC07B0DD49F9] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PatientMast]    Script Date: 11-01-2024 01:16:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PatientMast](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[PatName] [nvarchar](50) NOT NULL,
	[PatQualification] [nvarchar](50) NULL,
	[PatPhone] [nvarchar](50) NOT NULL,
	[PatEmail] [nvarchar](50) NULL,
	[PatDOB] [date] NULL,
	[PatBloodGroup] [nvarchar](50) NULL,
	[PatGender] [nvarchar](50) NOT NULL,
	[PatAddress1] [nvarchar](50) NULL,
	[PatAddress2] [nvarchar](50) NULL,
	[PatCity] [nvarchar](50) NULL,
	[PatPIN] [numeric](6, 0) NULL,
	[PatRefferedBy] [nvarchar](50) NOT NULL,
	[PatBalAmt] [numeric](18, 0) NULL,
	[PatUnderDr] [nvarchar](50) NULL,
	[PatReligion] [nvarchar](50) NULL,
 CONSTRAINT [PK__PatientM__3214EC0759858905] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[AdmissionView]    Script Date: 11-01-2024 01:16:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[AdmissionView]
AS
SELECT        dbo.IPD.Id, dbo.PatientMast.PatName, dbo.IPD.GarName, dbo.PatientMast.PatAddress1, dbo.PatientMast.PatAddress2, dbo.PatientMast.PatCity, dbo.PatientMast.PatPIN, dbo.IPD.PrecheckedBy, dbo.IPD.AdmissionDate, 
                         dbo.IPD.Age, dbo.PatientMast.PatGender, dbo.PatientMast.PatRefferedBy
FROM            dbo.IPD INNER JOIN
                         dbo.PatientMast ON dbo.IPD.PatID = dbo.PatientMast.Id
GO
/****** Object:  Table [dbo].[Advance]    Script Date: 11-01-2024 01:16:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Advance](
	[Id] [nvarchar](50) NOT NULL,
	[Patient] [nvarchar](50) NOT NULL,
	[AdvAmt] [numeric](18, 0) NOT NULL,
	[PayMode] [nvarchar](50) NOT NULL,
	[PayDate] [date] NOT NULL,
	[PatID] [nvarchar](50) NOT NULL,
	[PatientID] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK__Advance__3214EC0716075680] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BedManagement]    Script Date: 11-01-2024 01:16:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BedManagement](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Patient] [nvarchar](50) NOT NULL,
	[BedType] [nvarchar](50) NOT NULL,
	[BedNo] [nvarchar](50) NOT NULL,
	[FromDate] [date] NOT NULL,
	[BedAmount] [numeric](18, 0) NULL,
	[IPD] [nvarchar](50) NOT NULL,
	[Todate] [date] NULL,
	[Days] [numeric](4, 0) NULL,
	[Rate] [numeric](5, 0) NOT NULL,
	[DrName] [nvarchar](50) NOT NULL,
	[PatientID] [nvarchar](50) NULL,
 CONSTRAINT [PK__BedManag__3214EC076CFC3B63] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BedNumberMast]    Script Date: 11-01-2024 01:16:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BedNumberMast](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[BedNumber] [nvarchar](50) NOT NULL,
	[BedType] [nvarchar](50) NOT NULL,
	[CurrentStatus] [nvarchar](50) NOT NULL,
	[BedRate] [numeric](5, 0) NOT NULL,
 CONSTRAINT [PK__BedNumbe__3214EC078E42349F] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BedTypeMast]    Script Date: 11-01-2024 01:16:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BedTypeMast](
	[Id] [varchar](10) NOT NULL,
	[BedType] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK__BedTypeM__3214EC07F3C83DF7] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BloodGroupMast]    Script Date: 11-01-2024 01:16:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BloodGroupMast](
	[Id] [varchar](10) NOT NULL,
	[BloodGroup] [nchar](10) NOT NULL,
 CONSTRAINT [PK__BloodGro__3214EC07C2CBC498] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Discharge]    Script Date: 11-01-2024 01:16:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Discharge](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Patient] [nvarchar](50) NULL,
	[DischargeBy] [nvarchar](50) NULL,
	[Comment] [nvarchar](max) NULL,
	[NextVisitNo] [numeric](18, 0) NULL,
	[NextVisitUnit] [nchar](10) NULL,
	[DischargeDate] [date] NULL,
	[IPD] [nvarchar](50) NULL,
	[Diagnosis] [nvarchar](max) NULL,
	[AdmissionDt] [date] NULL,
 CONSTRAINT [PK__Discharg__3214EC07C123B656] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DischargeLin]    Script Date: 11-01-2024 01:16:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DischargeLin](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[DisID] [nvarchar](50) NULL,
	[SLNO] [nvarchar](50) NULL,
	[Perticulars] [nvarchar](50) NULL,
 CONSTRAINT [PK__Discharg__3214EC0723AD74A4] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DoctorDepartmentMast]    Script Date: 11-01-2024 01:16:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DoctorDepartmentMast](
	[Id] [varchar](10) NOT NULL,
	[DepartmentName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK__DoctorDe__3214EC0711340A1A] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DoctorMast]    Script Date: 11-01-2024 01:16:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DoctorMast](
	[Id] [varchar](10) NOT NULL,
	[DocName] [nvarchar](50) NOT NULL,
	[DocDesignation] [nvarchar](50) NULL,
	[DocQualification] [nvarchar](50) NULL,
	[DocSpecialist] [nvarchar](50) NULL,
	[DocPhone] [nvarchar](50) NOT NULL,
	[DocEmail] [nvarchar](50) NULL,
	[DocDOB] [date] NULL,
	[DocBloodGroup] [nchar](10) NULL,
	[DocGender] [nchar](10) NOT NULL,
	[DocAddress1] [nvarchar](50) NULL,
	[DocAddress2] [nvarchar](50) NULL,
	[DocCity] [nvarchar](50) NULL,
	[DocPIN] [numeric](18, 0) NULL,
 CONSTRAINT [PK__DoctorMa__3214EC079EC8B211] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FinalBillHdr]    Script Date: 11-01-2024 01:16:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FinalBillHdr](
	[Id] [nchar](10) NOT NULL,
	[IPD] [nchar](10) NOT NULL,
	[BillDate] [date] NOT NULL,
	[TaxRate] [numeric](18, 0) NULL,
	[TaxAmt] [numeric](18, 0) NOT NULL,
	[Concession] [numeric](18, 0) NOT NULL,
	[DrFees] [numeric](18, 0) NOT NULL,
	[Medicine] [numeric](18, 0) NOT NULL,
	[Blood] [numeric](18, 0) NOT NULL,
	[OtherCharges] [numeric](18, 0) NOT NULL,
	[AdvanceReceived] [numeric](18, 0) NOT NULL,
	[TotalReceivable] [numeric](18, 0) NOT NULL,
	[PatientID] [nchar](10) NOT NULL,
	[PatientName] [nchar](50) NOT NULL,
	[PayMode] [nchar](10) NOT NULL,
	[BedTAmt] [numeric](18, 0) NOT NULL,
	[OtherTAmt] [numeric](18, 0) NOT NULL,
	[TaxName] [nchar](15) NULL,
	[DtlTAmt] [numeric](18, 0) NOT NULL,
	[TotalAmt] [numeric](18, 0) NOT NULL,
	[ChargableAmt] [numeric](18, 0) NOT NULL,
 CONSTRAINT [PK__FinalBil__3214EC0746FC7D0F] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FinalBillOtherAmount]    Script Date: 11-01-2024 01:16:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FinalBillOtherAmount](
	[FBOItemsId] [numeric](18, 0) NULL,
	[FBOItemsPerticulars] [nvarchar](50) NULL,
	[FBOItemsAmt] [numeric](18, 0) NULL,
	[FBOItemsTID] [nchar](10) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GRNHdr]    Script Date: 11-01-2024 01:16:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GRNHdr](
	[GRNNo] [nvarchar](50) NOT NULL,
	[SuppCode] [nvarchar](50) NOT NULL,
	[InvNo] [nvarchar](50) NOT NULL,
	[InvDt] [date] NOT NULL,
	[GAmt] [numeric](18, 0) NOT NULL,
	[TaxName] [nvarchar](50) NULL,
	[TaxAmt] [numeric](18, 0) NULL,
	[OtherCharges] [numeric](18, 0) NULL,
	[NAmt] [numeric](18, 0) NOT NULL,
 CONSTRAINT [PK__tmp_ms_x__BC0E85A9B56C3B70] PRIMARY KEY CLUSTERED 
(
	[GRNNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GRNLin]    Script Date: 11-01-2024 01:16:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GRNLin](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[GRNNo] [nvarchar](50) NOT NULL,
	[InvDt] [date] NOT NULL,
	[ItCode] [nvarchar](50) NOT NULL,
	[ItQty] [numeric](18, 0) NOT NULL,
	[ItRate] [numeric](18, 0) NOT NULL,
	[ItAmt] [numeric](18, 0) NOT NULL,
 CONSTRAINT [PK__GRNLin__3214EC079A00923A] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ItCatMast]    Script Date: 11-01-2024 01:16:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ItCatMast](
	[CatID] [nvarchar](50) NOT NULL,
	[CatName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK__tmp_ms_x__6A1C8ADA89F48898] PRIMARY KEY CLUSTERED 
(
	[CatID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ItMast]    Script Date: 11-01-2024 01:16:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ItMast](
	[ItCode] [nvarchar](50) NOT NULL,
	[ItName] [nvarchar](50) NOT NULL,
	[ItCat] [nvarchar](50) NOT NULL,
	[ItRate] [numeric](18, 0) NOT NULL,
	[ItStock] [numeric](18, 0) NOT NULL,
	[ItUnit] [nvarchar](4) NOT NULL,
	[ItAmt] [numeric](18, 0) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ItCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OPD]    Script Date: 11-01-2024 01:16:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OPD](
	[Id] [varchar](10) NOT NULL,
	[Patient] [nvarchar](50) NOT NULL,
	[Age] [numeric](18, 0) NOT NULL,
	[Height] [numeric](18, 0) NULL,
	[Weight] [numeric](18, 0) NULL,
	[BloodPressure] [numeric](18, 0) NULL,
	[Doctor] [nchar](10) NOT NULL,
	[DoctorCharges] [numeric](18, 0) NOT NULL,
	[PaymentMode] [nchar](10) NOT NULL,
	[Symptoms] [nvarchar](max) NULL,
	[OPDDate] [date] NOT NULL,
 CONSTRAINT [PK__OPD__3214EC07206281B7] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Prescription]    Script Date: 11-01-2024 01:16:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Prescription](
	[Id] [varchar](10) NOT NULL,
	[PrescriptionType] [nchar](10) NOT NULL,
	[Patient] [nchar](10) NOT NULL,
	[Doctor] [nchar](10) NOT NULL,
	[BloodPressure] [nchar](10) NULL,
	[FoodAllergies] [nchar](10) NULL,
	[TendencyBleed] [nchar](10) NULL,
	[HeartDisease] [nchar](10) NULL,
	[Diabetic] [nchar](10) NULL,
	[AddedAt] [nchar](10) NULL,
	[FemalePregnancy] [nchar](10) NULL,
	[BreastFeeding] [nchar](10) NULL,
	[CurrentMedication] [nvarchar](50) NULL,
	[Surgery] [nvarchar](50) NULL,
	[Accident] [nvarchar](50) NULL,
	[Others] [nvarchar](max) NULL,
	[PulseRate] [nchar](10) NULL,
	[Temperature] [numeric](18, 0) NULL,
	[ProblemDescription] [nvarchar](max) NULL,
	[Test] [nvarchar](50) NULL,
	[Advice] [nvarchar](max) NULL,
	[NextVisitPeriod] [numeric](18, 0) NULL,
	[NextVisitType] [nchar](10) NULL,
	[PresDate] [date] NULL,
 CONSTRAINT [PK__Prescrip__3214EC07B61F14C0] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PresMed]    Script Date: 11-01-2024 01:16:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PresMed](
	[Id] [nchar](10) NOT NULL,
	[MedicineName] [nvarchar](50) NULL,
	[Dose] [nchar](10) NULL,
	[Duration] [nchar](10) NULL,
	[Timeing] [nchar](10) NULL,
	[DoseIntervel] [nchar](10) NULL,
	[Comment] [nvarchar](50) NULL,
	[PrescriptionID] [nchar](10) NULL,
 CONSTRAINT [PK__PresMed__3214EC0717C8E5B9] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SuppMast]    Script Date: 11-01-2024 01:16:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SuppMast](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[SuppCode] [nvarchar](50) NOT NULL,
	[SuppName] [nvarchar](50) NOT NULL,
	[SuppAddress1] [nvarchar](50) NOT NULL,
	[SuppAddress2] [nvarchar](50) NOT NULL,
	[SuppCity] [nvarchar](50) NOT NULL,
	[SuppPIN] [nvarchar](50) NOT NULL,
	[SuppPhone] [nvarchar](10) NOT NULL,
 CONSTRAINT [PK__SuppMast__3214EC07569375B8] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TaxMast]    Script Date: 11-01-2024 01:16:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaxMast](
	[Id] [varchar](10) NOT NULL,
	[TaxName] [nchar](15) NULL,
	[Percentage] [decimal](18, 0) NULL,
 CONSTRAINT [PK__TaxMaste__3214EC07CEA3EA93] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 11-01-2024 01:16:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[Username] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[Username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[GRNHdr] ADD  CONSTRAINT [DF__tmp_ms_xx__TaxAm__318258D2]  DEFAULT ((0)) FOR [TaxAmt]
GO
ALTER TABLE [dbo].[GRNHdr] ADD  CONSTRAINT [DF__tmp_ms_xx__Other__32767D0B]  DEFAULT ((0)) FOR [OtherCharges]
GO
ALTER TABLE [dbo].[IPD] ADD  DEFAULT ((0)) FOR [Height]
GO
ALTER TABLE [dbo].[IPD] ADD  DEFAULT ((0)) FOR [Weight]
GO
ALTER TABLE [dbo].[IPD] ADD  DEFAULT ((0)) FOR [BloodPressure]
GO
ALTER TABLE [dbo].[ItMast] ADD  DEFAULT ((0)) FOR [ItRate]
GO
ALTER TABLE [dbo].[ItMast] ADD  DEFAULT ((0)) FOR [ItStock]
GO
ALTER TABLE [dbo].[ItMast] ADD  DEFAULT ((0)) FOR [ItAmt]
GO
ALTER TABLE [dbo].[PatientMast] ADD  DEFAULT ((0)) FOR [PatBalAmt]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[41] 4[21] 2[14] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "IPD"
            Begin Extent = 
               Top = 22
               Left = 401
               Bottom = 152
               Right = 571
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "PatientMast"
            Begin Extent = 
               Top = 10
               Left = 86
               Bottom = 140
               Right = 260
            End
            DisplayFlags = 280
            TopColumn = 10
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'AdmissionView'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'AdmissionView'
GO
USE [master]
GO
ALTER DATABASE [HMS] SET  READ_WRITE 
GO
