using Builder.Builders;

Console.WriteLine("--------------------------------------------------------------\n");

var gamingMonitorBuilder = new GamingMonitorBuilder();
var gamingMonitorDirector = new MonitorDirector(gamingMonitorBuilder);
gamingMonitorDirector.MonitorBuild();
var gamingMonitor = gamingMonitorBuilder.GetMonitor();

Console.WriteLine($"\tGaming Monitor: {gamingMonitor}\n");

Console.WriteLine("--------------------------------------------------------------\n");

var officeMonitorBuilder = new OfficeMonitorBuilder();
var officeMonitorDirector = new MonitorDirector(officeMonitorBuilder);
officeMonitorDirector.MonitorBuild();
var officeMonitor = officeMonitorBuilder.GetMonitor();

Console.WriteLine($"\tOffice Monitor: {officeMonitor}\n");

Console.WriteLine("--------------------------------------------------------------\n");

var monitorBuilder = new ManualMonitorBuilder()
    .BuildMatrix()
    .BuildDiagonal()
    .BuildScreenResolution()
    .BuildUpdateFrequency()
    .BuildContrast();

var monitor = monitorBuilder.GetMonitor();
Console.WriteLine($"\tManual Monitor: {monitor}\n");