using Builder.Builders.Interfaces;
using Monitor = Builder.Entities.Monitor;

namespace Builder.Builders;

public class ManualMonitorBuilder : IMonitorBuilder
{
    private readonly Monitor _monitor;

    public ManualMonitorBuilder()
    {
        _monitor = new Monitor();
    }
    
    public IMonitorBuilder BuildMatrix()
    {
        _monitor.Matrix = "VA";
        return this;
    }

    public IMonitorBuilder BuildDiagonal()
    {
        _monitor.Diagonal = "19";
        return this;
    }

    public IMonitorBuilder BuildScreenResolution()
    {
        _monitor.ScreenResolution = "1600x900";
        return this;
    }

    public IMonitorBuilder BuildUpdateFrequency()
    {
        _monitor.UpdateFrequency = "5ms";
        return this;
    }

    public IMonitorBuilder BuildContrast()
    {
        _monitor.Contrast = "1000:1";
        return this;
    }

    public Monitor GetMonitor()
    {
        return _monitor;
    }
}