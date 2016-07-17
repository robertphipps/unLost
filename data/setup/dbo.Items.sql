CREATE TABLE [dbo].[Items] (
    [ItemId]     INT            IDENTITY (1000, 1) NOT NULL,
    [PupilId]    INT            NULL,
    [ItemCat]    INT            NOT NULL,
    [ItemSubcat] INT            NOT NULL,
    [ItemDesc]   NVARCHAR (MAX) NULL,
    [Added]      DATETIME       DEFAULT (getdate()) NOT NULL,
    [Mailed]     DATETIME       NULL,
    [Collected]  DATETIME       NULL,
    PRIMARY KEY CLUSTERED ([ItemId] ASC),
    CONSTRAINT [FK_Items_ToPupils] FOREIGN KEY ([PupilId]) REFERENCES [dbo].[Pupils] ([PupilId])
);

