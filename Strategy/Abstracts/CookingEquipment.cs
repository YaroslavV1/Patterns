namespace Strategy.Abstracts;

public abstract class CookingEquipment
{
    public string Name { get; set; }

    public abstract void Cook();
}