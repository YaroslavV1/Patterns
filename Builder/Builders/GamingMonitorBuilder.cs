using Builder.Builders.Interfaces;
using Monitor = Builder.Entities.Monitor;

namespace Builder.Builders;

public class GamingMonitorBuilder : IMonitorBuilder
{
    private const string MATRIX = "IPS";
    private const string DIAGONAL = "24";
    private const string SCREENRESOLUTION = "2560x1440";
    private const string UPDATEFREQUENCY = "1ms";
    private const string CONTRAST = "3000:1";
    
    private readonly Monitor _monitor;

    public GamingMonitorBuilder()
    {
        _monitor = new Monitor();
    }
    
    public IMonitorBuilder BuildMatrix()
    {
        _monitor.Matrix = MATRIX;
        return this;
    }

    public IMonitorBuilder BuildDiagonal()
    {
        _monitor.Diagonal = DIAGONAL;
        return this;
    }

    public IMonitorBuilder BuildScreenResolution()
    {
        _monitor.ScreenResolution = SCREENRESOLUTION;
        return this;
    }

    public IMonitorBuilder BuildUpdateFrequency()
    {
        _monitor.UpdateFrequency = UPDATEFREQUENCY;
        return this;
    }

    public IMonitorBuilder BuildContrast()
    {
        _monitor.Contrast = CONTRAST;
        return this;
    }

    public Monitor GetMonitor()
    {
        return _monitor;
    }
}