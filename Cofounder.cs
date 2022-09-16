public class CoFounderInfo
{
    public static void PrintCoFounder()
    {
        Cofounder[] users = InputCoFounder();
        PrintCoFounderInformation(users);
    }

    public static void PrintCoFounderInformation(CoFounder[] users) 
    {
       Array.ForEach(users, user => Console.WriteLine(Print.PrintCoFounderInfo()));
    }

    public static Cofounder[] InputCofounder()
    {
        Cofounder[] users = new Cofounder[3];

        for(int index = 0; index < users.Length; index++) {
            Console.WriteLine("Co - Founder Information", index + 1);

            Cofounder user = new Cofounder(Input.InputName(),
            Input.InputSurname(),
            Input.InputID());

            users[index] = user;
        }

        return users;
    }
}