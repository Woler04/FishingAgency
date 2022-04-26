GO
ALTER TABLE [dbo].[Users] WITH NOCHECK
    ADD FOREIGN KEY ([ShipId]) REFERENCES [dbo].[FishingShips] ([Id]);
