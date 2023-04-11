using Strategy.Abstracts;

namespace Strategy.Models;

public class Chef
{
    private CookingEquipment _cookingEquipment;

    public void SetCookingEquipment(CookingEquipment cookingEquipment)
    {
        _cookingEquipment = cookingEquipment;
        Console.WriteLine($"Installed for cooking: {_cookingEquipment.Name}");
    }

    public void Cook()
    {
        _cookingEquipment.Cook();
    }
}