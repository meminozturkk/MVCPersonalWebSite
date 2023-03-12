
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 03/09/2023 17:22:42
-- Generated from EDMX file: C:\Users\muham\OneDrive\Masaüstü\fds\PersonalWebSite\Models\Entity\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [DbCv];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[TblAbout]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TblAbout];
GO
IF OBJECT_ID(N'[dbo].[TblAdmin]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TblAdmin];
GO
IF OBJECT_ID(N'[dbo].[TblCertificate]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TblCertificate];
GO
IF OBJECT_ID(N'[dbo].[TblContact]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TblContact];
GO
IF OBJECT_ID(N'[dbo].[TblEducation]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TblEducation];
GO
IF OBJECT_ID(N'[dbo].[TblExperience]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TblExperience];
GO
IF OBJECT_ID(N'[dbo].[TblInterest]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TblInterest];
GO
IF OBJECT_ID(N'[dbo].[TblSkill]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TblSkill];
GO
IF OBJECT_ID(N'[dbo].[TblSocialMedia]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TblSocialMedia];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'TblAbouts'
CREATE TABLE [dbo].[TblAbouts] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] varchar(25)  NULL,
    [Surname] varchar(20)  NULL,
    [Address] varchar(max)  NULL,
    [Telephone] varchar(20)  NULL,
    [Mail] varchar(50)  NULL,
    [Explanation] varchar(max)  NULL,
    [Image] varchar(100)  NULL
);
GO

-- Creating table 'TblAdmins'
CREATE TABLE [dbo].[TblAdmins] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Username] varchar(20)  NULL,
    [Password] varchar(20)  NULL
);
GO

-- Creating table 'TblCertificates'
CREATE TABLE [dbo].[TblCertificates] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Explanation] varchar(1000)  NULL
);
GO

-- Creating table 'TblContacts'
CREATE TABLE [dbo].[TblContacts] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [NameSurname] varchar(75)  NULL,
    [Mail] varchar(50)  NULL,
    [Topic] varchar(50)  NULL,
    [Message] varchar(1000)  NULL,
    [Date] datetime  NULL
);
GO

-- Creating table 'TblEducations'
CREATE TABLE [dbo].[TblEducations] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Title] varchar(50)  NULL,
    [Subtitle1] varchar(250)  NULL,
    [Subtitle2] varchar(500)  NULL,
    [GNO] varchar(10)  NULL,
    [Date] varchar(50)  NULL
);
GO

-- Creating table 'TblExperiences'
CREATE TABLE [dbo].[TblExperiences] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Title] varchar(50)  NULL,
    [Subtitle] varchar(100)  NULL,
    [Explanation] varchar(max)  NULL,
    [Date] varchar(max)  NULL
);
GO

-- Creating table 'TblSkills'
CREATE TABLE [dbo].[TblSkills] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Skill] varchar(100)  NULL,
    [Rate] tinyint  NULL
);
GO

-- Creating table 'TblInterests'
CREATE TABLE [dbo].[TblInterests] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Explanation1] varchar(1000)  NULL,
    [Explanation2] varchar(500)  NULL
);
GO

-- Creating table 'TblSocialMedias'
CREATE TABLE [dbo].[TblSocialMedias] (
    [ID] tinyint  NOT NULL,
    [Name] varchar(20)  NULL,
    [Link] nchar(100)  NULL,
    [Icon] varchar(25)  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'TblAbouts'
ALTER TABLE [dbo].[TblAbouts]
ADD CONSTRAINT [PK_TblAbouts]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'TblAdmins'
ALTER TABLE [dbo].[TblAdmins]
ADD CONSTRAINT [PK_TblAdmins]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'TblCertificates'
ALTER TABLE [dbo].[TblCertificates]
ADD CONSTRAINT [PK_TblCertificates]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'TblContacts'
ALTER TABLE [dbo].[TblContacts]
ADD CONSTRAINT [PK_TblContacts]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'TblEducations'
ALTER TABLE [dbo].[TblEducations]
ADD CONSTRAINT [PK_TblEducations]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'TblExperiences'
ALTER TABLE [dbo].[TblExperiences]
ADD CONSTRAINT [PK_TblExperiences]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'TblSkills'
ALTER TABLE [dbo].[TblSkills]
ADD CONSTRAINT [PK_TblSkills]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'TblInterests'
ALTER TABLE [dbo].[TblInterests]
ADD CONSTRAINT [PK_TblInterests]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [ID] in table 'TblSocialMedias'
ALTER TABLE [dbo].[TblSocialMedias]
ADD CONSTRAINT [PK_TblSocialMedias]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------