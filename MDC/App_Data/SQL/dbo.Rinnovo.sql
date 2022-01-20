
USE [DatabaseMDC]
GO

IF EXISTS(SELECT * FROM sys.tables WHERE SCHEMA_NAME(schema_id) LIKE 'dbo' AND name like 'Rinnovi')  
	DROP TABLE [dbo].[Rinnovo];
GO

CREATE TABLE [dbo].[Rinnovo]
(
    [IdRinnovo]          UNIQUEIDENTIFIER NOT NULL,
    [IdSocio]            UNIQUEIDENTIFIER NOT NULL,
    [Data]               DATE             NOT NULL,
    [Anno1]              INT              NULL,
    [Anno2]              INT              NULL,
    [QuotaIscrizione]    REAL			  NOT NULL
    CONSTRAINT [PK_Rinnovi] PRIMARY KEY CLUSTERED ([IdRinnovo]),
);
GO

CREATE INDEX [IX_Rinnovi_IdSocio] ON [dbo].[Rinnovo] ([IdSocio]);
GO

ALTER TABLE [dbo].[Rinnovo] ADD CONSTRAINT [FK_Rinnovi_Socio]
								 FOREIGN KEY ([IdSocio]) REFERENCES [dbo].[Socio] ([IdSocio])
								 ON DELETE NO ACTION;
GO
