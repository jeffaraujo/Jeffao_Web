IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

CREATE TABLE [Perguntas] (
    [ID] int NOT NULL IDENTITY,
    [Autor] nvarchar(max) NULL,
    [Descricao] nvarchar(max) NOT NULL,
    CONSTRAINT [PK_Perguntas] PRIMARY KEY ([ID])
);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20180929174933_First', N'2.1.3-rtm-32065');

GO

