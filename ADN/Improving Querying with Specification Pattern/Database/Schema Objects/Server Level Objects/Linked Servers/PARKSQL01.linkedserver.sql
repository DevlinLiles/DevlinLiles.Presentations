EXECUTE sp_addlinkedserver @server = N'PARKSQL01', @srvproduct = N'sql_server', @provider = N'SQLNCLI10', @datasrc = N'(local)';


GO
EXECUTE sp_serveroption @server = N'PARKSQL01', @optname = N'rpc', @optvalue = N'TRUE';


GO
EXECUTE sp_serveroption @server = N'PARKSQL01', @optname = N'rpc out', @optvalue = N'TRUE';

