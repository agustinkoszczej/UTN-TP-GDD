sqlcmd -S LOCALHOST\SQLSERVER2012 -U gd -P gd2017 -i gd_esquema.Schema.sql,gd_esquema.Maestra.Table.sql  -a 32767 -o resultado_output.txt