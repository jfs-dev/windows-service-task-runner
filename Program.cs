using System.ServiceProcess;
using windows_service_task_runner;

if (OperatingSystem.IsWindows())
    ServiceBase.Run(new WindowsService());