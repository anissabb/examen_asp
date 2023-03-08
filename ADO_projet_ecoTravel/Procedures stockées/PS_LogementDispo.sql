CREATE PROCEDURE [dbo].[PS_LogementDispo]


@DateDebut DATE, 
@DateFin DATE

AS 

SELECT [Logement]. *FROM [Logement]
JOIN [VueDisponibilite] ON [VueDisponibilite].[idLogement] = [Logement].[idLogement]
	WHERE [VuedateDebut] >= @DateDebut AND [VuedateFin] <= @DateFin