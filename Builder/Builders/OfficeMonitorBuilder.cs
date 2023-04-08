using Builder.Builders.Interfaces;
using Monitor = Builder.Entities.Monitor;

namespace Builder.Builders;

public class OfficeMonitorBuilder : IMonitorBuilder
{
    private readonly Monitor _monitor;

    public OfficeMonitorBuilder()
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
        _monitor.Diagonal = "22";
        return this;
    }

    public IMonitorBuilder BuildScreenResolution()
    {
        _monitor.ScreenResolution = "1920x1080";
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