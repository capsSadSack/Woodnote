CREATE PROCEDURE [dbo].[spLanguages_GetAll]
AS
BEGIN
	SELECT [Id], [Name]
	FROM dbo.Languages
END
