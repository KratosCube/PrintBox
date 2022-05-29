CREATE TABLE [dbo].[PrintBoxData]
(
	[NameOfBox] NVARCHAR(20) NOT NULL, 
    [Temperature] FLOAT NULL, 
    [Door] NVARCHAR(5) NOT NULL, 
    [Led] NVARCHAR(5) NOT NULL, 
    [Fan] FLOAT NULL, 
    [Time_recieved] DATETIME NULL, 
    [Id]           INT           IDENTITY (1, 1) NOT NULL,
    CONSTRAINT [PK_PrintBoxData] PRIMARY KEY CLUSTERED ([Id] ASC)
)
