CREATE TABLE [dbo].[TownInCounty] (
    [TownID]   INT NOT NULL,
    [CountyID] INT NOT NULL,
    CONSTRAINT [PK_TownInCounty] PRIMARY KEY CLUSTERED ([TownID] ASC, [CountyID] ASC),
    CONSTRAINT [FK_TownInCounty_City] FOREIGN KEY ([TownID]) REFERENCES [dbo].[Town] ([ID]),
    CONSTRAINT [FK_TownInCounty_Country] FOREIGN KEY ([CountyID]) REFERENCES [dbo].[Country] ([ID])
);

