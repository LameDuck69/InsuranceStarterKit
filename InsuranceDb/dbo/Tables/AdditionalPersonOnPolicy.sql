CREATE TABLE [dbo].[AdditionalPersonOnPolicy] (
    [PersonID] INT NOT NULL,
    [PolicyId] INT NOT NULL,
    CONSTRAINT [PK_PolicyAdditionalPerson] PRIMARY KEY CLUSTERED ([PersonID] ASC, [PolicyId] ASC),
    CONSTRAINT [FK_AdditionalPersonOnPolicy_Person] FOREIGN KEY ([PersonID]) REFERENCES [dbo].[Person] ([ID]),
    CONSTRAINT [FK_AdditionalPersonOnPolicy_Policy] FOREIGN KEY ([PolicyId]) REFERENCES [dbo].[Policy] ([ID])
);

