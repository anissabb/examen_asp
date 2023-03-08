CREATE TABLE [dbo].[Avis]
(
	[IdAvis] INT NOT NULL IDENTITY,
	[Avis] NVARCHAR(250) NOT NULL,
	[IdClient] INT NOT NULL, 
    CONSTRAINT [FK_Avis_ToTable] FOREIGN KEY ([IdClient]) REFERENCES [Client]([IdClient]), 
    CONSTRAINT [PK_Avis] PRIMARY KEY ([IdAvis]),


)
