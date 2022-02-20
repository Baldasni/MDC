Sqlcmd -S .\SQLEXPRESS -E -i dbo.TipologiaContatto.sql
Sqlcmd -S .\SQLEXPRESS -E -i dbo.TipologiaPratica.sql
Sqlcmd -S .\SQLEXPRESS -E -i dbo.StatoPratica.sql
Sqlcmd -S .\SQLEXPRESS -E -i dbo.Sportello.sql
Sqlcmd -S .\SQLEXPRESS -E -i dbo.Regione.sql
Sqlcmd -S .\SQLEXPRESS -E -i dbo.Provincia.sql
Sqlcmd -S .\SQLEXPRESS -E -i dbo.Comune.sql
Sqlcmd -S .\SQLEXPRESS -E -i dbo.Socio.sql
Sqlcmd -S .\SQLEXPRESS -E -i dbo.Rinnovo.sql
Sqlcmd -S .\SQLEXPRESS -E -i dbo.Pratica.sql
Sqlcmd -S .\SQLEXPRESS -E -i dbo.Consulenza.sql
Sqlcmd -S .\SQLEXPRESS -E -i Insert.dbo.TipologiaContatto.sql -o Output.Insert.dbo.TipologiaContatto.txt
Sqlcmd -S .\SQLEXPRESS -E -i Insert.dbo.TipologiaPratica.sql -o Output.Insert.dbo.TipologiaPratica.txt
Sqlcmd -S .\SQLEXPRESS -E -i Insert.dbo.StatoPratica.sql -o Output.Insert.dbo.StatoPratica.txt
Sqlcmd -S .\SQLEXPRESS -E -i Insert.dbo.Sportello.sql -o Output.Insert.dbo.Sportello.txt
Sqlcmd -S .\SQLEXPRESS -E -i Insert.dbo.Regione.sql -o Output.Insert.dbo.Regione.txt
Sqlcmd -S .\SQLEXPRESS -E -i Insert.dbo.Provincia.sql -o Output.Insert.dbo.Provincia.txt
Sqlcmd -S .\SQLEXPRESS -E -i Insert.dbo.Comune.sql -o Output.Insert.dbo.Comune.txt
pause