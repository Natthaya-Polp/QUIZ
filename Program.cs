using System;

namespace QUIZ
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Menu();
            ChooseMenu();
        }

        public static void Menu()
        {
            Console.WriteLine("---------- Welcome to KFC! ----------");
            Console.WriteLine("Menu : Input Information(a) / KFC Information(b) / Co - Founder Information(c) / Staff Information(d) / Income and Expenses Information(e)");
            
            return Console.ReadLine();
        }

        public static void ChooseMenu()
        {
            choose = Menu();

            if (choose == "a")
            {
                Input.InputInfo();
            }
            else if (choose == "b")
            {
                KFC.PrintKFC();
            }
            else if (choose == "c")
            {
                CoFounder.PrintCoFounder();
            }
            else if (choose == "d")
            {
                Staff.PrintStaff();
            }
            else if (choose == "e")
            {
                IandE.PrintIandE();
            }
            else
            {
                throw new Exception("Please input a/b/c/d/e .");
            }
        }
    }
}
