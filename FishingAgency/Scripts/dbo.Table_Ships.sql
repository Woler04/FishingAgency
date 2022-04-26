GO
CREATE TABLE [dbo].[FishingShips]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Name] NVARCHAR(50) NOT NULL, 
    [LicenseExpiration] DATE NOT NULL, 
    [isForHobby] BIT NOT NULL, 
    [FuelUsage] FLOAT NOT NULL
)
