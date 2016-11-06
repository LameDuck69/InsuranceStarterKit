CREATE TABLE [dbo].[PersonAddress] (
    [PersonID]      INT NOT NULL,
    [AddressID]     INT NOT NULL,
    [AddressTypeID] INT NOT NULL,
    PRIMARY KEY CLUSTERED ([PersonID] ASC, [AddressID] ASC, [AddressTypeID] ASC),
    CONSTRAINT [FK_PersonAddress_Address] FOREIGN KEY ([AddressID]) REFERENCES [dbo].[Address] ([ID]),
    CONSTRAINT [FK_PersonAddress_AddressType] FOREIGN KEY ([AddressTypeID]) REFERENCES [dbo].[AddressType] ([ID]),
    CONSTRAINT [FK_PersonAddress_Person] FOREIGN KEY ([PersonID]) REFERENCES [dbo].[Person] ([ID])
);

