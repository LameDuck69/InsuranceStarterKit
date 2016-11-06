CREATE TABLE [dbo].[PersonLogin] (
    [PersonID]       INT NOT NULL,
    [LoginID]        INT NOT NULL,
    [targetSystemID] INT NOT NULL,
    CONSTRAINT [PK_PersonLogin] PRIMARY KEY CLUSTERED ([PersonID] ASC, [LoginID] ASC, [targetSystemID] ASC),
    CONSTRAINT [FK_PersonLogin_Login] FOREIGN KEY ([LoginID]) REFERENCES [dbo].[Login] ([ID]),
    CONSTRAINT [FK_PersonLogin_Person] FOREIGN KEY ([PersonID]) REFERENCES [dbo].[Person] ([ID]),
    CONSTRAINT [FK_PersonLogin_TargetSystem] FOREIGN KEY ([targetSystemID]) REFERENCES [dbo].[TargetSystem] ([ID])
);

