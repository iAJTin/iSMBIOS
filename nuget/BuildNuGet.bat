@ECHO OFF
CLS

..\src\.nuget\nuget Pack iSMBIOS.1.0.2.nuspec -NoDefaultExcludes -NoPackageAnalysis -OutputDirectory ..\deployment\nuget



