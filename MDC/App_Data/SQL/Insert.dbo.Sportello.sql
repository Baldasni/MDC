USE [DatabaseMDC]
GO

IF EXISTS(SELECT * FROM sys.tables WHERE SCHEMA_NAME(schema_id) LIKE 'dbo' AND name like 'Sportello')  
	INSERT INTO [dbo].[Sportello] ([Descrizione]) VALUES ('Perugia') 
	INSERT INTO [dbo].[Sportello] ([Descrizione]) VALUES ('Foligno') 
	INSERT INTO [dbo].[Sportello] ([Descrizione]) VALUES ('Bettona') 
	INSERT INTO [dbo].[Sportello] ([Descrizione]) VALUES ('Città di Castello') 
	INSERT INTO [dbo].[Sportello] ([Descrizione]) VALUES ('Sportello Digitale') 

GO