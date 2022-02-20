USE [DatabaseMDC]
GO

IF EXISTS (SELECT * 
		 	 FROM sys.foreign_keys 
		    WHERE object_id = OBJECT_ID(N'dbo.FK_Consulenza_Comune')
			  AND parent_object_id = OBJECT_ID(N'dbo.Consulenza')
)
    ALTER TABLE [dbo].[Consulenza] DROP CONSTRAINT [FK_Consulenza_Comune]
GO

IF EXISTS (SELECT * 
		 	 FROM sys.foreign_keys 
		    WHERE object_id = OBJECT_ID(N'dbo.FK_Socio_Comune_N')
			  AND parent_object_id = OBJECT_ID(N'dbo.Soci')
)
    ALTER TABLE [dbo].[Socio] DROP CONSTRAINT [FK_Socio_Comune_N]
GO

IF EXISTS (SELECT * 
		 	 FROM sys.foreign_keys 
		    WHERE object_id = OBJECT_ID(N'dbo.FK_Socio_Comune_R')
			  AND parent_object_id = OBJECT_ID(N'dbo.Soci')
)
    ALTER TABLE [dbo].[Socio] DROP CONSTRAINT [FK_Socio_Comune_R]
GO

IF EXISTS(SELECT * FROM sys.tables WHERE SCHEMA_NAME(schema_id) LIKE 'dbo' AND name like 'Comune')  
	DROP TABLE [dbo].[Comune]
GO

CREATE TABLE [dbo].[Comune]
(
    [IdComune]        			INTEGER  NOT NULL IDENTITY(1,1),
    [IdProvincia]     			INTEGER  NOT NULL DEFAULT 0,
	[CodiceCatastale]			NVARCHAR (4)     NOT NULL,
	[Descrizione] 		        NVARCHAR (50)     NOT NULL
    CONSTRAINT [PK_Comune] PRIMARY KEY CLUSTERED ([IdComune])

);

ALTER TABLE [dbo].[Comune] ADD CONSTRAINT [FK_Comune_Provincia]
								FOREIGN KEY ([IdProvincia]) REFERENCES [dbo].[Provincia] ([IdProvincia])
								ON DELETE NO ACTION;
GO

-- Reinserimento FK precedentemente cancellata 
IF EXISTS(SELECT * FROM sys.tables WHERE SCHEMA_NAME(schema_id) LIKE 'dbo' AND name like 'Consulenza')  
	ALTER TABLE [dbo].[Consulenza] ADD CONSTRAINT [FK_Consulenza_Comune]
									FOREIGN KEY ([IdComune]) REFERENCES [dbo].[Comune] ([IdComune])
									ON DELETE NO ACTION;
GO

IF EXISTS(SELECT * FROM sys.tables WHERE SCHEMA_NAME(schema_id) LIKE 'dbo' AND name like 'Soci')  
	ALTER TABLE [dbo].[Socio] ADD CONSTRAINT [FK_Socio_Comune_N]
							  FOREIGN KEY ([IdComuneNascita]) REFERENCES [dbo].[Comune] ([IdComune])
							  ON DELETE NO ACTION;
GO

IF EXISTS(SELECT * FROM sys.tables WHERE SCHEMA_NAME(schema_id) LIKE 'dbo' AND name like 'Soci')  
	ALTER TABLE [dbo].[Socio] ADD CONSTRAINT [FK_Socio_Comune_R]
							  FOREIGN KEY ([IdComuneResidenza]) REFERENCES [dbo].[Comune] ([IdComune])
							  ON DELETE NO ACTION;
GO