CREATE TABLE [dbo].[PersonPassword] (
    [PersonID]       INT NOT NULL,
    [PasswordID]     INT NOT NULL,
    [TargetSystemID] INT NOT NULL,
    CONSTRAINT [PK_PersonPassword] PRIMARY KEY CLUSTERED ([PersonID] ASC, [PasswordID] ASC, [TargetSystemID] ASC),
    CONSTRAINT [FK_PersonPassword_Password] FOREIGN KEY ([PasswordID]) REFERENCES [dbo].[Password] ([ID]),
    CONSTRAINT [FK_PersonPassword_Person] FOREIGN KEY ([PersonID]) REFERENCES [dbo].[Person] ([ID])
);

