CREATE TABLE [dbo].[Images]
(
	[IdImage] INT NOT NULL IDENTITY, 
    CONSTRAINT [PK_Images] PRIMARY KEY ([IdImage]),
	[Images] NVARCHAR(255) NOT NULL,
	[IdLogement] INT NOT NULL, 
    CONSTRAINT [FK_Images_ToTable] FOREIGN KEY ([IdLogement]) REFERENCES [Logement]([IdLogement]), 
    CONSTRAINT [CK_Images_Images] CHECK (LEN([Images]) >= 5 AND ([Images] LIKE '%_.png' OR[Images] LIKE '%_.jpg')),


)
