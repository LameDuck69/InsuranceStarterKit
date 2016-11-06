CREATE TABLE [dbo].[AddOn] (
    [ID]                            INT            NOT NULL,
    [AddOnName]                     VARCHAR (30)   NOT NULL,
    [OneOffCost]                    DECIMAL (4, 2) NULL,
    [PercentPerPersonOrItemCovered] DECIMAL (2, 2) NULL,
    [PercentagePerPremium]          NCHAR (10)     NULL,
    [PercentagePayableCommision]    DECIMAL (2, 2) NULL,
    [ProviderID]                    INT            NULL,
    PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [FK_AddOn_Provider] FOREIGN KEY ([ProviderID]) REFERENCES [dbo].[Provider] ([ID])
);

