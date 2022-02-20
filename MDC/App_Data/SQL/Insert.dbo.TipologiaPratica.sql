USE [DatabaseMDC]
GO

IF EXISTS(SELECT * FROM sys.tables WHERE SCHEMA_NAME(schema_id) LIKE 'dbo' AND name like 'TipologiaPratica')  
	INSERT INTO [dbo].[TipologiaPratica] ([Descrizione]) VALUES ('CONTRATTI GAS E LUCE');
	INSERT INTO [dbo].[TipologiaPratica] ([Descrizione]) VALUES ('GARANZIA BENI DI CONSUMO');
	INSERT INTO [dbo].[TipologiaPratica] ([Descrizione]) VALUES ('PRATICA COMMERCIALE SCORRETTA');
	INSERT INTO [dbo].[TipologiaPratica] ([Descrizione]) VALUES ('BANCHE - FINAZIAMENTI');
	INSERT INTO [dbo].[TipologiaPratica] ([Descrizione]) VALUES ('RAPPORTI PUBBLICA AMMINISTRAZIONE');
	INSERT INTO [dbo].[TipologiaPratica] ([Descrizione]) VALUES ('TELFONIA');
	INSERT INTO [dbo].[TipologiaPratica] ([Descrizione]) VALUES ('ECOBONUS');
	INSERT INTO [dbo].[TipologiaPratica] ([Descrizione]) VALUES ('CONTRATTI TRA PRIVATI');
	INSERT INTO [dbo].[TipologiaPratica] ([Descrizione]) VALUES ('UTENZA IDRICA');
	INSERT INTO [dbo].[TipologiaPratica] ([Descrizione]) VALUES ('ASSICURAZIONI');
	INSERT INTO [dbo].[TipologiaPratica] ([Descrizione]) VALUES ('UTENZE RIFIUTI');
	INSERT INTO [dbo].[TipologiaPratica] ([Descrizione]) VALUES ('IMPOSTE E TRIBUTI');
	INSERT INTO [dbo].[TipologiaPratica] ([Descrizione]) VALUES ('COMMERCIO ON LINE / VENDITA A DISTANZA');
	INSERT INTO [dbo].[TipologiaPratica] ([Descrizione]) VALUES ('RECLAMI POSTE ITALIANE');
	INSERT INTO [dbo].[TipologiaPratica] ([Descrizione]) VALUES ('CONDOMINIO');
	INSERT INTO [dbo].[TipologiaPratica] ([Descrizione]) VALUES ('SANITA');
	INSERT INTO [dbo].[TipologiaPratica] ([Descrizione]) VALUES ('SOVRAINDEBITAMENTO');
	
GO