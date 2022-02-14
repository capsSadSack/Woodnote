CREATE PROCEDURE [dbo].[spBirds_GetById]
	@birdId int,
	@languageId int = 1
AS
	SELECT [dbo].[BirdNames].[BirdId] AS 'BirdId', 
	   [dbo].[BirdNames].[Name] AS 'Name', 
	   [GeneralTaxonomicRankName],
	   [TaxonomicRankName]   
	FROM
	(
		SELECT [BirdId], [BirdName], [TaxonomicRankName], 
			   [dbo].[GeneralTaxonomicRankNames].[Name] AS 'GeneralTaxonomicRankName'
		FROM
		(
			SELECT [dbo].[Birds].[Id] AS 'BirdId', 
					[dbo].[Birds].[Name] AS 'BirdName', 
					[dbo].[Birds].[TaxonomicRankId],
					[dbo].[TaxonomicRankNames].[Name] AS 'TaxonomicRankName',
					[dbo].[TaxonomicRanks].[GeneralTaxonomicRankId] AS 'GeneralTaxonomicRankId'
			FROM [WoodnoteDB].[dbo].[Birds]

			INNER JOIN  [dbo].[TaxonomicRanks] ON TaxonomicRanks.Id = [dbo].[Birds].[TaxonomicRankId]
			INNER JOIN  [dbo].[TaxonomicRankNames] ON TaxonomicRankNames.TaxonomicRankId = [dbo].[Birds].[TaxonomicRankId]
			WHERE LanguageId = @languageId AND BirdId = @birdId
		) q
		INNER JOIN  dbo.GeneralTaxonomicRanks ON GeneralTaxonomicRanks.Id = q.GeneralTaxonomicRankId
		INNER JOIN  dbo.GeneralTaxonomicRankNames ON GeneralTaxonomicRankNames.GeneralTaxonomicRankId = q.GeneralTaxonomicRankId
		WHERE LanguageId = @languageId 
	) qq
	INNER JOIN  dbo.BirdNames ON BirdNames.BirdId = qq.BirdId
	WHERE LanguageId = @languageId AND qq.BirdId = @birdId
RETURN 0
