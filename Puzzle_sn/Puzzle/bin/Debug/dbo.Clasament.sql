CREATE TABLE [dbo].[Clasament] (
    [IdUser]    INT          IDENTITY (1, 1) NOT NULL,
    [Nume]      VARCHAR (50) NULL,
    [Timp]      VARCHAR(50)     NULL,
    [Patratele] INT          NULL,
    PRIMARY KEY CLUSTERED ([IdUser] ASC)
);

