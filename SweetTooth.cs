class SweetTooth : Ninja
{
    public override bool IsFull => calorieIntake >= 1500;

    public override void Consume(IConsumable item)
    {
        if (!IsFull)
        {
            int additionalCalories = 10;
            calorieIntake += item.IsSweet ? (item.Calories + additionalCalories) : item.Calories;
            ConsumptionHistory.Add(item);
            Console.WriteLine($"{item.GetInfo()} consumed.");
        }
        else
        {
            Console.WriteLine("SweetTooth is full and cannot consume more.");
        }
    }
}
