﻿CREATE PROCEDURE [dbo].[spBirds_GetByTaxonomicRankName]
	@taxonomicRankName int = 0,
	@languageId int
AS
	SELECT 
	    dbo.Birds.Id AS 'Id',
        dbo.BirdNames.Name AS 'Name',
	    dbo.GeneralTaxonomicRankNames.Name AS 'GeneralTaxonomicRankName',
	    dbo.TaxonomicRankNames.Name AS 'TaxonomicRankName',
	    dbo.TaxonomicRanks.Name AS 'TaxonomicRankNameEn'
    FROM dbo.Birds 
		LEFT JOIN  dbo.TaxonomicRanks ON TaxonomicRanks.Id = dbo.Birds.TaxonomicRankId
		LEFT JOIN  dbo.TaxonomicRankNames ON TaxonomicRankNames.TaxonomicRankId = dbo.Birds.TaxonomicRankId
		LEFT JOIN  dbo.GeneralTaxonomicRanks ON GeneralTaxonomicRanks.Id = GeneralTaxonomicRankId
		LEFT JOIN  dbo.BirdNames ON BirdNames.BirdId = dbo.Birds.Id
		LEFT JOIN  dbo.GeneralTaxonomicRankNames ON GeneralTaxonomicRankNames.GeneralTaxonomicRankId = GeneralTaxonomicRanks.Id
	WHERE 
		dbo.TaxonomicRanks.Name LIKE @taxonomicRankName AND
		BirdNames.LanguageId = @languageId AND 
		GeneralTaxonomicRankNames.LanguageId = @languageId AND 
		TaxonomicRankNames.LanguageId = @languageId
RETURN 0
