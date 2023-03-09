/*
Script de déploiement pour EcoTravelDB

Ce code a été généré par un outil.
La modification de ce fichier peut provoquer un comportement incorrect et sera perdue si
le code est régénéré.
*/

GO
SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, CONCAT_NULL_YIELDS_NULL, QUOTED_IDENTIFIER ON;

SET NUMERIC_ROUNDABORT OFF;


GO
:setvar DatabaseName "EcoTravelDB"
:setvar DefaultFilePrefix "EcoTravelDB"
:setvar DefaultDataPath "C:\Users\wille\AppData\Local\Microsoft\Microsoft SQL Server Local DB\Instances\MSSQLLocalDB\"
:setvar DefaultLogPath "C:\Users\wille\AppData\Local\Microsoft\Microsoft SQL Server Local DB\Instances\MSSQLLocalDB\"

GO
:on error exit
GO
/*
Détectez le mode SQLCMD et désactivez l'exécution du script si le mode SQLCMD n'est pas pris en charge.
Pour réactiver le script une fois le mode SQLCMD activé, exécutez ce qui suit :
SET NOEXEC OFF; 
*/
:setvar __IsSqlCmdEnabled "True"
GO
IF N'$(__IsSqlCmdEnabled)' NOT LIKE N'True'
    BEGIN
        PRINT N'Le mode SQLCMD doit être activé de manière à pouvoir exécuter ce script.';
        SET NOEXEC ON;
    END


GO
USE [master];


GO

IF (DB_ID(N'$(DatabaseName)') IS NOT NULL) 
BEGIN
    ALTER DATABASE [$(DatabaseName)]
    SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
    DROP DATABASE [$(DatabaseName)];
END

GO
PRINT N'Création de la base de données $(DatabaseName)...'
GO
CREATE DATABASE [$(DatabaseName)]
    ON 
    PRIMARY(NAME = [$(DatabaseName)], FILENAME = N'$(DefaultDataPath)$(DefaultFilePrefix)_Primary.mdf')
    LOG ON (NAME = [$(DatabaseName)_log], FILENAME = N'$(DefaultLogPath)$(DefaultFilePrefix)_Primary.ldf') COLLATE SQL_Latin1_General_CP1_CI_AS
GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE [$(DatabaseName)]
            SET AUTO_CLOSE OFF 
            WITH ROLLBACK IMMEDIATE;
    END


GO
USE [$(DatabaseName)];


GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE [$(DatabaseName)]
            SET ANSI_NULLS ON,
                ANSI_PADDING ON,
                ANSI_WARNINGS ON,
                ARITHABORT ON,
                CONCAT_NULL_YIELDS_NULL ON,
                NUMERIC_ROUNDABORT OFF,
                QUOTED_IDENTIFIER ON,
                ANSI_NULL_DEFAULT ON,
                CURSOR_DEFAULT LOCAL,
                CURSOR_CLOSE_ON_COMMIT OFF,
                AUTO_CREATE_STATISTICS ON,
                AUTO_SHRINK OFF,
                AUTO_UPDATE_STATISTICS ON,
                RECURSIVE_TRIGGERS OFF 
            WITH ROLLBACK IMMEDIATE;
    END


GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE [$(DatabaseName)]
            SET ALLOW_SNAPSHOT_ISOLATION OFF;
    END


GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE [$(DatabaseName)]
            SET READ_COMMITTED_SNAPSHOT OFF 
            WITH ROLLBACK IMMEDIATE;
    END


GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE [$(DatabaseName)]
            SET AUTO_UPDATE_STATISTICS_ASYNC OFF,
                PAGE_VERIFY NONE,
                DATE_CORRELATION_OPTIMIZATION OFF,
                DISABLE_BROKER,
                PARAMETERIZATION SIMPLE,
                SUPPLEMENTAL_LOGGING OFF 
            WITH ROLLBACK IMMEDIATE;
    END


GO
IF IS_SRVROLEMEMBER(N'sysadmin') = 1
    BEGIN
        IF EXISTS (SELECT 1
                   FROM   [master].[dbo].[sysdatabases]
                   WHERE  [name] = N'$(DatabaseName)')
            BEGIN
                EXECUTE sp_executesql N'ALTER DATABASE [$(DatabaseName)]
    SET TRUSTWORTHY OFF,
        DB_CHAINING OFF 
    WITH ROLLBACK IMMEDIATE';
            END
    END
ELSE
    BEGIN
        PRINT N'Impossible de modifier les paramètres de base de données. Vous devez être administrateur système pour appliquer ces paramètres.';
    END


GO
IF IS_SRVROLEMEMBER(N'sysadmin') = 1
    BEGIN
        IF EXISTS (SELECT 1
                   FROM   [master].[dbo].[sysdatabases]
                   WHERE  [name] = N'$(DatabaseName)')
            BEGIN
                EXECUTE sp_executesql N'ALTER DATABASE [$(DatabaseName)]
    SET HONOR_BROKER_PRIORITY OFF 
    WITH ROLLBACK IMMEDIATE';
            END
    END
ELSE
    BEGIN
        PRINT N'Impossible de modifier les paramètres de base de données. Vous devez être administrateur système pour appliquer ces paramètres.';
    END


GO
ALTER DATABASE [$(DatabaseName)]
    SET TARGET_RECOVERY_TIME = 0 SECONDS 
    WITH ROLLBACK IMMEDIATE;


GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE [$(DatabaseName)]
            SET FILESTREAM(NON_TRANSACTED_ACCESS = OFF),
                CONTAINMENT = NONE 
            WITH ROLLBACK IMMEDIATE;
    END


GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE [$(DatabaseName)]
            SET AUTO_CREATE_STATISTICS ON(INCREMENTAL = OFF),
                MEMORY_OPTIMIZED_ELEVATE_TO_SNAPSHOT = OFF,
                DELAYED_DURABILITY = DISABLED 
            WITH ROLLBACK IMMEDIATE;
    END


GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE [$(DatabaseName)]
            SET QUERY_STORE (QUERY_CAPTURE_MODE = ALL, DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_PLANS_PER_QUERY = 200, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 367), MAX_STORAGE_SIZE_MB = 100) 
            WITH ROLLBACK IMMEDIATE;
    END


GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE [$(DatabaseName)]
            SET QUERY_STORE = OFF 
            WITH ROLLBACK IMMEDIATE;
    END


GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
        ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
        ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
        ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
        ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
        ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
        ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
        ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
    END


GO
IF fulltextserviceproperty(N'IsFulltextInstalled') = 1
    EXECUTE sp_fulltext_database 'enable';


GO
PRINT N'Création de Table [dbo].[Annuler]...';


GO
CREATE TABLE [dbo].[Annuler] (
    [IdReservationLogement] INT  NOT NULL,
    [DateAnnulation]        DATE NOT NULL,
    [IdClient]              INT  NOT NULL
);


GO
PRINT N'Création de Table [dbo].[Avis]...';


GO
CREATE TABLE [dbo].[Avis] (
    [IdAvis]        INT            IDENTITY (1, 1) NOT NULL,
    [Commentaire]   NVARCHAR (250) NOT NULL,
    [Note]          TINYINT        NOT NULL,
    [IdReservation] INT            NOT NULL,
    [IdLogement]    INT            NOT NULL,
    CONSTRAINT [PK_Avis] PRIMARY KEY CLUSTERED ([IdAvis] ASC)
);


GO
PRINT N'Création de Table [dbo].[Client]...';


GO
CREATE TABLE [dbo].[Client] (
    [IdClient]    INT            IDENTITY (1, 1) NOT NULL,
    [Nom]         NVARCHAR (50)  NOT NULL,
    [Prenom]      NVARCHAR (50)  NOT NULL,
    [AdresseMail] NVARCHAR (250) NOT NULL,
    [Pays]        NVARCHAR (50)  NOT NULL,
    [Telephone]   INT            NOT NULL,
    [MotdePasse]  VARBINARY (64) NOT NULL,
    CONSTRAINT [PK_Client] PRIMARY KEY CLUSTERED ([IdClient] ASC),
    UNIQUE NONCLUSTERED ([AdresseMail] ASC),
    CONSTRAINT [AK_Client_email] UNIQUE NONCLUSTERED ([AdresseMail] ASC)
);


GO
PRINT N'Création de Table [dbo].[Images]...';


GO
CREATE TABLE [dbo].[Images] (
    [IdImage]    INT            IDENTITY (1, 1) NOT NULL,
    [Image]      NVARCHAR (255) NOT NULL,
    [IdLogement] INT            NOT NULL,
    CONSTRAINT [PK_Images] PRIMARY KEY CLUSTERED ([IdImage] ASC),
    UNIQUE NONCLUSTERED ([Image] ASC)
);


GO
PRINT N'Création de Table [dbo].[Indisponibilite]...';


GO
CREATE TABLE [dbo].[Indisponibilite] (
    [IdIndisponibilite] INT  IDENTITY (1, 1) NOT NULL,
    [DateDebut]         DATE NOT NULL,
    [DateFin]           DATE NOT NULL,
    [IdLogement]        INT  NOT NULL,
    CONSTRAINT [PK_Indisponibilite] PRIMARY KEY CLUSTERED ([IdIndisponibilite] ASC)
);


GO
PRINT N'Création de Table [dbo].[Logement]...';


GO
CREATE TABLE [dbo].[Logement] (
    [IdLogement]        INT             IDENTITY (1, 1) NOT NULL,
    [NomLogement]       NVARCHAR (50)   NOT NULL,
    [adresseRue]        NVARCHAR (200)  NOT NULL,
    [adresseNumero]     NVARCHAR (50)   NOT NULL,
    [adresseCodePostal] NVARCHAR (50)   NOT NULL,
    [adressePays]       NVARCHAR (50)   NOT NULL,
    [DescriptionCourte] NVARCHAR (50)   NOT NULL,
    [DescriptionLongue] NVARCHAR (512)  NOT NULL,
    [DateCreation]      DATE            NOT NULL,
    [NombrePieces]      TINYINT         NOT NULL,
    [PrixNuit]          MONEY           NOT NULL,
    [Capacite]          TINYINT         NOT NULL,
    [SalleBain]         TINYINT         NOT NULL,
    [Wc]                TINYINT         NOT NULL,
    [Balcon]            BIT             NOT NULL,
    [AirConditionne]    BIT             NOT NULL,
    [Wifi]              BIT             NOT NULL,
    [MiniBar]           BIT             NOT NULL,
    [AnimauxAdmis]      BIT             NOT NULL,
    [Piscine]           BIT             NOT NULL,
    [RoomService]       BIT             NOT NULL,
    [Lattitude]         DECIMAL (10, 7) NOT NULL,
    [Longitude]         DECIMAL (10, 7) NOT NULL,
    [IdTypeLogement]    INT             NOT NULL,
    [IdProprietaire]    INT             NOT NULL,
    CONSTRAINT [PK_Logement] PRIMARY KEY CLUSTERED ([IdLogement] ASC)
);


GO
PRINT N'Création de Table [dbo].[Proprietaire]...';


GO
CREATE TABLE [dbo].[Proprietaire] (
    [IdClient] INT IDENTITY (1, 1) NOT NULL,
    CONSTRAINT [PK_Proprietaire] PRIMARY KEY CLUSTERED ([IdClient] ASC)
);


GO
PRINT N'Création de Table [dbo].[ReservationLogement]...';


GO
CREATE TABLE [dbo].[ReservationLogement] (
    [IdReservationLogement] INT     IDENTITY (1, 1) NOT NULL,
    [Annulation]            BIT     NOT NULL,
    [Prix]                  MONEY   NOT NULL,
    [Assurance]             BIT     NOT NULL,
    [IdIndisponibilite]     INT     NOT NULL,
    [NombresAdulte]         TINYINT NOT NULL,
    [NombresEnfant]         TINYINT NOT NULL,
    [DateDebut]             DATE    NOT NULL,
    [DateFin]               DATE    NOT NULL,
    [AnnulerPar]            BIT     NOT NULL,
    [IdLogement]            INT     NOT NULL,
    [IdClient]              INT     NOT NULL,
    CONSTRAINT [PK_ReservationLogement] PRIMARY KEY CLUSTERED ([IdReservationLogement] ASC)
);


GO
PRINT N'Création de Table [dbo].[TypeLogement]...';


GO
CREATE TABLE [dbo].[TypeLogement] (
    [IdTypeLogement] INT            IDENTITY (1, 1) NOT NULL,
    [Type]           NVARCHAR (250) NOT NULL,
    CONSTRAINT [PK_TypeLogement] PRIMARY KEY CLUSTERED ([IdTypeLogement] ASC),
    UNIQUE NONCLUSTERED ([Type] ASC)
);


GO
PRINT N'Création de Contrainte par défaut contrainte sans nom sur [dbo].[Logement]...';


GO
ALTER TABLE [dbo].[Logement]
    ADD DEFAULT 1 FOR [Balcon];


GO
PRINT N'Création de Contrainte par défaut contrainte sans nom sur [dbo].[Logement]...';


GO
ALTER TABLE [dbo].[Logement]
    ADD DEFAULT 1 FOR [Wifi];


GO
PRINT N'Création de Contrainte par défaut contrainte sans nom sur [dbo].[Logement]...';


GO
ALTER TABLE [dbo].[Logement]
    ADD DEFAULT 1 FOR [AnimauxAdmis];


GO
PRINT N'Création de Contrainte par défaut contrainte sans nom sur [dbo].[Logement]...';


GO
ALTER TABLE [dbo].[Logement]
    ADD DEFAULT 1 FOR [Piscine];


GO
PRINT N'Création de Contrainte par défaut contrainte sans nom sur [dbo].[ReservationLogement]...';


GO
ALTER TABLE [dbo].[ReservationLogement]
    ADD DEFAULT 0 FOR [Annulation];


GO
PRINT N'Création de Contrainte par défaut contrainte sans nom sur [dbo].[ReservationLogement]...';


GO
ALTER TABLE [dbo].[ReservationLogement]
    ADD DEFAULT 0 FOR [Assurance];


GO
PRINT N'Création de Clé étrangère [dbo].[FK_Annuler_ReservationLogement]...';


GO
ALTER TABLE [dbo].[Annuler]
    ADD CONSTRAINT [FK_Annuler_ReservationLogement] FOREIGN KEY ([IdReservationLogement]) REFERENCES [dbo].[ReservationLogement] ([IdReservationLogement]);


GO
PRINT N'Création de Clé étrangère [dbo].[FK_Annuler_Client]...';


GO
ALTER TABLE [dbo].[Annuler]
    ADD CONSTRAINT [FK_Annuler_Client] FOREIGN KEY ([IdClient]) REFERENCES [dbo].[Client] ([IdClient]);


GO
PRINT N'Création de Clé étrangère [dbo].[FK_Avis_ReservationLogement]...';


GO
ALTER TABLE [dbo].[Avis]
    ADD CONSTRAINT [FK_Avis_ReservationLogement] FOREIGN KEY ([IdReservation]) REFERENCES [dbo].[ReservationLogement] ([IdReservationLogement]);


GO
PRINT N'Création de Clé étrangère [dbo].[FK_Avis_Logement]...';


GO
ALTER TABLE [dbo].[Avis]
    ADD CONSTRAINT [FK_Avis_Logement] FOREIGN KEY ([IdLogement]) REFERENCES [dbo].[Logement] ([IdLogement]);


GO
PRINT N'Création de Clé étrangère [dbo].[FK_Images_ToTable]...';


GO
ALTER TABLE [dbo].[Images]
    ADD CONSTRAINT [FK_Images_ToTable] FOREIGN KEY ([IdLogement]) REFERENCES [dbo].[Logement] ([IdLogement]);


GO
PRINT N'Création de Clé étrangère [dbo].[FK_Indisponibilité_Logement]...';


GO
ALTER TABLE [dbo].[Indisponibilite]
    ADD CONSTRAINT [FK_Indisponibilité_Logement] FOREIGN KEY ([IdLogement]) REFERENCES [dbo].[Logement] ([IdLogement]);


GO
PRINT N'Création de Clé étrangère [dbo].[FK_Logement_ToTable]...';


GO
ALTER TABLE [dbo].[Logement]
    ADD CONSTRAINT [FK_Logement_ToTable] FOREIGN KEY ([IdTypeLogement]) REFERENCES [dbo].[TypeLogement] ([IdTypeLogement]);


GO
PRINT N'Création de Clé étrangère [dbo].[FK_Logement_ToTable_1]...';


GO
ALTER TABLE [dbo].[Logement]
    ADD CONSTRAINT [FK_Logement_ToTable_1] FOREIGN KEY ([IdProprietaire]) REFERENCES [dbo].[Proprietaire] ([IdClient]);


GO
PRINT N'Création de Clé étrangère [dbo].[FK_Proprietaire_ToTable]...';


GO
ALTER TABLE [dbo].[Proprietaire]
    ADD CONSTRAINT [FK_Proprietaire_ToTable] FOREIGN KEY ([IdClient]) REFERENCES [dbo].[Client] ([IdClient]);


GO
PRINT N'Création de Clé étrangère [dbo].[FK_ReservationLogement_Indisponibilite]...';


GO
ALTER TABLE [dbo].[ReservationLogement]
    ADD CONSTRAINT [FK_ReservationLogement_Indisponibilite] FOREIGN KEY ([IdIndisponibilite]) REFERENCES [dbo].[Indisponibilite] ([IdIndisponibilite]);


GO
PRINT N'Création de Clé étrangère [dbo].[FK_ReservationLogement_Logement]...';


GO
ALTER TABLE [dbo].[ReservationLogement]
    ADD CONSTRAINT [FK_ReservationLogement_Logement] FOREIGN KEY ([IdLogement]) REFERENCES [dbo].[Logement] ([IdLogement]);


GO
PRINT N'Création de Clé étrangère [dbo].[FK_ReservationLogement_Client]...';


GO
ALTER TABLE [dbo].[ReservationLogement]
    ADD CONSTRAINT [FK_ReservationLogement_Client] FOREIGN KEY ([IdClient]) REFERENCES [dbo].[Client] ([IdClient]);


GO
PRINT N'Création de Contrainte de validation [dbo].[CK_Avis_Notes]...';


GO
ALTER TABLE [dbo].[Avis]
    ADD CONSTRAINT [CK_Avis_Notes] CHECK ([Note]<=5);


GO
PRINT N'Création de Contrainte de validation [dbo].[CK_Client_nom]...';


GO
ALTER TABLE [dbo].[Client]
    ADD CONSTRAINT [CK_Client_nom] CHECK (LEN ([nom]) >= 1);


GO
PRINT N'Création de Contrainte de validation [dbo].[CK_Client_prenom]...';


GO
ALTER TABLE [dbo].[Client]
    ADD CONSTRAINT [CK_Client_prenom] CHECK (LEN ([prenom]) >= 1);


GO
PRINT N'Création de Contrainte de validation [dbo].[CK_Client_email]...';


GO
ALTER TABLE [dbo].[Client]
    ADD CONSTRAINT [CK_Client_email] CHECK ([AdresseMail] LIKE ('%__@__%.__%'));


GO
PRINT N'Création de Contrainte de validation [dbo].[CK_Client_telephone]...';


GO
ALTER TABLE [dbo].[Client]
    ADD CONSTRAINT [CK_Client_telephone] CHECK (ISNUMERIC(REPLACE(REPLACE(REPLACE([telephone], '+', '00'), '/', ''), '.', '')) = 1);


GO
PRINT N'Création de Contrainte de validation [dbo].[CK_Images_Images]...';


GO
ALTER TABLE [dbo].[Images]
    ADD CONSTRAINT [CK_Images_Images] CHECK (LEN([Image]) >= 5 AND ([Image] LIKE '%_.png' OR[Image] LIKE '%_.jpg'));


GO
PRINT N'Création de Contrainte de validation [dbo].[CK_Logement_DescriptionCourte]...';


GO
ALTER TABLE [dbo].[Logement]
    ADD CONSTRAINT [CK_Logement_DescriptionCourte] CHECK (LEN([DescriptionCourte])>=8);


GO
PRINT N'Création de Contrainte de validation [dbo].[CK_Logement_DescriptionLongue]...';


GO
ALTER TABLE [dbo].[Logement]
    ADD CONSTRAINT [CK_Logement_DescriptionLongue] CHECK (LEN([DescriptionLongue])>=[DescriptionCourte]);


GO
PRINT N'Création de Contrainte de validation [dbo].[CK_ReservationLogement_DateDebut]...';


GO
ALTER TABLE [dbo].[ReservationLogement]
    ADD CONSTRAINT [CK_ReservationLogement_DateDebut] CHECK ([DateDebut]>=GetDate());


GO
PRINT N'Création de Contrainte de validation [dbo].[CK_ReservationLogement_DateFin]...';


GO
ALTER TABLE [dbo].[ReservationLogement]
    ADD CONSTRAINT [CK_ReservationLogement_DateFin] CHECK ([DateFin]>=[DateDebut]);


GO
PRINT N'Création de Vue [dbo].[LogementNotes]...';


GO
CREATE VIEW [dbo].[LogementNotes]
AS SELECT DISTINCT Logement.*
FROM [Logement] AS Logement
JOIN [Avis] AS Avis
ON Logement.[idLogement] = Avis.[idLogement]
WHERE (SELECT AVG([note]) FROM Avis WHERE Avis.idLogement = Logement.IdLogement)>(SELECT AVG([note]) FROM [Avis]);
GO
PRINT N'Création de Vue [dbo].[V_Reservation]...';


GO
CREATE VIEW [dbo].[V_Reservation]
	AS SELECT [IdReservationLogement],
				[DateDebut],	
				[DateFin],
				Logement.[adressePays]

	FROM [ReservationLogement] AS reservation  JOIN [Logement] AS Logement ON reservation.[IdLogement]=Logement.[IdLogement]
GO
PRINT N'Création de Procédure [dbo].[PS_Client]...';


GO
CREATE PROCEDURE [dbo].[PS_Client]
	@AdresseMail NVARCHAR(250),
	@MotdePasse NVARCHAR(50),
	@Nom NVARCHAR(50),
	@prenom NVARCHAR(50),
	@pays NVARCHAR(50),
	@telephone NVARCHAR(50)
AS
	INSERT INTO [Client] ([AdresseMail], [MotdePasse], [Nom], [Prenom], [Pays], [telephone])
	OUTPUT [inserted].[idClient]
	VALUES (@AdresseMail, HASHBYTES('SHA_512', @MotdePasse), @Nom, @Prenom, @Pays, @telephone)
GO
PRINT N'Création de Procédure [dbo].[PS_LogementDispo]...';


GO
CREATE PROCEDURE [dbo].[PS_LogementDispo]


@DateDebut DATE, 
@DateFin DATE

AS 

SELECT [Logement]. *FROM [Logement]
JOIN [VueDisponibilite] ON [VueDisponibilite].[idLogement] = [Logement].[idLogement]
	WHERE [VuedateDebut] >= @DateDebut AND [VuedateFin] <= @DateFin
GO
PRINT N'Création de Procédure [dbo].[PS_LogementMois]...';


GO
CREATE PROCEDURE [dbo].[PS_LogementMois]

AS
	SELECT * FROM [Logement]
	WHERE [DateCreation] BETWEEN CONVERT(DATETIME,DATEDIFF(DAY,30,GETDATE())) AND GETDATE()
GO
-- Étape de refactorisation pour mettre à jour le serveur cible avec des journaux de transactions déployés

IF OBJECT_ID(N'dbo.__RefactorLog') IS NULL
BEGIN
    CREATE TABLE [dbo].[__RefactorLog] (OperationKey UNIQUEIDENTIFIER NOT NULL PRIMARY KEY)
    EXEC sp_addextendedproperty N'microsoft_database_tools_support', N'refactoring log', N'schema', N'dbo', N'table', N'__RefactorLog'
END
GO
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = 'a0407028-faaa-492a-8e7b-3ac3361a1c18')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('a0407028-faaa-492a-8e7b-3ac3361a1c18')
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = '2518624f-3cce-452f-b725-8f3d68412657')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('2518624f-3cce-452f-b725-8f3d68412657')
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = '033b8af3-ffad-4cd0-b784-085a149a6fd4')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('033b8af3-ffad-4cd0-b784-085a149a6fd4')

GO

GO

INSERT INTO [TypeLogement] ([Type]) 


VALUES ('Maison'), 
		('Appartement'),
		('Hotel'),
		('Villa')

GO

GO
DECLARE @VarDecimalSupported AS BIT;

SELECT @VarDecimalSupported = 0;

IF ((ServerProperty(N'EngineEdition') = 3)
    AND (((@@microsoftversion / power(2, 24) = 9)
          AND (@@microsoftversion & 0xffff >= 3024))
         OR ((@@microsoftversion / power(2, 24) = 10)
             AND (@@microsoftversion & 0xffff >= 1600))))
    SELECT @VarDecimalSupported = 1;

IF (@VarDecimalSupported > 0)
    BEGIN
        EXECUTE sp_db_vardecimal_storage_format N'$(DatabaseName)', 'ON';
    END


GO
PRINT N'Mise à jour terminée.';


GO
