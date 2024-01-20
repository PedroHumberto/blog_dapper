CREATE TABLE[Category](
    [Id] INT NOT NULL IDENTITY(1,1),
    [Name] VARCHAR(80) NOT NULL,
    [Slug] VARCHAR (80) NOT NULL,


    CONSTRAINT [Pk_Category] PRIMARY KEY ([Id]),
    CONSTRAINT [Uq_Category_Slug] UNIQUE ([Slug])
)
CREATE NONCLUSTERED INDEX [IX_Category_Slug] ON [Category]([Slug])

