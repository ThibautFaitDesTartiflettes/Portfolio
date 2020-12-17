USE [master]
GO
/****** Object:  Database [dtb_gesAMM]    Script Date: 13/11/2020 16:44:18 ******/
CREATE DATABASE [dtb_gesAMM]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'dtb_gesAMM', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\dtb_gesAMM.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'dtb_gesAMM_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\dtb_gesAMM_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [dtb_gesAMM] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [dtb_gesAMM].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [dtb_gesAMM] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [dtb_gesAMM] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [dtb_gesAMM] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [dtb_gesAMM] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [dtb_gesAMM] SET ARITHABORT OFF 
GO
ALTER DATABASE [dtb_gesAMM] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [dtb_gesAMM] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [dtb_gesAMM] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [dtb_gesAMM] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [dtb_gesAMM] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [dtb_gesAMM] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [dtb_gesAMM] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [dtb_gesAMM] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [dtb_gesAMM] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [dtb_gesAMM] SET  DISABLE_BROKER 
GO
ALTER DATABASE [dtb_gesAMM] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [dtb_gesAMM] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [dtb_gesAMM] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [dtb_gesAMM] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [dtb_gesAMM] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [dtb_gesAMM] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [dtb_gesAMM] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [dtb_gesAMM] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [dtb_gesAMM] SET  MULTI_USER 
GO
ALTER DATABASE [dtb_gesAMM] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [dtb_gesAMM] SET DB_CHAINING OFF 
GO
ALTER DATABASE [dtb_gesAMM] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [dtb_gesAMM] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [dtb_gesAMM] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [dtb_gesAMM] SET QUERY_STORE = OFF
GO
USE [dtb_gesAMM]
GO
/****** Object:  Table [dbo].[DECISION]    Script Date: 13/11/2020 16:44:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DECISION](
	[DCS_ID] [int] NOT NULL,
	[DCS_LIBELLE] [nvarchar](15) NULL,
 CONSTRAINT [PK_DECISION] PRIMARY KEY CLUSTERED 
(
	[DCS_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ETAPE]    Script Date: 13/11/2020 16:44:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ETAPE](
	[ETP_NUM] [int] NOT NULL,
	[ETP_LIBELLE] [nvarchar](50) NOT NULL,
	[ETP_NORME] [nvarchar](20) NULL,
	[ETP_DATE_NORME] [date] NULL,
 CONSTRAINT [PK_ETAPE] PRIMARY KEY CLUSTERED 
(
	[ETP_NUM] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FAMILLE]    Script Date: 13/11/2020 16:44:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FAMILLE](
	[FAM_CODE] [nvarchar](3) NOT NULL,
	[FAM_LIBELLE] [nvarchar](80) NULL,
	[FAM_NB_MEDI_AMM] [int] NULL,
 CONSTRAINT [PK_FAMILLE] PRIMARY KEY CLUSTERED 
(
	[FAM_CODE] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HISTORIQUE]    Script Date: 13/11/2020 16:44:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HISTORIQUE](
	[HST_NUM] [int] IDENTITY(1,1) NOT NULL,
	[HST_DATE_MODIF] [date] NULL,
	[HST_ETP_DATE_BEFORE] [date] NULL,
	[HST_DATE_AFTER] [date] NULL,
	[HST_UTL] [int] NULL,
	[HST_ETP_NUM] [int] NULL,
	[HST_ETP_NORME_BEFORE] [nvarchar](20) NULL,
	[HST_ETP_NORME_AFTER] [nvarchar](20) NULL,
 CONSTRAINT [PK_HISTORIQUE] PRIMARY KEY CLUSTERED 
(
	[HST_NUM] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MEDICAMENT]    Script Date: 13/11/2020 16:44:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MEDICAMENT](
	[MED_DEPOTLEGAL] [nvarchar](10) NOT NULL,
	[MED_NOMCOMMERCIAL] [nvarchar](25) NULL,
	[MED_COMPOSITION] [nvarchar](255) NULL,
	[MED_EFFETS] [nvarchar](255) NULL,
	[MED_CONTREINDIC] [nvarchar](255) NULL,
	[MED_AMM] [nvarchar](10) NULL,
	[FAM_CODE_MED] [nvarchar](3) NOT NULL,
	[ETP_NUM_MED] [int] NULL,
 CONSTRAINT [PK_MEDICAMENT] PRIMARY KEY CLUSTERED 
(
	[MED_DEPOTLEGAL] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SUBIR]    Script Date: 13/11/2020 16:44:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SUBIR](
	[MED_DEPOTLEGAL_SUB] [nvarchar](10) NOT NULL,
	[ETP_NUM_SUB] [int] NOT NULL,
	[DSC_ID_SUB] [int] NULL,
	[dateDecision] [date] NULL,
 CONSTRAINT [PK_SUBIR] PRIMARY KEY CLUSTERED 
(
	[MED_DEPOTLEGAL_SUB] ASC,
	[ETP_NUM_SUB] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UTILISATEUR]    Script Date: 13/11/2020 16:44:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UTILISATEUR](
	[UTL_NUM] [int] NOT NULL,
	[UTL_LOGIN] [nvarchar](25) NULL,
	[UTL_MDP] [nvarchar](25) NULL,
	[UTL_NOM] [nvarchar](30) NULL,
	[UTL_PRENOM] [nvarchar](25) NULL,
 CONSTRAINT [PK_UTILISATEUR] PRIMARY KEY CLUSTERED 
(
	[UTL_NUM] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[ETAPE] ([ETP_NUM], [ETP_LIBELLE], [ETP_NORME], [ETP_DATE_NORME]) VALUES (1, N'coucou c moi', N'180/2012/CEE', CAST(N'2012-01-05' AS Date))
GO
INSERT [dbo].[FAMILLE] ([FAM_CODE], [FAM_LIBELLE], [FAM_NB_MEDI_AMM]) VALUES (N'AA', N'Antalgiques en association', 0)
INSERT [dbo].[FAMILLE] ([FAM_CODE], [FAM_LIBELLE], [FAM_NB_MEDI_AMM]) VALUES (N'AAA', N'Antalgiques antipyrétiques en association', 0)
INSERT [dbo].[FAMILLE] ([FAM_CODE], [FAM_LIBELLE], [FAM_NB_MEDI_AMM]) VALUES (N'AAC', N'Antidépresseur d''action centrale', 0)
INSERT [dbo].[FAMILLE] ([FAM_CODE], [FAM_LIBELLE], [FAM_NB_MEDI_AMM]) VALUES (N'AAH', N'Antivertigineux antihistaminique H1', 0)
INSERT [dbo].[FAMILLE] ([FAM_CODE], [FAM_LIBELLE], [FAM_NB_MEDI_AMM]) VALUES (N'ABA', N'Antibiotique antituberculeux', 0)
INSERT [dbo].[FAMILLE] ([FAM_CODE], [FAM_LIBELLE], [FAM_NB_MEDI_AMM]) VALUES (N'ABC', N'Antibiotique antiacnéique local', 0)
INSERT [dbo].[FAMILLE] ([FAM_CODE], [FAM_LIBELLE], [FAM_NB_MEDI_AMM]) VALUES (N'ABP', N'Antibiotique de la famille des béta-lactamines (pénicilline A)', 0)
INSERT [dbo].[FAMILLE] ([FAM_CODE], [FAM_LIBELLE], [FAM_NB_MEDI_AMM]) VALUES (N'AFC', N'Antibiotique de la famille des cyclines', 0)
INSERT [dbo].[FAMILLE] ([FAM_CODE], [FAM_LIBELLE], [FAM_NB_MEDI_AMM]) VALUES (N'AFM', N'Antibiotique de la famille des macrolides', 0)
INSERT [dbo].[FAMILLE] ([FAM_CODE], [FAM_LIBELLE], [FAM_NB_MEDI_AMM]) VALUES (N'AH', N'Antihistaminique H1 local', 0)
INSERT [dbo].[FAMILLE] ([FAM_CODE], [FAM_LIBELLE], [FAM_NB_MEDI_AMM]) VALUES (N'AIM', N'Antidépresseur imipraminique (tricyclique)', 0)
INSERT [dbo].[FAMILLE] ([FAM_CODE], [FAM_LIBELLE], [FAM_NB_MEDI_AMM]) VALUES (N'AIN', N'Antidépresseur inhibiteur sélectif de la recapture de la sérotonine', 0)
INSERT [dbo].[FAMILLE] ([FAM_CODE], [FAM_LIBELLE], [FAM_NB_MEDI_AMM]) VALUES (N'ALO', N'Antibiotique local (ORL)', 0)
INSERT [dbo].[FAMILLE] ([FAM_CODE], [FAM_LIBELLE], [FAM_NB_MEDI_AMM]) VALUES (N'ANS', N'Antidépresseur IMAO non sélectif', 0)
INSERT [dbo].[FAMILLE] ([FAM_CODE], [FAM_LIBELLE], [FAM_NB_MEDI_AMM]) VALUES (N'AO', N'Antibiotique ophtalmique', 0)
INSERT [dbo].[FAMILLE] ([FAM_CODE], [FAM_LIBELLE], [FAM_NB_MEDI_AMM]) VALUES (N'AP', N'Antipsychotique normothymique', 0)
INSERT [dbo].[FAMILLE] ([FAM_CODE], [FAM_LIBELLE], [FAM_NB_MEDI_AMM]) VALUES (N'AUM', N'Antibiotique urinaire minute', 0)
INSERT [dbo].[FAMILLE] ([FAM_CODE], [FAM_LIBELLE], [FAM_NB_MEDI_AMM]) VALUES (N'CRT', N'Corticoïde, antibiotique et antifongique à  usage local', 0)
INSERT [dbo].[FAMILLE] ([FAM_CODE], [FAM_LIBELLE], [FAM_NB_MEDI_AMM]) VALUES (N'HYP', N'Hypnotique antihistaminique', 0)
INSERT [dbo].[FAMILLE] ([FAM_CODE], [FAM_LIBELLE], [FAM_NB_MEDI_AMM]) VALUES (N'PSA', N'Psychostimulant, antiasthénique', 0)
GO
SET IDENTITY_INSERT [dbo].[HISTORIQUE] ON 

INSERT [dbo].[HISTORIQUE] ([HST_NUM], [HST_DATE_MODIF], [HST_ETP_DATE_BEFORE], [HST_DATE_AFTER], [HST_UTL], [HST_ETP_NUM], [HST_ETP_NORME_BEFORE], [HST_ETP_NORME_AFTER]) VALUES (5, CAST(N'2020-11-13' AS Date), CAST(N'2020-08-20' AS Date), CAST(N'2004-05-12' AS Date), 1, 1, NULL, N'726/2004/CEE')
INSERT [dbo].[HISTORIQUE] ([HST_NUM], [HST_DATE_MODIF], [HST_ETP_DATE_BEFORE], [HST_DATE_AFTER], [HST_UTL], [HST_ETP_NUM], [HST_ETP_NORME_BEFORE], [HST_ETP_NORME_AFTER]) VALUES (6, CAST(N'2020-11-13' AS Date), CAST(N'2004-05-12' AS Date), CAST(N'2012-01-05' AS Date), 1, 1, N'726/2004/CEE', N'180/2012/CEE')
SET IDENTITY_INSERT [dbo].[HISTORIQUE] OFF
GO
INSERT [dbo].[MEDICAMENT] ([MED_DEPOTLEGAL], [MED_NOMCOMMERCIAL], [MED_COMPOSITION], [MED_EFFETS], [MED_CONTREINDIC], [MED_AMM], [FAM_CODE_MED], [ETP_NUM_MED]) VALUES (N'3MYC7', N'TRIMYCINE', N'Triamcinolone (acétonide) + Néomycine + Nystatine
', N'Ce médicament est un corticoïde à  activité forte ou très forte associé à  un antibiotique et un antifongique, utilisé en application locale dans certaines atteintes cutanées surinfectées.
', N'Ce médicament est contre-indiqué en cas d''allergie à  l''un des constituants, d''infections de la peau ou de parasitisme non traités, d''acné. Ne pas appliquer sur une plaie, ni sous un pansement occlusif.
', NULL, N'CRT', NULL)
INSERT [dbo].[MEDICAMENT] ([MED_DEPOTLEGAL], [MED_NOMCOMMERCIAL], [MED_COMPOSITION], [MED_EFFETS], [MED_CONTREINDIC], [MED_AMM], [FAM_CODE_MED], [ETP_NUM_MED]) VALUES (N'ADIMOL9', N'ADIMOL', N'Amoxicilline + Acide clavulanique
', N'Ce médicament, plus puissant que les pénicillines simples, est utilisé pour traiter des infections bactériennes spécifiques.
', N'Ce médicament est contre-indiqué en cas d''allergie aux pénicillines ou aux céphalosporines.
', NULL, N'ABP', NULL)
INSERT [dbo].[MEDICAMENT] ([MED_DEPOTLEGAL], [MED_NOMCOMMERCIAL], [MED_COMPOSITION], [MED_EFFETS], [MED_CONTREINDIC], [MED_AMM], [FAM_CODE_MED], [ETP_NUM_MED]) VALUES (N'AMOPIL7', N'AMOPIL', N'Amoxicilline
', N'Ce médicament, plus puissant que les pénicillines simples, est utilisé pour traiter des infections bactériennes spécifiques.
', N'Ce médicament est contre-indiqué en cas d''allergie aux pénicillines. Il doit être administré avec prudence en cas d''allergie aux céphalosporines.
', NULL, N'ABP', NULL)
INSERT [dbo].[MEDICAMENT] ([MED_DEPOTLEGAL], [MED_NOMCOMMERCIAL], [MED_COMPOSITION], [MED_EFFETS], [MED_CONTREINDIC], [MED_AMM], [FAM_CODE_MED], [ETP_NUM_MED]) VALUES (N'AMOX45', N'AMOXAR', N'Amoxicilline
', N'Ce médicament, plus puissant que les pénicillines simples, est utilisé pour traiter des infections bactériennes spécifiques.
', N'La prise de ce médicament peut rendre positifs les tests de dépistage du dopage.
', NULL, N'ABP', NULL)
INSERT [dbo].[MEDICAMENT] ([MED_DEPOTLEGAL], [MED_NOMCOMMERCIAL], [MED_COMPOSITION], [MED_EFFETS], [MED_CONTREINDIC], [MED_AMM], [FAM_CODE_MED], [ETP_NUM_MED]) VALUES (N'AMOXIG12', N'AMOXI Gé', N'Amoxicilline
', N'Ce médicament, plus puissant que les pénicillines simples, est utilisé pour traiter des infections bactériennes spécifiques.
', N'Ce médicament est contre-indiqué en cas d''allergie aux pénicillines. Il doit être administré avec prudence en cas d''allergie aux céphalosporines.
', NULL, N'ABP', NULL)
INSERT [dbo].[MEDICAMENT] ([MED_DEPOTLEGAL], [MED_NOMCOMMERCIAL], [MED_COMPOSITION], [MED_EFFETS], [MED_CONTREINDIC], [MED_AMM], [FAM_CODE_MED], [ETP_NUM_MED]) VALUES (N'APATOUX22', N'APATOUX Vitamine C', N'Tyrothricine + Tétracaïne + Acide ascorbique (Vitamine C)
', N'Ce médicament est utilisé pour traiter les affections de la bouche et de la gorge.
', N'Ce médicament est contre-indiqué en cas d''allergie à  l''un des constituants, en cas de phénylcétonurie et chez l''enfant de moins de 6 ans.
', NULL, N'ALO', NULL)
INSERT [dbo].[MEDICAMENT] ([MED_DEPOTLEGAL], [MED_NOMCOMMERCIAL], [MED_COMPOSITION], [MED_EFFETS], [MED_CONTREINDIC], [MED_AMM], [FAM_CODE_MED], [ETP_NUM_MED]) VALUES (N'BACTIG10', N'BACTIGEL', N'Erythromycine
', N'Ce médicament est utilisé en application locale pour traiter l''acné et les infections cutanées bactériennes associées.
', N'Ce médicament est contre-indiqué en cas d''allergie aux antibiotiques de la famille des macrolides ou des lincosanides.
', NULL, N'ABC', NULL)
INSERT [dbo].[MEDICAMENT] ([MED_DEPOTLEGAL], [MED_NOMCOMMERCIAL], [MED_COMPOSITION], [MED_EFFETS], [MED_CONTREINDIC], [MED_AMM], [FAM_CODE_MED], [ETP_NUM_MED]) VALUES (N'BACTIV13', N'BACTIVIL', N'Erythromycine
', N'Ce médicament est utilisé pour traiter des infections bactériennes spécifiques.
', N'Ce médicament est contre-indiqué en cas d''allergie aux macrolides (dont le chef de file est l''érythromycine).
', NULL, N'AFM', NULL)
INSERT [dbo].[MEDICAMENT] ([MED_DEPOTLEGAL], [MED_NOMCOMMERCIAL], [MED_COMPOSITION], [MED_EFFETS], [MED_CONTREINDIC], [MED_AMM], [FAM_CODE_MED], [ETP_NUM_MED]) VALUES (N'BITALV', N'BIVALIC', N'Dextropropoxyphène + Paracétamol
', N'Ce médicament est utilisé pour traiter les douleurs d''intensité modérée ou intense.
', N'Ce médicament est contre-indiqué en cas d''allergie aux médicaments de cette famille, d''insuffisance hépatique ou d''insuffisance rénale.
', NULL, N'AAA', NULL)
INSERT [dbo].[MEDICAMENT] ([MED_DEPOTLEGAL], [MED_NOMCOMMERCIAL], [MED_COMPOSITION], [MED_EFFETS], [MED_CONTREINDIC], [MED_AMM], [FAM_CODE_MED], [ETP_NUM_MED]) VALUES (N'CARTION6', N'CARTION', N'Acide acétylsalicylique (aspirine) + Acide ascorbique (Vitamine C) + Paracétamol
', N'Ce médicament est utilisé dans le traitement symptomatique de la douleur ou de la fièvre.
', N'Ce médicament est contre-indiqué en cas de troubles de la coagulation (tendances aux hémorragies), d''ulcère gastroduodénal, maladies graves du foie.
', NULL, N'AAA', NULL)
INSERT [dbo].[MEDICAMENT] ([MED_DEPOTLEGAL], [MED_NOMCOMMERCIAL], [MED_COMPOSITION], [MED_EFFETS], [MED_CONTREINDIC], [MED_AMM], [FAM_CODE_MED], [ETP_NUM_MED]) VALUES (N'CLAZER6', N'CLAZER', N'Clarithromycine
', N'Ce médicament est utilisé pour traiter des infections bactériennes spécifiques. Il est également utilisé dans le traitement de l''ulcère gastro-duodénal, en association avec d''autres médicaments.
', N'Ce médicament est contre-indiqué en cas d''allergie aux macrolides (dont le chef de file est l''érythromycine).
', NULL, N'AFM', NULL)
INSERT [dbo].[MEDICAMENT] ([MED_DEPOTLEGAL], [MED_NOMCOMMERCIAL], [MED_COMPOSITION], [MED_EFFETS], [MED_CONTREINDIC], [MED_AMM], [FAM_CODE_MED], [ETP_NUM_MED]) VALUES (N'DEPRIL9', N'DEPRAMIL', N'Clomipramine
', N'Ce médicament est utilisé pour traiter les épisodes dépressifs sévères, certaines douleurs rebelles, les troubles obsessionnels compulsifs et certaines énurésies chez l''enfant.
', N'Ce médicament est contre-indiqué en cas de glaucome ou d''adénome de la prostate, d''infarctus récent, ou si vous avez reà§u un traitement par IMAO durant les 2 semaines précédentes ou en cas d''allergie aux antidépresseurs imipraminiques.
', NULL, N'AIM', NULL)
INSERT [dbo].[MEDICAMENT] ([MED_DEPOTLEGAL], [MED_NOMCOMMERCIAL], [MED_COMPOSITION], [MED_EFFETS], [MED_CONTREINDIC], [MED_AMM], [FAM_CODE_MED], [ETP_NUM_MED]) VALUES (N'DIMIRTAM6', N'DIMIRTAM', N'Mirtazapine
', N'Ce médicament est utilisé pour traiter les épisodes dépressifs sévères.
', N'La prise de ce produit est contre-indiquée en cas de d''allergie à  l''un des constituants.
', NULL, N'AAC', NULL)
INSERT [dbo].[MEDICAMENT] ([MED_DEPOTLEGAL], [MED_NOMCOMMERCIAL], [MED_COMPOSITION], [MED_EFFETS], [MED_CONTREINDIC], [MED_AMM], [FAM_CODE_MED], [ETP_NUM_MED]) VALUES (N'DOLRIL7', N'DOLORIL', N'Acide acétylsalicylique (aspirine) + Acide ascorbique (Vitamine C) + Paracétamol
', N'Ce médicament est utilisé dans le traitement symptomatique de la douleur ou de la fièvre.
', N'Ce médicament est contre-indiqué en cas d''allergie au paracétamol ou aux salicylates.
', NULL, N'AAA', NULL)
INSERT [dbo].[MEDICAMENT] ([MED_DEPOTLEGAL], [MED_NOMCOMMERCIAL], [MED_COMPOSITION], [MED_EFFETS], [MED_CONTREINDIC], [MED_AMM], [FAM_CODE_MED], [ETP_NUM_MED]) VALUES (N'DORNOM8', N'NORMADOR', N'Doxylamine
', N'Ce médicament est utilisé pour traiter l''insomnie chez l''adulte.
', N'Ce médicament est contre-indiqué en cas de glaucome, de certains troubles urinaires (rétention urinaire) et chez l''enfant de moins de 15 ans.
', NULL, N'HYP', NULL)
INSERT [dbo].[MEDICAMENT] ([MED_DEPOTLEGAL], [MED_NOMCOMMERCIAL], [MED_COMPOSITION], [MED_EFFETS], [MED_CONTREINDIC], [MED_AMM], [FAM_CODE_MED], [ETP_NUM_MED]) VALUES (N'EQUILARX6', N'EQUILAR', N'Méclozine
', N'Ce médicament est utilisé pour traiter les vertiges et pour prévenir le mal des transports.
', N'Ce médicament ne doit pas être utilisé en cas d''allergie au produit, en cas de glaucome ou de rétention urinaire.
', NULL, N'AAH', NULL)
INSERT [dbo].[MEDICAMENT] ([MED_DEPOTLEGAL], [MED_NOMCOMMERCIAL], [MED_COMPOSITION], [MED_EFFETS], [MED_CONTREINDIC], [MED_AMM], [FAM_CODE_MED], [ETP_NUM_MED]) VALUES (N'EVILR7', N'EVEILLOR', N'Adrafinil
', N'Ce médicament est utilisé pour traiter les troubles de la vigilance et certains symptomes neurologiques chez le sujet agé.
', N'Ce médicament est contre-indiqué en cas d''allergie à  l''un des constituants.
', NULL, N'PSA', NULL)
INSERT [dbo].[MEDICAMENT] ([MED_DEPOTLEGAL], [MED_NOMCOMMERCIAL], [MED_COMPOSITION], [MED_EFFETS], [MED_CONTREINDIC], [MED_AMM], [FAM_CODE_MED], [ETP_NUM_MED]) VALUES (N'INSXT5', N'INSECTIL', N'Diphénydramine
', N'Ce médicament est utilisé en application locale sur les piqûres d''insecte et l''urticaire.
', N'Ce médicament est contre-indiqué en cas d''allergie aux antihistaminiques.
', NULL, N'AH', NULL)
INSERT [dbo].[MEDICAMENT] ([MED_DEPOTLEGAL], [MED_NOMCOMMERCIAL], [MED_COMPOSITION], [MED_EFFETS], [MED_CONTREINDIC], [MED_AMM], [FAM_CODE_MED], [ETP_NUM_MED]) VALUES (N'JOVAI8', N'JOVENIL', N'Josamycine
', N'Ce médicament est utilisé pour traiter des infections bactériennes spécifiques.
', N'Ce médicament est contre-indiqué en cas d''allergie aux macrolides (dont le chef de file est l''érythromycine).
', NULL, N'AFM', NULL)
INSERT [dbo].[MEDICAMENT] ([MED_DEPOTLEGAL], [MED_NOMCOMMERCIAL], [MED_COMPOSITION], [MED_EFFETS], [MED_CONTREINDIC], [MED_AMM], [FAM_CODE_MED], [ETP_NUM_MED]) VALUES (N'LIDOXY23', N'LIDOXYTRACINE', N'Oxytétracycline +Lidocaïne
', N'Ce médicament est utilisé en injection intramusculaire pour traiter certaines infections spécifiques.
', N'Ce médicament est contre-indiqué en cas d''allergie à  l''un des constituants. Il ne doit pas être associé aux rétinoïdes.
', NULL, N'AFC', NULL)
INSERT [dbo].[MEDICAMENT] ([MED_DEPOTLEGAL], [MED_NOMCOMMERCIAL], [MED_COMPOSITION], [MED_EFFETS], [MED_CONTREINDIC], [MED_AMM], [FAM_CODE_MED], [ETP_NUM_MED]) VALUES (N'LITHOR12', N'LITHORINE', N'Lithium
', N'Ce médicament est indiqué dans la prévention des psychoses maniaco-dépressives ou pour traiter les états maniaques.
', N'Ce médicament ne doit pas être utilisé si vous êtes allergique au lithium. Avant de prendre ce traitement, signalez à  votre médecin traitant si vous souffrez d''insuffisance rénale, ou si vous avez un régime sans sel.
', NULL, N'AP', NULL)
INSERT [dbo].[MEDICAMENT] ([MED_DEPOTLEGAL], [MED_NOMCOMMERCIAL], [MED_COMPOSITION], [MED_EFFETS], [MED_CONTREINDIC], [MED_AMM], [FAM_CODE_MED], [ETP_NUM_MED]) VALUES (N'PARMOL16', N'PARMOCODEINE', N'Codéine + Paracétamol
', N'Ce médicament est utilisé pour le traitement des douleurs lorsque des antalgiques simples ne sont pas assez efficaces.
', N'Ce médicament est contre-indiqué en cas d''allergie à  l''un des constituants, chez l''enfant de moins de 15 Kg, en cas d''insuffisance hépatique ou respiratoire, d''asthme, de phénylcétonurie et chez la femme qui allaite.
', NULL, N'AA', NULL)
INSERT [dbo].[MEDICAMENT] ([MED_DEPOTLEGAL], [MED_NOMCOMMERCIAL], [MED_COMPOSITION], [MED_EFFETS], [MED_CONTREINDIC], [MED_AMM], [FAM_CODE_MED], [ETP_NUM_MED]) VALUES (N'PHYSOI8', N'PHYSICOR', N'Sulbutiamine
', N'Ce médicament est utilisé pour traiter les baisses d''activité physique ou psychique, souvent dans un contexte de dépression.
', N'Ce médicament est contre-indiqué en cas d''allergie à  l''un des constituants.
', NULL, N'PSA', NULL)
INSERT [dbo].[MEDICAMENT] ([MED_DEPOTLEGAL], [MED_NOMCOMMERCIAL], [MED_COMPOSITION], [MED_EFFETS], [MED_CONTREINDIC], [MED_AMM], [FAM_CODE_MED], [ETP_NUM_MED]) VALUES (N'PIRIZ8', N'PIRIZAN', N'Pyrazinamide
', N'Ce médicament est utilisé, en association à  d''autres antibiotiques, pour traiter la tuberculose.
', N'Ce médicament est contre-indiqué en cas d''allergie à  l''un des constituants, d''insuffisance rénale ou hépatique, d''hyperuricémie ou de porphyrie.
', NULL, N'ABA', NULL)
INSERT [dbo].[MEDICAMENT] ([MED_DEPOTLEGAL], [MED_NOMCOMMERCIAL], [MED_COMPOSITION], [MED_EFFETS], [MED_CONTREINDIC], [MED_AMM], [FAM_CODE_MED], [ETP_NUM_MED]) VALUES (N'POMDI20', N'POMADINE', N'Bacitracine
', N'Ce médicament est utilisé pour traiter les infections oculaires de la surface de l''oeil.
', N'Ce médicament est contre-indiqué en cas d''allergie aux antibiotiques appliqués localement.
', NULL, N'AO', NULL)
INSERT [dbo].[MEDICAMENT] ([MED_DEPOTLEGAL], [MED_NOMCOMMERCIAL], [MED_COMPOSITION], [MED_EFFETS], [MED_CONTREINDIC], [MED_AMM], [FAM_CODE_MED], [ETP_NUM_MED]) VALUES (N'TROXT21', N'TROXADET', N'Paroxétine
', N'Ce médicament est utilisé pour traiter la dépression et les troubles obsessionnels compulsifs. Il peut également être utilisé en prévention des crises de panique avec ou sans agoraphobie.
', N'Ce médicament est contre-indiqué en cas d''allergie au produit.
', NULL, N'AIN', NULL)
INSERT [dbo].[MEDICAMENT] ([MED_DEPOTLEGAL], [MED_NOMCOMMERCIAL], [MED_COMPOSITION], [MED_EFFETS], [MED_CONTREINDIC], [MED_AMM], [FAM_CODE_MED], [ETP_NUM_MED]) VALUES (N'TXISOL22', N'TOUXISOL Vitamine C', N'Tyrothricine + Acide ascorbique (Vitamine C)
', N'Ce médicament est utilisé pour traiter les affections de la bouche et de la gorge.
', N'Ce médicament est contre-indiqué en cas d''allergie à  l''un des constituants et chez l''enfant de moins de 6 ans.
', NULL, N'ALO', NULL)
INSERT [dbo].[MEDICAMENT] ([MED_DEPOTLEGAL], [MED_NOMCOMMERCIAL], [MED_COMPOSITION], [MED_EFFETS], [MED_CONTREINDIC], [MED_AMM], [FAM_CODE_MED], [ETP_NUM_MED]) VALUES (N'URIEG6', N'URIREGUL', N'Fosfomycine trométamol
', N'Ce médicament est utilisé pour traiter les infections urinaires simples chez la femme de moins de 65 ans.
', N'La prise de ce médicament est contre-indiquée en cas d''allergie à  l''un des constituants et d''insuffisance rénale.
', NULL, N'AUM', NULL)
GO
INSERT [dbo].[UTILISATEUR] ([UTL_NUM], [UTL_LOGIN], [UTL_MDP], [UTL_NOM], [UTL_PRENOM]) VALUES (1, N'thibautM', N'pd', N'meslin', N'thibaut')
GO
ALTER TABLE [dbo].[FAMILLE] ADD  CONSTRAINT [DF_FAMILLE_FAM_NB_MEDI_AMM]  DEFAULT ((0)) FOR [FAM_NB_MEDI_AMM]
GO
ALTER TABLE [dbo].[HISTORIQUE]  WITH CHECK ADD  CONSTRAINT [FK_HISTORIQUE_ETAPE] FOREIGN KEY([HST_ETP_NUM])
REFERENCES [dbo].[ETAPE] ([ETP_NUM])
GO
ALTER TABLE [dbo].[HISTORIQUE] CHECK CONSTRAINT [FK_HISTORIQUE_ETAPE]
GO
ALTER TABLE [dbo].[HISTORIQUE]  WITH CHECK ADD  CONSTRAINT [FK_HISTORIQUE_UTILISATEUR] FOREIGN KEY([HST_UTL])
REFERENCES [dbo].[UTILISATEUR] ([UTL_NUM])
GO
ALTER TABLE [dbo].[HISTORIQUE] CHECK CONSTRAINT [FK_HISTORIQUE_UTILISATEUR]
GO
ALTER TABLE [dbo].[MEDICAMENT]  WITH CHECK ADD  CONSTRAINT [FK_MEDICAMENT_ETAPE] FOREIGN KEY([ETP_NUM_MED])
REFERENCES [dbo].[ETAPE] ([ETP_NUM])
GO
ALTER TABLE [dbo].[MEDICAMENT] CHECK CONSTRAINT [FK_MEDICAMENT_ETAPE]
GO
ALTER TABLE [dbo].[MEDICAMENT]  WITH CHECK ADD  CONSTRAINT [FK_MEDICAMENT_FAMILLE] FOREIGN KEY([FAM_CODE_MED])
REFERENCES [dbo].[FAMILLE] ([FAM_CODE])
GO
ALTER TABLE [dbo].[MEDICAMENT] CHECK CONSTRAINT [FK_MEDICAMENT_FAMILLE]
GO
ALTER TABLE [dbo].[SUBIR]  WITH CHECK ADD  CONSTRAINT [FK_SUBIR_DECISION] FOREIGN KEY([DSC_ID_SUB])
REFERENCES [dbo].[DECISION] ([DCS_ID])
GO
ALTER TABLE [dbo].[SUBIR] CHECK CONSTRAINT [FK_SUBIR_DECISION]
GO
ALTER TABLE [dbo].[SUBIR]  WITH CHECK ADD  CONSTRAINT [FK_SUBIR_ETAPE] FOREIGN KEY([ETP_NUM_SUB])
REFERENCES [dbo].[ETAPE] ([ETP_NUM])
GO
ALTER TABLE [dbo].[SUBIR] CHECK CONSTRAINT [FK_SUBIR_ETAPE]
GO
ALTER TABLE [dbo].[SUBIR]  WITH CHECK ADD  CONSTRAINT [FK_SUBIR_MEDICAMENT] FOREIGN KEY([MED_DEPOTLEGAL_SUB])
REFERENCES [dbo].[MEDICAMENT] ([MED_DEPOTLEGAL])
GO
ALTER TABLE [dbo].[SUBIR] CHECK CONSTRAINT [FK_SUBIR_MEDICAMENT]
GO
/****** Object:  Trigger [dbo].[trg_update_historique]    Script Date: 13/11/2020 16:44:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[trg_update_historique]
   ON [dbo].[ETAPE]
   AFTER UPDATE
AS 
BEGIN
	SET NOCOUNT ON;

	DECLARE @dateMAJ as date
	DECLARE @util as int
	DECLARE @numEtape as int
	DECLARE @normeAvant as varchar(20)
	DECLARE @normeApres as varchar(20)
	DECLARE @dateAvant as date
	DECLARE @dateApres as date

	--récupérer les nouvelles informations
	SELECT @dateApres = ETP_DATE_NORME, @normeApres = ETP_NORME, @numEtape = ETP_NUM from inserted

	--récupérer les informations supprimées
	SELECT @normeAvant = ETP_NORME, @dateAvant = ETP_DATE_Norme from deleted

	--récupérer les anciennes informations
	SELECT @util = UTL_NUM from UTILISATEUR

	--récupérer la date du jour
	SELECT @dateMAJ = convert (date, SYSDATETIME());

	--Inserer la ligne dans la table HISTORIQUE
	INSERT INTO HISTORIQUE(HST_DATE_MODIF, HST_ETP_DATE_BEFORE, HST_DATE_AFTER, HST_UTL, HST_ETP_NUM, HST_ETP_NORME_BEFORE, HST_ETP_NORME_AFTER)
	VALUES (@dateMAJ, @dateAvant, @dateApres, @util, @numEtape, @normeAvant, @normeApres)

END
GO
ALTER TABLE [dbo].[ETAPE] ENABLE TRIGGER [trg_update_historique]
GO
USE [master]
GO
ALTER DATABASE [dtb_gesAMM] SET  READ_WRITE 
GO
