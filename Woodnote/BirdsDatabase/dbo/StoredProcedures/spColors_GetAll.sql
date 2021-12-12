CREATE PROCEDURE [dbo].[spColors_GetAll]
	@languageId int = 1
AS
BEGIN
    --=======================================================
	-- Без использования LanguageId
	--=======================================================
	--SELECT [Id], [HexCode], [Name] 
	--FROM dbo.Colors

	SELECT ColorId as 'Id', [HexCode], ColorNames.Name
	FROM 
	(
		dbo.Colors
		INNER JOIN  dbo.ColorNames ON ColorNames.ColorId = Colors.Id
	)
	WHERE ColorNames.LanguageId = @languageId
END
