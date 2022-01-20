
USE [DatabaseMDC]
GO

IF EXISTS (SELECT * 
		 	 FROM sys.foreign_keys 
		    WHERE object_id = OBJECT_ID(N'dbo.FK_Pratica_TipologiaPratica')
			  AND parent_object_id = OBJECT_ID(N'dbo.Pratica')
)
    ALTER TABLE [dbo].[Pratica] DROP CONSTRAINT [FK_Pratica_TipologiaPratica]
GO

IF EXISTS (SELECT * 
		 	 FROM sys.foreign_keys 
		    WHERE object_id = OBJECT_ID(N'dbo.FK_Consulenza_TipologiaPratica')
			  AND parent_object_id = OBJECT_ID(N'dbo.Consulenza')
)
    ALTER TABLE [dbo].[Consulenza] DROP CONSTRAINT [FK_Consulenza_TipologiaPratica]
GO

IF EXISTS(SELECT * FROM sys.tables WHERE SCHEMA_NAME(schema_id) LIKE 'dbo' AND name like 'TipologiaPratica')  
	DROP TABLE [dbo].[TipologiaPratica]
GO

CREATE TABLE [dbo].[TipologiaPratica]
(
    [IdTipologiaPratica]        INTEGER			  NOT NULL IDENTITY(1,1),
	[Descrizione] 		        NVARCHAR (50)     NOT NULL
    CONSTRAINT [PK_TipologiaPratica] PRIMARY KEY CLUSTERED ([IdTipologiaPratica]),

);

-- Reinserimento FK precedentemente cancellata 
IF EXISTS(SELECT * FROM sys.tables WHERE SCHEMA_NAME(schema_id) LIKE 'dbo' AND name like 'Pratica')  
	ALTER TABLE [dbo].[Pratica] ADD CONSTRAINT [FK_Pratica_TipologiaPratica]
								  FOREIGN KEY ([IdTipologiaPratica]) REFERENCES [dbo].[TipologiaPratica] ([IdTipologiaPratica])
								  ON DELETE NO ACTION;
GO

IF EXISTS(SELECT * FROM sys.tables WHERE SCHEMA_NAME(schema_id) LIKE 'dbo' AND name like 'Consulenza')  
	ALTER TABLE [dbo].[Consulenza] ADD CONSTRAINT [FK_Consulenza_TipologiaPratica]
									FOREIGN KEY ([IdTipologiaPratica]) REFERENCES [dbo].[TipologiaPratica] ([IdTipologiaPratica])
									ON DELETE NO ACTION;

