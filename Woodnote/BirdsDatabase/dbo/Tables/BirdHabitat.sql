CREATE TABLE [dbo].[BirdHabitat]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [BirdId] INT NOT NULL, 
    [RegionId] INT NOT NULL, 
    CONSTRAINT [FK_BirdHabitat_Birds] FOREIGN KEY ([BirdId]) REFERENCES [Birds]([Id]), 
    CONSTRAINT [FK_BirdHabitat_Regions] FOREIGN KEY ([RegionId]) REFERENCES [Regions]([Id])
)
