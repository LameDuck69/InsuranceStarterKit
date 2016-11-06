CREATE TABLE [dbo].[QuestionRangeGroup] (
    [QuestionangeID] INT NOT NULL,
    [QuestionID]     INT NOT NULL,
    CONSTRAINT [PK_QuestionRangeGroup] PRIMARY KEY CLUSTERED ([QuestionangeID] ASC, [QuestionID] ASC),
    CONSTRAINT [FK_QuestionRangeGroup_Question] FOREIGN KEY ([QuestionID]) REFERENCES [dbo].[Question] ([ID]),
    CONSTRAINT [FK_QuestionRangeGroup_QuestionRange] FOREIGN KEY ([QuestionangeID]) REFERENCES [dbo].[QuestionRange] ([ID])
);

