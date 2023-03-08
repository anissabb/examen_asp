CREATE PROCEDURE [dbo].[PS_ReservationClient]

@PasEnCours int=0,
@EnCours int=1

AS

	SELECT @PasEnCours, @EnCours

Return 0