﻿CREATE TABLE [dbo].[Trip]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1, 1), 
    [Name] NCHAR(100) NOT NULL, 
    [Description] NVARCHAR(MAX) NOT NULL
)
