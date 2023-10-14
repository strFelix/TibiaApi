IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

CREATE TABLE [TB_ACCOUNTS] (
    [Id] int NOT NULL IDENTITY,
    [Username] nvarchar(max) NOT NULL,
    [Email] nvarchar(max) NOT NULL,
    [PasswordString] nvarchar(max) NOT NULL,
    [PasswordHash] varbinary(max) NULL,
    [PasswordSalt] varbinary(max) NULL,
    [CreationDate] datetime2 NOT NULL,
    [AcessDate] datetime2 NULL,
    CONSTRAINT [PK_TB_ACCOUNTS] PRIMARY KEY ([Id])
);
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'AcessDate', N'CreationDate', N'Email', N'PasswordHash', N'PasswordSalt', N'PasswordString', N'Username') AND [object_id] = OBJECT_ID(N'[TB_ACCOUNTS]'))
    SET IDENTITY_INSERT [TB_ACCOUNTS] ON;
INSERT INTO [TB_ACCOUNTS] ([Id], [AcessDate], [CreationDate], [Email], [PasswordHash], [PasswordSalt], [PasswordString], [Username])
VALUES (1, NULL, '2023-10-14T00:00:00.0000000', N'beta.tester@gmail.com', 0x0E60CEF8CB1F872034ED2BB275F8092EE80B17E2C689A689BDA12AD4DD1C3678F1AC4D34BEB9FEB68DCD040885FC23DF68EE33FD7796FF599C9D5D866D1BFC96, 0xE84EFC6DA5B02F75653D48D76CBE90E3B0EC0DC332757E4112E156A34A6331E54D4E942AA04FB144465B4E52666B4EC7E0AE81BE84C70D2F58D0A67D66739AC3DC88DEB6555CE51114AC466542B61CC201EE87229037B2276D02465E4D53E740605E898A594EEFF0951AF09CDCF8E61C696D5F0BE5919FC769397572E30A05C9, N'', N'BetaTester');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'AcessDate', N'CreationDate', N'Email', N'PasswordHash', N'PasswordSalt', N'PasswordString', N'Username') AND [object_id] = OBJECT_ID(N'[TB_ACCOUNTS]'))
    SET IDENTITY_INSERT [TB_ACCOUNTS] OFF;
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20231014142203_InitialCreate', N'7.0.12');
GO

COMMIT;
GO

