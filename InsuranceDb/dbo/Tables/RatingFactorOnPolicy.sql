CREATE TABLE [dbo].[RatingFactorOnPolicy] (
    [RatingFactorID] INT NOT NULL,
    [PolicyID]       INT NOT NULL,
    [AnswerID]       INT NOT NULL,
    CONSTRAINT [PK_RatingFactorOnPolicy] PRIMARY KEY CLUSTERED ([AnswerID] ASC, [PolicyID] ASC, [RatingFactorID] ASC),
    CONSTRAINT [FK_RatingFactorOnPolicy_Answer] FOREIGN KEY ([AnswerID]) REFERENCES [dbo].[Answer] ([ID]),
    CONSTRAINT [FK_RatingFactorOnPolicy_Policy] FOREIGN KEY ([PolicyID]) REFERENCES [dbo].[Policy] ([ID]),
    CONSTRAINT [FK_RatingFactorOnPolicy_RatingFactor] FOREIGN KEY ([RatingFactorID]) REFERENCES [dbo].[RatingFactor] ([ID])
);

