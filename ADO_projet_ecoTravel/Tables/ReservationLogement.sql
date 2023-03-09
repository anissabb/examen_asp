CREATE TABLE [dbo].[ReservationLogement]
(
	[IdReservationLogement] INT NOT NULL IDENTITY,
	[Annulation] BIT NOT NULL DEFAULT 0,
	[Prix] MONEY NOT NULL,
	[Assurance] BIT NOT NULL DEFAULT 0,
	[IdIndisponibilite] INT NOT NULL, 
	[NombresAdulte] TINYINT NOT NULL,
	[NombresEnfant] TINYINT NOT NULL,
	[DateDebut] DATE NOT NULL,
	[DateFin] DATE NOT NULL,

	[AnnulerPar] BIT NOT NULL,
    CONSTRAINT [FK_ReservationLogement_Indisponibilite] FOREIGN KEY ([IdIndisponibilite]) REFERENCES [Indisponibilite]([IdIndisponibilite]), 
	[IdLogement] INT NOT NULL, 
    CONSTRAINT [FK_ReservationLogement_Logement] FOREIGN KEY ([IdLogement]) REFERENCES [Logement]([IdLogement]),
	[IdClient] INT NOT NULL, 
    CONSTRAINT [FK_ReservationLogement_Client] FOREIGN KEY ([IdClient]) REFERENCES [Client]([IdClient]), 
    CONSTRAINT [PK_ReservationLogement] PRIMARY KEY ([IdReservationLogement]), 
    CONSTRAINT [CK_ReservationLogement_DateDebut] CHECK ([DateDebut]>=GetDate()),
	CONSTRAINT [CK_ReservationLogement_DateFin] CHECK ([DateFin]>=[DateDebut]),



   

)
