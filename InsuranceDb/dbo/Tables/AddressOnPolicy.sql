CREATE TABLE [dbo].[AddressOnPolicy] (
    [AddressID] INT NOT NULL,
    [PolicyID]  INT NOT NULL,
    CONSTRAINT [PK_AddressOnPolicy] PRIMARY KEY CLUSTERED ([AddressID] ASC, [PolicyID] ASC),
    CONSTRAINT [FK_AddressOnPolicy_Address] FOREIGN KEY ([AddressID]) REFERENCES [dbo].[Address] ([ID]),
    CONSTRAINT [FK_AddressOnPolicy_Policy] FOREIGN KEY ([PolicyID]) REFERENCES [dbo].[Policy] ([ID])
);

