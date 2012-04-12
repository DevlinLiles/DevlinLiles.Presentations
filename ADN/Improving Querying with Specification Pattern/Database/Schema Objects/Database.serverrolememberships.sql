EXECUTE sp_addsrvrolemember @loginame = N'NT AUTHORITY\SYSTEM', @rolename = N'sysadmin';


GO
EXECUTE sp_addsrvrolemember @loginame = N'NT SERVICE\MSSQLSERVER', @rolename = N'sysadmin';


GO
EXECUTE sp_addsrvrolemember @loginame = N'DevlinLaptop\Devlin', @rolename = N'sysadmin';


GO
EXECUTE sp_addsrvrolemember @loginame = N'NT SERVICE\SQLSERVERAGENT', @rolename = N'sysadmin';

