@ECHO OFF
CLS

..\src\.nuget\nuget Pack iSMBIOS.1.1.1.nuspec -NoDefaultExcludes -NoPackageAnalysis -OutputDirectory ..\deployment\nuget 

pause

