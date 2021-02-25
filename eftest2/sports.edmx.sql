
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 02/22/2021 12:57:20
-- Generated from EDMX file: G:\test\eftest2\eftest2\sports.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [mydb];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'sports'
CREATE TABLE [dbo].[sports] (
    [sportid] int IDENTITY(1,1) NOT NULL,
    [sportname] nvarchar(30)  NOT NULL,
    [sporttype] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [sportid] in table 'sports'
ALTER TABLE [dbo].[sports]
ADD CONSTRAINT [PK_sports]
    PRIMARY KEY CLUSTERED ([sportid] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------