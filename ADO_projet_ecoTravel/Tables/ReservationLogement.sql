CREATE TABLE [dbo].[ReservationLogement]
(
	[IdReservationLogement] INT NOT NULL IDENTITY,
	[Annulation] BIT NOT NULL,
	[Prix] MONEY NOT NULL,
	[Assurance] BIT NOT NULL,
	[IdIndisponibilite] INT NOT NULL, 
	[NombresAdulte] INT NOT NULL,
	[NombresEnfant] INT NOT NULL,
    CONSTRAINT [FK_ReservationLogement_ToTable] FOREIGN KEY ([IdIndisponibilite]) REFERENCES [Indisponibilite]([IdIndisponibilite]), 
	[IdLogement] INT NOT NULL, 
    CONSTRAINT [FK_ReservationLogement_ToTable_1] FOREIGN KEY ([IdLogement]) REFERENCES [Logement]([IdLogement]),
	[IdClient] INT NOT NULL, 
    CONSTRAINT [FK_ReservationLogement_ToTable_2] FOREIGN KEY ([IdClient]) REFERENCES [Client]([IdClient]), 
    CONSTRAINT [PK_ReservationLogement] PRIMARY KEY ([IdReservationLogement]),


   

)
