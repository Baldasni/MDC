
USE [DatabaseMDC]
GO

IF EXISTS(SELECT * FROM sys.tables WHERE SCHEMA_NAME(schema_id) LIKE 'dbo' AND name like 'Pratica')  
	DROP TABLE [dbo].[Pratica];
GO

CREATE TABLE [dbo].[Pratica]
(
    [IdPratica]            UNIQUEIDENTIFIER NOT NULL,
    [IdSocio]              UNIQUEIDENTIFIER NOT NULL,
    [IdSportello]          INTEGER			NOT NULL,
    [DataPratica]          DATE             NOT NULL,
    [IdTipologiaPratica]   INTEGER			NOT NULL,
    [DescrizionePratica]   NVARCHAR (200)   NOT NULL,
    [IdStatoPratica]       INTEGER			NOT NULL,
	[DescrizioneRiscontro] NVARCHAR (200)       NULL,
	[Note]				   NVARCHAR (200)       NULL
    CONSTRAINT [PK_Pratica] PRIMARY KEY CLUSTERED ([IdPratica])
);
GO

CREATE INDEX [IX_Pratica_IdSocio] ON [dbo].[Pratica] ([IdSocio]);
GO

ALTER TABLE [dbo].[Pratica] ADD CONSTRAINT [FK_Pratica_Socio]
								  FOREIGN KEY ([IdSocio]) REFERENCES [dbo].[Socio] ([IdSocio])
								  ON DELETE NO ACTION;
GO

ALTER TABLE [dbo].[Pratica] ADD CONSTRAINT [FK_Pratica_Sportello]
								  FOREIGN KEY ([IdSportello]) REFERENCES [dbo].[Sportello] ([IdSportello])
								  ON DELETE NO ACTION;
GO

ALTER TABLE [dbo].[Pratica] ADD CONSTRAINT [FK_Pratica_TipologiaPratica]
								  FOREIGN KEY ([IdTipologiaPratica]) REFERENCES [dbo].[TipologiaPratica] ([IdTipologiaPratica])
								  ON DELETE NO ACTION;
GO

ALTER TABLE [dbo].[Pratica] ADD CONSTRAINT [FK_Pratica_StatiPratica]
								  FOREIGN KEY ([IdStatoPratica]) REFERENCES [dbo].[StatoPratica] ([IdStatoPratica])
								  ON DELETE NO ACTION;
GO