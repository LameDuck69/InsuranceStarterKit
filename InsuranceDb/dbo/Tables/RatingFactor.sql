CREATE TABLE [dbo].[RatingFactor] (
    [ID]               INT            NOT NULL,
    [RatingOperator]   INT            DEFAULT ((1)) NULL,
    [RatingOperand]    DECIMAL (4, 4) NULL,
    [RatingbaseRateID] INT            NOT NULL,
    PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [FK_RatingFactor_RatingBaseRate] FOREIGN KEY ([RatingbaseRateID]) REFERENCES [dbo].[RatingBaseRate] ([ID])
);


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Rate versioning through this', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'RatingFactor', @level2type = N'COLUMN', @level2name = N'RatingbaseRateID';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'1 = * : 2 = + : 3  = - : 4 = / :', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'RatingFactor', @level2type = N'COLUMN', @level2name = N'RatingOperator';

