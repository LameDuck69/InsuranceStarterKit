CREATE TABLE [dbo].[PhoneNumber] (
    [ID]           INT          IDENTITY (1, 1) NOT NULL,
    [PhoneNumber]  VARCHAR (40) NOT NULL,
    [ModifiedBy]   VARCHAR (20) NULL,
    [ModifiedDate] DATETIME     DEFAULT (getdate()) NOT NULL,
    PRIMARY KEY CLUSTERED ([ID] ASC)
);

