CREATE TABLE [dbo].[Pictures] (
    [IdPic]     INT          IDENTITY (1, 1) NOT NULL,
    [PicParent] INT          NULL,
    [PicPoz]    VARCHAR (50) NULL,
    [PicName]   NTEXT NULL,
    [Pic]       IMAGE        NULL,
    PRIMARY KEY CLUSTERED ([IdPic] ASC)
);

