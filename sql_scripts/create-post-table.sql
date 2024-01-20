CREATE TABLE [Post](
    [Id] INT NOT NULL IDENTITY(1,1),
    [CategoryId] INT NOT NULL,
    [AuthorId] INT NOT NULL,
    [Title] VARCHAR(160) NOT NULL,
    [Summary] VARCHAR(255) NOT NULL,
    [Body] TEXT NOT NULL,
    [Slug] VARCHAR(80) NOT NULL,
    [CreateDate] DATETIME NOT NULL DEFAULT(GETDATE()),
    [LastUpdate] DATETIME NOT NULL DEFAULT(GETDATE()),

    CONSTRAINT [Pk_Post] PRIMARY KEY ([Id]),
    CONSTRAINT [Fk_CategoryId] FOREIGN KEY ([CategoryId]) REFERENCES [Category]([Id]),
    CONSTRAINT [Fk_AuthorId] FOREIGN KEY ([AuthorId]) REFERENCES [User]([Id]),
    CONSTRAINT [Uq_Post_Slug] UNIQUE ([Slug])
)
CREATE NONCLUSTERED INDEX [IX_Post_Slug] ON [Post]([Slug]) 