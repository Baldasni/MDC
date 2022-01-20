
USE [DatabaseMDC]
GO
print 'Inizio Tipologia Contatto'

IF EXISTS (SELECT * 
		 	 FROM sys.foreign_keys 
		    WHERE object_id = OBJECT_ID(N'dbo.FK_Consulenza_TipologiaContatto')
			  AND parent_object_id = OBJECT_ID(N'dbo.Consulenza')
)
    ALTER TABLE [dbo].[Consulenza] DROP CONSTRAINT [FK_Consulenza_TipologiaContatto]
else
	print 'dbo.FK_Consulenza_TipologiaContatto non esistente'
GO

IF EXISTS(SELECT * FROM sys.tables WHERE SCHEMA_NAME(schema_id) LIKE 'dbo' AND name like 'TipologiaContatto')  
	DROP TABLE [dbo].[TipologiaContatto]
else
	print 'La tabella Conulenza non esiste'
GO
print 'tabella cancellata'

CREATE TABLE [dbo].[TipologiaContatto]
(
    [IdTipologiaContatto]   INTEGER			  NOT NULL IDENTITY(1,1),
	[Descrizione] 		    NVARCHAR (50)     NOT NULL
    CONSTRAINT [PK_TipologiaContatto] PRIMARY KEY CLUSTERED ([IdTipologiaContatto]),

);

print 'tabella creata'

-- Reinserimento FK precedentemente cancellata 
IF EXISTS(SELECT * FROM sys.tables WHERE SCHEMA_NAME(schema_id) LIKE 'dbo' AND name like 'Consulenza')  
	ALTER TABLE [dbo].[Consulenza] ADD CONSTRAINT [FK_Consulenza_TipologiaContatto]
									FOREIGN KEY ([IdTipologiaContatto]) REFERENCES [dbo].[TipologiaContatto] ([IdTipologiaContatto])
									ON DELETE NO ACTION;
else
	print 'La tabella Conulenza non esiste 2'

print 'Fine Tipologia Contatto'

GO

