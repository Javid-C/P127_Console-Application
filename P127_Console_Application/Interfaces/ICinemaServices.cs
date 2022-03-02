using P127_Console_Application.Enum;
using P127_Console_Application.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace P127_Console_Application.Interfaces
{
    interface ICinemaServices
    {
        public List<Hall> Halls { get;}

        public string CreateHall(int row, int column, Categories category);

        public void EditHall(string no, string newNo);

        public void GetAllHalls();

        public void GetAllSeats(string no);

        public void Reserve(string no, int row, int column);
    }
}
