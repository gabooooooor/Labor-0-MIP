using System;
using Labor1;

class Program
{
    static void Main()
    {
        var bigBottle = new Bottle(750, "Blue", "BigWaterBottle");
        var smallBottle = new Bottle(300, "Green", "SmallWaterBottle");
        var emptyBottle = new Bottle(-1, "Clear", "EmptyBottle");

        var truck = new Truck(500, "Delivery1");

        // Try to put the big bottle in the truck (this should fail)
        truck.TryLoad(bigBottle);

        // Try to put the small bottle in the truck (this should succeed)
        truck.TryLoad(smallBottle);

        truck.TryLoad(emptyBottle);
    }
}
public class Truck
{
    // Capacity of the truck in milliliters
    public double Capacity { get; private set; }

    // Name or identifier for the truck
    public string Name { get; private set; }

    // The bottle currently loaded (null if none)
    public Bottle LoadedBottle { get; private set; }

    public Truck(double capacity, string name)
    {
        if (capacity < 0)
        {
            capacity = 0;
        }

        this.Capacity = capacity;
        this.Name = name ?? "Unnamed Truck";
    }

    // Try to load a bottle into the truck.
    // If the bottle is larger than the truck capacity, write a message and return false.
    // If it fits, store the bottle and return true.
    public bool TryLoad(Bottle bottle)
    {
        if (bottle == null)
        {
            Console.WriteLine("Hol az uveg battya?");
            return false;
        }

        if (bottle.Capacity > this.Capacity)
        {
            Console.WriteLine("Tul nagy az uveged battya");
            Console.WriteLine("Bottle: " + bottle.Name + " (" + bottle.Capacity + " ml)");
            Console.WriteLine("Truck: " + this.Name + " (" + this.Capacity + " ml)");
            return false;
        }

        this.LoadedBottle = bottle;
        Console.WriteLine("Elfert az uveged battya, ide skubizz: " + bottle.Name);
        return true;
    }
}
