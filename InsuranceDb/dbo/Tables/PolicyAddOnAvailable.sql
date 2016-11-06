CREATE TABLE [dbo].[PolicyAddOnAvailable] (
    [AddonID]  INT NOT NULL,
    [PolicyID] INT NOT NULL,
    CONSTRAINT [PK_PolicyAddOnAvailable] PRIMARY KEY CLUSTERED ([AddonID] ASC, [PolicyID] ASC),
    CONSTRAINT [FK_PolicyAddOnAvailable_AddOn] FOREIGN KEY ([AddonID]) REFERENCES [dbo].[AddOn] ([ID]),
    CONSTRAINT [FK_PolicyAddOnAvailable_PolicyDefinition] FOREIGN KEY ([PolicyID]) REFERENCES [dbo].[PolicyDefinition] ([ID])
);

