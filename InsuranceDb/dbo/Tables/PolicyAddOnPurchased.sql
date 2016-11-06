CREATE TABLE [dbo].[PolicyAddOnPurchased] (
    [AddOnID]  INT NOT NULL,
    [PolicyID] INT NOT NULL,
    CONSTRAINT [PK_PolicyAddOnPurchased] PRIMARY KEY CLUSTERED ([AddOnID] ASC, [PolicyID] ASC),
    CONSTRAINT [FK_PolicyAddOnPurchased_AddOn] FOREIGN KEY ([AddOnID]) REFERENCES [dbo].[AddOn] ([ID]),
    CONSTRAINT [FK_PolicyAddOnPurchased_Policy] FOREIGN KEY ([PolicyID]) REFERENCES [dbo].[Policy] ([ID])
);

