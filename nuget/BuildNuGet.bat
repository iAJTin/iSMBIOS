@ECHO OFF
CLS

..\src\.nuget\nuget Pack iSMBIOS.1.1.3.nuspec -NoDefaultExcludes -NoPackageAnalysis -OutputDirectory ..\deployment\nuget 

pause

