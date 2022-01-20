USE [DatabaseMDC]
GO

IF EXISTS(SELECT * FROM sys.tables WHERE SCHEMA_NAME(schema_id) LIKE 'dbo' AND name like 'TipologiaPratica')  
	INSERT INTO [dbo].[TipologiaPratica] ([Descrizione]) VALUES ('contratti gas e luce') 
	INSERT INTO [dbo].[TipologiaPratica] ([Descrizione]) VALUES ('garanzia beni di consumo') 
	INSERT INTO [dbo].[TipologiaPratica] ([Descrizione]) VALUES ('pratica commerciale scorretta') 
	INSERT INTO [dbo].[TipologiaPratica] ([Descrizione]) VALUES ('consulenza banche') 
	INSERT INTO [dbo].[TipologiaPratica] ([Descrizione]) VALUES ('rapporti pubblica amministrazione') 
	INSERT INTO [dbo].[TipologiaPratica] ([Descrizione]) VALUES ('telefonia') 
	INSERT INTO [dbo].[TipologiaPratica] ([Descrizione]) VALUES ('ecobonus') 
	INSERT INTO [dbo].[TipologiaPratica] ([Descrizione]) VALUES ('contratti privati') 
	INSERT INTO [dbo].[TipologiaPratica] ([Descrizione]) VALUES ('utenza idrica') 
	INSERT INTO [dbo].[TipologiaPratica] ([Descrizione]) VALUES ('assicurazioni') 
	INSERT INTO [dbo].[TipologiaPratica] ([Descrizione]) VALUES ('utenze rifiuti') 
	INSERT INTO [dbo].[TipologiaPratica] ([Descrizione]) VALUES ('imposte e tributi') 
	INSERT INTO [dbo].[TipologiaPratica] ([Descrizione]) VALUES ('commercio on line') 
	INSERT INTO [dbo].[TipologiaPratica] ([Descrizione]) VALUES ('reclami Poste Italiane') 
	INSERT INTO [dbo].[TipologiaPratica] ([Descrizione]) VALUES ('condominio') 
	
GO