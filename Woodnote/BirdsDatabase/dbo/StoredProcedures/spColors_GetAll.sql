CREATE PROCEDURE [dbo].[spColors_GetAll]
AS
BEGIN
	SELECT [Id], [HexCode], [Name] 
	FROM dbo.Colors
END
