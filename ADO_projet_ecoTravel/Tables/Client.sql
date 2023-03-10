CREATE TABLE [dbo].[Client]
(
	[IdClient] INT NOT NULL  IDENTITY,
	[Nom] NVARCHAR(50) NOT NULL,
	[Prenom] NVARCHAR(50) NOT NULL,
	[AdresseMail] NVARCHAR(250) NOT NULL UNIQUE,
	[Pays] NVARCHAR(50) NOT NULL,
	[Telephone] NVARCHAR(15) NOT NULL, 
	[MotdePasse] VARBINARY(64) NOT NULL,
    CONSTRAINT [PK_Client] PRIMARY KEY ([IdClient]),
    CONSTRAINT [CK_Client_nom] CHECK (LEN ([nom]) >= 1 ),
    CONSTRAINT [CK_Client_prenom] CHECK (LEN ([prenom]) >= 1 ), 
    CONSTRAINT [AK_Client_email] UNIQUE ([AdresseMail]),
    CONSTRAINT [CK_Client_email] CHECK ([AdresseMail] LIKE ('%__@__%.__%')), 
    CONSTRAINT [CK_Client_telephone] CHECK (ISNUMERIC(REPLACE(REPLACE(REPLACE([telephone], '+', '00'), '/', ''), '.', '')) = 1)



)
