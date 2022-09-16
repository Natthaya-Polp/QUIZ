public class KFC
{
    public static void PrintKFC()
    {
        cap = InputCapital();
        branch = InputBranchName();
        add = InputAddress();

        Console.WriteLine("---------- KFC Infomation ----------");
        Console.WriteLine("Capital is : {0}",cap);
        Console.WriteLine("Branch name is : {0}",branch);
        Console.WriteLine("Address is : {0}",add);
        Console.WriteLine("------------------------------------");
    }

    public static void InputKFCInfo()
    {
        Input.InputCapital();
        Input.InputBranchName();
        Input.InputAddress();
    }
}