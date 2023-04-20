using Builder.Builders.Interfaces;
using Monitor = Builder.Entities.Monitor;

namespace Builder.Builders;

public class ManualMonitorBuilder : IMonitorBuilder
{
    private const string MATRIX = "VA";
    private const string DIAGONAL = "19";
    private const string SCREENRESOLUTION = "1600x900";
    private const string UPDATEFREQUENCY = "5ms";
    private const string CONTRAST = "1000:1";
    
    private readonly Monitor _monitor;

    public ManualMonitorBuilder()
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