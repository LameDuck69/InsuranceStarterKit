CREATE TABLE [dbo].[QuestionType] (
    [ID]                INT          NOT NULL,
    [QuiestionTypeName] VARCHAR (20) NOT NULL,
    CONSTRAINT [PK_QuestionType] PRIMARY KEY CLUSTERED ([ID] ASC)
);


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Possibly a free text answer', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'QuestionType', @level2type = N'COLUMN', @level2name = N'QuiestionTypeName';

