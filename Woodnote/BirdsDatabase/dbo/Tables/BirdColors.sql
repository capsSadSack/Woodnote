CREATE TABLE [dbo].[BirdColors]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [BirdId] INT NOT NULL, 
    [ColorId] INT NOT NULL, 
    CONSTRAINT [FK_BirdColors_Birds] FOREIGN KEY ([BirdId]) REFERENCES [Birds]([Id]), 
    CONSTRAINT [FK_BirdColors_Colors] FOREIGN KEY ([ColorId]) REFERENCES [Colors]([Id])
)
