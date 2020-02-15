@ECHO OFF
CLS

..\src\.nuget\nuget Pack iSMBIOS.1.1.2.nuspec -NoDefaultExcludes -NoPackageAnalysis -OutputDirectory ..\deployment\nuget 

pause

