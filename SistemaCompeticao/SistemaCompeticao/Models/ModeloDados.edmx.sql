
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 09/01/2019 12:22:58
-- Generated from EDMX file: C:\Users\Paula\Documents\Documentos IFSP\3° ANO\LP3\ProjetoLP3\SistemaCompeticao\SistemaCompeticao\Models\ModeloDados.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [CompeticaoDB];
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

-- Creating table 'Event'
CREATE TABLE [dbo].[Event] (
    [idEvent] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [EventDate] datetime  NOT NULL
);
GO

-- Creating table 'Battle'
CREATE TABLE [dbo].[Battle] (
    [idBattle] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [BattleHour] time  NOT NULL,
    [Event_idEvent] int  NOT NULL
);
GO

-- Creating table 'Artist'
CREATE TABLE [dbo].[Artist] (
    [idArtist] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [FormationYear] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Artist_has_Competition'
CREATE TABLE [dbo].[Artist_has_Competition] (
    [Artist_idArtist] int  NOT NULL,
    [Battle_idBattle] int  NOT NULL,
    [idArtist_has_Competition] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Member'
CREATE TABLE [dbo].[Member] (
    [idMember] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [CPF] nvarchar(max)  NOT NULL,
    [BirthDate] datetime  NOT NULL,
    [Artist_idArtist] int  NOT NULL
);
GO

-- Creating table 'Instrument'
CREATE TABLE [dbo].[Instrument] (
    [idInstrument] int IDENTITY(1,1) NOT NULL,
    [InstrumentType] nvarchar(max)  NOT NULL,
    [Music_idMusic] int  NOT NULL,
    [Member_idMember] int  NOT NULL
);
GO

-- Creating table 'Music'
CREATE TABLE [dbo].[Music] (
    [idMusic] int IDENTITY(1,1) NOT NULL,
    [Title] nvarchar(max)  NOT NULL,
    [MusicLength] time  NOT NULL,
    [Genre] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Artist_has_Music'
CREATE TABLE [dbo].[Artist_has_Music] (
    [Artist_idArtist] int  NOT NULL,
    [Music_idMusic] int  NOT NULL,
    [idArtist_has_Music] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [idEvent] in table 'Event'
ALTER TABLE [dbo].[Event]
ADD CONSTRAINT [PK_Event]
    PRIMARY KEY CLUSTERED ([idEvent] ASC);
GO

-- Creating primary key on [idBattle] in table 'Battle'
ALTER TABLE [dbo].[Battle]
ADD CONSTRAINT [PK_Battle]
    PRIMARY KEY CLUSTERED ([idBattle] ASC);
GO

-- Creating primary key on [idArtist] in table 'Artist'
ALTER TABLE [dbo].[Artist]
ADD CONSTRAINT [PK_Artist]
    PRIMARY KEY CLUSTERED ([idArtist] ASC);
GO

-- Creating primary key on [idArtist_has_Competition] in table 'Artist_has_Competition'
ALTER TABLE [dbo].[Artist_has_Competition]
ADD CONSTRAINT [PK_Artist_has_Competition]
    PRIMARY KEY CLUSTERED ([idArtist_has_Competition] ASC);
GO

-- Creating primary key on [idMember] in table 'Member'
ALTER TABLE [dbo].[Member]
ADD CONSTRAINT [PK_Member]
    PRIMARY KEY CLUSTERED ([idMember] ASC);
GO

-- Creating primary key on [idInstrument] in table 'Instrument'
ALTER TABLE [dbo].[Instrument]
ADD CONSTRAINT [PK_Instrument]
    PRIMARY KEY CLUSTERED ([idInstrument] ASC);
GO

-- Creating primary key on [idMusic] in table 'Music'
ALTER TABLE [dbo].[Music]
ADD CONSTRAINT [PK_Music]
    PRIMARY KEY CLUSTERED ([idMusic] ASC);
GO

-- Creating primary key on [idArtist_has_Music] in table 'Artist_has_Music'
ALTER TABLE [dbo].[Artist_has_Music]
ADD CONSTRAINT [PK_Artist_has_Music]
    PRIMARY KEY CLUSTERED ([idArtist_has_Music] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Event_idEvent] in table 'Battle'
ALTER TABLE [dbo].[Battle]
ADD CONSTRAINT [FK_EventBattle]
    FOREIGN KEY ([Event_idEvent])
    REFERENCES [dbo].[Event]
        ([idEvent])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EventBattle'
CREATE INDEX [IX_FK_EventBattle]
ON [dbo].[Battle]
    ([Event_idEvent]);
GO

-- Creating foreign key on [Artist_idArtist] in table 'Artist_has_Competition'
ALTER TABLE [dbo].[Artist_has_Competition]
ADD CONSTRAINT [FK_ArtistArtist_has_Competition]
    FOREIGN KEY ([Artist_idArtist])
    REFERENCES [dbo].[Artist]
        ([idArtist])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ArtistArtist_has_Competition'
CREATE INDEX [IX_FK_ArtistArtist_has_Competition]
ON [dbo].[Artist_has_Competition]
    ([Artist_idArtist]);
GO

-- Creating foreign key on [Battle_idBattle] in table 'Artist_has_Competition'
ALTER TABLE [dbo].[Artist_has_Competition]
ADD CONSTRAINT [FK_BattleArtist_has_Competition]
    FOREIGN KEY ([Battle_idBattle])
    REFERENCES [dbo].[Battle]
        ([idBattle])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_BattleArtist_has_Competition'
CREATE INDEX [IX_FK_BattleArtist_has_Competition]
ON [dbo].[Artist_has_Competition]
    ([Battle_idBattle]);
GO

-- Creating foreign key on [Artist_idArtist] in table 'Member'
ALTER TABLE [dbo].[Member]
ADD CONSTRAINT [FK_ArtistMember]
    FOREIGN KEY ([Artist_idArtist])
    REFERENCES [dbo].[Artist]
        ([idArtist])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ArtistMember'
CREATE INDEX [IX_FK_ArtistMember]
ON [dbo].[Member]
    ([Artist_idArtist]);
GO

-- Creating foreign key on [Artist_idArtist] in table 'Artist_has_Music'
ALTER TABLE [dbo].[Artist_has_Music]
ADD CONSTRAINT [FK_ArtistArtist_has_Music]
    FOREIGN KEY ([Artist_idArtist])
    REFERENCES [dbo].[Artist]
        ([idArtist])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ArtistArtist_has_Music'
CREATE INDEX [IX_FK_ArtistArtist_has_Music]
ON [dbo].[Artist_has_Music]
    ([Artist_idArtist]);
GO

-- Creating foreign key on [Music_idMusic] in table 'Artist_has_Music'
ALTER TABLE [dbo].[Artist_has_Music]
ADD CONSTRAINT [FK_MusicArtist_has_Music]
    FOREIGN KEY ([Music_idMusic])
    REFERENCES [dbo].[Music]
        ([idMusic])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MusicArtist_has_Music'
CREATE INDEX [IX_FK_MusicArtist_has_Music]
ON [dbo].[Artist_has_Music]
    ([Music_idMusic]);
GO

-- Creating foreign key on [Music_idMusic] in table 'Instrument'
ALTER TABLE [dbo].[Instrument]
ADD CONSTRAINT [FK_MusicInstrument]
    FOREIGN KEY ([Music_idMusic])
    REFERENCES [dbo].[Music]
        ([idMusic])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MusicInstrument'
CREATE INDEX [IX_FK_MusicInstrument]
ON [dbo].[Instrument]
    ([Music_idMusic]);
GO

-- Creating foreign key on [Member_idMember] in table 'Instrument'
ALTER TABLE [dbo].[Instrument]
ADD CONSTRAINT [FK_MemberInstrument]
    FOREIGN KEY ([Member_idMember])
    REFERENCES [dbo].[Member]
        ([idMember])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MemberInstrument'
CREATE INDEX [IX_FK_MemberInstrument]
ON [dbo].[Instrument]
    ([Member_idMember]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------