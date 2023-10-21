class Buffet
{
    public List<Food> Menu;

    //constructor
    public Buffet()
    {
        // In the Buffet class, set Menu to a hard coded list of 7 or more Food objects you instantiate manually.
        Menu = new List<Food>()
        {
            new Food("Dish1", 500, true, false),
            new Food("Dish2", 400, false, true),
            new Food("Dish3", 600, true, true),
            new Food("Dish4", 300, false, false),
            new Food("Dish5", 700, true, false),
            new Food("Dish6", 550, false, true),
            new Food("Dish7", 450, false, false)
        };
    }

    // In the Buffet class, build out a Serve method that randomly selects a Food object from the Menu list and returns the Food object.
    public Food Serve()
    {
        Random rand = new Random();
        int randomIndex = rand.Next(Menu.Count);
        return Menu[randomIndex];
    }
}