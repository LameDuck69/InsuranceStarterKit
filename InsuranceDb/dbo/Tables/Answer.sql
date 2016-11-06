CREATE TABLE [dbo].[Answer] (
    [ID]             INT           NOT NULL,
    [AnswerAsString] VARCHAR (MAX) NOT NULL,
    [QuestionID]     INT           NOT NULL,
    PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [FK_Answer_Question] FOREIGN KEY ([QuestionID]) REFERENCES [dbo].[Question] ([ID])
);

