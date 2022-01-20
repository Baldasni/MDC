
USE [DatabaseMDC]
GO

IF EXISTS (SELECT * 
		 	 FROM sys.foreign_keys 
		    WHERE object_id = OBJECT_ID(N'dbo.FK_Comune_Provincia')
			  AND parent_object_id = OBJECT_ID(N'dbo.Comuni')
)
    ALTER TABLE [dbo].[Comune] DROP CONSTRAINT [FK_Comune_Provincia]
GO

IF EXISTS(SELECT * FROM sys.tables WHERE SCHEMA_NAME(schema_id) LIKE 'dbo' AND name like 'Provincia')  
	DROP TABLE [dbo].[Provincia]
GO

CREATE TABLE [dbo].[Provincia]
(
    [IdProvincia]        		INTEGER		  	NOT NULL IDENTITY(1,1),
	[Sigla] 		        	CHAR (02)   	NOT NULL,
	[Descrizione] 		        NVARCHAR (50)   NOT NULL,
	[Regione] 		        	NVARCHAR (50)   NOT NULL
    CONSTRAINT [PK_Provincia] PRIMARY KEY  CLUSTERED ([IdProvincia])

);

-- Reinserimento FK precedentemente cancellata 
IF EXISTS(SELECT * FROM sys.tables WHERE SCHEMA_NAME(schema_id) LIKE 'dbo' AND name like 'Comune')  
	ALTER TABLE [dbo].[Comune] ADD CONSTRAINT [FK_Comune_Provincia]
								FOREIGN KEY ([IdProvincia]) REFERENCES [dbo].[Provincia] ([IdProvincia])
								ON DELETE NO ACTION;
GO
