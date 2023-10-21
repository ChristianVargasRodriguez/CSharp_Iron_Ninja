Console.WriteLine("------------------------");
Console.WriteLine("------------------------");
Console.WriteLine("------------------------");

Buffet buffet = new Buffet();
SweetTooth sweetTooth = new SweetTooth();
SpiceHound spiceHound = new SpiceHound();

while (!sweetTooth.IsFull || !spiceHound.IsFull)
{
    // Get a random consumable from the buffet
    IConsumable item = buffet.Serve();
    
    if (item != null)
    {
        sweetTooth.Consume(item);
        spiceHound.Consume(item);
    }
}
Console.WriteLine("------------------------");

Console.WriteLine("SweetTooth consumed:");
foreach (var item in sweetTooth.ConsumptionHistory)
{
    Console.WriteLine(item.GetInfo());
}
Console.WriteLine("------------------------");

Console.WriteLine("SpiceHound consumed:");
foreach (var item in spiceHound.ConsumptionHistory)
{
    Console.WriteLine(item.GetInfo());
}

Console.WriteLine("SweetTooth consumed a total of " + sweetTooth.ConsumptionHistory.Count + " items.");
Console.WriteLine("SpiceHound consumed a total of " + spiceHound.ConsumptionHistory.Count + " items.");
Console.WriteLine("------------------------");

if (sweetTooth.ConsumptionHistory.Count > spiceHound.ConsumptionHistory.Count)
{
    Console.WriteLine("SweetTooth consumed the most items.");
}
else if (spiceHound.ConsumptionHistory.Count > sweetTooth.ConsumptionHistory.Count)
{
    Console.WriteLine("SpiceHound consumed the most items.");
}
else
{
    Console.WriteLine("Both SweetTooth and SpiceHound consumed the same number of items.");
}
