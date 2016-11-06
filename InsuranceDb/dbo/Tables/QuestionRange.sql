CREATE TABLE [dbo].[QuestionRange] (
    [ID]         INT          NOT NULL,
    [RangeStart] VARCHAR (50) NOT NULL,
    [RangeEnd]   VARCHAR (50) NOT NULL,
    CONSTRAINT [PK_QuestionRange] PRIMARY KEY CLUSTERED ([ID] ASC)
);

