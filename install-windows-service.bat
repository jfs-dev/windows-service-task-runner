@echo off
@chcp 65001 > nul

cls

echo *************************************************************
echo ****        Criando e iniciando o Windows Service        ****
echo *************************************************************
echo.

sc create "WindowsServiceTaskRunner" start= auto binpath= "C:\dev\windows-service-task-runner\bin\Debug\net8.0\windows-service-task-runner.exe" DisplayName= "Windows Service Task Runner"
sc description "WindowsServiceTaskRunner" "Windows Service executando tarefas em segundo plano utilizando a biblioteca Hangfire e gerando logs para monitoramento no EventViewer"
sc start "WindowsServiceTaskRunner"

pause