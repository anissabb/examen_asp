CREATE TABLE [dbo].[Proprietaire]
(
	[IdClient] INT IDENTITY NOT NULL, 
    CONSTRAINT [FK_Proprietaire_ToTable] FOREIGN KEY ([IdClient]) REFERENCES [Client]([IdClient]), 
    CONSTRAINT [PK_Proprietaire] PRIMARY KEY ([IdClient]),
	
)
