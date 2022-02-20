
USE [DatabaseMDC]
GO

IF EXISTS (SELECT * 
		 	 FROM sys.foreign_keys 
		    WHERE object_id = OBJECT_ID(N'dbo.FK_Provincia_Regione')
			  AND parent_object_id = OBJECT_ID(N'dbo.Provincia')
)
    ALTER TABLE [dbo].[Provincia] DROP CONSTRAINT [FK_Provincia_Regione]
GO

IF EXISTS(SELECT * FROM sys.tables WHERE SCHEMA_NAME(schema_id) LIKE 'dbo' AND name like 'Regione')  
	DROP TABLE [dbo].[Regione]
GO

CREATE TABLE [dbo].[Regione]
(
    [IdRegione]        			INTEGER		  	NOT NULL,
	[Descrizione] 		        NVARCHAR (50)   NOT NULL
    CONSTRAINT [PK_Regione] PRIMARY KEY  CLUSTERED ([IdRegione])

);

-- Reinserimento FK precedentemente cancellata 
IF EXISTS(SELECT * FROM sys.tables WHERE SCHEMA_NAME(schema_id) LIKE 'dbo' AND name like 'Provincia')  
	ALTER TABLE [dbo].[Provincia] ADD CONSTRAINT [FK_Provincia_Regione]
								FOREIGN KEY ([IdRegione]) REFERENCES [dbo].[Regione] ([IdRegione])
								ON DELETE NO ACTION;
GO
