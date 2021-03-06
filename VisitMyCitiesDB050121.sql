USE [master]
GO
/****** Object:  Database [VisitMyCities]    Script Date: 05/01/2021 16:21:28 ******/
CREATE DATABASE [VisitMyCities]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'VisitMyCities', FILENAME = N'C:\Users\marin\VisitMyCities.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'VisitMyCities_log', FILENAME = N'C:\Users\marin\VisitMyCities_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [VisitMyCities] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [VisitMyCities].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [VisitMyCities] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [VisitMyCities] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [VisitMyCities] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [VisitMyCities] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [VisitMyCities] SET ARITHABORT OFF 
GO
ALTER DATABASE [VisitMyCities] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [VisitMyCities] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [VisitMyCities] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [VisitMyCities] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [VisitMyCities] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [VisitMyCities] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [VisitMyCities] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [VisitMyCities] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [VisitMyCities] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [VisitMyCities] SET  ENABLE_BROKER 
GO
ALTER DATABASE [VisitMyCities] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [VisitMyCities] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [VisitMyCities] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [VisitMyCities] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [VisitMyCities] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [VisitMyCities] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [VisitMyCities] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [VisitMyCities] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [VisitMyCities] SET  MULTI_USER 
GO
ALTER DATABASE [VisitMyCities] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [VisitMyCities] SET DB_CHAINING OFF 
GO
ALTER DATABASE [VisitMyCities] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [VisitMyCities] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [VisitMyCities] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [VisitMyCities] SET QUERY_STORE = OFF
GO
USE [VisitMyCities]
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [VisitMyCities]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 05/01/2021 16:21:28 ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetRoleClaims]    Script Date: 05/01/2021 16:21:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoleClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetRoleClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetRoles]    Script Date: 05/01/2021 16:21:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoles](
	[Id] [nvarchar](450) NOT NULL,
	[Name] [nvarchar](256) NULL,
	[NormalizedName] [nvarchar](256) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetRoles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserClaims]    Script Date: 05/01/2021 16:21:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [nvarchar](450) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUserClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserLogins]    Script Date: 05/01/2021 16:21:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserLogins](
	[LoginProvider] [nvarchar](450) NOT NULL,
	[ProviderKey] [nvarchar](450) NOT NULL,
	[ProviderDisplayName] [nvarchar](max) NULL,
	[UserId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_AspNetUserLogins] PRIMARY KEY CLUSTERED 
(
	[LoginProvider] ASC,
	[ProviderKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserRoles]    Script Date: 05/01/2021 16:21:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserRoles](
	[UserId] [nvarchar](450) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_AspNetUserRoles] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUsers]    Script Date: 05/01/2021 16:21:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUsers](
	[Id] [nvarchar](450) NOT NULL,
	[UserName] [nvarchar](256) NULL,
	[NormalizedUserName] [nvarchar](256) NULL,
	[Email] [nvarchar](256) NULL,
	[NormalizedEmail] [nvarchar](256) NULL,
	[EmailConfirmed] [bit] NOT NULL,
	[PasswordHash] [nvarchar](max) NULL,
	[SecurityStamp] [nvarchar](max) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
	[PhoneNumber] [nvarchar](max) NULL,
	[PhoneNumberConfirmed] [bit] NOT NULL,
	[TwoFactorEnabled] [bit] NOT NULL,
	[LockoutEnd] [datetimeoffset](7) NULL,
	[LockoutEnabled] [bit] NOT NULL,
	[AccessFailedCount] [int] NOT NULL,
	[Discriminator] [nvarchar](max) NOT NULL,
	[NomUtilisateur] [nvarchar](max) NULL,
	[Password] [nvarchar](max) NULL,
	[PrenomUtilisateur] [nvarchar](max) NULL,
	[SeSouvenir] [bit] NULL,
 CONSTRAINT [PK_AspNetUsers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserTokens]    Script Date: 05/01/2021 16:21:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserTokens](
	[UserId] [nvarchar](450) NOT NULL,
	[LoginProvider] [nvarchar](450) NOT NULL,
	[Name] [nvarchar](450) NOT NULL,
	[Value] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUserTokens] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[LoginProvider] ASC,
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Batiment]    Script Date: 05/01/2021 16:21:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Batiment](
	[BatimentId] [int] IDENTITY(1,1) NOT NULL,
	[NomBatiment] [nvarchar](max) NULL,
	[Adresse] [nvarchar](max) NULL,
	[URLPhoto] [nvarchar](max) NULL,
	[TypeBatiment] [nvarchar](max) NULL,
	[DescriptionBatiment] [nvarchar](max) NULL,
	[Longitude] [float] NULL,
	[Latitude] [float] NULL,
	[MonumentHistorique] [bit] NULL,
	[DateConstruction] [nvarchar](max) NULL,
	[VilleId] [int] NOT NULL,
 CONSTRAINT [PK_Batiment] PRIMARY KEY CLUSTERED 
(
	[BatimentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BatimentListeDeVoyage]    Script Date: 05/01/2021 16:21:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BatimentListeDeVoyage](
	[BatimentId] [int] NOT NULL,
	[IdListe] [int] NOT NULL,
 CONSTRAINT [PK_BatimentListeDeVoyage] PRIMARY KEY CLUSTERED 
(
	[BatimentId] ASC,
	[IdListe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DetailArchitectural]    Script Date: 05/01/2021 16:21:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DetailArchitectural](
	[DetailId] [int] IDENTITY(1,1) NOT NULL,
	[NomDetail] [nvarchar](max) NULL,
	[DescriptionDetail] [nvarchar](max) NULL,
	[BatimentId] [int] NOT NULL,
 CONSTRAINT [PK_DetailArchitectural] PRIMARY KEY CLUSTERED 
(
	[DetailId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ListeDeVoyage]    Script Date: 05/01/2021 16:21:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ListeDeVoyage](
	[IdListe] [int] IDENTITY(1,1) NOT NULL,
	[TitreListe] [nvarchar](max) NULL,
	[VilleId] [int] NOT NULL,
	[UtilisateurId] [nvarchar](450) NULL,
	[URLBlason] [nvarchar](max) NULL,
 CONSTRAINT [PK_ListeDeVoyage] PRIMARY KEY CLUSTERED 
(
	[IdListe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UtilisateurBatiment]    Script Date: 05/01/2021 16:21:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UtilisateurBatiment](
	[BatimentId] [int] NOT NULL,
	[UtilisateurId] [nvarchar](450) NOT NULL,
	[NombreEtoiles] [int] NOT NULL,
	[Commentaire] [nvarchar](max) NULL,
 CONSTRAINT [PK_UtilisateurBatiment] PRIMARY KEY CLUSTERED 
(
	[UtilisateurId] ASC,
	[BatimentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UtilisateurVille]    Script Date: 05/01/2021 16:21:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UtilisateurVille](
	[VilleId] [int] NOT NULL,
	[UtilisateurId] [nvarchar](450) NOT NULL,
	[NombreEtoiles] [int] NOT NULL,
	[Commentaire] [nvarchar](max) NULL,
 CONSTRAINT [PK_UtilisateurVille] PRIMARY KEY CLUSTERED 
(
	[UtilisateurId] ASC,
	[VilleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ville]    Script Date: 05/01/2021 16:21:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ville](
	[VilleId] [int] IDENTITY(1,1) NOT NULL,
	[NomVille] [nvarchar](max) NOT NULL,
	[NomRegion] [nvarchar](max) NULL,
	[NumDepartement] [int] NOT NULL,
	[NomDepartement] [nvarchar](max) NULL,
	[NomMaire] [nvarchar](max) NULL,
	[Blason] [nvarchar](max) NULL,
 CONSTRAINT [PK_Ville] PRIMARY KEY CLUSTERED 
(
	[VilleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetRoleClaims_RoleId]    Script Date: 05/01/2021 16:21:29 ******/
CREATE NONCLUSTERED INDEX [IX_AspNetRoleClaims_RoleId] ON [dbo].[AspNetRoleClaims]
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [RoleNameIndex]    Script Date: 05/01/2021 16:21:29 ******/
CREATE UNIQUE NONCLUSTERED INDEX [RoleNameIndex] ON [dbo].[AspNetRoles]
(
	[NormalizedName] ASC
)
WHERE ([NormalizedName] IS NOT NULL)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetUserClaims_UserId]    Script Date: 05/01/2021 16:21:29 ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserClaims_UserId] ON [dbo].[AspNetUserClaims]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetUserLogins_UserId]    Script Date: 05/01/2021 16:21:29 ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserLogins_UserId] ON [dbo].[AspNetUserLogins]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetUserRoles_RoleId]    Script Date: 05/01/2021 16:21:29 ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserRoles_RoleId] ON [dbo].[AspNetUserRoles]
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [EmailIndex]    Script Date: 05/01/2021 16:21:29 ******/
CREATE NONCLUSTERED INDEX [EmailIndex] ON [dbo].[AspNetUsers]
(
	[NormalizedEmail] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UserNameIndex]    Script Date: 05/01/2021 16:21:29 ******/
CREATE UNIQUE NONCLUSTERED INDEX [UserNameIndex] ON [dbo].[AspNetUsers]
(
	[NormalizedUserName] ASC
)
WHERE ([NormalizedUserName] IS NOT NULL)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Batiment_VilleId]    Script Date: 05/01/2021 16:21:29 ******/
CREATE NONCLUSTERED INDEX [IX_Batiment_VilleId] ON [dbo].[Batiment]
(
	[VilleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_BatimentListeDeVoyage_IdListe]    Script Date: 05/01/2021 16:21:29 ******/
CREATE NONCLUSTERED INDEX [IX_BatimentListeDeVoyage_IdListe] ON [dbo].[BatimentListeDeVoyage]
(
	[IdListe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_DetailArchitectural_BatimentId]    Script Date: 05/01/2021 16:21:29 ******/
CREATE NONCLUSTERED INDEX [IX_DetailArchitectural_BatimentId] ON [dbo].[DetailArchitectural]
(
	[BatimentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_ListeDeVoyage_UtilisateurId]    Script Date: 05/01/2021 16:21:29 ******/
CREATE NONCLUSTERED INDEX [IX_ListeDeVoyage_UtilisateurId] ON [dbo].[ListeDeVoyage]
(
	[UtilisateurId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_ListeDeVoyage_VilleId]    Script Date: 05/01/2021 16:21:29 ******/
CREATE NONCLUSTERED INDEX [IX_ListeDeVoyage_VilleId] ON [dbo].[ListeDeVoyage]
(
	[VilleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_UtilisateurBatiment_BatimentId]    Script Date: 05/01/2021 16:21:29 ******/
CREATE NONCLUSTERED INDEX [IX_UtilisateurBatiment_BatimentId] ON [dbo].[UtilisateurBatiment]
(
	[BatimentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_UtilisateurVille_VilleId]    Script Date: 05/01/2021 16:21:29 ******/
CREATE NONCLUSTERED INDEX [IX_UtilisateurVille_VilleId] ON [dbo].[UtilisateurVille]
(
	[VilleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[AspNetUsers] ADD  DEFAULT (N'') FOR [Discriminator]
GO
ALTER TABLE [dbo].[AspNetRoleClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetRoleClaims] CHECK CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserClaims] CHECK CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserLogins]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserLogins] CHECK CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserTokens]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserTokens] CHECK CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[Batiment]  WITH CHECK ADD  CONSTRAINT [FK_Batiment_Ville_VilleId] FOREIGN KEY([VilleId])
REFERENCES [dbo].[Ville] ([VilleId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Batiment] CHECK CONSTRAINT [FK_Batiment_Ville_VilleId]
GO
ALTER TABLE [dbo].[BatimentListeDeVoyage]  WITH CHECK ADD  CONSTRAINT [FK_BatimentListeDeVoyage_Batiment_BatimentId] FOREIGN KEY([BatimentId])
REFERENCES [dbo].[Batiment] ([BatimentId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[BatimentListeDeVoyage] CHECK CONSTRAINT [FK_BatimentListeDeVoyage_Batiment_BatimentId]
GO
ALTER TABLE [dbo].[BatimentListeDeVoyage]  WITH CHECK ADD  CONSTRAINT [FK_BatimentListeDeVoyage_ListeDeVoyage_IdListe] FOREIGN KEY([IdListe])
REFERENCES [dbo].[ListeDeVoyage] ([IdListe])
GO
ALTER TABLE [dbo].[BatimentListeDeVoyage] CHECK CONSTRAINT [FK_BatimentListeDeVoyage_ListeDeVoyage_IdListe]
GO
ALTER TABLE [dbo].[DetailArchitectural]  WITH CHECK ADD  CONSTRAINT [FK_DetailArchitectural_Batiment_BatimentId] FOREIGN KEY([BatimentId])
REFERENCES [dbo].[Batiment] ([BatimentId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[DetailArchitectural] CHECK CONSTRAINT [FK_DetailArchitectural_Batiment_BatimentId]
GO
ALTER TABLE [dbo].[ListeDeVoyage]  WITH CHECK ADD  CONSTRAINT [FK_ListeDeVoyage_AspNetUsers_UtilisateurId] FOREIGN KEY([UtilisateurId])
REFERENCES [dbo].[AspNetUsers] ([Id])
GO
ALTER TABLE [dbo].[ListeDeVoyage] CHECK CONSTRAINT [FK_ListeDeVoyage_AspNetUsers_UtilisateurId]
GO
ALTER TABLE [dbo].[ListeDeVoyage]  WITH CHECK ADD  CONSTRAINT [FK_ListeDeVoyage_Ville_VilleId] FOREIGN KEY([VilleId])
REFERENCES [dbo].[Ville] ([VilleId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ListeDeVoyage] CHECK CONSTRAINT [FK_ListeDeVoyage_Ville_VilleId]
GO
ALTER TABLE [dbo].[UtilisateurBatiment]  WITH CHECK ADD  CONSTRAINT [FK_UtilisateurBatiment_AspNetUsers_UtilisateurId] FOREIGN KEY([UtilisateurId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[UtilisateurBatiment] CHECK CONSTRAINT [FK_UtilisateurBatiment_AspNetUsers_UtilisateurId]
GO
ALTER TABLE [dbo].[UtilisateurBatiment]  WITH CHECK ADD  CONSTRAINT [FK_UtilisateurBatiment_Batiment_BatimentId] FOREIGN KEY([BatimentId])
REFERENCES [dbo].[Batiment] ([BatimentId])
GO
ALTER TABLE [dbo].[UtilisateurBatiment] CHECK CONSTRAINT [FK_UtilisateurBatiment_Batiment_BatimentId]
GO
ALTER TABLE [dbo].[UtilisateurVille]  WITH CHECK ADD  CONSTRAINT [FK_UtilisateurVille_AspNetUsers_UtilisateurId] FOREIGN KEY([UtilisateurId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[UtilisateurVille] CHECK CONSTRAINT [FK_UtilisateurVille_AspNetUsers_UtilisateurId]
GO
ALTER TABLE [dbo].[UtilisateurVille]  WITH CHECK ADD  CONSTRAINT [FK_UtilisateurVille_Ville_VilleId] FOREIGN KEY([VilleId])
REFERENCES [dbo].[Ville] ([VilleId])
GO
ALTER TABLE [dbo].[UtilisateurVille] CHECK CONSTRAINT [FK_UtilisateurVille_Ville_VilleId]
GO
USE [master]
GO
ALTER DATABASE [VisitMyCities] SET  READ_WRITE 
GO
