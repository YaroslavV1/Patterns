using Builder.Builders.Interfaces;
using Monitor = Builder.Entities.Monitor;

namespace Builder.Builders;

public class GamingMonitorBuilder : IMonitorBuilder
{
    private readonly Monitor _monitor;

    public GamingMonitorBuilder()
    {
        _monitor = new Monitor();
    }
    
    public IMonitorBuilder BuildMatrix()
    {
        _monitor.Matrix = "IPS";
        return this;
    }

    public IMonitorBuilder BuildDiagonal()
    {
        _monitor.Diagonal = "24";
        return this;
    }

    public IMonitorBuilder BuildScreenResolution()
    {
        _monitor.ScreenResolution = "2560x1440";
        return this;
    }

    public IMonitorBuilder BuildUpdateFrequency()
    {
        _monitor.UpdateFrequency = "1ms";
        return this;
    }

    public IMonitorBuilder BuildContrast()
    {
        _monitor.Contrast = "3000:1";
        return this;
    }

    public Monitor GetMonitor()
    {
        return _monitor;
    }
}