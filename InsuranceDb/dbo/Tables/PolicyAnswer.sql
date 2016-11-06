CREATE TABLE [dbo].[PolicyAnswer] (
    [PolicyID] INT NOT NULL,
    [AnswerID] INT NOT NULL,
    CONSTRAINT [PK_PolicyAnswer] PRIMARY KEY CLUSTERED ([PolicyID] ASC, [AnswerID] ASC),
    CONSTRAINT [FK_PolicyAnswer_Answer] FOREIGN KEY ([AnswerID]) REFERENCES [dbo].[Answer] ([ID]),
    CONSTRAINT [FK_PolicyAnswer_Policy] FOREIGN KEY ([PolicyID]) REFERENCES [dbo].[Policy] ([ID])
);

