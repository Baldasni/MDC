
USE [DatabaseMDC]
GO

	IF EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'dbo.FK_Pratica_Sportello'))
		ALTER TABLE [dbo].[Pratica] DROP CONSTRAINT [FK_Pratica_Sportello];
	IF EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'dbo.FK_Consulenza_Comune'))
		ALTER TABLE [dbo].[Consulenza] DROP CONSTRAINT [FK_Consulenza_Comune];
	IF EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'dbo.FK_Socio_Comune_N'))
		ALTER TABLE [dbo].[Socio] DROP CONSTRAINT [FK_Socio_Comune_N];
	IF EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'dbo.FK_Socio_Comune_R'))
		ALTER TABLE [dbo].[Socio] DROP CONSTRAINT [FK_Socio_Comune_R];
	IF EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'dbo.FK_Comune_Provincia'))
		ALTER TABLE [dbo].[Comune] DROP CONSTRAINT [FK_Comune_Provincia];
	IF EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'dbo.FK_Provincia_Regione'))
		ALTER TABLE [dbo].[Comune] DROP CONSTRAINT [FK_Provincia_Regione];
	IF EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'dbo.FK_Rinnovi_Socio'))
		ALTER TABLE [dbo].[Rinnovo] DROP CONSTRAINT [FK_Rinnovi_Socio];
	IF EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'dbo.FK_Pratica_Socio'))
		ALTER TABLE [dbo].[Pratica] DROP CONSTRAINT [FK_Pratica_Socio];
	IF EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'dbo.FK_Consulenza_Socio'))
		ALTER TABLE [dbo].[Consulenza] DROP CONSTRAINT [FK_Consulenza_Socio];
	IF EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'dbo.FK_Pratica_TipologiaPratica'))
		ALTER TABLE [dbo].[Pratica] DROP CONSTRAINT [FK_Pratica_TipologiaPratica];
	IF EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'dbo.FK_Consulenza_TipologiaPratica'))
		ALTER TABLE [dbo].[Consulenza] DROP CONSTRAINT [FK_Consulenza_TipologiaPratica];
	IF EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'dbo.FK_Consulenza_TipologiaContatto'))
		ALTER TABLE [dbo].[Consulenza] DROP CONSTRAINT [FK_Consulenza_TipologiaContatto];
	IF EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'dbo.FK_Pratica_StatiPratica'))
		ALTER TABLE [dbo].[Pratica] DROP CONSTRAINT [FK_Pratica_StatiPratica];

	
	IF EXISTS(SELECT * FROM sys.tables WHERE SCHEMA_NAME(schema_id) LIKE 'dbo' AND name like 'Sportello') 
		DROP TABLE [dbo].[Sportello];
	IF EXISTS(SELECT * FROM sys.tables WHERE SCHEMA_NAME(schema_id) LIKE 'dbo' AND name like 'Comune') 
		DROP TABLE [dbo].[Comune];
	IF EXISTS(SELECT * FROM sys.tables WHERE SCHEMA_NAME(schema_id) LIKE 'dbo' AND name like 'Consulenza') 
		DROP TABLE [dbo].[Consulenza];
	IF EXISTS(SELECT * FROM sys.tables WHERE SCHEMA_NAME(schema_id) LIKE 'dbo' AND name like 'Pratica') 
		DROP TABLE [dbo].[Pratica];
	IF EXISTS(SELECT * FROM sys.tables WHERE SCHEMA_NAME(schema_id) LIKE 'dbo' AND name like 'Provincia') 
		DROP TABLE [dbo].[Provincia];
	IF EXISTS(SELECT * FROM sys.tables WHERE SCHEMA_NAME(schema_id) LIKE 'dbo' AND name like 'Regione') 
		DROP TABLE [dbo].[Regione];
	IF EXISTS(SELECT * FROM sys.tables WHERE SCHEMA_NAME(schema_id) LIKE 'dbo' AND name like 'Rinnovo') 
		DROP TABLE [dbo].[Rinnovo];
	IF EXISTS(SELECT * FROM sys.tables WHERE SCHEMA_NAME(schema_id) LIKE 'dbo' AND name like 'Socio') 
		DROP TABLE [dbo].[Socio];
	IF EXISTS(SELECT * FROM sys.tables WHERE SCHEMA_NAME(schema_id) LIKE 'dbo' AND name like 'TipologiaPratica') 
		DROP TABLE [dbo].[TipologiaPratica];
	IF EXISTS(SELECT * FROM sys.tables WHERE SCHEMA_NAME(schema_id) LIKE 'dbo' AND name like 'TipologiaContatto') 
		DROP TABLE [dbo].[TipologiaContatto];
	IF EXISTS(SELECT * FROM sys.tables WHERE SCHEMA_NAME(schema_id) LIKE 'dbo' AND name like 'StatoPratica') 
		DROP TABLE [dbo].[StatoPratica];

GO

