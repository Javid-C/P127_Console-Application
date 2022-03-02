using P127_Console_Application.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace P127_Console_Application.Services
{
    static class MenuServices
    {
        public static CinemaServices cinemaServices = new CinemaServices();

        public static void CreateHallMenu()
        {
            Console.WriteLine("Please choose row value");
            int row;
            string rowStr = Console.ReadLine();
            bool resultRow = int.TryParse(rowStr, out row);

            Console.WriteLine("Please choose column value");
            int col;
            string colStr = Console.ReadLine();
            bool resultCol = int.TryParse(colStr, out col);

            if (resultRow && resultCol)
            {
                Console.WriteLine("Please choose category");
                foreach (Categories c in System.Enum.GetValues(typeof(Categories)))
                {
                    Console.WriteLine($"{(int)c}. {c}");
                }
                int category;
                string catStr = Console.ReadLine();
                bool resultCat = int.TryParse(catStr, out category);
                if (resultCat)
                {
                    switch (category)
                    {
                        case (int)Categories.Sci_Fi:
                            string No = cinemaServices.CreateHall(row, col, Categories.Sci_Fi);
                            Console.WriteLine($"{No} hall succesfully created");
                            break;
                        case (int)Categories.Thriller:
                            No = cinemaServices.CreateHall(row, col, Categories.Thriller);
                            Console.WriteLine($"{No} hall succesfully created");
                            break;
                        case (int)Categories.Drama:
                            No = cinemaServices.CreateHall(row, col, Categories.Drama);
                            Console.WriteLine($"{No} hall succesfully created");
                            break;
                        case (int)Categories.Comedy:
                            No = cinemaServices.CreateHall(row, col, Categories.Comedy);
                            Console.WriteLine($"{No} hall succesfully created");
                            break;
                        case (int)Categories.Action:
                            No = cinemaServices.CreateHall(row, col, Categories.Action);
                            Console.WriteLine($"{No} hall succesfully created");
                            break;
                        case (int)Categories.Horror:
                            No = cinemaServices.CreateHall(row, col, Categories.Horror);
                            Console.WriteLine($"{No} hall succesfully created");
                            break;
                        default:
                            Console.WriteLine("Please choose valid number");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Please choose valid category");
                }
            }
            else
            {
                Console.WriteLine("Please choose correct row or column value");
            }
        }

        public static void EditHallMenu()
        {
            Console.WriteLine("Please choose hall no");
            string no = Console.ReadLine();
            Console.WriteLine("Please choose new hall no");
            string newNo = Console.ReadLine();
            cinemaServices.EditHall(no, newNo);
        }
        public static void GetAllHallsMenu()
        {
            cinemaServices.GetAllHalls();
        }
        public static void GetAllSeatsMenu()
        {
            Console.WriteLine("Please choose hall no");
            string no = Console.ReadLine();
            cinemaServices.GetAllSeats(no);
        }

        public static void ReserveMenu()
        {
            Console.WriteLine("Please enter hall no");
            string no = Console.ReadLine();
            Console.WriteLine("Please enter row that you want to reserve");
            int row;
            string rowStr = Console.ReadLine();
            bool rowResult = int.TryParse(rowStr, out row);

            Console.WriteLine("Please enter column that you want to reserve");
            int col;
            string colStr = Console.ReadLine();
            bool colResult= int.TryParse(colStr, out col);

            if(rowResult && colResult)
            {
                cinemaServices.Reserve(no, row, col);
            }
            else
            {
                Console.WriteLine("Please choose correct row or column value");
            }
        }
    }
}
