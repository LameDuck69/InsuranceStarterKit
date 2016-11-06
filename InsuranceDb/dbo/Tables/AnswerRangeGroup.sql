CREATE TABLE [dbo].[AnswerRangeGroup] (
    [AnswerID]        INT NOT NULL,
    [QuestionRangeID] INT NOT NULL,
    CONSTRAINT [PK_AnswerRangeGroup] PRIMARY KEY CLUSTERED ([AnswerID] ASC, [QuestionRangeID] ASC),
    CONSTRAINT [FK_AnswerRangeGroup_Answer] FOREIGN KEY ([AnswerID]) REFERENCES [dbo].[Answer] ([ID]),
    CONSTRAINT [FK_AnswerRangeGroup_QuestionRange] FOREIGN KEY ([QuestionRangeID]) REFERENCES [dbo].[QuestionRange] ([ID])
);

