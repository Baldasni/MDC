
USE [DatabaseMDC]
GO

IF EXISTS (SELECT * 
		 	 FROM sys.foreign_keys 
		    WHERE object_id = OBJECT_ID(N'dbo.FK_Rinnovi_Socio')
			  AND parent_object_id = OBJECT_ID(N'dbo.Rinnovi')
)
    ALTER TABLE [dbo].[Rinnovo] DROP CONSTRAINT [FK_Rinnovi_Socio];
GO

IF EXISTS (SELECT * 
		 	 FROM sys.foreign_keys 
		    WHERE object_id = OBJECT_ID(N'dbo.FK_Pratica_Socio')
			  AND parent_object_id = OBJECT_ID(N'dbo.Pratica')
)
    ALTER TABLE [dbo].[Pratica] DROP CONSTRAINT [FK_Pratica_Socio];
GO

IF EXISTS (SELECT * 
		 	 FROM sys.foreign_keys 
		    WHERE object_id = OBJECT_ID(N'dbo.FK_Consulenza_Socio')
			  AND parent_object_id = OBJECT_ID(N'dbo.Consulenza')
)
    ALTER TABLE [dbo].[Consulenza] DROP CONSTRAINT [FK_Consulenza_Socio];
GO

IF EXISTS(SELECT * FROM sys.tables WHERE SCHEMA_NAME(schema_id) LIKE 'dbo' AND name like 'Soci')  
	DROP TABLE [dbo].[Socio];
GO

CREATE TABLE [dbo].[Socio] (
    [IdSocio]            UNIQUEIDENTIFIER NOT NULL,
    [CodiceFiscale]      NCHAR (16)       NULL,
    [Nome]               NVARCHAR (50)    NOT NULL,
    [Cognome]            NVARCHAR (50)    NULL,
    [DataNascita]        DATE             NULL,
    [IdComuneNascita]    INTEGER          NULL,
    [Sesso]              NCHAR (1)        NULL,
    [DataIscrizione]     DATE             NOT NULL,
    [Email]              NVARCHAR (50)    NULL,
    [Telefono1]          NVARCHAR (50)    NULL,
    [Telefono2]          NVARCHAR (50)    NULL,
    [IndirizzoResidenza] NVARCHAR (50)    NULL,
    [IdComuneResidenza]  INTEGER		  NULL,
    [Cap]                NCHAR (5)        NULL
    CONSTRAINT [PK_Socioo] PRIMARY KEY CLUSTERED ([IdSocio] ASC)
);
GO

CREATE NONCLUSTERED INDEX [IX_Socio_Email]
    ON [dbo].[Socio]([Email] ASC);
GO

ALTER TABLE [dbo].[Socio] ADD CONSTRAINT [FK_Socio_Comune_N]
							  FOREIGN KEY ([IdComuneNascita]) REFERENCES [dbo].[Comune] ([IdComune])
							  ON DELETE NO ACTION;
GO

ALTER TABLE [dbo].[Socio] ADD CONSTRAINT [FK_Socio_Comune_R]
							  FOREIGN KEY ([IdComuneResidenza]) REFERENCES [dbo].[Comune] ([IdComune])
							  ON DELETE NO ACTION;
GO

-- Reinserimento FK precedentemente cancellata 
IF EXISTS(SELECT * FROM sys.tables WHERE SCHEMA_NAME(schema_id) LIKE 'dbo' AND name like 'Rinnovi')  
	ALTER TABLE [dbo].[Rinnovo] ADD CONSTRAINT [FK_Rinnovi_Socio]
								 FOREIGN KEY ([IdSocio]) REFERENCES [dbo].[Socio] ([IdSocio])
								 ON DELETE NO ACTION;
GO

IF EXISTS(SELECT * FROM sys.tables WHERE SCHEMA_NAME(schema_id) LIKE 'dbo' AND name like 'Pratica')  
	ALTER TABLE [dbo].[Pratica] ADD CONSTRAINT [FK_Pratica_Socio]
								  FOREIGN KEY ([IdSocio]) REFERENCES [dbo].[Socio] ([IdSocio])
								  ON DELETE NO ACTION;
GO

IF EXISTS(SELECT * FROM sys.tables WHERE SCHEMA_NAME(schema_id) LIKE 'dbo' AND name like 'Consulenza')  
	ALTER TABLE [dbo].[Consulenza] ADD CONSTRAINT [FK_Consulenza_Socio]
								    FOREIGN KEY ([IdSocio]) REFERENCES [dbo].[Socio] ([IdSocio])
								    ON DELETE NO ACTION;
GO
