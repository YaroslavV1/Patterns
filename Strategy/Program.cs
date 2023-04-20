using System.Threading.Channels;
using Strategy.Models;

var chef = new Chef();

Console.WriteLine("\n\tStarting program!");

chef.SetCookingEquipment(new Stove());
chef.Cook();

Console.WriteLine();

chef.SetCookingEquipment(new Oven());
chef.Cook();

Console.WriteLine("\n\tEnd program!");
