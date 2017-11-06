USE [PlantsCatalog]
GO
DROP TABLE Plants
/****** Object: Table [dbo].[Plants] Script Date: 10/28/2017 8:32:12 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Plants] (
    [ID]           INT          IDENTITY(1,1) PRIMARY KEY ,
    [COMMON]       NVARCHAR (MAX) NULL,
    [BOTANICAL]    NVARCHAR (MAX) NULL,
    [ZONE]         NVARCHAR (MAX) NULL,
    [LIGHT]        NVARCHAR (MAX) NULL,
    [PRICE]        NVARCHAR (max) NULL,
    [AVAILABILITY] NVARCHAR (MAX) NULL
);


--ALTER TABLE Plants DROP COLUMN ID
--ALTER TABLE Plants ADD ID INT IDENTITY(1,1)