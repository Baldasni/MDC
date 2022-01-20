
USE [DatabaseMDC]
GO

IF EXISTS(SELECT * FROM sys.tables WHERE SCHEMA_NAME(schema_id) LIKE 'dbo' AND name like 'Consulenza')  
	DROP TABLE [dbo].[Consulenza];
GO

CREATE TABLE [dbo].[Consulenza]
(
    [IdConsulenza]          UNIQUEIDENTIFIER  NOT NULL,
    [IdSocio]               UNIQUEIDENTIFIER      NULL,
    [DataConsulenza]        DATE              NOT NULL,
    [IdTipologiaPratica]    INTEGER			  NOT NULL,
    [DescrizioneConsulenza] NVARCHAR (200)    NOT NULL,
    [IdTipologiaContatto]   INTEGER			      NULL,
	[Nominativo] 		    NVARCHAR (50)         NULL,
	[Email] 			    NVARCHAR (50)         NULL,
	[IdComune] 			    INTEGER               NULL
    CONSTRAINT [PK_Consulenza] PRIMARY KEY CLUSTERED ([IdConsulenza])
);
GO

CREATE INDEX [IX_Consulenza_IdSocio] ON [dbo].[Consulenza] ([IdSocio]);
GO

ALTER TABLE [dbo].[Consulenza] ADD CONSTRAINT [FK_Consulenza_Socio]
								    FOREIGN KEY ([IdSocio]) REFERENCES [dbo].[Socio] ([IdSocio])
								    ON DELETE NO ACTION;
GO

ALTER TABLE [dbo].[Consulenza] ADD CONSTRAINT [FK_Consulenza_TipologiaPratica]
									FOREIGN KEY ([IdTipologiaPratica]) REFERENCES [dbo].[TipologiaPratica] ([IdTipologiaPratica])
									ON DELETE NO ACTION;
GO

ALTER TABLE [dbo].[Consulenza] ADD CONSTRAINT [FK_Consulenza_TipologiaContatto]
									FOREIGN KEY ([IdTipologiaContatto]) REFERENCES [dbo].[TipologiaContatto] ([IdTipologiaContatto])
									ON DELETE NO ACTION;
GO

ALTER TABLE [dbo].[Consulenza] ADD CONSTRAINT [FK_Consulenza_Comune]
									FOREIGN KEY ([IdComune]) REFERENCES [dbo].[Comune] ([IdComune])
									ON DELETE NO ACTION;
GO