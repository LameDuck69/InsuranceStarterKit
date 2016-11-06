CREATE TABLE [dbo].[PersonEmailAddress] (
    [EmailAddressID]     INT NOT NULL,
    [PersonID]           INT NOT NULL,
    [EmailAddressTypeID] INT NOT NULL,
    CONSTRAINT [PK_PersonEmailAddress] PRIMARY KEY CLUSTERED ([EmailAddressID] ASC, [PersonID] ASC, [EmailAddressTypeID] ASC),
    CONSTRAINT [FK_PersonEmailAddress_EmailAddress] FOREIGN KEY ([EmailAddressID]) REFERENCES [dbo].[EmailAddress] ([ID]),
    CONSTRAINT [FK_PersonEmailAddress_EmailAddressType] FOREIGN KEY ([EmailAddressTypeID]) REFERENCES [dbo].[EmailAddressType] ([ID]),
    CONSTRAINT [FK_PersonEmailAddress_Person] FOREIGN KEY ([PersonID]) REFERENCES [dbo].[Person] ([ID])
);

