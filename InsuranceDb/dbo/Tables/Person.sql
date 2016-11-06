CREATE TABLE [dbo].[Person] (
    [ID]                 INT          IDENTITY (1, 1) NOT NULL,
    [KnownAs]            VARCHAR (40) NOT NULL,
    [Title]              INT          NOT NULL,
    [FirstName]          VARCHAR (40) NOT NULL,
    [MiddleName]         VARCHAR (40) NULL,
    [LastName]           VARCHAR (40) NOT NULL,
    [DoB]                DATETIME     NOT NULL,
    [PostNominalLetters] VARCHAR (30) NULL,
    [PasswordID]         INT          NULL,
    [UserName]           VARCHAR (2)  NULL,
    [ModifiedBy]         VARCHAR (1)  NULL,
    [ModifiedDate]       DATETIME     DEFAULT (getdate()) NOT NULL,
    PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [FK_Person_Salutatiion] FOREIGN KEY ([Title]) REFERENCES [dbo].[Salutation] ([ID])
);

