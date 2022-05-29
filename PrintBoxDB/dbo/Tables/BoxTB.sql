CREATE TABLE [dbo].[BoxTB] (
    [Id]           INT           IDENTITY (1, 1) NOT NULL,
    [NameOfBox]    NVARCHAR (20) NULL,
    [Organization] NVARCHAR (20) NULL,
    [GroupName]    NVARCHAR (20) NULL,
    [CurrentTime]  TIMESTAMP    NOT NULL ,
    CONSTRAINT [PK__Boxes__3214EC07DA4AC5D7] PRIMARY KEY CLUSTERED ([Id] ASC)
);