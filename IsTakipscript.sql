USE [GITakipDB]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 22.07.2020 12:41:27 ******/
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
/****** Object:  Table [dbo].[AylikIsTBLs]    Script Date: 22.07.2020 12:41:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AylikIsTBLs](
	[AylikID] [int] IDENTITY(1,1) NOT NULL,
	[IsBasligi] [nvarchar](max) NULL,
	[Aciklama] [nvarchar](max) NULL,
	[BaslamaTarihi] [datetime2](7) NOT NULL,
	[BitisTarihi] [datetime2](7) NOT NULL,
	[KullaniciID] [int] NOT NULL,
	[KullaniciTBLKullaniciID] [int] NULL,
 CONSTRAINT [PK_AylikIsTBLs] PRIMARY KEY CLUSTERED 
(
	[AylikID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GunlukIsTBLs]    Script Date: 22.07.2020 12:41:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GunlukIsTBLs](
	[GunlukID] [int] IDENTITY(1,1) NOT NULL,
	[IsBasligi] [nvarchar](max) NULL,
	[Aciklama] [nvarchar](max) NULL,
	[BaslamaTarihi] [datetime2](7) NOT NULL,
	[BitisTarihi] [datetime2](7) NOT NULL,
	[KullaniciID] [int] NOT NULL,
	[KullaniciTBLKullaniciID] [int] NULL,
 CONSTRAINT [PK_GunlukIsTBLs] PRIMARY KEY CLUSTERED 
(
	[GunlukID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HaftalikIsTBLs]    Script Date: 22.07.2020 12:41:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HaftalikIsTBLs](
	[HaftlikID] [int] IDENTITY(1,1) NOT NULL,
	[IsBasligi] [nvarchar](max) NULL,
	[Aciklama] [nvarchar](max) NULL,
	[BaslamaTarihi] [datetime2](7) NOT NULL,
	[BitisTarihi] [datetime2](7) NOT NULL,
	[KullaniciID] [int] NOT NULL,
	[KullaniciTBLKullaniciID] [int] NULL,
 CONSTRAINT [PK_HaftalikIsTBLs] PRIMARY KEY CLUSTERED 
(
	[HaftlikID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KullaniciTBLs]    Script Date: 22.07.2020 12:41:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KullaniciTBLs](
	[KullaniciID] [int] IDENTITY(1,1) NOT NULL,
	[KullaniciAd] [nvarchar](max) NULL,
	[KullaniciSoyad] [nvarchar](max) NULL,
	[Mail] [nvarchar](max) NULL,
	[Sifre] [nvarchar](max) NULL,
 CONSTRAINT [PK_KullaniciTBLs] PRIMARY KEY CLUSTERED 
(
	[KullaniciID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NotTBLs]    Script Date: 22.07.2020 12:41:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NotTBLs](
	[NotID] [int] IDENTITY(1,1) NOT NULL,
	[NotBasligi] [nvarchar](max) NULL,
	[NotAlinmaTarih] [datetime2](7) NOT NULL,
	[KullaniciID] [int] NOT NULL,
	[NotIcerik] [nvarchar](max) NULL,
 CONSTRAINT [PK_NotTBLs] PRIMARY KEY CLUSTERED 
(
	[NotID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[AylikIsTBLs]  WITH CHECK ADD  CONSTRAINT [FK_AylikIsTBLs_KullaniciTBLs_KullaniciTBLKullaniciID] FOREIGN KEY([KullaniciTBLKullaniciID])
REFERENCES [dbo].[KullaniciTBLs] ([KullaniciID])
GO
ALTER TABLE [dbo].[AylikIsTBLs] CHECK CONSTRAINT [FK_AylikIsTBLs_KullaniciTBLs_KullaniciTBLKullaniciID]
GO
ALTER TABLE [dbo].[GunlukIsTBLs]  WITH CHECK ADD  CONSTRAINT [FK_GunlukIsTBLs_KullaniciTBLs_KullaniciTBLKullaniciID] FOREIGN KEY([KullaniciTBLKullaniciID])
REFERENCES [dbo].[KullaniciTBLs] ([KullaniciID])
GO
ALTER TABLE [dbo].[GunlukIsTBLs] CHECK CONSTRAINT [FK_GunlukIsTBLs_KullaniciTBLs_KullaniciTBLKullaniciID]
GO
ALTER TABLE [dbo].[HaftalikIsTBLs]  WITH CHECK ADD  CONSTRAINT [FK_HaftalikIsTBLs_KullaniciTBLs_KullaniciTBLKullaniciID] FOREIGN KEY([KullaniciTBLKullaniciID])
REFERENCES [dbo].[KullaniciTBLs] ([KullaniciID])
GO
ALTER TABLE [dbo].[HaftalikIsTBLs] CHECK CONSTRAINT [FK_HaftalikIsTBLs_KullaniciTBLs_KullaniciTBLKullaniciID]
GO
ALTER TABLE [dbo].[NotTBLs]  WITH CHECK ADD  CONSTRAINT [FK_NotTBLs_KullaniciTBLs_KullaniciID] FOREIGN KEY([KullaniciID])
REFERENCES [dbo].[KullaniciTBLs] ([KullaniciID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[NotTBLs] CHECK CONSTRAINT [FK_NotTBLs_KullaniciTBLs_KullaniciID]
GO
