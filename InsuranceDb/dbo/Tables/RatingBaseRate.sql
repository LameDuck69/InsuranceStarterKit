CREATE TABLE [dbo].[RatingBaseRate] (
    [ID]         INT            NOT NULL,
    [ProviderID] INT            NOT NULL,
    [ValidFrom]  DATETIME       DEFAULT (getdate()) NOT NULL,
    [ValidTo]    DATETIME       NULL,
    [BaseRate]   DECIMAL (4, 2) NOT NULL,
    PRIMARY KEY CLUSTERED ([ID] ASC)
);

