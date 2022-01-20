
USE [DatabaseMDC]
GO

IF EXISTS (SELECT * 
		 	 FROM sys.foreign_keys 
		    WHERE object_id = OBJECT_ID(N'dbo.FK_Pratica_Sportello')
			  AND parent_object_id = OBJECT_ID(N'dbo.Pratica')
)
    ALTER TABLE [dbo].[Pratica] DROP CONSTRAINT [FK_Pratica_Sportello]
GO

IF EXISTS(SELECT * FROM sys.tables WHERE SCHEMA_NAME(schema_id) LIKE 'dbo' AND name like 'Sportello')  
	DROP TABLE [dbo].[Sportello]
GO

CREATE TABLE [dbo].[Sportello]
(
    [IdSportello]        		INTEGER			  NOT NULL IDENTITY(1,1),
	[Descrizione] 		        NVARCHAR (50)     NOT NULL
    CONSTRAINT [PK_Sportello] PRIMARY KEY CLUSTERED ([IdSportello]),

);

-- Reinserimento FK precedentemente cancellata 
IF EXISTS(SELECT * FROM sys.tables WHERE SCHEMA_NAME(schema_id) LIKE 'dbo' AND name like 'Pratica')  
	ALTER TABLE [dbo].[Pratica] ADD CONSTRAINT [FK_Pratica_Sportello]
								  FOREIGN KEY ([IdSportello]) REFERENCES [dbo].[Sportello] ([IdSportello])
								  ON DELETE NO ACTION;
GO

