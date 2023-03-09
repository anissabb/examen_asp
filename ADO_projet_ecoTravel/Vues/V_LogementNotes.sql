CREATE VIEW [dbo].[V_LogementNotes]

AS SELECT Logement.*
FROM [Logement] AS Logement
JOIN [Avis] AS Avis
ON Logement.[idLogement] = Avis.[idLogement]
GROUP BY Logement.[idLogement]
Having AVG(Avis.[note])>(SELECT AVG([note]) FROM [Avis]);