class Pizza
{
    public virtual string Title => $"{nameof(Pizza)}";
    public virtual decimal Price => 10m;
    private static void Prepare()
    {
        Console.Write("preparing...");
        Thread.Sleep(500);
        Console.WriteLine(" completed");
    }
    private static void Cook()
    {
        Console.Write("cooking...");
        Thread.Sleep(500);
        Console.WriteLine(" completed");
    }
    private static void Cut()
    {
        Console.Write("cutting and boxing...");
        Thread.Sleep(500);
        Console.WriteLine(" completed");
    }
    public override string ToString()
    {
        return $"\n{Title}" +
               $"\n\tPrice: {Price.ToString("C")}";
    }
}
class Cheese: Pizza
{
    public override string Title => $"{base.Title} {nameof(Cheese)}"; // Pizza Cheese
    public override decimal Price => base.Price + 3m;
}
class Chicken : Pizza
{
    public override string Title => $"{base.Title} {nameof(Chicken)}"; // Pizza Cheese
    public override decimal Price => base.Price + 6m;
}