CREATE TABLE [dbo].[Blogs] (
    [BlogId]       INT            IDENTITY (1, 1) NOT NULL,
    [CreationDate] DATETIME       NOT NULL,
    [Description]  TEXT           NULL,
    [Title]        NVARCHAR (250) NOT NULL,
    [Rating]       FLOAT          NOT NULL,
    PRIMARY KEY CLUSTERED ([BlogId] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF)
);

