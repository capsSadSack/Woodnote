CREATE TABLE [dbo].[GeneralTaxonomicRankNames]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [GeneralTaxonomicRankId] INT NOT NULL, 
    [LanguageId] INT NOT NULL, 
    [Name] NVARCHAR(100) NOT NULL, 
    CONSTRAINT [FK_GeneralTaxonomicRankNames_GeneralTaxonomicRanks] FOREIGN KEY ([GeneralTaxonomicRankId]) REFERENCES [GeneralTaxonomicRanks]([Id]), 
    CONSTRAINT [FK_GeneralTaxonomicRankNames_Languages] FOREIGN KEY ([LanguageId]) REFERENCES [Languages]([Id])
)
