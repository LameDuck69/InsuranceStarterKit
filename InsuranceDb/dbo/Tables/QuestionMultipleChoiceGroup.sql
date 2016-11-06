CREATE TABLE [dbo].[QuestionMultipleChoiceGroup] (
    [QuestionID]               INT NOT NULL,
    [QuestionMultipleChoiceID] INT NOT NULL,
    CONSTRAINT [PK_QuestionMultipleChoiceGroup] PRIMARY KEY CLUSTERED ([QuestionID] ASC, [QuestionMultipleChoiceID] ASC),
    CONSTRAINT [FK_QuestionMultipleChoiceGroup_Question] FOREIGN KEY ([QuestionID]) REFERENCES [dbo].[Question] ([ID]),
    CONSTRAINT [FK_QuestionMultipleChoiceGroup_QuestionMultiChoice] FOREIGN KEY ([QuestionID]) REFERENCES [dbo].[QuestionMultiChoice] ([ID])
);

