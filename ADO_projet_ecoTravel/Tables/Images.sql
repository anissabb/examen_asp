CREATE TABLE [dbo].[Images]
(
	[IdImage] INT NOT NULL IDENTITY, 
    CONSTRAINT [PK_Images] PRIMARY KEY ([IdImage]),
	[Image] NVARCHAR(255) NOT NULL UNIQUE,
	[IdLogement] INT NOT NULL, 
    CONSTRAINT [FK_Images_ToTable] FOREIGN KEY ([IdLogement]) REFERENCES [Logement]([IdLogement]), 
    CONSTRAINT [CK_Images_Images] CHECK (LEN([Image]) >= 5 AND ([Image] LIKE '%_.png' OR[Image] LIKE '%_.jpg'))


)
