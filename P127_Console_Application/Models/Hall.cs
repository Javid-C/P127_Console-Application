using P127_Console_Application.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace P127_Console_Application.Models
{
    class Hall
    {
        public static int count=1;
        public string No;
        public Categories Category;
        public Seat[,] Seats;

        public Hall(int row,int column, Categories category)
        {
            switch (category)
            {
                case Categories.Sci_Fi:
                    No = $"SF-{count}";
                    break;
                case Categories.Thriller:
                    No = $"T-{count}";
                    break;
                case Categories.Drama:
                    No = $"D-{count}";
                    break;
                case Categories.Comedy:
                    No = $"C-{count}";
                    break;
                case Categories.Action:
                    No = $"A-{count}";
                    break;
                case Categories.Horror:
                    No = $"H-{count}";
                    break;
                default:
                    break;
            }

            Category = category;

            Seats = new Seat[row, column];

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    Seat seat = new Seat(i+1,j +1);
                    Seats[i, j] = seat;
                }
            }
            count++;
        }
        public override string ToString()
        {
            return $"No: {No}, Category: {Category}";
        }
    }
}
