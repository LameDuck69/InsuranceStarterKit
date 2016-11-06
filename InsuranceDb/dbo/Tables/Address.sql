CREATE TABLE [dbo].[Address] (
    [ID]              INT               IDENTITY (1, 1) NOT NULL,
    [AddressLine1]    VARCHAR (60)      NOT NULL,
    [AddressLine2]    VARCHAR (60)      NULL,
    [CityID]          INT               NOT NULL,
    [CountyID]        INT               NOT NULL,
    [CountryID]       INT               NOT NULL,
    [PostCode]        VARCHAR (15)      NOT NULL,
    [SpatialLocation] [sys].[geography] NULL,
    [ModifiedDate]    DATETIME          DEFAULT (getdate()) NOT NULL,
    [ModifiedBy]      VARCHAR (20)      NOT NULL,
    PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [FK_Address_City] FOREIGN KEY ([CityID]) REFERENCES [dbo].[Town] ([ID]),
    CONSTRAINT [FK_Address_Country] FOREIGN KEY ([CountryID]) REFERENCES [dbo].[Country] ([ID]),
    CONSTRAINT [FK_Address_County] FOREIGN KEY ([CountyID]) REFERENCES [dbo].[County] ([ID])
);

