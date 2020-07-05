
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 05/25/2020 21:36:32
-- Generated from EDMX file: D:\C_Sharp_code\ADO\CS_demo03\School.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [School];
GO
IF SCHEMA_ID(N'Student') IS NULL EXECUTE(N'CREATE SCHEMA [Student]');
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

-- Creating table 'Course'
CREATE TABLE [Student].[Course] (
    [CourseId] int IDENTITY(1,1) NOT NULL,
    [CourseName] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'ClassRoom'
CREATE TABLE [Student].[ClassRoom] (
    [ClassRoomId] int IDENTITY(1,1) NOT NULL,
    [Course_Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [CourseId] in table 'Course'
ALTER TABLE [Student].[Course]
ADD CONSTRAINT [PK_Course]
    PRIMARY KEY CLUSTERED ([CourseId] ASC);
GO

-- Creating primary key on [ClassRoomId] in table 'ClassRoom'
ALTER TABLE [Student].[ClassRoom]
ADD CONSTRAINT [PK_ClassRoom]
    PRIMARY KEY CLUSTERED ([ClassRoomId] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Course_Id] in table 'ClassRoom'
ALTER TABLE [Student].[ClassRoom]
ADD CONSTRAINT [FK_CourseClassRoom]
    FOREIGN KEY ([Course_Id])
    REFERENCES [Student].[Course]
        ([CourseId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CourseClassRoom'
CREATE INDEX [IX_FK_CourseClassRoom]
ON [Student].[ClassRoom]
    ([Course_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------