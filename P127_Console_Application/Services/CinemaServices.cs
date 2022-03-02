using P127_Console_Application.Enum;
using P127_Console_Application.Interfaces;
using P127_Console_Application.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace P127_Console_Application.Services
{
    class CinemaServices : ICinemaServices
    {
        private List<Hall> _halls = new List<Hall>();
        public List<Hall> Halls => _halls;

        //public List<Hall> Halls
        //{
        //    get
        //    {
        //        return _halls;
        //    }
        //}

        public string CreateHall(int row, int column, Categories category)
        {
            if (row <= 0 || column <= 0)
            {
                return "Please choose valid row or column value";
            }

            Hall hall = new Hall(row, column, category);
            Halls.Add(hall);

            return hall.No;
        }

        public void EditHall(string no, string newNo)
        {
            Hall existedHall = FindHall(no);

            if (existedHall == null)
            {
                Console.WriteLine("Please choose correct hall no");
                return;
            }
            foreach (Hall hall in Halls)
            {
                if (hall.No.ToLower().Trim() == newNo.ToLower().Trim())
                {
                    Console.WriteLine($"{newNo} hall already exist");
                    return;
                }
            }
            existedHall.No = newNo.ToUpper();
            Console.WriteLine($"{no} hall succesfully change to {newNo}");
        }

        public Hall FindHall(string no)
        {
            foreach (Hall hall in Halls)
            {
                if (hall.No.ToLower().Trim() == no.ToLower().Trim())
                {
                    return hall;
                }
            }
            return null;
        }

        public void GetAllHalls()
        {
            if (_halls.Count == 0)
            {
                Console.WriteLine("There is no hall in cinema");
                return;
            }
            foreach (Hall hall in Halls)
            {
                Console.WriteLine(hall);
            }
        }

        public void GetAllSeats(string no)
        {
            Hall hall = FindHall(no);
            if (hall == null)
            {
                Console.WriteLine("Please choose valid hall no");
                return;
            }
            foreach (Seat seat in hall.Seats)
            {
                Console.WriteLine(seat);
            }
        }

        public void Reserve(string no, int row, int column)
        {
            if (string.IsNullOrEmpty(no))
            {
                Console.WriteLine("Please choose valid hall no");
                return;
            }

            if (row <= 0 || column <= 0)
            {
                Console.WriteLine("Please choose correct row or column value");
                return;
            }

            Hall hall = FindHall(no);
            if (hall == null)
            {
                Console.WriteLine($"There is no hall => {no}");
                return;
            }

            if (row > hall.Seats.GetLength(0) || column > hall.Seats.GetLength(1))
            {
                Console.WriteLine("Please choose valid row or column value");
                return;
            }

            if (!hall.Seats[row - 1, column - 1].isFull)
            {
                hall.Seats[row - 1, column - 1].isFull = true;
                Console.WriteLine("You successfully reserved seat");
            }
            else
            {
                Console.WriteLine("Already resered\n");
                GetAllSeats(no);
            }
        }
    }
}
