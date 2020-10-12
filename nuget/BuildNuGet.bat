@ECHO OFF
CLS

..\src\.nuget\nuget Pack iSMBIOS.1.1.5.nuspec -NoDefaultExcludes -NoPackageAnalysis -OutputDirectory ..\deployment\nuget 

pause

