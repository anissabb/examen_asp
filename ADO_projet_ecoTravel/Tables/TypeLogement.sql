CREATE TABLE [dbo].[TypeLogement]
(
	[IdTypeLogement] INT NOT NULL IDENTITY,
	[Type] NVARCHAR (250) NOT NULL UNIQUE, 
    CONSTRAINT [PK_TypeLogement] PRIMARY KEY ([IdTypeLogement]),
	

)
