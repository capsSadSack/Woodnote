CREATE TABLE [dbo].[Birds]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [TaxonomicRankId] INT NOT NULL, 
    [Name] NVARCHAR(100) NOT NULL, 
    CONSTRAINT [FK_Birds_TaxonomicRanks] FOREIGN KEY ([TaxonomicRankId]) REFERENCES [TaxonomicRanks]([Id])
)
