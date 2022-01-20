USE [DatabaseMDC]
GO

IF EXISTS(SELECT * FROM sys.tables WHERE SCHEMA_NAME(schema_id) LIKE 'dbo' AND name like 'StatoPratica')  
	INSERT INTO [dbo].[StatoPratica] ([Descrizione]) VALUES ('Inserita')
	INSERT INTO [dbo].[StatoPratica] ([Descrizione]) VALUES ('In lavorazione')
	INSERT INTO [dbo].[StatoPratica] ([Descrizione]) VALUES ('pendente')
	INSERT INTO [dbo].[StatoPratica] ([Descrizione]) VALUES ('chiusa con esito positivo')
	INSERT INTO [dbo].[StatoPratica] ([Descrizione]) VALUES ('chiusa con esito negativo')
	
GO