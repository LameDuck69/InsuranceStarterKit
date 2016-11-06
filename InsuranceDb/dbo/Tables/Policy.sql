CREATE TABLE [dbo].[Policy] (
    [ID]                 INT            NOT NULL,
    [PurchaserID]        INT            NOT NULL,
    [StartDate]          DATE           NOT NULL,
    [DurationInDays]     INT            NULL,
    [QuoteDate]          DATE           NOT NULL,
    [PolicyDefinitionID] INT            NOT NULL,
    [Premium]            DECIMAL (4, 2) NOT NULL,
    [PolicyAutoRenew]    BIT            DEFAULT ((1)) NOT NULL,
    [SoldByID]           INT            NOT NULL,
    [SnailMail]          BIT            DEFAULT ((0)) NOT NULL,
    PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [FK_Policy_PolicyDefinition] FOREIGN KEY ([PolicyDefinitionID]) REFERENCES [dbo].[PolicyDefinition] ([ID])
);


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'0 all docs and written comms via email - 1 using physical post', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Policy', @level2type = N'COLUMN', @level2name = N'SnailMail';

