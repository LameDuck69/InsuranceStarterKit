CREATE TABLE [dbo].[Question] (
    [ID]             INT           NOT NULL,
    [QuestionText]   VARCHAR (MAX) NOT NULL,
    [QuestionTypeID] INT           NOT NULL,
    [RatingEffect]   NCHAR (10)    NULL,
    [QuestionHint]   VARCHAR (MAX) NULL,
    [GuiID]          INT           NULL,
    CONSTRAINT [PK_Question] PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [FK_Question_QuestionType] FOREIGN KEY ([QuestionTypeID]) REFERENCES [dbo].[QuestionType] ([ID])
);


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'0 - No rating effect : 1 rating factor must be applied', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Question', @level2type = N'COLUMN', @level2name = N'RatingEffect';

