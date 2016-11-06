CREATE TABLE [dbo].[CountryInRegion] (
    [GlobalRegionID] INT NOT NULL,
    [CountryID]      INT NOT NULL,
    [RegionSetID]    INT NOT NULL,
    CONSTRAINT [PK_CountryInRegion] PRIMARY KEY CLUSTERED ([GlobalRegionID] ASC, [CountryID] ASC, [RegionSetID] ASC),
    CONSTRAINT [FK_CountryInRegion_Country] FOREIGN KEY ([CountryID]) REFERENCES [dbo].[Country] ([ID]),
    CONSTRAINT [FK_CountryInRegion_GlobalRegion] FOREIGN KEY ([GlobalRegionID]) REFERENCES [dbo].[GlobalRegion] ([ID]),
    CONSTRAINT [FK_CountryInRegion_GlobalRegionSet] FOREIGN KEY ([RegionSetID]) REFERENCES [dbo].[GlobalRegionSet] ([ID])
);

