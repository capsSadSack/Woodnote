CREATE TABLE [dbo].[RegionNames]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [RegionId] INT NOT NULL, 
    [LanguageId] INT NOT NULL, 
    [Name] NVARCHAR(100) NULL, 
    CONSTRAINT [FK_RegionNames_Regions] FOREIGN KEY ([RegionId]) REFERENCES [Regions]([Id]), 
    CONSTRAINT [FK_RegionNames_Languages] FOREIGN KEY ([LanguageId]) REFERENCES [Languages]([Id])
)
