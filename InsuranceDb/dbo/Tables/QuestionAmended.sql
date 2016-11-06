CREATE TABLE [dbo].[QuestionAmended] (
    [QuestionID]        INT NOT NULL,
    [PolicyAmendmentID] INT NOT NULL,
    CONSTRAINT [PK_QuestionAmended] PRIMARY KEY CLUSTERED ([QuestionID] ASC, [PolicyAmendmentID] ASC),
    CONSTRAINT [FK_QuestionAmended_PolicyAmendment] FOREIGN KEY ([PolicyAmendmentID]) REFERENCES [dbo].[PolicyAmendment] ([ID]),
    CONSTRAINT [FK_QuestionAmended_Question] FOREIGN KEY ([QuestionID]) REFERENCES [dbo].[Question] ([ID])
);

