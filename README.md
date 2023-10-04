# windows-service-task-runner
Aplicação Windows Service rodando tarefas em segundo plano utilizando a biblioteca Hangfire e gerando logs para monitoramento no EventViewer

![.Net](https://img.shields.io/badge/.NET-5C2D91?style=for-the-badge&logo=.net&logoColor=white)
![C#](https://img.shields.io/badge/c%23-%23239120.svg?style=for-the-badge&logo=c-sharp&logoColor=white)
![Visual Studio Code](https://img.shields.io/badge/Visual%20Studio%20Code-0078d7.svg?style=for-the-badge&logo=visual-studio-code&logoColor=white)
![Visual Studio](https://img.shields.io/badge/Visual%20Studio-5C2D91.svg?style=for-the-badge&logo=visual-studio&logoColor=white)

## Sobre o projeto
Este projeto mostra uma aplicação Windows Service rodando tarefas em segundo plano utilizando a biblioteca Hangfire e gerando logs para monitoramento no EventViewer.

Parar criar e iniciar o Windows Service, execute como Administrador o arquivo em lote <code>install-windows-service.bat</code>. Para pausar e remover o Windows Service, execute como Administrador o arquivo em lote <code>uninstall-windows-service.bat</code>.

Lembre-se de substituir o caminho da aplicação no arquivo <code>install-windows-service.bat</code>.

<div align="center">
    <img src="https://github.com/jfs-dev/windows-service-task-runner/assets/54154628/f88536bb-a0cc-438c-8bf9-87355ac90aa4"</img>
    <img src="https://github.com/jfs-dev/windows-service-task-runner/assets/54154628/ddd56693-9b29-41a5-a483-990c344f2d2a"</img>
    <img src="https://github.com/jfs-dev/windows-service-task-runner/assets/54154628/fa1ca890-ac33-49c3-81a2-432ea393e019"</img>
</div>

## Referências
https://learn.microsoft.com/pt-br/dotnet/core/extensions/workers?pivots=dotnet-7-0/

https://learn.microsoft.com/en-us/dotnet/api/system.serviceprocess.servicebase?view=dotnet-plat-ext-7.0/

https://www.hangfire.io/

https://github.com/HangfireIO/Hangfire/

https://learn.microsoft.com/en-us/windows-server/administration/windows-commands/sc-create/

## Licença
GPL-3.0 license
