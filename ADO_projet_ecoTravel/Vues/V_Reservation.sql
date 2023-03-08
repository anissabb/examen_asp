CREATE VIEW [dbo].[V_Reservation]
	AS SELECT [idReservation],
				[DateDebut],	
				[DateFin],
				Logement.[Pays]

	FROM[Reservation] AS reservation  JOIN [Logement] as Logement ON reservation.[IdLogement]=Logement.[IdLogement]

