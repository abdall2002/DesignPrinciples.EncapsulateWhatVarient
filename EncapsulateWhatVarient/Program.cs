Pizza pizza = Pizza.Order("Cheese");
Console.WriteLine(pizza);
Console.WriteLine("__________________________________");
Console.WriteLine("The Second Order........");
Pizza pizza2 = Pizza.Order("Chicken");
Console.WriteLine(pizza2);
class Pizza
{
    public virtual string Title => $"{nameof(Pizza)}";
    public virtual decimal Price => 10m;
    public static Pizza Order(string type)
    {
        Pizza pizza;
        if (type.Equals("Cheese"))
        {
            pizza = new Cheese();
        }
        else
        {
            pizza = new Chicken();
        }
        Prepare();
        Cook();
        Cut();
        return pizza;
    }
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