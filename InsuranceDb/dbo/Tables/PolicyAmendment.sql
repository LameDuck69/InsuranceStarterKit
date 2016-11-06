CREATE TABLE [dbo].[PolicyAmendment] (
    [ID]              INT            NOT NULL,
    [PolicyID]        INT            NOT NULL,
    [AmendmentDate]   DATE           NOT NULL,
    [AmendmentTypeID] INT            NOT NULL,
    [PreviousPremium] DECIMAL (4, 2) NOT NULL,
    [AmmendedByID]    INT            NOT NULL,
    PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [FK_PolicyAmendment_Policy] FOREIGN KEY ([PolicyID]) REFERENCES [dbo].[Policy] ([ID]),
    CONSTRAINT [FK_PolicyAmendment_PolicyAmentmentType] FOREIGN KEY ([AmendmentTypeID]) REFERENCES [dbo].[PolicyAmentmentType] ([ID])
);

