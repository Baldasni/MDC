USE [DatabaseMDC]
GO

IF EXISTS (SELECT * 
		 	 FROM sys.foreign_keys 
		    WHERE object_id = OBJECT_ID(N'dbo.FK_Pratica_StatiPratica')
			  AND parent_object_id = OBJECT_ID(N'dbo.Pratica')
)
    ALTER TABLE [dbo].[Pratica] DROP CONSTRAINT [FK_Pratica_StatiPratica]
GO

IF EXISTS(SELECT * FROM sys.tables WHERE SCHEMA_NAME(schema_id) LIKE 'dbo' AND name like 'StatiPratica')  
	DROP TABLE [dbo].[StatoPratica]
GO

CREATE TABLE [dbo].[StatoPratica]
(
    [IdStatoPratica]        	INTEGER			  NOT NULL IDENTITY(1,1),
	[Descrizione] 		        NVARCHAR (50)     NOT NULL
    CONSTRAINT [PK_StatiPratica] PRIMARY KEY CLUSTERED ([IdStatoPratica])

);

-- Reinserimento FK precedentemente cancellata 
IF EXISTS(SELECT * FROM sys.tables WHERE SCHEMA_NAME(schema_id) LIKE 'dbo' AND name like 'Pratica')  
	ALTER TABLE [dbo].[Pratica] ADD CONSTRAINT [FK_Pratica_StatiPratica]
								  FOREIGN KEY ([IdStatoPratica]) REFERENCES [dbo].[StatoPratica] ([IdStatoPratica])
								  ON DELETE NO ACTION;
GO

