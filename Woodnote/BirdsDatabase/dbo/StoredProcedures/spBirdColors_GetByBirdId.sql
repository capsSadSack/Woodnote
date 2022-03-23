CREATE PROCEDURE [dbo].[spBirdColors_GetByBirdId]
	@birdId int,
	@languageId int = 1
AS
	--==================================================
	-- Без выбора LanguageId 
	--==================================================
	--SELECT [ColorId] as 'Id', [HexCode], [Name]
	--FROM
	--(SELECT *
	--	FROM dbo.BirdColors 
	--	WHERE BirdId = 1) q
	--	INNER JOIN  dbo.Colors ON Colors.Id = q.ColorId

	SELECT qq.Id as 'Id', [HexCode], ColorNames.Name
	FROM
	(
		SELECT [ColorId] as 'Id', [HexCode] , [Name]
		FROM
		(
			SELECT *
			FROM dbo.BirdColors
			WHERE BirdId = @birdId
		) q
		INNER JOIN  dbo.Colors ON Colors.Id = q.ColorId
	) qq

	INNER JOIN  dbo.ColorNames ON ColorNames.ColorId = qq.Id
	WHERE ColorNames.LanguageId = @languageId
RETURN 0
