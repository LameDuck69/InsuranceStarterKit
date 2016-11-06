CREATE TABLE [dbo].[EmailAddress] (
    [ID]           INT          IDENTITY (1, 1) NOT NULL,
    [EmailAddress] VARCHAR (50) NULL,
    [ModifiedBy]   VARCHAR (20) NULL,
    [ModifiedDate] DATETIME     DEFAULT (getdate()) NOT NULL,
    PRIMARY KEY CLUSTERED ([ID] ASC)
);

