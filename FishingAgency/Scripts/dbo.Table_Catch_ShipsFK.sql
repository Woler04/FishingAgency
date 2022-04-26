GO
ALTER TABLE [dbo].[Catch] WITH NOCHECK
    ADD FOREIGN KEY ([ShipId]) REFERENCES [dbo].[FishingShips] ([Id]);

