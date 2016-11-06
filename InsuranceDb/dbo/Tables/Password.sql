CREATE TABLE [dbo].[Password] (
    [ID]           INT           IDENTITY (1, 1) NOT NULL,
    [Password]     VARCHAR (128) NOT NULL,
    [ModifiedBy]   VARCHAR (20)  NULL,
    [ModifiedDate] DATETIME      DEFAULT (getdate()) NOT NULL,
    PRIMARY KEY CLUSTERED ([ID] ASC)
);

