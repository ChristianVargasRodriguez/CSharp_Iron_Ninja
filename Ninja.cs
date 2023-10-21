abstract class Ninja
{
    protected int calorieIntake;
    public List<IConsumable> ConsumptionHistory;
    
    // In the Ninja class, add a constructor that sets calorieIntake to 0 and creates a new, empty list of Food objects to FoodHistory.
    // add a constructor
    public Ninja()
    {
        calorieIntake = 0;
        ConsumptionHistory = new List<IConsumable>();
    }
    // In the Ninja class, add a public "getter" property called "IsFull" that returns a boolean based on if the Ninja's calorie intake is greater than 1200 calories.
    // add a public "getter" property called "IsFull"
    public abstract bool IsFull {get;}
    // {
    //     get
    //     {
    //         return calorieIntake > 1200;
    //     }
    // }


    public abstract void Consume(IConsumable item);



    // // Build out the Eat method of the Ninja class
    // // so that if the Ninja is not full: 
    // // it adds the calories to the calorieIntake, 
    // // it adds the food to the Food History, 
    // // and it prints out the name of the food and whether or not it is Spicy or Sweet to the console.
    // // build out the Eat method
    // public void Eat(Food item)
    // {
    //     while (!IsFull) 
    //     {
    //         calorieIntake += item.Calories;
    //         FoodHistory.Add(item);
    //         Console.WriteLine($"Ninja ate {item.Name}. Spicy: {item.IsSpicy}, Sweet: {item.IsSweet}");
    //         Console.WriteLine($"Eat Again! Calories taken: {calorieIntake}");
            
    //     }
    //     // Finish building out the Eat method of the Ninja class so that if the Ninja is full, a warning prints to the console.
    //     if (IsFull)
    //     {
    //         Console.WriteLine("WARNING! Ninja is full and cannot eat more!.");
    //         Console.WriteLine($"Calories taken: {calorieIntake}");
    //     }

    // }

}
