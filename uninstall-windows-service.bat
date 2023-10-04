@echo off
@chcp 65001 > nul

cls

echo *************************************************************
echo ****        Parando e deletando o Windows Service        ****
echo *************************************************************
echo.

sc stop "WindowsServiceTaskRunner"
sc delete "WindowsServiceTaskRunner"

pause