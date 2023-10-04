using System.Diagnostics;
using System.Runtime.Versioning;
using System.ServiceProcess;
using Hangfire;
using Hangfire.MemoryStorage;

namespace windows_service_task_runner;

[SupportedOSPlatform("windows")]
public class WindowsService : ServiceBase
{
    private readonly BackgroundJobServer _server;
    private readonly EventLog _eventLog;
    private const string TaskName = "EventViewerCreateLog";

    public WindowsService()
    {
        ServiceName = "WindowsServiceTaskRunner";

        GlobalConfiguration.Configuration.UseMemoryStorage();

        var options = new BackgroundJobServerOptions
        {
            SchedulePollingInterval = TimeSpan.FromSeconds(1)
        };

        _server = new BackgroundJobServer(options);

        if (!EventLog.SourceExists(ServiceName))
            EventLog.CreateEventSource(ServiceName, "Application");

        _eventLog = new EventLog("Application")
        {
            Source = ServiceName
        };
    }

    protected override void OnStart(string[] args)
    {
        RecurringJob.AddOrUpdate(TaskName, () => Task(), "*/15 * * * * *");

        _eventLog.WriteEntry($"Serviço iniciado - {DateTime.Now}", EventLogEntryType.Information);
    }

    protected override void OnStop()
    {
        RecurringJob.RemoveIfExists(TaskName);
        _server.Dispose();

        _eventLog.WriteEntry($"Serviço parado - {DateTime.Now}", EventLogEntryType.Information);
    }

    public void Task()
    {
        _eventLog.WriteEntry($"Tarefa {TaskName} executada a cada 15s - {DateTime.Now}", EventLogEntryType.Information);
    }
}
