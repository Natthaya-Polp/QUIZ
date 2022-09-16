public class Input
{
    public static void InputInfo()
    {
        Console.WriteLine("What infomation do you want to input?");
        Console.WriteLine("KFC Information(a) / Co - Founder Information(b) / Staff Information(c) / Income and Expenses Information(d) / Back to menu (x)");

        return Console.ReadLine();
    }

    public static void ChooseInput()
        {
            choose = InputInfo();

            if (choose = "a")
            {
                KFC.InputKFCInfo();
            }
            else if (choose = "b")
            {
                CoFounder.InputCoFounder();
            }
            else if (choose = "c")
            {
                Staff.StaffType();
            }
            else if (choose = "d")
            {
                IandE.InputIandE();
            }
            else if (choose = "x")
            {
                Program.Menu();
            }
            else
            {
                throw new Exception("Please input a/b/c/d/x .");
            }
        }

    public static string InputName()
    {
        Console.Write("Input Name : ");
        return Console.ReadLine();
    }

    public static string InputSurname()
    {
        Console.Write("Input Surname : ");
        return Console.ReadLine();
    }

    public static string InputAge()
    {
        Console.Write("Input Age : ");
        return Console.ReadLine();
    }

    public static string InputID()
    {
        Console.Write("Input ID card number : ");
        return Console.ReadLine();
    }

    public static int InputSalary()
    {
        Console.Write("Input Salary : ");
        return Console.ReadLine();
    }

    public static int InputCapital()
    {
        Console.Write("Input Capital : ");
        return Console.ReadLine();
    }

    public static string InputBranchName()
    {
        Console.Write("Input Branch Name : ");
        return Console.ReadLine();
    }

    public static string InputAddress()
    {
        Console.Write("Input Address : ");
        return Console.ReadLine();
    }
}