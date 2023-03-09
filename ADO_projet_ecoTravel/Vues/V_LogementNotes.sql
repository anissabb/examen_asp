CREATE VIEW [dbo].[LogementNotes]
AS SELECT DISTINCT Logement.*
FROM [Logement] AS Logement
JOIN [Avis] AS Avis
ON Logement.[idLogement] = Avis.[idLogement]
WHERE (SELECT AVG([note]) FROM Avis WHERE Avis.idLogement = Logement.IdLogement)>(SELECT AVG([note]) FROM [Avis]);