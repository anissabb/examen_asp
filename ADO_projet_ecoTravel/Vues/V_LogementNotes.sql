CREATE VIEW [dbo].[V_LogementNotes]

AS SELECT [IdLogement],
			[IdReservationLogement],
			[Avis].Avis

FROM [Reservation] AS Reservation JOIN [Avis] as Avis ON Reservation.[IdLogement]=Avis.[IdAvis]