CREATE TABLE [dbo].[PolicyDefinition] (
    [ID]                      INT          NOT NULL,
    [PolicyTypeID]            INT          NOT NULL,
    [DefinitionName]          VARCHAR (30) NOT NULL,
    [ProvidorOrUnderWriterID] INT          NULL,
    CONSTRAINT [PK_PolicyDefinition] PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [FK_PolicyDefinition_PolicyType] FOREIGN KEY ([PolicyTypeID]) REFERENCES [dbo].[PolicyType] ([ID]),
    CONSTRAINT [FK_PolicyDefinition_Provider] FOREIGN KEY ([ProvidorOrUnderWriterID]) REFERENCES [dbo].[Provider] ([ID])
);

