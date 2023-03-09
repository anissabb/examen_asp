CREATE TABLE [dbo].[Avis]
(
	[IdAvis] INT NOT NULL IDENTITY,
	[Commentaire] NVARCHAR(250) NOT NULL,
	[Note] TINYINT NOT NULL,
	[IdReservation] INT NOT NULL, 

    CONSTRAINT [FK_Avis_ReservationLogement] FOREIGN KEY ([IdReservation]) REFERENCES [ReservationLogement]([IdReservationLogement]), 
    CONSTRAINT [PK_Avis] PRIMARY KEY ([IdAvis]),
	[IdLogement] INT NOT NULL, 
    CONSTRAINT [FK_Avis_Logement] FOREIGN KEY ([IdLogement]) REFERENCES [Logement]([IdLogement]), 
    CONSTRAINT [CK_Avis_Notes] CHECK ([Note]<=5)



)
