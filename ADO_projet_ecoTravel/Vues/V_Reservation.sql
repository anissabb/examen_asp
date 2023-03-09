CREATE VIEW [dbo].[V_Reservation]
	AS SELECT [IdReservationLogement],
				[DateDebut],	
				[DateFin],
				Logement.[adressePays]

	FROM [ReservationLogement] AS reservation  JOIN [Logement] AS Logement ON reservation.[IdLogement]=Logement.[IdLogement]
	

