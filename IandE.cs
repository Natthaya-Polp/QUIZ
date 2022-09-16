public class IandE
{
    public static void PrintIandE()
    {

    }

    public static void InputIandE()
    {
        InputIncome();
    }

    public static void InputIncome()
    {
        Console.WriteLine("Input number of sales at the store.");
        Console.Write("Week 1 : ");
        week1 = int.Parse(Console.ReadLine());
        Console.Write("Week 2 : ");
        week2 = int.Parse(Console.ReadLine());
        Console.Write("Week 3 : ");
        week3 = int.Parse(Console.ReadLine());
        Console.Write("Week 4 : ");
        week4 = int.Parse(Console.ReadLine());

        Console.WriteLine("Input number of delivery sales.");
        Console.Write("Week 1 : ");
        dweek1 = int.Parse(Console.ReadLine());
        Console.Write("Week 2 : ");
        dweek2 = int.Parse(Console.ReadLine());
        Console.Write("Week 3 : ");
        dweek3 = int.Parse(Console.ReadLine());
        Console.Write("Week 4 : ");
        dweek4 = int.Parse(Console.ReadLine());
    }

    public static void Income()
    {
        storeincome = (week1+week2+week3+week4)*127
        deliveryincome = (dweek1+dweek2+dweek3+dweek4)*357
        Console.WriteLine("Store Income is : {0}",storeincome);
        Console.WriteLine("Delivery Income is : {0}",deliveryincome);
        Console.WriteLine("Income of this month is : {0}",storeincome+deliveryincome);
    }
}