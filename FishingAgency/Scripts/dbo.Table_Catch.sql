GO
CREATE TABLE [dbo].[Catch] (
    [Id]        INT        NOT NULL,
    [Amount]    FLOAT (53) NOT NULL,
    [Lenght]    FLOAT (53) NOT NULL,
    [StartDate] DATE       NOT NULL,
    [ShipId]    INT        NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

