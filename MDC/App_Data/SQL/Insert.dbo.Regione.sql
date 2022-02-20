USE [DatabaseMDC]
GO

IF EXISTS(SELECT * FROM sys.tables WHERE SCHEMA_NAME(schema_id) LIKE 'dbo' AND name like 'Regione')  
	INSERT INTO [dbo].[Regione] ([IdRegione], [Descrizione]) VALUES (1,'Abruzzo')
	INSERT INTO [dbo].[Regione] ([IdRegione], [Descrizione]) VALUES (2,'Basilicata')
	INSERT INTO [dbo].[Regione] ([IdRegione], [Descrizione]) VALUES (3,'Calabria')
	INSERT INTO [dbo].[Regione] ([IdRegione], [Descrizione]) VALUES (4,'Campania')
	INSERT INTO [dbo].[Regione] ([IdRegione], [Descrizione]) VALUES (5,'Emilia Romagna')
	INSERT INTO [dbo].[Regione] ([IdRegione], [Descrizione]) VALUES (6,'Friuli Venezia Giulia')
	INSERT INTO [dbo].[Regione] ([IdRegione], [Descrizione]) VALUES (7,'Lazio')
	INSERT INTO [dbo].[Regione] ([IdRegione], [Descrizione]) VALUES (8,'Liguria')
	INSERT INTO [dbo].[Regione] ([IdRegione], [Descrizione]) VALUES (9,'Lombardia')
	INSERT INTO [dbo].[Regione] ([IdRegione], [Descrizione]) VALUES (10,'Marche')
	INSERT INTO [dbo].[Regione] ([IdRegione], [Descrizione]) VALUES (11,'Molise')
	INSERT INTO [dbo].[Regione] ([IdRegione], [Descrizione]) VALUES (12,'Piemonte')
	INSERT INTO [dbo].[Regione] ([IdRegione], [Descrizione]) VALUES (13,'Puglia')
	INSERT INTO [dbo].[Regione] ([IdRegione], [Descrizione]) VALUES (14,'Sardegna')
	INSERT INTO [dbo].[Regione] ([IdRegione], [Descrizione]) VALUES (15,'Sicilia')
	INSERT INTO [dbo].[Regione] ([IdRegione], [Descrizione]) VALUES (16,'Toscana')
	INSERT INTO [dbo].[Regione] ([IdRegione], [Descrizione]) VALUES (17,'Trentino Alto Adige')
	INSERT INTO [dbo].[Regione] ([IdRegione], [Descrizione]) VALUES (18,'Umbria')
	INSERT INTO [dbo].[Regione] ([IdRegione], [Descrizione]) VALUES (19,'Valle d''Aosta')
	INSERT INTO [dbo].[Regione] ([IdRegione], [Descrizione]) VALUES (20,'Veneto')
	INSERT INTO [dbo].[Regione] ([IdRegione], [Descrizione]) VALUES (21,'ESTERO')

GO