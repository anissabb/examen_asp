CREATE PROCEDURE [dbo].[PS_Client]
	@AdresseMail NVARCHAR(250),
	@MotdePasse NVARCHAR(50),
	@Nom NVARCHAR(50),
	@prenom NVARCHAR(50),
	@pays NVARCHAR(50),
	@telephone NVARCHAR(50)
AS
	INSERT INTO [Client] ([AdresseMail], [MotdePasse], [Nom], [Prenom], [Pays], [telephone])
	OUTPUT [inserted].[idClient]
	VALUES (@AdresseMail, HASHBYTES('SHA_512', @MotdePasse), @Nom, @Prenom, @Pays, @telephone)