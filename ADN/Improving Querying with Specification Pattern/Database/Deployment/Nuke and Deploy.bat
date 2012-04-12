call "%VS_HOME%\VC\vcvarsall.bat" x86

sqlcmd -S . -Q "alter database EFCookboook set offline with rollback immediate"
sqlcmd -S . -Q "alter database EFCookboook set online"
sqlcmd -S . -Q "drop database EFCookboook"

msbuild.exe /target:clean;build;deploy "..\Database.dbproj"
@echo %0 finished