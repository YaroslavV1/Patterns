using Builder.Builders.Interfaces;

namespace Builder.Builders;

public class MonitorDirector
{
    private readonly IMonitorBuilder _monitorBuilder;

    public MonitorDirector(IMonitorBuilder monitorBuilder)
    {
        _monitorBuilder = monitorBuilder;
    }

    public void MonitorBuild()
    {
        _monitorBuilder.BuildMatrix()
            .BuildDiagonal()
            .BuildScreenResolution()
            .BuildUpdateFrequency()
            .BuildContrast();
    }
}