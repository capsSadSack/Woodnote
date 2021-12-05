CREATE TABLE [dbo].[BirdNames]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [BirdId] INT NOT NULL, 
    [LanguageId] INT NOT NULL, 
    [Name] NVARCHAR(100) NOT NULL, 
    CONSTRAINT [FK_BirdNames_Languages] FOREIGN KEY (LanguageId) REFERENCES [Languages]([Id]), 
    CONSTRAINT [FK_BirdNames_Birds] FOREIGN KEY ([BirdId]) REFERENCES [Birds]([Id])
)
