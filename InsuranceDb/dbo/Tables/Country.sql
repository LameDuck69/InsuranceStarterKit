CREATE TABLE [dbo].[Country] (
    [ID]          INT          IDENTITY (1, 1) NOT NULL,
    [CountryName] VARCHAR (20) NOT NULL,
    [CountryCode] VARCHAR (3)  NOT NULL,
    PRIMARY KEY CLUSTERED ([ID] ASC)
);

