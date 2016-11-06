CREATE TABLE [dbo].[PersonPhone] (
    [PersonID]          INT NOT NULL,
    [PhoneNumberID]     INT NOT NULL,
    [PhoneNumberTypeID] INT NOT NULL,
    CONSTRAINT [PK_PersonPhone] PRIMARY KEY CLUSTERED ([PersonID] ASC, [PhoneNumberID] ASC, [PhoneNumberTypeID] ASC),
    CONSTRAINT [FK_PersonPhone_Person] FOREIGN KEY ([PersonID]) REFERENCES [dbo].[Person] ([ID]),
    CONSTRAINT [FK_PersonPhone_PhoneNumber] FOREIGN KEY ([PhoneNumberID]) REFERENCES [dbo].[PhoneNumber] ([ID]),
    CONSTRAINT [FK_PersonPhone_PhoneNumberType] FOREIGN KEY ([PhoneNumberTypeID]) REFERENCES [dbo].[PhoneNumberType] ([ID])
);

