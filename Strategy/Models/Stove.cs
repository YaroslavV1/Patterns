using Strategy.Abstracts;

namespace Strategy.Models;

public class Stove : CookingEquipment
{
    public Stove()
    {
        Name = "Stove";
    }
    public override void Cook()
    {
        Console.WriteLine($"Cooking with a {Name}.");
    }
}