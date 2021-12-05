CREATE TABLE [dbo].[ColorNames]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [ColorId] INT NOT NULL, 
    [LanguageId] INT NOT NULL, 
    [Name] NVARCHAR(50) NOT NULL, 
    CONSTRAINT [FK_ColorNames_Colors] FOREIGN KEY ([ColorId]) REFERENCES [Colors]([Id]), 
    CONSTRAINT [FK_ColorNames_Languages] FOREIGN KEY ([LanguageId]) REFERENCES [Languages]([Id])
)
