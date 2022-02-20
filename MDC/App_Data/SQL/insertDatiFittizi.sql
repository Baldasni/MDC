USE [DatabaseMDC]
GO

IF EXISTS(SELECT * FROM sys.tables WHERE SCHEMA_NAME(schema_id) LIKE 'dbo' AND name like 'Socio')
	delete from [dbo].[Rinnovo];
	delete from [dbo].[Pratica];
	delete from [dbo].[Consulenza];
	delete from [dbo].[Socio];
-- Tabella socio
	insert into [dbo].[Socio] values(NEWID(), 'BCCCLD71T58G478J', 'CLAUDIA', 'BOCCALI', '1971-12-12', (SELECT [IdComune] FROM [dbo].[Comune] WHERE [Descrizione] = 'Assisi'), 'F', '2020-01-01', 'zio@tin.it', '075075075', '339339339', 'via fassoni 88', (SELECT [IdComune] FROM [dbo].[Comune] WHERE [Descrizione] = 'Assisi'), '06053');
	insert into [dbo].[Socio] values(NEWID(), 'GSTSRG62P25L216Q', 'SERGIO', 'AGOSTINELLI', '1962-09-25', (SELECT [IdComune] FROM [dbo].[Comune] WHERE [Descrizione] = 'Assisi'), 'M', '2021-01-01', 'zio@tin.it', '075075075', '339339339', 'VIA TOSCANA 9 (PASSAGGIO)', (SELECT [IdComune] FROM [dbo].[Comune] WHERE [Descrizione] = 'Assisi'), '06084');
	insert into [dbo].[Socio] values(NEWID(), 'NGLMRA49C24F844R', 'MARIO', 'ANGELINI', '1949-03-24', (SELECT [IdComune] FROM [dbo].[Comune] WHERE [Descrizione] = 'Assisi'), 'M', '2021-01-01', 'zio@tin.it', '075075075', '339339339', 'VIA TUDERTE 459', (SELECT [IdComune] FROM [dbo].[Comune] WHERE [Descrizione] = 'Assisi'), '05035');
	insert into [dbo].[Socio] values(NEWID(), 'BRCLRN50D50F844N', 'LORENA', 'BARCHERINI', '1950-04-10', (SELECT [IdComune] FROM [dbo].[Comune] WHERE [Descrizione] = 'Assisi'), 'F', '2019-01-01', 'lilasaradasi@gmail.com', '075075075', '339339339', 'LOCALITA CORLO', (SELECT [IdComune] FROM [dbo].[Comune] WHERE [Descrizione] = 'Assisi'), '06014');
	insert into [dbo].[Socio] values(NEWID(), 'BNCDNN48L56D786I', 'DEANNA', 'BONUCCI', '1948-07-16', (SELECT [IdComune] FROM [dbo].[Comune] WHERE [Descrizione] = 'Assisi'), 'F', '2016-09-01', 'tandempubb@tin.it', '075075075', '339339339', 'VIALE DEL POLACCHINO 20', (SELECT [IdComune] FROM [dbo].[Comune] WHERE [Descrizione] = 'Assisi'), '06012');
	insert into [dbo].[Socio] values(NEWID(), 'CPCFNC51C51L117B', 'FRANCESCA', 'CIPICCIA', '1951-11-03', (SELECT [IdComune] FROM [dbo].[Comune] WHERE [Descrizione] = 'Assisi'), 'F', '2021-01-01', 'tandempubb@tin.it', '075075075', '339339339', 'VIA LEOPARDI 26', (SELECT [IdComune] FROM [dbo].[Comune] WHERE [Descrizione] = 'Assisi'), '05100');
	insert into [dbo].[Socio] values(NEWID(), 'DMTSPN61T18E955E', 'SCIPIONE', 'DI MATTEO', '1961-12-18', (SELECT [IdComune] FROM [dbo].[Comune] WHERE [Descrizione] = 'Assisi'), 'M', '2021-04-05', 'scipiodim@libero.it', '075075075', '339339339', 'STRADA SAN ROCCO', (SELECT [IdComune] FROM [dbo].[Comune] WHERE [Descrizione] = 'Assisi'), '06084');
	insert into [dbo].[Socio] values(NEWID(), 'FBBFRZ62T28D786R', 'FABRIZIO', 'FABBRI', '1962-12-28', (SELECT [IdComune] FROM [dbo].[Comune] WHERE [Descrizione] = 'Assisi'), 'M', '2021-01-01', 'scipiodim@libero.it', '075075075', '339339339', 'VIA DEL VIGNOLA 3', (SELECT [IdComune] FROM [dbo].[Comune] WHERE [Descrizione] = 'Assisi'), '06019');
	insert into [dbo].[Socio] values(NEWID(), 'GRDMRA62T49A662L', 'MARIA', 'GIARDINO', '1962-12-09', (SELECT [IdComune] FROM [dbo].[Comune] WHERE [Descrizione] = 'Assisi'), 'F', '2021-02-01', 'daniela.geom@tiscali.it', '075075075', '339339339', 'VIA DELLA DOGA 100', (SELECT [IdComune] FROM [dbo].[Comune] WHERE [Descrizione] = 'Assisi'), '05035');
	insert into [dbo].[Socio] values(NEWID(), 'GLDDNL65R71C745I', 'DANIELA', 'GILDONI', '1965-10-31', (SELECT [IdComune] FROM [dbo].[Comune] WHERE [Descrizione] = 'Assisi'), 'F', '2017-01-01', 'daniela.geom@tiscali.it', '075075075', '339339339', 'VIALE STELVIO 15', (SELECT [IdComune] FROM [dbo].[Comune] WHERE [Descrizione] = 'Assisi'), '06012');
	insert into [dbo].[Socio] values(NEWID(), 'GRSMSM59T27A475I', 'MASSIMO', 'GRASSELLI', '1959-12-27', (SELECT [IdComune] FROM [dbo].[Comune] WHERE [Descrizione] = 'Assisi'), 'M', '2021-01-01', 'massimo.grasselli59@gmail.com', '075075075', '339339339', 'VIA ULISSE ROCCHI 57', (SELECT [IdComune] FROM [dbo].[Comune] WHERE [Descrizione] = 'Assisi'), '06123');
	insert into [dbo].[Socio] values(NEWID(), 'LLMFLL65D62E229T', 'FIORELLA', 'ILLUMINATI', '1965-04-22', (SELECT [IdComune] FROM [dbo].[Comune] WHERE [Descrizione] = 'Assisi'), 'F', '2021-01-01', 'daniela.geom@tiscali.it', '075075075', '339339339', 'STRADA GABELLETTA', (SELECT [IdComune] FROM [dbo].[Comune] WHERE [Descrizione] = 'Assisi'), '05100');
	insert into [dbo].[Socio] values(NEWID(), 'LVZNMR59H48F205Z', 'ANNA MARIA', 'LAVEZZALI', '1959-06-08', (SELECT [IdComune] FROM [dbo].[Comune] WHERE [Descrizione] = 'Assisi'), 'F', '2016-01-01', 'daniela.geom@tiscali.it', '075075075', '339339339', 'VIA CESARE BATTISTI', (SELECT [IdComune] FROM [dbo].[Comune] WHERE [Descrizione] = 'Assisi'), '06123');
	insert into [dbo].[Socio] values(NEWID(), 'LPTMLE65L25C746A', 'EMILIO', 'LUPATTELLI', '1965-07-25', (SELECT [IdComune] FROM [dbo].[Comune] WHERE [Descrizione] = 'Assisi'), 'M', '2021-03-01', 'daniela.geom@tiscali.it', '075075075', '339339339', 'VIA CHIUSI 473', (SELECT [IdComune] FROM [dbo].[Comune] WHERE [Descrizione] = 'Assisi'), '06129');
	insert into [dbo].[Socio] values(NEWID(), 'MNCMRC88C28L117K', 'MIRCO', 'MANCINI', '1988-03-28', (SELECT [IdComune] FROM [dbo].[Comune] WHERE [Descrizione] = 'Assisi'), 'M', '2020-02-01', 'daniela.geom@tiscali.it', '075075075', '339339339', 'VIA XX SETTEMBRE 133', (SELECT [IdComune] FROM [dbo].[Comune] WHERE [Descrizione] = 'Assisi'), '05100');
	insert into [dbo].[Socio] values(NEWID(), 'MRNCRN60R57D653D', 'CATERINA', 'MARIANI', '1960-10-17', (SELECT [IdComune] FROM [dbo].[Comune] WHERE [Descrizione] = 'Assisi'), 'F', '2021-01-01', 'daniela.geom@tiscali.it', '075075075', '339339339', 'VIA DEL BASALTO 6', (SELECT [IdComune] FROM [dbo].[Comune] WHERE [Descrizione] = 'Assisi'), '06132');
	insert into [dbo].[Socio] values(NEWID(), 'NCNNNA78S47C745N', 'ANNA', 'NOCENINI', '1978-11-07', (SELECT [IdComune] FROM [dbo].[Comune] WHERE [Descrizione] = 'Assisi'), 'F', '2018-01-01', 'daniela.geom@tiscali.it', '075075075', '339339339', 'LOCALITA CANCELLO 21', (SELECT [IdComune] FROM [dbo].[Comune] WHERE [Descrizione] = 'Assisi'), '06012');
	insert into [dbo].[Socio] values(NEWID(), 'PSQLGN65C21Z133Y', 'LUIGINO', 'PASQUI', '1965-03-21', (SELECT [IdComune] FROM [dbo].[Comune] WHERE [Descrizione] = 'Assisi'), 'M', '2020-01-01', 'daniela.geom@tiscali.it', '075075075', '339339339', 'VIA DELL EREMO 6', (SELECT [IdComune] FROM [dbo].[Comune] WHERE [Descrizione] = 'Assisi'), '06012');
	insert into [dbo].[Socio] values(NEWID(), 'PTRPRI41A01L117X', 'PIETRO', 'PETRUCCI', '1941-01-01', (SELECT [IdComune] FROM [dbo].[Comune] WHERE [Descrizione] = 'Assisi'), 'M', '2021-01-01', 'generavt@libero.it', '075075075', '339339339', 'VOCABOLO SANTA LUCIA 58/B', (SELECT [IdComune] FROM [dbo].[Comune] WHERE [Descrizione] = 'Assisi'), '05039');
	insert into [dbo].[Socio] values(NEWID(), 'PRPMRA53D66D653N', 'MAURA', 'PROPERZI', '1953-04-26', (SELECT [IdComune] FROM [dbo].[Comune] WHERE [Descrizione] = 'Assisi'), 'F', '2021-01-01', '', '075075075', '339339339', 'VIA FONTEVECCHIA 23/A', (SELECT [IdComune] FROM [dbo].[Comune] WHERE [Descrizione] = 'Assisi'), '06034');
GO

USE [DatabaseMDC]
GO

IF EXISTS(SELECT * FROM sys.tables WHERE SCHEMA_NAME(schema_id) LIKE 'dbo' AND name like 'Rinnovo')  
-- Tabella [dbo].[Rinnovo]
	insert into [dbo].[Rinnovo] values(NEWID(), (SELECT [IdSocio] FROM [dbo].[Socio] WHERE [CodiceFiscale] = 'MRNCRN60R57D653D'), '2020-01-01', '2020', '2021', 20.00 );
	insert into [dbo].[Rinnovo] values(NEWID(), (SELECT [IdSocio] FROM [dbo].[Socio] WHERE [CodiceFiscale] = 'MRNCRN60R57D653D'), '2022-01-01', '2022', '2023', 20.00 );
	insert into [dbo].[Rinnovo] values(NEWID(), (SELECT [IdSocio] FROM [dbo].[Socio] WHERE [CodiceFiscale] = 'DMTSPN61T18E955E'), '2021-01-01', '2021', '2022', 20.00 );
	insert into [dbo].[Rinnovo] values(NEWID(), (SELECT [IdSocio] FROM [dbo].[Socio] WHERE [CodiceFiscale] = 'PTRPRI41A01L117X'), '2021-01-01', '2021', '2022', 20.00 );
	insert into [dbo].[Rinnovo] values(NEWID(), (SELECT [IdSocio] FROM [dbo].[Socio] WHERE [CodiceFiscale] = 'GRDMRA62T49A662L'), '2019-01-01', '2019', '2020', 20.00 );
	insert into [dbo].[Rinnovo] values(NEWID(), (SELECT [IdSocio] FROM [dbo].[Socio] WHERE [CodiceFiscale] = 'GRDMRA62T49A662L'), '2021-01-01', '2021', '2022', 20.00 );
	insert into [dbo].[Rinnovo] values(NEWID(), (SELECT [IdSocio] FROM [dbo].[Socio] WHERE [CodiceFiscale] = 'LLMFLL65D62E229T'), '2016-03-01', '2016', '2017', 20.00 );
	insert into [dbo].[Rinnovo] values(NEWID(), (SELECT [IdSocio] FROM [dbo].[Socio] WHERE [CodiceFiscale] = 'LLMFLL65D62E229T'), '2018-01-01', '2018', '2019', 20.00 );
	insert into [dbo].[Rinnovo] values(NEWID(), (SELECT [IdSocio] FROM [dbo].[Socio] WHERE [CodiceFiscale] = 'LLMFLL65D62E229T'), '2020-01-01', '2020', '2021', 20.00 );
	insert into [dbo].[Rinnovo] values(NEWID(), (SELECT [IdSocio] FROM [dbo].[Socio] WHERE [CodiceFiscale] = 'LLMFLL65D62E229T'), '2022-01-01', '2022', '2023', 20.00 );
	insert into [dbo].[Rinnovo] values(NEWID(), (SELECT [IdSocio] FROM [dbo].[Socio] WHERE [CodiceFiscale] = 'NCNNNA78S47C745N'), '2021-01-01', '2021', '2022', 20.00 );
	insert into [dbo].[Rinnovo] values(NEWID(), (SELECT [IdSocio] FROM [dbo].[Socio] WHERE [CodiceFiscale] = 'MNCMRC88C28L117K'), '2021-05-04', '2021', '2022', 20.00 );
	insert into [dbo].[Rinnovo] values(NEWID(), (SELECT [IdSocio] FROM [dbo].[Socio] WHERE [CodiceFiscale] = 'PRPMRA53D66D653N'), '2021-01-01', '2021', '2022', 20.00 );
	insert into [dbo].[Rinnovo] values(NEWID(), (SELECT [IdSocio] FROM [dbo].[Socio] WHERE [CodiceFiscale] = 'GRSMSM59T27A475I'), '2021-02-01', '2021', '2022', 20.00 );
	insert into [dbo].[Rinnovo] values(NEWID(), (SELECT [IdSocio] FROM [dbo].[Socio] WHERE [CodiceFiscale] = 'LVZNMR59H48F205Z'), '2017-01-01', '2017', '2018', 20.00 );
	insert into [dbo].[Rinnovo] values(NEWID(), (SELECT [IdSocio] FROM [dbo].[Socio] WHERE [CodiceFiscale] = 'LVZNMR59H48F205Z'), '2019-01-01', '2019', '2020', 20.00 );
	insert into [dbo].[Rinnovo] values(NEWID(), (SELECT [IdSocio] FROM [dbo].[Socio] WHERE [CodiceFiscale] = 'LVZNMR59H48F205Z'), '2021-01-01', '2021', '2022', 20.00 );
	insert into [dbo].[Rinnovo] values(NEWID(), (SELECT [IdSocio] FROM [dbo].[Socio] WHERE [CodiceFiscale] = 'GSTSRG62P25L216Q'), '2021-01-01', '2021', '2022', 20.00 );
	insert into [dbo].[Rinnovo] values(NEWID(), (SELECT [IdSocio] FROM [dbo].[Socio] WHERE [CodiceFiscale] = 'GLDDNL65R71C745I'), '2021-01-01', '2021', '2022', 20.00 );
	insert into [dbo].[Rinnovo] values(NEWID(), (SELECT [IdSocio] FROM [dbo].[Socio] WHERE [CodiceFiscale] = 'BCCCLD71T58G478J'), '2016-01-01', '2016', '2017', 20.00 );
	insert into [dbo].[Rinnovo] values(NEWID(), (SELECT [IdSocio] FROM [dbo].[Socio] WHERE [CodiceFiscale] = 'BCCCLD71T58G478J'), '2018-01-01', '2018', '2019', 20.00 );
	insert into [dbo].[Rinnovo] values(NEWID(), (SELECT [IdSocio] FROM [dbo].[Socio] WHERE [CodiceFiscale] = 'BCCCLD71T58G478J'), '2020-01-01', '2020', '2021', 20.00 );
	insert into [dbo].[Rinnovo] values(NEWID(), (SELECT [IdSocio] FROM [dbo].[Socio] WHERE [CodiceFiscale] = 'BCCCLD71T58G478J'), '2022-01-01', '2022', '2023', 20.00 );
	insert into [dbo].[Rinnovo] values(NEWID(), (SELECT [IdSocio] FROM [dbo].[Socio] WHERE [CodiceFiscale] = 'BRCLRN50D50F844N'), '2021-03-01', '2021', '2022', 20.00 );
	insert into [dbo].[Rinnovo] values(NEWID(), (SELECT [IdSocio] FROM [dbo].[Socio] WHERE [CodiceFiscale] = 'CPCFNC51C51L117B'), '2020-02-01', '2020', '2021', 20.00 );
	insert into [dbo].[Rinnovo] values(NEWID(), (SELECT [IdSocio] FROM [dbo].[Socio] WHERE [CodiceFiscale] = 'CPCFNC51C51L117B'), '2022-01-01', '2022', '2023', 20.00 );
	insert into [dbo].[Rinnovo] values(NEWID(), (SELECT [IdSocio] FROM [dbo].[Socio] WHERE [CodiceFiscale] = 'FBBFRZ62T28D786R'), '2021-01-01', '2021', '2022', 20.00 );
	insert into [dbo].[Rinnovo] values(NEWID(), (SELECT [IdSocio] FROM [dbo].[Socio] WHERE [CodiceFiscale] = 'BNCDNN48L56D786I'), '2018-01-01', '2018', '2019', 20.00 );
	insert into [dbo].[Rinnovo] values(NEWID(), (SELECT [IdSocio] FROM [dbo].[Socio] WHERE [CodiceFiscale] = 'BNCDNN48L56D786I'), '2020-01-01', '2020', '2021', 20.00 );
	insert into [dbo].[Rinnovo] values(NEWID(), (SELECT [IdSocio] FROM [dbo].[Socio] WHERE [CodiceFiscale] = 'BNCDNN48L56D786I'), '2022-01-01', '2022', '2022', 20.00 );
	insert into [dbo].[Rinnovo] values(NEWID(), (SELECT [IdSocio] FROM [dbo].[Socio] WHERE [CodiceFiscale] = 'NGLMRA49C24F844R'), '2020-01-01', '2020', '2021', 20.00 );
	insert into [dbo].[Rinnovo] values(NEWID(), (SELECT [IdSocio] FROM [dbo].[Socio] WHERE [CodiceFiscale] = 'NGLMRA49C24F844R'), '2022-01-01', '2022', '2023', 20.00 );
	insert into [dbo].[Rinnovo] values(NEWID(), (SELECT [IdSocio] FROM [dbo].[Socio] WHERE [CodiceFiscale] = 'PSQLGN65C21Z133Y'), '2021-01-01', '2021', '2022', 20.00 );
	insert into [dbo].[Rinnovo] values(NEWID(), (SELECT [IdSocio] FROM [dbo].[Socio] WHERE [CodiceFiscale] = 'LPTMLE65L25C746A'), '2021-01-01', '2021', '2022', 20.00 );
GO

USE [DatabaseMDC]
GO

IF EXISTS(SELECT * FROM sys.tables WHERE SCHEMA_NAME(schema_id) LIKE 'dbo' AND name like 'Pratica')  
-- Tabella Pratica
	insert into [dbo].[Pratica] values(NEWID(), (SELECT [IdSocio] FROM[dbo].[Socio]WHERE [CodiceFiscale] = 'MRNCRN60R57D653D'), 1, 'CLAUDIA BOCCALI', '2020-01-10', 1, 'RECLAMO SPORTELLO CONSUMATORE ENERGIA/ENEL DISTRIBUZIONE', 4, 'EFFETUATO RIMBORSO AL CLIENTE');
	insert into [dbo].[Pratica] values(NEWID(), (SELECT [IdSocio] FROM[dbo].[Socio]WHERE [CodiceFiscale] = 'GSTSRG62P25L216Q'), 1, 'SERGIO AGOSTINELLI', '2020-04-02', 4, 'DISDETTA CONTO CORRENTE/MPS', 2, '');
	insert into [dbo].[Pratica] values(NEWID(), (SELECT [IdSocio] FROM[dbo].[Socio]WHERE [CodiceFiscale] = 'NGLMRA49C24F844R'), 1, 'MARIO ANGELINI', '2020-03-21', 1, 'UTENZA ENERGIA/GAS. SOLLECITO FATTURA 2016. 18/11/2020, PEC CONTESTAZIONE ENI+EUROPAFACTOR', 3, '');
	insert into [dbo].[Pratica] values(NEWID(), (SELECT [IdSocio] FROM[dbo].[Socio]WHERE [CodiceFiscale] = 'BRCLRN50D50F844N'), 2, 'LORENA BARCHERINI/TIM + VODAFONE', '2021-02-02', 6, 'TELEFONIA. MANCATA MIGRAZIONE NUMERAZIONE, MALFUNZIONAMENTO, PERDITA NUMERAZIONE, MANCATO RISCONTRO AI RECLAMI. 13/11/2020 UG N. 352966/20', 3, '');
	insert into [dbo].[Pratica] values(NEWID(), (SELECT [IdSocio] FROM[dbo].[Socio]WHERE [CodiceFiscale] = 'BNCDNN48L56D786I'), 2, 'DEANNA BONUCCI/GESENU', '2021-02-02', 12, 'TRIBUTI/UTENZA TARI. CONTESTAZIONE MANCATA RETTIFICA AVVISI E MANCATO SUBENTRO. PEC ARUBA E EMAIL RECLAMO', 5, '');
	insert into [dbo].[Pratica] values(NEWID(), (SELECT [IdSocio] FROM[dbo].[Socio]WHERE [CodiceFiscale] = 'CPCFNC51C51L117B'), 3, 'FRANCESCA CIPICCIA/NUOVA ENERGIA ITALIA + ELETTRA ROMA ', '2021-02-02', 5, 'RAPPORTI PA/TRIBUTI/PATRONATI. ERRONEO ADDEBITO SU STIPENDIO DEGLI ACCONTI IRPEF. PEC AGENZIA DELLE ENTRATE PER RATEAZIONE', 4, '');
	insert into [dbo].[Pratica] values(NEWID(), (SELECT [IdSocio] FROM[dbo].[Socio]WHERE [CodiceFiscale] = 'DMTSPN61T18E955E'), 3, 'SCIPIONE DI MATTEO/TECNORETE TERNI', '2020-06-30', 8, 'CONTRATTI PRIVATI. MEDIAZIONE IMMOBILIARE, MANCATA CONSEGNA  CONTRATTO E FIRMA ADEGUAMENTO PREZZO FALSA. 30/06/2020 PEC+EMAIL CONTESTAZIONI E DISDETTA.  RISCONTRO MDC PEC 20 LUGLIO 2020 PER ACCORDO TRANSATTIVO', 1, 'RISCONTRO AGENZIA PEC 14 LUGLIO 2020.');
	insert into [dbo].[Pratica] values(NEWID(), (SELECT [IdSocio] FROM[dbo].[Socio]WHERE [CodiceFiscale] = 'FBBFRZ62T28D786R'), 4, 'FABRIZIO FABBRI/TIM', '2020-07-31', 6, 'TELEFONIA. MANCATO RISCONTRO RECLAMO 16/10/2020 (319/20), PER VIOLAZIONE DELIBERA MODEM LIBERO, CAMBIO TARIFFARIO, FATTURAZIONE 28 GIORNI. 21/11/20 UG N. 356847/20', 4, 'STORNO 72,80+300 INDENNIZZO. TOTALE: 372,70');
	insert into [dbo].[Pratica] values(NEWID(), (SELECT [IdSocio] FROM[dbo].[Socio]WHERE [CodiceFiscale] = 'FBBFRZ62T28D786R'), 4, 'FABRIZIO FABBRI/C. LYONESS', '2020-12-15', 8, 'CONTRATTI PRIVATI. VENDITA PIRAMIDALE, CONTESTAZIONE E RICHIESTA RIMBORSO. PEC 15/12/2020', 3, '');
	insert into [dbo].[Pratica] values(NEWID(), (SELECT [IdSocio] FROM[dbo].[Socio]WHERE [CodiceFiscale] = 'FBBFRZ62T28D786R'), 4, 'FABRIZIO FABBRI/SANTANDER', '2021-01-01', 4, 'BANCHE/FINANZIAMENTI. CESSIONE DEL QUINTO, PENSIONAMENTO PER MOTIVI DI MALATTIA PROFESSIONALE. ESCUSSIONE TFR+RESIDUO. ANALISI DOCUMENTAZIONE', 1, '');
GO