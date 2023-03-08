CREATE TABLE [dbo].[TypeLogement]
(
	[IdTypeLogement] INT NOT NULL IDENTITY,
	[Type] NVARCHAR (250) NOT NULL, 
    CONSTRAINT [PK_TypeLogement] PRIMARY KEY ([IdTypeLogement]),
	

)
