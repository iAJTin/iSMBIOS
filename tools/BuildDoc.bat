@ECHO OFF
CLS

rmdir .\documentation /s /q

xmldocmd .\src\lib\net\iTin.Hardware\iTin.Hardware.Specification\iTin.Hardware.Specification.Dmi\bin\Release\net461\iTin.Hardware.Specification.Dmi.dll .\documentation

PAUSE
