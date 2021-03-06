USE [master]
GO
/****** Object:  Database [VisitMyCities]    Script Date: 15/10/2020 09:58:52 ******/
/*CREATE DATABASE [VisitMyCities]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'VisitMyCities', FILENAME = N'C:\Users\marin\VisitMyCities.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'VisitMyCities_log', FILENAME = N'C:\Users\marin\VisitMyCities_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO*/
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
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 15/10/2020 09:58:53 ******/
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
/****** Object:  Table [dbo].[AspNetRoleClaims]    Script Date: 15/10/2020 09:58:53 ******/
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
/****** Object:  Table [dbo].[AspNetRoles]    Script Date: 15/10/2020 09:58:53 ******/
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
/****** Object:  Table [dbo].[AspNetUserClaims]    Script Date: 15/10/2020 09:58:53 ******/
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
/****** Object:  Table [dbo].[AspNetUserLogins]    Script Date: 15/10/2020 09:58:53 ******/
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
/****** Object:  Table [dbo].[AspNetUserRoles]    Script Date: 15/10/2020 09:58:53 ******/
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
/****** Object:  Table [dbo].[AspNetUsers]    Script Date: 15/10/2020 09:58:53 ******/
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
/****** Object:  Table [dbo].[AspNetUserTokens]    Script Date: 15/10/2020 09:58:53 ******/
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
/****** Object:  Table [dbo].[Batiment]    Script Date: 15/10/2020 09:58:53 ******/
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
/****** Object:  Table [dbo].[BatimentListeDeVoyage]    Script Date: 15/10/2020 09:58:53 ******/
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
/****** Object:  Table [dbo].[DetailArchitectural]    Script Date: 15/10/2020 09:58:53 ******/
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
/****** Object:  Table [dbo].[ListeDeVoyage]    Script Date: 15/10/2020 09:58:53 ******/
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
/****** Object:  Table [dbo].[Ville]    Script Date: 15/10/2020 09:58:53 ******/
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
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20200518144757_ModifyBatimentMigration', N'3.1.3')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20200520091423_AjoutNomMaire', N'3.1.3')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20200706134005_AddingIdentity', N'3.1.5')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20200820153446_ListeDeVoyage', N'3.1.5')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20200910083307_AjouterBlason', N'3.1.7')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20200929161638_BatimentListedeVoyage', N'3.1.8')
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [Discriminator], [NomUtilisateur], [Password], [PrenomUtilisateur], [SeSouvenir]) VALUES (N'87152786-8528-42fb-96dd-470b744f4489', N'Marina', N'MARINA', NULL, N'MARINA.PHILIPPE@OUTLOOK.COM', 0, N'AQAAAAEAACcQAAAAEJS+XtZF+rswuiAJD/EjjaHFswNN9BEnhF/KAD5llSduE8ILX0AeCQ41LI4C0bEp5A==', N'WZYQPGNYARDSQV4RDQIF4AKF6ZK2MCO7', N'd83ba3f9-7a02-4086-aa92-8a80048d3279', NULL, 0, 0, NULL, 1, 0, N'Utilisateur', N'PHILIPPE', NULL, N'Marina', 0)
SET IDENTITY_INSERT [dbo].[Batiment] ON 

INSERT [dbo].[Batiment] ([BatimentId], [NomBatiment], [Adresse], [URLPhoto], [TypeBatiment], [DescriptionBatiment], [Longitude], [Latitude], [MonumentHistorique], [DateConstruction], [VilleId]) VALUES (1, N'Koifhus', NULL, N'assets/img/batiments/koifhus_colmar.jpg', N'Ancienne douane', N'Le Koïfhus est un monument historique situé à Colmar, dans le département français du Haut-Rhin. C''est le plus ancien bâtiment public local', NULL, NULL, NULL, N'1480', 1)
INSERT [dbo].[Batiment] ([BatimentId], [NomBatiment], [Adresse], [URLPhoto], [TypeBatiment], [DescriptionBatiment], [Longitude], [Latitude], [MonumentHistorique], [DateConstruction], [VilleId]) VALUES (2, N'Musée Unterlinden', NULL, N'assets/img/batiments/musee-unterlinden-colmar.jpg', N'Musée', N'Le musée Unterlinden est un musée d''association situé dans la ville alsacienne de Colmar. C''est l''un des musées de beaux-arts de province le plus visité.', NULL, NULL, NULL, N'1849', 1)
INSERT [dbo].[Batiment] ([BatimentId], [NomBatiment], [Adresse], [URLPhoto], [TypeBatiment], [DescriptionBatiment], [Longitude], [Latitude], [MonumentHistorique], [DateConstruction], [VilleId]) VALUES (3, N'Eglise protestante Saint-Pierre-le-Jeune', NULL, NULL, N'Eglise', N'Trois églises ont été construites successivement au même endroit. Au début du Moyen-Âge, une petite église, dédiée à Saint Colomban - ou Sainte Colombe ? -, dont il subsiste sous le bas-côté extérieur Sud un caveau. En 1031 fut commencée la construction d’une église romane, pour un chapître de chanoines. Il en reste le cloître et les étages inférieurs du clocher.', NULL, NULL, NULL, N'1031', 2)
INSERT [dbo].[Batiment] ([BatimentId], [NomBatiment], [Adresse], [URLPhoto], [TypeBatiment], [DescriptionBatiment], [Longitude], [Latitude], [MonumentHistorique], [DateConstruction], [VilleId]) VALUES (4, N'Cathédrale Notre Dame', NULL, NULL, N'Cathédrale', N'De votre premier aperçu de la magnifique structure de pâtés de maisons à une vue époustouflante lorsque vous entrez sur la place qui entoure ce gigantesque monument gothique presque étrange, il est vraiment impressionnant !', NULL, NULL, NULL, N'1015', 2)
INSERT [dbo].[Batiment] ([BatimentId], [NomBatiment], [Adresse], [URLPhoto], [TypeBatiment], [DescriptionBatiment], [Longitude], [Latitude], [MonumentHistorique], [DateConstruction], [VilleId]) VALUES (5, N'Palais du Rhin', NULL, NULL, N'Ancien palais', N'Le palais du Rhin, ancien palais impérial, se situe à Strasbourg, dans la Neustadt, sur la place de la République qu’il domine de son imposante coupole. Avec le grand jardin qui l’entoure et les anciennes écuries situées derrière le bâtiment, il forme l’un des ensembles les plus complets et les plus emblématiques de l''architecture allemande de la fin du XIXᵉ siècle.', NULL, NULL, NULL, N'1883', 2)
INSERT [dbo].[Batiment] ([BatimentId], [NomBatiment], [Adresse], [URLPhoto], [TypeBatiment], [DescriptionBatiment], [Longitude], [Latitude], [MonumentHistorique], [DateConstruction], [VilleId]) VALUES (6, N'Pont de l''Europe', NULL, NULL, N'Pont', N'Le pont de l''Europe de Strasbourg - Kehl est un pont routier frontalier entre l''Allemagne et la France au-dessus du Rhin.', NULL, NULL, NULL, N'2005', 2)
INSERT [dbo].[Batiment] ([BatimentId], [NomBatiment], [Adresse], [URLPhoto], [TypeBatiment], [DescriptionBatiment], [Longitude], [Latitude], [MonumentHistorique], [DateConstruction], [VilleId]) VALUES (7, N'Église Catholique Saint-Pierre-le-Vieux', NULL, NULL, N'Eglise', N'L''église Saint-Pierre-le-Vieux de Strasbourg se situe place Saint-Pierre-le-Vieux, au bout de la rue du 22-Novembre et de la Grand''rue dans le centre historique de la ville. La partie de l''église côté rue du 22-Novembre est affectée au culte catholique tandis que la partie donnant sur la Grand''rue est affectée au culte protestant.', NULL, NULL, NULL, N'1381', 2)
INSERT [dbo].[Batiment] ([BatimentId], [NomBatiment], [Adresse], [URLPhoto], [TypeBatiment], [DescriptionBatiment], [Longitude], [Latitude], [MonumentHistorique], [DateConstruction], [VilleId]) VALUES (8, N'Musée Zoologique de Strasbourg', NULL, NULL, N'Musée', N'Le musée zoologique de la ville de Strasbourg présente des collections de zoologie appartenant à la ville de Strasbourg et gérées par l''université de Strasbourg. Il est situé boulevard de la Victoire à proximité du campus historique', NULL, NULL, NULL, N'1804', 2)
SET IDENTITY_INSERT [dbo].[Batiment] OFF
INSERT [dbo].[BatimentListeDeVoyage] ([BatimentId], [IdListe]) VALUES (1, 7)
INSERT [dbo].[BatimentListeDeVoyage] ([BatimentId], [IdListe]) VALUES (2, 7)
SET IDENTITY_INSERT [dbo].[DetailArchitectural] ON 

INSERT [dbo].[DetailArchitectural] ([DetailId], [NomDetail], [DescriptionDetail], [BatimentId]) VALUES (1, N'Orgue Silbermann', N'Orgue de Jean André Silbermann (restauré en 1950 et 1966) dont la notoriété dépasse la région. Helmut Walcha y a enregistré un grand nombre de ses interprétations des œuvres pour orgue de Bach.', 3)
INSERT [dbo].[DetailArchitectural] ([DetailId], [NomDetail], [DescriptionDetail], [BatimentId]) VALUES (2, N'Portail principal', N'En 1897-1901 l''église, en partie ruinée, fut complètement restaurée par le professeur Carl Schäfer (de), professeur à la Technische Hochschule de Karlsruhe. L''entrée entre autres fut alors déplacée latéralement et un nouveau portail principal fut créé, sur le modèle du portail nord de la façade de la cathédrale de Strasbourg.', 3)
INSERT [dbo].[DetailArchitectural] ([DetailId], [NomDetail], [DescriptionDetail], [BatimentId]) VALUES (3, N'Vitraux', N'Vitraux des Empereurs.', 4)
INSERT [dbo].[DetailArchitectural] ([DetailId], [NomDetail], [DescriptionDetail], [BatimentId]) VALUES (4, N'Tapisseries', N'Tapisseries du xviie siècle représentant les Scènes de la vie de la Vierge.', 4)
INSERT [dbo].[DetailArchitectural] ([DetailId], [NomDetail], [DescriptionDetail], [BatimentId]) VALUES (5, N'Horloge Astronomique', N'L''Horloge astronomique de la Cathédrale Notre-Dame de Strasbourg est un chef-d''œuvre de la Renaissance, considéré à l''époque comme faisant partie des sept merveilles de l''Allemagne1. Elle est classée monument historique depuis le 15 avril 1987.', 4)
INSERT [dbo].[DetailArchitectural] ([DetailId], [NomDetail], [DescriptionDetail], [BatimentId]) VALUES (6, N'Autel', N'Autel baroque de la chapelle Saint-Laurent.', 4)
INSERT [dbo].[DetailArchitectural] ([DetailId], [NomDetail], [DescriptionDetail], [BatimentId]) VALUES (7, N'Hall d''entrée', N'Au rez-de-chaussée, le hall d''entrée s''ouvre sur deux vestibules latéraux surélevés conduisant aux doubles appartements réservés, à l''origine, à un couple princier, au sud, et à un hôte de marque, au nord.', 5)
INSERT [dbo].[DetailArchitectural] ([DetailId], [NomDetail], [DescriptionDetail], [BatimentId]) VALUES (8, N'Décor du salon de l''impératrice', N'Le décor du salon de l''impératrice, d''esprit rococo, se démarque résolument de l''inspiration Renaissance qui a présidé à la décoration intérieure. Le plafond peint, les portes blanches rechampies surmontées de panneaux peints et la cheminée en marbre blanc confèrent à l''ensemble une atmosphère chaleureuse et gaie qui contraste avec les autres pièces du palais.', 5)
INSERT [dbo].[DetailArchitectural] ([DetailId], [NomDetail], [DescriptionDetail], [BatimentId]) VALUES (9, N'Reconstitution', N'Reconstitution du cabinet d''histoire naturelle de Jean Hermann avec de nombreux documents et spécimens d''époque en situation.', 8)
INSERT [dbo].[DetailArchitectural] ([DetailId], [NomDetail], [DescriptionDetail], [BatimentId]) VALUES (10, N'Collections', N'Le musée présente des collections très variées et riches d''oiseaux, mammifères, invertébrés marins et insectes, avec un accent tout particulier sur la faune alsacienne.', 8)
SET IDENTITY_INSERT [dbo].[DetailArchitectural] OFF
SET IDENTITY_INSERT [dbo].[ListeDeVoyage] ON 

INSERT [dbo].[ListeDeVoyage] ([IdListe], [TitreListe], [VilleId], [UtilisateurId], [URLBlason]) VALUES (7, N'Balade à Colmar', 1, NULL, N'assets/img/blasons/818px-Blason_Colmar.png')
SET IDENTITY_INSERT [dbo].[ListeDeVoyage] OFF
SET IDENTITY_INSERT [dbo].[Ville] ON 

INSERT [dbo].[Ville] ([VilleId], [NomVille], [NomRegion], [NumDepartement], [NomDepartement], [NomMaire], [Blason]) VALUES (1, N'Colmar', N'Alsace', 68, N'Haut-Rhin', NULL, NULL)
INSERT [dbo].[Ville] ([VilleId], [NomVille], [NomRegion], [NumDepartement], [NomDepartement], [NomMaire], [Blason]) VALUES (2, N'Strasbourg', N'Alsace', 67, N'Bas-Rhin', NULL, NULL)
SET IDENTITY_INSERT [dbo].[Ville] OFF
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetRoleClaims_RoleId]    Script Date: 15/10/2020 09:58:53 ******/
CREATE NONCLUSTERED INDEX [IX_AspNetRoleClaims_RoleId] ON [dbo].[AspNetRoleClaims]
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [RoleNameIndex]    Script Date: 15/10/2020 09:58:53 ******/
CREATE UNIQUE NONCLUSTERED INDEX [RoleNameIndex] ON [dbo].[AspNetRoles]
(
	[NormalizedName] ASC
)
WHERE ([NormalizedName] IS NOT NULL)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetUserClaims_UserId]    Script Date: 15/10/2020 09:58:53 ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserClaims_UserId] ON [dbo].[AspNetUserClaims]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetUserLogins_UserId]    Script Date: 15/10/2020 09:58:53 ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserLogins_UserId] ON [dbo].[AspNetUserLogins]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetUserRoles_RoleId]    Script Date: 15/10/2020 09:58:53 ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserRoles_RoleId] ON [dbo].[AspNetUserRoles]
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [EmailIndex]    Script Date: 15/10/2020 09:58:53 ******/
CREATE NONCLUSTERED INDEX [EmailIndex] ON [dbo].[AspNetUsers]
(
	[NormalizedEmail] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UserNameIndex]    Script Date: 15/10/2020 09:58:53 ******/
CREATE UNIQUE NONCLUSTERED INDEX [UserNameIndex] ON [dbo].[AspNetUsers]
(
	[NormalizedUserName] ASC
)
WHERE ([NormalizedUserName] IS NOT NULL)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Batiment_VilleId]    Script Date: 15/10/2020 09:58:53 ******/
CREATE NONCLUSTERED INDEX [IX_Batiment_VilleId] ON [dbo].[Batiment]
(
	[VilleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_BatimentListeDeVoyage_IdListe]    Script Date: 15/10/2020 09:58:53 ******/
CREATE NONCLUSTERED INDEX [IX_BatimentListeDeVoyage_IdListe] ON [dbo].[BatimentListeDeVoyage]
(
	[IdListe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_DetailArchitectural_BatimentId]    Script Date: 15/10/2020 09:58:53 ******/
CREATE NONCLUSTERED INDEX [IX_DetailArchitectural_BatimentId] ON [dbo].[DetailArchitectural]
(
	[BatimentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_ListeDeVoyage_UtilisateurId]    Script Date: 15/10/2020 09:58:53 ******/
CREATE NONCLUSTERED INDEX [IX_ListeDeVoyage_UtilisateurId] ON [dbo].[ListeDeVoyage]
(
	[UtilisateurId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_ListeDeVoyage_VilleId]    Script Date: 15/10/2020 09:58:53 ******/
CREATE NONCLUSTERED INDEX [IX_ListeDeVoyage_VilleId] ON [dbo].[ListeDeVoyage]
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
USE [master]
GO
ALTER DATABASE [VisitMyCities] SET  READ_WRITE 
GO
