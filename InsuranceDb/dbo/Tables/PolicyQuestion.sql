CREATE TABLE [dbo].[PolicyQuestion] (
    [PolicyDefinitionID] INT NOT NULL,
    [QuestionID]         INT NOT NULL,
    CONSTRAINT [PK_PolicyQuestion] PRIMARY KEY CLUSTERED ([PolicyDefinitionID] ASC, [QuestionID] ASC),
    CONSTRAINT [FK_PolicyQuestion_PolicyDefinition] FOREIGN KEY ([PolicyDefinitionID]) REFERENCES [dbo].[PolicyDefinition] ([ID]),
    CONSTRAINT [FK_PolicyQuestion_Question] FOREIGN KEY ([QuestionID]) REFERENCES [dbo].[Question] ([ID])
);

