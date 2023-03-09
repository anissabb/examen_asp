CREATE TABLE [dbo].[Annuler]
(
	[IdReservationLogement] INT NOT NULL, 
    CONSTRAINT [FK_Annuler_ReservationLogement] FOREIGN KEY ([IdReservationLogement]) REFERENCES [ReservationLogement]([IdReservationLogement]),
	[DateAnnulation] Date NOT NULL,
	[IdClient] INT NOT NULL, 
    CONSTRAINT [FK_Annuler_Client] FOREIGN KEY ([IdClient]) REFERENCES [Client]([IdClient]),


)
