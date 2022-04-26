﻿CREATE TABLE [dbo].[Catch] (
    [Id]        INT        NOT NULL,
    [Amount]    FLOAT (53) NOT NULL,
    [Lenght]    FLOAT (53) NOT NULL,
    [StartDate] DATE       NOT NULL,
    [ShipId]    INT        NOT NULL FOREIGN KEY ([ShipId]) REFERENCES FishingShips([Id]),
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

