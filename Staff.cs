public class StaffInfo
{
    public static void PrintStaff()
    {
        Staff[] users = InputStoreStaff();
        PrintStaffInformation(users);

        Staff[] users2 = InputDeliveryStaff();
        PrintStaffInformation(users2);
    }

    public static void PrintStaffInformation(Staff[] users) 
    {
       Array.ForEach(users, user => Console.WriteLine(Print.PrintStaffInfo()));
    }

    public static Staff[] InputStoreStaff()
    {
        Staff[] users = new Staff[3];

        for(int index = 0; index < users.Length; index++) {
            Console.WriteLine("Store Staff Information", index + 1);

            Staff user = new Staff(Input.InputName(),
            Input.InputSurname(),
            Input.InputAge(),
            Input.InputSalary());

            users[index] = user;
        }

        return users;
    }

    public static Staff[] InputDeliveryStaff()
    {
        Staff[] users2 = new Staff[2];

        for(int index = 0; index < users2.Length; index++) {
            Console.WriteLine("Delivery Staff Information", index + 1);

            Staff user = new Staff(Input.InputName(),
            Input.InputSurname(),
            Input.InputAge(),
            Input.InputSalary());

            users2[index] = user;
        }

        return users2;
    }

    public static void StaffType()
    {
        Console.WriteLine("What type of staff do you want to input information?");
        Console.Write("Store Staff(s) / Delivery Staff(d) / Back(x) : ");
        type = Console.ReadLine();

        if (type == "s")
        {
            InputStoreStaff();
        }
        else if (type == "d")
        {
            InputDeliveryStaff();
        }
        else if (type == "x")
        {
            Input.InputInfo();
        }
        else
        {
            throw new Exception("Please input s/d/x .");
        }
    }
}