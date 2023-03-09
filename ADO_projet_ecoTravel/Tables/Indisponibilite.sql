CREATE TABLE [dbo].[Indisponibilite]
(
	[IdIndisponibilite] INT NOT NULL IDENTITY,
	[DateDebut] DATE NOT NULL,
	[DateFin] DATE NOT NULL,
	[IdLogement] INT NOT NULL, 
    CONSTRAINT [FK_Indisponibilité_Logement] FOREIGN KEY([IdLogement]) REFERENCES [Logement]([IdLogement]), 
    CONSTRAINT [PK_Indisponibilite] PRIMARY KEY ([IdIndisponibilite])



)
