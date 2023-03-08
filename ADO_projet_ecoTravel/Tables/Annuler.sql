CREATE TABLE [dbo].[Annuler]
(
	[IdReservationLogement] INT NOT NULL, 
    CONSTRAINT [FK_Annuler_ToTable] FOREIGN KEY ([IdReservationLogement]) REFERENCES [Annuler]([IdReservationLogement]),
	[dateAnnulation] Date NOT NULL,
	[IdClient] INT NOT NULL, 
    CONSTRAINT [FK_Annuler_ToTable_1] FOREIGN KEY ([IdClient]) REFERENCES [Client]([IdClient]),


)
