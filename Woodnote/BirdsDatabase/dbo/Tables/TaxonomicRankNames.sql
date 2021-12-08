CREATE TABLE [dbo].[TaxonomicRankNames]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [TaxonomicRankId] INT NOT NULL, 
    [LanguageId] INT NOT NULL, 
    [Name] NVARCHAR(100) NULL, 
    CONSTRAINT [FK_TaxonomicRankNames_TaxonomicRanks] FOREIGN KEY ([TaxonomicRankId]) REFERENCES [TaxonomicRanks]([Id]), 
    CONSTRAINT [FK_TaxonomicRankNames_Languages] FOREIGN KEY ([LanguageId]) REFERENCES [Languages]([Id])
)
