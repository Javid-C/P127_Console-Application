
using P127_Console_Application.Enum;
using P127_Console_Application.Services;
using System;

namespace P127_Console_Application
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cinema Application");
            int selection;
            do
            {
                Console.WriteLine("\n1. Create Hall");
                Console.WriteLine("2. Edit Hall");
                Console.WriteLine("3. Get all halls");
                Console.WriteLine("4. Get all seats");
                Console.WriteLine("5. Reserve");
                Console.WriteLine("0. Exit");

                string strSelection = Console.ReadLine();
                bool result = int.TryParse(strSelection, out selection);

                if (result)
                {
                    switch (selection)
                    {
                        case 1:
                            MenuServices.CreateHallMenu();
                            break;
                        case 2:
                            MenuServices.EditHallMenu();
                            break;
                        case 3:
                            MenuServices.GetAllHallsMenu();
                            break;
                        case 4:
                            MenuServices.GetAllSeatsMenu();
                            break;
                        case 5:
                            MenuServices.ReserveMenu();
                            break;
                        default:
                            Console.WriteLine("Please choose valid number");
                            break;
                    }
                }
            } while (selection!=0);
        }
    }
}
