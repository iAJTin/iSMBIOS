@ECHO OFF
CLS

..\src\.nuget\nuget Pack iSMBIOS.1.0.1.nuspec -NoDefaultExcludes -NoPackageAnalysis -OutputDirectory ..\deployment\nuget



