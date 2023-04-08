using Monitor = Builder.Entities.Monitor;

namespace Builder.Builders.Interfaces;

public interface IMonitorBuilder
{
    public IMonitorBuilder BuildMatrix();
    public IMonitorBuilder BuildDiagonal();
    public IMonitorBuilder BuildScreenResolution();
    public IMonitorBuilder BuildUpdateFrequency();
    public IMonitorBuilder BuildContrast();
    public Monitor GetMonitor();
}