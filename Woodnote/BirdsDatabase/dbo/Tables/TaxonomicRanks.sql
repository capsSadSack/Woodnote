CREATE TABLE [dbo].[TaxonomicRanks]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [ParentId] INT NULL, 
    [GeneralTaxonomicRankId] INT NOT NULL, 
    [Name] NVARCHAR(100) NULL, 
    CONSTRAINT [FK_TaxonomicRanks_GeneralTaxonomicRanks] FOREIGN KEY ([GeneralTaxonomicRankId]) REFERENCES [GeneralTaxonomicRanks]([Id])
)
