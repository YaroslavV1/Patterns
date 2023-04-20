using Strategy.Abstracts;

namespace Strategy.Models;

public class Oven : CookingEquipment
{
    public Oven()
    {
        Name = "Oven";
    }
    
    public override void Cook()
    {
        Console.WriteLine($"Cooking with a {Name}.");
    }
}