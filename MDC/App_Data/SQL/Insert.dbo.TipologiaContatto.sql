USE [DatabaseMDC]
GO

IF EXISTS(SELECT * FROM sys.tables WHERE SCHEMA_NAME(schema_id) LIKE 'dbo' AND name like 'TipologiaContatto')  
	INSERT INTO [dbo].[TipologiaContatto] ([Descrizione]) VALUES ('mail') 
	INSERT INTO [dbo].[TipologiaContatto] ([Descrizione]) VALUES ('lettera') 
	INSERT INTO [dbo].[TipologiaContatto] ([Descrizione]) VALUES ('telefono') 
	INSERT INTO [dbo].[TipologiaContatto] ([Descrizione]) VALUES ('sportello fisico') 
	INSERT INTO [dbo].[TipologiaContatto] ([Descrizione]) VALUES ('whatsapp') 
	INSERT INTO [dbo].[TipologiaContatto] ([Descrizione]) VALUES ('facebook') 
	INSERT INTO [dbo].[TipologiaContatto] ([Descrizione]) VALUES ('sito web') 

GO