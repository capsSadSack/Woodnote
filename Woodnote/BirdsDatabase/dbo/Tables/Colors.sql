CREATE TABLE [dbo].[Colors]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [HexCode] CHAR(7) NOT NULL, 
    [Name] NVARCHAR(50) NULL
)
