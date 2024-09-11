namespace ordering_system
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Drink> drinks = new List<Drink>();
            drinks.Add(new Drink( Nmae="Coke", Size="Medium", Price=30 ));
            drinks.Add(new Drink(Nmae = "Pepsi", Size = "Large", Price = 40));
            drinks.Add(new Drink(Nmae = "Sprite", Size = "Small", Price = 20));
            drinks.Add(new Drink(Nmae = "Fanta", Size = "Medium", Price = 30));
            drinks.Add(new Drink(Nmae = "Dew", Size = "Large", Price = 40));

            foreach (var drink in drinks)
            {
                Console.WriteLine(drink.Name + " " + drink.Size + " " + drink.Price);
            }
        }
    }
}
