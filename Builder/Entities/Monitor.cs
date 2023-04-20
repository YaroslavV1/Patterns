namespace Builder.Entities;

public class Monitor
{
    public string Matrix { get; set; }
    public string Diagonal { get; set; }
    public string ScreenResolution { get; set; }
    public string UpdateFrequency { get; set; }
    public string Contrast { get; set; }

    public override string ToString() =>
        $"\nMatrix: {Matrix}" +
        $"\nDiagonal: {Diagonal}" +
        $"\nScreenResolution: {ScreenResolution}" +
        $"\nUpdateFrequency: {UpdateFrequency}" +
        $"\nContrast: {Contrast}";
}