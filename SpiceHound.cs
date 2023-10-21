class SpiceHound : Ninja
{
    public override bool IsFull => calorieIntake >= 1200;

    public override void Consume(IConsumable item)
    {
        if (!IsFull)
        {
            int additionalCalories = -5;
            calorieIntake += item.IsSpicy ? (item.Calories + additionalCalories) : item.Calories;
            ConsumptionHistory.Add(item);
            Console.WriteLine($"{item.GetInfo()} consumed.");
        }
        else
        {
            Console.WriteLine("SpiceHound is full and cannot consume more.");
        }
    }
}
