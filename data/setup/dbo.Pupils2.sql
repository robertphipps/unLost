CREATE TABLE [dbo].[Pupils] (
    [PupilId]  INT            IDENTITY (1, 1) NOT NULL,
    [CandNo]   NCHAR (4)      NULL,
    [Surname]  NVARCHAR (50)  NOT NULL,
    [Forename] NVARCHAR (50)  NOT NULL,
    [TutorGp]  NVARCHAR (50)  NULL,
    [Email]    NVARCHAR (100) NULL,
    [Active]   BIT            DEFAULT ((1)) NOT NULL,
    PRIMARY KEY CLUSTERED ([PupilId] ASC)
);

